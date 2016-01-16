using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Norka.Lager
{
  using Func;
  
  public partial class Form_Lager_Ansicht : Form
  {
   
    public Form_Lager_Ansicht()
    {
      InitializeComponent();
    }

    private void Form_Lager_Ansicht_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsKategorieFilter.Lagerkategorie". Sie können sie bei Bedarf verschieben oder entfernen.
      this.lagerkategorieTableAdapter.Fill(this.dsKategorieFilter.Lagerkategorie);

      cbxKategorie.SelectedIndex = 0;
    }

    private void rdbKunde_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbKunde.Checked)
      {
        ntbxProzent.Visible = true;
        lblZuschlag.Visible = true;
        lblEingabemodus.Visible = false;
      }
    }

    private void rdbLager_CheckedChanged(object sender, EventArgs e)
    {
      if (rdbLager.Checked)
      {
        ntbxProzent.Visible = false;
        lblZuschlag.Visible = false;

        lblEingabemodus.Visible = cbxKategorie.SelectedIndex == 0; 
      }
    }

    private void openLagerForm(string type, double prozent, int kategorie)
    {
      // 0 = Lager
      // 1 = Kunde
      switch (type)
      {
        case "LAGER":
          if (Func.FLager == null)
          {
            Func.FLager = new Form_Lager(type,prozent,kategorie);
            Func.FLager.MdiParent = Func.FStart;
          }
          break;

        case "KUNDE":
          if (Func.FLager == null)
          {
            Func.FLager = new Form_Lager(type, prozent, kategorie);
            Func.FLager.MdiParent = Func.FStart;
          }
          break;
      }


      Func.FLager.Show();
      Func.FLager.WindowState = FormWindowState.Maximized;

    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (rdbKunde.Checked)
      {
        ntbxProzent.Visible = true;
        openLagerForm("KUNDE",ntbxProzent.DoubleValue ,cbxKategorie.SelectedIndex);
      }
      else
      {
        ntbxProzent.Visible = false;
        openLagerForm("LAGER",0.0,cbxKategorie.SelectedIndex);
      }

      this.Close();
      Func.FLagerAnsicht = null;
    }

    private void ntbxProzent_Validating(object sender, CancelEventArgs e)
    {
      if (ntbxProzent.Text.Trim() == "")
      {
        ntbxProzent.Text = "0";
      }
    }

    private void cbxKategorie_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cbxKategorie.SelectedIndex == 0 && rdbLager.Checked)
      {
        lblEingabemodus.Visible = true;
      }
      else
      {
        lblEingabemodus.Visible = false;
      }
    }

   


  }
}
