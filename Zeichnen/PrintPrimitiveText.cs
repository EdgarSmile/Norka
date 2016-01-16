using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Norka.Zeichnen
{
    public class PrintPrimitiveText : IPrintPrimitive
    {
        // members...
        public String Text;

        public PrintPrimitiveText(String buf)
        {
            Text = buf;
        }
        // CalculateHeight - work out how tall the primitive is...
        public float CalculateHeight(PrintEngine engine, Graphics graphics)
        {
            // return the height...
            return engine.PrintFont.GetHeight(graphics);
        }
        // Print - draw the text...
        public void Draw(PrintEngine engine, float yPos, Graphics graphics, Rectangle elementBounds)
        {
            // draw it...
            graphics.DrawString(engine.ReplaceTokens(Text), engine.PrintFont,
            engine.PrintBrush, elementBounds.Left, yPos, new StringFormat());
        }
    }

}
