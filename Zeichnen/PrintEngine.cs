using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Norka.Zeichnen
{
    public class PrintEngine : PrintDocument
    {
        // members...
        private ArrayList _printObjects = new ArrayList();
        
        // The PrintFont and PrintBrush will be used to define the font and brush that will be used to do the printing.
        public Font PrintFont = new Font("Arial", 10);
        public Brush PrintBrush = Brushes.Black;
        
        // The Header and Footer describe elements that contain the header and footer 
        // for each page. _printElements describes a list of all the elements, except Header and Footer. _printIndex keeps 
        // track of the current position in the _printElements list. Finally, _pageNum keeps track of the current page number. 
        public PrintElement Header;
        public PrintElement Footer;
        
        private ArrayList _printElements;
        private int _printIndex = 0;
        private int _pageNum = 0;        

         
        // The first thing to do before we try to print is build up the header and footer elements. We'll create default ones in the constructor: 
        public PrintEngine()
        {
            // create the header...
            Header = new PrintElement(null);
            Header.AddText("Report");
            Header.AddText("Page: [pagenum]");
            Header.AddHorizontalRule();
            Header.AddBlankLine();

            // create the footer...
            Footer = new PrintElement(null);
            Footer.AddBlankLine();
            Footer.AddHorizontalRule();
            Footer.AddText("Confidential");
        }

        // AddPrintObject - add a print object the document...
        public void AddPrintObject(IPrintable printObject)
        {
            _printObjects.Add(printObject);
        }

        // The printing routines have a fairly curious way of working, which I mentioned right at the beginning involved firing events to signal when a page needs to be printed.
        // The first event that gets fired is BeginPrint, but as PrintEngine is inherited from PrintDocument the best way to get at this is to override OnBeginPrint. 
        // This is, I'm told, similar to the way that the printing routines in MFC worked. 
        
        // OnBeginPrint - called when printing starts
        protected override void OnBeginPrint(PrintEventArgs e)
        {
            // reset...
            _printElements = new ArrayList();
            _pageNum = 0;
            _printIndex = 0;

            // go through the objects in the list and create print elements for each one...
            foreach (IPrintable printObject in _printObjects)
            {
                // create an element...
                PrintElement element = new PrintElement(printObject);
                _printElements.Add(element);

                // tell it to print...
                printObject.Print(element);
               
            }
        }

        // As we work through the list we create a new PrintElement object for each IPrintable -supporting object that we have. 
        // We then ask each element to print itself through the Print method. 
        // At this time, the element will call into IPrintable.Print and the underlying class will tall the various AddText, AddHeader, AddHorizontalRule methods to build up the primitives. 

        // Once we've done that, we can turn our attention to the printing mechanism. This is done through OnPrintPage. Add this code: 
        
        // OnPrintPage - called when printing needs to be done...
        protected override void OnPrintPage(PrintPageEventArgs e)
        {

            _pageNum++;  // adjust the page number...

            //he first thing we do is increment the page number. In OnBeginPrint we set this to 0, meaning that on the first page it will be 1. We then want to draw the header element. This will always appear in the top-left hand corner of each page. 

            // The PrintPageEventArgs contains members that tell us everything we need to know about printing. 
            // MarginBounds describes a rectangle containing the printable area of the page. 
            // Graphics contains a System.Graphics.Drawing object that contains the methods necessary for drawing on the screen or printer. We pass both of these into the header element: 


            // now, render the header element...
            float headerHeight = Header.CalculateHeight(this, e.Graphics);
            Header.Draw(this, e.MarginBounds.Top, e.Graphics, e.MarginBounds);

            // also, we need to calculate the footer height...
            float footerHeight = Footer.CalculateHeight(this, e.Graphics);
            Footer.Draw(this, e.MarginBounds.Bottom - footerHeight, e.Graphics, e.MarginBounds);

            // Once we've done that, we need to calculate the area of the page that's left. This will contain the elements, or rather as many elements as will fit onto the page. 
            // now we know the header and footer, we can adjust the page bounds...
            Rectangle pageBounds = new Rectangle(e.MarginBounds.Left, (int)(e.MarginBounds.Top + headerHeight), e.MarginBounds.Width,
                  (int)(e.MarginBounds.Height - footerHeight - headerHeight));
            float yPos = pageBounds.Top;

            // Right at the end there we define and set yPos to be the top of the printable area given over to elements. We'll see how this moves down the page as we draw elements. 
            // The _printIndex keeps track of which element has to be drawn next. 
            // In OnBeginPage we set this to 0 meaning that the next element we draw will be the first one in _printElements. To loop through the elements, we need to do this:
            // ok, now we need to loop through the elements...
            bool morePages = false;
            int elementsOnPage = 0;
            while (_printIndex < _printElements.Count)
            {
                // get the element...
                PrintElement element = (PrintElement)_printElements[_printIndex];
               
                // Once we have the element, we need to find its height. Taking into consideration the current position of yPos, we want to make sure that the element will fit on the page: 
                
                // how tall is the primitive?
                float height = element.CalculateHeight(this, e.Graphics);

                // will it fit on the page?
                if (yPos + height > pageBounds.Bottom)
                {
                    // we don't want to do this if we're the first thing on the page...
                    if (elementsOnPage != 0)
                    {
                        morePages = true;
                        break;
                    }
                }



                // If the element will not fit on the page, we quit the loop - and we'll see why in a moment. 
                //One important thing tonote here is that if this is the first element on the page (i.e. elementsOnPage = 0), we never want to leave the loop. 
                // If it's the first element and it's the first page, it's too big to fit on any page.
                // Rather than breaking the element up, we'll just render it as it is, meaning that the bottom of the element will draw over the footer. 
                // Providing the element will fit, we can tell the element to draw itself, move yPos down to the position of the next element and adjust printIndex so that it points to the next element in the list: 
                // now draw the element...
                element.Draw(this, yPos, e.Graphics, pageBounds);

                // move the ypos...
                yPos += height;

                // next...
                _printIndex++;
                elementsOnPage++;
            }
            // do we have more pages?
            e.HasMorePages = morePages;
        }


        // ReplaceTokens - take a string and remove any tokens replacing them with values...
        public String ReplaceTokens(String buf)
        {
            // replace...
            buf = buf.Replace("[pagenum]", _pageNum.ToString());

            // return...
            return buf;
        }


        // ShowPreview - show a print preview...
        public void ShowPreview()
        {
            // now, show the print dialog...
            PrintPreviewDialog dialog = new PrintPreviewDialog();
            dialog.Document = this;
            dialog.WindowState = FormWindowState.Maximized;
            // show the dialog...
            dialog.ShowDialog();

        }

    }
}
