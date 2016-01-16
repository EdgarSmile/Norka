using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Norka.DB;
using Norka.Reports;
using SortOrder = System.Windows.Forms.SortOrder;

namespace Norka.Lager
{
  using Func;

  public partial class Form_Lager : Form
  {

    #region Variablen

    private double currentCellValueStk;
    private double currentCellValueEk;
    private double zuschlagProzent;
    private int kategorie;
    private string ansicht;

    #endregion


    #region Kontruktoren

    /// <summary>
    /// Erstellt eine neue Instanz der <see cref="Form_Lager"/> Klasse.
    /// </summary>
    public Form_Lager()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Erstellt eine neue Instanz der <see cref="Form_Lager"/> Klasse.
    /// </summary>
    public Form_Lager(string pAnsicht, double pZuschlagProzent, int pKategorie)
    {
      InitializeComponent();
      zuschlagProzent = pZuschlagProzent;
      kategorie = pKategorie;
      ansicht = pAnsicht;

      if (ansicht == "KUNDE")
      {
        tsItemZeileLoeschen.Enabled = false;
        tsNeueZeile.Enabled = false;
        dgrLager.ReadOnly = true;
      }

      if (kategorie != 0)
      {
        tsItemZeileLoeschen.Enabled = false;
        tsNeueZeile.Enabled = false;
        dgrLager.ReadOnly = true;
      }
    }

    #endregion



    #region Methoden

    private void CreateColumns()
    {
      var columnNr = new DataGridViewTextBoxColumn();
      columnNr.HeaderText = "Nr";
      columnNr.Name = "Nr";
      columnNr.Width = 50;
      columnNr.ReadOnly = true;
      columnNr.SortMode = DataGridViewColumnSortMode.NotSortable;

      var columnBezeichnung = new DataGridViewTextBoxColumn();
      columnBezeichnung.HeaderText = "Bezeichnung";
      columnBezeichnung.Name = "Bezeichnung";
      columnBezeichnung.Width = 250;
      columnBezeichnung.SortMode = DataGridViewColumnSortMode.NotSortable;

      var columnKategorie = new DataGridViewComboBoxColumn();
      columnKategorie.DataSource = lagerkategorieBindingSource;
      columnKategorie.DisplayMember = "Bezeichnung";
      columnKategorie.ValueMember = "ID";
      columnKategorie.HeaderText = "Kategorie";
      columnKategorie.Name = "Kategorie";
      columnKategorie.Width = 150;
      columnKategorie.SortMode = DataGridViewColumnSortMode.NotSortable;

      var columnFaktor = new DataGridViewTextBoxColumn();
      columnFaktor.HeaderText = "Faktor";
      columnFaktor.Name = "Faktor";
      columnFaktor.Width = 50;
      columnFaktor.SortMode = DataGridViewColumnSortMode.NotSortable;
      columnFaktor.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

      var columnEinheit = new DataGridViewComboBoxColumn();
      columnEinheit.DataSource = lagereinheitBindingSource;
      columnEinheit.DisplayMember = "Bezeichnung";
      columnEinheit.ValueMember = "ID";
      columnEinheit.HeaderText = "Einheit";
      columnEinheit.Name = "Einheit";
      columnEinheit.SortMode = DataGridViewColumnSortMode.NotSortable;

      var columnStk = new DataGridViewTextBoxColumn();
      columnStk.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n2" };
      columnStk.HeaderText = "Anzahl";
      columnStk.Name = "Anzahl";
      columnStk.SortMode = DataGridViewColumnSortMode.NotSortable;

      var columnEk = new DataGridViewTextBoxColumn();
      columnEk.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleRight, Font = new Font(new Font("verdana", 8), FontStyle.Bold), Format = "n2" };
      columnEk.HeaderText = "EK";
      columnEk.Name = "EK";
      columnEk.SortMode = DataGridViewColumnSortMode.NotSortable;

      var columnBetrag = new DataGridViewTextBoxColumn();
      columnBetrag.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "n2" };
      columnBetrag.HeaderText = "Betrag";
      columnBetrag.Name = "Betrag";
      columnBetrag.ReadOnly = true;
      columnBetrag.SortMode = DataGridViewColumnSortMode.NotSortable;

      // Add Columns 
      dgrLager.Columns.Add(columnNr);
      dgrLager.Columns.Add(columnBezeichnung);
      dgrLager.Columns.Add(columnKategorie);
      dgrLager.Columns.Add(columnEinheit);
      dgrLager.Columns.Add(columnFaktor);
      dgrLager.Columns.Add(columnStk);
      dgrLager.Columns.Add(columnEk);
      dgrLager.Columns.Add(columnBetrag);
    }

    private void LoadRowsFromDatabase(int KategorieFilter, double pZuschlagProzent)
    {
      using (DataBaseDataContext dbContext = new DataBaseDataContext())
      {
        IQueryable<DB.Lager> x;

        if (KategorieFilter != 0)
        {
          x = dbContext.Lager.Where(l => l.Kategorie.Equals(KategorieFilter));
        }
        else
        {
          x = dbContext.Lager.Select(s => s);
        }

        foreach (var lager in x)
        {
          // Neue Zeile erzeugen
          var dataGridRow = new DataGridViewRow();

          // Zellen erzeugen
          var cellNr = new DataGridViewTextBoxCell();
          var cellBezeichnung = new DataGridViewTextBoxCell();
          var cellEinheit = new DataGridViewComboBoxCell();
          var cellKategorie = new DataGridViewComboBoxCell();
          var cellFaktor = new DataGridViewTextBoxCell();
          var cellAnzahl = new DataGridViewTextBoxCell();
          var cellEk = new DataGridViewTextBoxCell();
          var cellBetrag = new DataGridViewTextBoxCell();

          // Zellen in die Zeile einfeügen
          dataGridRow.Cells.Add(cellNr);
          dataGridRow.Cells.Add(cellBezeichnung);
          dataGridRow.Cells.Add(cellKategorie);
          dataGridRow.Cells.Add(cellEinheit);
          dataGridRow.Cells.Add(cellFaktor);
          dataGridRow.Cells.Add(cellAnzahl);
          dataGridRow.Cells.Add(cellEk);
          dataGridRow.Cells.Add(cellBetrag);

          // Zelle (Bezeichnung)
          cellBezeichnung.Value = lager.Bezeichnung;

          // Zelle (Einheit)
          cellEinheit.DataSource = lagereinheitBindingSource;
          cellEinheit.DisplayMember = "Bezeichnung";
          cellEinheit.ValueMember = "ID";
          cellEinheit.Value = lager.Einheit;

          // Zelle (Faktor)
          cellFaktor.Value = lager.Faktor;

          // Zelle (Kategorie)
          cellKategorie.DataSource = lagerkategorieBindingSource;
          cellKategorie.DisplayMember = "Bezeichnung";
          cellKategorie.ValueMember = "ID";
          cellKategorie.Value = lager.Kategorie;
     

          // Zelle (Stk)
          cellAnzahl.Value = lager.Stk;

          // Zelle (Ek)
          if (zuschlagProzent == 0.0)
          {
            cellEk.Value = lager.EK;
          }
          else
          {
            // EK um eingegebenen Prozentsatz erhöhen
            cellEk.Value = lager.EK + (lager.EK / 100) * pZuschlagProzent;
          }

          // Zelle (Betrag)
          cellBetrag.Value = lager.Stk * (Convert.ToDouble(cellEk.Value)/ Convert.ToDouble(cellFaktor.Value));

          // Zeile ins Grid einfügen
          dgrLager.Rows.Add(dataGridRow);

          // Neue Positonsnummern vergeben
          ReNumberPos();
        }
      }
    }

    private void SaveRowsInDatabase()
    {
      using (var dbContext = new DataBaseDataContext())
      {
        try
        {
          for (int i = 0; i <= dgrLager.Rows.Count - 2; i++)
          {
            DB.Lager lager = new DB.Lager();

            lager.Bezeichnung = dgrLager.Rows[i].Cells["Bezeichnung"].Value != null ? dgrLager.Rows[i].Cells["Bezeichnung"].Value.ToString() : "";
            lager.Einheit = dgrLager.Rows[i].Cells["Einheit"].Value != null ? Convert.ToInt32(dgrLager.Rows[i].Cells["Einheit"].Value) : (int?)null;
            lager.Faktor = Convert.ToInt32(dgrLager.Rows[i].Cells["Faktor"].Value) != 0 ? Convert.ToInt32(dgrLager.Rows[i].Cells["Faktor"].Value) : 1;
            lager.Kategorie = dgrLager.Rows[i].Cells["Kategorie"].Value != null ? Convert.ToInt32(dgrLager.Rows[i].Cells["Kategorie"].Value) : (int?)null;
            lager.Stk = dgrLager.Rows[i].Cells["Anzahl"].Value != null ? Convert.ToDouble(dgrLager.Rows[i].Cells["Anzahl"].Value) : 0.0;
            lager.EK = dgrLager.Rows[i].Cells["EK"].Value != null ? Convert.ToDouble(dgrLager.Rows[i].Cells["EK"].Value) : 0.0;

            dbContext.Lager.InsertOnSubmit(lager);
          }

          dbContext.ExecuteCommand("TRUNCATE TABLE Lager");

          dbContext.SubmitChanges();
          //MessageBox.Show("DB-Update erfolgt.");
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }

      // Summengrid aktualisieren
      this.SummenTableAdapter.Fill(this.dsSummen1.Summen);
    }

    /// <summary>
    /// Nummeriert alle Zeile im DataGrid neu durch.
    /// </summary>
    private void ReNumberPos()
    {
      int i = 1;

      foreach (DataGridViewRow row in dgrLager.Rows)
      {
        row.Cells["Nr"].Value = i;
        i++;
      }
    }

    /// <summary>
    /// Berechnet für die aktuelle Zeile im Grid den Betrag.
    /// </summary>
    private void CaclBetragForCurrentRow()
    {
      if (dgrLager.CurrentRow != null)
      {
        var row = dgrLager.CurrentRow;    
        
       
          row.Cells["Betrag"].Value = Convert.ToDouble(row.Cells["Anzahl"].Value) * (Convert.ToDouble(row.Cells["EK"].Value) / (Convert.ToInt32(row.Cells["Faktor"].Value) != 0 ? Convert.ToInt32(row.Cells["Faktor"].Value) : 1) );
        
        
      }
    }


    #endregion


    #region Events

    private void tsItemZeileLoeschen_Click(object sender, EventArgs e)
    {
      try
      {
        DialogResult result = MessageBox.Show("Möchten Sie diese Zeile wirklich löschen?", "Zeile löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

        if (result == DialogResult.Yes)
        {
          if (dgrLager.CurrentRow != null)
          {
            dgrLager.Rows.RemoveAt(dgrLager.CurrentRow.Index);
            ReNumberPos();
            SaveRowsInDatabase();
          }
        }

      }
      catch (InvalidOperationException ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void dgrLager_CellEnter(object sender, DataGridViewCellEventArgs e)
    {
      int colIndexStk = dgrLager.Columns.IndexOf(dgrLager.Columns["Anzahl"]);
      int colIndexEk = dgrLager.Columns.IndexOf(dgrLager.Columns["Ek"]);

      if (dgrLager.CurrentRow != null)
      {
        var cellStkOfCurrRow = dgrLager.CurrentRow.Cells["Anzahl"];
        var cellEkOfCurrRow = dgrLager.CurrentRow.Cells["Ek"];

        try
        {
          if (e.ColumnIndex == colIndexStk && Func.IsNumeric(Convert.ToDouble(cellStkOfCurrRow.Value), true))
          {
            // Wenn in der Zelle "0" eingegeben wird, dann muss intern als currentValue "-1.0" gespeichert werden. 
            // Ansonsten läuft die Prüfung in der Methoe dgrLager_CellEndEdit immer ins Leere.
            currentCellValueStk = Convert.ToDouble(cellStkOfCurrRow.Value) == -1.0 ? 1 : Convert.ToDouble(cellStkOfCurrRow.Value);
          }
          else if (e.ColumnIndex == colIndexEk && Func.IsNumeric(Convert.ToDouble(cellEkOfCurrRow.Value), true))
          {
            // Wenn in der Zelle "0" eingegeben wird, dann muss intern als currentValue "-1.0" gespeichert werden. 
            // Ansonsten läuft die Prüfung in der Methoe dgrLager_CellEndEdit immer ins Leere.
            currentCellValueEk = Convert.ToDouble(cellEkOfCurrRow.Value) == -1.0 ? 1 : Convert.ToDouble(cellEkOfCurrRow.Value);
          }
        }
        catch (Exception ex)
        {
          //MessageBox.Show(ex.Message, "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

      }
    }

    private void dgrLager_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        if (dgrLager.CurrentRow != null)
        {
          var cellStkOfCurrRow = dgrLager.CurrentRow.Cells["Anzahl"];
          var cellEkOfCurrRow = dgrLager.CurrentRow.Cells["Ek"];

          int curCellColIndex = dgrLager.CurrentCell.ColumnIndex;
          int colIndexStk = dgrLager.Columns.IndexOf(dgrLager.Columns["Anzahl"]);
          int colIndexEk = dgrLager.Columns.IndexOf(dgrLager.Columns["Ek"]);
          int colIndexFaktor = dgrLager.Columns.IndexOf(dgrLager.Columns["Faktor"]);

          try
          {
            if (
          (curCellColIndex == colIndexStk) && Func.IsNumeric(dgrLager.CurrentCell.Value, false) && Func.IsNumeric(cellEkOfCurrRow.Value, false) && Convert.ToDouble(dgrLager.CurrentCell.Value) != currentCellValueStk
          || (curCellColIndex == colIndexEk) && Func.IsNumeric(dgrLager.CurrentCell.Value, false) && Func.IsNumeric(cellStkOfCurrRow.Value, false) && Convert.ToDouble(dgrLager.CurrentCell.Value) != currentCellValueEk
          || (curCellColIndex == colIndexFaktor) && Func.IsNumeric(dgrLager.CurrentCell.Value, false) && Func.IsNumeric(cellStkOfCurrRow.Value, false) && Convert.ToDouble(dgrLager.CurrentCell.Value) != currentCellValueEk
          )
            {
              CaclBetragForCurrentRow();
              cellStkOfCurrRow.Value = double.Parse(Convert.ToDouble(cellStkOfCurrRow.Value).ToString("####0.00"));
              cellEkOfCurrRow.Value = double.Parse(Convert.ToDouble(cellEkOfCurrRow.Value).ToString("#####0.00"));


            }
            ReNumberPos();
            SaveRowsInDatabase();            
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          }
        }


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }



    private void tsNeueZeile_Click(object sender, EventArgs e)
    {
      try
      {
        if (dgrLager.CurrentRow != null)
        {
          dgrLager.Rows.Insert(dgrLager.CurrentRow.Index, 1);
          ReNumberPos();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void tsItemKundeUebersichtSchließen_Click(object sender, System.EventArgs e)
    {
      this.Close();
      Func.FLager = null;
    }

    private void Form_Lager_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsKategorieFilter.Lagerkategorie". Sie können sie bei Bedarf verschieben oder entfernen.
      this.lagerkategorieTableAdapter1.Fill(this.dsKategorieFilter.Lagerkategorie);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsSummen.DataTable1". Sie können sie bei Bedarf verschieben oder entfernen.
      this.SummenTableAdapter.Fill(this.dsSummen1.Summen);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsLagereinheit.Lagereinheit". Sie können sie bei Bedarf verschieben oder entfernen.
      this.lagereinheitTableAdapter.Fill(this.dsLagereinheit.Lagereinheit);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsLagerkategorie.Lagerkategorie". Sie können sie bei Bedarf verschieben oder entfernen.
      this.lagerkategorieTableAdapter.Fill(this.dsLagerkategorie.Lagerkategorie);
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsLager.Lager". Sie können sie bei Bedarf verschieben oder entfernen.
      //this.lagerTableAdapter.Fill(this.dsLager.Lager);

      // Wenn die Kundenansicht ausgewählt wurde, dann sollen die Summenbeträge nicht angezeigt werden.
      if (ansicht == "KUNDE")
      {
        splitContainer1.Panel2Collapsed = true;
      }

      CreateColumns();

      LoadRowsFromDatabase(kategorie, zuschlagProzent);
    }

    private void tsItemDrucken_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      var report = ReportManager.GetReportByName(EReports.Inventurliste);

      var r = new Form_Report(report);
      r.Show();
      r.Refresh();
      this.Cursor = Cursors.Default;
    }

    private void dgrLager_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
      if (ansicht != "KUNDE" && kategorie == 0)
      {
        tsItemZeileLoeschen.Enabled = true;
      }
      else
      {
        tsItemZeileLoeschen.Enabled = false;
        tsNeueZeile.Enabled = false;
      }
    }

    private void dgrLager_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
      if (ansicht != "KUNDE" && kategorie == 0)
      {
        tsItemZeileLoeschen.Enabled = true;
      }
      else
      {
        tsItemZeileLoeschen.Enabled = false;
        tsNeueZeile.Enabled = false;
      }
    }

    #endregion










  }
}