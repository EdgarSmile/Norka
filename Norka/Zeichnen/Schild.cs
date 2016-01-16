using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Norka.DB;

namespace Norka.Zeichnen
{

  public class Schild : IPosition
  {
    #region Properties

    // Sägemaße -->
    public float PlatteSchildHoehe
    {
      get
      {
        return (float)Math.Round(Hoehe - Bodenfreiheit - Zeichenparameter.SchildLuft,1);
      }
    }

    public float PlatteSchildBreite
    {
      get
      {
        return (float)Math.Round(Schildbreite - Zeichenparameter.VW_PlattenLuft,1);
      }
    }

    public float HöheAussparung
    {
      get
      {
        return (float)Math.Round(Hoehe - Brüstungshöhe,1);
      }
    }

    public float PlatteAussparungBreite
    {
      get
      {
        return (float)Math.Round(Aussparungsbreite - Zeichenparameter.VW_PlattenLuft,1);
      }
    }

    public float PlatteAussparungHöhe
    {
      get
      {
        return (float)Math.Round(HöheAussparung - Zeichenparameter.SchildLuft,1);
      }
    }

    public float AluAussparung
    {
      get
      {
        return (float)Math.Round(HöheAussparung - Zeichenparameter.SCHILD_Alu,1);
      }
    }

    // Sägemaße <--

    // Eingabemaße -->
    public float Hoehe { get; set; }

    public float Brüstungshöhe { get; set; }

    public float Schildbreite { get; set; }

    public float Aussparungsbreite { get; set; }

    public float Bodenfreiheit { get; set; }

    public int Stk { get; set; }

    // Eingabemaße <--

    public Zeichenparameter Zeichenparameter { get; set; }

    public string Artikel { get; set; }


    #endregion


    public override string ToString()
    {
      string result = "";

      if (Artikel == "schildLinks")
      {
        result = "Schild links";
      }
      else if (Artikel == "schildRechts")
      {
        result = "Schild rechts";
      }
      return result;
    }

    public string AsString()
    {
      //float vs = Breite >= Zeichenparameter.VerstaerkungGrenze ? Breite + Zeichenparameter.Verbindungsstück : 0;

      return
           "Typ:                             Trennwand "+ "\n\r\n\r" +
            "Stückzahl:             " + Stk +"\n\r" +
           "Höhe Schild:               " + Hoehe + "\n\r" +
           "Höhe Aussparung:        " + HöheAussparung + "\n\r" +
            "Breite Schild:              " + Schildbreite+ "\n\r" +
            "Breite Aussparung:              " + Aussparungsbreite+ "\n\r\n\r" +
            "Platten:" + "\n\r\n\r" +
            Stk + " x " + PlatteSchildBreite+"\n\r" +
            Stk + " x " + PlatteAussparungBreite  + "\n\r\n\r" +
            "Alu:" + "\n\r\n\r" +

            Stk * 2 + " x " + AluAussparung
          ;

    }


    public void DrawOnPanel(Graphics graphics) { }

  }
}
