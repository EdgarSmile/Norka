#region Usings

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Norka.Properties;
using System.Data.Linq;
using System.Linq;
using Norka.DB;
using Norka.Func;
#endregion


namespace Norka.Kunden
{
    using Func;
    using log4net;
    public partial class Form_Kunde : Form
    {
        private ErrorProvider epNameFirma;
        private ErrorProvider epStrasse;
        private ErrorProvider epLand;
        private ErrorProvider epPLZ;
        private ErrorProvider epOrt;
        private ErrorProvider epVorname;
        private ErrorProvider epEmail1;
        private ErrorProvider epEmail2;
        private AutoCompleteStringCollection plzCollection;
        private AutoCompleteStringCollection straﬂeCollection;
        private AutoCompleteStringCollection ortCollection;

        private Boolean IsDefault = false;

        // ****************************************************************************
        // Konstruktoren
        // ****************************************************************************
        /// <summary>
        /// Initializes a new instance of the <see cref="Form_Kunde"/> class.
        /// Wird aufgerufen, wenn eine neuer Kunde angelegt wird.
        /// </summary>
        public Form_Kunde()
        {
            InitializeComponent();

            epNameFirma = new ErrorProvider();
            epStrasse = new ErrorProvider();
            epLand = new ErrorProvider();
            epPLZ = new ErrorProvider();
            epOrt = new ErrorProvider();
            epVorname = new ErrorProvider();
            //epEmail1 = new ErrorProvider();
            epEmail2 = new ErrorProvider();

            epNameFirma.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epStrasse.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epLand.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epPLZ.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epOrt.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epVorname.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            //epEmail1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epEmail2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            cbxAnrede.SelectedIndex = 0;
            tbxVorname.BackColor = Func.CDisabled;

            tbxLand.Text = "DE";

            // Bei der Neuanlage von Kunden ist das Speichern von ƒnderungen noch nicht notwendig.
            if (tbxKundennummer.Text != "")
            {
                btnAenderungSp.Enabled = true;
                btnSpeicherSchlieﬂen.Enabled = true;
            }

            plzCollection = new AutoCompleteStringCollection();
            straﬂeCollection = new AutoCompleteStringCollection();
            ortCollection = new AutoCompleteStringCollection();

            fillAutoCompleteSourcePlz();
            fillAutoCompleteSourceStraﬂe();
            fillAutoCompleteSourceOrt();
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Form_Kunde"/> class.
        /// Wird aufgerufen, wenn ein bestehender Kunde bearbeitet wird.
        /// </summary>
        /// <param name="p_Kunde">The p_ kunde.</param>
        public Form_Kunde(Kunde p_Kunde)
        {
            InitializeComponent();

            tbxKundennummer.Text = p_Kunde.KundeID.ToString();
            cbxAnrede.Text = p_Kunde.Anrede;
            tbxVorname.Text = p_Kunde.Vorname;
            tbxNameFirma.Text = p_Kunde.Name_Firma;
            tbxStrasse.Text = p_Kunde.Straﬂe;
            tbxZusatz1.Text = p_Kunde.AdressZusatz1;
            tbxZusatz2.Text = p_Kunde.AdressZusatz2;
            tbxPLZL.Text = p_Kunde.PLZ;
            tbxLand.Text = p_Kunde.Land;
            tbxOrt.Text = p_Kunde.Ort;
            // tbxTelefon1.Text = p_Kunde.Telefon1;
            tbxTelefon2.Text = p_Kunde.Telefon2;
            //  tbxFax1.Text = p_Kunde.Fax1;
            tbxFax2.Text = p_Kunde.Fax2;
            tbxMobil.Text = p_Kunde.Mobil;
            // tbxEmail1.Text = p_Kunde.Email1;
            tbxEmail2.Text = p_Kunde.Email2;
            tbxHomepage.Text = p_Kunde.Homepage;
            tbxMatchcode.Text = p_Kunde.Matchcode;

            switch (p_Kunde.Kategorie)
            {
                case "Kunde":
                    cmbKunde.Checked = true;
                    break;
                case "Privat":
                    cmbPrivat.Checked = true;
                    break;
                case "Verein":
                    cmbVerein.Checked = true;
                    break;
            }

            if (p_Kunde.Status != null)
            {
                cbxSperren.Checked = true;
            }

            tbxNotiz.Text = p_Kunde.Notiz;

            epNameFirma = new ErrorProvider();
            epStrasse = new ErrorProvider();
            epLand = new ErrorProvider();
            epPLZ = new ErrorProvider();
            epOrt = new ErrorProvider();
            epVorname = new ErrorProvider();
            //epEmail1 = new ErrorProvider();
            epEmail2 = new ErrorProvider();

            epNameFirma.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epStrasse.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epLand.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epPLZ.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epOrt.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epVorname.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            // epEmail1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            epEmail2.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            btnAenderungSp.Enabled = true;
            btnSpeicherSchlieﬂen.Enabled = true;

            plzCollection = new AutoCompleteStringCollection();
            straﬂeCollection = new AutoCompleteStringCollection();
            ortCollection = new AutoCompleteStringCollection();

            fillAutoCompleteSourcePlz();
            fillAutoCompleteSourceStraﬂe();
            fillAutoCompleteSourceOrt();
        }




        // **************************
        // Methoden
        // **************************

        /// <summary>Lˆscht alle gesetzten Werte der Eingabe-Controls der Form "Kunde".
        /// </summary>
        private void clearEingabefelderKunde()
        {
            cbxAnrede.SelectedIndex = 0;
            tbxKundennummer.Text = "";
            tbxVorname.Text = "";
            tbxNameFirma.Text = "";
            tbxStrasse.Text = "";
            tbxZusatz1.Text = "";
            tbxZusatz2.Text = "";
            tbxPLZL.Text = "";
            tbxLand.Text = "DE";
            tbxOrt.Text = "";
            // tbxTelefon1.Text = "";
            tbxTelefon2.Text = "";
            // tbxFax1.Text = "";
            tbxFax2.Text = "";
            tbxMobil.Text = "";
            // tbxEmail1.Text = "";
            tbxEmail2.Text = "";
            tbxHomepage.Text = "";
            tbxMatchcode.Text = "";
            tbxNotiz.Text = "";
            cmbKunde.Checked = true;
            cmbVerein.Checked = false;
            cmbPrivat.Checked = false;
            cbxSperren.Checked = false;
            cbxOutlookKontakt.Checked = false;
        }


        private int checkKundeDublette(Kunde kunde)
        {
            int result = 0;

            try
            {
                using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
                {
                    var command = new SqlCommand(string.Format("SELECT KundeID, Anrede, Vorname, Name_Firma, Straﬂe, AdressZusatz1, AdressZusatz2, PLZ, Ort, Land FROM Kunde WHERE plz = \'{0}\' and ort = \'{1}\' and straﬂe = \'{2}\'", kunde.PLZ, kunde.Ort, kunde.Straﬂe), sqlconnection);
                    var adapter = new SqlDataAdapter(command);
                    var table = new DataTable();

                    if (adapter.Fill(table) > 0)
                    {
                        Func.FKundeDubletten = new Form_Kunde_Dubletten();
                        Func.FKundeDubletten.dgrKundeDubletten.DataSource = table;

                        if (Func.FKundeDubletten.ShowDialog() == DialogResult.Yes)
                        {
                            result = 1;
                        }

                    }
                    else
                    {
                        result = 1;
                    }
                    //Func.FKundeDubletten.dgrKundeDubletten.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            return result;
            //Func.FUebersicht.tsItemAkualisieren.PerformClick();
        }

        private void fillAutoCompleteSourcePlz()
        {
            SqlDataReader dReader = null;

            try
            {
                using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlconnection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "Select distinct plz from kunde order by plz asc";
                    sqlconnection.Open();
                    dReader = cmd.ExecuteReader();
                    if (dReader.HasRows)
                    {
                        while (dReader.Read())
                        {
                            plzCollection.Add(dReader["plz"].ToString());
                        }
                    }
                }

                tbxPLZL.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbxPLZL.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbxPLZL.AutoCompleteCustomSource = plzCollection;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dReader.Close();
            }


        }

        private void fillAutoCompleteSourceStraﬂe()
        {
            SqlDataReader dReader = null;

            try
            {
                using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlconnection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "Select distinct straﬂe from kunde order by straﬂe asc";
                    sqlconnection.Open();
                    dReader = cmd.ExecuteReader();
                    if (dReader.HasRows)
                    {
                        while (dReader.Read())
                        {
                            straﬂeCollection.Add(dReader["straﬂe"].ToString());
                        }
                    }
                }

                tbxStrasse.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbxStrasse.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbxStrasse.AutoCompleteCustomSource = straﬂeCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dReader.Close();
            }


        }

        private void fillAutoCompleteSourceOrt()
        {
            SqlDataReader dReader = null;

            try
            {
                using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlconnection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText =
                        "Select distinct ort from kunde order by ort asc";
                    sqlconnection.Open();
                    dReader = cmd.ExecuteReader();
                    if (dReader.HasRows)
                    {
                        while (dReader.Read())
                        {
                            ortCollection.Add(dReader["ort"].ToString());
                        }
                    }
                }

                tbxOrt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbxOrt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbxOrt.AutoCompleteCustomSource = ortCollection;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                dReader.Close();
            }


        }

        #region validate Muss-Felder
        private bool validateNameFirma()
        {
            bool _status = false;

            if (tbxNameFirma.Text == "")
            {
                epNameFirma.SetError(tbxNameFirma,
                                     "Dieses Feld darf nicht leer sein! \nBitte geben Sie einen Namen/Firma ein.");
            }
            else
            {
                epNameFirma.Clear();
                _status = true;
            }

            return _status;
        }

        private bool validateStrasse()
        {
            bool _status = false;

            if (tbxStrasse.Text == "")
            {
                epStrasse.SetError(tbxStrasse,
                                   "Dieses Feld darf nicht leer sein! \nBitte geben Sie eine Straﬂe ein ein.");
            }
            else
            {
                epStrasse.Clear();
                _status = true;
            }

            return _status;
        }

        private bool validateLand()
        {
            bool _status = false;

            if (tbxLand.Text == "")
            {
                epLand.SetError(tbxLand, "Dieses Feld darf nicht leer sein! \nBitte geben Sie ein Land ein.");
            }
            else
            {
                epLand.Clear();
                _status = true;
            }

            return _status;
        }

        private bool validatePLZ()
        {
            bool _status = false;

            if (tbxPLZL.Text == "")
            {
                epPLZ.SetError(tbxPLZL, "Dieses Feld darf nicht leer sein! \nBitte geben Sie eine PLZ ein.");
            }
            else
            {
                epPLZ.Clear();
                _status = true;
            }

            return _status;
        }

        private bool validateOrt()
        {
            bool _status = false;

            if (tbxOrt.Text == "")
            {
                epOrt.SetError(tbxOrt, "Dieses Feld darf nicht leer sein! \nBitte geben Sie einen Ort ein.");
            }
            else
            {
                epOrt.Clear();
                _status = true;
            }

            return _status;
        }

        private bool validateVorname()
        {
            bool _status = false;

            if (cbxAnrede.SelectedIndex == 2 || cbxAnrede.SelectedIndex == 3)
            {
                if (tbxVorname.TextLength < 1)
                {
                    epVorname.SetError(tbxVorname, "Dieses Feld darf nicht leer sein! \nBitte geben Sie einen Vornamen ein.");
                }
                else
                {
                    epVorname.Clear();
                    _status = true;
                }
            }
            else
            {
                epVorname.Clear();
                _status = true;
            }

            return _status;
        }



        //private bool validateEmail1()
        //{
        //  bool _status = false;

        //  if (!tbxEmail1.Text.Equals(""))
        //  {
        //    if (!Func.IsEmail(tbxEmail1.Text))
        //    {
        //      epEmail1.SetError(tbxEmail1, "Bitte geben Sie eine g¸ltige Email-Adresse ein.");
        //    }
        //    else
        //    {
        //      epEmail1.Clear();
        //      _status = true;
        //    }
        //  }
        //  else
        //  {
        //    epEmail1.Clear();
        //    _status = true;
        //  }

        //  return _status;
        //}

        private bool validateEmail2()
        {
            bool _status = false;

            if (!tbxEmail2.Text.Equals(""))
            {
                if (!Func.IsEmail(tbxEmail2.Text))
                {
                    epEmail2.SetError(tbxEmail2, "Bitte geben Sie eine g¸ltige Email-Adresse ein.");
                }
                else
                {
                    epEmail2.Clear();
                    _status = true;
                }
            }
            else
            {
                epEmail2.Clear();
                _status = true;
            }

            return _status;
        }

        private bool validateEingabe()
        {
            bool _status = false;

            if (validateNameFirma() & validateStrasse() & validateLand() & validatePLZ() & validateOrt() & validateVorname() &
                /*validateEmail1() &*/ validateEmail2())
            {
                _status = true;
            }
            return _status;
        }
        # endregion


        // **************************
        // Events
        // **************************

        private void btnKundeAnl_Click(object sender, EventArgs e)
        {


            int lastKundeId = 0;

            if (validateEingabe())
            {

                using (DataBaseDataContext dbContext = new DataBaseDataContext())
                {
                    try
                    {
                        Kunde k = new Kunde
                                  {
                                      Anrede = cbxAnrede.Text == "" ? null : cbxAnrede.Text,
                                      Name_Firma = tbxNameFirma.Text == "" ? null : tbxNameFirma.Text,
                                      Straﬂe = tbxStrasse.Text == "" ? null : tbxStrasse.Text,
                                      PLZ = tbxPLZL.Text == "" ? null : tbxPLZL.Text,
                                      Land = tbxLand.Text == "" ? null : tbxLand.Text,
                                      Ort = tbxOrt.Text == "" ? null : tbxOrt.Text,
                                      Vorname = tbxVorname.Text == "" ? null : tbxVorname.Text,
                                      AdressZusatz1 = tbxZusatz1.Text == "" ? null : tbxZusatz1.Text,
                                      AdressZusatz2 = tbxZusatz2.Text == "" ? null : tbxZusatz2.Text,
                                      Telefon1 = null,//tbxTelefon1.Text =="" ? null : tbxTelefon1.Text,
                                      Telefon2 = tbxTelefon2.Text == "" ? null : tbxTelefon2.Text,
                                      Fax1 = null,//tbxFax1.Text == "" ? null : tbxFax1.Text,
                                      Fax2 = tbxFax2.Text == "" ? null : tbxFax2.Text,
                                      Mobil = tbxMobil.Text == "" ? null : tbxMobil.Text,
                                      Email1 = null,//tbxEmail1.Text == "" ? null : tbxEmail1.Text,
                                      Email2 = tbxEmail2.Text == "" ? null : tbxEmail2.Text,
                                      Homepage = tbxHomepage.Text == "" ? null : tbxHomepage.Text,
                                      Matchcode = tbxMatchcode.Text == "" ? null : tbxMatchcode.Text,
                                      Notiz = tbxNotiz.Text == "" ? null : tbxNotiz.Text,
                                      Kategorie = cmbKunde.Checked ? "Kunde" : (cmbPrivat.Checked) ? "Privat" : (cmbVerein.Checked) ? "Verein" : null,
                                      Status = cbxSperren.Checked ? "gesperrt" : null
                                  };

                        if (checkKundeDublette(k) == 1)
                        {
                            dbContext.Kunde.InsertOnSubmit(k);
                            dbContext.SubmitChanges();
                            lastKundeId = k.KundeID;



                            if (cbxOutlookKontakt.Checked)
                            {
                                Func.AddOutlookContact(k);
                            }

                            this.clearEingabefelderKunde();
                            IsDefault = true;

                            try
                            {
                                using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
                                {
                                    var command = new SqlCommand(string.Format("SELECT KundeID, Anrede, Vorname, Name_Firma, Straﬂe, AdressZusatz1, AdressZusatz2, PLZ, Ort, Land, Telefon2, Fax2, Mobil, Email2, Homepage, Matchcode, Kategorie, Status, Notiz FROM Kunde WHERE KundeID = {0}", lastKundeId), sqlconnection);
                                    var adapter = new SqlDataAdapter(command);
                                    var table = new DataTable();
                                    Func.FUebersicht.slKunde.Text = string.Format("{0} Datens‰tze gefunden.", adapter.Fill(table));
                                    Func.FUebersicht.dgrKunden.Columns.Clear();
                                    Func.FUebersicht.dgrKunden.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                                    Func.FUebersicht.dgrKunden.DataSource = table;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                            //Func.FUebersicht.tsItemAkualisieren.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void cobAnrede_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bei Auswahl "Firma" ist die Textbox "Vorname" gesperrt.
            if (cbxAnrede.SelectedIndex == 0)
            {
                tbxVorname.Enabled = false;
                tbxVorname.BackColor = Func.CDisabled;
                if (epVorname != null)
                {
                    epVorname.Clear();
                }
            }
            else
            {
                tbxVorname.Enabled = true;
                tbxVorname.BackColor = Func.CEnabled;
            }
        }

        private void btnAenderungSp_Click(object sender, EventArgs e)
        {
            UpdateKunde();
        }

        private void UpdateKunde()
        {
            if (tbxNameFirma.Text == "" || tbxStrasse.Text == "" || tbxPLZL.Text == "" || tbxLand.Text == "" ||
                tbxOrt.Text == "")
            {
                MessageBox.Show("Sie m¸ssen alle erforderlichen (*) Felder f¸llen.",
                                "Nicht alle Felder gef¸llt!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (DataBaseDataContext dbContext = new DataBaseDataContext())
                {
                    try
                    {
                        var k = dbContext.Kunde.Where(customer => customer.KundeID.Equals(int.Parse(tbxKundennummer.Text))).FirstOrDefault();

                        k.Anrede = cbxAnrede.Text == "" ? null : cbxAnrede.Text;
                        k.Name_Firma = tbxNameFirma.Text == "" ? null : tbxNameFirma.Text;
                        k.Straﬂe = tbxStrasse.Text == "" ? null : tbxStrasse.Text;
                        k.PLZ = tbxPLZL.Text == "" ? null : tbxPLZL.Text;
                        k.Land = tbxLand.Text == "" ? null : tbxLand.Text;
                        k.Ort = tbxOrt.Text == "" ? null : tbxOrt.Text;
                        k.Vorname = tbxVorname.Text == "" ? null : tbxVorname.Text;
                        k.AdressZusatz1 = tbxZusatz1.Text == "" ? null : tbxZusatz1.Text;
                        k.AdressZusatz2 = tbxZusatz2.Text == "" ? null : tbxZusatz2.Text;
                        k.Telefon1 = null;//tbxTelefon1.Text == "" ? null : tbxTelefon1.Text;
                        k.Telefon2 = tbxTelefon2.Text == "" ? null : tbxTelefon2.Text;
                        k.Fax1 = null;//tbxFax1.Text == "" ? null : tbxFax1.Text;
                        k.Fax2 = tbxFax2.Text == "" ? null : tbxFax2.Text;
                        k.Mobil = tbxMobil.Text == "" ? null : tbxMobil.Text;
                        k.Email1 = null;//tbxEmail1.Text == "" ? null : tbxEmail1.Text;
                        k.Email2 = tbxEmail2.Text == "" ? null : tbxEmail2.Text;
                        k.Homepage = tbxHomepage.Text == "" ? null : tbxHomepage.Text;
                        k.Matchcode = tbxMatchcode.Text == "" ? null : tbxMatchcode.Text;
                        k.Notiz = tbxNotiz.Text == "" ? null : tbxNotiz.Text;
                        k.Kategorie = cmbKunde.Checked ? "Kunde" : (cmbPrivat.Checked) ? "Privat" : (cmbVerein.Checked) ? "Verein" : null;
                        k.Status = cbxSperren.Checked ? "gesperrt" : null;

                        dbContext.SubmitChanges();

                        //Func.FUebersicht.dgrKunden.DataSource = dbContext.Kunde.Where(customer => customer.Kategorie == k.Kategorie && customer.Status == null);

                        Func.FUebersicht.tsItemAkualisieren.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                //this.clearEingabefelderKunde();
                //this.Close();
            }
        }

        private void btnLand_Click(object sender, EventArgs e)
        {
            Form_Land land = new Form_Land();
            land.ShowDialog();
        }

        private void tbxStrasse_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateStrasse();
        }

        private void tbxVorname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateVorname();
        }

        private void tbxLand_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateLand();
        }

        private void tbxPLZL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validatePLZ();
        }

        private void tbxOrt_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateOrt();
        }

        private void tbxNameFirma_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateNameFirma();
        }

        private void tbxEmail1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validateEmail1();
        }

        private void tbxEmail2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //validateEmail2();
        }

        private void Kunde_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsDefault)
            {
                CheckWheterDefault();
            }

            if (!IsDefault)
            {
                DialogResult result = MessageBox.Show("Mˆchten Sie die ƒnderungen speichern?",
                                                      "Best‰tigung",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = true;


                    if (tbxKundennummer.Text == "")
                    {
                        if ((tbxNameFirma.Text == "" || tbxStrasse.Text == "" || tbxPLZL.Text == "" || tbxLand.Text == "" ||
                      tbxOrt.Text == ""))
                        {
                            btnKundeAnl.PerformClick();
                        }
                        else
                        {
                            IsDefault = true;
                            btnKundeAnl.PerformClick();
                            this.Close();
                        }

                    }
                    else
                    {
                        IsDefault = true;
                        btnSpeicherSchlieﬂen.PerformClick();
                    }

                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            else
            {
                this.Dispose();
            }



        }





        private void btnSpeicherSchlieﬂen_Click(object sender, EventArgs e)
        {
            IsDefault = true; // verhindert wiederholte Abfrage, ob ƒnderungen gespeichert werden sollen.
            UpdateKunde();
            this.Close();
        }

        private void CheckWheterDefault()
        {
            if ((cbxAnrede.Text == "Firma") & (tbxVorname.Text == "") & (tbxNameFirma.Text == "") & (tbxZusatz1.Text == "") & (tbxZusatz2.Text == "") & (tbxStrasse.Text == "") & (tbxPLZL.Text == "") & (tbxOrt.Text == "") & (tbxLand.Text == "DE") & /*(tbxTelefon1.Text == "") &*/ (tbxTelefon2.Text == "") & /*(tbxFax1.Text == "") &*/ (tbxFax2.Text == "") & (tbxMobil.Text == "") & /*(tbxEmail1.Text == "") &*/ (tbxEmail2.Text == "") & (tbxHomepage.Text == "") & (tbxMatchcode.Text == "") & (tbxNotiz.Text == "") & (cbxSperren.Checked == false) & (cmbKunde.Checked == true))
            {
                IsDefault = true;
            }
        }



    }
}