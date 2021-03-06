﻿using System;
using System.Drawing;
using Norka.DB;

namespace Norka.Zeichnen
{
  public class Sonderkabine : IPosition
  {
    // Sägemaße

    #region Properties

    // Sägemaße -->
    public float Schildhoehe
    {
      get { return (float)Math.Round(Hoehe - Bodenfreiheit - Zeichenparameter.SchildLuft,1); }
    }

    public float Tuerhoehe
    {
      get { return (float)Math.Round(Hoehe - Bodenfreiheit - Zeichenparameter.TuerLuft,1); }
    }

    public float PlatteSchildWand
    {
      get { return (float)Math.Round(Schildwand - Zeichenparameter.RK_SchildLuft,1); }
    }

    public float PlatteSchildEck
    {
	  get {return Typ < 3 ? (float)Math.Round(Schildeck - Zeichenparameter.RK_MittelschildLuft,1) : (float)Math.Round(Schildeck - Zeichenparameter.RK_SchildLuft,1);}
    }

    public float PlatteTrennwand
    {
      get { return (float)Math.Round(Trennwand - Zeichenparameter.RK_TrennwandLuft,1); }
    }

    public float PlatteMittelschildL
    {
      get { return (float)Math.Round(MittelschildL - Zeichenparameter.RK_MittelschildLuft,1); }
    }

    public float PlatteMittelschildR
    {
      get { return (float)Math.Round(MittelschildR - Zeichenparameter.RK_MittelschildLuft,1); }
    }

    public float Tuere
    {
      get { return (float)Math.Round(Tuerbreite - U,1); }
    }

    public float Aussen
    {
      get { return (float)Math.Round(Trennwand + Zeichenparameter.RK_Trennwandstaerke,1); }
    }

    // Sägemaße <--

    public float Alu
    {
      get { return (float)Math.Round(Trennwand + Zeichenparameter.RK_Alu,1); }
    }

    public float AluEckTW
    {
      get { return (float)Math.Round(Trennwand + Zeichenparameter.EK_Alu,1); }
    }

    public float Verbindungsstueck
    {
      get
      {
        return Typ < 3 ? Breite : Breite + Zeichenparameter.RK_Verbindungsstück;
      }
    }

    public string Artikel { get; set; }

    public int Typ { get; set; }

    // Eingabemaße -->
    public float Hoehe { get; set; }

    public float Breite { get; set; }

    public float Bodenfreiheit { get; set; }

    public float Tuerbreite { get; set; }

    public int Tueranzahl { get; set; }

    public float Trennwand { get; set; }

    public float MittelschildL { get; set; }

    public float MittelschildR { get; set; }

    public float Schildwand { get; set; }

    public float Schildeck { get; set; }

    public float U { get; set; }

    // Eingabemaße <--

    public Zeichenparameter Zeichenparameter { get; set; }

    #endregion

    public override string ToString()
    {
      return "Sonderkabine Typ - " + Typ;
    }

    public string AsString()
    {
      //float vs = Breite >= Zeichenparameter.VerstaerkungGrenze ? Breite + Zeichenparameter.Verbindungsstück : 0;

      string result = "";

      switch (Typ)
      {
        case 1:
          result = "Typ:                             " + Typ + "\n\r\n\r" +
                   "Schild-Höhe:            " + Schildhoehe + "\n\r\n\r" +
                   "Tür-Höhe:                 " + Tuerhoehe + "\n\r\n\r" +
                   "Platten" + "\n\r\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteTrennwand + " / " + Alu + "\n\r" +
                   "1    X    " + PlatteTrennwand + " / " + AluEckTW + "\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteMittelschildL + "\n\r" +
                   "1    X    " + PlatteSchildEck + "\n\r" +
                   "1    X    " + PlatteSchildWand + "\n\r" +
                   Tueranzahl + "    X    " + Tuere + "\n\r\n\r" +
                   "Vb   " + Verbindungsstueck + "\n\r" +
                   "Außen: " + Aussen + "\n\r\n\r";
          break;
        case 2:
          result = "Typ:                             " + Typ + "\n\r\n\r" +
                   "Schild-Höhe:            " + Schildhoehe + "\n\r\n\r" +
                   "Tür-Höhe:                 " + Tuerhoehe + "\n\r\n\r" +
                   "Platten" + "\n\r\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteTrennwand + " / " + Alu + "\n\r" +
                   "1    X    " + PlatteTrennwand + " / " + AluEckTW + "\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteMittelschildL + "\n\r" +
                   "1    X    " + PlatteSchildEck + "\n\r" +
                   "1    X    " + PlatteSchildWand + "\n\r" +
                   Tueranzahl + "    X    " + Tuere + "\n\r\n\r" +
                   "Vb   " + Verbindungsstueck + "\n\r" +
                   "Außen: " + Aussen + "\n\r\n\r";
          break;

        case 3:
          result = "Typ:                             " + Typ + "\n\r\n\r" +
                   "Schild-Höhe:            " + Schildhoehe + "\n\r\n\r" +
                   "Tür-Höhe:                 " + Tuerhoehe + "\n\r\n\r" +
                   "Platten" + "\n\r\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteTrennwand + " / " + Alu + "\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteMittelschildL + "\n\r" +
                   "1    X    " + PlatteSchildWand + "\n\r" +
                   "1    X    " + PlatteSchildEck + "\n\r" +
                   Tueranzahl + "    X    " + Tuere + "\n\r\n\r" +
                   "Vb   " + Verbindungsstueck + "\n\r" +
                   "Außen: " + Aussen + "\n\r\n\r";
          break;

        case 4:
          result = "Typ:                             " + Typ + "\n\r\n\r" +
                   "Schild-Höhe:            " + Schildhoehe + "\n\r\n\r" +
                   "Tür-Höhe:                 " + Tuerhoehe + "\n\r\n\r" +
                   "Platten" + "\n\r\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteTrennwand + " / " + Alu + "\n\r" +
                   "1    X    " + PlatteMittelschildL + "\n\r" +
                   "1    X    " + PlatteMittelschildR + "\n\r" +
                   "1    X    " + PlatteSchildWand + "\n\r" +
                   "1    X    " + PlatteSchildEck + "\n\r" +
                   Tueranzahl + "    X    " + Tuere + "\n\r\n\r" +
                   "Vb   " + Verbindungsstueck + "\n\r" +
                   "Außen: " + Aussen + "\n\r\n\r";
          break;

        case 5:
          result = "Typ:                             " + Typ + "\n\r\n\r" +
                   "Schild-Höhe:            " + Schildhoehe + "\n\r\n\r" +
                   "Tür-Höhe:                 " + Tuerhoehe + "\n\r\n\r" +
                   "Platten" + "\n\r\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteTrennwand + " / " + Alu + "\n\r" +
                   (Tueranzahl - 1) + "    X    " + PlatteMittelschildL + "\n\r" +
                   "1    X    " + PlatteSchildWand + "\n\r" +
                   "1    X    " + PlatteSchildEck + "\n\r" +
                   Tueranzahl + "    X    " + Tuere + "\n\r\n\r" +
                   "Vb   " + Verbindungsstueck + "\n\r" +
                   "Außen: " + Aussen + "\n\r\n\r";
          break;
      }
      return result;
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