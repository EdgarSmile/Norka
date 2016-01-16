using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    public class Seitenumbruch : IPosition
    {
        private string text;
        private bool _umbruch;


        public Seitenumbruch(string pText)
        {
            text = pText;
            _umbruch = true;
        }
        public override string ToString()
        {
            return text;
        }


        public void Print(PrintElement element)
        {
            element.AddText(text);
        }


        public string AsString()
        {
            return text;
        }

        public void DrawOnPanel(Graphics graphics)
        {
            throw new NotImplementedException();
        }
    }
}
