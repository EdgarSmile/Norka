using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    public class PrintElement
    {
        // members...
        private ArrayList _printPrimitives = new ArrayList();
        private IPrintable _printObject;

        public PrintElement(IPrintable printObject)  //  constructor
        {
            _printObject = printObject;
        }

        
        public void Print()
        {
            // now, show the print dialog...
            PrintDialog dialog = new PrintDialog();
            //   dialog.Document = this;

            // show the dialog...
            dialog.ShowDialog();
        }

        // AddText - add text to the element...
        public void AddText(String buf)
        {
            // add the text...
            AddPrimitive(new PrintPrimitiveText(buf));
        }

        public void AddImage(String bmpPath)
        {
            // add this image to the collection... 
            AddPrimitive(new PrintPrimitiveImage(bmpPath));

        }

        // AddPrimitive - add a primitive to the list...
        public void AddPrimitive(IPrintPrimitive primitive)
        {
            // add it...
            _printPrimitives.Add(primitive);
        }
        // AddData - add data to the element... 
        public void AddData(String dataName, String dataValue)
        {
            // add this data to the collection... 
            AddText(dataName + ": " + dataValue);
        }

        // AddHorizontalRule - add a rule to the element... 
        public void AddHorizontalRule()
        {
            // add a rule object... 
            AddPrimitive(new PrintPrimitiveRule());
        }

        // AddBlankLine - add a blank line... 
        public void AddBlankLine()
        {
            // add a blank line... 
            AddText("");
        }

        // AddHeader - add a header... 
        public void AddHeader(String buf)
        {
            AddText(buf);
            AddHorizontalRule();
        }

        public float CalculateHeight(PrintEngine engine, Graphics graphics)
        {
            // loop through the print height...
            float height = 0;
            foreach (IPrintPrimitive primitive in _printPrimitives)
            {
                // get the height...
                height += primitive.CalculateHeight(engine, graphics);
            }

            // return the height...
            return height;
        }

        // Draw - draw the element on a graphics object...
        public void Draw(PrintEngine engine, float yPos, Graphics graphics, Rectangle pageBounds)
        {
            // where...
            float height = CalculateHeight(engine, graphics);
            Rectangle elementBounds = new Rectangle(pageBounds.Left, (int)yPos, pageBounds.Right - pageBounds.Left, (int)height);

            // now, tell the primitives to print themselves...
            foreach (IPrintPrimitive primitive in _printPrimitives)
            {
                // render it...
                primitive.Draw(engine, yPos, graphics, elementBounds);

                // move to the next line...
                yPos += primitive.CalculateHeight(engine, graphics);
            }
        }
    }
}
