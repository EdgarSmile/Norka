using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    public interface IPosition
    {
         string AsString();

         void DrawOnPanel(Graphics graphics);
    }
}
