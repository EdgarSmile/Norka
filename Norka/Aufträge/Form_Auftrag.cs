
using Norka.Print;

namespace Norka.Aufträge
{
  using Func;
  using System;
  using System.Collections.Generic;
  using System.Windows.Forms;
  using Reports;
  using Exception = System.Exception;
  using System.Drawing;
  using Norka.DB;
  using System.Linq;
  using Norka.Rechnungen;
  using Norka.Kunden;

  using Norka.Common;
  public partial class Form_Auftrag : Form
  {
    private decimal PositionSumme;
    private decimal Nachlass;
    private decimal Steuer;
    private decimal Gesamt;

    public bool changesDone = false;

    private static log4net.ILog Log = log4net.LogManager.GetLogger("Form_Auftrag");


    private int selectedRows = 0;

    // Flag ob bereits eine Rechnung für den Auftrag (oder eine Auftragsposition) vorhanden ist
    private bool isRechnungExisting = false;

    public Form_Auftrag()
    {
      InitializeComponent();
      log4net.Config.XmlConfigurator.Configure();
    }

    private void Auftrag_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsSteuer.Steuer". Sie können sie bei Bedarf verschieben oder entfernen.
      this.steuerTableAdapter.Fill(this.dsSteuer.Steuer);
      //Wenn dieser Block nicht auskommentiert wird, werden die Angebotsdaten nicht richtig aus der Datenbank geladen.

      //cobTyp.SelectedIndex = 0;
      //cobBetreff.SelectedIndex = 0;
      //cobMwSt.SelectedIndex = 0;
      //cobNachlass.SelectedIndex = 0;
      //Func.LoadAngebotSumme();
      //cobBetreff.SelectedIndex = 0;
      cobMwSt.SelectedValue = 0;
      //cobNachlass.SelectedIndex = 0;
      //cobSkonto.SelectedIndex = 0;
      //cobTyp.SelectedIndex = 0;
    }

    //Behandlung der tbxEigenerText
    private void cobTyp_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cobTyp.SelectedItem.ToString() == "Eigener Text")
      {
        tbxEigenerText.Enabled = true;
        tbxEigenerText.BackColor = Func.CEnabled;
      }
      else if (cobTyp.SelectedItem.ToString() == "Neutral")
      {
        tbxSondertext.Text = "Sehr geehrte Damen und Herren," + Environment.NewLine + Environment.NewLine + "anbei erhalten Sie unser Angebot zu Ihrer gefälligen Verwendung.";
      }
      else
      {
        tbxEigenerText.Enabled = false;
        tbxEigenerText.BackColor = Func.CDisabled;
        tbxEigenerText.Text = "";
      }

      changesDone = true;
    }


    //Schließen des Autragfensters
    private void itemClose_Click(object sender, EventArgs e)
    {
      //if (btnEdit.Enabled == false & tbxAufNummer.Text != "")
      //{
      Func.FAuftrag = null;
      this.Close();
      //}
      //else if (IsDefault() == false)
      //{
      //  DialogResult result = MessageBox.Show("Es sind noch nicht gespeicherte Änderungen vorhanden.\nMöchten Sie die Änderungen speichern?", "Bestätigung.",
      //                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

      //  switch (result)
      //  {
      //    case DialogResult.Yes:
      //      if (tbxKdNummer.Text != "")
      //      {
      //        btnAnlegen.PerformClick();
      //        changesDone = false;
      //        Func.FAuftrag = null;
      //        this.Close();
      //      }
      //      else
      //      {
      //        MessageBox.Show("Bitte wählen Sie einen gültigen Kunden aus.", "Ungültige Kundenauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //        tbxKdNummer.Focus();
      //      }
      //      break;
      //    case DialogResult.No:
      //      changesDone = false;
      //      Func.FAuftrag = null;
      //      this.Close();
      //      break;
      //  }
      //}
      //else
      //{
      //  Func.FAuftrag = null;
      //  this.Close();
      //}
    }

    //Anlegen eines Auftrags
    private void btnAnlegen_Click(object sender, EventArgs e)
    {
      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        if ((!string.IsNullOrEmpty(tbxKdName.Text)) | (Func.IsNumeric(tbxKdNummer.Text, true)))
        {
          if (cobBetreff.SelectedIndex != -1)
          {
            try
            {
              DB.Auftrag a = new DB.Auftrag
                                 {
                                   Anfahrt = cbxAnfahrt.Checked ? "ja" : "nein",
                                   KundeID = int.Parse(tbxKdNummer.Text),
                                   Empfänger = tbxKdHaenden.Text == "" ? null : tbxKdHaenden.Text,
                                   Datum = dateAngebot.Value,
                                   Typ = cobTyp.Text == "Eigener Text" ? tbxEigenerText.Text : cobTyp.Text,
                                   Betreff = cobBetreff.Text,
                                   BV = tbxBauvorhaben.Text == "" ? null : tbxBauvorhaben.Text,
                                   BV2 = tbxBV2.Text == "" ? null : tbxBV2.Text,
                                   Gesamtbetrag = 0.0m,
                                   //Initialwert
                                   Nachlass = Decimal.Parse(tbxNachlass.Text),
                                   NachlassArt = cobNachlass.Text,
                                   Steuer = (Decimal)cobMwSt.SelectedValue,
                                   Zahlungsbedingung = cobSkonto.Text,
                                   Aufmaß = cbxAufmaß.Checked ? "ja" : "nein",
                                   Sondertext = tbxSondertext.Text == "" ? null : tbxSondertext.Text,
                                   SondertextUnten = tbxSondertextUnten.Text == "" ? null : tbxSondertextUnten.Text,
                                   VorgabedatumRechnung = dateAufVorgabeRech.Value.Date != DateTime.Today.Date ? dateAufVorgabeRech.Value.Date : (DateTime?)null
                                 };

              dbContext.Auftrag.InsertOnSubmit(a);
              dbContext.SubmitChanges();
              tbxAufNummer.Text = a.AuftragID.ToString();

              //itemPosNeu.Enabled = true;
              btnAnlegen.Enabled = false;
              btnEdit.Enabled = true;
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
          else
          {
            DialogResult res = MessageBox.Show("Bitte wählen Sie einen gültigen Betreff aus.", "Ungültige Betreffauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (res == DialogResult.OK)
            {
              cobBetreff.DroppedDown = true;
            }
          }
        }
        else
        {
          MessageBox.Show("Bitte wählen Sie einen gültigen Kunden aus.", "Ungültige Kundenauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    private void itemPosDelete_Click(object sender, EventArgs e)
    {
      deleteAuftragPos();
    }

    /// <summary>
    /// Löscht eine Postion aus dem Angebot.
    /// </summary>
    private void deleteAuftragPos()
    {
      DataGridViewRow dr = dgrPositionen.CurrentRow;

      if (dr != null)
      {
        DialogResult result = MessageBox.Show("Möchten Sie diese Position wirklich löschen?", "Position löschen", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        if (result == DialogResult.Yes)
        {
          using (DataBaseDataContext dbContext = new DataBaseDataContext())
          {
            try
            {
              var ap = dbContext.Auftrag_Position.Where(auftrag_position => auftrag_position.PosID.Equals(dr.Cells["PosID"].Value)).FirstOrDefault();

              dbContext.Auftrag_Position.DeleteOnSubmit(ap);
              dbContext.SubmitChanges();
              dgrPositionen.DataSource = Func.LoadAuftragPositionenUebersicht();
              //GeneratePosNr();
              //DisableSortmode();
              //Func.LoadAuftragSumme();

              var auftrag = dbContext.Auftrag.Where(a => a.AuftragID.Equals(int.Parse(tbxAufNummer.Text))).FirstOrDefault();
              auftrag.Gesamtbetrag = Decimal.Parse(Func.FAuftrag.lblAufGesamt.Text);
              dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }
      }
    }

    private void itemPosEdit_Click(object sender, EventArgs e)
    {
      editAuftragPos();
    }

    private void editAuftragPos()
    {
      DataGridViewRow currentRow = dgrPositionen.CurrentRow;

      if (currentRow != null)
      {
        using (DataBaseDataContext dbContext = new DataBaseDataContext())
        {
          try
          {
            var ap = dbContext.Auftrag_Position.Where(auftrag_position => auftrag_position.PosID.Equals(currentRow.Cells["PosID"].Value)).FirstOrDefault();

            Func.FAuftragPosition = new Kalkulationen.Form_Kalkualtion(ap);
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
          }
        }

        //Mit der übergebenen List lösen!
        Func.FAuftragPosition.SetAuftragsNr(tbxAufNummer.Text, "ändern -");
        Func.FAuftragPosition.FormBorderStyle = FormBorderStyle.FixedSingle;
        Func.FAuftragPosition.WindowState = FormWindowState.Normal;
        Func.FAuftragPosition.grpSteuerung.Visible = true;
        Func.FAuftragPosition.toolStrip1.Visible = false;
        Func.FAuftragPosition.btnAendSpeichern.Enabled = false;
        Func.FAuftragPosition.btnPosAnlegen.Enabled = false;
        Func.FAuftragPosition.ShowDialog();
      }
    }

    private void tbxAufNummer_TextChanged(object sender, EventArgs e)
    {
      tbxAufNummer.Text = tbxAufNummer.Text.Replace(",", "");

      if ((tbxAufNummer.Text.Length > 3) & (Func.IsNumeric(tbxAufNummer.Text, true)))
      {
        try
        {
          using (DataBaseDataContext dbContext = new DataBaseDataContext())
          {
            var a = dbContext.Auftrag.Where(auftrag => auftrag.AuftragID.Equals(tbxAufNummer.Text)).FirstOrDefault();

            var ap = dbContext.Auftrag_Position.Where(auftrag_position => auftrag_position.AuftragID.Equals(tbxAufNummer.Text));

            // Überprüfung, ob für zu den Positionen schon Aufträge vorhanden sind.
            if (ap.Count(y => y.RechnungID != null) > 0) // Wenn > 0, dann exisiert mindestens zu einer Angebotsposition ein Auftrag
            {
              isRechnungExisting = true;
            }
            else
            {
              isRechnungExisting = false;
            }

            if (a == null) // Zur eingegebenen Nummer ist kein Auftrag vorhanden.
            {
              itemPosNeu.Enabled = false;
              itemPosEdit.Enabled = false;
              itemPosDelete.Enabled = false;
              itemPrint.Enabled = false;
              itemMail.Enabled = false;
              itemRechnung.Enabled = false;
              btnEdit.Enabled = false;
            }
            else
            {

              tbxKdNummer.Text = a.KundeID.ToString();
              //cobTyp.SelectedItem = a.Typ;
              dgrPositionen.Columns.Clear();
              dgrPositionen.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = Const.CheckColumHeaderName, Name = Const.CheckColumHeaderName, ThreeState = false });
              dgrPositionen.Columns.Add(new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell(), HeaderText = Const.PosNrHeaderName, Name = Const.PosNrHeaderName, Visible = true });
              dgrPositionen.DataSource = ap;
              //GeneratePosNr();
              //DisableSortmode();
              dgrPositionen.ClearSelection();
              //ColorizeZuschlagColumn();

              //ColorizeTypColumn();
              //dgrPositionen.AutoGenerateColumns = true;
              dgrPositionen.Columns["PosID"].Visible = false;
              dgrPositionen.Columns["AuftragID"].Visible = false;
              dgrPositionen.Columns["Auftrag"].Visible = false;
              dgrPositionen.Columns["Rechnung"].Visible = false;
              dgrPositionen.Columns["RechnungID"].Visible = true;




              btnAnlegen.Enabled = false;

              btnEdit.Enabled = true;


              switch (a.Typ)
              {
                case "Normal":
                  cobTyp.SelectedItem = a.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "Alternativ-gleichwertig":
                  cobTyp.SelectedItem = a.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "Kurztext":
                  cobTyp.SelectedItem = a.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "LV-abweichend":
                  cobTyp.SelectedItem = a.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "Neutral":
                  cobTyp.SelectedItem = a.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                default:
                  cobTyp.Text = "Eigener Text";
                  tbxEigenerText.Enabled = true;
                  tbxEigenerText.Text = a.Typ;
                  break;
              }

              tbxBauvorhaben.Text = a.BV;

              if (!cobSkonto.Items.Contains(a.Zahlungsbedingung))
              {
                cobSkonto.Items.Add(a.Zahlungsbedingung);
              }

              cobSkonto.Text = a.Zahlungsbedingung;
              cobBetreff.SelectedItem = a.Betreff;
              //tbxNachlass.Text = a.Nachlass.ToString();
              tbxNachlass.Text = String.Format("{0:#,0.00}", a.Nachlass);
              cobNachlass.SelectedItem = a.NachlassArt;
              tbxKdHaenden.Text = a.Empfänger;
              tbxBV2.Text = a.BV2;
              tbxSondertext.Text = a.Sondertext;
              tbxSondertextUnten.Text = a.SondertextUnten;
              tbxKdHaenden.Text = a.Empfänger;
              dateAngebot.Value = a.Datum;

              if (a.VorgabedatumRechnung != null)
              {
                dateAufVorgabeRech.Value = (DateTime)a.VorgabedatumRechnung;
              }
              else
              {
                dateAufVorgabeRech.Value = DateTime.Today;

              }
              //PFUSCH
              //if (a.Steuer == 0.00m)
              //{
              //    cobMwSt.SelectedIndex = 0;
              //}
              //else if (a.Steuer == 1.00m)
              //{
              //    cobMwSt.SelectedIndex = 1;
              //}
              //else if (a.Steuer == 2.00m)
              //{
              //    cobMwSt.SelectedIndex = 2;
              //}

              cobMwSt.SelectedValue = a.Steuer;



              if (a.Aufmaß == "ja")
              {
                cbxAufmaß.Checked = true;
              }
              else
              {
                cbxAufmaß.Checked = false;
              }

              if (a.Anfahrt == "ja")
              {
                cbxAnfahrt.Checked = true;
              }
              else
              {
                cbxAnfahrt.Checked = false;
              }

              btnAnlegen.Enabled = false;

              if (isRechnungExisting == true)
              {
                btnEdit.Enabled = false;
              }
              else
              {
                btnEdit.Enabled = true;
              }

              if (dgrPositionen.Rows.Count > 0)
              {
                itemPrint.Enabled = true;
                itemMail.Enabled = true;
                itemRechnung.Enabled = true;
              }
              itemPosNeu.Enabled = true;
              //itemPosEdit.Enabled = true;
              //itemPosDelete.Enabled = true;

              Func.LoadAuftragSumme();
            }
          }
        }

        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
          //Log.Error("Upps", ex);
        }
      }
      else
      {
        itemPosNeu.Enabled = false;
        itemPosEdit.Enabled = false;
        itemPosDelete.Enabled = false;
        itemPrint.Enabled = false;
        itemMail.Enabled = false;
      }
    }

    /// <summary>
    /// Handles the Click event of the itemMail control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    private void itemMail_Click(object sender, EventArgs e)
    {

      String eMail = String.Empty;

      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        try
        {
          var k = dbContext.Kunde.Where(customer => customer.KundeID.Equals(int.Parse(tbxKdNummer.Text))).FirstOrDefault();

          eMail = k.Email2;

          Func.SendDocumentViaEmail(eMail, "Norka Sanitärkabinen: Auftrag", "", ReportManager.GetExportFilepath(EReports.Auftragsbestätigung, int.Parse(tbxAufNummer.Text)));
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
    }


    private void sofortdruckToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      PrintManager.PrintDirectlyWithDialog(EReports.Auftragsbestätigung, new List<int>() { 1, int.Parse(tbxAufNummer.Text) });
      this.Cursor = Cursors.Default;
    }

    private void vorschauToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Auftragsbestätigung, new List<int>() { 1, int.Parse(tbxAufNummer.Text) });
      var r = new Form_Report(report);
      r.Show();
      r.Refresh();
      this.Cursor = Cursors.Default;
    }


    private void cobNachlass_TextChanged(object sender, EventArgs e)
    {
      Func.LoadAuftragSumme();
    }


    private void cobMwSt_TextChanged(object sender, EventArgs e)
    {
      Func.LoadAuftragSumme();
    }

    public void setErgebnisse(decimal Pos, decimal Nachl, decimal Mwst, decimal Gesamtsum)
    {
      PositionSumme = Pos;
      Nachlass = Nachl;
      Steuer = Mwst;
      Gesamt = Gesamtsum;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        try
        {
          var a = dbContext.Auftrag.Where(auftrag => auftrag.AuftragID.Equals(int.Parse(tbxAufNummer.Text))).FirstOrDefault();

          a.Anfahrt = cbxAnfahrt.Checked ? "ja" : "nein";
          a.KundeID = int.Parse(tbxKdNummer.Text);
          a.Empfänger = tbxKdHaenden.Text == "" ? null : tbxKdHaenden.Text;
          a.Datum = dateAngebot.Value;
          a.Typ = cobTyp.Text == "Eigener Text" ? tbxEigenerText.Text : cobTyp.Text;
          a.Betreff = cobBetreff.Text;
          a.BV = tbxBauvorhaben.Text == "" ? null : tbxBauvorhaben.Text;
          a.BV2 = tbxBV2.Text == "" ? null : tbxBV2.Text;
          a.Gesamtbetrag = Decimal.Parse(lblAufGesamt.Text);
          a.Nachlass = Decimal.Parse(tbxNachlass.Text);
          a.NachlassArt = cobNachlass.Text;
          a.Steuer = (Decimal)cobMwSt.SelectedValue;
          a.Zahlungsbedingung = cobSkonto.Text;
          a.Aufmaß = cbxAufmaß.Checked ? "ja" : "nein";
          a.Sondertext = tbxSondertext.Text == "" ? null : tbxSondertext.Text;
          a.SondertextUnten = tbxSondertextUnten.Text == "" ? null : tbxSondertextUnten.Text;
          a.VorgabedatumRechnung = dateAufVorgabeRech.Value.Date != DateTime.Today ? dateAufVorgabeRech.Value : (DateTime?)null;
          dbContext.SubmitChanges();

          changesDone = false;
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
    }

    private void tbxKdNummer_TextChanged(object sender, EventArgs e)
    {
      if ((tbxKdNummer.Text.Length > 3) & (Func.IsNumeric(tbxKdNummer.Text, true)))
      {
        try
        {
          using (DataBaseDataContext dbContext = new DataBaseDataContext())
          {
            var k = dbContext.Kunde.Where(kunde => kunde.KundeID.Equals(int.Parse(tbxKdNummer.Text))).FirstOrDefault();

            if (k != null)
            {
              if (k.Status != "gesperrt")
              {
                tbxKdAnrede.Text = k.Anrede;
                tbxKdName.Text = k.Name_Firma;
                btnAnlegen.Enabled = tbxAufNummer.Text == "" ? true : false;
              }
              else
              {
                MessageBox.Show("Der Kunde ist gesperrt.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnAnlegen.Enabled = false;
              }

              changesDone = true;
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }

      }
    }

    private void dgrPositionen_MouseDown(object sender, MouseEventArgs e)
    {
      // Zeilenmarkierung bei Rechtsklick ermöglichen.
      DataGridView.HitTestInfo hti = dgrPositionen.HitTest(e.X, e.Y);

      if (hti.Type == DataGridViewHitTestType.Cell)
      {
        dgrPositionen.CurrentCell = dgrPositionen[hti.ColumnIndex, hti.RowIndex];

        DataGridViewRow row = dgrPositionen.CurrentRow;

        if (row.Cells["RechnungID"].Value == null)
        {
          itemPosEdit.Enabled = true;
          itemPosDelete.Enabled = true;
          itemPosNeu.Enabled = true;
        }
        else
        {
          itemPosEdit.Enabled = false;
          itemPosDelete.Enabled = false;
        }
      }
    }

    private void itemBearbeiten_Click(object sender, EventArgs e)
    {
      editAuftragPos();
    }

    private void itemLoeschen_Click(object sender, EventArgs e)
    {
      deleteAuftragPos();
    }


    private void itemAufNeu_Click(object sender, EventArgs e)
    {
      if (changesDone == true)
      {
        DialogResult result = MessageBox.Show("Nicht gespeicherte Werte gehen verloren.\nMöchten Sie die Änderungen zuerst speichern?", "Bestätigung",
                                              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        switch (result)
        {
          case DialogResult.Yes:
            changesDone = false;
            btnEdit.PerformClick();
            Func.FAuftrag.Close();
            Func.FAuftrag = null;
            Func.FAuftrag = new Form_Auftrag();
            Func.FAuftrag.MdiParent = Func.FStart;
            Func.FAuftrag.Text = "Angebot";
            Func.FAuftrag.Show();
            Func.FAuftrag.WindowState = FormWindowState.Maximized;
            break;
          case DialogResult.No:
            changesDone = false;
            Func.FAuftrag.Close();
            Func.FAuftrag = null;
            Func.FAuftrag = new Form_Auftrag();
            Func.FAuftrag.MdiParent = Func.FStart;
            Func.FAuftrag.Text = "Angebot";
            Func.FAuftrag.Show();
            Func.FAuftrag.WindowState = FormWindowState.Maximized;
            break;
        }
      }
    }

    private void itemPosNeu_Click(object sender, EventArgs e)
    {

      if (Func.FAuftragPosition == null)
      {
        Func.FAuftragPosition = new Kalkulationen.Form_Kalkualtion(true);
      }

      Func.FAuftragPosition.SetAuftragsNr(tbxAufNummer.Text, "anlegen -");
      Func.FAuftragPosition.FormBorderStyle = FormBorderStyle.FixedSingle;
      Func.FAuftragPosition.WindowState = FormWindowState.Normal;
      Func.FAuftragPosition.grpSteuerung.Visible = true;
      Func.FAuftragPosition.toolStrip1.Visible = false;
      Func.FAuftragPosition.btnPosAnlegen.Enabled = false;
      Func.FAuftragPosition.ShowDialog();
    }

    private void cobSkonto_DropDown(object sender, EventArgs e)
    {
      if (cobSkonto.Items.Count == 4)
      {
        cobSkonto.Items.RemoveAt(3);
      }
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.DrawLine(new Pen(Brushes.Black, 1), 3, 90, 300, 90);
      e.Graphics.DrawLine(new Pen(Brushes.Black, 1), 3, 150, 300, 150);
    }



    private void tbxSondertext_DoubleClick(object sender, EventArgs e)
    {
      //tbxSondertext.Height = 200;
      //tbxSondertext.Width = 400;
      //groupBox3.Width = 600;
      //splitContainer1.
    }

    private void tbxNachlass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if ((tbxNachlass.TextLength == 0) || (!Func.IsNumeric(tbxNachlass.Text, true)))
      {
        e.Cancel = true;
        MessageBox.Show("Bitte geben Sie einen gülten Wert für das Feld 'Nachlass'\nDieses Feld darf keine negativen Werte enthalten, nicht leer sein und muss nummerische Werte enthalten.", "Ungültiger Wert in Feld 'Nachlass'", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        Func.LoadAuftragSumme();
        changesDone = true;
      }
    }

    private void Form_Auftrag_Leave(object sender, EventArgs e)
    {
      //if (changesDone == true)
      //{
      //  if (btnEdit.Enabled == false & tbxAufNummer.Text != "")
      //  {
      //  }
      //  else if (IsDefault() == false)
      //  {
      //    DialogResult result = MessageBox.Show("Es sind noch nicht gespeicherte Änderungen vorhanden.\nMöchten Sie die Änderungen speichern?", "Bestätigung.",
      //                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      //    if (result == DialogResult.Yes)
      //    {
      //      if (tbxKdNummer.Text != "")
      //      {
      //        btnAnlegen.PerformClick();
      //      }
      //      else
      //      {
      //        MessageBox.Show("Bitte wählen Sie einen gültigen Kunden aus.", "Ungültige Kundenauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //        tbxKdNummer.Focus();
      //      }
      //    }
      //  }
      //}
    }

    private void dateAuftrag_ValueChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private DialogResult CheckChanges()
    {
      if (changesDone == true)
      {
        DialogResult = MessageBox.Show("Es sind noch nicht gespeicherte Änderungen vorhanden.\nMöchten Sie die Änderungen speichern?", "Nicht gespeicherte Änderungen.",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      }

      return DialogResult;
    }

    private void tbxEigenerText_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void tbxBauvorhaben_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void tbxBV2_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void cobSkonto_SelectedIndexChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void cobSkonto_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void cobBetreff_SelectedIndexChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void cobNachlass_SelectedIndexChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void cobMwSt_SelectedIndexChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void cbxAufmaß_CheckedChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void cbxAnfahrt_CheckedChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void tbxSondertext_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void tbxKdHaenden_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void dgrPositionen_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewRow row = dgrPositionen.CurrentRow;

      if (row.Cells["RechnungID"].Value == null)
      {
        itemPosEdit.Enabled = true;
        itemPosDelete.Enabled = true;
        itemPosNeu.Enabled = true;
      }
      else
      {
        itemPosEdit.Enabled = false;
        itemPosDelete.Enabled = false;
      }

      if (dgrPositionen.CurrentCell == row.Cells[Const.CheckColumHeaderName])
      {
        DataGridViewCheckBoxCell cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (row.Cells["RechnungID"].Value == null)
        {
          if (cell.Value == null)
          {
            cell.Value = true;
            selectedRows++;
          }
          else if ((bool)cell.Value == true)
          {
            cell.Value = false;
            selectedRows--;
          }
          else if ((bool)cell.Value == false)
          {
            cell.Value = true;
            selectedRows++;
          }
        }

      }
    }



    private void itemMarkKein_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        DataGridViewCheckBoxCell cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (row.Cells["RechnungID"].Value == null)
        {
          cell.Value = null;
        }
      }

      selectedRows = 0;
    }

    private void itemMarkAlle_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        DataGridViewCheckBoxCell cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (row.Cells["RechnungID"].Value == null)
        {
          cell.Value = true;
        }

      }

      selectedRows = dgrPositionen.Rows.Count;
    }



    private void itemAllPos_Click(object sender, EventArgs e)
    {
      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        var auftrag = dbContext.Auftrag.Where(auf => auf.AuftragID.Equals(int.Parse(tbxAufNummer.Text))).FirstOrDefault();

        var rechnung = new DB.Rechnung
                          {
                            Datum = dateAufVorgabeRech.Value.Date != DateTime.Today.Date ? dateAufVorgabeRech.Value.Date : DateTime.Today.Date, 
                            Steuer = auftrag.Steuer,
                            KundeID = auftrag.KundeID,
                            Typ = auftrag.Typ,
                            BV = auftrag.BV,
                            BV2 = auftrag.BV2,
                            Zahlungsbedingung = auftrag.Zahlungsbedingung,
                            Betreff = auftrag.Betreff,
                            Nachlass = auftrag.Nachlass,
                            NachlassArt = auftrag.NachlassArt,
                            Aufmaß = auftrag.Aufmaß,
                            Anfahrt = auftrag.Anfahrt,
                            Sondertext = auftrag.Sondertext,
                          };

        try
        {
          dbContext.Rechnung.InsertOnSubmit(rechnung);
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }

        decimal sum = 0.0m;

        foreach (DataGridViewRow row in dgrPositionen.Rows)
        {
          // Es werden nur Auftragspositionen berücksichtigt, die noch keinem Auftrag zugeordnet wurden.
          if (row.Cells["RechnungID"].Value == null)
          { 
            var auftragPosition = dbContext.Auftrag_Position.Where(ap => ap.PosID.Equals(row.Cells["PosID"].Value)).FirstOrDefault();

            var rechnungPosition = new Rechnung_Position()
            {
              RechnungID = rechnung.RechnungID,
              Artikel = auftragPosition.Artikel,
              Sondertext = auftragPosition.Sondertext,
              Typ = auftragPosition.Typ,
              AnlagenStk = auftragPosition.AnlagenStk,
              Breite = auftragPosition.Breite,
              Tiefe = auftragPosition.Tiefe,
              Türen = auftragPosition.Türen,
              TW = auftragPosition.TW,
              ZuschlagTür = auftragPosition.ZuschlagTür,
              Einzelpreis = auftragPosition.Einzelpreis,
              Zuschlag = auftragPosition.Zuschlag,
              ZuschlagArt = auftragPosition.ZuschlagArt,
              Alupulver = auftragPosition.Alupulver,
              Montage = auftragPosition.Montage,
              AussparungStk = auftragPosition.AussparungStk,
              AussparungTxt = auftragPosition.AussparungTxt,
              Alternativ1Typ = auftragPosition.Alternativ1Typ,
              Alternativ1Preis = auftragPosition.Alternativ1Preis,
              Alternativ2Typ = auftragPosition.Alternativ2Typ,
              Alternativ2Preis = auftragPosition.Alternativ2Preis,
              SondertextOben = auftragPosition.SondertextOben,
              SonderartikelEinheit = auftragPosition.SonderartikelEinheit
            };


            // Increment Gesamtsumme.
            sum += rechnungPosition.Einzelpreis * rechnungPosition.AnlagenStk;
            sum += rechnungPosition.Alupulver * rechnungPosition.AnlagenStk;
            try
            {
              dbContext.Rechnung_Position.InsertOnSubmit(rechnungPosition);
              dbContext.SubmitChanges();
              auftragPosition.RechnungID = rechnung.RechnungID;
              dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }

        try
        {
          // Von der Gesamtsumme der Positionen den Nachlass abziehen
          if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "" & cobNachlass.SelectedIndex == 0) // Prozent
          {
            sum = sum - (sum * decimal.Parse(tbxNachlass.Text) / 100);
          }
          else if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "")
          {
            sum = sum - decimal.Parse(tbxNachlass.Text);
          }

          // Zu der Gesamtsumme der Positionen die MwSt hinzurechnen.
          //if (cobMwSt.SelectedIndex == 0)
          //{
          //    sum = sum * 0.19m + sum;
          //}

          sum = sum * (Decimal)cobMwSt.SelectedValue + sum;

          // Rechnung mit Gesamtbetrag updaten.
          rechnung.Gesamtbetrag = sum;
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
        dgrPositionen.DataSource = Func.LoadAuftragPositionenUebersicht();
        GeneratePosNr();
        selectedRows = 0;
        btnEdit.Enabled = false;

        this.Cursor = Cursors.WaitCursor;
        PrintManager.PrintDirectlyWithDialog(EReports.Rechnung, new List<int>() { 1, rechnung.RechnungID });
        this.Cursor = Cursors.Default;
      }
     
    }

    private void dgrPositionen_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      // Nicht löschen, sonst tauchen unerklärliche Fehlermeldungen auf. Notlösung.
    }

    private void itemMarkPos_Click(object sender, EventArgs e)
    {
      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        var auftrag = dbContext.Auftrag.Where(auf => auf.AuftragID.Equals(int.Parse(tbxAufNummer.Text))).FirstOrDefault();

        var rechnung = new DB.Rechnung
        {
          Datum = dateAufVorgabeRech.Value.Date != DateTime.Today.Date ? dateAufVorgabeRech.Value.Date : DateTime.Today.Date, 
          Steuer = auftrag.Steuer,
          KundeID = auftrag.KundeID,
          Typ = auftrag.Typ,
          BV = auftrag.BV,
          BV2 = auftrag.BV2,
          Zahlungsbedingung = auftrag.Zahlungsbedingung,
          Betreff = auftrag.Betreff,
          Nachlass = auftrag.Nachlass,
          NachlassArt = auftrag.NachlassArt,
          Aufmaß = auftrag.Aufmaß,
          Anfahrt = auftrag.Anfahrt,
          Sondertext = auftrag.Sondertext
        };

        try
        {
          dbContext.Rechnung.InsertOnSubmit(rechnung);
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }


        decimal sum = 0.0m;

        foreach (DataGridViewRow row in dgrPositionen.Rows)
        {
          // Nur alle gecheckten Positionen berücksichtigen.
          DataGridViewCheckBoxCell cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;
          if (cell.Value != null)
          {
            // Aktuelle, gecheckte Auftragsposition im FOREACH-Durchlauf aus DB auslesen.
            var auftragPosition = dbContext.Auftrag_Position.Where(ap => ap.PosID.Equals(row.Cells["PosID"].Value)).FirstOrDefault();

            // Neue Rechnungsposition anlegen und mit Daten aus Auftragssposition füllen.
            var rechnungPosition = new Rechnung_Position()
                                               {
                                                 RechnungID = rechnung.RechnungID,
                                                 Artikel = auftragPosition.Artikel,
                                                 Sondertext = auftragPosition.Sondertext,
                                                 Typ = auftragPosition.Typ,
                                                 AnlagenStk = auftragPosition.AnlagenStk,
                                                 Breite = auftragPosition.Breite,
                                                 Tiefe = auftragPosition.Tiefe,
                                                 Türen = auftragPosition.Türen,
                                                 TW = auftragPosition.TW,
                                                 ZuschlagTür = auftragPosition.ZuschlagTür,
                                                 Einzelpreis = auftragPosition.Einzelpreis,
                                                 Zuschlag = auftragPosition.Zuschlag,
                                                 ZuschlagArt = auftragPosition.ZuschlagArt,
                                                 Alupulver = auftragPosition.Alupulver,
                                                 Montage = auftragPosition.Montage,
                                                 AussparungStk = auftragPosition.AussparungStk,
                                                 AussparungTxt = auftragPosition.AussparungTxt,
                                                 Alternativ1Typ = auftragPosition.Alternativ1Typ,
                                                 Alternativ1Preis = auftragPosition.Alternativ1Preis,
                                                 Alternativ2Typ = auftragPosition.Alternativ2Typ,
                                                 Alternativ2Preis = auftragPosition.Alternativ2Preis,
                                                 SondertextOben = auftragPosition.SondertextOben,
                                                 SonderartikelEinheit =  auftragPosition.SonderartikelEinheit
                                               };

            // Increment Gesamtsumme.
            sum += rechnungPosition.Einzelpreis * rechnungPosition.AnlagenStk;
            sum += rechnungPosition.Alupulver * rechnungPosition.AnlagenStk;
            try
            {
              // Rechnungssposition in DB speichern.
              dbContext.Rechnung_Position.InsertOnSubmit(rechnungPosition);
              dbContext.SubmitChanges();

              // Rechnungssposition auf Rechnung referenzieren.
              auftragPosition.RechnungID = rechnung.RechnungID;
              dbContext.SubmitChanges();


            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }

        try
        {
          // Von der Gesamtsumme der Positionen den Nachlass abziehen.
          if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "" & cobNachlass.SelectedIndex == 0) // Prozent
          {
            sum = sum - (sum * decimal.Parse(tbxNachlass.Text) / 100);
          }
          else if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "")
          {
            sum = sum - decimal.Parse(tbxNachlass.Text);
          }


          // Zu der Gesamtsumme der Positionen die MwSt hinzurechnen.
          //if (cobMwSt.SelectedIndex == 0)
          //{
          //    sum = sum * 0.19m + sum;
          //}

          sum = sum * (Decimal)cobMwSt.SelectedValue + sum;
          // Rechnung mit Gesamtbetrag updaten.
          rechnung.Gesamtbetrag = sum;
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }

        dgrPositionen.DataSource = Func.LoadAuftragPositionenUebersicht();
        GeneratePosNr();
        selectedRows = 0;
        btnEdit.Enabled = false;

        this.Cursor = Cursors.WaitCursor;
        PrintManager.PrintDirectlyWithDialog(EReports.Rechnung, new List<int>() { 1, rechnung.RechnungID });
        this.Cursor = Cursors.Default;

      }
      

      
    }




    private bool IsDefault()
    {
      bool state = false;

      if (tbxAufNummer.Text == "" & dateAngebot.Value.ToShortDateString() == DateTime.Today.ToShortDateString() & cobTyp.Text == "Normal" & tbxEigenerText.Text == "" & tbxBauvorhaben.Text == "" &
          tbxBV2.Text == "" & cobSkonto.Text == "" & cobBetreff.Text == "Lieferung und Montage von WC-Trennwänden" & tbxNachlass.Text == "0" &
          cobNachlass.Text == "Prozent" & cobMwSt.Text == "19" & cbxAnfahrt.Checked == false & cbxAufmaß.Checked == false & tbxSondertext.Text == "" & tbxSondertextUnten.Text == "" &
          tbxKdNummer.Text == "" & tbxKdHaenden.Text == "")
      {
        state = true;
      }

      return state;
    }

    private void itemRechnung_DropDownOpening(object sender, EventArgs e)
    {
      DataGridViewRow row = dgrPositionen.CurrentRow;

      if (row != null)
      {
        itemMarkPos.Enabled = false;
        itemAllPos.Enabled = true;
      }
      else
      {
        itemMarkPos.Enabled = false;
        itemAllPos.Enabled = false;
      }

      if (selectedRows != 0)
      {
        itemMarkPos.Enabled = true;
        itemMarkPosSchluss.Enabled = true;
        itemAllPos.Enabled = true;
        itemAllPosSchluss.Enabled = true;
      }
      else if (selectedRows == 0)
      {
        itemMarkPos.Enabled = false;
        itemMarkPosSchluss.Enabled = false;
        itemAllPos.Enabled = true;
        itemAllPosSchluss.Enabled = true;
      }

      int posMitRechnung = 0;
      foreach (DataGridViewRow r in dgrPositionen.Rows)
      {
        if (r.Cells["RechnungID"].Value != null)
        {
          posMitRechnung++;
        }
      }

      if (posMitRechnung == dgrPositionen.Rows.Count)
      {
        itemAllPos.Enabled = false;
        itemAllPosSchluss.Enabled = false;
      }
      else
      {
        itemAllPos.Enabled = true;
        itemAllPosSchluss.Enabled = true;
      }
    }



    private void ctmAngebot_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (dgrPositionen.Rows.Count > 0)
      {
        if (dgrPositionen.CurrentRow.Cells["RechnungID"].Value != null)
        {
          itemBearbeiten.Enabled = false;
          itemLoeschen.Enabled = false;
          itemRechnungÖffnen.Enabled = true;
        }
        else
        {
          itemBearbeiten.Enabled = true;
          itemLoeschen.Enabled = true;
          itemRechnungÖffnen.Enabled = false;
        }
      }
    }

    private void itemAllPosSchluss_Click(object sender, EventArgs e)
    {

      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        var auftrag = dbContext.Auftrag.Where(auf => auf.AuftragID.Equals(int.Parse(tbxAufNummer.Text))).FirstOrDefault();

        var rechnung = new DB.Rechnung
        {
          Datum = dateAufVorgabeRech.Value.Date != DateTime.Today.Date ? dateAufVorgabeRech.Value.Date : DateTime.Today.Date, 
          Steuer = auftrag.Steuer,
          KundeID = auftrag.KundeID,
          Typ = auftrag.Typ,
          BV = auftrag.BV,
          BV2 = auftrag.BV2,
          Zahlungsbedingung = auftrag.Zahlungsbedingung,
          Betreff = auftrag.Betreff,
          Nachlass = auftrag.Nachlass,
          NachlassArt = auftrag.NachlassArt,
          Aufmaß = auftrag.Aufmaß,
          Anfahrt = auftrag.Anfahrt,
          Sondertext = auftrag.Sondertext,
          Schlussrechnung = "ja"
        };

        try
        {
          dbContext.Rechnung.InsertOnSubmit(rechnung);
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }

        decimal sum = 0.0m;

        foreach (DataGridViewRow row in dgrPositionen.Rows)
        {
          // Es werden nur AngebotsPositionen berücksichtigt, die noch keinem Auftrag zugeordnet wurden.
          if (row.Cells["RechnungID"].Value == null)
          {
            var auftragPosition = dbContext.Auftrag_Position.Where(ap => ap.PosID.Equals(row.Cells["PosID"].Value)).FirstOrDefault();

            var rechnungPosition = new Rechnung_Position()
            {
              RechnungID = rechnung.RechnungID,
              Artikel = auftragPosition.Artikel,
              Sondertext = auftragPosition.Sondertext,
              Typ = auftragPosition.Typ,
              AnlagenStk = auftragPosition.AnlagenStk,
              Breite = auftragPosition.Breite,
              Tiefe = auftragPosition.Tiefe,
              Türen = auftragPosition.Türen,
              TW = auftragPosition.TW,
              ZuschlagTür = auftragPosition.ZuschlagTür,
              Einzelpreis = auftragPosition.Einzelpreis,
              Zuschlag = auftragPosition.Zuschlag,
              ZuschlagArt = auftragPosition.ZuschlagArt,
              Alupulver = auftragPosition.Alupulver,
              Montage = auftragPosition.Montage,
              AussparungStk = auftragPosition.AussparungStk,
              AussparungTxt = auftragPosition.AussparungTxt,
              Alternativ1Typ = auftragPosition.Alternativ1Typ,
              Alternativ1Preis = auftragPosition.Alternativ1Preis,
              Alternativ2Typ = auftragPosition.Alternativ2Typ,
              Alternativ2Preis = auftragPosition.Alternativ2Preis,
              SondertextOben = auftragPosition.SondertextOben,
              SonderartikelEinheit = auftragPosition.SonderartikelEinheit
            };

            // Increment Gesamtsumme.
            sum += rechnungPosition.Einzelpreis * rechnungPosition.AnlagenStk;
            sum += rechnungPosition.Alupulver * rechnungPosition.AnlagenStk;

            try
            {
              dbContext.Rechnung_Position.InsertOnSubmit(rechnungPosition);
              dbContext.SubmitChanges();
              auftragPosition.RechnungID = rechnung.RechnungID;
              dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }

        try
        {
          // Von der Gesamtsumme der Positionen den Nachlass abziehen.
          if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "" & cobNachlass.SelectedIndex == 0) // Prozent
          {
            sum = sum - (sum * decimal.Parse(tbxNachlass.Text) / 100);
          }
          else if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "")
          {
            sum = sum - decimal.Parse(tbxNachlass.Text);
          }

          // Zu der Gesamtsumme der Positionen die MwSt hinzurechnen.
          //if (cobMwSt.SelectedIndex == 0)
          //{
          //    sum = sum * 0.19m + sum;
          //}

          sum = sum * (Decimal)cobMwSt.SelectedValue + sum;

          // Rechnung mit Gesamtbetrag updaten.
          rechnung.Gesamtbetrag = sum;
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
        dgrPositionen.DataSource = Func.LoadAuftragPositionenUebersicht();
        GeneratePosNr();
        selectedRows = 0;
        btnEdit.Enabled = false;

        this.Cursor = Cursors.WaitCursor;
        PrintManager.PrintDirectlyWithDialog(EReports.Rechnung, new List<int>() { 1, rechnung.RechnungID });
        this.Cursor = Cursors.Default;
      }
     
    }

    private void itemMarkPosSchluss_Click(object sender, EventArgs e)
    {
      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        var auftrag = dbContext.Auftrag.Where(auf => auf.AuftragID.Equals(int.Parse(tbxAufNummer.Text))).FirstOrDefault();

        var rechnung = new DB.Rechnung
        {
          Datum = dateAufVorgabeRech.Value.Date != DateTime.Today.Date ? dateAufVorgabeRech.Value.Date : DateTime.Today.Date, 
          Steuer = auftrag.Steuer,
          KundeID = auftrag.KundeID,
          Typ = auftrag.Typ,
          BV = auftrag.BV,
          BV2 = auftrag.BV2,
          Zahlungsbedingung = auftrag.Zahlungsbedingung,
          Betreff = auftrag.Betreff,
          Nachlass = auftrag.Nachlass,
          NachlassArt = auftrag.NachlassArt,
          Aufmaß = auftrag.Aufmaß,
          Anfahrt = auftrag.Anfahrt,
          Sondertext = auftrag.Sondertext,
          Schlussrechnung = "ja"
        };

        try
        {
          dbContext.Rechnung.InsertOnSubmit(rechnung);
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }


        decimal sum = 0.0m;

        foreach (DataGridViewRow row in dgrPositionen.Rows)
        {
          // Nur alle gecheckten Positionen berücksichtigen.
          DataGridViewCheckBoxCell cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;
          if (cell.Value != null)
          {
            // Aktuelle, gecheckte Auftragsposition im FOREACH-Durchlauf aus DB auslesen.
            var auftragPosition = dbContext.Auftrag_Position.Where(ap => ap.PosID.Equals(row.Cells["PosID"].Value)).FirstOrDefault();

            // Neue Rechnungsposition anlegen und mit Daten aus Auftragssposition füllen.
            var rechnungPosition = new Rechnung_Position()
            {
              RechnungID = rechnung.RechnungID,
              Artikel = auftragPosition.Artikel,
              Sondertext = auftragPosition.Sondertext,
              Typ = auftragPosition.Typ,
              AnlagenStk = auftragPosition.AnlagenStk,
              Breite = auftragPosition.Breite,
              Tiefe = auftragPosition.Tiefe,
              Türen = auftragPosition.Türen,
              TW = auftragPosition.TW,
              ZuschlagTür = auftragPosition.ZuschlagTür,
              Einzelpreis = auftragPosition.Einzelpreis,
              Zuschlag = auftragPosition.Zuschlag,
              ZuschlagArt = auftragPosition.ZuschlagArt,
              Alupulver = auftragPosition.Alupulver,
              Montage = auftragPosition.Montage,
              AussparungStk = auftragPosition.AussparungStk,
              AussparungTxt = auftragPosition.AussparungTxt,
              Alternativ1Typ = auftragPosition.Alternativ1Typ,
              Alternativ1Preis = auftragPosition.Alternativ1Preis,
              Alternativ2Typ = auftragPosition.Alternativ2Typ,
              Alternativ2Preis = auftragPosition.Alternativ2Preis,
              SondertextOben = auftragPosition.SondertextOben,
              SonderartikelEinheit = auftragPosition.SonderartikelEinheit
            };

            // Increment Gesamtsumme.
            sum += rechnungPosition.Einzelpreis * rechnungPosition.AnlagenStk;
            sum += rechnungPosition.Alupulver * rechnungPosition.AnlagenStk;
            try
            {
              // Rechnungssposition in DB speichern.
              dbContext.Rechnung_Position.InsertOnSubmit(rechnungPosition);
              dbContext.SubmitChanges();

              // Rechnungssposition auf Rechnung referenzieren.
              auftragPosition.RechnungID = rechnung.RechnungID;
              dbContext.SubmitChanges();


            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }

        try
        {
          // Von der Gesamtsumme der Positionen den Nachlass abziehen.
          if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "" & cobNachlass.SelectedIndex == 0) // Prozent
          {
            sum = sum - (sum * decimal.Parse(tbxNachlass.Text) / 100);
          }
          else if (Func.IsNumeric(tbxNachlass.Text, true) & tbxNachlass.Text != "")
          {
            sum = sum - decimal.Parse(tbxNachlass.Text);
          }

          // Zu der Gesamtsumme der Positionen die MwSt hinzurechnen.
          //if (cobMwSt.SelectedIndex == 0)
          //{
          //    sum = sum * 0.19m + sum;
          //}

          sum = sum * (Decimal)cobMwSt.SelectedValue + sum;
          // Rechnung mit Gesamtbetrag updaten.
          rechnung.Gesamtbetrag = sum;
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }

        dgrPositionen.DataSource = Func.LoadAuftragPositionenUebersicht();
        GeneratePosNr();
        selectedRows = 0;
        btnEdit.Enabled = false;

        this.Cursor = Cursors.WaitCursor;
        PrintManager.PrintDirectlyWithDialog(EReports.Rechnung, new List<int>() { 1, rechnung.RechnungID });
        this.Cursor = Cursors.Default;
      }
     
    }

    private void itemRechnungÖffnen_Click(object sender, EventArgs e)
    {
      DataGridViewRow row = dgrPositionen.CurrentRow;

      if (Func.FRechnung == null)
      {
        Func.FRechnung = new Form_Rechnung();
        Func.FRechnung.MdiParent = Func.FStart;

        Func.FRechnung.Text = "Rechnung";
        Func.FRechnung.Show();
        Func.FRechnung.WindowState = FormWindowState.Maximized;
        Func.FRechnung.tbxRechNummer.Text = row.Cells["RechnungID"].Value.ToString();
      }
      else
      {
        Func.FRechnung.Show();
        Func.FRechnung.WindowState = FormWindowState.Maximized;
        Func.FRechnung.tbxRechNummer.Text = row.Cells["RechnungID"].Value.ToString();
      }
    }

    private void dgrPositionen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      if (dgrPositionen.Rows.Count > 0)
      {
        itemPrint.Enabled = true;
        itemMail.Enabled = true;
        itemRechnung.Enabled = true;
        itemMarkAlle.Enabled = true;
        itemMarkKein.Enabled = true;
      }
    }

    private void dgrPositionen_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (dgrPositionen.Rows.Count > 0)
      {
        itemPrint.Enabled = true;
        itemMail.Enabled = true;
        itemRechnung.Enabled = true;
        itemMarkAlle.Enabled = true;
        itemMarkKein.Enabled = true;
      }
      else
      {
        itemPrint.Enabled = false;
        itemMail.Enabled = false;
        itemRechnung.Enabled = false;
        itemMarkAlle.Enabled = false;
        itemMarkKein.Enabled = false;
        itemPosEdit.Enabled = false;
        itemPosDelete.Enabled = false;
      }
    }



    private void faxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      PrintManager.Fax(EReports.Begleitschreiben, new List<int>() { 1, int.Parse(tbxAufNummer.Text) });
      this.Cursor = Cursors.Default;
    }

    private void tbxKdName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      ProcessKeyDown(e.KeyCode);
    }

    private void ProcessKeyDown(Keys keyCode)
    {
      if (keyCode == Keys.Tab)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          var resultAnzeige = from k in dbContext.Kunde
                              where k.Name_Firma.Contains(tbxKdName.Text)
                              select new { k.KundeID, k.Name_Firma,k.PLZ,k.Ort };

          var res = dbContext.Kunde.Where(k => k.Name_Firma.Contains(tbxKdName.Text)).Select(k => k);

          if (resultAnzeige.Count() == 1)
          {
            foreach (Kunde kunde in res)
            {
              tbxKdNummer.Text = "";
              tbxKdNummer.Text = kunde.KundeID.ToString();
            }
          }
          else
          {
            Func.FKundeMiniAuswahl = new Form_Kunde_MiniAuswahl(resultAnzeige, true);
            Func.FKundeMiniAuswahl.StartPosition = FormStartPosition.CenterScreen;
            Func.FKundeMiniAuswahl.ShowDialog();
          }
        }
      }
    }

    public void ColorizeZuschlagColumn()
    {
      dgrPositionen.Columns["Zuschlag"].DefaultCellStyle.Font = new Font("Verdana", 8.25F, FontStyle.Bold);
      dgrPositionen.Columns["Zuschlag"].DefaultCellStyle.ForeColor = Color.Red;
      dgrPositionen.Columns["Zuschlag"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    public void ColorizeTypColumn()
    {
      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        row.Cells["Typ"].Style.Font = new Font("Verdana", 8.25F, FontStyle.Bold);

        switch (row.Cells["Typ"].Value.ToString())
        {
          case "TM":
            row.Cells["Typ"].Style.ForeColor = Color.Brown;
            break;
          case "TS":
            row.Cells["Typ"].Style.ForeColor = Color.Fuchsia;
            break;
          case "NK":
            row.Cells["Typ"].Style.ForeColor = Color.Blue;
            break;
        }
      }
    }

    public void GeneratePosNr()
    {
      int nr = 1;
      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        // Es werden nur AngebotsPositionen berücksichtigt, die noch keinem Auftrag zugeordnet wurden.
        row.Cells[Const.PosNrHeaderName].Value = nr;
        nr++;
      }
    }

    public void DisableSortmode()
    {
      foreach (DataGridViewColumn col in dgrPositionen.Columns)
      {
        col.SortMode = DataGridViewColumnSortMode.NotSortable;
      }
    }

    private void dgrPositionen_DataSourceChanged(object sender, EventArgs e)
    {
      ColorizeTypColumn();
      ColorizeZuschlagColumn();
      GeneratePosNr();
      DisableSortmode();
      Func.LoadAuftragSumme();
    }


    private void itemMail_Click_1(object sender, EventArgs e)
    {

      String eMail = String.Empty;

      using (var dbContext = new DataBaseDataContext())
      {
        try
        {
          var k = dbContext.Kunde.Where(customer => customer.KundeID.Equals(int.Parse(tbxKdNummer.Text))).FirstOrDefault();

          eMail = k.Email2;

          Func.SendDocumentViaEmail(eMail, "Norka Sanitärkabinen: Auftragsbestätigung", "", ReportManager.GetExportFilepath(EReports.Auftragsbestätigung, int.Parse(tbxAufNummer.Text)));
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
    }

    private void lieferscheinToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Lieferschein, new List<int>() { 1, int.Parse(tbxAufNummer.Text) });
      var r = new Form_Report(report);
      r.Show();
      r.Refresh();
      this.Cursor = Cursors.Default;
    }


  }

}