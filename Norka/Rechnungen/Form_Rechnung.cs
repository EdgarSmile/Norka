
using System.Drawing.Printing;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.ReportingServices.ReportRendering;
using Norka.Common;

namespace Norka.Rechnungen
{
  using Func;
  using System;
  using System.Collections.Generic;
  using System.Windows.Forms;
  using Reports;
  using Exception = System.Exception;
  using System.Drawing;
  using DB;
  using System.Linq;
  using Print;

  public partial class Form_Rechnung : Form
  {
    private decimal positionSumme;
    private decimal nachlass;
    private decimal steuer;
    private decimal gesamt;

    public bool changesDone = false;

    private static log4net.ILog Log = log4net.LogManager.GetLogger("Form_Rechnung");


    public Form_Rechnung()
    {
      InitializeComponent();
      log4net.Config.XmlConfigurator.Configure();
    }

    private void Rechnung_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsSteuer.Steuer". Sie können sie bei Bedarf verschieben oder entfernen.
      this.steuerTableAdapter.Fill(this.dsSteuer.Steuer);
    }

    //Schließen des Rechnungs
    private void itemClose_Click(object sender, EventArgs e)
    {
      Func.FRechnung = null;
      this.Close();
    }


    private void tbxRechNummer_TextChanged(object sender, EventArgs e)
    {
      tbxRechNummer.Text = tbxRechNummer.Text.Replace(",", "");

      if ((tbxRechNummer.Text.Length > 3) & (Func.IsNumeric(tbxRechNummer.Text, true)))
      {
        try
        {
          using (var dbContext = new DataBaseDataContext())
          {

            var r = dbContext.Rechnung.Where(rechnung => rechnung.RechnungID.Equals(tbxRechNummer.Text)).FirstOrDefault();

            var sr = dbContext.Rechnung.Where(rech => rech.StornoID.Equals(tbxRechNummer.Text)).FirstOrDefault();

            var rp = dbContext.Rechnung_Position.Where(rechnung_position => rechnung_position.RechnungID.Equals(tbxRechNummer.Text));

            //var a = dbContext.Auftrag.Where(auftrag => auftrag.AuftragID.Equals(ap.FirstOrDefault().AuftragID)).FirstOrDefault();

            if (r == null) // Zur eingegebenen Nummer ist keine Rechnung vorhanden.
            {
              itemPosNeu.Enabled = false;
              itemPosEdit.Enabled = false;
              itemPosDelete.Enabled = false;
              itemPrint.Enabled = false;
              itemMail.Enabled = false;
              itemStornieren.Enabled = false;
              //itemAuftrag.Enabled = false;
              btnEdit.Enabled = false;
              itemEinbehaltSetzen.Enabled = false;
              itemEinbehaltLoeschen.Enabled = false;
            }
            else
            {
              if (r.Gesamtbetrag < 0) // Stornorechnungen
              {
                tbxRechNummer.ForeColor = Color.Red;
              }
              else if (r.StornoID != null)
              {
                tbxRechNummer.ForeColor = Color.Red;
                itemStornieren.Enabled = false;

                if (sr != null)
                {
                  itemStornieren.Enabled = false;
                }
              }
              else
              {
                if (sr != null)
                {
                  itemStornieren.Enabled = false;
                  tbxRechNummer.ForeColor = Color.Empty;
                }
                else
                {
                  tbxRechNummer.ForeColor = Color.Empty;
                  itemStornieren.Enabled = true;
                }
              }

              if (r.Einbehalt != null)
              {
                itemEinbehaltLoeschen.Enabled = true;
                itemEinbehaltSetzen.Enabled = false;
              }
              else
              {
                itemEinbehaltLoeschen.Enabled = false;
                itemEinbehaltSetzen.Enabled = true;
              }

              tbxKdNummer.Text = r.KundeID.ToString();
              //cobTyp.SelectedItem = a.Typ;
              dgrPositionen.Columns.Clear();
              //dgrPositionen.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = Const.CheckColumHeaderName, Name = Const.CheckColumHeaderName, ThreeState = false });
              dgrPositionen.DataSource = rp;
              dgrPositionen.ClearSelection();
              //Func.FRechnung.ColorizeZuschlagColumn();
              //Func.FRechnung.ColorizeTypColumn();

              //dgrPositionen.AutoGenerateColumns = true;
              dgrPositionen.Columns["PosID"].Visible = false;
              //dgrPositionen.Columns["AuftragID"].Visible = true;
              //dgrPositionen.Columns["Auftrag"].Visible = false;
              dgrPositionen.Columns["Rechnung"].Visible = false;
              dgrPositionen.Columns["RechnungID"].Visible = false;


              btnAnlegen.Enabled = false;
              btnEdit.Enabled = true;

              //btnEdit.Enabled = true;


              switch (r.Typ)
              {
                case "Normal":
                  cobTyp.SelectedItem = r.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "Alternativ-gleichwertig":
                  cobTyp.SelectedItem = r.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "Kurztext":
                  cobTyp.SelectedItem = r.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "LV-abweichend":
                  cobTyp.SelectedItem = r.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                case "Neutral":
                  cobTyp.SelectedItem = r.Typ;
                  tbxEigenerText.Enabled = false;
                  break;
                default:
                  cobTyp.Text = "Eigener Text";
                  tbxEigenerText.Enabled = true;
                  tbxEigenerText.Text = r.Typ;
                  break;
              }

              tbxBauvorhaben.Text = r.BV;

              if (!cobSkonto.Items.Contains(r.Zahlungsbedingung))
              {
                cobSkonto.Items.Add(r.Zahlungsbedingung);
              }

              cobSkonto.SelectedItem = r.Zahlungsbedingung;
              cobBetreff.SelectedItem = r.Betreff;
              tbxNachlass.Text = r.Nachlass.ToString();
              cobNachlass.SelectedItem = r.NachlassArt;
              tbxKdHaenden.Text = r.Empfänger;
              tbxBV2.Text = r.BV2;
              tbxSondertext.Text = r.Sondertext;

              dateRechnung.Value = r.Datum;

              //PFUSCH
              //if (r.Steuer == 0.00m)
              //{
              //    cobMwSt.SelectedIndex = 0;
              //}
              //else if (r.Steuer == 1.00m)
              //{
              //    cobMwSt.SelectedIndex = 1;
              //}
              //else if (r.Steuer == 2.00m)
              //{
              //    cobMwSt.SelectedIndex = 2;
              //}

              cobMwSt.SelectedValue = r.Steuer;
              //Falscher Datentyp @ DB

              if (r.Aufmaß == "ja")
              {
                cbxAufmaß.Checked = true;
              }
              else
              {
                cbxAufmaß.Checked = false;
              }

              if (r.Anfahrt == "ja")
              {
                cbxAnfahrt.Checked = true;
              }
              else
              {
                cbxAnfahrt.Checked = false;
              }

              //itemPosNeu.Enabled = true;
              //itemPosEdit.Enabled = true;
              //itemPosDelete.Enabled = true;
              itemPrint.Enabled = true;
              itemMail.Enabled = true;
              //itemStornieren.Enabled = true;
              //itemAuftrag.Enabled = true;
              Func.LoadRechnungSumme();
            }
          }
        }

        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
          Log.Error("Upps", ex);
        }
        Func.FRechnung.tbxRechNummer.DeselectAll();
      }
      else
      {
        itemPosNeu.Enabled = false;
        itemPosEdit.Enabled = false;
        itemPosDelete.Enabled = false;
        itemPrint.Enabled = false;
        itemMail.Enabled = false;
        itemStornieren.Enabled = false;
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

      using (var dbContext = new DataBaseDataContext())
      {
        try
        {
          var k = dbContext.Kunde.Where(customer => customer.KundeID.Equals(int.Parse(tbxKdNummer.Text))).FirstOrDefault();

          eMail = k.Email2;

          Func.SendDocumentViaEmail(eMail, "Norka Sanitärkabinen: Rechnung", "", ReportManager.GetExportFilepath(EReports.Rechnung, int.Parse(tbxRechNummer.Text)));
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
      PrintManager.PrintDirectlyWithDialog(EReports.Rechnung, new List<int>() { 1, int.Parse(tbxRechNummer.Text) });
      this.Cursor = Cursors.Default;
    }

    private void vorschauToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      var report = ReportManager.GetReportByNameForSelectedRecord(EReports.Rechnung, new List<int>() { 1, int.Parse(tbxRechNummer.Text) });
      var r = new Form_Report(report);
      r.Show();
      r.Refresh();
      this.Cursor = Cursors.Default;
    }


    private void cobNachlass_TextChanged(object sender, EventArgs e)
    {
      //Func.LoadAuftragSumme();
    }

    private void cobMwSt_TextChanged(object sender, EventArgs e)
    {
      Func.LoadRechnungSumme();
    }

    public void setErgebnisse(decimal Pos, decimal Nachl, decimal Mwst, decimal Gesamtsum)
    {
      positionSumme = Pos;
      nachlass = Nachl;
      steuer = Mwst;
      gesamt = Gesamtsum;
    }



    private void tbxKdNummer_TextChanged(object sender, EventArgs e)
    {
      if ((tbxKdNummer.Text.Length > 3) & (Func.IsNumeric(tbxKdNummer.Text, true)))
      {
        try
        {
          using (var dbContext = new DataBaseDataContext())
          {
            var k = dbContext.Kunde.Where(kunde => kunde.KundeID.Equals(int.Parse(tbxKdNummer.Text))).FirstOrDefault();

            if (k != null)
            {
              if (k.Status != "gesperrt")
              {
                tbxKdAnrede.Text = k.Anrede;
                tbxKdName.Text = k.Name_Firma;
                //btnAnlegen.Enabled = true;
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

    //private void dgrPositionen_MouseDown(object sender, MouseEventArgs e)
    //{
    //  // Zeilenmarkierung bei Rechtsklick ermöglichen.
    //  DataGridView.HitTestInfo hti = dgrPositionen.HitTest(e.X, e.Y);

    //  if (hti.Type == DataGridViewHitTestType.Cell)
    //  {
    //    dgrPositionen.CurrentCell = dgrPositionen[hti.ColumnIndex, hti.RowIndex];
    //  }
    //}

    private void itemBearbeiten_Click(object sender, EventArgs e)
    {
      //editAuftragPos();
    }

    private void itemLoeschen_Click(object sender, EventArgs e)
    {
      //deleteAuftragPos();
    }




    private void panel3_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.DrawLine(new Pen(Brushes.Black, 1), 3, 90, 300, 90);
      e.Graphics.DrawLine(new Pen(Brushes.Black, 1), 3, 150, 300, 150);
    }









    private void dateAuftrag_ValueChanged(object sender, EventArgs e)
    {
      //changesDone = true;
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
      //changesDone = true;
    }

    private void tbxBauvorhaben_TextChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void tbxBV2_TextChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void cobSkonto_SelectedIndexChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void cobSkonto_TextChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void cobBetreff_SelectedIndexChanged(object sender, EventArgs e)
    {
      // changesDone = true;
    }

    private void cobNachlass_SelectedIndexChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void cobMwSt_SelectedIndexChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void cbxAufmaß_CheckedChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void cbxAnfahrt_CheckedChanged(object sender, EventArgs e)
    {
      //changesDone = true;
    }

    private void tbxSondertext_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }

    private void tbxKdHaenden_TextChanged(object sender, EventArgs e)
    {
      changesDone = true;
    }




    private void dgrPositionen_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      // Nicht löschen, sonst tauchen unerklärliche Fehlermeldungen auf. Notlösung.
    }

    private void dgrPositionen_CellClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void itemStornieren_Click(object sender, EventArgs e)
    {
      DialogResult result =
              MessageBox.Show(
                  "Möchten Sie die Rechnung wirklich stornieren?",
                  "Rechnung stornieren",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

      if (result == DialogResult.Yes)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          // Zu stornierende Rechnung aus DB laden
          var rechnung = dbContext.Rechnung.Where(r => r.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();


          // Storno-Rechnung erzeugen
          var rechnungStorno = new DB.Rechnung {Datum = DateTime.Today,Steuer = rechnung.Steuer,KundeID = rechnung.KundeID,Typ = rechnung.Typ,BV = rechnung.BV,BV2 = rechnung.BV2,Zahlungsbedingung = rechnung.Zahlungsbedingung,Betreff = rechnung.Betreff,Nachlass = rechnung.Nachlass,NachlassArt = rechnung.NachlassArt,Aufmaß = rechnung.Aufmaß,Anfahrt = rechnung.Anfahrt,Sondertext = rechnung.Sondertext //,
                                                // Gesamtbetrag = rechnung.Gesamtbetrag
                                               };


          try
          {
            // Storno Rechnung in DB speichern
            dbContext.Rechnung.InsertOnSubmit(rechnungStorno);
            dbContext.SubmitChanges();
            tbxRechNummer.ForeColor = Color.Red;
            itemStornieren.Enabled = false;
            tbxRechNummer.DeselectAll();

            // Stornierte Rechnung auf Storno-Rechnung referenzieren
            rechnung.StornoID = rechnungStorno.RechnungID;
            dbContext.SubmitChanges();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
            Log.Error("Fehler beim Einfügen / Referenzieren Storno-Rechnungs Kopf");
            Log.Error(rechnungStorno);
          }

          // Positionen der zu stornierenden Rechnung ermitteln
          var rechnungPositionen = dbContext.Rechnung_Position.Where(rp => rp.RechnungID.Equals(int.Parse(tbxRechNummer.Text)));

          // Auftragspositionen ermitteln, die eine Referenz auf die zu stornierende Rechnung haben.
          var auftragsPositionen = dbContext.Auftrag_Position.Where(ap => ap.RechnungID.Equals(int.Parse(tbxRechNummer.Text)));

          decimal sum = 0.0m;
          foreach (Rechnung_Position rp in rechnungPositionen)
          {
            var rechnungPositionStorno = new Rechnung_Position() {RechnungID = rechnungStorno.RechnungID,Artikel = rp.Artikel,Sondertext = rp.Sondertext,Typ = rp.Typ,AnlagenStk = rp.AnlagenStk,Breite = rp.Breite,Tiefe = rp.Tiefe,Türen = rp.Türen,TW = rp.TW,ZuschlagTür = rp.ZuschlagTür,Einzelpreis = rp.Einzelpreis*-1,Zuschlag = rp.Zuschlag,ZuschlagArt = rp.ZuschlagArt,Alupulver = rp.Alupulver*-1,Montage = rp.Montage,AussparungStk = rp.AussparungStk,AussparungTxt = rp.AussparungTxt,Alternativ1Typ = rp.Alternativ1Typ,Alternativ1Preis = rp.Alternativ1Preis*-1,Alternativ2Typ = rp.Alternativ2Typ,Alternativ2Preis = rp.Alternativ2Preis*-1,SondertextOben = rp.SondertextOben};

            // Increment Gesamtsumme.
            sum += rechnungPositionStorno.Einzelpreis*rechnungPositionStorno.AnlagenStk;
            sum += rechnungPositionStorno.Alupulver*rechnungPositionStorno.AnlagenStk;

            try
            {
              dbContext.Rechnung_Position.InsertOnSubmit(rechnungPositionStorno);
              dbContext.SubmitChanges();

              rechnungPositionStorno.RechnungID = rechnungPositionStorno.RechnungID;
              dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
              Log.Error("Fehler am anlegen einer Storno-Position");
            }



          }
          try
          {
            // Von der Gesamtsumme der Positionen den Nachlass abziehen.
            if(Func.IsNumeric(tbxNachlass.Text,true) & tbxNachlass.Text != "" & cobNachlass.SelectedIndex == 0) // Prozent
            {
              //sum = sum - ((sum * decimal.Parse(tbxNachlass.Text) / 100) * - 1);
              sum = sum - (sum*decimal.Parse(tbxNachlass.Text)/100);
            }
            else if(Func.IsNumeric(tbxNachlass.Text,true) & tbxNachlass.Text != "")
            {
              sum = sum - (decimal.Parse(tbxNachlass.Text)*-1);
            }

            // Zu der Gesamtsumme der Positionen die MwSt hinzurechnen.
            //if (cobMwSt.SelectedIndex == 0)
            //{
            //    sum = sum * 0.19m + sum;
            //}

            sum = sum*(Decimal)cobMwSt.SelectedValue + sum;

            // Rechnung mit Gesamtbetrag updaten.
            rechnungStorno.Gesamtbetrag = sum;
            dbContext.SubmitChanges();
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
            Log.Error("Fehler beim setzen des Gesamtpreises");
          }

          foreach (Auftrag_Position ap in auftragsPositionen)
          {
            try
            {
              ap.RechnungID = null;
              dbContext.SubmitChanges();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
              Log.Error("Fehler beim freigeben einer Auftragsposition");
            }
          }

          // Anzeige der Auftragspositionen wird hiermit aktualisiert.
          // Bewirkt, dass in der Spalte RechnungID alle Werte gelöscht werden, deren Rechnung zuvor storniert wurde.
          // Macht nur Sinn, wenn die Auftragsform geöffnet ist und die zugehörige Rechnung zu den Positonen gerade storniert wird.
          if(Func.FAuftrag != null)
          {
            Func.FAuftrag.tbxAufNummer.Copy();
            Func.FAuftrag.tbxAufNummer.Clear();
            Func.FAuftrag.tbxAufNummer.Paste();

          }

          if(Func.FArchiv != null)
          {
            Func.FArchiv.AnzeigeAktualisieren();
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




    private void MahnungFreundlicheItem_Click(object sender, EventArgs e)
    {
      if (PrintManager.PrintMahnung(EReports.Mahnung, 1, new List<int>() { 1, int.Parse(tbxRechNummer.Text) }) == true)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          var r = dbContext.Rechnung.Where(rech => rech.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();

          r.Mahndatum = DateTime.Today;

          dbContext.SubmitChanges();
        }
      }

    }

    private void MahnungErsteItem_Click(object sender, EventArgs e)
    {
      if (PrintManager.PrintMahnung(EReports.Mahnung, 2, new List<int>() { 1, int.Parse(tbxRechNummer.Text) }) == true)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          var r = dbContext.Rechnung.Where(rech => rech.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();

          r.Mahndatum = DateTime.Today;

          dbContext.SubmitChanges();
        }
      }
    }

    private void MahnungErneuteItem_Click(object sender, EventArgs e)
    {
      if (PrintManager.PrintMahnung(EReports.Mahnung, 3, new List<int>() { 1, int.Parse(tbxRechNummer.Text) }) == true)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          var r = dbContext.Rechnung.Where(rech => rech.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();

          r.Mahndatum = DateTime.Today;

          dbContext.SubmitChanges();
        }
      }
    }

    private void MahnungLetzteItem_Click(object sender, EventArgs e)
    {
      if (PrintManager.PrintMahnung(EReports.Mahnung, 4, new List<int>() { 1, int.Parse(tbxRechNummer.Text) }) == true)
      {
        using (var dbContext = new DataBaseDataContext())
        {
          var r = dbContext.Rechnung.Where(rech => rech.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();

          r.Mahndatum = DateTime.Today;

          dbContext.SubmitChanges();
        }
      }
    }

    private void dgrPositionen_DataSourceChanged(object sender, EventArgs e)
    {
      Func.FRechnung.ColorizeZuschlagColumn();
      Func.FRechnung.ColorizeTypColumn();
    }

    private void itemEinbehaltSetzen_Click(object sender, EventArgs e)
    {
      DateTime datumEinbehalt;

      try
      {
        using (var dbContext = new DataBaseDataContext())
        {
          var r = dbContext.Rechnung.Where(rech => rech.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();

          datumEinbehalt = r.Datum;
          datumEinbehalt = datumEinbehalt.AddYears(5);
          datumEinbehalt = datumEinbehalt.AddMonths(5);
          

          r.Einbehalt = datumEinbehalt;

          dbContext.SubmitChanges();
        }

        itemEinbehaltSetzen.Enabled = false;
        itemEinbehaltLoeschen.Enabled = true;

        Func.FArchiv.AnzeigeAktualisieren();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void itemEinbehaltLoeschen_Click(object sender, EventArgs e)
    {
      try
      {
        using (var dbContext = new DataBaseDataContext())
        {
          var r = dbContext.Rechnung.Where(rech => rech.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();

          r.Einbehalt = null;

          dbContext.SubmitChanges();
        }

        itemEinbehaltSetzen.Enabled = true;
        itemEinbehaltLoeschen.Enabled = false;

        Func.FArchiv.AnzeigeAktualisieren();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        try
        {
          var r = dbContext.Rechnung.Where(rechnung => rechnung.RechnungID.Equals(int.Parse(tbxRechNummer.Text))).FirstOrDefault();

          r.Gesamtbetrag = Decimal.Parse(lblAufGesamt.Text);
          r.Steuer = (Decimal)cobMwSt.SelectedValue;
          dbContext.SubmitChanges();

          changesDone = false;
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
    }








  }

}