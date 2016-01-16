using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    [Serializable()]
    public class Text : IPosition
    {
        private string _text;

        public string Beschreibung
        {
            get{ return _text;}
            set { _text = value; }
        }

        public Text(string pText)
        {
            _text = pText;
        }
        public override string ToString()
        {
            return "Text";
        }

 

        public string AsString()
        {
            return "Text: \n\r" + Beschreibung;
        }

        public void DrawOnPanel(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
