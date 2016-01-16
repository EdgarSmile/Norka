using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Norka.Rechnungen;


namespace Norka.Cockpit
{
    using System.Collections.Generic;
    using System.Linq;
    using Angebote;
    using Func;
    using DB;
    using Reports;
    using Aufträge;

    /// <summary>
    /// 
    /// </summary>
    public partial class Form_Cockpit : Form
    {
        #region Variablen


        #endregion


        #region Kontruktoren

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="Form_Cockpit"/> Klasse.
        /// </summary>
        public Form_Cockpit()
        {
            InitializeComponent();
        }

        #endregion


        #region Methoden


        #endregion


        #region Events


        private void Form_Cockpit_Load(object sender, EventArgs e)
        {
            trvKategorie.ExpandAll();
        }



        private void itemCockpitSch_Click(object sender, EventArgs e)
        {
            this.Close();
            Func.FCockpit = null;
        }



        private void dgrKunden_MouseDown(object sender, MouseEventArgs e)
        {
            // Zeilenmarkierung bei Rechtsklick ermöglichen.
            DataGridView.HitTestInfo hti = dgrResults.HitTest(e.X, e.Y);

            if (hti.Type == DataGridViewHitTestType.Cell)
            {
                dgrResults.CurrentCell = dgrResults[hti.ColumnIndex, hti.RowIndex];
            }
        }

        private void dgrResults_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            itemDrucken.Enabled = Func.GetDataGridViewRowCount(dgrResults) == 0 ? false : true;
        }

        private void dgrResults_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            itemDrucken.Enabled = Func.GetDataGridViewRowCount(dgrResults) == 0 ? false : true;
        }

        private void trvKategorie_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name)
            {
                case "NettoUmsatzProJahrKunde":
                    using (var f = new Form_Cockpit_Auswahl())
                    {
                        f.Text = e.Node.Parent.Text + ' ' + e.Node.Text;
                        f.Controls[string.Format("pnl{0}", e.Node.Name)].Visible = true;
                        f.ShowDialog();
                    }
                    break;
                case "AngeboteAufträgeRechnungen":
                    using (var f = new Form_Cockpit_Auswahl())
                    {
                        f.Text = e.Node.Parent.Text + ' ' + e.Node.Text;
                        f.Controls[string.Format("pnl{0}", e.Node.Name)].Visible = true;
                        f.ShowDialog();
                    }

                    break;
                case "NettoUmsatzProMonatKunde":
                    using (var f = new Form_Cockpit_Auswahl())
                    {
                      f.Text = e.Node.Parent.Text + ' ' + e.Node.Text;
                      f.Controls[string.Format("pnl{0}", e.Node.Name)].Visible = true;
                      f.ShowDialog();
                    }
                    break;
                case "NettoUmsatzProJahrMonat":
                    using (var f = new Form_Cockpit_Auswahl())
                    {
                      f.Text = e.Node.Parent.Text + ' ' + e.Node.Text;
                      f.Controls[string.Format("pnl{0}", e.Node.Name)].Visible = true;
                      f.ShowDialog();
                    }
                    break;
                case "NettoUmsatzProJahrMonatVergangenheit":
                    using (var dbContext = new DataBaseDataContext())
                    {
                      Func.FCockpit.dgrResults.Columns.Clear();
                      Func.FCockpit.dgrResults.DataSource =
                        dbContext.VIEW_Nettoumsatz_JahrMonat_Vergangenheits;
                    }
                    break;
                
            }
        }

        private void ctmCockpitGrid_Opened(object sender, EventArgs e)
        {
            itemDrucken.Enabled = Func.GetDataGridViewRowCount(dgrResults) == 0 ? false : true;
        }

        #endregion














    }
}