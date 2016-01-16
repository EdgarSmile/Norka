using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Norka.DB;
using Norka.Reports;
using Brief = Norka.DB.Brief;
using System.Drawing;

namespace Norka.Kunden
{
  using Func;

  public partial class Form_Brief : Form
  {
    private List<int> kundennr;
    private EReports reportType;
    private ReportDocument report;

    public Form_Brief(EReports preport, List<int> pKundenNr)
    {
      InitializeComponent();
      kundennr = pKundenNr;
      reportType = preport;


      switch (reportType)
      {
        case EReports.Brief:
          tbxBauvorhaben.BackColor = Color.Gray;
          tbxBauvorhaben.Enabled = false;
          this.Text = "Brief";
          break;
        case EReports.AbsageProgramm:
          this.Text = "Absage - Nicht im Programm";
          break;
        case EReports.AbsageWirkungskreis:
          this.Text = "Absage - Außerhalb Wirkungskreis";
          break;
      }
    }

    private void btnEmail_Click(object sender, EventArgs e)
    {
      //this.Cursor = Cursors.WaitCursor;

      String eMail = "";

      using (var dbContext = new DataBaseDataContext())
      {
        try
        {
          // Tabelleninhalt löschen
          dbContext.ExecuteCommand("TRUNCATE TABLE Brief");
          dbContext.SubmitChanges();

          var brief = new Brief
                        {
                          Betreff = tbxBetreff.Text,
                          Text = tbxText.Text,
                          Bauvorhaben = tbxBauvorhaben.Text,
                          ZuHaenden = tbxHaenden.Text,
                          Anrede = cobAnrede.Text
                        };

          dbContext.Brief.InsertOnSubmit(brief);

          dbContext.SubmitChanges();

          var k = dbContext.Kunde.Where(customer => customer.KundeID.Equals(kundennr[0])).FirstOrDefault();

          eMail = k.Email2;

          Func.SendDocumentViaEmail(eMail, "", "", ReportManager.GetExportFilepath(reportType, kundennr[0]));

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
      }
      //this.Cursor = Cursors.Default;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //this.Cursor = Cursors.WaitCursor;

      using (var dbContext = new DataBaseDataContext())
      {
        // Tabelleninhalt löschen
        dbContext.ExecuteCommand("TRUNCATE TABLE Brief");
        dbContext.SubmitChanges();

        var brief = new Brief
                      {
                        Betreff = tbxBetreff.Text,
                        Text = tbxText.Text,
                        Bauvorhaben = tbxBauvorhaben.Text,
                        ZuHaenden = tbxHaenden.Text,
                        Anrede = cobAnrede.Text
                      };



        dbContext.Brief.InsertOnSubmit(brief);

        dbContext.SubmitChanges();

      }

      //Close();
      //Func.FBrief = null;


      switch (reportType)
      {
        case EReports.Brief:
          report = ReportManager.GetReportByNameForSelectedRecord(EReports.Brief, kundennr);
          break;
        case EReports.AbsageProgramm:
          report = ReportManager.GetReportByNameForSelectedRecord(EReports.AbsageProgramm, kundennr);
          break;
        case EReports.AbsageWirkungskreis:
          report = ReportManager.GetReportByNameForSelectedRecord(EReports.AbsageWirkungskreis, kundennr);
          break;
      }


      var r = new Form_Report(report);

      r.Show();
     // r.Refresh();


      // this.Cursor = Cursors.Default;

    }

    private void btnAbbrechen_Click(object sender, EventArgs e)
    {
      Close();
      Func.FBrief = null;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
