using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Norka.Zeichnen
{
    

    public class PrintPrimitiveRule : IPrintPrimitive
    {
        // CalculateHeight - work out how tall the primitive is...
        public float CalculateHeight(PrintEngine engine, Graphics graphics)
        {
            // we're always five units tall...
            return 5;
        }

        // Print - draw the rule...
        public void Draw(PrintEngine engine, float yPos, Graphics graphics, Rectangle elementBounds)
        {
            // draw a line...
            Pen pen = new Pen(engine.PrintBrush, 1);
            graphics.DrawLine(pen, elementBounds.Left, yPos + 2,
                          elementBounds.Right, yPos + 2);
        }
    }
}
