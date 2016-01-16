using Norka.Archiv;
using Norka.Aufträge;
using System.Threading;
using Norka.Cockpit;

namespace Norka
{
  using System;
  using System.Diagnostics;
  using System.Windows.Forms;
 
  using Kunden;
  using Properties;
  using Reports;
  using Extras;
  using SplashScreen;
  using Angebote;
  using Rechnungen;
  using Func;
  using Zeichnen;
  using Lager;
  /// <summary>
  /// 
  /// </summary>
  public partial class Form_Start : Form
  {
    // ******************************************************************
    // Konstruktor
    // ******************************************************************
    /// <summary>
    /// Initialisiert eine neue Instanz der <see cref="Form_Start"/> Klasse.
    /// </summary>
    public Form_Start()
    {
      //Thread thSplash = new Thread(new ThreadStart(DoSplash));
      //thSplash.Start();            
      //Thread.Sleep(1000);
      InitializeComponent();

      //thSplash.Abort();	
    }

    // ******************************************************************
    // Methoden
    // ******************************************************************
    #region Methoden

    /// <summary>
    /// Öffnet das SplachScreen-Formular
    /// </summary>
    private static void DoSplash()
    {
      Form_Splash sp = new Form_Splash();
      sp.ShowDialog();
    }

    /// <summary>
    /// Öffnet das Angebots-Formular.
    /// </summary>
    private void openAngebotForm()
    {
      //bool offen = false;

      //for (int i = 0; i < this.MdiChildren.Length; i++)
      //{
      //  if (this.MdiChildren[i].GetType() == typeof(Form_Angebot) & this.MdiChildren[i].Text == "Angebot")
      //    offen = true;
      //}

      //if (offen == false)
      //{
      //  Form_Angebot FAngebot = new Form_Angebot();
      //  FAngebot.MdiParent = this;
      //  FAngebot.Text = "Angebot";
      //  FAngebot.Show();
      //  FAngebot.WindowState = FormWindowState.Maximized;
      //}


      // Mehrmaliges Öffnen des Formulars wird hiermit verhindert.
      if (Func.Func.FAngebot == null)
      {
        Func.Func.FAngebot = new Form_Angebot();
        Func.Func.FAngebot.MdiParent = this;
      }

      Func.Func.FAngebot.Text = "Angebot";
      Func.Func.FAngebot.Show();
      Func.Func.FAngebot.WindowState = FormWindowState.Maximized;

    }

    /// <summary>
    /// Öffnet das Auftragsformular.
    /// </summary>
    private void openAuftragForm()
    {
      // Mehrmaliges Öffnen des Formulars wird hiermit verhindert.
      if (Func.Func.FAuftrag == null)
      {
        Func.Func.FAuftrag = new Form_Auftrag();
        Func.Func.FAuftrag.MdiParent = this;
      }

      Func.Func.FAuftrag.Text = "Auftrag";
      Func.Func.FAuftrag.Show();
      Func.Func.FAuftrag.WindowState = FormWindowState.Maximized;

      //bool offen = false;

      //for (int i = 0; i < this.MdiChildren.Length; i++)
      //{
      //  if (this.MdiChildren[i].GetType() == typeof(Form_Angebot) & this.MdiChildren[i].Text == "Auftrag")
      //    offen = true;
      //}

      //if (offen == false)
      //{
      //  Form_Angebot FAngebot = new Form_Angebot();
      //  FAngebot.MdiParent = this;
      //  FAngebot.Text = "Auftrag";
      //  FAngebot.Show();
      //  FAngebot.WindowState = FormWindowState.Maximized;
      //}
    }

    /// <summary>
    /// Öffnet das Kunden-Überischts-Formular.
    /// </summary>
    private void openKundenUebersichtForm()
    {
      // Mehrmaliges Öffnen des Formulars wird hiermit verhindert.
      if (Func.Func.FUebersicht == null)
      {
        Func.Func.FUebersicht = new Form_Kunde_Uebersicht();
        Func.Func.FUebersicht.MdiParent = this;
      }

      Func.Func.FUebersicht.Show();
      Func.Func.FUebersicht.WindowState = FormWindowState.Maximized;
    }

    /// <summary>
    /// Öffnet das Kalkulations-Formular.
    /// </summary>
    private void openKalkulationForm()
    {
      // Mehrmaliges Öffnen des Formulars wird hiermit verhindert.
      if (Func.Func.FKalkulation == null)
      {
        Func.Func.FKalkulation = new Kalkulationen.Form_Kalkualtion();
        Func.Func.FKalkulation.MdiParent = this;
      }

      Func.Func.FKalkulation.Show();
      Func.Func.FKalkulation.WindowState = FormWindowState.Maximized;
      Func.Func.FKalkulation.grpSteuerung.Visible = false;
    }

    #endregion

    // ******************************************************************
    // Events
    // ******************************************************************
    #region Events

    private void Start_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      try
      {
        if (e.KeyCode == Keys.F2)
        {
          this.openKundenUebersichtForm();
        }
        if (e.KeyCode == Keys.F3)
        {
          openKalkulationForm();
        }
        if (e.KeyCode == Keys.F4)
        {
          openAngebotForm();
        }
        if (e.KeyCode == Keys.F5)
        {
          openArchivForm();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message.ToString());
      }
    }

    private void fernwartungToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //Process teamviewer = new Process();
      //teamviewer.StartInfo.FileName = "E:\\project\\Norka\\Norka\\teamviewer.exe";
      //teamviewer.Start();
    }

    private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnKalkulation_Click(object sender, EventArgs e)
    {
      openKalkulationForm();
    }



    private void btnAngebot_Click(object sender, EventArgs e)
    {
      openAngebotForm();
    }


    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      openAuftragForm();
    }

    private void btnKunden_Click_1(object sender, EventArgs e)
    {
      openKundenUebersichtForm();
    }

    #endregion

    private void itemTelefonliste_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      var r = ReportManager.GetReportByName(EReports.Telefonliste);
      var report = new Form_Report(r);
      report.Show();
      report.Refresh();
      this.Cursor = Cursors.Default;
    }

    private void itemKundenABC_Click(object sender, EventArgs e)
    {

    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      // Mehrmaliges Öffnen des Formulars wird hiermit verhindert.
      openArchivForm();
    }

    private void openArchivForm()
    {
      if (Func.Func.FArchiv == null)
      {
        Func.Func.FArchiv = new Form_Archiv();
        Func.Func.FArchiv.MdiParent = this;
      }


      Func.Func.FArchiv.Show();
      Func.Func.FArchiv.WindowState = FormWindowState.Maximized;
    }

    private void openCockpitForm()
    {
      if (Func.Func.FCockpit == null)
      {
        Func.Func.FCockpit = new Form_Cockpit();
        Func.Func.FCockpit.MdiParent = this;
      }


      Func.Func.FCockpit.Show();
      Func.Func.FCockpit.WindowState = FormWindowState.Maximized;
    
    }

    private void openZeichnenForm()
    {
      //if (Func.Func.FZeichnen == null)
      //{
      //    Func.Func.FZeichnen = new Form_Zeichnen();
      //    Func.Func.FZeichnen.MdiParent = this;
      //}


      //Func.Func.FZeichnen.Show();
      //Func.Func.FZeichnen.WindowState = FormWindowState.Maximized;

      if (Func.Func.FZeichnen == null)
      {
        Func.Func.FZeichnen = new Form_Zeichnen();
        Func.Func.FZeichnen.MdiParent = this;
      }


      Func.Func.FZeichnen.Show();
      Func.Func.FZeichnen.WindowState = FormWindowState.Maximized;
    }

    private void openRechnungForm()
    {
      if (Func.Func.FRechnung == null)
      {
        Func.Func.FRechnung = new Form_Rechnung();
        Func.Func.FRechnung.MdiParent = this;
      }

      Func.Func.FRechnung.Show();
      Func.Func.FRechnung.WindowState = FormWindowState.Maximized;
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {
      openRechnungForm();
    }

    private void optionenToolStripMenuItem_Click(object sender, EventArgs e)
    {

      if (Func.Func.FOptionen == null)
      {
        Func.Func.FOptionen = new Form_Optionen();
      }

      Func.Func.FOptionen.ShowDialog(this);

    }

    private void btnCockpit_Click(object sender, EventArgs e)
    {
      openCockpitForm();
    }

    private void btnZeichnen_Click(object sender, EventArgs e)
    {
      openZeichnenForm();
    }

    private void btnLage_Click(object sender, EventArgs e)
    {
      if (Func.Func.FLagerAnsicht == null)
      {
        Func.Func.FLagerAnsicht = new Form_Lager_Ansicht();
      }

      Func.Func.FLagerAnsicht.ShowDialog(this);
    }
  }
}