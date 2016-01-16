using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    
    public class Vorderwand : IPosition
    {
        private  int _typ;
        private  float _hoehe;
        private  float _breite;
        private  float _bodenfreiheit;
        private  float _tuerbreite;
        private  float _schildlinks;
        private  float _schildrechts;
        private  float _u;


        public int Typ
        {
            get { return _typ; }
            set { _typ = value;}
        }

        public float Hoehe
        {
            get { return _hoehe; }
            set { _hoehe = value; }
        }
        public float Breite
        {
            get { return _breite; }
            set { _breite = value; }
        }

        public float Bodenfreiheit
        {
            get { return _bodenfreiheit; }
            set { _bodenfreiheit = value; }
        }

        public float Tuerbreite
        {
            get { return _tuerbreite; }
            set { _tuerbreite = value; }
        }

        public float Schildlinks
        {
            get { return _schildlinks; }
            set { _schildlinks = value; }
        }

        public float Schildrechts
        {
            get { return _schildrechts; }
            set { _schildrechts = value; }
        }

        public float U
        {
            get { return _u; }
            set { _u = value; }
        }

        public Vorderwand(int pTyp, float pHoehe, float pBreite, float pBodenfreiheit, float pTuerbreite, float pSchildlinks, float pSchildrechts, float pU)
        {
            _typ = pTyp;
            _hoehe = pHoehe;
            _breite = pBreite;
            _bodenfreiheit = pBodenfreiheit;
            _tuerbreite = pTuerbreite;
            _schildlinks = pSchildlinks;
            _schildrechts = pSchildrechts;
            _u = pU;
        }



        public override string ToString()
        {
            return "Vorderwand - Typ " + Typ;
        }

        public string AsString()
        {
            float vs = Breite >= 170f ? Breite + 4f : 0;

            return
                 "Typ:                             " + Typ + "\n\r\n\r" +
                  "Schild-Höhe:            " + (Hoehe - Bodenfreiheit - 0.6f) + "\n\r\n\r" +
                  "Tür-Höhe:                 " + (Hoehe - Bodenfreiheit - 2.9f) + "\n\r\n\r" +
                "Platten" + "\n\r\n\r" +
                "1    X    " + (Schildrechts - 1.7f) + "\n\r" +
                "1    X    " + (Schildlinks - 1.7f) + "\n\r" +
                 "1    X    " + (Tuerbreite - U) + "\n\r\n\r" +
                 "Vb   " + (Breite + 4f) + "\n\r" +
                 "Vs   " + vs + "\n\r"
                ;

        }


        public void DrawOnPanel(Graphics graphics)
        {
            Pen thickPen = new Pen(Color.Black, 15);
            Pen middlePen = new Pen(Color.Black, 10);
            Pen thinPen = new Pen(Color.Black, 5);

            switch (_typ)
            {
                case 10:

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
                    //graphics.DrawRectangle(myPen, new Rectangle(5, 5, 200, 300));
                    break;

                case 12:

                    break;

                case 13:

                    break;
            }

            thinPen.Dispose();
            middlePen.Dispose();
            thickPen.Dispose();
            graphics.Dispose();
        }
    }
}
