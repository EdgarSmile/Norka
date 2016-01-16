using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Norka.Zeichnen
{
    public class ListContents : IPrintable
    {
        // members...
        public String bookNumber;
        public String title;
        public String ISBN;
        public String location;
        public String price;
        public String status;



        public void Print(PrintElement element)
        {
            // tell the engine to draw a header...
            element.AddHeader("Contents of List");

            // now, draw the data...
            element.AddData("Book Nbr", bookNumber);
            element.AddData("Title", title);
            element.AddData("ISBN", ISBN);
            element.AddData("Location", location);
            element.AddData("Price", price);
            element.AddData("Status", status);

            // finally, add a blank line...
            element.AddBlankLine();
        }
    }
}
