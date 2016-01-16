using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Norka.Archiv;


namespace Norka.Cockpit
{
    using Func;
    using DB;
    using Common;


    /// <summary>
    /// 
    /// </summary>
    public partial class Form_Cockpit_Auswahl : Form
    {
        #region Variablen

        private readonly ErrorProvider epAngebotNr;
        private readonly ErrorProvider epAuftragNr;
        private readonly ErrorProvider epKundenNr;
        private readonly ErrorProvider epRechnungNr;

        #endregion


        #region Kontruktoren

        /// <summary>
        /// Initializes a new instance of the <see cref="Form_Archiv_Auswahl"/> class.
        /// </summary>
        public Form_Cockpit_Auswahl()
        {
            InitializeComponent();
            epAngebotNr = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.AlwaysBlink };
            epKundenNr = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.AlwaysBlink };
        }

        #endregion


        #region Methoden


        /// <summary>
        /// Überprüft die Eingabe der Kunden-Nr auf nummerische Werte.
        /// </summary>
        /// <returns>Flag - ob Kunden-Nr nummerisch ist oder nicht</returns>
        private bool ValidateKundenNr()
        {
            bool status = false;

            if (tbxUmsatzProJahrKundeNr.TextLength > 0 & !Func.IsNumeric(tbxUmsatzProJahrKundeNr.Text, true))
            {
                epKundenNr.SetError(tbxUmsatzProJahrKundeNr, "Die Kunden-Nr darf nur nummerische Werte enthalten.");
            }
            else
            {
                epKundenNr.Clear();
                status = true;
            }

            return status;
        }



        #endregion


        #region Events

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Umsatz pro Jahr
            tbxUmsatzProJahrKundeNr.Clear();
            tbxUmsatzProJahrName.Clear();
            cbxUmsatzProJahrJahrVon.SelectedIndex = 0;
            cbxUmsatzProJahrJahrBis.SelectedIndex = 0;

            // Umsatz pro Monat
            tbxUmsatzProMonatKundeNr.Clear();
            tbxUmsatzProMonatName.Clear();
            cbxUmsatzProMonatJahrVon.SelectedIndex = 0;
            cbxUmsatzProMonatJahrBis.SelectedIndex = 0;

            // Angebote, Aufträge und Rechnungen
            tbxAARKundeNr.Clear();
            tbxAARKundeName.Clear();
            cbxAARJahrVon.SelectedIndex = 0;
            cbxAARJahrBis.SelectedIndex = 0;

            // Umsatz pro Jahr und Monat
            cbxUmsatzProJahrMonatJahrVon.SelectedIndex = 0;
            cbxUmsatzProJahrMonatJahrBis.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (pnlNettoUmsatzProJahrKunde.Visible)
            {
                ShowNettoumsatzKundeProJahr();
            }
            else if (pnlAngeboteAufträgeRechnungen.Visible)
            {
                ShowAngeboteAufträgeRechnungen();
            }
            else if (pnlNettoUmsatzProMonatKunde.Visible)
            {
              ShowNettoumsatzKundeJahr();
            }
            else if (pnlNettoUmsatzProJahrMonat.Visible)
            {
              ShowNettoumsatzJahrMonat();
            }


        }

        private void ShowAngeboteAufträgeRechnungen()
        {
         if ((cbxAARJahrVon.SelectedIndex == 0) && (cbxAARJahrBis.SelectedIndex == 0) && (tbxAARKundeNr.Text == String.Empty) && (tbxAARKundeName.Text == String.Empty))
         {
             using (var dbContext = new DataBaseDataContext())
             {
                 Func.FCockpit.dgrResults.Columns.Clear();
                 Func.FCockpit.dgrResults.DataSource =
                   dbContext.VIEW_Angebote_KundeProJahr.Where(x => x.Jahr == dbContext.VIEW_Angebote_KundeProJahr.Max(y => y.Jahr));
             }
         }
         else
         {
             var sb = new StringBuilder("SELECT v.* FROM  VIEW_Angebote_KundeProJahr v WHERE ");

             if (tbxAARKundeNr.Text != String.Empty)
             {
                 sb.AppendFormat("v.KundeID LIKE \'%{0}%\' AND ", tbxAARKundeNr.Text);
             }

             if (tbxAARKundeName.Text != String.Empty)
             {
                 sb.AppendFormat("v.Name_Firma LIKE \'%{0}%\' AND ", tbxAARKundeName.Text);
             }

             if (cbxAARJahrVon.Text != String.Empty)
             {
                 sb.AppendFormat("v.Jahr >= \'{0}\' AND ", cbxAARJahrVon.Text);
             }

             if (cbxAARJahrBis.Text != String.Empty)
             {
                 sb.AppendFormat("v.Jahr <= \'{0}\' AND ", cbxAARJahrBis.Text);
             }


             String s = sb.ToString();

             String j = s.Substring(s.Length - 4, 3);

             if (j == "AND")
             {
                 s = s.Substring(0, s.Length - 5);
             }

             //s += "ORDER BY VIEW_Nettoumsatz_KundeProJahr.AngebotID DESC";


             try
             {
                 using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
                 {
                     var command = new SqlCommand(s, sqlconnection);
                     var adapter = new SqlDataAdapter(command);
                     var table = new DataTable();
                     adapter.Fill(table);
                     Func.FCockpit.dgrResults.Columns.Clear();
                     Func.FCockpit.dgrResults.DataSource = table;
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
         }    
         
        }

        private void ShowNettoumsatzKundeProJahr()
        {
            // Nur die Werte für das aktuelle Jahr werden angezeigt.
            if ((cbxUmsatzProJahrJahrVon.SelectedIndex == 0) && (cbxUmsatzProJahrJahrBis.SelectedIndex == 0) && (tbxUmsatzProJahrKundeNr.Text == String.Empty) && (tbxUmsatzProJahrName.Text == String.Empty))
            {
                using (var dbContext = new DataBaseDataContext())
                {
                    Func.FCockpit.dgrResults.Columns.Clear();
                    Func.FCockpit.dgrResults.DataSource =
                      dbContext.VIEW_Nettoumsatz_KundeProJahr.Where(x => x.Jahr == dbContext.VIEW_Nettoumsatz_KundeProJahr.Max(y => y.Jahr));
                }
            }
            else
            {
                var sb = new StringBuilder("SELECT v.* FROM  VIEW_Nettoumsatz_KundeProJahr v WHERE ");

                if (tbxUmsatzProJahrKundeNr.Text != String.Empty)
                {
                    sb.AppendFormat("v.KundeID LIKE \'%{0}%\' AND ", tbxUmsatzProJahrKundeNr.Text);
                }

                if (tbxUmsatzProJahrName.Text != String.Empty)
                {
                    sb.AppendFormat("v.Name_Firma LIKE \'%{0}%\' AND ", tbxUmsatzProJahrName.Text);
                }

                if (cbxUmsatzProJahrJahrVon.Text != String.Empty)
                {
                    sb.AppendFormat("v.Jahr >= \'{0}\' AND ", cbxUmsatzProJahrJahrVon.Text);
                }

                if (cbxUmsatzProJahrJahrBis.Text != String.Empty)
                {
                    sb.AppendFormat("v.Jahr <= \'{0}\' AND ", cbxUmsatzProJahrJahrBis.Text);
                }


                String s = sb.ToString();

                String j = s.Substring(s.Length - 4, 3);

                if (j == "AND")
                {
                    s = s.Substring(0, s.Length - 5);
                }

                //s += "ORDER BY VIEW_Nettoumsatz_KundeProJahr.AngebotID DESC";


                try
                {
                    using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
                    {
                        var command = new SqlCommand(s, sqlconnection);
                        var adapter = new SqlDataAdapter(command);
                        var table = new DataTable();
                        adapter.Fill(table);
                        Func.FCockpit.dgrResults.Columns.Clear();
                        Func.FCockpit.dgrResults.DataSource = table;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void ShowNettoumsatzKundeJahr()
        {
          // Nur die Werte für das aktuelle Jahr werden angezeigt.
          if ((cbxUmsatzProJahrJahrVon.SelectedIndex == 0) && (cbxUmsatzProJahrJahrBis.SelectedIndex == 0) && (tbxUmsatzProJahrKundeNr.Text == String.Empty) && (tbxUmsatzProJahrName.Text == String.Empty))
          {
            using (var dbContext = new DataBaseDataContext())
            {
              Func.FCockpit.dgrResults.Columns.Clear();
              Func.FCockpit.dgrResults.DataSource =
                dbContext.VIEW_Nettoumsatz_KundeProMonat.Where(x => x.Jahr == dbContext.VIEW_Nettoumsatz_KundeProMonat.Max(y => y.Jahr));
            }
          }
          else
          {
            var sb = new StringBuilder("SELECT v.* FROM  VIEW_Nettoumsatz_KundeProMonat v WHERE ");

            if (tbxUmsatzProJahrKundeNr.Text != String.Empty)
            {
              sb.AppendFormat("v.KundeID LIKE \'%{0}%\' AND ", tbxUmsatzProJahrKundeNr.Text);
            }

            if (tbxUmsatzProJahrName.Text != String.Empty)
            {
              sb.AppendFormat("v.Name_Firma LIKE \'%{0}%\' AND ", tbxUmsatzProJahrName.Text);
            }

            if (cbxUmsatzProJahrJahrVon.Text != String.Empty)
            {
              sb.AppendFormat("v.Jahr >= \'{0}\' AND ", cbxUmsatzProJahrJahrVon.Text);
            }

            if (cbxUmsatzProJahrJahrBis.Text != String.Empty)
            {
              sb.AppendFormat("v.Jahr <= \'{0}\' AND ", cbxUmsatzProJahrJahrBis.Text);
            }


            String s = sb.ToString();

            String j = s.Substring(s.Length - 4, 3);

            if (j == "AND")
            {
              s = s.Substring(0, s.Length - 5);
            }

            //s += "ORDER BY VIEW_Nettoumsatz_KundeProJahr.AngebotID DESC";


            try
            {
              using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
              {
                var command = new SqlCommand(s, sqlconnection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                Func.FCockpit.dgrResults.Columns.Clear();
                Func.FCockpit.dgrResults.DataSource = table;
              }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }

        }

        private void ShowNettoumsatzJahrMonat()
        {
          // Nur die Werte für das aktuelle Jahr werden angezeigt.
          if ((cbxUmsatzProJahrMonatJahrVon.SelectedIndex == 0) && (cbxUmsatzProJahrMonatJahrBis.SelectedIndex == 0))
          {
            using (var dbContext = new DataBaseDataContext())
            {
              Func.FCockpit.dgrResults.Columns.Clear();
              Func.FCockpit.dgrResults.DataSource =
                dbContext.VIEW_Nettoumsatz_JahrMonat.Where(x => x.Jahr == dbContext.VIEW_Nettoumsatz_JahrMonat.Max(y => y.Jahr));
            }
          }
          else
          {
            var sb = new StringBuilder("SELECT v.* FROM  VIEW_Nettoumsatz_JahrMonat v WHERE ");

            if (cbxUmsatzProJahrJahrVon.Text != String.Empty)
            {
              sb.AppendFormat("v.Jahr >= \'{0}\' AND ", cbxUmsatzProJahrJahrVon.Text);
            }

            if (cbxUmsatzProJahrJahrBis.Text != String.Empty)
            {
              sb.AppendFormat("v.Jahr <= \'{0}\' AND ", cbxUmsatzProJahrJahrBis.Text);
            }


            String s = sb.ToString();

            String j = s.Substring(s.Length - 4, 3);

            if (j == "AND")
            {
              s = s.Substring(0, s.Length - 5);
            }

            try
            {
              using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
              {
                var command = new SqlCommand(s, sqlconnection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                Func.FCockpit.dgrResults.Columns.Clear();
                Func.FCockpit.dgrResults.DataSource = table;
              }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }

        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPreview = true;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnOK.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnClear_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPreview = true;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnClear.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void tbxAngKundenNr_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPreview = true;

            if (ValidateKundenNr())
            {
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        btnOK.PerformClick();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void tbxAngName_KeyDown_1(object sender, KeyEventArgs e)
        {
            KeyPreview = true;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnOK.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void tbxAngKundenNr_Validating(object sender, CancelEventArgs e)
        {
            ValidateKundenNr();
        }


        private void tbxAngKundenNr_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                tbxUmsatzProJahrKundeNr.SelectAll();
            });
        }

        private void tbxAngName_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate()
            {
                tbxUmsatzProJahrName.SelectAll();
            });
        }


        #endregion

        private void Form_Cockpit_Auswahl_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dsYears.AARJahrBis". Sie können sie bei Bedarf verschieben oder entfernen.
            this.aARJahrBisTableAdapter.Fill(this.dsYears.AARJahrBis);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dsYears.AARJahrVon". Sie können sie bei Bedarf verschieben oder entfernen.
            this.aARJahrVonTableAdapter.Fill(this.dsYears.AARJahrVon);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dsYears.UmsatzJahrBis". Sie können sie bei Bedarf verschieben oder entfernen.
            this.umsatzJahrBisTableAdapter.Fill(this.dsYears.UmsatzJahrBis);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "dsYears.UmsatzJahrVon". Sie können sie bei Bedarf verschieben oder entfernen.
            this.umsatzJahrVonTableAdapter.Fill(this.dsYears.UmsatzJahrVon);


        }


    }
}
