
using System.Linq;
using Norka.DB;

namespace Norka.Kalkulationen
{
  #region using
  using System;
  using Properties;


  #endregion

  /// <summary>
  /// Die Klasse Kalkulation stellt alle Eigenschaften und Methoden zur Verfügung um eine Kalkulation durchführen zu können.
  /// </summary>
  public class Kalkulation
  {
    #region Variablen

    private Kalkulationsparameter kalkParamDB;

    #endregion

    // ******************************************************************
    // Gespeicherte Kalkulationsparameter
    // ******************************************************************
    #region Gespeicherte Kalkulationsparameter

    /// <summary>
    /// Ruft den Wert für die Lohnkosten ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Lohnkosten.</value>
    public Decimal Lohnkosten { get; set; } // T

    /// <summary>
    /// Ruft den Wert für die Plattenkosten ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Plattenkosten.</value>
    public Decimal Plattenkosten { get; set; } // P

    /// <summary>
    /// Ruft den Wert für die Beschlagkosten ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Beschlagkosten.</value>
    public Decimal Beschlagkosten { get; set; } // B

    /// <summary>
    /// Ruft den Wert für die Fixkosten ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Fixkosten.</value>
    public Decimal Fixkosten { get; set; } // F

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Die diversen Kosten.</value>
    public Decimal DiverseKosten { get; set; } // 

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Alukosten.</value>
    public Decimal Alukosten { get; set; } // A

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Alubeschichtungskosten pro lfm Aluprofil.</value>
    public Decimal AlubeschKosten { get; set; } // PU

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Montagekosten.</value>
    public Decimal Montagekosten { get; set; } // M

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Der Typ.</value>
    public Decimal Typ { get; set; }

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Der Artikel.</value>
    public Int32 Artikel { get; set; }

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Der Gewinn.</value>
    public Decimal Gewinn { get; set; } // GW

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Die Oberlichtkosten.</value>
    public Decimal Oberlichtkosten { get; set; }

    /// <summary>
    /// Ruft den dieser Eigenschaft zugeordneten Wert ab oder legt diesen fest.
    /// </summary>
    /// <value>Der Sonderzuschlag.</value>
    public Decimal Sonderzuschlag { get; set; }

    #endregion

    // ******************************************************************
    // Eingegebene Kalkulationsparameter
    // ******************************************************************
    #region Eingegebne Kalkulationsparameter
    /// <summary>
    /// Anzahl der Anlagen pro Kalkulation.
    /// </summary>
    /// <value>Die Anlagenanzahl.</value>
    public Decimal AnzahlAnlagen { get; set; } // M5

    /// <summary>
    /// Breite pro Anlage in cm.
    /// </summary>
    /// <value>Die Anlagenbreite.</value>
    public Int32 Anlagenbreite { get; set; } // M1

    /// <summary>
    /// Anzahl der Türen pro Anlage.
    /// </summary>
    /// <value>Die Türenanzahl pro Anlage</value>
    public Int32 AnzahlTuerenAnlage { get; set; } // M3

    /// <summary>
    /// Tiefe pro Anlage in cm.
    /// </summary>
    /// <value>Die Anlagentiefe.</value>
    public Int32 Anlagentiefe { get; set; } // M2

    /// <summary>
    /// Anzahl der Trennwände pro Anlage.
    /// </summary>
    /// <value>Die Anzahld der Trennwände pro Anlage.</value>
    public Int32 AnzahlTrennwaendeAnlage { get; set; } // M4

    /// <summary>
    /// Optionaler Zuschlag pro Tür.
    /// </summary>
    /// <value>Der Zuschlag pro Tür</value>
    public Decimal ZuschlagTuer { get; set; } // M8

    /// <summary>
    /// Pauschaler, optionaler Zuschlag pro Kalkulation in Prozent.
    /// </summary>
    /// <value>Das Verkaufsprozent</value>
    public Decimal Verkaufsprozent { get; set; } // M9

    /// <summary>
    /// Pauschaler, optionaler Zuschlag pro Kalkulation in Euro.
    /// </summary>
    /// <value></value>
    public Decimal Verkaufseuro { get; set; } // M9
    #endregion

    // ******************************************************************
    // Errechnete Preise / Werte
    // ******************************************************************
    #region Errechnete Preise / Werte

    /// <summary>
    /// Die Anzahl der Teile pro Anlage in Stk.
    /// </summary>
    /// <value>Die Anzahl der Teile pro Anlage in Stk</value>
    public int AnzahlTeile
    {
      get
      {
        Int32 teile = 0;

        switch (this.Artikel)
        {
          case 1:
            teile = 3;
            break;
          case 2:
            teile = this.AnzahlTuerenAnlage * 2 + 1 + this.AnzahlTrennwaendeAnlage;
            break;
          case 3:
            teile = 1;
            break;
          case 6:
            teile = 2;
            break;
          case 8:
            teile = 1;
            break;
        }
        return teile;
      }
    }

    /// <summary>
    /// Der Einzelpreis für die Alubeschichtung in Euro.
    /// </summary>
    /// <value>Der Einzelpreis für die Alubeschichtung in Euro</value>
    public Decimal EinzelpreisAlubeschichtung
    {
      get
      {
        return this.GesamtmengeAluprofile * this.AlubeschKosten;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für die Alubeschichtungin Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für die Alubeschichtungin Euro</value>
    public Decimal GesamtpreisAlubeschichtung
    {
      get
      {
        return this.GesamtmengeAluprofile * this.AlubeschKosten * this.AnzahlAnlagen;
      }
    }

    /// <summary>
    /// Gesamtmenge der Platten in lfm.
    /// </summary>
    /// <value>Die Gesamtmenge der Platten pro Anlage in lfm</value>
    public Decimal GesamtmengePlatten
    {
      get
      {
        Decimal _lfmPlatten = 0.0m;

        switch (this.Artikel)
        {
          case 1:
            _lfmPlatten = this.Anlagenbreite / 100.00m;
            break;
          case 2:
            _lfmPlatten = (Convert.ToDecimal(this.Anlagenbreite) / 100.00m) +
                          (Convert.ToDecimal(this.Anlagentiefe) * this.AnzahlTrennwaendeAnlage / 100.00m);
            break;
          case 3:
            _lfmPlatten = this.Anlagenbreite / 100.00m;
            break;
          case 6:
            _lfmPlatten = ((this.Anlagenbreite / 100.00m) - 0.60m); // 60 cm = Breite einer Tür
            break;
          case 8:
            _lfmPlatten = this.Anlagenbreite / 100.00m;
            break;
        }
        return _lfmPlatten;
      }
    }

    /// <summary>
    /// Die Gesamtmenge der Aluprofile pro Anlage in lfm.
    /// </summary>
    /// <value>Die Gesamtmenge der Aluprofile pro Anlage in lfm</value>
    public Decimal GesamtmengeAluprofile
    {
      get
      {
        Decimal lfmAlu = 0.0m;

        switch (this.Artikel)
        {
          case 1: // Vorderwand

            lfmAlu = Math.Round(this.Anlagenbreite / 100.00m + this.AnzahlTeile * 2 * 1.85m, 2); // geändert ltm E-Mail Wolle 10.09.2009
            //_lfmAlu = Math.Round(this.Anlagenbreite / 100.00m * 2.00m + (this.AnzahlTeile * 2.0m * 1.85m), 2);
            break;
          case 2: // R-Kabine
            lfmAlu = Math.Round((this.Anlagenbreite / 100.00m + (this.Anlagentiefe / 100.00m * this.AnzahlTrennwaendeAnlage)) +
            (this.AnzahlTeile * 2.0m * 1.85m), 2); // geändert ltm E-Mail Wolle 10.09.2009

            // _lfmAlu = Math.Round((this.Anlagenbreite / 100.00m + (this.Anlagentiefe / 100.00m * this.AnzahlTrennwaendeAnlage)) * 2.0m +
            //(this.AnzahlTeile * 2.0m * 1.85m), 2);
            break;
          case 3: // Trennwand - richtig
            lfmAlu = Math.Round(this.Anlagenbreite / 100.00m + 2.0m * 1.85m, 2);
            break;
          case 6: // Vorderwand ohne Tür 
            lfmAlu = Math.Round((this.Anlagenbreite / 100.00m) - 0.60m + ((this.AnzahlTeile * 2.0m) * 1.85m), 2);
            break;
          case 8: // Schamwand - falsch
            lfmAlu = Math.Round(this.Anlagenbreite / 100.00m + 2.0m * 1.85m, 2);
            break;
        }

        return lfmAlu;
      }
    }

    /// <summary>
    /// Der Gesamtpreis der Platten pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis der Platten pro Anlage in Euro</value>
    public Decimal GesamtpreisPlatten
    {
      get
      {
        return this.Plattenkosten * this.GesamtmengePlatten;
      }
    }

    /// <summary>
    /// Der Gesamtpreis der Aluprofile pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis der Aluprofile pro Anlage in Euro</value>
    public Decimal GesamtpreisAluprofil
    {
      get
      {
        return this.Alukosten * this.GesamtmengeAluprofile;
      }
    }

    /// <summary>
    /// Der Gesamtpreis der Beschläge pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis der Beschläge pro Anlage in Euro</value>
    public Decimal GesamtpreisBeschlaege
    {
      get
      {
        return this.Beschlagkosten * this.AnzahlTuerenAnlage;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für den Lohn pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für den Lohn pro Anlage in Euro</value>
    public Decimal GesamtpreisLohn
    {
      get
      {
        return this.AnzahlTeile * this.Lohnkosten;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für die Fixkosten pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für die Fixkosten pro Anlage in Euro</value>
    public Decimal GesamtpreisFixkosten
    {
      get
      {
        return this.AnzahlTeile * this.Fixkosten;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für die diversen Kosten pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für die diversen Kosten pro Anlage in Euro</value>
    public Decimal GesamtpreisDiverseKosten { get; set; } // calcPreisDiverse

    /// <summary>
    /// Der Gesamtpreis für die Montage pro Anlage in Euro
    /// </summary>
    /// <value>Der Gesamtpreis für die Montage pro Anlage in Euro</value>
    public Decimal GesamtpreisMontage
    {
      get
      {
        return this.AnzahlTeile * this.Montagekosten;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für das Material pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für das Material pro Anlage in Euro</value>
    public Decimal GesamtpreisMaterial
    {
      get
      {
        return this.GesamtpreisPlatten + this.GesamtpreisAluprofil + this.GesamtpreisBeschlaege +
             this.GesamtpreisFixkosten +
             this.GesamtpreisDiverseKosten;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für das Material + Lohn pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für das Material + Lohn pro Anlage in Euro</value>
    public Decimal GesamtpreisMaterialLohn
    {
      get
      {
        return this.GesamtpreisMaterial + this.GesamtpreisLohn;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für das Material + Lohn + Montage pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für das Material + Lohn + Montage pro Anlage in Euro</value>
    public Decimal GesamtpreisMaterialLohnMontage
    {
      get
      {
        return this.GesamtpreisMaterialLohn + this.GesamtpreisMontage;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für das Material + Lohn + Montage + Alubeschichtung pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für das Material + Lohn + Montage + Alubeschichtung pro Anlage in Euro</value>
    public Decimal GesamtpreisMaterialLohnMontageAlu
    {
      get
      {
        return this.GesamtpreisMaterialLohnMontage + this.EinzelpreisAlubeschichtung;
      }
    }

    /// <summary>
    /// Der Gesamtpreis für das Material + Lohn + Alubeschichtung pro Anlage in Euro.
    /// </summary>
    /// <value>Der Gesamtpreis für das Material + Lohn + Alubeschichtung pro Anlage in Euro</value>
    public Decimal GesamtpreisMaterialLohnAlu
    {
      get
      {
        return this.GesamtpreisMaterialLohn + this.EinzelpreisAlubeschichtung;
      }
    }

    /// <summary>
    /// Die Gewinnreserve.
    /// </summary>
    /// <value>Die Gewinnreserve.</value>
    public Decimal Gewinnreserve
    {
      get
      {
        return this.AnzahlTeile * this.Gewinn;
      }
    }

    #endregion



    
    // ******************************************************************
    // Konstruktor
    // ******************************************************************
    #region Konstruktor
    /// <summary>
    /// Intitialisiert eine neue Instanz der <see cref="Kalkulation"/> Klasse.
    /// </summary>
    public Kalkulation()
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
      }

      this.Montagekosten = kalkParamDB.Montagekosten;
      this.Alukosten = kalkParamDB.Aluprofilkosten;
      this.AlubeschKosten = kalkParamDB.Pulverkosten;
      this.Beschlagkosten = kalkParamDB.Beschlagkosten;
      this.Fixkosten = kalkParamDB.Fixkosten;
      this.Gewinn = kalkParamDB.Gewinn;
      this.Sonderzuschlag = kalkParamDB.Sonderzuschlag;
    }
    #endregion

    // ******************************************************************
    // Methoden
    // ******************************************************************
    #region Methoden


    /// <summary>
    /// Gesamtpreis für diverse Kosten - PD
    /// </summary>
    /// <param name="p_zuschlag">Zuschlag pro Tür</param>
    /// <returns>Gesamtpreis Diverse</returns>
    public Decimal calcPreisDiverse(Decimal p_zuschlag)
    {
      Decimal _preisDiverse = 0.0m;

      if (this.Artikel == 1 || this.Artikel == 2)
      {
        _preisDiverse = p_zuschlag * this.AnzahlTuerenAnlage;
      }

      if (this.Artikel == 3 || this.Artikel == 6 || this.Artikel == 8)
      {
        _preisDiverse = p_zuschlag;
      }

      return _preisDiverse;
    }

    /******************************************************************/
    /********** Diese beiden Methoden werden nicht verwendet **********/
    /******************************************************************/

    /// <summary>
    /// Berechnung des Einzelpreis für Material + Gesamtpreis für Lohn + Gewinnzuschlag - EPOM
    /// </summary>
    /// <returns></returns>
    //public Decimal calcEndpreisMaterialLohnGewinn()
    //{
    //  return (this.GesamtpreisMaterialLohn + this.Gewinnreserve);
    //}

    /// <summary>
    /// Berechnung des Endpreises für Material + Gesamtpreis für Lohn + Gesamtpreis für Montage + Gewinnzuschlag- EPMM
    /// </summary>
    /// <returns></returns>
    //public Decimal calcEndpreisMaterialLohnMontageGewinn()
    //{
    //  return (this.GesamtpreisMaterialLohnMontage + this.Gewinnreserve);
    //}

    
    #endregion
  }
}