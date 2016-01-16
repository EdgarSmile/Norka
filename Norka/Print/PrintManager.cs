using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Norka.Reports;

namespace Norka.Print
{
  public static class PrintManager
  {

    public static bool PrintMahnung(EReports reportname, int type, List<int> records)
    {
      bool result = false;

      // Create Printdocument
      var printDocument = new PrintDocument();

      var printDialog = new PrintDialog();

      printDialog.Document = printDocument;
      printDialog.UseEXDialog = true;

      var dialogResult = printDialog.ShowDialog();

      if (dialogResult == DialogResult.OK)
      {

        short copies = printDocument.PrinterSettings.Copies;

        int fromPage = printDocument.PrinterSettings.FromPage;

        int toPage = printDocument.PrinterSettings.ToPage;

        string printerName = printDocument.PrinterSettings.PrinterName;

        var report = ReportManager.GetReportByNameForSelectedRecord(reportname, records);

        report.SetParameterValue("Type", type);
        try
        {
          report.PrintOptions.PrinterName = printerName;

          report.PrintToPrinter(copies, false, fromPage, toPage);

          result = true;
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }

      return result;
    }

    public static void PrintDirectlyWithDialog(EReports reportname,List<int> records)
    {
      // Create Printdocument
      var printDocument = new PrintDocument();

      var printDialog = new PrintDialog();

      printDialog.Document = printDocument;
      printDialog.UseEXDialog = true;

      var dialogResult = printDialog.ShowDialog();

      if (dialogResult == DialogResult.OK)
      {

        short copies = printDocument.PrinterSettings.Copies;

        int fromPage = printDocument.PrinterSettings.FromPage;

        int toPage = printDocument.PrinterSettings.ToPage;

        string printerName = printDocument.PrinterSettings.PrinterName;

        var report = ReportManager.GetReportByNameForSelectedRecord(reportname, records);

        try
        {
          report.PrintOptions.PrinterName = printerName;

          report.PrintToPrinter(copies, false, fromPage, toPage);

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
    }

    public static void PrintDirectlyWithDialog(EReports reportname, List<int> records, List<int> posIDs)
    {
      // Create Printdocument
      var printDocument = new PrintDocument();

      var printDialog = new PrintDialog();

      printDialog.Document = printDocument;
      printDialog.UseEXDialog = true;

      var dialogResult = printDialog.ShowDialog();

      if (dialogResult == DialogResult.OK)
      {

        short copies = printDocument.PrinterSettings.Copies;

        int fromPage = printDocument.PrinterSettings.FromPage;

        int toPage = printDocument.PrinterSettings.ToPage;

        string printerName = printDocument.PrinterSettings.PrinterName;

        var report = ReportManager.GetReportByNameForSelectedRecord(reportname, records, posIDs);

        try
        {
          report.PrintOptions.PrinterName = printerName;

          report.PrintToPrinter(copies, false, fromPage, toPage);

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
    }

    public static void PrintWithPreview()
    {
     
    }

    public static void Fax(EReports reportname, List<int> records)
    {
      //Zu druckender Report wird geladen.
      var report = ReportManager.GetReportByNameForSelectedRecord(reportname, records);

      //Auswahl des Faxdruckers
      report.PrintOptions.PrinterName = "WinFax";

      report.PrintToPrinter(1, false, 1, 100);
    }

    public static void Fax(EReports reportname, List<int> records, List<int> posIDs)
    {
      //Zu druckender Report wird geladen.
      var report = ReportManager.GetReportByNameForSelectedRecord(reportname, records, posIDs);

      //Auswahl des Faxdruckers
      report.PrintOptions.PrinterName = "WinFax";

      report.PrintToPrinter(1, false, 1, 100);
    }


  }

}
