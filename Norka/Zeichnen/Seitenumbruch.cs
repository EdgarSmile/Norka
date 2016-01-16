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
      private string text = "SEITENUMBRUCH";
      


        public Seitenumbruch()
        {
        }
        public override string ToString()
        {
            return text;
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
