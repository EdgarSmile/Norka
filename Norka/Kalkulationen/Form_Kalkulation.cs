using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Norka.DB;

namespace Norka.Kalkulationen
{
  using Func;
  using Common;

  /// <summary>
  /// Klasse zur Darstellung/Steuerung der Kalkulationsform
  /// </summary>
  public partial class Form_Kalkualtion : Form
  {
    #region Objektvariablen

    private ErrorProvider epAnlagen;
    private ErrorProvider epBreite;
    private ErrorProvider epTueren;
    private ErrorProvider epTiefe;
    private ErrorProvider epTrw;
    private ErrorProvider epZuschlag;
    private ErrorProvider epVK;
    private Kalkulation k;
    private Kalkulation kTM;
    private Kalkulation kTS;
    private Kalkulation kNK;
    private string angebotsNr;
    private string auftragsNr;
    private string positionsNr;
    private decimal Montage;

    /// <summary>
    /// Temporäre Variable, die den "VK-Wert" zwischenspeichert, damit dieser beim Anlegen einer weiteren Position im Angebot/Auftrag
    /// als Vorauswahlwert in der entsprechenden Textbox steht.
    /// </summary>
    private string tempVK;

    /// <summary>
    /// Temporäre Variable, die den Türzuschlag zwischenspeichert, damit dieser beim Anlegen einer weiteren Position im Angebot/Auftrag
    /// als Vorauswahlwert in der entsprechenden Textbox steht.
    /// </summary>
    private string tempZuschlagTür;

    private bool isAuftrag;

    /// <summary>
    /// Obejekt enthält sämtliche Kalkulationsparameter.
    /// Es wird bei jeder Kalkulation erneut aus der DB geladen und enthält somit immer die aktuellesten Werte.
    /// </summary>
    private Kalkulationsparameter kalkParamDB;

    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="Form_Kalkulation"/> class.
    /// </summary>
    /// <param name="pIsAuftrag">Wenn Flag == <c>true</c>, dann wurde die Kalkulationsform aus dem Auftragsmodul heraus geöffnet.</param>
    public Form_Kalkualtion(bool pIsAuftrag)
    {
      this.isAuftrag = pIsAuftrag;
      InitializeComponent();

      InitializeKalkulation();

      kalkParamDB = DBManager.GetKalkulationsparameter();
      cbxSonderartikelEinheit.SelectedIndex = 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Form_Kalkulation"/> class.
    /// </summary>
    public Form_Kalkualtion()
    {
      InitializeComponent();

      InitializeKalkulation();

      kalkParamDB = DBManager.GetKalkulationsparameter();
      cbxSonderartikelEinheit.SelectedIndex = 0;
    }

    /// <summary>
    /// 
    /// </summary>
    private void InitializeKalkulation()
    {
      epAnlagen = new ErrorProvider();
      epBreite = new ErrorProvider();
      epTueren = new ErrorProvider();
      epTrw = new ErrorProvider();
      epTiefe = new ErrorProvider();
      epZuschlag = new ErrorProvider();
      epVK = new ErrorProvider();

      epAnlagen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
      epBreite.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
      epTueren.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
      epTiefe.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
      epTrw.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
      epZuschlag.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

      tbxOberlichtLfm.BackColor = Func.CDisabled;
      lblOberlichtG.BackColor = Func.CDisabled;

      cbxVK.SelectedItem = "Prozent";

      k = new Kalkulation();
      kTM = new Kalkulation();
      kTS = new Kalkulation();
      kNK = new Kalkulation();
    }

    ///<summary>
    ///</summary>
    ///<param name="ap"></param>
    public Form_Kalkualtion(Auftrag_Position ap)
    {
      InitializeComponent();
      InitializeKalkulation();

      kalkParamDB = DBManager.GetKalkulationsparameter();

      this.isAuftrag = true;

      //Ausgewählte Auftragsposition laden 
      positionsNr = ap.PosID.ToString();
      auftragsNr = ap.AuftragID.ToString();

      switch (ap.Artikel)
      {
        case "Vorderwand":
          rdbVorderwand.Checked = true;
          break;
        case "Kabine":
          rdbKabinen.Checked = true;
          break;
        case "Trennwand":
          rdbTrennwand.Checked = true;
          break;
        case "Schamwand":
          rdbSchamwand.Checked = true;
          break;
        case "Abschlusswand":
          rdbVorOTuer.Checked = true;
          break;
        case "Sonderartikel":
          rdbAussparung.Checked = true;
          break;
      }

      tbxSondertextUnten.Text = ap.Sondertext;
      tbxSondertextOben.Text = ap.SondertextOben;

      switch (ap.Typ)
      {
        case "TM":
          rdbTM.Checked = true;
          break;
        case "TS":
          rdbTS.Checked = true;
          break;
        case "NK":
          rdbNK.Checked = true;
          break;
      }

      tbxAnlagen.Text = String.Format("{0:#,0.##}", ap.AnlagenStk);
      tbxBreite.Text = ap.Breite.ToString();
      tbxTiefe.Text = ap.Tiefe.ToString();
      tbxTüren.Text = ap.Türen.ToString();
      tbxTrw.Text = ap.TW.ToString();
      tbxZuschlag.Text = ap.ZuschlagTür.ToString();

      if (ap.Artikel == "Sonderartikel")
      {
        tbxAussparungenPreis.Text = ap.Einzelpreis.ToString();
        double temp = double.Parse(tbxAussparungenPreis.Text);
        tbxAussparungenPreis.Text = temp.ToString();
        gbxAussparung.Enabled = true;
        cbxSonderartikelEinheit.Text = ap.SonderartikelEinheit;
      }
      tbxVK.Text = ap.Zuschlag.ToString();

      switch (ap.ZuschlagArt)
      {
        case "Prozent":
          cbxVK.SelectedIndex = 0;
          break;
        case "Euro":
          cbxVK.SelectedIndex = 1;
          break;
      }

      cbxAlupulver.Checked = ap.Alupulver != 0.00m ? true : false;
      cbxMontage.Checked = ap.Montage == "ja" ? true : false;

      cobAussaprungBeschreibung.Text = ap.AussparungTxt;

      if (ap.Alternativ1Typ != null)
      {
        cbxAlternativ1.Checked = true;

        switch (ap.Alternativ1Typ)
        {
          case "TM":
            rdbTM1.Checked = true;
            break;
          case "TS":
            rdbTS1.Checked = true;
            break;
          case "NK":
            rdbNK1.Checked = true;
            break;
        }

        tbxAlt1Preis.Text = ap.Alternativ1Preis.ToString();
      }

      if (ap.Alternativ2Typ != null)
      {
        cbxAlternativ2.Checked = true;

        switch (ap.Alternativ2Typ)
        {
          case "TM":
            rdbTM2.Checked = true;
            break;
          case "TS":
            rdbTS2.Checked = true;
            break;
          case "NK":
            rdbNK2.Checked = true;
            break;
        }

        tbxAlt2Preis.Text = ap.Alternativ2Preis.ToString();
      }

      Kalkulieren();

      tbxAlupulv.Text = ap.Alupulver.ToString();

      cbxOberlicht.Checked = ap.Oberlicht == "ja" ? true : false;

      if (ap.Artikel != "Sonderartikel")
      {
        tbxEinzelVK.Text = String.Format("{0:0,0}", ap.Einzelpreis);
      }
    }

    ///<summary>
    ///</summary>
    ///<param name="ap"></param>
    public Form_Kalkualtion(Angebot_Position ap)
    {
      InitializeComponent();
      InitializeKalkulation();
      kalkParamDB = DBManager.GetKalkulationsparameter();
      isAuftrag = false;

      //Ausgewählte Angebotsposition laden 
      positionsNr = ap.PosID.ToString();
      angebotsNr = ap.AngebotID.ToString();



      switch (ap.Artikel)
      {
        case "Vorderwand":
          rdbVorderwand.Checked = true;
          break;
        case "Kabine":
          rdbKabinen.Checked = true;
          break;
        case "Trennwand":
          rdbTrennwand.Checked = true;
          break;
        case "Schamwand":
          rdbSchamwand.Checked = true;
          break;
        case "Abschlusswand":
          rdbVorOTuer.Checked = true;
          break;
        case "Sonderartikel":
          rdbAussparung.Checked = true;
          break;
      }

      tbxSondertextUnten.Text = ap.Sondertext;
      tbxSondertextOben.Text = ap.SondertextOben;

      switch (ap.Typ)
      {
        case "TM":
          rdbTM.Checked = true;
          break;
        case "TS":
          rdbTS.Checked = true;
          break;
        case "NK":
          rdbNK.Checked = true;
          break;
      }

      tbxAnlagen.Text = String.Format("{0:#,0.##}", ap.AnlagenStk);
      tbxBreite.Text = ap.Breite.ToString();
      tbxTiefe.Text = ap.Tiefe.ToString();
      tbxTüren.Text = ap.Türen.ToString();
      tbxTrw.Text = ap.TW.ToString();
      tbxZuschlag.Text = ap.ZuschlagTür.ToString();

      if (ap.Artikel == "Sonderartikel")
      {
        tbxAussparungenPreis.Text = ap.Einzelpreis.ToString();
        double temp = double.Parse(tbxAussparungenPreis.Text);
        tbxAussparungenPreis.Text = temp.ToString();
        gbxAussparung.Enabled = true;
        cbxSonderartikelEinheit.Text = ap.SonderartikelEinheit;
      }
      tbxVK.Text = ap.Zuschlag.ToString();

      switch (ap.ZuschlagArt)
      {
        case "Prozent":
          cbxVK.SelectedIndex = 0;
          break;
        case "Euro":
          cbxVK.SelectedIndex = 1;
          break;
      }

      cbxAlupulver.Checked = ap.Alupulver != 0.00m ? true : false;
      cbxMontage.Checked = ap.Montage == "ja" ? true : false;
      cbxEventual.Checked = ap.Eventual != 0 ? true : false;

      cobAussaprungBeschreibung.Text = ap.AussparungTxt;
      

      if (ap.Alternativ1Typ != null)
      {
        cbxAlternativ1.Checked = true;

        switch (ap.Alternativ1Typ)
        {
          case "TM":
            rdbTM1.Checked = true;
            break;
          case "TS":
            rdbTS1.Checked = true;
            break;
          case "NK":
            rdbNK1.Checked = true;
            break;
        }

        tbxAlt1Preis.Text = ap.Alternativ1Preis.ToString();
      }

      if (ap.Alternativ2Typ != null)
      {
        cbxAlternativ2.Checked = true;

        switch (ap.Alternativ2Typ)
        {
          case "TM":
            rdbTM2.Checked = true;
            break;
          case "TS":
            rdbTS2.Checked = true;
            break;
          case "NK":
            rdbNK2.Checked = true;
            break;
        }

        tbxAlt2Preis.Text = ap.Alternativ2Preis.ToString();
      }

      Kalkulieren();

      tbxAlupulv.Text = ap.Alupulver.ToString();
      cbxOberlicht.Checked = ap.Oberlicht == "ja" ? true : false;

      // Der Positions-Einzelpreis wird zum Schluss in die Form geladen.
      // Hat der User bei der Kalkulation den errechneten Preis manuell abgeändert 
      // so würde der Preis immer durch das erneute Kalkulieren überschrieben.
      // Das passiert zwar weiterhin, aber durch das nachladen des Preises erscheint somit der korrekte Betrag.
      if (ap.Artikel != "Sonderartikel")
      {
        tbxEinzelVK.Text = String.Format("{0:0,0}", ap.Einzelpreis);
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pAngebotsNr"></param>
    /// <param name="pAufruf"></param>
    public void SetAngebotNr(string pAngebotsNr, string pAufruf)
    {
      angebotsNr = pAngebotsNr;
      this.Text = "Angebot Nr. " + angebotsNr + "  - Position " + pAufruf;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pAuftragsNr"></param>
    /// <param name="pAufruf"></param>
    public void SetAuftragsNr(string pAuftragsNr, string pAufruf)
    {
      auftragsNr = pAuftragsNr;
      this.Text = "Auftrag Nr. " + auftragsNr + "  - Position " + pAufruf;
    }

    // ******************************************************************
    // Methoden
    // ******************************************************************

    #region Methoden

    /// <summary>
    /// Legt den ausgeählten Artikel. Der Wert wird für die Kalkulationsberechnung benötigt.
    /// </summary>
    private void DetermineArtikel()
    {
      if (rdbVorderwand.Checked)
      {
        k.Artikel = 1;
        kTM.Artikel = 1;
        kTS.Artikel = 1;
        kNK.Artikel = 1;
      }
      if (rdbKabinen.Checked)
      {
        k.Artikel = 2;
        kTM.Artikel = 2;
        kTS.Artikel = 2;
        kNK.Artikel = 2;
      }
      if (rdbTrennwand.Checked)
      {
        k.Artikel = 3;
        kTM.Artikel = 3;
        kTS.Artikel = 3;
        kNK.Artikel = 3;
      }
      if (rdbVorOTuer.Checked)
      {
        k.Artikel = 6;
        kTM.Artikel = 6;
        kTS.Artikel = 6;
        kNK.Artikel = 6;
      }
      if (rdbSchamwand.Checked)
      {
        k.Artikel = 8;
        kTM.Artikel = 8;
        kTS.Artikel = 8;
        kNK.Artikel = 8;
      }
      if (rdbAussparung.Checked)
      {
        k.Artikel = 9;
        kTM.Artikel = 9;
        kTS.Artikel = 9;
        kNK.Artikel = 9;
      }
    }

    /// <summary>
    /// Legt die zu verwendenden Plattenkosten anhand des durch den Benutzer ausgewählten Typen fest.
    /// </summary>
    private void DeterminePlattenLohnOberlicht()
    {
      if (rdbTM.Checked)
      {
        k.Plattenkosten = kalkParamDB.PlattenkostenTM;
        k.Lohnkosten = kalkParamDB.LohnkostenTM;
        k.Oberlichtkosten = kalkParamDB.OberlichtkostenTM;
      }
      if (rdbTS.Checked)
      {
        k.Plattenkosten = kalkParamDB.PlattenkostenTS;
        k.Lohnkosten = kalkParamDB.LohnkostenTS;
        k.Oberlichtkosten = kalkParamDB.OberlichtkostenTS;
      }
      if (rdbNK.Checked)
      {
        k.Plattenkosten = kalkParamDB.PlattenkostenNK;
        k.Lohnkosten = kalkParamDB.LohnkostenNK;
        k.Oberlichtkosten = kalkParamDB.OberlichtkostenNK;
      }

      kTM.Plattenkosten = kalkParamDB.PlattenkostenTM;
      kTS.Plattenkosten = kalkParamDB.PlattenkostenTS;
      kNK.Plattenkosten = kalkParamDB.PlattenkostenNK;

      kTM.Lohnkosten = kalkParamDB.LohnkostenTM;
      kTS.Lohnkosten = kalkParamDB.LohnkostenTS;
      kNK.Lohnkosten = kalkParamDB.LohnkostenNK;

      kTM.Oberlichtkosten = kalkParamDB.OberlichtkostenTM;
      kTS.Oberlichtkosten = kalkParamDB.OberlichtkostenTS;
      kNK.Oberlichtkosten = kalkParamDB.OberlichtkostenNK;
    }

    /// <summary>
    /// Berechnet die Kalkulationsdaten und gibt die Werte in die dafür vorgesehenen Steuerelemente aus.
    /// </summary>
    private void DoBerechnenAusgeben()
    {
      // Das Label lblVK wird in Abhängigkeit des gewählten Wertes in der Combobox cbxVK 
      // entweder mit dem entsprechenden Prozentwert oder mit einem Leer-String gefüllt.
      if (cbxVK.SelectedItem == "Prozent")
      {
        lblVK.Text = (100.00m + Decimal.Parse(tbxVK.Text)).ToString() + " %";
      }
      else
      {
        lblVK.Text = "";
      }

      // Aluprofile
      lblAluMenge.Text = k.GesamtmengeAluprofile.ToString();
      lblAluPreis.Text = k.Alukosten.ToString();
      lblAluPreisGesamt.Text = Math.Round(k.GesamtpreisAluprofil).ToString();

      // Alupulverbeschichtung
      tbxAlupulv.Text = Math.Round(k.EinzelpreisAlubeschichtung, 2).ToString();

      // Platten
      lblPlattenMenge.Text = k.GesamtmengePlatten.ToString();
      lblPlattenPreis.Text = k.Plattenkosten.ToString();
      lblPlattenPreisGesamt.Text = Math.Round(k.GesamtpreisPlatten, 0).ToString();

      // Beschläge
      lblBeschlagMenge.Text = k.AnzahlTuerenAnlage.ToString();

      lblBeschlagPreis.Text = k.Beschlagkosten.ToString();
      lblBeschlagPreisGesamt.Text = Math.Round(k.GesamtpreisBeschlaege, 0).ToString();

      lblFixkosten.Text = Math.Round(k.GesamtpreisFixkosten, 0).ToString();

      // Diverse Kosten
      k.GesamtpreisDiverseKosten = k.calcPreisDiverse(Decimal.Parse(tbxZuschlag.Text));
      kTM.GesamtpreisDiverseKosten = kTM.calcPreisDiverse(Decimal.Parse(tbxZuschlag.Text));
      kTS.GesamtpreisDiverseKosten = kTS.calcPreisDiverse(Decimal.Parse(tbxZuschlag.Text));
      kNK.GesamtpreisDiverseKosten = kNK.calcPreisDiverse(Decimal.Parse(tbxZuschlag.Text));

      lblDiverseKosten.Text = Math.Round(k.GesamtpreisDiverseKosten, 0).ToString();

      // Lohn
      lblLohnteile.Text = k.AnzahlTeile.ToString();
      lblLohnPreis.Text = k.Lohnkosten.ToString();
      lblLohnPreisGesamt.Text = Math.Round(k.GesamtpreisLohn, 0).ToString();

      // Montage
      lblMontageTeile.Text = k.AnzahlTeile.ToString();
      lblMontagePreis.Text = k.Montagekosten.ToString();

      if (cbxMontage.Checked)
      {
        lblMontagePreisGesamt.Text = Math.Round(k.GesamtpreisMontage, 0).ToString();
      }
      else
        lblMontagePreisGesamt.Text = "0";
      
      Montage = Math.Round(k.GesamtpreisMontage, 0);

      //if (cbxOberlicht.Checked)
      //{
      //    if (tbxOberlichtLfm.Text != String.Empty)
      //    {
      //        lblOberlichtG.Text =
      //          Math.Round(Decimal.Parse(tbxOberlichtLfm.Text) * k.Oberlichtkosten, 0).ToString();
      //    }
      //}

      Endsumme();
    }

    // ******************************************************************
    // Artikel-Validation
    // ******************************************************************
    /// <summary>
    /// Überprüft, ob die für den Artikel "Vorderwand" nötigen Benutzereingaben gültig sind.
    /// </summary>
    /// <returns>Status, ob gültig oder nicht</returns>
    private bool ValidateVorderwand()
    {
      bool status = false;

      if (ValidateAnlagen() & ValidateBreite() & ValidateTueren() & ValidateZuschlag())
      {
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Überprüft, ob die für den Artikel "R-Kabine" nötigen Benutzereingaben gültig sind.
    /// </summary>
    /// <returns>Status, ob gültig oder nicht</returns>
    private bool ValidateKabine()
    {
      bool status = false;

      if (ValidateAnlagen() & ValidateBreite() & ValidateTueren() & ValidateTiefe() & ValidateTrw() & ValidateZuschlag())
      {
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Überprüft, ob die für den Artikel "Trennwand" nötigen Benutzereingaben gültig sind.
    /// </summary>
    /// <returns>Status, ob gültig oder nicht</returns>
    private bool ValidateTrennwand()
    {
      bool status = false;

      if (ValidateAnlagen() & ValidateBreite() & ValidateZuschlag())
      {
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Überprüft, ob die für den Artikel "Vorderwand" ohne Tür nötigen Benutzereingaben gültig sind.
    /// </summary>
    /// <returns>Status, ob gültig oder nicht</returns>
    private bool ValidateVorOTuer()
    {
      bool status = false;

      if (ValidateAnlagen() & ValidateBreite())
      {
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Überprüft, ob die für den Artikel "Schamwand" nötigen Benutzereingaben gültig sind.
    /// </summary>
    /// <returns>Status, ob gültig oder nicht</returns>
    private bool ValidateSchamwand()
    {
      bool status = false;

      if (ValidateAnlagen() & ValidateBreite())
      {
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Wird beim Klick auf den "Kalkulieren-Button" ausgeführt. Übeprüft in Abhängigkeit der Artikelauswahl die Benutzereingaben in den Textboxen.
    /// </summary>
    private bool ValidateEingabe()
    {
      bool status = false;

      if (rdbVorderwand.Checked)
      {
        if (ValidateVorderwand())
        {
          status = true;
        }
      }
      if (rdbKabinen.Checked)
      {
        if (this.ValidateKabine())
        {
          status = true;
        }
      }
      if (rdbTrennwand.Checked)
      {
        if (this.ValidateTrennwand())
        {
          status = true;
        }
      }
      if (rdbVorOTuer.Checked)
      {
        if (this.ValidateVorOTuer())
        {
          status = true;
        }
      }
      if (rdbSchamwand.Checked)
      {
        if (ValidateSchamwand())
        {
          status = true;
        }
      }

      return status;
    }

    /// <summary>
    /// Berechnet die Einzelsumme pro Anlage (100% und 100% + VK) und die Gesamtsumme aller Anlagen (100% und 100% + VK) und gibt die Ergebnisse in zugewiesenen Steuerelementen aus. 
    /// Zusätzlich werden die Alternativpreise ermittelt und ausgegeben.
    /// </summary>
    private void Endsumme()
    {
      
      if (cbxOberlicht.Checked)
      {
        if (tbxBreite.Text != String.Empty && k.Artikel != 0)
        {
          decimal oberlichtLfm = 0.0m;

          switch (k.Artikel)
          {
            case 1:
              oberlichtLfm = Math.Round(Decimal.Parse(tbxBreite.Text) / 100, 1);
              break;
            case 2:
              oberlichtLfm = Math.Round((Decimal.Parse(tbxBreite.Text) + (Decimal.Parse(tbxTiefe.Text) * Decimal.Parse(tbxTrw.Text))) / 100, 1);
              break;
            case 3:
              oberlichtLfm = Math.Round(Decimal.Parse(tbxBreite.Text) / 100, 1);
              break;
            case 6:
              oberlichtLfm = Math.Round(Decimal.Parse(tbxBreite.Text) / 100, 1);
              break;
          }

          tbxOberlichtLfm.Text = oberlichtLfm.ToString();

          lblOberlichtG.Text = Math.Round(Decimal.Parse(tbxOberlichtLfm.Text) * k.Oberlichtkosten, 0).ToString();
        }
      }

      if (cbxMontage.Checked)
      {
       
        if (cbxAlupulver.Checked)
        {
          if (cbxOberlicht.Checked)
          {
            lblEinzel.Text = Math.Round(k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1) + Decimal.Parse(lblOberlichtG.Text), 0).ToString(); // 100% pro Anlage 
          }
          else
          {
            lblEinzel.Text = Math.Round(k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1), 0).ToString(); // 100% pro Anlage
          }

          lblGesamt.Text = String.Format("{0:0,0}", (Decimal.Parse(this.lblEinzel.Text) * k.AnzahlAnlagen));

          if ((string)cbxVK.SelectedItem == "Prozent")
          {
            if (cbxOberlicht.Checked)
            {
              tbxEinzelVK.Text = Math.Round(((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString(); // 100% + VK
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }
            else
            {
              tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent, 0).ToString(); // 100% + VK
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }

            #region Alternativpositionen

            //Alternativposition 1 -->
            if (rdbTM1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString();  
              }
              
            }
            else if (rdbTS1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString();  
              }
              
            }
            else if (rdbNK1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent, 0).ToString();  
              }
              
            }
            //<--Alternativposition 1 

            //Alternativposition 2 -->
            if (rdbTM2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString(); 
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString();  
              }
            }
            else if (rdbTS2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text) , 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString(); 
              }
            }
            else if (rdbNK2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
               tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent, 0).ToString(); 
              }              
            }

            //<--Alternativposition 2  

            #endregion
          }
          else
          {
            if ((string)cbxVK.SelectedItem == "Euro")
            {
              if (cbxOberlicht.Checked)
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }
              else
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro, 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }

              #region Alternativpositionen

              //Alternativposition 1 -->
              if (rdbTM1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text) , 0).ToString();
                }
                else
                {
                tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString();  
                }
              }
              else if (rdbTS1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString();  
                } 
              }
              else if (rdbNK1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString();
                }
              }
              //<--Alternativposition 1 

              //Alternativposition 2 -->
              if (rdbTM2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString(); 
                }
              }
              else if (rdbTS2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString(); 
                }
              }
              else if (rdbNK2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString();  
                }
              }

              //<--Alternativposition 2  

              #endregion
            }
          }
        }
        else
        {
          if (cbxOberlicht.Checked)
          {
            lblEinzel.Text = Math.Round(k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1) + Decimal.Parse(lblOberlichtG.Text), 0).ToString(); // 100% pro Anlage
            lblGesamt.Text = String.Format("{0:0,0}", (Decimal.Parse(this.lblEinzel.Text) * k.AnzahlAnlagen));
          }
          else
          {
            lblEinzel.Text = Math.Round(k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1), 0).ToString(); // 100% pro Anlage
            lblGesamt.Text = String.Format("{0:0,0}", (Decimal.Parse(this.lblEinzel.Text) * k.AnzahlAnlagen));
          }

          if ((string)cbxVK.SelectedItem == "Prozent")
          {
            if (cbxOberlicht.Checked)
            {
              tbxEinzelVK.Text = Math.Round(((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString(); // 100% + VK
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }
            else
            {
              tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent, 0).ToString(); // 100% + VK
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }

            #region Alternativpositionen

            //Alternativposition 1 -->
            if (rdbTM1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString();  
              }
              
            }
            else if (rdbTS1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString(); 
              }
            }
            else if (rdbNK1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent, 0).ToString();  
              }
              
            }
            //<--Alternativposition 1 

            //Alternativposition 2 -->
            if (rdbTM2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString();  
              }
            }
            else if (rdbTS2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString(); 
              }
            }
            else if (rdbNK2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent, 0).ToString(); 
              }
            }

            //<--Alternativposition 2  

            #endregion
          }
          else
          {
            if ((string)cbxVK.SelectedItem == "Euro")
            {
              if (cbxOberlicht.Checked)
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }
              else
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohnMontage * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro, 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }

              #region Alternativpositionen

              //Alternativposition 1 -->
              if (rdbTM1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString();  
                }
                
              }
              else if (rdbTS1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString();  
                }
                
              }
              else if (rdbNK1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString(); 
                }
              }
              //<--Alternativposition 1 

              //Alternativposition 2 -->
              if (rdbTM2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohnMontage * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString();  
                }
                
              }
              else if (rdbTS2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohnMontage * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString();  
                }
                
              }
              else if (rdbNK2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) +Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohnMontage * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString(); 
                }                
              }

              //<--Alternativposition 2  

              #endregion
            }
          }
        }
      }
      else
      {
        if (cbxAlupulver.Checked)
        {
          if (cbxOberlicht.Checked)
          {
            lblEinzel.Text = Math.Round(k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1 + Decimal.Parse(lblOberlichtG.Text)), 0).ToString();
            lblGesamt.Text = String.Format("{0:0,0}", (Decimal.Parse(this.lblEinzel.Text) * k.AnzahlAnlagen));
          }
          else
          {
            lblEinzel.Text = Math.Round(k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1), 0).ToString();
            lblGesamt.Text = String.Format("{0:0,0}", (Decimal.Parse(this.lblEinzel.Text) * k.AnzahlAnlagen));
          }

          if ((string)cbxVK.SelectedItem == "Prozent")
          {
            if (cbxOberlicht.Checked)
            {
              tbxEinzelVK.Text = Math.Round(((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }
            else
            {
              tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent, 0).ToString();
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }

            #region Alternativpositionen

            //Alternativposition 1 -->
            if (rdbTM1.Checked)
            { 
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString();  
              }
              
            }
            else if (rdbTS1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString();  
              }
              
            }
            else if (rdbNK1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent, 0).ToString();  
              }
              
            }
            //<--Alternativposition 1 

            //Alternativposition 2 -->
            if (rdbTM2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString();  
              }
              
            }
            else if (rdbTS2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString();  
              }
              
            }
            else if (rdbNK2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent, 0).ToString();  
              }
              
            }

            //<--Alternativposition 2  

            #endregion
          }
          else
          {
            if ((string)cbxVK.SelectedItem == "Euro")
            {
              if (cbxOberlicht.Checked)
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }
              else
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro, 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }

              #region Alternativpositionen

              //Alternativposition 1 -->
              if (rdbTM1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString(); 
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString();  
                }
              }
              else if (rdbTS1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString();  
                }
                
              }
              else if (rdbNK1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString();  
                }
                
              }
              //<--Alternativposition 1 

              //Alternativposition 2 -->
              if (rdbTM2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString();  
                }
                
              }
              else if (rdbTS2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString(); 
                }
              }
              else if (rdbNK2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString();  
                }
                
              }

              //<--Alternativposition 2  

              #endregion
            }
          }
        }
        else
        {
          if (cbxOberlicht.Checked)
          {
            lblEinzel.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
            lblGesamt.Text = String.Format("{0:0,0}", (Decimal.Parse(this.lblEinzel.Text) * k.AnzahlAnlagen));
          }
          else
          {
            lblEinzel.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)), 0).ToString();
            lblGesamt.Text = String.Format("{0:0,0}", (Decimal.Parse(this.lblEinzel.Text) * k.AnzahlAnlagen));
          }

          if ((string)cbxVK.SelectedItem == "Prozent")
          {
            if (cbxOberlicht.Checked)
            {
              tbxEinzelVK.Text = Math.Round(((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }
            else
            {
              tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) * k.Verkaufsprozent, 0).ToString();
              lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
            }

            #region Alternativpositionen

            //Alternativposition 1 -->
            if (rdbTM1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString(); 
              }
            }
            else if (rdbTS1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString();  
              }
            }
            else if (rdbNK1.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn*(kNK.Gewinn + k.Sonderzuschlag - 1))*kNK.Verkaufsprozent,0).ToString();
              }

            }
            //<--Alternativposition 1 

            //Alternativposition 2 -->
            if (rdbTM2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();  
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) * kTM.Verkaufsprozent, 0).ToString();
              }
            }
            else if (rdbTS2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) * kTS.Verkaufsprozent, 0).ToString();  
              }
            }
            else if (rdbNK2.Checked)
            {
              if (cbxOberlicht.Checked)
              {
                tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
              }
              else
              {
                tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) * kNK.Verkaufsprozent, 0).ToString();  
              }
            }

            //<--Alternativposition 2  

            #endregion
          }
          else
          {
            if ((string)cbxVK.SelectedItem == "Euro")
            {
              if (cbxOberlicht.Checked)
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }
              else
              {
                tbxEinzelVK.Text = Math.Round((k.GesamtpreisMaterialLohn * (k.Gewinn + k.Sonderzuschlag - 1)) + k.Verkaufseuro, 0).ToString();
                lblGesamtVK.Text = String.Format("{0:0,0}", (Decimal.Parse(this.tbxEinzelVK.Text) * k.AnzahlAnlagen));
              }

              #region Alternativpositionen

              //Alternativposition 1 -->
              if (rdbTM1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString();                  
                }
              }
              else if (rdbTS1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString();
                }
              }
              else if (rdbNK1.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt1Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt1Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString();  
                }
              }
              //<--Alternativposition 1 

              //Alternativposition 2 -->
              if (rdbTM2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTM.GesamtpreisMaterialLohn * (kTM.Gewinn + k.Sonderzuschlag - 1)) + kTM.Verkaufseuro, 0).ToString();  
                }
              }
              else if (rdbTS2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kTS.GesamtpreisMaterialLohn * (kTS.Gewinn + k.Sonderzuschlag - 1)) + kTS.Verkaufseuro, 0).ToString();  
                }
              }
              else if (rdbNK2.Checked)
              {
                if (cbxOberlicht.Checked)
                {
                  tbxAlt2Preis.Text = Math.Round(((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro) + Decimal.Parse(lblOberlichtG.Text), 0).ToString();
                }
                else
                {
                  tbxAlt2Preis.Text = Math.Round((kNK.GesamtpreisMaterialLohn * (kNK.Gewinn + k.Sonderzuschlag - 1)) + kNK.Verkaufseuro, 0).ToString();  
                } 
              }
              //<--Alternativposition 2  

              #endregion
            }
          }
        }
      }
    }

    /// <summary>
    /// Löscht alle Werte der Eingabefelder und löscht alle Einstellungen der Errorprovider-Objekte.
    /// </summary>
    private void ClearEingabefelder()
    {
      tbxAnlagen.Text = String.Empty;
      tbxBreite.Text = String.Empty;
      tbxTüren.Text = String.Empty;
      tbxTiefe.Text = String.Empty;
      tbxTrw.Text = String.Empty;

      tbxZuschlag.Text = rdbAussparung.Checked ? "0" : tbxZuschlag.Text = tempZuschlagTür;

      tbxVK.Text = rdbAussparung.Checked ? "0" : tbxVK.Text = tempVK;
      tbxSondertextUnten.Text = String.Empty;
      tbxSondertextOben.Text = String.Empty;
      lblPlattenMenge.Text = String.Empty;
      lblPlattenPreis.Text = String.Empty;
      lblPlattenPreisGesamt.Text = String.Empty;
      lblAluMenge.Text = String.Empty;
      lblAluPreis.Text = String.Empty;
      lblAluPreisGesamt.Text = String.Empty;
      lblBeschlagMenge.Text = String.Empty;
      lblBeschlagPreis.Text = String.Empty;
      lblBeschlagPreisGesamt.Text = String.Empty;
      lblFixkosten.Text = String.Empty;
      lblDiverseKosten.Text = String.Empty;
      lblLohnteile.Text = String.Empty;
      lblLohnPreis.Text = String.Empty;
      lblLohnPreisGesamt.Text = String.Empty;
      lblMontageTeile.Text = String.Empty;
      lblMontagePreis.Text = String.Empty;
      lblMontagePreisGesamt.Text = String.Empty;
      lblEinzel.Text = String.Empty;
      lblGesamt.Text = String.Empty;
      lblGesamtVK.Text = String.Empty;
      tbxEinzelVK.Text = String.Empty;
      cbxAlupulver.Checked = false;
      cbxMontage.Checked = true;
      cbxEventual.Checked = false;
      tbxAlupulv.Text = String.Empty;
      lblVK.Text = String.Empty;
      tbxAussparungenPreis.Text = String.Empty;
      tbxAussparungGesamt.Text = String.Empty;
      cobAussaprungBeschreibung.Text = "Aussparung(en)";

      if (this.epAnlagen != null)
      {
        epAnlagen.Clear();
      }
      if (this.epBreite != null)
      {
        epBreite.Clear();
      }
      if (this.epTiefe != null)
      {
        epTiefe.Clear();
      }
      if (this.epTrw != null)
      {
        epTrw.Clear();
      }
      if (this.epTueren != null)
      {
        epTueren.Clear();
      }
      if (this.epVK != null)
      {
        epVK.Clear();
      }
      if (this.epZuschlag != null)
      {
        epZuschlag.Clear();
      }
    }

    // ******************************************************************
    // Methoden zur Validierung der einzelnen Parameter-Textboxen
    // ******************************************************************
    /// <summary> Überprüft, ob die Textbox für die Anlagenstückzahl einen gülten Wert enthält.
    /// </summary>
    /// <returns>Status</returns>
    private bool ValidateAnlagen()
    {
      bool status = false;

      tbxAnlagen.Text = tbxAnlagen.Text.Replace(".", ",");

      if ((tbxAnlagen.Text.Trim() != "") && (Func.IsNumeric(tbxAnlagen.Text, true)) && (Decimal.Parse(tbxAnlagen.Text) != 0.0m))
      {
        epAnlagen.Clear();
        k.AnzahlAnlagen = Decimal.Parse(tbxAnlagen.Text);
        kTM.AnzahlAnlagen = Decimal.Parse(tbxAnlagen.Text);
        kTS.AnzahlAnlagen = Decimal.Parse(tbxAnlagen.Text);
        kNK.AnzahlAnlagen = Decimal.Parse(tbxAnlagen.Text);
        status = true;
      }
      else
      {
        epAnlagen.SetError(tbxAnlagen, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
      }

      return status;
    }

    /// <summary>Überprüft, ob die Textbox für die Anlagenbreite einen gülten Wert enthält.
    /// </summary>
    /// <returns>Status</returns>
    private bool ValidateBreite()
    {
      bool status = false;

      if ((tbxBreite.Text.Trim() != "") && (Func.IsNumeric(tbxBreite.Text, true)) && (Double.Parse(tbxBreite.Text) != 0.0))
      {
        epBreite.Clear();
        k.Anlagenbreite = Int32.Parse(tbxBreite.Text);
        kTM.Anlagenbreite = Int32.Parse(tbxBreite.Text);
        kTS.Anlagenbreite = Int32.Parse(tbxBreite.Text);
        kNK.Anlagenbreite = Int32.Parse(tbxBreite.Text);
        status = true;
      }
      else
      {
        epBreite.SetError(tbxBreite, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
      }

      return status;
    }

    /// <summary>Überprüft, ob die Textbox für die Türenanzahl pro Anlage einen gülten Wert enthält.
    /// </summary>
    /// <returns>Status</returns>
    private bool ValidateTueren()
    {
      bool status = false;

      if ((tbxTüren.Text.Trim() != "") && (Func.IsNumeric(tbxTüren.Text, true)) && (Double.Parse(tbxTüren.Text) != 0.0))
      {
        epTueren.Clear();
        k.AnzahlTuerenAnlage = Int32.Parse(tbxTüren.Text);
        kTM.AnzahlTuerenAnlage = Int32.Parse(tbxTüren.Text);
        kTS.AnzahlTuerenAnlage = Int32.Parse(tbxTüren.Text);
        kNK.AnzahlTuerenAnlage = Int32.Parse(tbxTüren.Text);
        status = true;
      }
      else
      {
        epTueren.SetError(tbxTüren, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
      }

      return status;
    }

    /// <summary>Überprüft, ob die Textbox für die Anlagentiefe einen gülten Wert enthält.
    /// </summary>
    /// <returns>Status</returns>
    private bool ValidateTiefe()
    {
      bool status = false;

      if (tbxTiefe.Text.Trim() != "")
      {
        if (Func.IsNumeric(tbxTiefe.Text, true))
        {
          if (Double.Parse(tbxTiefe.Text) != 0.0)
          {
            epTiefe.Clear();
            k.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
            kTM.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
            kTS.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
            kNK.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
            status = true;
          }
          else
          {
            if (rdbKabinen.Checked)
            {
              epTiefe.Clear();
              k.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
              kTM.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
              kTS.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
              kNK.Anlagentiefe = Int32.Parse(tbxTiefe.Text);
              status = true;
            }
            else
            {
              epTiefe.SetError(tbxTiefe, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
            }
          }
        }
        else
        {
          epTiefe.SetError(tbxTiefe, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
        }
      }
      else
      {
        epTiefe.SetError(tbxTiefe, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
      }

      return status;
    }

    /// <summary>Überprüft, ob die Textbox für die Trennwandanzahl pro Anlage einen gülten Wert enthält.
    /// </summary>
    /// <returns>Status</returns>
    private bool ValidateTrw()
    {
      bool status = false;

      if (tbxTrw.Text.Trim() != "")
      {
        if (Func.IsNumeric(tbxTrw.Text, true))
        {
          if (Double.Parse(tbxTrw.Text) != 0.0)
          {
            epTrw.Clear();
            k.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
            kTM.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
            kTS.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
            kNK.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
            status = true;
          }
          else
          {
            if (rdbKabinen.Checked)
            {
              epTrw.Clear();
              k.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
              kTM.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
              kTS.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
              kNK.AnzahlTrennwaendeAnlage = Int32.Parse(tbxTrw.Text);
              status = true;
            }
            else
            {
              epTrw.SetError(tbxTrw, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
            }
          }
        }
        else
        {
          epTrw.SetError(tbxTrw, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
        }
      }
      else
      {
        epTrw.SetError(tbxTrw, "Bitte geben Sie einen gülten Wert ein: 1 oder mehr!");
      }

      return status;
    }

    /// <summary>Überprüft, ob die Textbox für die Zuschlag pro Tür einen gülten Wert enthält.
    /// </summary>
    /// <returns>Status</returns>
    private bool ValidateZuschlag()
    {
      bool status = false;

      if ((tbxZuschlag.Text != "") && Func.IsNumeric(tbxZuschlag.Text, true))
      {
        epZuschlag.Clear();
        k.ZuschlagTuer = Decimal.Parse(tbxZuschlag.Text);
        kTM.ZuschlagTuer = Decimal.Parse(tbxZuschlag.Text);
        kTS.ZuschlagTuer = Decimal.Parse(tbxZuschlag.Text);
        kNK.ZuschlagTuer = Decimal.Parse(tbxZuschlag.Text);
        status = true;
      }
      else
      {
        epZuschlag.SetError(tbxZuschlag, "Bitte geben Sie einen gülten Wert ein: 0 oder mehr!");
      }

      return status;
    }

    /// <summary>Überprüft, ob die Textbox für das VK Prozent einen gültigen Wert enthält
    /// </summary>
    /// <returns>Status</returns>
    private bool ValidateVk()
    {
      bool status = false;

      if ((tbxVK.Text != "") && (Func.IsNumeric(tbxVK.Text, false)))
      {
        epVK.Clear();
        k.Verkaufsprozent = (100.00m + Decimal.Parse(tbxVK.Text)) / 100;
        k.Verkaufseuro = Decimal.Parse(tbxVK.Text);

        kTM.Verkaufsprozent = (100.00m + Decimal.Parse(tbxVK.Text)) / 100;
        kTM.Verkaufseuro = Decimal.Parse(tbxVK.Text);

        kTS.Verkaufsprozent = (100.00m + Decimal.Parse(tbxVK.Text)) / 100;
        kTS.Verkaufseuro = Decimal.Parse(tbxVK.Text);

        kNK.Verkaufsprozent = (100.00m + Decimal.Parse(tbxVK.Text)) / 100;
        kNK.Verkaufseuro = Decimal.Parse(tbxVK.Text);
        status = true;
      }
      else
      {
        epVK.SetError(tbxVK, "Bitte geben Sie einen gülten Wert ein: 0 oder mehr!");
      }

      return status;
    }

    #endregion

    // **********************************
    // Events
    // **********************************

    #region Events

    private void btnKalkulieren_Click(object sender, EventArgs e)
    {
      Kalkulieren();

      if (positionsNr != null)
      {
        btnAendSpeichern.Enabled = true;
      }
      else
      {
        btnPosAnlegen.Enabled = true;
        btnPosAnlegen.Focus();
      }
    }

    ///<summary>
    ///</summary>
    public void Kalkulieren()
    {
      //using (var dbContext = new DataBaseDataContext())
      //{
      //  if (kalkParamDB != null)
      //  {
      //    kalkParamDB = null;
      //    kalkParamDB = dbContext.Kalkulationsparameter.Where(kp => kp.ParamterID.Equals(1)).FirstOrDefault();
      //  }
      //  else
      //  {
      //    kalkParamDB = dbContext.Kalkulationsparameter.Where(kp => kp.ParamterID.Equals(1)).FirstOrDefault();
      //  }
      //}

      k = null;
      k = new Kalkulation();

      kTM = null;
      kTM = new Kalkulation();

      kTS = null;
      kTS = new Kalkulation();

      kNK = null;
      kNK = new Kalkulation();

      // Artikel festlegen
      DetermineArtikel();

      if (k.Artikel == 9) // Artikel -> Aussparung
      {
        if (tbxAnlagen.Text == "")
        {
          tbxAussparungGesamt.Text = "";
        }
        else
        {
          if (Func.IsNumeric(tbxAnlagen.Text, true) & (tbxAussparungenPreis.Text != "") & (Func.IsNumeric(tbxAussparungenPreis.Text, false)))
          {
            tbxAussparungGesamt.Text = String.Format("{0:#,0.00}", Decimal.Parse(tbxAnlagen.Text) * Decimal.Parse(tbxAussparungenPreis.Text));

            // Button nur enablen wenn eine neue Position angelegt wird.
            if (positionsNr == "")
            {
              btnPosAnlegen.Enabled = true;
            }
          }
        }
      }

      // Platten und Lohnkosten festlegen
      DeterminePlattenLohnOberlicht();

      // Eingegebene Werte in Textboxen überprüfen
      if (ValidateEingabe() & ValidateVk())
      {
        // Berechnungen und Ergebnisausgabe
        DoBerechnenAusgeben();

        // Button nur enablen wenn eine neue Position angelegt wird.
        if (positionsNr == "")
        {
          btnPosAnlegen.Enabled = true;
        }
      }
    }

    private void itemKundeSchließen_Click(object sender, EventArgs e)
    {
      Func.FKalkulation = null;
      this.Close();
    }

    private void itemKalkulationNeu_Click(object sender, EventArgs e)
    {
      ClearEingabefelder();
    }

    private void cbxAlupulver_CheckedChanged(object sender, EventArgs e)
    {
      Endsumme();
    }

    private void cbxMontage_CheckedChanged(object sender, EventArgs e)
    {
      
      if (cbxMontage.Checked)
      {
        lblMontagePreisGesamt.Text = Montage.ToString();
      }
      else
      {
        lblMontagePreisGesamt.Text = "0";
      }

      Endsumme();
    }

    private void rdbVorderwand_CheckedChanged(object sender, EventArgs e)
    {
      SetControlsForParameters(sender);
    }

    private void rdbKabinen_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbKabinen.Checked)
      {
        SetControlsForParameters(sender);
      }
    }

    private void rdbTrennwand_CheckedChanged(object sender, EventArgs e)
    {
      SetControlsForParameters(sender);
    }

    private void rdbOTrw_CheckedChanged(object sender, EventArgs e)
    {
      SetControlsForParameters(sender);
    }

    private void rdbSchamwand_CheckedChanged(object sender, EventArgs e)
    {
      SetControlsForParameters(sender);
    }

    private void btnSchließen_Click(object sender, EventArgs e)
    {
      tempVK = String.Empty;
      tempZuschlagTür = String.Empty;

      if (isAuftrag)
      {
        Func.FAuftragPosition.Close();
        Func.FAuftragPosition = null;
      }
      else
      {
        Func.FAngebotPosition.Close();
        Func.FAngebotPosition = null;
      }
    }

    private void tbxSondertext_KeyDown(object sender, KeyEventArgs e)
    {
      // Die maximale Zeichenanzahl der Textbox für den Sondertext ist auf 198 Zeichen begrenzt.
      if (tbxSondertextUnten.TextLength == 198)
      {
        if (e.KeyCode != Keys.Back)
        {
          MessageBox.Show("Es können nicht mehr als 198 Zeichen eingeben werden.", "Maximale Zeichenanzahl erreicht.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
    }

    // Anwendung der Validierungsmethoden
    private void tbxAnlagen_Validating(object sender, CancelEventArgs e)
    {
      ValidateAnlagen();
    }

    private void tbxBreite_Validating(object sender, CancelEventArgs e)
    {
      ValidateBreite();
    }

    private void tbxTüren_Validating(object sender, CancelEventArgs e)
    {
      ValidateTueren();
    }

    private void tbxTiefe_Validating(object sender, CancelEventArgs e)
    {
      ValidateTiefe();
    }

    private void tbxTrw_Validating(object sender, CancelEventArgs e)
    {
      ValidateTrw();
    }

    private void tbxZuschlag_Validating(object sender, CancelEventArgs e)
    {
      ValidateZuschlag();
    }

    private void tbxVK_Validating(object sender, CancelEventArgs e)
    {
      ValidateVk();
    }

    private void cbxOberlicht_CheckedChanged(object sender, EventArgs e)
    {
      if (!cbxOberlicht.Checked)
      {
        tbxOberlichtLfm.Enabled = false;
        tbxOberlichtLfm.BackColor = Func.CDisabled;
        tbxOberlichtLfm.Clear();
        lblOberlichtG.Enabled = false;
        lblOberlichtG.BackColor = Func.CDisabled;
        lblOberlichtG.Text = "";
      }
      else
      {
        tbxOberlichtLfm.Enabled = true;
        tbxOberlichtLfm.BackColor = Func.CEnabled;
        lblOberlichtG.Enabled = true;
        lblOberlichtG.BackColor = Func.CEnabled;

        //if (tbxBreite.Text != String.Empty && k.Artikel != 0)
        //{
        //    decimal oberlichtLfm = 0.0m;

        //    switch (k.Artikel)
        //    {
        //        case 1:
        //            oberlichtLfm = Math.Round(Decimal.Parse(tbxBreite.Text)/100, 0);
        //            break;
        //        case 2:
        //            oberlichtLfm = Math.Round((Decimal.Parse(tbxBreite.Text) + (Decimal.Parse(tbxTiefe.Text) * Decimal.Parse(tbxTrw.Text))) / 100, 0);
        //            break;
        //        case 3:
        //            oberlichtLfm = Math.Round(Decimal.Parse(tbxBreite.Text) / 100, 0);
        //            break;
        //        case 6:
        //            oberlichtLfm = Math.Round(Decimal.Parse(tbxBreite.Text) / 100, 0);
        //            break;
        //    }

        //    tbxOberlichtLfm.Text = oberlichtLfm.ToString();

        //    lblOberlichtG.Text = Math.Round(Decimal.Parse(tbxOberlichtLfm.Text) * k.Oberlichtkosten, 0).ToString();

        //    tbxEinzelVK.Text = (Decimal.Parse(tbxEinzelVK.Text) + oberlichtLfm).ToString();
        //    lblGesamtVK.Text = (Decimal.Parse(tbxEinzelVK.Text) + (oberlichtLfm * Decimal.Parse(tbxAnlagen.Text))).ToString();
        //}
      }

      Endsumme();
    }

    private void SetControlsForParameters(object sender)
    {
      var x = (RadioButton)sender;

      if (x.Checked)
      {
        tbxTüren.Text = "";
        tbxTiefe.Text = "";
        tbxTrw.Text = "";
        //cobAussaprungBeschreibung.Text = "";

        tbxAnlagen.Text = "";
        tbxAnlagen.Enabled = true;
        tbxAnlagen.BackColor = Func.CEnabled;

        tbxBreite.Enabled = true;
        tbxBreite.BackColor = Func.CEnabled;
        tbxBreite.Text = "";

        tbxZuschlag.Text = tempZuschlagTür == null ? "0" : tempZuschlagTür;

        tbxVK.Text = tempVK;
        tbxVK.Enabled = true;
        tbxVK.BackColor = Func.CEnabled;
        cbxVK.Enabled = true;

        switch (x.Name)
        {
          case "rdbVorderwand":
            gbxErgebnisse.Enabled = true;
            gbxParameter.Enabled = true;
            gbxSondertext.Enabled = true;
            gbxTyp.Enabled = true;
            gbxAussparung.Enabled = false;

            tbxTüren.Enabled = true;
            tbxTüren.BackColor = Func.CEnabled;
            tbxTrw.Enabled = false;
            tbxTrw.BackColor = Func.CDisabled;
            tbxTiefe.Enabled = false;
            tbxTiefe.BackColor = Func.CDisabled;
            tbxZuschlag.Enabled = true;
            tbxZuschlag.BackColor = Func.CEnabled;

            break;
          case "rdbKabinen":
            gbxErgebnisse.Enabled = true;
            gbxParameter.Enabled = true;
            gbxSondertext.Enabled = true;
            gbxTyp.Enabled = true;
            gbxAussparung.Enabled = false;

            tbxTrw.Enabled = true;
            tbxTrw.BackColor = Func.CEnabled;
            tbxTüren.Enabled = true;
            tbxTüren.BackColor = Func.CEnabled;
            tbxTiefe.Enabled = true;
            tbxTiefe.BackColor = Func.CEnabled;
            tbxZuschlag.Enabled = true;
            tbxZuschlag.BackColor = Func.CEnabled;

            break;
          case "rdbTrennwand":
            gbxErgebnisse.Enabled = true;
            gbxParameter.Enabled = true;
            gbxSondertext.Enabled = true;
            gbxTyp.Enabled = true;
            gbxAussparung.Enabled = false;

            tbxTüren.Enabled = false;
            tbxTüren.BackColor = Func.CDisabled;
            tbxZuschlag.Enabled = true;
            tbxZuschlag.BackColor = Func.CEnabled;
            tbxTiefe.Enabled = false;
            tbxTiefe.BackColor = Func.CDisabled;
            tbxTrw.Enabled = false;
            tbxTrw.BackColor = Func.CDisabled;

            break;
          case "rdbSchamwand":
            gbxErgebnisse.Enabled = true;
            gbxParameter.Enabled = true;
            gbxSondertext.Enabled = true;
            gbxTyp.Enabled = true;
            gbxAussparung.Enabled = false;

            tbxTüren.Enabled = false;
            tbxTüren.BackColor = Func.CDisabled;
            tbxTiefe.Enabled = false;
            tbxTiefe.BackColor = Func.CDisabled;
            tbxTrw.Enabled = false;
            tbxTrw.BackColor = Func.CDisabled;
            tbxVK.Enabled = true;
            tbxVK.BackColor = Func.CEnabled;
            tbxZuschlag.Enabled = true;
            tbxZuschlag.BackColor = Func.CEnabled;

            break;
          case "rdbVorOTuer":
            gbxErgebnisse.Enabled = true;
            gbxParameter.Enabled = true;
            gbxSondertext.Enabled = true;
            gbxTyp.Enabled = true;
            gbxAussparung.Enabled = false;

            tbxTüren.Enabled = false;
            tbxTüren.BackColor = Func.CDisabled;
            tbxTiefe.Enabled = false;
            tbxTiefe.BackColor = Func.CDisabled;
            tbxTrw.Enabled = false;
            tbxTrw.BackColor = Func.CDisabled;
            tbxZuschlag.Enabled = true;
            tbxZuschlag.BackColor = Func.CEnabled;

            break;
          case "rdbAussparung":
            gbxAussparung.Enabled = true;
            gbxErgebnisse.Enabled = false;
            gbxParameter.Enabled = true;

            //cobAussaprungBeschreibung.Text = "Aussparung(en)";
            tbxBreite.Enabled = false;
            tbxBreite.BackColor = Func.CDisabled;
            tbxTiefe.Enabled = false;
            tbxTiefe.BackColor = Func.CDisabled;
            tbxTüren.Enabled = false;
            tbxTüren.BackColor = Func.CDisabled;
            tbxTrw.Enabled = false;
            tbxTrw.BackColor = Func.CDisabled;
            tbxZuschlag.Enabled = false;
            tbxZuschlag.BackColor = Func.CDisabled;
            tbxVK.Text = "0";
            tbxVK.Enabled = false;
            tbxVK.BackColor = Func.CDisabled;
            cbxVK.Enabled = false;
            gbxSondertext.Enabled = true;
            gbxTyp.Enabled = false;

            break;
        }
        this.ClearErrorProvider();
      }
    }

    private void rdbAussparung_CheckedChanged(object sender, EventArgs e)
    {
      SetControlsForParameters(sender);
    }

    /// <summary>
    /// ErrorProvier prüfen und gegebenenfalls zurücksetzten.
    /// </summary>
    private void ClearErrorProvider()
    {
      if (this.epAnlagen != null)
      {
        this.epAnlagen.Clear();
      }
      if (this.epBreite != null)
      {
        this.epBreite.Clear();
      }
      if (this.epTiefe != null)
      {
        this.epTiefe.Clear();
      }
      if (this.epTrw != null)
      {
        this.epTrw.Clear();
      }
      if (this.epTueren != null)
      {
        this.epTueren.Clear();
      }
      if (this.epVK != null)
      {
        this.epVK.Clear();
      }
      if (this.epZuschlag != null)
      {
        this.epZuschlag.Clear();
      }
    }

    #endregion

    private void checkBox1_CheckStateChanged(object sender, EventArgs e)
    {
      if (cbxAlternativ1.Checked)
      {
        gpxAlternativ1.Height = 51;
      }
      else
      {
        gpxAlternativ1.Height = 15;
      }

      if (rdbTM.Checked)
      {
        rdbTM1.Enabled = false;
        rdbTS1.Enabled = true;
        rdbNK1.Enabled = true;
        if (rdbTM1.Checked)
        {
          rdbTS1.Checked = true;
        }
      }
      if (rdbTS.Checked)
      {
        rdbTM1.Enabled = true;
        rdbTS1.Enabled = false;
        rdbNK1.Enabled = true;
        if (rdbTS1.Checked)
        {
          rdbTM1.Checked = true;
        }
      }
      if (rdbNK.Checked)
      {
        rdbTM1.Enabled = true;
        rdbTS1.Enabled = true;
        rdbNK1.Enabled = false;
        if (rdbNK1.Checked)
        {
          rdbTM1.Checked = true;
        }
      }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (cbxAlternativ2.Checked)
      {
        gpxAlternativ2.Height = 51;
      }
      else
      {
        gpxAlternativ2.Height = 15;
      }
      if (rdbTM.Checked)
      {
        rdbTM2.Enabled = false;
        rdbTS2.Enabled = true;
        rdbNK2.Enabled = true;
        if (rdbTM2.Checked)
        {
          rdbTS2.Checked = true;
        }
      }
      if (rdbTS.Checked)
      {
        rdbTM2.Enabled = true;
        rdbTS2.Enabled = false;
        rdbNK2.Enabled = true;
        if (rdbTS2.Checked)
        {
          rdbTM2.Checked = true;
        }
      }
      if (rdbNK.Checked)
      {
        rdbTM2.Enabled = true;
        rdbTS2.Enabled = true;
        rdbNK2.Enabled = false;
        if (rdbNK2.Checked)
        {
          rdbTM2.Checked = true;
        }
      }
    }

    private void Form_Kalkulation_Load(object sender, EventArgs e)
    {
      //gbxAussparung.Enabled = false;
    }

    private void rdbTM_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbTM.Checked)
      {
        rdbTM1.Enabled = false;
        rdbTS1.Enabled = true;
        rdbNK1.Enabled = true;
        if (rdbTM1.Checked)
        {
          rdbTS1.Checked = true;
        }

        rdbTM2.Enabled = false;
        rdbTS2.Enabled = true;
        rdbNK2.Enabled = true;
        if (rdbTM2.Checked)
        {
          rdbTS2.Checked = true;
        }
      }
    }

    private void rdbTS_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbTS.Checked)
      {
        rdbTM1.Enabled = true;
        rdbTS1.Enabled = false;
        rdbNK1.Enabled = true;
        if (rdbTS1.Checked)
        {
          rdbTM1.Checked = true;
        }

        rdbTM2.Enabled = true;
        rdbTS2.Enabled = false;
        rdbNK2.Enabled = true;
        if (rdbTS2.Checked)
        {
          rdbTM2.Checked = true;
        }
      }
    }

    private void rdbNK_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbNK.Checked)
      {
        rdbTM1.Enabled = true;
        rdbTS1.Enabled = true;
        rdbNK1.Enabled = false;
        if (rdbNK1.Checked)
        {
          rdbTM1.Checked = true;
        }

        rdbTM2.Enabled = true;
        rdbTS2.Enabled = true;
        rdbNK2.Enabled = false;
        if (rdbNK2.Checked)
        {
          rdbTM2.Checked = true;
        }
      }
    }

    private void btnPosAnlegen_Click(object sender, EventArgs e)
    {
      // Zwischenvariable soll bei allen Artikeln (außer Aussparung) geschrieben werden.
      // Ansonsten würde diese mit 0 belegt werden, da bei einer Aussparung kein VK-Wert eingegeben werden kann.
      if (!rdbAussparung.Checked)
      {
        tempVK = tbxVK.Text;
        tempZuschlagTür = tbxZuschlag.Text;
      }

      if (isAuftrag)
      {
        AuftragPosAnlegen();
      }
      else
      {
        AngebotPosAnlegen();
      }
    }

    /// <summary>
    /// Fills the position with values.
    /// </summary>
    /// <param name="ap">The ap.</param>
    /// <param name="isAlternative1Checked">if set to <c>true</c> [is alternative1 checked].</param>
    /// <param name="isAlternative2Checked">if set to <c>true</c> [is alternative2 checked].</param>
    private void FillAuftragPositionWithValues(ref Auftrag_Position ap, bool isAlternative1Checked, bool isAlternative2Checked)
    {
      ap.AuftragID = int.Parse(auftragsNr);
      ap.Artikel = rdbVorderwand.Checked ? "Vorderwand" : rdbKabinen.Checked ? "Kabine" : rdbTrennwand.Checked ? "Trennwand" : rdbSchamwand.Checked ? "Schamwand" : rdbVorOTuer.Checked ? "Abschlusswand" : "Sonderartikel";
      ap.Sondertext = tbxSondertextUnten.Text == "" ? null : tbxSondertextUnten.Text;
      ap.SondertextOben = tbxSondertextOben.Text == "" ? null : tbxSondertextOben.Text;
      ap.Typ = rdbTM.Checked ? "TM" : rdbTS.Checked ? "TS" : "NK";
      ap.AnlagenStk = tbxAnlagen.Text == "" ? 0 : Decimal.Parse(tbxAnlagen.Text);
      ap.Breite = tbxBreite.Text == "" ? 0 : int.Parse(tbxBreite.Text);
      ap.Tiefe = tbxTiefe.Text == "" ? 0 : int.Parse(tbxTiefe.Text);
      ap.Türen = tbxTüren.Text == "" ? 0 : int.Parse(tbxTüren.Text);
      ap.TW = tbxTrw.Text == "" ? 0 : int.Parse(tbxTrw.Text);
      ap.ZuschlagTür = tbxZuschlag.Text == "" ? 0 : int.Parse(tbxZuschlag.Text);
      ap.Zuschlag = tbxVK.Text == "" ? 0 : int.Parse(tbxVK.Text);
      ap.ZuschlagArt = cbxVK.SelectedItem.ToString();
      ap.Alupulver = cbxAlupulver.Checked ? Decimal.Parse(tbxAlupulv.Text) : 0.00m;
      ap.Montage = cbxMontage.Checked ? "ja" : "nein";
      ap.Oberlicht = cbxOberlicht.Checked ? "ja" : "nein";
      ap.AussparungStk = null;
      ap.SonderartikelEinheit = cbxSonderartikelEinheit.Text == "" ? null : cbxSonderartikelEinheit.Text;

      if (rdbAussparung.Checked)
      {
        ap.AussparungTxt = cobAussaprungBeschreibung.Text == "" ? null : cobAussaprungBeschreibung.Text;
      }
      else
      {
        ap.AussparungTxt = null;
      }

      ap.Einzelpreis = tbxEinzelVK.Text == "" ? 0.00m : Decimal.Parse(tbxEinzelVK.Text);

      if (isAlternative1Checked)
      {
        ap.Alternativ1Typ = rdbTM1.Checked ? "TM" : rdbTS1.Checked ? "TS" : "NK";
        ap.Alternativ1Preis = tbxAlt1Preis.Text == "" ? 0.00m : Decimal.Parse(tbxAlt1Preis.Text);
      }
      else
      {
        ap.Alternativ1Typ = null;
        ap.Alternativ1Preis = null;
      }
      if (isAlternative2Checked)
      {
        ap.Alternativ2Typ = rdbTM2.Checked ? "TM" : rdbTS2.Checked ? "TS" : "NK";
        ap.Alternativ2Preis = tbxAlt2Preis.Text == "" ? 0.00m : Decimal.Parse(tbxAlt2Preis.Text);
      }
      else
      {
        ap.Alternativ2Typ = null;
        ap.Alternativ2Preis = null;
      }
    }

    /// <summary>
    /// Befüllt die übergebene Auftrags- oder Angbotsposition mit Werten.
    /// Entweder bei der Neuanlage einer Position oder beim Ändern einer Position.
    /// </summary>
    /// <param name="ap">Übergebene Angebots- oder Auftragsposition.</param>
    /// <param name="isAlternative1Checked">if set to <c>true</c> [is alternative1 checked].</param>
    /// <param name="isAlternative2Checked">if set to <c>true</c> [is alternative2 checked].</param>
    private void FillAngebotPositionWithValues(ref Angebot_Position ap, bool isAlternative1Checked, bool isAlternative2Checked)
    {
      try
      {
        ap.AngebotID = int.Parse(angebotsNr);

        if (rdbVorderwand.Checked)
        {
          ap.Artikel = "Vorderwand";
        }
        else if (rdbKabinen.Checked)
        {
          ap.Artikel = "Kabine";
        }
        else if (rdbTrennwand.Checked)
        {
          ap.Artikel = "Trennwand";
        }
        else if (rdbSchamwand.Checked)
        {
          ap.Artikel = "Schamwand";
        }
        else if (rdbVorOTuer.Checked)
        {
          ap.Artikel = "Abschlusswand";
        }
        else
        {
          ap.Artikel = "Sonderartikel";
        }

        ap.Sondertext = tbxSondertextUnten.Text == "" ? null : tbxSondertextUnten.Text;
        ap.SondertextOben = tbxSondertextOben.Text == "" ? null : tbxSondertextOben.Text;
        ap.Typ = rdbTM.Checked ? "TM" : rdbTS.Checked ? "TS" : "NK";
        ap.AnlagenStk = tbxAnlagen.Text == "" ? 0 : Decimal.Parse(tbxAnlagen.Text);
        ap.Breite = tbxBreite.Text == "" ? 0 : int.Parse(tbxBreite.Text);
        ap.Tiefe = tbxTiefe.Text == "" ? 0 : int.Parse(tbxTiefe.Text);
        ap.Türen = tbxTüren.Text == "" ? 0 : int.Parse(tbxTüren.Text);
        ap.TW = tbxTrw.Text == "" ? 0 : int.Parse(tbxTrw.Text);
        ap.ZuschlagTür = tbxZuschlag.Text == "" ? 0 : int.Parse(tbxZuschlag.Text);
        ap.Zuschlag = tbxVK.Text == "" ? 0 : int.Parse(tbxVK.Text);
        ap.ZuschlagArt = cbxVK.SelectedItem.ToString();
        ap.Alupulver = cbxAlupulver.Checked ? Decimal.Parse(tbxAlupulv.Text) : 0.00m;
        ap.Montage = cbxMontage.Checked ? "ja" : "nein";
        ap.Oberlicht = cbxOberlicht.Checked ? "ja" : "nein";
        ap.AussparungStk = null;
        ap.SonderartikelEinheit = cbxSonderartikelEinheit.Text == "" ? null : cbxSonderartikelEinheit.Text;
        ap.Eventual = cbxEventual.Checked ? 1: 0;

        if (rdbAussparung.Checked)
        {
          ap.AussparungTxt = cobAussaprungBeschreibung.Text == "" ? null : cobAussaprungBeschreibung.Text;
        }
        else
        {
          ap.AussparungTxt = null;
        }

        ap.Einzelpreis = tbxEinzelVK.Text == "" ? 0.00m : Decimal.Parse(tbxEinzelVK.Text);

        if (isAlternative1Checked)
        {
          ap.Alternativ1Typ = rdbTM1.Checked ? "TM" : rdbTS1.Checked ? "TS" : "NK";
          ap.Alternativ1Preis = tbxAlt1Preis.Text == "" ? 0.00m : Decimal.Parse(tbxAlt1Preis.Text);
        }
        else
        {
          ap.Alternativ1Typ = null;
          ap.Alternativ1Preis = null;
        }

        if (isAlternative2Checked)
        {
          ap.Alternativ2Typ = rdbTM2.Checked ? "TM" : rdbTS2.Checked ? "TS" : "NK";
          ap.Alternativ2Preis = tbxAlt2Preis.Text == "" ? 0.00m : Decimal.Parse(tbxAlt2Preis.Text);
        }
        else
        {
          ap.Alternativ2Typ = null;
          ap.Alternativ2Preis = null;
        }
      }
      catch (Exception ex) { }
    }

    private void AuftragPosAnlegen()
    {
      if (rdbAussparung.Checked)
      {
        tbxEinzelVK.Text = tbxAussparungenPreis.Text;
      }

      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        Auftrag_Position ap = new Auftrag_Position();

        FillAuftragPositionWithValues(ref ap, cbxAlternativ1.Checked, cbxAlternativ2.Checked);

        try
        {
          dbContext.Auftrag_Position.InsertOnSubmit(ap);
          dbContext.SubmitChanges();
          Func.FAuftrag.dgrPositionen.Columns.Clear();

          Func.FAuftrag.dgrPositionen.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = Const.CheckColumHeaderName, Name = Const.CheckColumHeaderName, ThreeState = false });
          Func.FAuftrag.dgrPositionen.Columns.Add(new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell(), HeaderText = Const.PosNrHeaderName, Name = Const.PosNrHeaderName, Visible = true });
          Func.FAuftrag.dgrPositionen.DataSource = Func.LoadAuftragPositionenUebersicht();
          Func.FAuftrag.ColorizeZuschlagColumn();
          Func.FAuftrag.ColorizeTypColumn();
          Func.FAuftrag.GeneratePosNr();
          Func.FAuftrag.DisableSortmode();
          Func.FAuftrag.dgrPositionen.Columns["PosID"].Visible = false;
          Func.FAuftrag.dgrPositionen.Columns["AuftragID"].Visible = false;
          Func.FAuftrag.dgrPositionen.Columns["Auftrag"].Visible = false;
          Func.FAuftrag.dgrPositionen.Columns["Rechnung"].Visible = false;
          Func.FAuftrag.dgrPositionen.Columns["RechnungID"].Visible = true;

          k = null;
          k = new Kalkulation();
          Func.FAuftragPosition.ClearEingabefelder();
          Func.LoadAuftragSumme();

          var auftrag = dbContext.Auftrag.Where(a => a.AuftragID.Equals(int.Parse(auftragsNr))).FirstOrDefault();
          auftrag.Gesamtbetrag = Decimal.Parse(Func.FAuftrag.lblAufGesamt.Text);
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }

      btnPosAnlegen.Enabled = false;
    }

    private void AngebotPosAnlegen()
    {
      if (rdbAussparung.Checked)
      {
        tbxEinzelVK.Text = tbxAussparungenPreis.Text;
      }

      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        var ap = new Angebot_Position();

        FillAngebotPositionWithValues(ref ap, cbxAlternativ1.Checked, cbxAlternativ2.Checked);

        dbContext.Angebot_Position.InsertOnSubmit(ap);

        try
        {
          dbContext.SubmitChanges();
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

          k = null;
          k = new Kalkulation();
          Func.FAngebotPosition.ClearEingabefelder();
          Func.LoadAngebotSumme();

          var angebot = dbContext.Angebot.Where(a => a.AngebotID.Equals(int.Parse(angebotsNr))).FirstOrDefault();
          angebot.Gesamtbetrag = Decimal.Parse(Func.FAngebot.lblGesamt.Text);
          dbContext.SubmitChanges();
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }

      btnPosAnlegen.Enabled = false;
    }

    private void btnAendSpeichern_Click(object sender, EventArgs e)
    {
      if (rdbAussparung.Checked)
      {
        tbxEinzelVK.Text = tbxAussparungenPreis.Text;
      }
      using (var dbContext = new DataBaseDataContext())
      {
        if (isAuftrag)
        {
          try
          {
            var ap = dbContext.Auftrag_Position.Where(auftragPosition => auftragPosition.PosID.Equals(positionsNr)).FirstOrDefault();

            FillAuftragPositionWithValues(ref ap, cbxAlternativ1.Checked, cbxAlternativ2.Checked);

            dbContext.SubmitChanges();

            Func.FAuftrag.dgrPositionen.Columns.Clear();
            Func.FAuftrag.dgrPositionen.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = Const.CheckColumHeaderName, Name = Const.CheckColumHeaderName, ThreeState = false });
            Func.FAuftrag.dgrPositionen.Columns.Add(new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell(), HeaderText = Const.PosNrHeaderName, Name = Const.PosNrHeaderName, Visible = true });
            Func.FAuftrag.dgrPositionen.DataSource = Func.LoadAuftragPositionenUebersicht();
            Func.FAuftrag.ColorizeZuschlagColumn();
            Func.FAuftrag.ColorizeTypColumn();
            Func.FAuftrag.GeneratePosNr();
            Func.FAuftrag.DisableSortmode();
            Func.LoadAuftragSumme();
            Func.FAuftrag.dgrPositionen.Columns["PosID"].Visible = false;
            Func.FAuftrag.dgrPositionen.Columns["AuftragID"].Visible = false;
            Func.FAuftrag.dgrPositionen.Columns["Auftrag"].Visible = false;
            Func.FAuftrag.dgrPositionen.Columns["Rechnung"].Visible = false;
            Func.FAuftrag.dgrPositionen.Columns["RechnungID"].Visible = true;

            var auftrag = dbContext.Auftrag.Where(a => a.AuftragID.Equals(int.Parse(auftragsNr))).FirstOrDefault();
            auftrag.Gesamtbetrag = Decimal.Parse(Func.FAuftrag.lblAufGesamt.Text);
            dbContext.SubmitChanges();

            this.Close();
            Func.FAuftragPosition = null;
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
          }
        }
        else
        {
          try
          {
            var ap = dbContext.Angebot_Position.Where(angebotPosition => angebotPosition.PosID.Equals(positionsNr)).FirstOrDefault();

            FillAngebotPositionWithValues(ref ap, cbxAlternativ1.Checked, cbxAlternativ2.Checked);

            dbContext.SubmitChanges();

            Func.FAngebot.dgrPositionen.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren", Name = "Markieren" });
            Func.FAngebot.dgrPositionen.Columns.Add(new DataGridViewColumn { CellTemplate = new DataGridViewTextBoxCell(), HeaderText = Const.PosNrHeaderName, Name = Const.PosNrHeaderName, Visible = true });
            Func.FAngebot.dgrPositionen.DataSource = Func.LoadAngebotPositionenUebersicht();
            //Func.FAngebot.ColorizeZuschlagColumn();
            //Func.FAngebot.ColorizeTypColumn();
            //Func.FAngebot.GeneratePosNr();
            Func.FAngebot.DisableSortmode();
            Func.LoadAngebotSumme();
            Func.FAngebot.dgrPositionen.Columns["PosID"].Visible = false;
            Func.FAngebot.dgrPositionen.Columns["AngebotID"].Visible = false;
            Func.FAngebot.dgrPositionen.Columns["Angebot"].Visible = false;
            Func.FAngebot.dgrPositionen.Columns["Auftrag"].Visible = false;

            var angebot = dbContext.Angebot.Where(a => a.AngebotID.Equals(int.Parse(angebotsNr))).FirstOrDefault();
            angebot.Gesamtbetrag = Decimal.Parse(Func.FAngebot.lblGesamt.Text);
            dbContext.SubmitChanges();

            this.Close();
            Func.FAngebotPosition = null;
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.ToString());
          }
        }
      }
    }

    private void tbxAnlagen_Enter(object sender, EventArgs e)
    {
      tbxAnlagen.SelectAll();
    }

    private void tbxBreite_Enter(object sender, EventArgs e)
    {
      tbxBreite.SelectAll();
    }

    private void tbxTüren_Enter(object sender, EventArgs e)
    {
      tbxTüren.SelectAll();
    }

    private void tbxTiefe_Enter(object sender, EventArgs e)
    {
      tbxTiefe.SelectAll();
    }

    private void tbxTrw_Enter(object sender, EventArgs e)
    {
      tbxTrw.SelectAll();
    }

    private void tbxZuschlag_Enter(object sender, EventArgs e)
    {
      tbxZuschlag.SelectAll();
    }

    private void tbxVK_Enter(object sender, EventArgs e)
    {
      tbxVK.SelectAll();
    }

    private void tbxEinzelVK_Enter(object sender, EventArgs e)
    {
      tbxEinzelVK.SelectAll();
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
      tbxAussparungenPreis.SelectAll();
    }

    private void tbxAussparungGesamt_Enter(object sender, EventArgs e)
    {
      tbxAussparungGesamt.SelectAll();
    }

    private void tbxAlt1Preis_Enter(object sender, EventArgs e)
    {
      tbxAlt1Preis.SelectAll();
    }

    private void tbxAlt2Preis_Enter(object sender, EventArgs e)
    {
      tbxAlt2Preis.SelectAll();
    }

    private void rdbTM1_CheckedChanged(object sender, EventArgs e)
    {
      Kalkulieren();
    }

    private void rdbTS1_CheckedChanged(object sender, EventArgs e)
    {
      Kalkulieren();
    }

    private void rdbNK1_CheckedChanged(object sender, EventArgs e)
    {
      Kalkulieren();
    }

    private void rdbTM2_CheckedChanged(object sender, EventArgs e)
    {
      Kalkulieren();
    }

    private void rdbTS2_CheckedChanged(object sender, EventArgs e)
    {
      Kalkulieren();
    }

    private void rdbNK2_CheckedChanged(object sender, EventArgs e)
    {
      Kalkulieren();
    }
  }
}