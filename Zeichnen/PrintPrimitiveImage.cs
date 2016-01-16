using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Norka.Zeichnen
{
    public class PrintPrimitiveImage : IPrintPrimitive
    {
        Image i;

        public PrintPrimitiveImage(string bmpPath)
        {
            i = Image.FromFile(bmpPath);
        }

        public float CalculateHeight(PrintEngine engine, Graphics graphics)
        {
            return (i.Height / i.HorizontalResolution) * 100;
        }


        public void Draw(PrintEngine engine, float yPos, Graphics graphics, Rectangle elementBounds)
        {
            graphics.DrawImage(i, elementBounds.X, elementBounds.Y);
        }
    } 
}
