using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Norka.DB;

namespace Norka.Kunden
{
  using Func;
  public partial class Form_Kunde_MiniAuswahl : Form
  {
    private bool isAuftrag;
    public Form_Kunde_MiniAuswahl()
    {
      InitializeComponent();
    }

    public Form_Kunde_MiniAuswahl(IQueryable auswahl, bool flagAuftrag)
    {
      InitializeComponent();

      if (flagAuftrag)
      {
        isAuftrag = true;
      }
      else
      {
        isAuftrag = false;
      }
      dgrKundenMini.DataSource = auswahl;
      
    }

    private void dgrKundenMini_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      DataGridViewRow row = dgrKundenMini.CurrentRow;

      if (isAuftrag)
      {
        Func.FAuftrag.tbxKdNummer.Text = row.Cells["KundeID"].Value.ToString();
      }
      else
      {
        Func.FAngebot.tbxKdNummer.Text = row.Cells["KundeID"].Value.ToString();
      }
      
      this.Dispose();
    }
  }
}
