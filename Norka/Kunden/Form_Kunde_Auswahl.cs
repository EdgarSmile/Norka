using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Norka.Kunden
{
  using Func;
  using DB;
  using Properties;

  /// <summary>
  /// 
  /// </summary>
  public partial class Form_Kunde_Auswahl : Form
  {
    #region Variablen

    /// <summary>
    /// 
    /// </summary>
    private readonly ErrorProvider epKundenNr;

    #endregion


    #region Kontruktoren

    /// <summary>
    /// Initializes a new instance of the <see cref="Form_Kunde_Auswahl"/> class.
    /// </summary>
    public Form_Kunde_Auswahl()
    {
      InitializeComponent();
      epKundenNr = new ErrorProvider { BlinkStyle = ErrorBlinkStyle.AlwaysBlink };
    }

    #endregion


    #region Methoden

    /// <summary>
    /// Ermöglicht es nach bestimmten Kunden zu suchen bzw. alle Kunden aus der Datenbank anzeigen zu lassen.
    /// </summary>
    private void SearchKunden()
    {
      this.Cursor = Cursors.WaitCursor;
      KundeFilter filter = new KundeFilter();
      filter.KundeId = tbxKundenNr.Text;
      filter.Name_Firma = tbxName.Text;
      filter.Matchcode = tbxMatchcode.Text;
      filter.Ort = tbxOrt.Text;
      filter.PLZ = tbxPLZ.Text;
      filter.Kategorie = cobKategorie.Text;
      filter.Status = cbxGesperrt.CheckState;
      filter.Query = filter.GetSqlQuery(filter);

      Func.FUebersicht.slKunde.Text = "";
      // User hat keine Suchwerte eingegeben - Alle Kunden werden nach Bestätigung durch User aufgelistet

      if (filter.IsDefault)

      //if ((tbxKundenNr.Text == "") & (tbxMatchcode.Text == "") & (tbxName.Text == "") & (tbxOrt.Text == "") & (tbxPLZ.Text == "") &
      //    (cbxGesperrt.CheckState == CheckState.Indeterminate) & (cobKategorie.Text == ""))
      {
        using (var dbContext = new DataBaseDataContext())
        {
          int customerCount = dbContext.Kunde.Count();
          if (customerCount > 0)
          {
            //this.Hide();
            this.Cursor = Cursors.Default;
            DialogResult result = MessageBox.Show(string.Format("Es wurden insgesamt  ( {0} )  Kunden gefunden.\nSollen diese alle angezeigt werden?", customerCount.ToString()),
                                                  "Auswahl Kunden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Bei Bestätigung des Dialoges werden alle Kunden aus der Datenbank angezeigt.
            if (result == DialogResult.Yes)
            {
              try
              {
                this.Cursor = Cursors.WaitCursor;
                using (var sqlconnection = new SqlConnection(Settings.Default.NorkaConnectionString))
                {
                  var command = new SqlCommand(filter.Query, sqlconnection);
                  var adapter = new SqlDataAdapter(command);
                  var table = new DataTable();
                  Func.FUebersicht.slKunde.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
                  Func.FUebersicht.dgrKunden.Columns.Clear();
                  Func.FUebersicht.dgrKunden.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
                  this.Cursor = Cursors.Default;
                  Func.FUebersicht.dgrKunden.DataSource = table;
                }
              }
              catch (Exception ex)
              {
                MessageBox.Show(ex.ToString());
              }
              //Func.FUebersicht.dgrKunden.DataSource = dbContext.Kunde.Select(k => k);
              Func.FUebersicht.LastCustomerSearchQuery = filter.Query;
            }
          }
        }
      }
      else
      {
        try
        {
          this.Cursor = Cursors.WaitCursor;
          using (var sqlconnection = new SqlConnection(Settings.Default.NorkaConnectionString))
          {
            var command = new SqlCommand(filter.Query, sqlconnection);
            var adapter = new SqlDataAdapter(command);
            var table = new DataTable();
            Func.FUebersicht.slKunde.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
            Func.FUebersicht.dgrKunden.Columns.Clear();
            Func.FUebersicht.dgrKunden.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
            this.Cursor = Cursors.Default;
            Func.FUebersicht.dgrKunden.DataSource = table;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.ToString());
        }
        //Func.FUebersicht.dgrKunden.DataSource = dbContext.Kunde.Select(k => k);
        Func.FUebersicht.LastCustomerSearchQuery = filter.Query;
      }
      // if (ValidateKundenNr())
      //  {
      //    var sb = new StringBuilder("SELECT * FROM Kunde WHERE ");

      //    if (tbxKundenNr.Text != "")
      //    {
      //      sb.AppendFormat("Kunde.KundeID LIKE \'%{0}%\' AND ", tbxKundenNr.Text);
      //    }

      //    if (tbxMatchcode.Text != "")
      //    {
      //      sb.AppendFormat("Kunde.Matchcode LIKE \'%{0}%\' AND ", tbxMatchcode.Text);
      //    }

      //    if (tbxName.Text != "")
      //    {
      //      sb.AppendFormat("Kunde.Name_Firma LIKE \'%{0}%\' AND ", tbxName.Text);
      //    }

      //    if (tbxOrt.Text != "")
      //    {
      //      sb.AppendFormat("Kunde.Ort LIKE \'%{0}%\' AND ", tbxOrt.Text);
      //    }

      //    if (tbxPLZ.Text != "")
      //    {
      //      sb.AppendFormat("Kunde.PLZ LIKE \'%{0}%\' AND ", tbxPLZ.Text);
      //    }

      //    if ((cbxGesperrt.CheckState == CheckState.Checked))
      //    {
      //      sb.Append("Kunde.Status = \'gesperrt\' AND ");
      //    }
      //    if ((cbxGesperrt.CheckState == CheckState.Unchecked))
      //    {
      //      sb.Append("Kunde.Status is null AND ");
      //    }

      //    if (cobKategorie.Text != "")
      //    {
      //      sb.AppendFormat("Kunde.Kategorie = \'{0}\'", cobKategorie.Text);
      //    }

      //    String query = sb.ToString();

      //    String j = query.Substring(query.Length - 4, 3);

      //    if (j == "AND")
      //    {
      //      query = query.Substring(0, query.Length - 5);
      //    }

      //    Func.FUebersicht.LastCustomerSearchQuery = query;

      //    try
      //    {
      //      using (var sqlconnection = new SqlConnection(Settings.Default.NorkaConnectionString))
      //      {
      //        var command = new SqlCommand(query, sqlconnection);
      //        var adapter = new SqlDataAdapter(command);
      //        var table = new DataTable();
      //        Func.FUebersicht.slKunde.Text = string.Format("{0} Datensätze gefunden.", adapter.Fill(table));
      //        Func.FUebersicht.dgrKunden.Columns.Clear();
      //        Func.FUebersicht.dgrKunden.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Markieren" });
      //        Func.FUebersicht.dgrKunden.DataSource = table;
      //      }
      //    }
      //    catch (Exception ex)
      //    {
      //      MessageBox.Show(ex.ToString());
      //    }
      //  }
      //}
    }


    /// <summary>
    /// Überprüft die Eingabe der Kunden-Nr auf nummerische Werte.
    /// </summary>
    /// <returns>Flag - ob Kunden-Nr nummerisch ist oder nicht</returns>
    private bool ValidateKundenNr()
    {
      bool status = false;

      if (tbxKundenNr.TextLength > 0 & !Func.IsNumeric(tbxKundenNr.Text, true))
      {
        epKundenNr.SetError(tbxKundenNr, "Die Kunden-Nr darf nur nummerische Werte enthalten.");
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
      tbxKundenNr.Clear();
      tbxMatchcode.Clear();
      tbxName.Clear();
      tbxOrt.Clear();
      tbxPLZ.Clear();
      cobKategorie.Text = "";
      cbxGesperrt.CheckState = CheckState.Indeterminate;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      SearchKunden();
    }

    private void tbxKundenNr_Validating(object sender, CancelEventArgs e)
    {
      ValidateKundenNr();
    }

    private void tbxKundenNr_KeyDown(object sender, KeyEventArgs e)
    {
      KeyPreview = true;

      if ((Func.IsNumeric(tbxKundenNr.Text, true)) || (tbxKundenNr.Text == ""))
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

    private void tbxName_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxPLZ_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxMatchcode_KeyDown(object sender, KeyEventArgs e)
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

    private void tbxOrt_KeyDown(object sender, KeyEventArgs e)
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
          btnOK.PerformClick();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message.ToString());
      }
    }

    private void tbxKundenNr_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxKundenNr.SelectAll();
      });
    }

    private void tbxName_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxName.SelectAll();
      });
    }

    private void tbxPLZ_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxPLZ.SelectAll();
      });
    }

    private void tbxMatchcode_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxMatchcode.SelectAll();
      });
    }

    private void tbxOrt_Enter(object sender, EventArgs e)
    {
      this.BeginInvoke((MethodInvoker)delegate()
      {
        tbxOrt.SelectAll();
      });
    }

    #endregion

















  }
}
