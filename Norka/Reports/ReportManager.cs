﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Norka.DB;
using System.Linq;

namespace Norka.Reports
{

    ///<summary>
    ///</summary>
    public static class ReportManager
    {
        private const String DefaultFilepath = "c:\\";



        /// <summary>
        /// Liefert den gewählten Report für die übergenen Datensätze.
        /// </summary>
        /// <param name="reportname">Der Name des gewählten Reports.</param>
        /// <param name="records">Auflistung der übergebenen Daten.</param>
        /// <returns></returns>
        public static ReportDocument GetReportByNameForSelectedRecord(EReports reportname, List<int> records)
        {
            ReportDocument report = null;
            try
            {
                report = GetReportByName(reportname);

                report.SetParameterValue("Param" + reportname + "ID", records.ToArray());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return report;
        }

        /// <summary>
        /// Liefert den gewählten Report für die übergenen Datensätze.
        /// </summary>
        /// <param name="reportname">Der Name des gewählten Reports.</param>
        /// <param name="records">Auflistung der übergebenen Daten.</param>
        /// <returns></returns>
        public static ReportDocument GetReportByNameForSelectedRecord(EReports reportname, List<int> records, List<int> posIDs)
        {
            ReportDocument report = null;
            try
            {
                report = GetReportByName(reportname);

                report.SetParameterValue("Param" + reportname + "ID", records.ToArray());
                report.SetParameterValue("Param" + reportname + "PosID", posIDs.ToArray());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return report;
        }


        #region Sonstiges

        /// <summary>
        /// Liefert ein Reportobjekt entsprechend dem übergebenen Reportnamen.
        /// </summary>
        /// <param name="reportname">Der Name des gewählten Reports.</param>
        /// <returns>Das entsprechende Report-Objekt</returns>
        public static ReportDocument GetReportByName(EReports reportname)
        {
            //Leere ReportDocument Objekt. Wird später mit dem gewählten Report "befüllt".
            var report = new ReportDocument();

            using (var dbContext = new DataBaseDataContext())
            {
                var reportPath = dbContext.Reports.Where(rp => rp.Name.Equals(reportname)).FirstOrDefault();
                report.Load(reportPath.Pfad);
            }

            return report;

        }

        /// <summary>
        /// Liefert den Dateipfad des exportierten Reports.
        /// </summary>
        /// <param name="reportname">Der Name des gewählten Reports.</param>
        /// <param name="recordId">ID des Datensatzes, für den der Exportdateipfad ermittelt werden soll.</param>
        /// <returns>Export-Dateipfad des übergebenen Reports.</returns>
        public static String GetExportFilepath(EReports reportname, int recordId)
        {
            ReportDocument report = null;

            report = GetReportByName(reportname);

            report.SetParameterValue("Param" + reportname + "ID", recordId);

            var crExportOptions = report.ExportOptions;
            var crDiskFileDestinationOptions = new DiskFileDestinationOptions();
            var crFormatTypeOptions = new PdfRtfWordFormatOptions();
            String exportFilePath = DefaultFilepath + reportname.ToString() + " " + recordId.ToString() + ".pdf";
            crDiskFileDestinationOptions.DiskFileName = exportFilePath;

            crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            crExportOptions.DestinationOptions = crDiskFileDestinationOptions;
            crExportOptions.FormatOptions = crFormatTypeOptions;

            report.Export();

            return exportFilePath;
        }

        /// <summary>
        /// Liefert den Dateipfad des exportierten Reports.
        /// </summary>
        /// <param name="reportname">Der Name des gewählten Reports.</param>
        /// <param name="recordId">ID des Datensatzes, für den der Exportdateipfad ermittelt werden soll.</param>
        /// <returns>Export-Dateipfad des übergebenen Reports.</returns>
        public static String GetExportFilepath(EReports reportname, int recordId, List<int> posIDs)
        {
            ReportDocument report = null;

            report = GetReportByName(reportname);

            report.SetParameterValue("Param" + reportname + "ID", recordId);
            report.SetParameterValue("Param" + reportname + "PosID", posIDs.ToArray());

            var crExportOptions = report.ExportOptions;
            var crDiskFileDestinationOptions = new DiskFileDestinationOptions();
            var crFormatTypeOptions = new PdfRtfWordFormatOptions();
            String exportFilePath = DefaultFilepath + reportname.ToString() + " " + recordId.ToString() + ".pdf";
            crDiskFileDestinationOptions.DiskFileName = exportFilePath;

            crExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            crExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
            crExportOptions.DestinationOptions = crDiskFileDestinationOptions;
            crExportOptions.FormatOptions = crFormatTypeOptions;

            report.Export();

            return exportFilePath;
        }

        #endregion
    }
}
