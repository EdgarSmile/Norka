using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    public class Wohnung : IPosition
    {

        private double _wohnflaeche;
        private float _miete;
        private int _zimmeranzahl;

        private string eigentuemer;

        public Wohnung(string peigentuemer, double flaeche, float preis, int anzahl)
        {
            eigentuemer = peigentuemer;
            _wohnflaeche = flaeche;
            _miete = preis;
            _zimmeranzahl = anzahl;
        }

        public string Eigentuemer
        {
            get { return eigentuemer; }
        }

        public double Wohnflaeche
        {
            get { return _wohnflaeche; }
        }

        public float Miete
        {
            get { return _miete; }
        }

        public string Bezeichnung
        {
            get { return _miete.ToString() + "-Zimmer-Wohnung"; }
        }

        public override string ToString()
        {
            return this.Bezeichnung;
        }

        string IPosition.AsString()
        {
            return
                 "Eigentümer: " + this.Eigentuemer + "\r\n" +
                 "Bezeichnung: " + this.Bezeichnung + "\r\n" +
                 "Miete: " + this.Miete + "\r\n" +
                 "Wohnfläche: " + this.Wohnflaeche
                 ;
        }

        public void DrawOnPanel(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
