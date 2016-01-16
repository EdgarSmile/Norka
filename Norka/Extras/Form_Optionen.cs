using System;
using System.Linq;
using System.Windows.Forms;
using Norka.DB;

namespace Norka.Extras
{
  using Func;


  /// <summary>
  /// 
  /// </summary>
  public partial class Form_Optionen : Form
  {
    #region Variablen

    /// <summary>
    /// Obejekt enthält sämtliche Kalkulationsparameter.
    /// Es wird bei jeder Kalkulation erneut aus der DB geladen und enthält somit immer die aktuellesten Werte.
    /// </summary>
    private Kalkulationsparameter kalkParamDB;

    /// <summary>
    /// Objekt enthält sämtliche Firmendaten.
    /// </summary>
    private Firmendaten firmendatenDB;

    #endregion


    #region Kontruktoren

    /// <summary>
    /// Initialisiert eine neue Instanz der<see cref="Form_Optionen"/> Klasse.
    /// </summary>
    public Form_Optionen()
    {
      InitializeComponent();
    }

    #endregion


    #region Methoden

    /// <summary>
    /// Lädt die Kalkulationsparameter aus der DB in die entsprechenden Textboxen.
    /// </summary>
    private void LoadKalkulationsparameter()
    {
      try
      {
        using (var dbContext = new DataBaseDataContext())
        {
          if (kalkParamDB != null)
          {
            kalkParamDB = null;
            kalkParamDB = dbContext.Kalkulationsparameter.Where(kp => kp.ParamterID.Equals(1)).FirstOrDefault();

          }
          else
          {
            kalkParamDB = dbContext.Kalkulationsparameter.Where(kp => kp.ParamterID.Equals(1)).FirstOrDefault();
          }

          tbxPlattenkostenTM.Text = kalkParamDB.PlattenkostenTM.ToString("#00.00");
          tbxPlattenkostenTS.Text = kalkParamDB.PlattenkostenTS.ToString("#00.00");
          tbxPlattenkostenNK.Text = kalkParamDB.PlattenkostenNK.ToString("#00.00");
          tbxAluprofilkosten.Text = kalkParamDB.Aluprofilkosten.ToString("##0.00");
          tbxBeschlagkosten.Text = kalkParamDB.Beschlagkosten.ToString("#00.00");
          tbxFixkosten.Text = kalkParamDB.Fixkosten.ToString("##0.00");
          tbxPulverkosten.Text = kalkParamDB.Pulverkosten.ToString("##0.00");
          tbxMontagekosten.Text = kalkParamDB.Montagekosten.ToString("#00.00");
          tbxLohnkostenTM.Text = kalkParamDB.LohnkostenTM.ToString("#00.00");
          tbxLohnkostenTS.Text = kalkParamDB.LohnkostenTS.ToString("#00.00");
          tbxLohnkostenNK.Text = kalkParamDB.LohnkostenNK.ToString("#00.00");
          tbxOberlichtTM.Text = kalkParamDB.OberlichtkostenTM.ToString("#00.00");
          tbxOberlichtTS.Text = kalkParamDB.OberlichtkostenTS.ToString("#00.00");
          tbxOberlichtNK.Text = kalkParamDB.OberlichtkostenNK.ToString("#00.00");
          tbxGewinn.Text = (((kalkParamDB.Gewinn) - 1) * 100).ToString("0.00#");
          //tbxMwst.Text = (((kalkParamDB.Mwst) - 1) * 100).ToString("0.00#");
          tbxSonderzuschlag.Text = (((kalkParamDB.Sonderzuschlag) - 1) * 100).ToString("0.00#");
          tbxAussparung.Text = ((kalkParamDB.Aussparung).ToString("0.00#"));
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    /// <summary>
    /// Speichert die Kalkulationsparameter in der DB.
    /// </summary>
    private void SaveKalkulationsparameter()
    {
      try
      {
        using (var dbContext = new DataBaseDataContext())
        {
          if (kalkParamDB != null)
          {
            kalkParamDB = null;
            kalkParamDB = dbContext.Kalkulationsparameter.Where(kp => kp.ParamterID.Equals(1)).FirstOrDefault();

          }
          else
          {
            kalkParamDB = dbContext.Kalkulationsparameter.Where(kp => kp.ParamterID.Equals(1)).FirstOrDefault();
          }


          kalkParamDB.PlattenkostenTM = Decimal.Parse(tbxPlattenkostenTM.Text);
          kalkParamDB.PlattenkostenTS = Decimal.Parse(tbxPlattenkostenTS.Text);
          kalkParamDB.PlattenkostenNK = Decimal.Parse(tbxPlattenkostenNK.Text);
          kalkParamDB.Aluprofilkosten = Decimal.Parse(tbxAluprofilkosten.Text);
          kalkParamDB.Beschlagkosten = Decimal.Parse(tbxBeschlagkosten.Text);
          kalkParamDB.Fixkosten = Decimal.Parse(tbxFixkosten.Text);
          kalkParamDB.Pulverkosten = Decimal.Parse(tbxPulverkosten.Text);
          kalkParamDB.Montagekosten = Decimal.Parse(tbxMontagekosten.Text);
          kalkParamDB.LohnkostenTM = Decimal.Parse(tbxLohnkostenTM.Text);
          kalkParamDB.LohnkostenTS = Decimal.Parse(tbxLohnkostenTS.Text);
          kalkParamDB.LohnkostenNK = Decimal.Parse(tbxLohnkostenNK.Text);
          kalkParamDB.OberlichtkostenTM = Decimal.Parse(tbxOberlichtTM.Text);
          kalkParamDB.OberlichtkostenTS = Decimal.Parse(tbxOberlichtTS.Text);
          kalkParamDB.OberlichtkostenNK = Decimal.Parse(tbxOberlichtNK.Text);
          kalkParamDB.Gewinn = Decimal.Parse(tbxGewinn.Text) / 100 + 1;
          kalkParamDB.Sonderzuschlag = Decimal.Parse(tbxSonderzuschlag.Text) / 100 + 1;
          kalkParamDB.Aussparung = Decimal.Parse(tbxAussparung.Text);
          //kalkParamDB.Mwst = Decimal.Parse(tbxMwst.Text) / 100 + 1;
          dbContext.SubmitChanges();

          this.Validate();

          // Steuer speichern
          this.steuerBindingSource.EndEdit();
          this.steuerTableAdapter.Update(this.dsSteuer.Steuer);

          // Zeichenparameter speichern
          zeichenparameterBindingSource.EndEdit();
          zeichenparameterTableAdapter.Update(dsZeichenparameter.Zeichenparameter);

          // Lagerkategorien speichern
          lagerkategorieBindingSource.EndEdit();
          lagerkategorieTableAdapter.Update(dsLagerkategorie.Lagerkategorie);

          // Lagereinheiten speichern
          lagereinheitBindingSource.EndEdit();
          lagereinheitTableAdapter.Update(dsLagereinheit.Lagereinheit);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    /// <summary>
    /// Speicher die Firmendaten in der DB.
    /// </summary>
    private void SaveFirmendaten()
    {
      try
      {
        using (var dbContext = new DataBaseDataContext())
        {
          if (firmendatenDB != null)
          {
            firmendatenDB = null;
            firmendatenDB = dbContext.Firmendatens.Where(fd => fd.ID.Equals(1)).FirstOrDefault();

          }
          else
          {
            firmendatenDB = dbContext.Firmendatens.Where(fd => fd.ID.Equals(1)).FirstOrDefault();
          }

          firmendatenDB.Name = tbxFirmenname.Text;
          firmendatenDB.Inhaber = tbxInhaber.Text;
          firmendatenDB.Straße = tbxStraße.Text;
          firmendatenDB.PLZ = tbxPLZ.Text;
          firmendatenDB.Ort = tbxOrt.Text;
          firmendatenDB.Telefon = tbxTelefon.Text;
          firmendatenDB.Fax = tbxFax.Text;
          firmendatenDB.Email = tbxEmail.Text;
          firmendatenDB.Homepage = tbxHompage.Text;
          firmendatenDB.Steuernummer = tbxSteuernummer.Text;
          firmendatenDB.Ust_Nummer = tbxUST.Text;
          firmendatenDB.Bank1 = tbxBank1.Text;
          firmendatenDB.BLZ1 = tbxBLZ1.Text;
          firmendatenDB.Konto1 = tbxKnt1.Text;
          firmendatenDB.IBAN1 = tbxIban1.Text;
          firmendatenDB.BIC1 = tbxBic1.Text;
          firmendatenDB.Bank2 = tbxBank2.Text;
          firmendatenDB.BLZ2 = tbxBLZ2.Text;
          firmendatenDB.Konto2 = tbxKnt2.Text;
          firmendatenDB.IBAN2 = tbxIban2.Text;
          firmendatenDB.BIC2 = tbxBic2.Text;
          firmendatenDB.Steuertext = tbxSteuertext.Text;
          firmendatenDB.Bank1Aktiv = cbxBank1Aktiv.Checked ? 1 : 0;
          firmendatenDB.Bank2Aktiv = cbxBank2Aktiv.Checked ? 1 : 0;

          dbContext.SubmitChanges();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    /// <summary>
    /// Lädt sämtliche Firmendaten aus der DB in die entsprechenden Textboxsen des Optionen-Moduls.
    /// </summary>
    private void LoadFirmendaten()
    {
      try
      {
        using (var dbContext = new DataBaseDataContext())
        {
          if (firmendatenDB != null)
          {
            firmendatenDB = null;
            firmendatenDB = dbContext.Firmendatens.Where(fd => fd.ID.Equals(1)).FirstOrDefault();

          }
          else
          {
            firmendatenDB = dbContext.Firmendatens.Where(fd => fd.ID.Equals(1)).FirstOrDefault();
          }

          tbxFirmenname.Text = firmendatenDB.Name;
          tbxInhaber.Text = firmendatenDB.Inhaber;
          tbxStraße.Text = firmendatenDB.Straße;
          tbxPLZ.Text = firmendatenDB.PLZ;
          tbxOrt.Text = firmendatenDB.Ort;
          tbxTelefon.Text = firmendatenDB.Telefon;
          tbxFax.Text = firmendatenDB.Fax;
          tbxEmail.Text = firmendatenDB.Email;
          tbxHompage.Text = firmendatenDB.Homepage;
          tbxSteuernummer.Text = firmendatenDB.Steuernummer;
          tbxUST.Text = firmendatenDB.Ust_Nummer;
          tbxBank1.Text = firmendatenDB.Bank1;
          tbxBLZ1.Text = firmendatenDB.BLZ1;
          tbxKnt1.Text = firmendatenDB.Konto1;
          tbxIban1.Text = firmendatenDB.IBAN1;
          tbxBic1.Text = firmendatenDB.BIC1;
          tbxBank2.Text = firmendatenDB.Bank2;
          tbxBLZ2.Text = firmendatenDB.BLZ2;
          tbxIban2.Text = firmendatenDB.IBAN2;
          tbxBic2.Text = firmendatenDB.BIC2;
          tbxKnt2.Text = firmendatenDB.Konto2;
          tbxSteuertext.Text = firmendatenDB.Steuertext;
          cbxBank1Aktiv.Checked = firmendatenDB.Bank1Aktiv == 1 ? true : false;
          cbxBank2Aktiv.Checked = firmendatenDB.Bank2Aktiv == 1 ? true : false;
             

          dbContext.SubmitChanges();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }


    /// <summary>
    /// Speichert sämtliche Reportpfade aus den Textboxen in die DB.
    /// </summary>
    private void SaveReportPaths()
    {
      this.Validate();
      this.reportsBindingSource.EndEdit();
      this.reportsTableAdapter.Update(this.dsReports.Reports);
    }


    #endregion


    #region Events

    private void btnSchließen_Click(object sender, EventArgs e)
    {
      DialogResult result =
          MessageBox.Show(
              "Nicht gespeicherte Änderungen gehen verloren.\nMöchten Sie wirklich schließen?",
              "Fenster schließen",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

      if (result == DialogResult.Yes)
      {
        Func.FOptionen = null;
        this.Close();
      }
    }

    private void Optionen_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsLagereinheit.Lagereinheit". Sie können sie bei Bedarf verschieben oder entfernen.
      this.lagereinheitTableAdapter.Fill(this.dsLagereinheit.Lagereinheit);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsLagerkategorie.Lagerkategorie". Sie können sie bei Bedarf verschieben oder entfernen.
      this.lagerkategorieTableAdapter.Fill(this.dsLagerkategorie.Lagerkategorie);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsZeichenparameter.Zeichenparameter". Sie können sie bei Bedarf verschieben oder entfernen.
      this.zeichenparameterTableAdapter.Fill(this.dsZeichenparameter.Zeichenparameter);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsSteuer.Steuer". Sie können sie bei Bedarf verschieben oder entfernen.
      this.steuerTableAdapter.Fill(this.dsSteuer.Steuer);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsReports.Reports". Sie können sie bei Bedarf verschieben oder entfernen.
      this.reportsTableAdapter.Fill(this.dsReports.Reports);

      LoadFirmendaten();

      LoadKalkulationsparameter();
    }

    private void btnSpeichern_Click(object sender, EventArgs e)
    {
      SaveKalkulationsparameter();

      SaveReportPaths();
    }


    private void btnSpeicherSchließen_Click(object sender, EventArgs e)
    {
      SaveFirmendaten();
      SaveKalkulationsparameter();
      SaveReportPaths();

      Func.FOptionen = null;
      this.Close();
    }

    #endregion

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewCell cell = dataGridView1.CurrentCell;

      int columnIndex = dataGridView1.CurrentCell.ColumnIndex;

      if (columnIndex == 1)
      {
        DialogResult result = dlgReport.ShowDialog();

        if (result == DialogResult.OK)
        {
          cell.Value = dlgReport.FileName;
        }
      }
    }

    
  }
}