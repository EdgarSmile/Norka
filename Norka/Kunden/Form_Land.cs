using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace Norka.Kunden
{
  using Func;

  public partial class Form_Land : Form
  {
    public Form_Land()
    {
      InitializeComponent();
    }

    private void Land_Load(object sender, EventArgs e)
    {
      
      this.landTableAdapter.Fill(this.dsLand.Land);
    
      
      // Deutschland wird vorausgew‰hlt
      lbxLand.SelectedValue = "de";
    }

    private void btnUebernehmen_Click(object sender, EventArgs e)
    {
      // ‹bernahme des ausgew‰hlten Landes.
      // Der ausgew‰hlte Wert wird in Groﬂbuchstaben umgewandelt.
      Func.FKunde.tbxLand.Text = lbxLand.SelectedValue.ToString().ToUpper();
      //this.Close();
    }

   
  }
}