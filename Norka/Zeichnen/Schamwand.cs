using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Norka.DB;

namespace Norka.Zeichnen
{

  public class Schamwand : IPosition
  {
    #region Properties

    // Sägemaße -->
    public float PlatteHoehe
    {
      get
      {
        float result = 0.0f;

        if (Artikel == "frei")
        {
          result = (float)Math.Round(Hoehe - Bodenfreiheit);
        }
        else if (Artikel == "fuss")
        {
          result = (float)Math.Round(Hoehe - Bodenfreiheit - Zeichenparameter.SchildLuft,1);
        }
        return result;
      }
    }

    public float PlatteBreite
    {
      get
      {
        float result = 0.0f;

        if (Artikel == "frei")
        {
          result = (float)Math.Round(Breite - Zeichenparameter.SchildLuft,1);
        }
        else if (Artikel == "fuss")
        {
          result = (float)Math.Round(Breite - Zeichenparameter.VW_PlattenLuft,1);
        }
        return result;
      }
    }

    // Sägemaße <--

    // Eingabemaße -->
    public float Hoehe { get; set; }

    public float Breite { get; set; }

    public float Bodenfreiheit { get; set; }

    public int Stk { get; set; }

    // Eingabemaße <--

    public Zeichenparameter Zeichenparameter { get; set; }

    public string Artikel { get; set; }


    #endregion


    public override string ToString()
    {
      string result = "";

      if (Artikel == "frei")
      {
        result = "Schamwand freihängend";
      }
      else if (Artikel == "fuss")
      {
        result = "Schamwand mit Fuß";
      }
      return result;
    }

    public string AsString()
    {
      //float vs = Breite >= Zeichenparameter.VerstaerkungGrenze ? Breite + Zeichenparameter.Verbindungsstück : 0;

      return
           "Typ:                             " + Artikel + "\n\r\n\r" +
            "Stückzahl:             " + Stk + "\n\r\n\r" +
           "Höhe:               " + Hoehe + "\n\r\n\r" +
            "Breite:              " + Breite
          ;

    }


    public void DrawOnPanel(Graphics graphics) { }

  }
}
