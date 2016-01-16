using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Norka.Reports
{

  public partial class Form_Report : Form
  {
   

    #region Kontruktoren

    /// <summary>
    /// Erstellt eine neue Instanz der <see cref="Form_Report"/> Klasse.
    /// </summary>
    public Form_Report()
    {
      InitializeComponent();
    }


    public Form_Report(ReportDocument report )
    {
      InitializeComponent();

      this.Text = "Report " + report.Name;

      crViewer.ReportSource = report;
    }

    #endregion


    




    



  }
}
