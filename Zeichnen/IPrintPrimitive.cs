using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Norka.Zeichnen
{
    public interface IPrintPrimitive
    {
        // CalculateHeight - work out how tall the primitive is...
        float CalculateHeight(PrintEngine engine, Graphics graphics);

        // Print - tell the primitive to physically draw itself...
        void Draw(PrintEngine engine, float yPos, Graphics graphics, Rectangle elementBounds);
    }
}
