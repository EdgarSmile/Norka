using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Norka.Zeichnen
{

  public partial class Form_Report_Zeichnen : Form
  {
   

    #region Kontruktoren

    /// <summary>
      /// Erstellt eine neue Instanz der <see cref="Form_Report_Zeichnen"/> Klasse.
    /// </summary>
    public Form_Report_Zeichnen()
    {
      InitializeComponent();
    }


    public Form_Report_Zeichnen(ReportDocument report)
    {
      InitializeComponent();

      this.Text = "Report " + report.Name;

      crViewer.ReportSource = report;
    }

    #endregion


    




    



  }
}
