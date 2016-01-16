using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Norka.Zeichnen
{
    public class Customer : IPrintable
    {
        // members... 
        public int Id;
        public String FirstName;
        public String LastName;
        public String Company;
        public String Email;
        public String Phone;



        public void Print(PrintElement element)
        {
            // tell the engine to draw a header... 
            element.AddHeader("Customer");

            // now, draw the data... 
            element.AddData("Customer ID", Id.ToString());
            element.AddData("Name", FirstName + " " + LastName);
            element.AddData("Company", Company);
            element.AddData("E-mail", Email);
            element.AddData("Phone", Phone);

            // finally, add a blank line... 
            element.AddBlankLine(); 
            
        }

        
    }
}
