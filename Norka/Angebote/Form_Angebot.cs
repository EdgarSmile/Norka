
using Norka.Aufträge;

namespace Norka.Angebote
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
  using Kunden;
  using Norka.Print;
  using Common;
  using CrystalDecisions.CrystalReports.Engine;

  public partial class Form_Angebot : Form
  {
    public bool changesDone = false;

    private int selectedRows = 0;

    // Flag ob bereits ein Auftrag für das Angebot (oder eine Angebotsposition) vorhanden ist
    private bool IsAuftragExisting;

    public Form_Angebot()
    {
      InitializeComponent();
    }

    private void Angebot_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsSteuer.Steuer". Sie können sie bei Bedarf verschieben oder entfernen.
      this.steuerTableAdapter.Fill(this.dsSteuer.Steuer);


      //Wenn dieser Block nicht auskommentiert wird, werden die Angebotsdaten nicht richtig aus der Datenbank geladen.

      //cobTyp.SelectedIndex = 0;
      //cobBetreff.SelectedIndex = 0;
      //cobMwSt.SelectedIndex = 0;
      //cobNachlass.SelectedIndex = 0;
      Func.LoadAngebotSumme();
      //cobBetreff.SelectedIndex = 0;
      cobMwSt.SelectedValue = 0;
      //cobNachlass.SelectedIndex = 0;
      //cobSkonto.SelectedIndex = 0; //Auskommentieren - ansonsten wird das individuelle Zahlungsziel aus der DB immer überschrieben.
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
        tbxSondertextOben.Text = "Sehr geehrte Damen und Herren," + Environment.NewLine + Environment.NewLine +  "anbei erhalten Sie unser Angebot zu Ihrer gefälligen Verwendung.";
      }
      else
      {
        tbxEigenerText.Enabled = false;
        tbxEigenerText.BackColor = Func.CDisabled;
        tbxEigenerText.Text = "";
      }

    }


    //Schließen des Angebotfensters
    private void itemClose_Click(object sender, EventArgs e)
    {
      this.Close();
      Func.FAngebot = null;
    }

    //Anlegen eines Angebots
    private void btnAnlegen_Click(object sender, EventArgs e)
    {
      using (var dbContext = new DataBaseDataContext())
      {
        if ((!string.IsNullOrEmpty(tbxKdName.Text)) | (Func.IsNumeric(tbxKdNummer.Text, true)))
        {
          if (cobBetreff.SelectedIndex != -1)
          {
            try
            {
              var a = new Angebot
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
                            Zahlungsbedingung = cobSkonto.Text == "" ? "Keine" : cobSkonto.Text,
                            Aufmaß = cbxAufmaß.Checked ? "ja" : "nein",
                            Sondertext = tbxSondertextOben.Text == "" ? null : tbxSondertextOben.Text,
                            SondertextUnten =
                                tbxSondertextUnten.Text == "" ? null : tbxSondertextUnten.Text,
                            VorgabedatumRechnung = dateAngVorgabeRech.Value.Date != DateTime.Today.Date ? dateAngVorgabeRech.Value.Date : (DateTime?)null
                          };

              dbContext.Angebot.InsertOnSubmit(a);
              dbContext.SubmitChanges();
              tbxAngNummer.Text = a.AngebotID.ToString();

              //itemPosNeu.Enabled = true;
              btnAnlegen.Enabled = false;
              //btnEdit.Enabled = true;
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
      DeleteAngebotPos();
    }

    /// <summary>
    /// Löscht eine Postion aus dem Angebot.
    /// </summary>
    private void DeleteAngebotPos()
    {
      var dr = dgrPositionen.CurrentRow;

      if (dr != null)
      {
        DialogResult result = MessageBox.Show("Möchten Sie diese Position wirklich löschen?", "Position löschen", MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        if (result == DialogResult.Yes)
        {
          using (var dbContext = new DataBaseDataContext())
          {
            try
            {
              var ap = dbContext.Angebot_Position.Where(angebot_position => angebot_position.PosID.Equals(dr.Cells["PosID"].Value)).FirstOrDefault();

              dbContext.Angebot_Position.DeleteOnSubmit(ap);
              dbContext.SubmitChanges();

              dgrPositionen.DataSource = Func.LoadAngebotPositionenUebersicht();
              GeneratePosNr();
              DisableSortmode();
              Func.LoadAngebotSumme();

              var angebot = dbContext.Angebot.Where(a => a.AngebotID.Equals(int.Parse(tbxAngNummer.Text))).FirstOrDefault();
              angebot.Gesamtbetrag = Decimal.Parse(Func.FAngebot.lblGesamt.Text);
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
      EditAngebotPos();
    }

    private void EditAngebotPos()
    {
      var currentRow = dgrPositionen.CurrentRow;

      if (currentRow != null)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          try
          {
            var ap = dbContext.Angebot_Position.Where(angebotPosition => angebotPosition.PosID.Equals(currentRow.Cells["PosID"].Value)).FirstOrDefault();

            Func.FAngebotPosition = new Kalkulationen.Form_Kalkualtion(ap);
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
          }
        }

        //Mit der übergebenen List lösen!
        Func.FAngebotPosition.SetAngebotNr(tbxAngNummer.Text, "ändern -");
        Func.FAngebotPosition.FormBorderStyle = FormBorderStyle.FixedSingle;
        Func.FAngebotPosition.WindowState = FormWindowState.Normal;
        Func.FAngebotPosition.grpSteuerung.Visible = true;
        Func.FAngebotPosition.toolStrip1.Visible = false;
        Func.FAngebotPosition.btnAendSpeichern.Enabled = false;
        Func.FAngebotPosition.btnPosAnlegen.Enabled = false;
        Func.FAngebotPosition.ShowDialog();
      }
    }

    private void tbxAngNummer_TextChanged(object sender, EventArgs e)
    {
      tbxAngNummer.Text = tbxAngNummer.Text.Replace(",", "");

      if ((tbxAngNummer.Text.Length > 3) & (Func.IsNumeric(tbxAngNummer.Text, true)))
      {
        try
        {
          //var a = DBManager.GetAngebotByID(int.Parse(tbxAngNummer.Text));

          //var ap = DBManager.GetAngebotPositionen(int.Parse(tbxAngNummer.Text));

          using (var dbContext = new DataBaseDataContext())
          {
            // Das Angebotsobjekt zur Angebotsnummer wird aus der DB geladen.
            var a = dbContext.Angebot.Where(angebot => angebot.AngebotID.Equals(tbxAngNummer.Text)).FirstOrDefault();

            // Die Positionen zum Angebotsobjekt werden aus der DB geladen.
            var ap = dbContext.Angebot_Position.Where(angebotPosition => angebotPosition.AngebotID.Equals(tbxAngNummer.Text));

            //Test mit DB Function -->
            //var ap1 = dbContext.GetAngPos(int.Parse(tbxAngNummer.Text));
            //<--

            // Überprüfung, ob zu den Positionen schon Aufträge vorhanden sind.
            if (ap.Count(y => y.AuftragID != null) > 0) // Wenn > 0, dann exisiert mindestens zu einer Angebotsposition ein Auftrag
            {
              IsAuftragExisting = true;
            }
            else
            {
              IsAuftragExisting = false;
            }


            if (a == null) // Zur eingegebenen Nummer ist kein Angebot vorhanden.
            {
              itemPosNeu.Enabled = false;
              itemPosEdit.Enabled = false;
              itemPosDelete.Enabled = false;
              itemPrint.Enabled = false;
              itemMail.Enabled = false;
              itemAuftrag.Enabled = false;
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
              DisableSortmode();
              dgrPositionen.ClearSelection();
              //ColorizeZuschlagColumn();
              //ColorizeTypColumn();
              dgrPositionen.AutoGenerateColumns = true;
              dgrPositionen.Columns["PosID"].Visible = false;
              dgrPositionen.Columns["AngebotID"].Visible = false;
              dgrPositionen.Columns["Angebot"].Visible = false;
              dgrPositionen.Columns["Auftrag"].Visible = false;

              //foreach (DataGridViewColumn x in dgrPositionen.Columns)
              //{
              //  if (x.Name != "Pos")
              //  {
              //    x.ReadOnly = true;
              //  }
              //}

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

              // Selbst definiertes Zahlungsziel der Combobox hinzufügen.
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
              tbxSondertextOben.Text = a.Sondertext;
              tbxSondertextUnten.Text = a.SondertextUnten;

              dateAngebot.Value = a.Datum;

              if (a.VorgabedatumRechnung != null)
              {
                dateAngVorgabeRech.Value = (DateTime)a.VorgabedatumRechnung;
              }
              else
              {
                dateAngVorgabeRech.Value = DateTime.Today;

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

              switch (a.Aufmaß)
              {
                case "ja":
                  cbxAufmaß.Checked = true;
                  break;
                default:
                  cbxAufmaß.Checked = false;
                  break;
              }



              switch (a.Anfahrt)
              {
                case "ja":
                  cbxAnfahrt.Checked = true;
                  break;
                default:
                  cbxAnfahrt.Checked = false;
                  break;
              }

              btnAnlegen.Enabled = false;

              // Ist bereits ein Auftrag vorhanden, dann dürfen die Basisdaten des Angebots nicht mehr verändert werden.
              switch (IsAuftragExisting)
              {
                case true:
                  btnEdit.Enabled = false;
                  break;
                default:
                  btnEdit.Enabled = true;
                  break;
              }

              if (dgrPositionen.Rows.Count > 0)
              {
                itemPrint.Enabled = true;
                itemMail.Enabled = true;
                itemAuftrag.Enabled = true;
              }
              itemPosNeu.Enabled = true;
              //itemPosEdit.Enabled = true;
              //itemPosDelete.Enabled = true;


              Func.LoadAngebotSumme();


            }
          }
        }

        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
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
      this.Cursor = Cursors.WaitCursor;

      String eMail = String.Empty;

      List<int> posIDs = new List<int>();

      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        // Nur alle gecheckten Positionen berücksichtigen.
        var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (cell.Value != null && (bool)cell.Value == true)
        {
          Angebot_Position pos = row.DataBoundItem as Angebot_Position;
          if (pos != null)
          {
            posIDs.Add(pos.PosID);
          }
        }

      }


      using (var dbContext = new DataBaseDataContext())
      {
        try
        {
          var k = dbContext.Kunde.Where(customer => customer.KundeID.Equals(int.Parse(tbxKdNummer.Text))).FirstOrDefault();

          eMail = k.Email2;

          if (posIDs.Count == 0)
          {

            Func.SendDocumentViaEmail(eMail, "Norka Sanitärkabinen: Angebot", "", ReportManager.GetExportFilepath(EReports.Angebot, int.Parse(tbxAngNummer.Text), new List<int>() { 1, 0 }));
          }
          else
          {
            Func.SendDocumentViaEmail(eMail, "Norka Sanitärkabinen: Angebot", "", ReportManager.GetExportFilepath(EReports.Angebot, int.Parse(tbxAngNummer.Text), posIDs));
          }



        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }

      posIDs = null;

      this.Cursor = Cursors.Default;
    }


    private void AngebotSofortdruckToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      List<int> posIDs = new List<int>();

      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        // Nur alle gecheckten Positionen berücksichtigen.
        var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (cell.Value != null && (bool)cell.Value == true)
        {
          Angebot_Position pos = row.DataBoundItem as Angebot_Position;
          if (pos != null)
          {
            posIDs.Add(pos.PosID);
          }
        }

      }



      if (posIDs.Count == 0)
      {
        PrintManager.PrintDirectlyWithDialog(EReports.Angebot, new List<int>() { 1, int.Parse(tbxAngNummer.Text) }, new List<int>() { 1, 0 });
      }
      else
      {
        PrintManager.PrintDirectlyWithDialog(EReports.Angebot, new List<int>() { 1, int.Parse(tbxAngNummer.Text) }, posIDs);
      }


      posIDs = null;

      this.Cursor = Cursors.Default;
    }

    private void AngebotVorschauToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      List<int> posIDs = new List<int>();

      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        // Nur alle gecheckten Positionen berücksichtigen.
        var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (cell.Value != null && (bool)cell.Value == true)
        {
          Angebot_Position pos = row.DataBoundItem as Angebot_Position;
          if (pos != null)
          {
            posIDs.Add(pos.PosID);
          }
        }

      }


      ReportDocument report;

      if (posIDs.Count == 0)
      {
        report = ReportManager.GetReportByNameForSelectedRecord(EReports.Angebot, new List<int>() { 1, int.Parse(tbxAngNummer.Text) }, new List<int>() { 1, 0 });
      }
      else
      {
        report = ReportManager.GetReportByNameForSelectedRecord(EReports.Angebot, new List<int>() { 1, int.Parse(tbxAngNummer.Text) }, posIDs);
      }

      var r = new Form_Report(report);
      r.Show();
      r.Refresh();

      posIDs = null;

      this.Cursor = Cursors.Default;
    }


    private void cobNachlass_TextChanged(object sender, EventArgs e)
    {
      Func.LoadAngebotSumme();
    }

    private void cobMwSt_TextChanged(object sender, EventArgs e)
    {
      Func.LoadAngebotSumme();
    }

    //public void setErgebnisse(decimal Pos, decimal Nachl, decimal Mwst, decimal Gesamtsum)
    //{
    //  positionSumme = Pos;
    //  nachlass = Nachl;
    //  steuer = Mwst;
    //  gesamt = Gesamtsum;
    //}

    private void btnEdit_Click(object sender, EventArgs e)
    {
      using (var dbContext = new DataBaseDataContext())
      {
        try
        {
          var a = dbContext.Angebot.Where(angebot => angebot.AngebotID.Equals(int.Parse(tbxAngNummer.Text))).FirstOrDefault();

          a.Anfahrt = cbxAnfahrt.Checked ? "ja" : "nein";
          a.KundeID = int.Parse(tbxKdNummer.Text);
          a.Empfänger = tbxKdHaenden.Text == "" ? null : tbxKdHaenden.Text;
          a.Datum = dateAngebot.Value;
          a.Typ = cobTyp.Text == "Eigener Text" ? tbxEigenerText.Text : cobTyp.Text;
          a.Betreff = cobBetreff.Text;
          a.BV = tbxBauvorhaben.Text == "" ? null : tbxBauvorhaben.Text;
          a.BV2 = tbxBV2.Text == "" ? null : tbxBV2.Text;
          a.Gesamtbetrag = Decimal.Parse(lblGesamt.Text);
          a.Nachlass = Decimal.Parse(tbxNachlass.Text);
          a.NachlassArt = cobNachlass.Text;
          a.Steuer = (Decimal)cobMwSt.SelectedValue;
          a.Zahlungsbedingung = cobSkonto.Text;
          a.Aufmaß = cbxAufmaß.Checked ? "ja" : "nein";
          a.Sondertext = tbxSondertextOben.Text == "" ? null : tbxSondertextOben.Text;
          a.SondertextUnten = tbxSondertextUnten.Text == "" ? null : tbxSondertextUnten.Text;
          a.VorgabedatumRechnung = dateAngVorgabeRech.Value.Date != DateTime.Today.Date ? dateAngVorgabeRech.Value.Date : (DateTime?)null;


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
          var k = DBManager.GetCustomerByID(int.Parse(tbxKdNummer.Text));

          if (k != null)
          {
            if (k.Status != "gesperrt")
            {
              tbxKdAnrede.Text = k.Anrede;
              tbxKdName.Text = k.Name_Firma;
              btnAnlegen.Enabled = tbxAngNummer.Text == "" ? true : false;
            }
            else
            {
              MessageBox.Show("Der Kunde ist gesperrt.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Information);
              btnAnlegen.Enabled = false;
            }

            changesDone = true;
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

        if (row.Cells["AuftragID"].Value == null)
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
      EditAngebotPos();
    }

    private void itemLoeschen_Click(object sender, EventArgs e)
    {
      DeleteAngebotPos();
    }


    private void itemAngNeu_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      if (changesDone == true)
      {
        DialogResult result = MessageBox.Show("Nicht gespeicherte Werte gehen verloren.\nMöchten Sie die Änderungen zuerst speichern?", "Bestätigung",
                                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        switch (result)
        {
          case DialogResult.Yes:
            btnEdit.PerformClick();
            changesDone = false;
            Func.FAngebot.Close();
            Func.FAngebot = null;
            Func.FAngebot = new Form_Angebot { MdiParent = Func.FStart, Text = "Angebot" };
            Func.FAngebot.Show();
            Func.FAngebot.WindowState = FormWindowState.Maximized;
            break;
          case DialogResult.No:
            changesDone = false;
            Func.FAngebot.Close();
            Func.FAngebot = null;
            Func.FAngebot = new Form_Angebot { MdiParent = Func.FStart, Text = "Angebot" };
            Func.FAngebot.Show();
            Func.FAngebot.WindowState = FormWindowState.Maximized;
            break;
        }
      }
      else
      {
        Func.FAngebot.Close();
        Func.FAngebot = null;
        Func.FAngebot = new Form_Angebot { MdiParent = Func.FStart, Text = "Angebot" };
        Func.FAngebot.Show();
        Func.FAngebot.WindowState = FormWindowState.Maximized;
      }


      this.Cursor = Cursors.Default;

    }

    private void itemPosNeu_Click_1(object sender, EventArgs e)
    {
      if (Func.FAngebotPosition == null)
      {
        Func.FAngebotPosition = new Kalkulationen.Form_Kalkualtion(false);
      }

      Func.FAngebotPosition.SetAngebotNr(tbxAngNummer.Text, "anlegen -");
      Func.FAngebotPosition.FormBorderStyle = FormBorderStyle.FixedSingle;
      Func.FAngebotPosition.WindowState = FormWindowState.Normal;
      Func.FAngebotPosition.grpSteuerung.Visible = true;
      Func.FAngebotPosition.toolStrip1.Visible = false;
      Func.FAngebotPosition.btnPosAnlegen.Enabled = false;
      Func.FAngebotPosition.ShowDialog();
    }

    private void cobSkonto_DropDown(object sender, EventArgs e)
    {
      if (cobSkonto.Items.Count == 4)
      {
        //cobSkonto.Items.RemoveAt(3);
      }
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.DrawLine(new Pen(Brushes.Black, 1), 3, 90, 300, 90);
      e.Graphics.DrawLine(new Pen(Brushes.Black, 1), 3, 150, 300, 150);
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
        Func.LoadAngebotSumme();
        changesDone = true;
      }
    }

    private void Form_Angebot_Leave(object sender, EventArgs e)
    {
      //if (changesDone == true)
      //{
      //  if (btnEdit.Enabled == false & tbxAngNummer.Text != "")
      //  {
      //Func.FAngebot = null;
      //this.Close();
      //}
      //else if (IsAngebotFormControlsDefault() == false)
      //{
      //  DialogResult result = MessageBox.Show("Es sind noch nicht gespeicherte Änderungen vorhanden.\nMöchten Sie die Änderungen speichern?", "Bestätigung.",
      //                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

      //  if (result == DialogResult.Yes)
      //  {
      //    if (tbxKdNummer.Text != "")
      //    {
      //      btnAnlegen.PerformClick();
      //      //Func.FAngebot = null;
      //      //this.Close();
      //    }
      //    else
      //    {
      //      MessageBox.Show("Bitte wählen Sie einen gültigen Kunden aus.", "Ungültige Kundenauswahl", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //      tbxKdNummer.Focus();
      //    }
      //  }
      //}
      //}
    }

    private void dateAngebot_ValueChanged(object sender, EventArgs e)
    {
      changesDone = true;
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

      if (row.Cells["AuftragID"].Value == null)
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
        var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (row.Cells["AuftragID"].Value == null)
        {
          if (cell.Value == null)
          {
            cell.Value = true;
            selectedRows++;
          }
          else switch ((bool)cell.Value)
            {
              case true:
                cell.Value = false;
                selectedRows--;
                break;
              case false:
                cell.Value = true;
                selectedRows++;
                break;
            }
        }
      }

    }

    private void itemMarkKein_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (row.Cells["AuftragID"].Value == null)
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
        var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (row.Cells["AuftragID"].Value == null)
        {
          cell.Value = true;
        }

      }
      selectedRows = dgrPositionen.Rows.Count;
    }

    private void itemAuftrag_DropDownOpening(object sender, EventArgs e)
    {
      var row = dgrPositionen.CurrentRow;

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
        itemAllPos.Enabled = true;

      }
      else if (selectedRows == 0)
      {
        itemMarkPos.Enabled = false;
        itemAllPos.Enabled = true;
      }

      int posMitAuftrag = 0;
      foreach (DataGridViewRow r in dgrPositionen.Rows)
      {
        if (r.Cells["AuftragID"].Value != null)
        {
          posMitAuftrag++;
        }
      }

      if (posMitAuftrag == dgrPositionen.Rows.Count)
      {
        itemAllPos.Enabled = false;
        itemRech.Enabled = false;
      }
      else
      {
        itemAllPos.Enabled = true;
        itemRech.Enabled = true;
      }


    }

    private void itemAllPos_Click(object sender, EventArgs e)
    {
      CreateOrderForOfferPositionsWithoutOrderID();
    }


    /// <summary>
    /// Diese Methode erstellt einen Auftrag über alle Angebotspositionen, zu denen noch kein Auftrag exisitiert.
    /// </summary>
    private Auftrag CreateOrderForOfferPositionsWithoutOrderID()
    {

      Auftrag auftrag;

      using (var dbContext = new DataBaseDataContext())
      {

        var angebot = dbContext.Angebot.Where(ang => ang.AngebotID.Equals(int.Parse(tbxAngNummer.Text))).FirstOrDefault();

        auftrag = new Auftrag
                                {
                                  Datum = DateTime.Today,
                                  Typ = angebot.Typ,
                                  BV = angebot.BV,
                                  BV2 = angebot.BV2,
                                  Zahlungsbedingung = angebot.Zahlungsbedingung,
                                  Betreff = angebot.Betreff,
                                  Nachlass = angebot.Nachlass,
                                  NachlassArt = angebot.NachlassArt,
                                  Steuer = angebot.Steuer,
                                  Aufmaß = angebot.Aufmaß,
                                  Anfahrt = angebot.Anfahrt,
                                  Sondertext = angebot.Sondertext,
                                  SondertextUnten = angebot.SondertextUnten,
                                  KundeID = angebot.KundeID,
                                  //Gesamtbetrag = angebot.Gesamtbetrag,
                                  Empfänger = angebot.Empfänger,
                                  VorgabedatumRechnung = dateAngVorgabeRech.Value.Date != DateTime.Today.Date ? dateAngVorgabeRech.Value.Date : (DateTime?)null
                                };

        try
        {
          dbContext.Auftrag.InsertOnSubmit(auftrag);
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
          if (row.Cells["AuftragID"].Value == null)
          {
            var angebotPosition = dbContext.Angebot_Position.Where(ap => ap.PosID.Equals(row.Cells["PosID"].Value)).FirstOrDefault();

            var auftragPosition = new Auftrag_Position
                                      {
                                        AuftragID = auftrag.AuftragID,
                                        Artikel = angebotPosition.Artikel,
                                        Sondertext = angebotPosition.Sondertext,
                                        Typ = angebotPosition.Typ,
                                        AnlagenStk = angebotPosition.AnlagenStk,
                                        Breite = angebotPosition.Breite,
                                        Tiefe = angebotPosition.Tiefe,
                                        Türen = angebotPosition.Türen,
                                        TW = angebotPosition.TW,
                                        ZuschlagTür = angebotPosition.ZuschlagTür,
                                        Einzelpreis = angebotPosition.Einzelpreis,
                                        Zuschlag = angebotPosition.Zuschlag,
                                        ZuschlagArt = angebotPosition.ZuschlagArt,
                                        Alupulver = angebotPosition.Alupulver,
                                        Montage = angebotPosition.Montage,
                                        AussparungStk = angebotPosition.AussparungStk,
                                        AussparungTxt = angebotPosition.AussparungTxt,
                                        Alternativ1Typ = angebotPosition.Alternativ1Typ,
                                        Alternativ1Preis = angebotPosition.Alternativ1Preis,
                                        Alternativ2Typ = angebotPosition.Alternativ2Typ,
                                        Alternativ2Preis = angebotPosition.Alternativ2Preis,
                                        SondertextOben = angebotPosition.SondertextOben,
                                        Oberlicht = angebotPosition.Oberlicht,
                                        SonderartikelEinheit = angebotPosition.SonderartikelEinheit
                                      };


            // Increment Gesamtsumme.
            sum += auftragPosition.Einzelpreis * auftragPosition.AnlagenStk;
            sum += auftragPosition.Alupulver * auftragPosition.AnlagenStk;
            try
            {
              // Auftragsposition in DB speichern
              dbContext.Auftrag_Position.InsertOnSubmit(auftragPosition);
              dbContext.SubmitChanges();
              // Auftragsposition auf Auftrag referenzieren.
              angebotPosition.AuftragID = auftrag.AuftragID;
              //dbContext.SubmitChanges();

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

          // Auftrag mit Gesamtbetrag updaten.
          auftrag.Gesamtbetrag = sum;
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }

      }

      btnEdit.Enabled = false;
      itemPosNeu.Enabled = false;
      itemPosEdit.Enabled = false;
      itemPosDelete.Enabled = false;


      // Positionsgrid aktualisieren
      Func.FAngebot.dgrPositionen.DataSource = Func.LoadAngebotPositionenUebersicht();
      //GeneratePosNr();


      selectedRows = 0;

      return auftrag;
    }

    /// <summary>
    /// Diese Methode erstellt für das angezeigte Angebot implizit einen Auftrag und danach eine Rechnung und öffnet den Sofortdruck-Dialog
    /// </summary>
    /// <param name="schlussrechnung">Gibt an ob es sich um eine Schlussrechnung handelt (true) oder nicht (false)</param>
    private void CreateInvoiceForOrderPositions(bool schlussrechnung)
    {
      // Auftrag erstellen
      Auftrag auftrag = CreateOrderForOfferPositionsWithoutOrderID();

      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        // Auftragspositionen zum Auftrag ermitteln.
        var auftrag_positionen = dbContext.Auftrag_Position.Where(ap => ap.AuftragID.Equals(auftrag.AuftragID));


        var rechnung = new DB.Rechnung
                           {
                             Datum = dateAngVorgabeRech.Value.Date != DateTime.Today.Date ? dateAngVorgabeRech.Value.Date : DateTime.Today.Date,
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
                             Schlussrechnung = schlussrechnung ? "ja" : null
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

        foreach (Auftrag_Position pos in auftrag_positionen)
        {

          var rechnungPosition = new Rechnung_Position()
          {
            RechnungID = rechnung.RechnungID,
            Artikel = pos.Artikel,
            Sondertext = pos.Sondertext,
            Typ = pos.Typ,
            AnlagenStk = pos.AnlagenStk,
            Breite = pos.Breite,
            Tiefe = pos.Tiefe,
            Türen = pos.Türen,
            TW = pos.TW,
            ZuschlagTür = pos.ZuschlagTür,
            Einzelpreis = pos.Einzelpreis,
            Zuschlag = pos.Zuschlag,
            ZuschlagArt = pos.ZuschlagArt,
            Alupulver = pos.Alupulver,
            Montage = pos.Montage,
            AussparungStk = pos.AussparungStk,
            AussparungTxt = pos.AussparungTxt,
            Alternativ1Typ = pos.Alternativ1Typ,
            Alternativ1Preis = pos.Alternativ1Preis,
            Alternativ2Typ = pos.Alternativ2Typ,
            Alternativ2Preis = pos.Alternativ2Preis,
            SondertextOben = pos.SondertextOben,
            SonderartikelEinheit = pos.SonderartikelEinheit
          };


          // Increment Gesamtsumme.
          sum += rechnungPosition.Einzelpreis * rechnungPosition.AnlagenStk;
          sum += rechnungPosition.Alupulver * rechnungPosition.AnlagenStk;

          try
          {
            dbContext.Rechnung_Position.InsertOnSubmit(rechnungPosition);
            dbContext.SubmitChanges();
            pos.RechnungID = rechnung.RechnungID;
            dbContext.SubmitChanges();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
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
      this.Cursor = Cursors.WaitCursor;

      using (var dbContext = new DataBaseDataContext())
      {
        // Aktuelles Angebotsobjekt aus DB ermitteln.
        var angebot = dbContext.Angebot.Where(ang => ang.AngebotID.Equals(int.Parse(tbxAngNummer.Text))).FirstOrDefault();

        // Auftragsobjekt anlegen und mit Daten des Angebots füllen. (Außer Gesamtbetrag)
        var auftrag = new DB.Auftrag
                          {
                            Datum = DateTime.Today,
                            Typ = angebot.Typ,
                            BV = angebot.BV,
                            BV2 = angebot.BV2,
                            Zahlungsbedingung = angebot.Zahlungsbedingung,
                            Betreff = angebot.Betreff,
                            Nachlass = angebot.Nachlass,
                            NachlassArt = angebot.NachlassArt,
                            Steuer = angebot.Steuer,
                            Aufmaß = angebot.Aufmaß,
                            Anfahrt = angebot.Anfahrt,
                            Sondertext = angebot.Sondertext,
                            SondertextUnten = angebot.SondertextUnten,
                            KundeID = angebot.KundeID,
                            Empfänger = angebot.Empfänger,
                            VorgabedatumRechnung = dateAngVorgabeRech.Value.Date != DateTime.Today.Date ? dateAngVorgabeRech.Value.Date : (DateTime?)null
                          };

        try
        {
          // Auftrag in DB speichern.
          dbContext.Auftrag.InsertOnSubmit(auftrag);
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
          var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

          if (cell.Value != null)
          {
            // Aktuelle, gecheckte Angebotsposition im FOREACH-Durchlauf aus DB auslesen.
            var angebotPosition = dbContext.Angebot_Position.Where(ap => ap.PosID.Equals(row.Cells["PosID"].Value)).FirstOrDefault();

            // Neue Auftragsposition anlegen und mit Daten aus Angebotsposition füllen.
            var auftragPosition = new Auftrag_Position
                                               {
                                                 AuftragID = auftrag.AuftragID,
                                                 Artikel = angebotPosition.Artikel,
                                                 Sondertext = angebotPosition.Sondertext,
                                                 Typ = angebotPosition.Typ,
                                                 AnlagenStk = angebotPosition.AnlagenStk,
                                                 Breite = angebotPosition.Breite,
                                                 Tiefe = angebotPosition.Tiefe,
                                                 Türen = angebotPosition.Türen,
                                                 TW = angebotPosition.TW,
                                                 ZuschlagTür = angebotPosition.ZuschlagTür,
                                                 Einzelpreis = angebotPosition.Einzelpreis,
                                                 Zuschlag = angebotPosition.Zuschlag,
                                                 ZuschlagArt = angebotPosition.ZuschlagArt,
                                                 Alupulver = angebotPosition.Alupulver,
                                                 Montage = angebotPosition.Montage,
                                                 AussparungStk = angebotPosition.AussparungStk,
                                                 AussparungTxt = angebotPosition.AussparungTxt,
                                                 Alternativ1Typ = angebotPosition.Alternativ1Typ,
                                                 Alternativ1Preis = angebotPosition.Alternativ1Preis,
                                                 Alternativ2Typ = angebotPosition.Alternativ2Typ,
                                                 Alternativ2Preis = angebotPosition.Alternativ2Preis,
                                                 SondertextOben = angebotPosition.SondertextOben,
                                                 Oberlicht =  angebotPosition.Oberlicht,
                                                 SonderartikelEinheit = angebotPosition.SonderartikelEinheit
                                               };

            // Increment Gesamtsumme.
            sum += auftragPosition.Einzelpreis * auftragPosition.AnlagenStk;
            sum += auftragPosition.Alupulver * auftragPosition.AnlagenStk;

            try
            {
              // Auftragsposition in DB speichern.
              dbContext.Auftrag_Position.InsertOnSubmit(auftragPosition);

              // Angebotsposition auf Auftrag referenzieren.
              angebotPosition.AuftragID = auftrag.AuftragID;
              //dbContext.SubmitChanges();

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
          // Auftrag mit Gesamtbetrag updaten.
          auftrag.Gesamtbetrag = sum;
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }


      }
      // Refresh Angebotspositionen
      Func.FAngebot.dgrPositionen.DataSource = Func.LoadAngebotPositionenUebersicht();
      //GeneratePosNr();
      btnEdit.Enabled = false;
      // itemPosNeu.Enabled = false;
      itemPosEdit.Enabled = false;
      itemPosDelete.Enabled = false;

      selectedRows = 0;
      this.Cursor = Cursors.Default;

    }

   


    private bool IsAngebotFormControlsDefault()
    {
      bool state = false;

      if (tbxAngNummer.Text == ""
        & dateAngebot.Value.ToShortDateString() == DateTime.Today.ToShortDateString()
        & cobTyp.Text == "" & tbxEigenerText.Text == ""
        & tbxBauvorhaben.Text == ""
        & tbxBV2.Text == ""
        & cobSkonto.Text == ""
        & cobBetreff.Text == ""
        & tbxNachlass.Text == "0"
        & cobNachlass.Text == ""
        & cobMwSt.Text == ""
        & cbxAnfahrt.Checked == false
        & cbxAufmaß.Checked == false
        & tbxSondertextOben.Text == ""
        & tbxSondertextUnten.Text == ""
        & tbxKdNummer.Text == ""
        & tbxKdHaenden.Text == "")
      {
        state = true;
      }

      return state;
    }



    private void auftragÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DataGridViewRow row = dgrPositionen.CurrentRow;

      if (Func.FAuftrag == null)
      {
        Func.FAuftrag = new Form_Auftrag();
        Func.FAuftrag.MdiParent = Func.FStart;

        Func.FAuftrag.Show();
        Func.FAuftrag.WindowState = FormWindowState.Maximized;

        Func.FAuftrag.Text = "Auftrag";
        Func.FAuftrag.tbxAufNummer.Text = row.Cells["AuftragID"].Value.ToString();
        //Func.FAuftrag.tbxKdNummer.Text = pCurrentRow.Cells[2].Value.ToString();

      }
      else
      {
        Func.FAuftrag.Show();
        Func.FAuftrag.WindowState = FormWindowState.Maximized;
        Func.FAuftrag.tbxAufNummer.Text = row.Cells["AuftragID"].Value.ToString();
        //Func.FAuftrag.tbxKdNummer.Text = pCurrentRow.Cells[2].Value.ToString();      
      }
    }

    private void ctmAngebot_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (dgrPositionen.Rows.Count > 0)
      {
        if (dgrPositionen.CurrentRow.Cells["AuftragID"].Value != null)
        {
          itemBearbeiten.Enabled = false;
          itemLoeschen.Enabled = false;
          itemAuftragÖffnen.Enabled = true;
        }
        else
        {
          itemBearbeiten.Enabled = true;
          itemLoeschen.Enabled = true;
          itemAuftragÖffnen.Enabled = false;
        }
      }

    }

    private void dgrPositionen_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      if (dgrPositionen.Rows.Count > 0)
      {
        itemPrint.Enabled = true;
        itemMail.Enabled = true;
        itemAuftrag.Enabled = true;
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
        itemAuftrag.Enabled = true;
        itemMarkAlle.Enabled = true;
        itemMarkKein.Enabled = true;
      }
      else
      {
        itemPrint.Enabled = false;
        itemMail.Enabled = false;
        itemAuftrag.Enabled = false;
        itemMarkAlle.Enabled = false;
        itemMarkKein.Enabled = false;
        itemPosEdit.Enabled = false;
        itemPosDelete.Enabled = false;
      }
    }



    private void BegleitschreibenVorschauToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Begleitschreiben, new List<int>() { 1, int.Parse(tbxAngNummer.Text) });
      var r = new Form_Report(report);
      r.Show();
      r.Refresh();
      this.Cursor = Cursors.Default;
    }

    private void BegleitschribenSofortdruckToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      PrintManager.PrintDirectlyWithDialog(EReports.Begleitschreiben, new List<int>() { 1, int.Parse(tbxAngNummer.Text) });
      this.Cursor = Cursors.Default;
    }

    private void faxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      List<int> posIDs = new List<int>();

      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        // Nur alle gecheckten Positionen berücksichtigen.
        var cell = row.Cells[Const.CheckColumHeaderName] as DataGridViewCheckBoxCell;

        if (cell.Value != null && (bool)cell.Value == true)
        {
          Angebot_Position pos = row.DataBoundItem as Angebot_Position;
          if (pos != null)
          {
            posIDs.Add(pos.PosID);
          }
        }

      }

      if (posIDs.Count == 0)
      {
        PrintManager.Fax(EReports.Angebot, new List<int>() { 1, int.Parse(tbxAngNummer.Text) }, new List<int>() { 1, 0 });
      }
      else
      {
        PrintManager.Fax(EReports.Angebot, new List<int>() { 1, int.Parse(tbxAngNummer.Text) }, posIDs);
      }




      posIDs = null;
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
            Func.FKundeMiniAuswahl = new Form_Kunde_MiniAuswahl(resultAnzeige, false);
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
      Font f = new Font("Verdana", 8.25F, FontStyle.Bold);


      foreach (DataGridViewRow row in dgrPositionen.Rows)
      {
        row.Cells["Typ"].Style.Font = f;



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
        row.Cells[Const.PosNrHeaderName].Value = nr;
        nr++;
      }
    }

    /// <summary>
    /// Deaktiviert für alle Spalten im DataGridView die Sortieroption
    /// </summary>
    public void DisableSortmode()
    {
      foreach (DataGridViewColumn col in dgrPositionen.Columns)
      {
        col.SortMode = DataGridViewColumnSortMode.NotSortable;
      }
    }

    private void itemAllPosRech_Click(object sender, EventArgs e)
    {
      CreateInvoiceForOrderPositions(false);
    }

    private void itemAllPosSchluss_Click(object sender, EventArgs e)
    {
      CreateInvoiceForOrderPositions(true);
    }

    private void duplizierenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var currentRow = dgrPositionen.CurrentRow;

      if (currentRow != null)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          try
          {
            var ap = dbContext.Angebot_Position.Where(angebotPosition => angebotPosition.PosID.Equals(currentRow.Cells["PosID"].Value)).FirstOrDefault();

            Angebot_Position ap_new = (Angebot_Position)Entity.Copy(ap, new Angebot_Position());

            dbContext.Angebot_Position.InsertOnSubmit(ap_new);

            dbContext.SubmitChanges();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
          }
        }

        Func.FAngebot.dgrPositionen.Columns.Clear();
        Func.FAngebot.dgrPositionen.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren", Name = "Markieren" });
        Func.FAngebot.dgrPositionen.Columns.Add(new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell(), HeaderText = Const.PosNrHeaderName, Name = Const.PosNrHeaderName, Visible = true });
        Func.FAngebot.dgrPositionen.DataSource = Func.LoadAngebotPositionenUebersicht();
        //Func.FAngebot.ColorizeZuschlagColumn();
        //Func.FAngebot.ColorizeTypColumn();
        //Func.FAngebot.GeneratePosNr();
        Func.FAngebot.DisableSortmode();
        Func.FAngebot.dgrPositionen.Columns["PosID"].Visible = false;
        Func.FAngebot.dgrPositionen.Columns["AngebotID"].Visible = false;
        Func.FAngebot.dgrPositionen.Columns["Angebot"].Visible = false;
        Func.FAngebot.dgrPositionen.Columns["Auftrag"].Visible = false;
        
      }
    }

    private void dgrPositionen_DataSourceChanged(object sender, EventArgs e)
    {
      ColorizeZuschlagColumn();
      ColorizeTypColumn();
      GeneratePosNr();
    }

    //private void dgrPositionen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    //{
    //  DataGridView x = (DataGridView)sender;

    //  DataGridViewColumn c = x.CurrentCell.OwningColumn;

    //  if(c.Name == "Pos")
    //  {
    //    MessageBox.Show("hallo");
    //  }
    //}


  }
}













