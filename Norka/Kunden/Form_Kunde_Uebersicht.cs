using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Norka.Angebote;
using Norka.Aufträge;
using Norka.Print;
using Norka.Reports;
using Norka.DB;
using System.Linq;

namespace Norka.Kunden
{
  using System.Collections.Generic;
  using Func;


  public partial class Form_Kunde_Uebersicht : Form
  {

    #region Variablen

    /// <summary>
    /// Speichert den SQL-Befehl der zuletzt durchgeführten Kundensuchanfrage.
    /// Wird für die Aktualisierung des dgrKunden-Grids benötigt.
    /// </summary>
    public string LastCustomerSearchQuery = String.Empty;

    #endregion


    #region Kontruktoren

    /// <summary>
    /// Erstellt eine neue Instanz der <see cref="Form_Kunde_Uebersicht"/> Klasse.
    /// </summary>
    public Form_Kunde_Uebersicht()
    {
      InitializeComponent();
    }

    #endregion


    #region Methoden


    /// <summary>
    /// Lädt den selektierten Kunden im dgrKunden-Grid aus der Datenbank 
    /// und erstellt eine neue Instanz der <see cref="Form_Kunde"/> Klasse zur Bearbeitung des Kunden.
    /// </summary>
    private void EditKunde()
    {
      // Selektierte Zeile im dgrKunden-Grid ermitteln.
      DataGridViewRow dr = dgrKunden.CurrentRow;

      using (var dbContext = new DataBaseDataContext())
      {
        if (dr != null)
        {
          // Selektierten Kunden aus DB ermitteln.
          var kunde = dbContext.Kunde.Where(c => c.KundeID.Equals(dr.Cells["KundeID"].Value)).FirstOrDefault();

          // Kundenobjekt an Form_Kunde Instanz übergeben.
          Func.FKunde = new Form_Kunde(kunde);
          Func.FKunde.btnKundeAnl.Enabled = false;
          Func.FKunde.ShowDialog();
        }
      }
    }

    /// <summary>
    /// Erstellt ein neues Angebot mit den Daten ds selektieren Kunden.
    /// </summary>
    private void CreateAngebot()
    {
      DataGridViewRow dr = dgrKunden.CurrentRow;

      try
      {
        if (dr != null) // sicherstellen, dass ein Kunde selektiert wurde.
        {
          if (dr.Cells["Status"].Value.ToString() != "gesperrt") // selektiertert Kunde darf nicht gesperrt sein.
          {
            if (Func.FAngebot == null)
            {
              Func.FAngebot = new Form_Angebot();
              Func.FAngebot.MdiParent = Func.FStart;
              Func.FAngebot.Text = "Angebot";
              Func.FAngebot.tbxKdNummer.Text = dr.Cells["KundeID"].Value.ToString();
              Func.FAngebot.Show();
              Func.FAngebot.WindowState = FormWindowState.Maximized;
            }
          }
          else
          {
            MessageBox.Show("Sie können mit diesem Kunden kein Angebot erstellen.\nDieser Kunde ist gesperrt.", "Achtung", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    /// <summary>
    /// Erstellt einen neuen Auftrag mit den Daten ds selektieren Kunden.
    /// </summary>
    private void CreateAuftrag()
    {
      DataGridViewRow dr = dgrKunden.CurrentRow;

      try
      {
        if (dr != null)
        {
          if (dr.Cells["Status"].Value.ToString() != "gesperrt") // Kunde ist nicht gesperrt
          {
            if (Func.FAuftrag == null)
            {
              Func.FAuftrag = new Form_Auftrag();
              Func.FAuftrag.MdiParent = Func.FStart;
              Func.FAuftrag.Text = "Auftrag";
              Func.FAuftrag.tbxKdNummer.Text = dr.Cells["KundeID"].Value.ToString();
              Func.FAuftrag.Show();
              Func.FAuftrag.WindowState = FormWindowState.Maximized;
            }
          }
          else
          {
            MessageBox.Show("Sie können mit diesem Kunden keinen Auftrag erstellen.\nDieser Kunde ist gesperrt.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
      }
      catch (Exception ex)
      {

        MessageBox.Show(ex.ToString());
      }
    }

    /// <summary>
    /// Löscht den selektierten Kunden im dgrKunden-Grid aus der Datenbank. 
    /// </summary>
    private void DeleteKunde()
    {
      DataGridViewRow dr = dgrKunden.CurrentRow;

      if (dr != null) // sicherstellen, dass ein Kunde selektiert wurde.
      {
        DialogResult result = MessageBox.Show("Möchten Sie diesen Kunden wirklich löschen?", "Kunden löschen",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        if (result == DialogResult.Yes)
        {
          using (var dbContext = new DataBaseDataContext())
          {
            var kunde = dbContext.Kunde.Where(cust => cust.KundeID.Equals(dr.Cells["KundeID"].Value)).FirstOrDefault();

            dbContext.Kunde.DeleteOnSubmit(kunde);

            try
            {
              dbContext.SubmitChanges();
            }
            catch (SqlException ex)
            {
              if (ex.Number == 547) // Verletzung der Foreign-Key REFERENCE-Einschränkung
              {
                if (ex.Message.Contains("FK_Auftrag_Kunde"))
                {
                  MessageBox.Show("Dieser Kunde kann nicht gelöscht werden, da ihm noch Aufträge zugeordnet sind.", "Kunde löschen.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (ex.Message.Contains("FK_Angebot_Kunde"))
                {
                  MessageBox.Show("Dieser Kunde kann nicht gelöscht werden, da ihm noch Angebote zugeordnet sind.", "Kunde löschen", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

              }
            }
          }
          Func.FUebersicht.tsItemAkualisieren.PerformClick(); // aktualisieren des dgrKunden-Grids.
        }
      }
    }

    /// <summary>
    /// Aktualisiert das dgrKunden-Grid
    /// </summary>
    private void RefreshKundenGrid()
    {
      if (LastCustomerSearchQuery != String.Empty)
      {
        Func.FUebersicht.slKunde.Text = "";
        using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
        {
          var command = new SqlCommand(LastCustomerSearchQuery, sqlconnection);
          var adapter = new SqlDataAdapter(command);
          var table = new DataTable();
          Func.FUebersicht.slKunde.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
          Func.FUebersicht.dgrKunden.DataSource = table;
        }
      }

    }

  

    #endregion


    #region Events

    private void itemKundeSch_Click(object sender, EventArgs e)
    {
      this.Close();
      Func.FUebersicht = null;
    }

    private void dgrKunden_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      if (dgrKunden.Rows.Count > 0)
      {
        // Für Kundensuche - wenn Kunden gefunden wurden Buttons verfügbar machen.
        tsItemAngebotErstellen.Enabled = true;
        tsItemAuftragErstellen.Enabled = true;
        tsItemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrKunden) == 0 ? false : true;
        tsItemKundeBearbeiten.Enabled = true;
        tsItemKundeLoeschen.Enabled = true;
        tsItemAkualisieren.Enabled = true;
        tsItemAllMark.Enabled = true;
        tsItemKeineMark.Enabled = true;
      }
      
    }

    private void dgrKunden_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (dgrKunden.Rows.Count == 0)
      {
        tsItemAngebotErstellen.Enabled = false;
        tsItemAuftragErstellen.Enabled = false;
        tsItemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrKunden) == 0 ? false : true;
        tsItemKundeBearbeiten.Enabled = false;
        tsItemKundeLoeschen.Enabled = false;
        tsItemAkualisieren.Enabled = false;
        tsItemAllMark.Enabled = false;
        tsItemKeineMark.Enabled = false;
      }
    }

    private void dgrKunden_MouseDown(object sender, MouseEventArgs e)
    {
      // Zeilenmarkierung bei Rechtsklick ermöglichen.
      DataGridView.HitTestInfo hti = dgrKunden.HitTest(e.X, e.Y);
      if (hti.Type == DataGridViewHitTestType.Cell)
      {
        dgrKunden.CurrentCell = dgrKunden[hti.ColumnIndex, hti.RowIndex];
      }
    }

    private void ctmKundenGrid_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (Func.FAngebot != null)
      {
        ctmAngebotErstellen.Enabled = false;
        ctmAngebotErstellen.ToolTipText =
            "Es ist bereits ein Angebotsfenster geöffnet. Es kann nur ein Fenster geöffnet sein.";
      }
      else if (Func.FAngebot == null)
      {
        ctmAngebotErstellen.Enabled = true;
        ctmAngebotErstellen.ToolTipText = "Mit diesem Kunden ein Angebot erstellen.";
      }

      var row = dgrKunden.CurrentRow;

      if (row != null)
      {

        ctmDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrKunden) == 0 ? false : true;
      }

    }

    private void tsItemAngebotErstellen_Click(object sender, EventArgs e)
    {
      CreateAngebot();
    }

    private void ctmAngebotErstellen_Click(object sender, EventArgs e)
    {
      CreateAngebot();
    }

    private void tsItemKundeAuswahl_Click(object sender, EventArgs e)
    {
      Form_Kunde_Auswahl ka = new Form_Kunde_Auswahl();
      ka.ShowDialog();
    }

    private void tsItemKundeNeu_Click(object sender, EventArgs e)
    {
      Func.FKunde = new Form_Kunde();
      Func.FKunde.btnAenderungSp.Enabled = false;
      Func.FKunde.ShowDialog();
    }

    private void tsItemKundeBearbeiten_Click(object sender, EventArgs e)
    {
      EditKunde();
    }

    private void tsItemKundeLoeschen_Click(object sender, EventArgs e)
    {
      DeleteKunde();
    }

    private void tsItemAuftragErstellen_Click(object sender, EventArgs e)
    {
      CreateAuftrag();
    }

    private void tsItemAkualisieren_Click(object sender, EventArgs e)
    {
      RefreshKundenGrid();
    }

    private void ctmAuftragErstellen_Click(object sender, EventArgs e)
    {
      CreateAuftrag();
    }

    private void ctmKundeBearbeiten_Click(object sender, EventArgs e)
    {
      EditKunde();
    }

    private void ctmKundeLoeschen_Click(object sender, EventArgs e)
    {
      DeleteKunde();
    }

    

    private void tsItemDruckenDatenblattVorschau_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      //Alle angezeigten KundenID's auslesen.
      List<int> data = new List<int>();

      foreach (DataGridViewRow row in dgrKunden.Rows)
      {
        DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

        if (cell.Value != null)
        {
          data.Add((int)row.Cells["KundeID"].Value);
        }
      }

      var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Kundendatenblatt, data);
      var r = new Form_Report(report);
      r.Show();
      r.Refresh();
      this.Cursor = Cursors.Default;
    }

    private void tsItemDruckenDatenblattSofortdruck_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      //Alle angezeigten KundenID's auslesen.
      List<int> data = new List<int>();

      foreach (DataGridViewRow row in dgrKunden.Rows)
      {
        DataGridViewCheckBoxCell cell = row.Cells[0] as DataGridViewCheckBoxCell;

        if (cell.Value != null)
        {
          data.Add((int)row.Cells["KundeID"].Value);
        }
      }

      
      PrintManager.PrintDirectlyWithDialog(EReports.Kundendatenblatt, data);

      this.Cursor = Cursors.Default;
    }

    #endregion

    private void tsItemDruckenAbsageProgramm_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      //ID des ausgewählten Kunden auslesen.-->
      List<int> data = new List<int>();

      DataGridViewRow row = dgrKunden.CurrentRow;

      data.Add((int)row.Cells["KundeID"].Value);
      //<--

      Func.FBrief = new Form_Brief(EReports.AbsageProgramm, data);
      Func.FBrief.StartPosition = FormStartPosition.CenterScreen;
      Func.FBrief.Show();
     
      this.Cursor = Cursors.Default;
    }

    private void tsItemDruckenAbsageWirkungskreis_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      //ID des ausgewählten Kunden auslesen.-->
      List<int> data = new List<int>();

      DataGridViewRow row = dgrKunden.CurrentRow;

      data.Add((int)row.Cells["KundeID"].Value);


      Func.FBrief = new Form_Brief(EReports.AbsageWirkungskreis, data);
      Func.FBrief.StartPosition = FormStartPosition.CenterScreen;
      Func.FBrief.Show();

      this.Cursor = Cursors.Default;

    }

    private void dgrKunden_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      var row = dgrKunden.CurrentRow;

      if (row != null)
      {
        if (dgrKunden.CurrentCell == row.Cells[0])
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
          tsItemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrKunden) == 0 ? false : true;
        }
      }
    }

    private void dgrKunden_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var row = dgrKunden.CurrentRow;

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
        tsItemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrKunden) == 0 ? false : true;
      }
    }

    private void itemAllMark_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgrKunden.Rows)
      {
        var cell = row.Cells[0] as DataGridViewCheckBoxCell;

        if (cell != null)
        {
          cell.Value = true;
        }
      }
      tsItemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrKunden) == 0 ? false : true;
    }

    private void itemKeineMark_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgrKunden.Rows)
      {
        var cell = row.Cells[0] as DataGridViewCheckBoxCell;

        if (cell != null)
        {
          cell.Value = null;
        }
      }
      tsItemDrucken.Enabled = Func.GetDataGridViewMarkedRows(dgrKunden) == 0 ? false : true;
    }

    private void tsItemBrief_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      //ID des ausgewählten Kunden auslesen.-->
      List<int> data = new List<int>();

      DataGridViewRow row = dgrKunden.CurrentRow;

      data.Add((int)row.Cells["KundeID"].Value);


      Func.FBrief = new Form_Brief(EReports.Brief, data);
      Func.FBrief.StartPosition = FormStartPosition.CenterScreen;
      Func.FBrief.Show();

      this.Cursor = Cursors.Default;
    }

   

  }
}