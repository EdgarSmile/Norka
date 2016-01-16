using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Norka.DB;

namespace Norka.Zeichnen
{

  public class Vorderwand : IPosition
  {
    #region Properties

    // Sägemaße -->
    public float Schildhoehe
    {
      get { return (float)Math.Round(Hoehe - Bodenfreiheit - Zeichenparameter.SchildLuft, 1); }
    }

    public float Tuerhoehe
    {
      get { return (float)Math.Round(Hoehe - Bodenfreiheit - Zeichenparameter.TuerLuft, 1); }
    }

    public float PlatteSchildLinks
    {
      get { return (float)Math.Round(Schildlinks - Zeichenparameter.VW_PlattenLuft, 1); }
    }

    public float PlatteSchildRechts
    {
      get { return (float)Math.Round(Schildrechts - Zeichenparameter.VW_PlattenLuft, 1); }
    }

    public float Verbindungsstueck
    {
      get { return (float)Math.Round(Breite + Zeichenparameter.VW_Verbindungsstück, 1); }
    }

    public float Verstaerkung
    {
      get { return Breite >= Zeichenparameter.VW_VerstaerkungGrenze ? (float)Math.Round(Breite + Zeichenparameter.VW_Verbindungsstück, 1) : 0; }
    }

    public float Tuere
    {
      get { return (float)Math.Round(Tuerbreite - U, 1); }
    }
    // Sägemaße <--

    public int Typ { get; set; }

    // Eingabemaße -->
    public float Hoehe { get; set; }

    public float Breite { get; set; }

    public float Bodenfreiheit { get; set; }

    public float Tuerbreite { get; set; }

    public float Schildlinks { get; set; }

    public float Schildrechts { get; set; }

    public float U { get; set; }

    // Eingabemaße <--

    public Zeichenparameter Zeichenparameter { get; set; }

    #endregion


    public override string ToString()
    {
      return "Vorderwand - Typ " + Typ;
    }

    public string AsString()
    {
      //float vs = Breite >= Zeichenparameter.VerstaerkungGrenze ? Breite + Zeichenparameter.Verbindungsstück : 0;

      return
           "Typ:                             " + Typ + "\n\r\n\r" +
            "Schild-Höhe:            " + Schildhoehe + "\n\r\n\r" +
            "Tür-Höhe:                 " + Tuerhoehe + "\n\r\n\r" +
          "Platten" + "\n\r\n\r" +
          "1    X    " + PlatteSchildRechts + "\n\r" +
          "1    X    " + PlatteSchildLinks + "\n\r" +
           "1    X    " + Tuere + "\n\r\n\r" +
           "Vb   " + Verbindungsstueck + "\n\r" +
           "Vs   " + Verstaerkung + "\n\r"
          ;

    }


    public void DrawOnPanel(Graphics graphics)
    {
      Pen thickPen = new Pen(Color.Black, 15);
      Pen middlePen = new Pen(Color.Black, 10);
      Pen thinPen = new Pen(Color.Black, 5);

      switch (Typ)
      {
        case 10:
          // Rückwand
          graphics.DrawLine(thinPen, 5, 50, 300, 50);

          // Linke Wand
          graphics.DrawLine(thinPen, 7, 50, 7, 200);

          // Rechte Wand
          graphics.DrawLine(thinPen, 297, 50, 297, 200);

          // Schild-Links
          graphics.DrawLine(thickPen, 7, 145, 70, 145);

          // Schild-Rechts
          graphics.DrawLine(thickPen, 297, 145, 222, 145);

          // Kloschüssel
          graphics.DrawLine(middlePen, 140, 75, 170, 75);

          break;
        case 11:
          // Rückwand
          graphics.DrawLine(thinPen, 5, 50, 300, 50);

          // Linke Wand
          graphics.DrawLine(thinPen, 7, 50, 7, 200);

          // Rechte Wand
          graphics.DrawLine(thinPen, 297, 50, 297, 200);

          // Schild-Links
          graphics.DrawLine(thickPen, 7, 145, 70, 145);

          // Schild-Rechts
          graphics.DrawLine(thickPen, 297, 145, 165, 145);

          // Kloschüssel
          graphics.DrawLine(middlePen, 270, 80, 270, 120);

          break;

        case 12:
          // Rückwand
          graphics.DrawLine(thinPen, 5, 50, 300, 50);

          // Linke Wand
          graphics.DrawLine(thinPen, 7, 50, 7, 200);

          // Rechte Wand
          graphics.DrawLine(thinPen, 297, 50, 297, 200);

          // Schild-Links
          graphics.DrawLine(thickPen, 7, 145, 130, 145);

          // Schild-Rechts
          graphics.DrawLine(thickPen, 297, 145, 220, 145);

          // Kloschüssel
          graphics.DrawLine(middlePen, 25, 80, 25, 120);

          break;

        case 13:
          // Rückwand
          //graphics.DrawLine(thinPen, 5, 50, 300, 50);

          // Linke Wand
          graphics.DrawLine(thinPen, 7, 50, 7, 200);

          // Rechte Wand
          graphics.DrawLine(thinPen, 297, 50, 297, 200);

          // Schild-Links
          graphics.DrawLine(thickPen, 7, 145, 70, 145);

          // Schild-Rechts
          graphics.DrawLine(thickPen, 297, 145, 222, 145);

          // Kloschüssel
          //graphics.DrawLine(middlePen, 140, 75, 170, 75);
          break;
      }

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }
  }
}
