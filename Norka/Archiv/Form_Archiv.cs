using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Norka.Print;
using Norka.Rechnungen;


namespace Norka.Archiv
{
  using System.Collections.Generic;
  using System.Linq;
  using Angebote;
  using Func;
  using DB;
  using Reports;
  using Aufträge;

  /// <summary>
  /// 
  /// </summary>
  public partial class Form_Archiv : Form
  {
    #region Variablen
    /// <summary>
    /// Speichert den SQL-Befehl der zuletzt durchgeführten Suche/Auswahl.
    /// Wird für den Aktualisieren-Button benötigt, damit dieser weiß, welche angezeigte Daten aktualisert werden sollen.
    /// </summary>
    public String Query = String.Empty;

    /// <summary>
    /// Kennzeichen ob im Result-Grid zurzeit Rechnungen angezeigt werden,
    /// </summary>
    private bool isRechnungenSelected = false;

    private string module;

    #endregion


    #region Kontruktoren

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="Form_Archiv"/> Klasse.
    /// </summary>
    public Form_Archiv()
    {
      InitializeComponent();
    }

    #endregion


    #region Methoden



    /// <summary>
    /// Löscht das selektierte Angebot aus der DB.
    /// Es findet eine Prüfung statt, ob zu dem zu löschenden Angebot Positionen vorhanden sind
    /// und ob bereits Aufträge zu dem Angebot vorhanden sind.
    /// </summary>
    private void DeleteAngebot()
    {
      this.Cursor = Cursors.WaitCursor;

      DataGridViewRow dr = dgrResults.CurrentRow;

      if (dr != null)
      {
        var selectedAngebotNr = (int)dr.Cells["AngebotID"].Value;

        DialogResult resultAngebotLoeschen = MessageBox.Show(String.Format("Möchten Sie das Angebot {0} wirklich löschen?", selectedAngebotNr.ToString()), "Bestätigung.", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                           MessageBoxDefaultButton.Button1);

        if (resultAngebotLoeschen == DialogResult.Yes)
        {
          using (var dbContext = new DataBaseDataContext())
          {
            // Zu löschendes Angebotobjekt wird aus der DB geladen.
            var angebot = dbContext.Angebot.Where(ang => ang.AngebotID.Equals(selectedAngebotNr)).FirstOrDefault();

            // Alle Positionen zu dem zu löschenden Angebot werden aus der DB geladen.
            var angPositionen = dbContext.Angebot_Position.Where(ap => ap.AngebotID.Equals(angebot.AngebotID));

            // Angebot wird gelöscht
            dbContext.Angebot.DeleteOnSubmit(angebot);

            try
            {
              // Änderungen an DB übermitteltn.
              dbContext.SubmitChanges();
              AnzeigeAktualisieren();
            }
            catch (SqlException ex)
            {
              if (ex.Number == 547)
              {
                DialogResult resultPositionenLoeschen = MessageBox.Show(String.Format("Das Angebot {0} enthält noch Positionen.\nMöchten Sie dieses Angebot und alle dazugehörigen Positionen löschen?", selectedAngebotNr.ToString()), "Bestätigung",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultPositionenLoeschen == DialogResult.Yes)
                {
                  if (angPositionen.Count() > 0)
                  {
                    // Prüfung ob zu irgendwelchen Angebotspositionen schon Aufträge existieren.
                    // Es wird die Anzahl der Angebotspositionen ermittelt, denen bereits eine Auftrag zugeordnet ist.
                    if (angPositionen.Count(ap => ap.AuftragID != null) > 0)
                    {
                      MessageBox.Show(String.Format("Zu dem  Angebot {0} existieren bereits Aufträge.\nSie müssen zuerst die Aufträge löschen.", selectedAngebotNr.ToString()),
                                                         "Bestätigung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                      try
                      {
                        // Alle Angebotspositionen zu dem zu löschen Angebot löschen.
                        foreach (Angebot_Position pos in angPositionen)
                        {
                          dbContext.Angebot_Position.DeleteOnSubmit(pos);
                        }

                        dbContext.SubmitChanges();
                        AnzeigeAktualisieren();
                      }
                      catch (Exception ex1)
                      {
                        MessageBox.Show("Eine oder mehrere Angebotspositionen konnte(n) nicht gelöscht werden.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Löscht den selektierten Auftrag aus der DB.
    /// Es findet eine Prüfung statt, ob zu dem zu löschenden Auftrag Positionen vorhanden sind.
    /// </summary>
    private void DeleteAuftrag()
    {
      this.Cursor = Cursors.WaitCursor;

      DataGridViewRow dr = dgrResults.CurrentRow;

      if (dr != null)
      {
        var selectedAuftragNr = (int)dr.Cells["AuftragID"].Value;

        DialogResult resultAuftragLoeschen = MessageBox.Show(String.Format("Möchten Sie den Auftrag {0} wirklich löschen?", selectedAuftragNr.ToString()), "Bestätigung.", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                              MessageBoxDefaultButton.Button1);

        if (resultAuftragLoeschen == DialogResult.Yes)
        {
          using (var dbContext = new DataBaseDataContext())
          {
            // Das zu löschende Auftragsobjekt aus der DB ermitteln.
            var auftrag = dbContext.Auftrag.Where(auf => auf.AuftragID.Equals(selectedAuftragNr)).FirstOrDefault();

            // Sämtliche Auftragspositionen, die zu dem Auftragsobjekt gehören, aus der DB ermitteln.
            var positionen = dbContext.Auftrag_Position.Where(ap => ap.AuftragID.Equals(auftrag.AuftragID));

            // Sämtliche Angebotspositionen, zu denen eine Referenz zum zu löschenden Auftragsobjekt vorhanden ist, aus der DB ermitteln.
            var angPositionen = dbContext.Angebot_Position.Where(angp => angp.AuftragID.Equals(auftrag.AuftragID));

            try
            {
              dbContext.Auftrag.DeleteOnSubmit(auftrag);
              dbContext.SubmitChanges();
              AnzeigeAktualisieren();
            }
            catch (SqlException ex)
            {
              if (ex.Number == 547)
              {
                DialogResult resultPositionLoeschen =
                  MessageBox.Show(String.Format(
                    "Der Auftrag {0} enthält noch Positionen.\nMöchten Sie diesen Auftrag und alle dazugehörigen Positionen löschen?\n\nAngebotspositionen, die zu diesem Auftrag gehören, werden wieder frei.", selectedAuftragNr.ToString()),
                    "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultPositionLoeschen == DialogResult.Yes)
                {
                  // Hat die Angebotsposition im Feld "AuftragID" einen Wert, so ist eine Auftragreferenz vorhanden.
                  // Diese wird entfernt, indem in das Feld "AuftragID" NULL gespeichert wird.
                  if (angPositionen.Count() > 0)
                  {
                    try
                    {
                      foreach (Angebot_Position pos in angPositionen)
                      {
                        if (pos.AuftragID != null)
                        {
                          pos.AuftragID = null;
                        }
                      }
                    }
                    catch (Exception ex1)
                    {
                      MessageBox.Show(ex1.ToString());
                    }
                  }

                  try
                  {
                    foreach (Auftrag_Position pos in positionen)
                    {
                      dbContext.Auftrag_Position.DeleteOnSubmit(pos);
                    }
                    dbContext.SubmitChanges();
                    AnzeigeAktualisieren();
                  }
                  catch (SqlException ex1)
                  {
                    MessageBox.Show("Eine oder mehrere Auftragspositionen konnte(n) nicht gelöscht werden.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  }
                }
              }
            }
          }
        }
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Öffnet das selektierte Angebot.
    /// </summary>
    private void OpenAngebot()
    {
      this.Cursor = Cursors.WaitCursor;
      DataGridViewRow currentRow = dgrResults.CurrentRow;

      if (currentRow != null)
      {
        // Angebotsform ist noch nicht geöffnet.
        if (Func.FAngebot == null)
        {
          Func.FAngebot = new Form_Angebot();
          Func.FAngebot.MdiParent = Func.FStart;

          Func.FAngebot.Text = "Angebot";
          Func.FAngebot.Show();
          Func.FAngebot.WindowState = FormWindowState.Maximized;
          Func.FAngebot.tbxAngNummer.Text = currentRow.Cells["AngebotID"].Value.ToString();
          Func.FAngebot.tbxKdNummer.Text = currentRow.Cells["KundeID"].Value.ToString();
        }
        else // Angebotsform ist bereits geöffnet.
        {
          Func.FAngebot.Show();
          Func.FAngebot.WindowState = FormWindowState.Maximized;
          Func.FAngebot.tbxAngNummer.Text = currentRow.Cells["AngebotID"].Value.ToString();
          Func.FAngebot.tbxKdNummer.Text = currentRow.Cells["KundeID"].Value.ToString();
        }
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Öffnet den selektieren Auftrag.
    /// </summary>
    private void OpenAuftrag()
    {
      this.Cursor = Cursors.WaitCursor;
      DataGridViewRow currentRow = dgrResults.CurrentRow;

      if (currentRow != null)
      {
        // Auftragsform ist noch nicht geöffnet.
        if (Func.FAuftrag == null)
        {
          Func.FAuftrag = new Form_Auftrag();
          Func.FAuftrag.MdiParent = Func.FStart;

          Func.FAuftrag.Text = "Auftrag";
          Func.FAuftrag.Show();
          Func.FAuftrag.WindowState = FormWindowState.Maximized;
          Func.FAuftrag.tbxAufNummer.Text = currentRow.Cells["AuftragID"].Value.ToString();
          Func.FAuftrag.tbxKdNummer.Text = currentRow.Cells["KundeID"].Value.ToString();
        }
        else // Auftragsform ist bereits geöffnet.
        {
          Func.FAuftrag.Show();
          Func.FAuftrag.WindowState = FormWindowState.Maximized;
          Func.FAuftrag.tbxAufNummer.Text = currentRow.Cells["AuftragID"].Value.ToString();
          Func.FAuftrag.tbxKdNummer.Text = currentRow.Cells["KundeID"].Value.ToString();
        }
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Öffnet die selektiere Rechnung
    /// </summary>
    private void OpenRechnung()
    {
      this.Cursor = Cursors.WaitCursor;
      DataGridViewRow currentRow = dgrResults.CurrentRow;

      if (currentRow != null)
      {
        // Rechnungsform ist noch nicht geöffnet.
        if (Func.FRechnung == null)
        {
          Func.FRechnung = new Form_Rechnung();
          Func.FRechnung.MdiParent = Func.FStart;

          Func.FRechnung.Show();
          Func.FRechnung.tbxRechNummer.DeselectAll();
          Func.FRechnung.WindowState = FormWindowState.Maximized;
          Func.FRechnung.Text = "Rechnung";
          Func.FRechnung.tbxRechNummer.Text = currentRow.Cells["RechnungID"].Value.ToString();
          Func.FRechnung.tbxKdNummer.Text = currentRow.Cells["KundeID"].Value.ToString();

        }
        else // Rechnungsform ist bereits geöffnet.
        {
          Func.FRechnung.Show();
          Func.FRechnung.tbxRechNummer.DeselectAll();
          Func.FRechnung.WindowState = FormWindowState.Maximized;
          Func.FRechnung.tbxRechNummer.Text = currentRow.Cells["RechnungID"].Value.ToString();
          Func.FRechnung.tbxKdNummer.Text = currentRow.Cells["KundeID"].Value.ToString();

        }
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Öffnet den gewählten Bericht in der Vorschau-ANzeige.
    /// </summary>
    private void PrintVorschau()
    {
      this.Cursor = Cursors.WaitCursor;
      Form_Report r;

      List<int> data = new List<int>();

      switch (module)
      {
        case "Angebote":
          {
            foreach (DataGridViewRow row in dgrResults.Rows)
            {
              DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

              if (cell.Value != null)
              {
                data.Add((int)row.Cells["AngebotID"].Value);
              }
            }
            //data.Add((int)row.Cells[0].Value);

            var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Angebot, data);
            r = new Form_Report(report);
            r.Show();
            r.Refresh();
          }
          break;
        case "Aufträge":
          {
            foreach (DataGridViewRow row in dgrResults.Rows)
            {

              DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

              if (cell.Value != null)
              {
                data.Add((int)row.Cells["AuftragID"].Value);
              }
            }
            //data.Add((int)row.Cells[0].Value);

            var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Auftragsbestätigung, data);
            r = new Form_Report(report);
            r.Show();
            r.Refresh();
          }
          break;
        case "Rechnungen":
          {
            foreach (DataGridViewRow row in dgrResults.Rows)
            {

              DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

              if (cell.Value != null)
              {
                data.Add((int)row.Cells["RechnungID"].Value);
              }
            }
            //data.Add((int)row.Cells[0].Value);

            var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Rechnung, data);
            r = new Form_Report(report);
            r.Show();
            r.Refresh();
          }
          break;
      }
      this.Cursor = Cursors.Default;
    }




    /// <summary>
    /// Druckt den gewählten Bericht direkt auf dem Windows-Standarddrucker
    /// </summary>
    private void PrintSofort()
    {
      this.Cursor = Cursors.WaitCursor;

      switch (module)
      {
        case "Angebote":
          PrintManager.PrintDirectlyWithDialog(EReports.Angebot, new List<int>() { 1, (int)dgrResults.CurrentRow.Cells["AngebotID"].Value });
          break;
        case "Aufträge":
          PrintManager.PrintDirectlyWithDialog(EReports.Auftragsbestätigung, new List<int>() { 1, (int)dgrResults.CurrentRow.Cells["AuftragID"].Value });
          break;
        case "Rechnungen":
          PrintManager.PrintDirectlyWithDialog(EReports.Rechnung, new List<int>() { 1, (int)dgrResults.CurrentRow.Cells["RechnungID"].Value });
          break;
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Öffnet den gewählten Bericht im dem hinterlegten Fax-Drucker
    /// </summary>
    private void Fax()
    {
      this.Cursor = Cursors.WaitCursor;

      switch (module)
      {
        case "Angebote":
          PrintManager.Fax(EReports.Angebot, new List<int>() { 1, (int)dgrResults.CurrentRow.Cells["AngebotID"].Value });
          break;
        case "Aufträge":
          PrintManager.Fax(EReports.Auftragsbestätigung, new List<int>() { 1, (int)dgrResults.CurrentRow.Cells["AuftragID"].Value });
          break;
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Aktualisiert die Anzeige des DataGrid
    /// </summary>
    public void AnzeigeAktualisieren()
    {
      this.Cursor = Cursors.WaitCursor;
      Func.FArchiv.slArchiv.Text = "";
      if (Query != "")
      {
        using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
        {
          var command = new SqlCommand(Query, sqlconnection);
          var adapter = new SqlDataAdapter(command);
          var table = new DataTable();
          //adapter.Fill(table);
          Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
          Func.FArchiv.dgrResults.Columns.Clear();
          Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
          Func.FArchiv.dgrResults.DataSource = table;

        }
        StornoKennzeichnen();
      }
      this.Cursor = Cursors.Default;
    }






    /// <summary>
    /// Kennzeichnet alle stornieren Rechnungen und die dazugehörigen Storno-Rechnungen farblich.
    /// </summary>
    public void StornoKennzeichnen()
    {
      if (isRechnungenSelected)
      {
        var stornoIDs = new List<DataGridViewRow>();

        foreach (DataGridViewRow row in this.dgrResults.Rows)
        {
          if ((row.Cells["StornoID"].Value != null) && (row.Cells["StornoID"].Value != DBNull.Value))
          {
            stornoIDs.Add(row);
            row.DefaultCellStyle.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
            row.DefaultCellStyle.ForeColor = Color.Red;
          }
        }

        foreach (DataGridViewRow r in this.dgrResults.Rows)
        {
          foreach (DataGridViewRow iD in stornoIDs)
          {
            if (r.Cells["RechnungID"].Value.ToString() == iD.Cells["StornoID"].Value.ToString())
            {
              r.DefaultCellStyle.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
              r.DefaultCellStyle.ForeColor = Color.Red;
            }
          }

        }
      }

    }

    #endregion


    #region Events

    private void Form_Archiv_Load(object sender, EventArgs e)
    {
      trvKategorie.ExpandAll();
    }

    private void itemArchivSch_Click(object sender, EventArgs e)
    {
      this.Close();
      Func.FArchiv = null;
    }

    private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      itemLoeschen.PerformClick();
    }

    private void itemLoeschen_Click(object sender, EventArgs e)
    {
      switch (module)
      {
        case "Angebote":
          DeleteAngebot();
          break;
        case "Aufträge":
          DeleteAuftrag();
          break;
      }
    }

    private void dgrKunden_MouseDown(object sender, MouseEventArgs e)
    {
      // Zeilenmarkierung bei Rechtsklick ermöglichen.
      DataGridView.HitTestInfo hti = dgrResults.HitTest(e.X, e.Y);

      if (hti.Type == DataGridViewHitTestType.Cell)
      {
        dgrResults.CurrentCell = dgrResults[hti.ColumnIndex, hti.RowIndex];
      }
    }

    private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      itemAnzeigen.PerformClick();
    }

    private void itemAnzeigen_Click(object sender, EventArgs e)
    {
      switch (module)
      {
        case "Angebote":
          OpenAngebot();
          break;
        case "Aufträge":
          OpenAuftrag();
          break;
        case "Rechnungen":
          OpenRechnung();
          break;
      }
    }

    private void vorschauToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PrintVorschau();
    }

    private void sofortdruckToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PrintSofort();
    }

    private void faxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Fax();
    }

    private void itemAktualisieren_Click(object sender, EventArgs e)
    {
      AnzeigeAktualisieren();
    }

    private void itemAlleMarkieren_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgrResults.Rows)
      {
        var cell = row.Cells[0] as DataGridViewCheckBoxCell;

        if (cell != null)
        {
          cell.Value = true;
        }
      }
      itemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrResults) == 0 ? false : true;
    }

    private void itemKeineMarkieren_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgrResults.Rows)
      {
        var cell = row.Cells[0] as DataGridViewCheckBoxCell;

        if (cell != null)
        {
          cell.Value = null;
        }
      }
      itemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrResults) == 0 ? false : true;
    }

    private void ctmArchivGrid_Opened(object sender, EventArgs e)
    {
      var row = dgrResults.CurrentRow;

      if (row != null)
      {
        anzeigenToolStripMenuItem.Enabled = true;

        löschenToolStripMenuItem.Enabled = trvKategorie.SelectedNode.Text != "Rechnungen";

        druckenToolStripMenuItem.Enabled = Func.GetDataGridViewMarkedRows(dgrResults) == 0 ? false : true;
      }
      else
      {
        anzeigenToolStripMenuItem.Enabled = false;
      }
    }

    private void dgrResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var row = dgrResults.CurrentRow;

      if (row != null)
      {
        var cell = row.Cells[0] as DataGridViewCheckBoxCell;

        if (cell != null)
        {
          if (cell.Value == null)
          {
            cell.Value = true;
          }
          else
          {
            cell.Value = null;
          }
        }
        itemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrResults) == 0 ? false : true;
      }
    }

    private void dgrResults_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var row = dgrResults.CurrentRow;

      if (row != null)
      {
        if (dgrResults.CurrentCell == row.Cells[0])
        {
          var cell = row.Cells[0] as DataGridViewCheckBoxCell;

          if (cell != null)
          {
            if (cell.Value == null)
            {
              cell.Value = true;
            }
            else
            {
              cell.Value = null;
            }
          }
          itemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrResults) == 0 ? false : true;
        }
      }
    }

    private void dgrResults_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      itemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrResults) == 0 ? false : true;
    }

    private void trvKategorie_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      module = e.Node.Text;
      switch (module)
      {
        case "Angebote":
          itemLoeschen.Enabled = true;
          itemAnzeigen.Enabled = true;
          isRechnungenSelected = false;
          break;
        case "Aufträge":
          itemLoeschen.Enabled = true;
          itemAnzeigen.Enabled = true;
          isRechnungenSelected = false;
          break;
        case "Rechnungen":
          itemLoeschen.Enabled = false;
          isRechnungenSelected = true;
          break;
      }

      using (var f = new Form_Archiv_Auswahl())
      {
        f.Text = String.Format("Auswahl {0}", e.Node.Text);
        f.Controls[string.Format("pnl{0}", e.Node.Text)].Visible = true;
        f.ShowDialog();
      }

    }

    #endregion

    private void dgrResults_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      //Bisher verloren alle Stornos die farbige Kennzeichnung nachdem auf einen ColumnHeader geklickt wurde. Fixed!
      StornoKennzeichnen();
    }









  }
}