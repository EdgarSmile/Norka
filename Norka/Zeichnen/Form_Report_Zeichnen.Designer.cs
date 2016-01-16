

namespace Norka.Zeichnen
{
    partial class Form_Report_Zeichnen
    {
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Report_Zeichnen));
          this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
          this.SuspendLayout();
          // 
          // crViewer
          // 
          this.crViewer.ActiveViewIndex = -1;
          this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.crViewer.DisplayGroupTree = false;
          this.crViewer.Dock = System.Windows.Forms.DockStyle.Fill;
          this.crViewer.Location = new System.Drawing.Point(0, 0);
          this.crViewer.Name = "crViewer";
          this.crViewer.SelectionFormula = "";
          this.crViewer.ShowRefreshButton = false;
          this.crViewer.Size = new System.Drawing.Size(1048, 743);
          this.crViewer.TabIndex = 2;
          this.crViewer.ViewTimeSelectionFormula = "";
          // 
          // Form_Report
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(1048, 743);
          this.Controls.Add(this.crViewer);
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.Name = "Form_Report";
          this.Text = "Report";
          this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}