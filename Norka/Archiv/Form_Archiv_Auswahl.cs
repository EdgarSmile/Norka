using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Norka.Archiv
{
  using Func;
  using DB;
  using Common;


  /// <summary>
  /// 
  /// </summary>
  public partial class Form_Archiv_Auswahl : Form
  {
    #region Variablen

    private readonly ErrorProvider epAngebotNr;
    private readonly ErrorProvider epAuftragNr;
    private readonly ErrorProvider epKundenNr;
    private readonly ErrorProvider epRechnungNr;
    private ErrorProvider epAngebotMaxZeilen;
    private ErrorProvider epAuftragMaxZeilen;
    private ErrorProvider epRechnungMaxZeilen;

    private bool isMaxAngebotZeilenFilled = false;
    private bool isMaxAuftragZeilenFilled = false;
    private bool isMaxRechnungZeilenFilled = false;

    #endregion


    #region Kontruktoren

    /// <summary>
    /// Initializes a new instance of the <see cref="Form_Archiv_Auswahl"/> class.
    /// </summary>
    public Form_Archiv_Auswahl()
    {
      InitializeComponent();
      epAngebotNr = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.AlwaysBlink };
      epKundenNr = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.AlwaysBlink };
      epAuftragNr = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.AlwaysBlink };
      epRechnungNr = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.AlwaysBlink };

      if (tbxAngebotMaxZeilen.Text != "")
      {
        isMaxAngebotZeilenFilled = true;
      }

      if (tbxAuftragMaxZeilen.Text != "")
      {
        isMaxAuftragZeilenFilled = true;
      }

      if (tbxRechnungMaxZeilen.Text != "")
      {
        isMaxRechnungZeilenFilled = true;
      }
    }

    #endregion


    #region Methoden

    private void SearchAngebote()
    {
      this.Cursor = Cursors.WaitCursor;
      Func.FArchiv.slArchiv.Text = String.Empty;

      using (var dbContext = new DataBaseDataContext())
      {
        // User hat keine Suchwerte eingegeben - Alle Angebot werden nach Bestätigung durch User aufgelistet
        if ((tbxAngKundenNr.Text == String.Empty) & (tbxAngBV.Text == String.Empty) & (tbxAngName.Text == String.Empty) & (tbxAngebotNr.Text == String.Empty) & (tbxAngOrt.Text == String.Empty) & (mtbxAngDatumVon.Text == "  .  .") & (mtbxAngDatumBis.Text == "  .  ."))
        {

          // Alle Kundendatensätze in der DB zählen.
          int orderCount = dbContext.Angebot.Count();
          if (orderCount > 0)
          {
            //this.Dispose();


            if (isMaxAngebotZeilenFilled && epAngebotMaxZeilen == null)
            {
              var res = dbContext.VIEW_ArchivAngeboteAlle.Select(a => a).OrderByDescending(a => a.AngebotID).Take(int.Parse(tbxAngebotMaxZeilen.Text));

              Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", res.Count());
              Func.FArchiv.dgrResults.Columns.Clear();
              Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
              Func.FArchiv.dgrResults.DataSource = res;
              Func.FArchiv.Query = "SELECT TOP (" + res.Count() + ") * FROM VIEW_ArchivAngeboteAlle ORDER BY VIEW_ArchivAngeboteAlle.AngebotID DESC";
            }
            else
            {
              DialogResult result = MessageBox.Show(string.Format("Es wurden insgesamt  ( {0} )  Angebote gefunden.\nSollen diese alle angezeigt werden?", orderCount.ToString()), "Auswahl Angebote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              if (result == DialogResult.Yes & epAngebotMaxZeilen == null)
              {

                var res = dbContext.VIEW_ArchivAngeboteAlle.Select(a => a).OrderByDescending(a => a.AngebotID);
                Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", orderCount.ToString());
                Func.FArchiv.dgrResults.Columns.Clear();
                Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                Func.FArchiv.dgrResults.DataSource = res;
                Func.FArchiv.Query = "SELECT * FROM VIEW_ArchivAngeboteAlle ORDER BY VIEW_ArchivAngeboteAlle.AngebotID DESC";
              }
            }
          }
          else
          {
            Func.FArchiv.dgrResults.Columns.Clear();
          }
        }
        else
        {
          if (ValidateAngebotNr())
          {
            var sb = new StringBuilder();

            if (isMaxAngebotZeilenFilled && epAngebotMaxZeilen == null)
            {
              var res = dbContext.VIEW_ArchivAngeboteAlle.Select(a => a).OrderByDescending(a => a.AngebotID).Take(int.Parse(tbxAngebotMaxZeilen.Text));
              sb.AppendFormat("SELECT TOP ({0}) VIEW_ArchivAngeboteAlle.* FROM  VIEW_ArchivAngeboteAlle INNER JOIN Kunde ON VIEW_ArchivAngeboteAlle.KundeID = Kunde.KundeID WHERE ", res.Count());
            }
            else
            {
              sb.AppendLine("SELECT VIEW_ArchivAngeboteAlle.* FROM  VIEW_ArchivAngeboteAlle INNER JOIN Kunde ON VIEW_ArchivAngeboteAlle.KundeID = Kunde.KundeID WHERE ");
            }

            if (tbxAngebotNr.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivAngeboteAlle.AngebotID LIKE \'%{0}%\' AND ", tbxAngebotNr.Text);
            }

            if (tbxAngKundenNr.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivAngeboteAlle.KundeID LIKE \'%{0}%\' AND ", tbxAngKundenNr.Text);
            }

            if (tbxAngName.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivAngeboteAlle.Name_Firma LIKE \'%{0}%\' AND ", tbxAngName.Text);
            }

            if (tbxAngOrt.Text != String.Empty)
            {
              sb.AppendFormat("Kunde.Ort LIKE \'%{0}%\' AND ", tbxAngOrt.Text);
            }

            if (mtbxAngDatumVon.Text != Const.DEFAULT_MTBX)
            {
              sb.AppendFormat("VIEW_ArchivAngeboteAlle.Datum >= \'{0}\' AND ", mtbxAngDatumVon.Text);
            }

            if (mtbxAngDatumBis.Text != Const.DEFAULT_MTBX)
            {
              sb.AppendFormat("VIEW_ArchivAngeboteAlle.Datum <= \'{0}\' AND ", mtbxAngDatumBis.Text);
            }

            if (tbxAngBV.Text != String.Empty)
            {
              sb.AppendFormat("(VIEW_ArchivAngeboteAlle.bv LIKE \'%{0}%\' OR VIEW_ArchivAngeboteAlle.bv2 LIKE \'%{0}%\') AND ", tbxAngBV.Text);
            }

            String s = sb.ToString();

            String j = s.Substring(s.Length - 4, 3);

            if (j == "AND")
            {
              s = s.Substring(0, s.Length - 5);
            }

            s += " ORDER BY VIEW_ArchivAngeboteAlle.AngebotID DESC";

            Func.FArchiv.Query = s;

            try
            {
              using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
              {
                var command = new SqlCommand(s, sqlconnection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
                Func.FArchiv.dgrResults.Columns.Clear();
                Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                Func.FArchiv.dgrResults.DataSource = table;
              }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }
      }

      this.Cursor = Cursors.Default;
    }

    private void SearchRechnungen()
    {
      this.Cursor = Cursors.WaitCursor;
      Func.FArchiv.slArchiv.Text = String.Empty;

      using (var dbContext = new DataBaseDataContext())
      {
        // User hat keine Suchwerte eingegeben - Alle Angebot werden nach Bestätigung durch User aufgelistet
        if ((tbxRechKundenNr.Text == String.Empty) & (tbxRechBV.Text == String.Empty) & (tbxRechName.Text == String.Empty) & (tbxRechnungNr.Text == String.Empty) & (tbxRechOrt.Text == String.Empty) & (mtbxRechDatumVon.Text == "  .  .") & (mtbxRechDatumBis.Text == "  .  .") & (cbxRechStorniert.CheckState == CheckState.Indeterminate) & (cbxAngemahnt.CheckState == CheckState.Indeterminate) & (cbxEinbehalt.CheckState == CheckState.Indeterminate) & (cbxSchlussrechnung.CheckState == CheckState.Indeterminate))
        {

          // Alle Kundendatensätze in der DB zählen.
          int orderCount = dbContext.Rechnung.Count();
          if (orderCount > 0)
          {
            //this.Dispose();

            if (isMaxRechnungZeilenFilled && epRechnungMaxZeilen == null)
            {
              var res = dbContext.VIEW_ArchivRechnungAlle.Select(a => a).OrderByDescending(a => a.RechnungID).Take(int.Parse(tbxRechnungMaxZeilen.Text));

              Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", res.Count());
              Func.FArchiv.dgrResults.Columns.Clear();
              Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
              Func.FArchiv.dgrResults.DataSource = res;
              Func.FArchiv.Query = "SELECT TOP (" + res.Count() + ") * FROM VIEW_ArchivRechnungAlle ORDER BY VIEW_ArchivRechnungAlle.RechnungID DESC";
            }
            else
            {
              DialogResult result = MessageBox.Show(string.Format("Es wurden insgesamt  ( {0} )  Rechnungen gefunden.\nSollen diese alle angezeigt werden?", orderCount.ToString()),
                                                    "Auswahl Rechnungen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              if (result == DialogResult.Yes & epRechnungMaxZeilen == null)
              {
                var res = dbContext.VIEW_ArchivRechnungAlle.Select(a => a).OrderByDescending(a => a.RechnungID);
                Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", orderCount.ToString());
                Func.FArchiv.dgrResults.Columns.Clear();
                Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                Func.FArchiv.dgrResults.DataSource = res;
                Func.FArchiv.Query = "SELECT * FROM VIEW_ArchivRechnungAlle ORDER BY VIEW_ArchivRechnungAlle.AuftragID DESC";
              }
            }
            Func.FArchiv.StornoKennzeichnen();
          }
          else
          {
            Func.FArchiv.dgrResults.Columns.Clear();
          }

        }
        else
        {
          if (ValidateRechnungNr())
          {

            var sb = new StringBuilder();

            if (isMaxRechnungZeilenFilled && epRechnungMaxZeilen == null)
            {
              var res = dbContext.VIEW_ArchivRechnungAlle.Select(a => a).OrderByDescending(a => a.RechnungID).Take(int.Parse(tbxRechnungMaxZeilen.Text));
              sb.AppendFormat("SELECT TOP ({0}) VIEW_ArchivRechnungAlle.* FROM  VIEW_ArchivRechnungAlle INNER JOIN Kunde ON VIEW_ArchivRechnungAlle.KundeID = Kunde.KundeID WHERE ", res.Count());
            }
            else
            {
              sb.AppendLine("SELECT VIEW_ArchivRechnungAlle.* FROM  VIEW_ArchivRechnungAlle INNER JOIN Kunde ON VIEW_ArchivRechnungAlle.KundeID = Kunde.KundeID WHERE ");
            }

            if (tbxRechnungNr.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivRechnungAlle.RechnungID LIKE \'%{0}%\' AND ", tbxRechnungNr.Text);
            }

            if (tbxRechKundenNr.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivRechnungAlle.KundeID LIKE \'%{0}%\' AND ", tbxRechKundenNr.Text);
            }

            if (tbxRechName.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivRechnungAlle.Name_Firma LIKE \'%{0}%\' AND ", tbxRechName.Text);
            }

            if (tbxRechOrt.Text != String.Empty)
            {
              sb.AppendFormat("Kunde.Ort LIKE \'%{0}%\' AND ", tbxRechOrt.Text);
            }

            if (mtbxRechDatumVon.Text != Const.DEFAULT_MTBX)
            {
              sb.AppendFormat("VIEW_ArchivRechnungAlle.RechDatum >= \'{0}\' AND ", mtbxRechDatumVon.Text);
            }

            if (mtbxRechDatumBis.Text != Const.DEFAULT_MTBX)
            {
              sb.AppendFormat("VIEW_ArchivRechnungAlle.RechDatum <= \'{0}\' AND ", mtbxRechDatumBis.Text);
            }

            if ((cbxRechStorniert.CheckState == CheckState.Checked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.StornoID IS NOT NULL AND ");
            }
            if ((cbxRechStorniert.CheckState == CheckState.Unchecked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.StornoID IS null AND VIEW_ArchivRechnungAlle.Gesamtbetrag >= 0 AND ");
            }

            if ((cbxAngemahnt.CheckState == CheckState.Checked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.Mahndatum IS NOT NULL AND ");
            }
            if ((cbxAngemahnt.CheckState == CheckState.Unchecked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.Mahndatum IS null AND ");
            }

            if ((cbxSchlussrechnung.CheckState == CheckState.Checked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.SR = \'Ja\' ");
            }
            if ((cbxSchlussrechnung.CheckState == CheckState.Unchecked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.SR  IS null  ");
            }

            if ((cbxEinbehalt.CheckState == CheckState.Checked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.Einbehalt IS NOT NULL AND ");
            }
            if ((cbxEinbehalt.CheckState == CheckState.Unchecked))
            {
              sb.Append("VIEW_ArchivRechnungAlle.Einbehalt IS null AND ");
            }

            if (tbxRechBV.Text != String.Empty)
            {
              sb.AppendFormat("(VIEW_ArchivRechnungAlle.bv LIKE \'%{0}%\' OR VIEW_ArchivRechnungAlle.bv2 LIKE \'%{0}%\') AND ", tbxRechBV.Text);
            }

            String s = sb.ToString();

            String j = s.Substring(s.Length - 4, 3);

            if (j == "AND")
            {
              s = s.Substring(0, s.Length - 5);
            }

            s += " ORDER BY VIEW_ArchivRechnungAlle.RechnungID DESC";

            Func.FArchiv.Query = s;

            try
            {
              using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
              {
                var command = new SqlCommand(s, sqlconnection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
                Func.FArchiv.dgrResults.Columns.Clear();
                Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                Func.FArchiv.dgrResults.DataSource = table;
              }
              Func.FArchiv.StornoKennzeichnen();
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }
      }
      this.Cursor = Cursors.Default;
    }

    private void SearchAufträge()
    {
      this.Cursor = Cursors.WaitCursor;
      Func.FArchiv.slArchiv.Text = String.Empty;

      using (var dbContext = new DataBaseDataContext())
      {
        // User hat keine Suchwerte eingegeben - Alle Angebot werden nach Bestätigung durch User aufgelistet
        if ((tbxAufKundenNr.Text == String.Empty) & (tbxAufName.Text == String.Empty) & (tbxAuftragNr.Text == String.Empty) & (tbxAufOrt.Text == String.Empty) & (mtbxAufDatumVon.Text == "  .  .") & (mtbxAufDatumBis.Text == "  .  ."))
        {

          // Alle Kundendatensätze in der DB zählen.
          int orderCount = dbContext.Auftrag.Count();
          if (orderCount > 0)
          {
            //this.Dispose();

            if (isMaxAuftragZeilenFilled && epAuftragMaxZeilen == null)
            {
              var res = dbContext.VIEW_ArchivAuftragAlle.Select(a => a).OrderByDescending(a => a.AuftragID).Take(int.Parse(tbxAuftragMaxZeilen.Text));

              Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", res.Count());
              Func.FArchiv.dgrResults.Columns.Clear();
              Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
              Func.FArchiv.dgrResults.DataSource = res;
              Func.FArchiv.Query = "SELECT TOP (" + res.Count() + ") * FROM VIEW_ArchivAuftragAlle ORDER BY VIEW_ArchivAuftragAlle.AuftragID DESC";
            }
            else
            {
              DialogResult result = MessageBox.Show(string.Format("Es wurden insgesamt  ( {0} )  Aufträge gefunden.\nSollen diese alle angezeigt werden?", orderCount.ToString()),
                                                    "Auswahl Aufträge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

              if (result == DialogResult.Yes & epAuftragMaxZeilen == null)
              {
                var res = dbContext.VIEW_ArchivAuftragAlle.Select(a => a).OrderByDescending(a => a.AuftragID);
                Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", orderCount.ToString());
                Func.FArchiv.dgrResults.Columns.Clear();
                Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                Func.FArchiv.dgrResults.DataSource = res;
                Func.FArchiv.Query = "SELECT * FROM VIEW_ArchivAuftragAlle ORDER BY VIEW_ArchivAuftragAlle.AuftragID DESC";
              }
            }
          }
          else
          {
            Func.FArchiv.dgrResults.Columns.Clear();
          }

        }
        else
        {
          if (ValidateAuftragNr())
          {
            var sb = new StringBuilder();

            if (isMaxAuftragZeilenFilled && epAuftragMaxZeilen == null)
            {
              var res = dbContext.VIEW_ArchivAuftragAlle.Select(a => a).OrderByDescending(a => a.AuftragID).Take(int.Parse(tbxAuftragMaxZeilen.Text));
              sb.AppendFormat("SELECT TOP ({0}) VIEW_ArchivAuftragAlle.* FROM  VIEW_ArchivAuftragAlle INNER JOIN Kunde ON VIEW_ArchivAuftragAlle.KundeID = Kunde.KundeID WHERE ", res.Count());
            }
            else
            {
              sb.AppendLine("SELECT VIEW_ArchivAuftragAlle.* FROM  VIEW_ArchivAuftragAlle INNER JOIN Kunde ON VIEW_ArchivAuftragAlle.KundeID = Kunde.KundeID WHERE ");
            }

            if (tbxAuftragNr.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivAuftragAlle.AuftragID LIKE \'%{0}%\' AND ", tbxAuftragNr.Text);
            }

            if (tbxAufKundenNr.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivAuftragAlle.KundeID LIKE \'%{0}%\' AND ", tbxAufKundenNr.Text);
            }

            if (tbxAufName.Text != String.Empty)
            {
              sb.AppendFormat("VIEW_ArchivAuftragAlle.Name_Firma LIKE \'%{0}%\' AND ", tbxAufName.Text);
            }

            if (tbxAufOrt.Text != String.Empty)
            {
              sb.AppendFormat("Kunde.Ort LIKE \'%{0}%\' AND ", tbxAufOrt.Text);
            }

            if (mtbxAufDatumVon.Text != Const.DEFAULT_MTBX)
            {
              sb.AppendFormat("VIEW_ArchivAuftragAlle.Datum >= \'{0}\' AND ", mtbxAufDatumVon.Text);
            }

            if (mtbxAufDatumBis.Text != Const.DEFAULT_MTBX)
            {
              sb.AppendFormat("VIEW_ArchivAuftragAlle.Datum <= \'{0}\' AND ", mtbxAufDatumBis.Text);
            }

            String s = sb.ToString();

            String j = s.Substring(s.Length - 4, 3);

            if (j == "AND")
            {
              s = s.Substring(0, s.Length - 5);
            }

            s += "ORDER BY VIEW_ArchivAuftragAlle.AuftragID DESC";

            Func.FArchiv.Query = s;

            try
            {
              using (var sqlconnection = new SqlConnection(Properties.Settings.Default.NorkaConnectionString))
              {
                var command = new SqlCommand(s, sqlconnection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                Func.FArchiv.slArchiv.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
                Func.FArchiv.dgrResults.Columns.Clear();
                Func.FArchiv.dgrResults.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                Func.FArchiv.dgrResults.DataSource = table;

              }

            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.ToString());
            }
          }
        }
      }
      this.Cursor = Cursors.Default;
    }

    /// <summary>
    /// Überprüft die Eingabe der Angebot-Nr auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob Angebot-Nr nummerisch ist oder nicht</returns>
    private bool ValidateAngebotNr()
    {
      bool status = false;

      if (tbxAngebotNr.TextLength > 0 & !Func.IsNumeric(tbxAngebotNr.Text, true))
      {
        epAngebotNr.SetError(tbxAngebotNr, "Die Angebot-Nr darf nur nummerische Werte enthalten.");
      }
      else
      {
        epAngebotNr.Clear();
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Überprüft die Eingabe der Auftrag-Nr auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob Auftrag-Nr nummerisch ist oder nicht</returns>
    private bool ValidateAuftragNr()
    {
      bool status = false;

      if (tbxAuftragNr.TextLength > 0 & !Func.IsNumeric(tbxAuftragNr.Text, true))
      {
        epAuftragNr.SetError(tbxAuftragNr, "Die Auftrag-Nr darf nur nummerische Werte enthalten.");
      }
      else
      {
        epAuftragNr.Clear();
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Überprüft die Eingabe der Kunden-Nr auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob Kunden-Nr nummerisch ist oder nicht</returns>
    private bool ValidateKundenNr()
    {
      bool status = false;

      if (tbxAngKundenNr.TextLength > 0 & !Func.IsNumeric(tbxAngKundenNr.Text, true) || (tbxAufKundenNr.TextLength > 0 & !Func.IsNumeric(tbxAufKundenNr.Text, true)) || (tbxRechKundenNr.TextLength > 0 & !Func.IsNumeric(tbxRechKundenNr.Text, true)))
      {
        epKundenNr.SetError(tbxAngKundenNr, "Die Kunden-Nr darf nur nummerische Werte enthalten.");
        epKundenNr.SetError(tbxAufKundenNr, "Die Kunden-Nr darf nur nummerische Werte enthalten.");
      }
      else
      {
        epKundenNr.Clear();
        status = true;
      }

      return status;
    }

    /// <summary>
    /// Überprüft die Eingabe der MaxAngebotZeilen auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob MaxAngebotZeilen nummerisch ist oder nicht</returns>
    private bool ValidateMaxAngebotZeilen()
    {
      bool status = false;

      if (System.Text.RegularExpressions.Regex.IsMatch(tbxAngebotMaxZeilen.Text, "\\d+") || tbxAngebotMaxZeilen.Text == "")
      {
        isMaxAngebotZeilenFilled = true;

        if (epAngebotMaxZeilen != null)
        {
          epAngebotMaxZeilen.Clear();
        }

        status = true;
      }
      else
      {
        epAngebotMaxZeilen = new ErrorProvider();
        epAngebotMaxZeilen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        epAngebotMaxZeilen.SetError(tbxAngebotMaxZeilen, "Nur positive, numerische Werte erlaubt!");
        tbxAngebotMaxZeilen.SelectAll();
        isMaxAngebotZeilenFilled = false;
      }

      return status;
    }

    /// <summary>
    /// Überprüft die Eingabe der MaxAuftragZeilen auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob MaxAuftragZeilen nummerisch ist oder nicht</returns>
    private bool ValidateMaxAuftragZeilen()
    {
      bool status = false;

      if (System.Text.RegularExpressions.Regex.IsMatch(tbxAuftragMaxZeilen.Text, "\\d+") || tbxAuftragMaxZeilen.Text == "")
      {
        isMaxAuftragZeilenFilled = true;

        if (epAuftragMaxZeilen != null)
        {
          epAuftragMaxZeilen.Clear();
        }

        status = true;
      }
      else
      {
        epAuftragMaxZeilen = new ErrorProvider();
        epAuftragMaxZeilen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        epAuftragMaxZeilen.SetError(tbxAuftragMaxZeilen, "Nur positive, numerische Werte erlaubt!");
        tbxAuftragMaxZeilen.SelectAll();
        isMaxAuftragZeilenFilled = false;
      }

      return status;
    }

    /// <summary>
    /// Überprüft die Eingabe der MaxRechnungZeilen auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob MaxRechnungZeilen nummerisch ist oder nicht</returns>
    private bool ValidateMaxRechnungZeilen()
    {
      bool status = false;

      if (System.Text.RegularExpressions.Regex.IsMatch(tbxRechnungMaxZeilen.Text, "\\d+") || tbxRechnungMaxZeilen.Text == "")
      {
        isMaxRechnungZeilenFilled = true;

        if (epRechnungMaxZeilen != null)
        {
          epRechnungMaxZeilen.Clear();
        }

        status = true;
      }
      else
      {
        epRechnungMaxZeilen = new ErrorProvider();
        epRechnungMaxZeilen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
        epRechnungMaxZeilen.SetError(tbxRechnungMaxZeilen, "Nur positive, numerische Werte erlaubt!");
        tbxRechnungMaxZeilen.SelectAll();
        isMaxRechnungZeilenFilled = false;
      }

      return status;
    }



    /// <summary>
    /// Überprüft die Eingabe der Rechnung-Nr auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob Rechnung-Nr nummerisch ist oder nicht</returns>
    private bool ValidateRechnungNr()
    {
      bool status = false;

      if (tbxRechKundenNr.TextLength > 0 & !Func.IsNumeric(tbxRechKundenNr.Text, true))
      {
        epRechnungNr.SetError(tbxAngKundenNr, "Die Rechnung-Nr darf nur nummerische Werte enthalten.");
      }
      else
      {
        epRechnungNr.Clear();
        status = true;
      }

      return status;
    }

    #endregion


    #region Events

    private void btnClear_Click(object sender, EventArgs e)
    {
      tbxAngKundenNr.Clear();
      tbxAngName.Clear();
      tbxAngebotNr.Clear();
      tbxAngOrt.Clear();
      mtbxAngDatumVon.Clear();
      mtbxAngDatumBis.Clear();


      tbxAufKundenNr.Clear();
      tbxAufName.Clear();
      tbxAuftragNr.Clear();
      tbxAufOrt.Clear();
      mtbxAufDatumVon.Clear();
      mtbxAufDatumBis.Clear();

      tbxRechKundenNr.Clear();
      tbxRechName.Clear();
      tbxRechnungNr.Clear();
      tbxRechOrt.Clear();
      mtbxRechDatumVon.Clear();
      mtbxRechDatumBis.Clear();

      cbxRechStorniert.CheckState = CheckState.Indeterminate;
      cbxAngemahnt.CheckState = CheckState.Indeterminate;

    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (pnlAngebote.Visible)
      {
        SearchAngebote();
      }
      else if (pnlAufträge.Visible)
      {
        SearchAufträge();
      }
      else if (pnlRechnungen.Visible)
      {
        SearchRechnungen();
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

    private void tbxAngebotNr_Validating(object sender, CancelEventArgs e)
    {
      ValidateAngebotNr();
    }

    private void tbxAngebotNr_KeyDown_1(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      if (ValidateAngebotNr())
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

    private void mtbxAngDatumVon_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          btnOK.PerformClick();
        }
        else if (e.KeyCode == Keys.H)
        {
          mtbxAngDatumVon.Text = DateTime.Today.ToShortDateString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message.ToString());
      }
    }

    private void mtbxAngDatumBis_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          btnOK.PerformClick();
        }
        else if (e.KeyCode == Keys.H)
        {
          mtbxAngDatumBis.Text = DateTime.Today.ToShortDateString();
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

    private void tbxAngebotNr_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAngebotNr.SelectAll();
      });
    }

    private void tbxAngKundenNr_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAngKundenNr.SelectAll();
      });
    }

    private void tbxAngName_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAngName.SelectAll();
      });
    }

    private void mtbxAngDatumVon_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        mtbxAngDatumVon.SelectAll();
      });
    }

    private void mtbxAngDatumBis_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        mtbxAngDatumBis.SelectAll();
      });
    }

    private void tbxAufName_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAufName.SelectAll();
      });
    }

    private void tbxAufName_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxAuftragNr_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxAuftragNr_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAuftragNr.SelectAll();
      });
    }

    private void tbxAuftragNr_Validating(object sender, CancelEventArgs e)
    {
      ValidateAuftragNr();
    }

    private void tbxAufKundenNr_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAufKundenNr.SelectAll();
      });
    }

    private void tbxAufKundenNr_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxAufKundenNr_Validating(object sender, CancelEventArgs e)
    {
      ValidateKundenNr();
    }

    private void mtbxAufDatumVon_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        mtbxAufDatumVon.SelectAll();
      });
    }

    private void mtbxAufDatumVon_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          btnOK.PerformClick();
        }
        else if (e.KeyCode == Keys.H)
        {
          mtbxAufDatumVon.Text = DateTime.Today.ToShortDateString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message.ToString());
      }
    }

    private void mtbxAufDaumBix_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          btnOK.PerformClick();
        }
        else if (e.KeyCode == Keys.H)
        {
          mtbxAufDatumBis.Text = DateTime.Today.ToShortDateString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message.ToString());
      }
    }

    private void mtbxAufDaumBis_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        mtbxAufDatumBis.SelectAll();
      });
    }

    #endregion

    private void tbxRechnungNr_Validating(object sender, CancelEventArgs e)
    {
      ValidateRechnungNr();
    }

    private void tbxRechnungNr_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxRechnungNr_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxRechnungNr.SelectAll();
      });
    }

    private void tbxRechKundenNr_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxRechKundenNr.SelectAll();
      });
    }

    private void tbxRechKundenNr_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxRechKundenNr_Validating(object sender, CancelEventArgs e)
    {
      ValidateKundenNr();
    }

    private void tbxRechName_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxRechName_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxRechName.SelectAll();
      });
    }

    private void mtbxRechDatumVon_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        mtbxRechDatumVon.SelectAll();
      });
    }

    private void mtbxRechDatumVon_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          btnOK.PerformClick();
        }
        else if (e.KeyCode == Keys.H)
        {
          mtbxRechDatumVon.Text = DateTime.Today.ToShortDateString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message.ToString());
      }
    }

    private void mtbxRechDatumBis_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        mtbxRechDatumBis.SelectAll();
      });
    }

    private void mtbxRechDatumBis_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      try
      {
        if (e.KeyCode == Keys.Enter)
        {
          btnOK.PerformClick();
        }
        else if (e.KeyCode == Keys.H)
        {
          mtbxRechDatumBis.Text = DateTime.Today.ToShortDateString();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message.ToString());
      }
    }

    private void tbxAufOrt_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAufOrt.SelectAll();
      });
    }

    private void tbxAufOrt_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxAngOrt_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAngOrt.SelectAll();
      });
    }

    private void tbxAngOrt_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxRechOrt_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxRechOrt.SelectAll();
      });
    }

    private void tbxRechOrt_KeyDown(object sender, KeyEventArgs e)
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




    private void tbxAngebotMaxZeilen_TextChanged(object sender, EventArgs e)
    {
      if (tbxAngebotMaxZeilen.Text == "")
      {
        isMaxAngebotZeilenFilled = false;
      }
      else
      {
        if (System.Text.RegularExpressions.Regex.IsMatch(tbxAngebotMaxZeilen.Text, "\\d+") || tbxAngebotMaxZeilen.Text != "")
        {
          isMaxAngebotZeilenFilled = true;

          if (epAngebotMaxZeilen != null)
          {
            epAngebotMaxZeilen.Clear();
          }
        }
        else
        {
          epAngebotMaxZeilen = new ErrorProvider();
          epAngebotMaxZeilen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
          epAngebotMaxZeilen.SetError(tbxAngebotMaxZeilen, "Nur positive, numerische Werte erlaubt!");
          tbxAngebotMaxZeilen.SelectAll();
          isMaxAngebotZeilenFilled = false;
        }
      }

    }

    private void tbxAngebotMaxZeilen_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      if (ValidateMaxAngebotZeilen())
      {
        try
        {
          if (e.KeyCode == Keys.Enter)
          {
            if (tbxAngebotMaxZeilen.Text == "")
            {
              isMaxAngebotZeilenFilled = false;
            }
            btnOK.PerformClick();
          }

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message.ToString());
        }
      }
    }

    private void tbxAuftragMaxZeilen_TextChanged(object sender, EventArgs e)
    {
      if (tbxAuftragMaxZeilen.Text == "")
      {
        isMaxAuftragZeilenFilled = false;
      }
      else
      {
        if (System.Text.RegularExpressions.Regex.IsMatch(tbxAuftragMaxZeilen.Text, "\\d+") || tbxAuftragMaxZeilen.Text != "")
        {
          isMaxAuftragZeilenFilled = true;

          if (epAuftragMaxZeilen != null)
          {
            epAuftragMaxZeilen.Clear();
          }
        }
        else
        {
          epAuftragMaxZeilen = new ErrorProvider();
          epAuftragMaxZeilen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
          epAuftragMaxZeilen.SetError(tbxAuftragMaxZeilen, "Nur positive, numerische Werte erlaubt!");
          tbxAuftragMaxZeilen.SelectAll();
          isMaxAuftragZeilenFilled = false;
        }
      }

    }

    private void tbxAuftragMaxZeilen_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      if (ValidateMaxAuftragZeilen())
      {
        try
        {
          if (e.KeyCode == Keys.Enter)
          {
            if (tbxAuftragMaxZeilen.Text == "")
            {
              isMaxAuftragZeilenFilled = false;
            }
            btnOK.PerformClick();
          }

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message.ToString());
        }
      }
    }

    private void tbxRechnungMaxZeilen_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      if (ValidateMaxRechnungZeilen())
      {
        try
        {
          if (e.KeyCode == Keys.Enter)
          {
            if (tbxRechnungMaxZeilen.Text == "")
            {
              isMaxRechnungZeilenFilled = false;
            }
            btnOK.PerformClick();
          }

        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message.ToString());
        }
      }
    }

    private void tbxRechnungMaxZeilen_TextChanged(object sender, EventArgs e)
    {
      if (tbxRechnungMaxZeilen.Text == "")
      {
        isMaxRechnungZeilenFilled = false;
      }
      else
      {
        if (System.Text.RegularExpressions.Regex.IsMatch(tbxRechnungMaxZeilen.Text, "\\d+") || tbxRechnungMaxZeilen.Text != "")
        {
          isMaxRechnungZeilenFilled = true;

          if (epRechnungMaxZeilen != null)
          {
            epRechnungMaxZeilen.Clear();
          }
        }
        else
        {
          epRechnungMaxZeilen = new ErrorProvider();
          epRechnungMaxZeilen.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
          epRechnungMaxZeilen.SetError(tbxRechnungMaxZeilen, "Nur positive, numerische Werte erlaubt!");
          tbxRechnungMaxZeilen.SelectAll();
          isMaxRechnungZeilenFilled = false;
        }
      }

    }

    private void label25_Click(object sender, EventArgs e)
    {

    }

    private void tbxAngBV_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxAngBV_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxAngBV.SelectAll();
      });
    }

    private void tbxRechBV_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxRechBV.SelectAll();
      });
    }

    private void tbxRechBV_KeyDown(object sender, KeyEventArgs e)
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























  }
}
