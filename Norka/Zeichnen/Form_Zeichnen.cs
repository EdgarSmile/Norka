using System;
using System.Drawing;
using System.Windows.Forms;
using Norka.Reports;
using Norka.DB;

namespace Norka.Zeichnen
{

  public partial class Form_Zeichnen : Form
  {
    #region Variables

    /// <summary>
    /// Diese Variable speichert den gewählten Vorderwandtypen.
    /// Dieser Wert wird beim Speichern verwendet.
    /// </summary>
    private int _vorderwandTyp;

    /// <summary>
    /// Diese Variable speichert den gewählten Sonderkabinentyp.
    /// Dieser Wert wird beim Speichern verwendet.
    /// </summary>
    private int _sonderkabinenTyp;

    private string _schamwandArtikel;

    private string _schildOrTrennwand;

    private Zeichenparameter _zeichenparameter;

    #endregion

    #region Constructors

    public Form_Zeichnen()
    {
      InitializeComponent();
      // Aktuelle Zeichenparameter aus DB holen.
      _zeichenparameter = DBManager.GetZeichenparameter();
    }

    #endregion

    #region Events

    #region lbxPositionen

    private void lbxPositionen_SelectedIndexChanged(object sender, EventArgs e)
    {
      // Index des selektierten Items merken
      int index = lbxPositionen.SelectedIndex;

      if (lbxPositionen.SelectedItems.Count > 0)
      {
        lbxPositionen.BeginUpdate();

        btnSeitenUmbr.Enabled = true;

        lbxPositionen.EndUpdate();
      }
    }

    private void lbxPositionen_MouseClick(object sender, MouseEventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        // Löschen der Controls auf dem Draw-Panel
        pnlDraw.Controls.Clear();

        lblMaße.Text = ((IPosition)lbxPositionen.SelectedItem).AsString();

        // Neues Zeichnen des Draw-Panles erzwingen.
        // Die hiermit aufgerufene Paint-Methode des pnlDraw erledigt das Zeichnen sowie das Schreiben der Werte in die Labels
        pnlDraw.Refresh();

        // Je nach Typ des selektierten Items wird der entsprechende Tab gewählt und die Werte des Item-Objekts in die Controls geschrieben.
        if (lbxPositionen.SelectedItem.GetType() == typeof(Text))
        {
          tabControl1.SelectTab(tabText);
          tbxText.Text = ((Text)lbxPositionen.SelectedItem).Beschreibung;
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand))
        {
          tabControl1.SelectTab(tabVW);

          SetDisabledColorForPanelsVW();
          EnableControlsVW();

          if (((Vorderwand)lbxPositionen.SelectedItem).Typ == 10)
          {
            pnlV10.BackColor = Color.FromArgb(255, 255, 192);
          }
          else if (((Vorderwand)lbxPositionen.SelectedItem).Typ == 11)
          {
            pnlV11.BackColor = Color.FromArgb(255, 255, 192);
          }
          else if (((Vorderwand)lbxPositionen.SelectedItem).Typ == 12)
          {
            pnlV12.BackColor = Color.FromArgb(255, 255, 192);
          }
          else if (((Vorderwand)lbxPositionen.SelectedItem).Typ == 13)
          {
            pnlV13.BackColor = Color.FromArgb(255, 255, 192);
          }

          tbxVWBreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Breite.ToString();
          tbxVWHoehe.Text = ((Vorderwand)lbxPositionen.SelectedItem).Hoehe.ToString();
          tbxVWBodenfreiheit.Text = ((Vorderwand)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();
          tbxVWTuer.Text = ((Vorderwand)lbxPositionen.SelectedItem).Tuerbreite.ToString();

          if (((Vorderwand)lbxPositionen.SelectedItem).U == _zeichenparameter.GrossesU)
          {
            rdbVWUGroß.Checked = true;
          }
          else
          {
            rdbVWUKlein.Checked = true;
          }

          tbxVWSchildLinks.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildlinks.ToString();
          tbxVWSchildRechts.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildrechts.ToString();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Reihenkabine))
        {
          tabControl1.SelectTab(tabRK);

          tbxRKBreite.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Breite.ToString();
          tbxRKHoehe.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Hoehe.ToString();
          tbxRKBodenfreiheit.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();
          tbxRKTuer.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Tuerbreite.ToString();
          tbxRKStkTuer.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Tueranzahl.ToString();

          if (((Reihenkabine)lbxPositionen.SelectedItem).U == _zeichenparameter.GrossesU)
          {
            rdbRKUGross.Checked = true;
          }
          else
          {
            rdbRKUKlein.Checked = true;
          }

          tbxRKTrennwand.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Trennwand.ToString();
          tbxRKSchildLinks.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Schildlinks.ToString();
          tbxRKSchildRechts.Text = ((Reihenkabine)lbxPositionen.SelectedItem).Schildrechts.ToString();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Eckkabine))
        {
          tabControl1.SelectTab(tabEK);

          SetDisabledColorForPanelsEck();
          EnableControlsEck();

          if (((Eckkabine)lbxPositionen.SelectedItem).Artikel == "Eckk. L")
          {
            pnlEckLinks.BackColor = Color.FromArgb(255, 255, 192);
          }
          else if (((Eckkabine)lbxPositionen.SelectedItem).Artikel == "Eckk. R")
          {
            pnlEckRechts.BackColor = Color.FromArgb(255, 255, 192);
          }
          else if (((Eckkabine)lbxPositionen.SelectedItem).Artikel == "Eckk. einzel L")
          {
            pnlEckEinzelLinks.BackColor = Color.FromArgb(255, 255, 192);
            tbxEckStkTuer.Enabled = false;
          }
          else if (((Eckkabine)lbxPositionen.SelectedItem).Artikel == "Eckk. einzel R")
          {
            pnlEckEinzelRechts.BackColor = Color.FromArgb(255, 255, 192);
            tbxEckStkTuer.Enabled = false;
          }

          tbxEckBreite.Text = ((Eckkabine)lbxPositionen.SelectedItem).Breite.ToString();
          tbxEckHoehe.Text = ((Eckkabine)lbxPositionen.SelectedItem).Hoehe.ToString();
          tbxEckBodenfreiheit.Text = ((Eckkabine)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();
          tbxEckTuer.Text = ((Eckkabine)lbxPositionen.SelectedItem).Tuerbreite.ToString();
          tbxEckStkTuer.Text = ((Eckkabine)lbxPositionen.SelectedItem).Tueranzahl.ToString();

          if (((Eckkabine)lbxPositionen.SelectedItem).U == _zeichenparameter.GrossesU)
          {
            rdbEckUGross.Checked = true;
          }
          else
          {
            rdbEckUKlein.Checked = true;
          }

          tbxEckTrennwand.Text = ((Eckkabine)lbxPositionen.SelectedItem).Trennwand.ToString();
          tbxEckSchildWand.Text = ((Eckkabine)lbxPositionen.SelectedItem).Schildwand.ToString();
          tbxEckSchildEck.Text = ((Eckkabine)lbxPositionen.SelectedItem).Schildeck.ToString();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine))
        {
          tabControl1.SelectTab(tabSK);

          SetDisabledColorForPanelsSK();
          EnableControlsSK();

          if (((Sonderkabine)lbxPositionen.SelectedItem).Typ == 1)
          {
            pnlSK1.BackColor = Color.FromArgb(255, 255, 192);
            tbxSKMittelschildR.Text = "0";
            tbxSKMittelschildR.Enabled = false;
            tbxSKStkTuer.Enabled = false;
            lblEckSchild.Text = "E-Schild";
            lblWandSchild.Text = "W-Schild";
            tbxSKBreite.Focus();
          }
          else if (((Sonderkabine)lbxPositionen.SelectedItem).Typ == 2)
          {
            pnlSK2.BackColor = Color.FromArgb(255, 255, 192);
            tbxSKMittelschildR.Text = "0";
            tbxSKMittelschildR.Enabled = false;
            tbxSKStkTuer.Enabled = false;
            lblEckSchild.Text = "E-Schild";
            lblWandSchild.Text = "W-Schild";
            tbxSKBreite.Focus();
          }
          else if (((Sonderkabine)lbxPositionen.SelectedItem).Typ == 3)
          {
            pnlSK3.BackColor = Color.FromArgb(255, 255, 192);
            tbxSKMittelschildR.Text = "0";
            tbxSKMittelschildR.Enabled = false;
            tbxSKStkTuer.Enabled = false;
            lblEckSchild.Text = "W-Schild R";
            lblWandSchild.Text = "W-Schild L";
          }
          else if (((Sonderkabine)lbxPositionen.SelectedItem).Typ == 4)
          {
            pnlSK4.BackColor = Color.FromArgb(255, 255, 192);
            tbxSKMittelschildR.Text = "0";
            tbxSKMittelschildR.Enabled = false;
            tbxSKStkTuer.Enabled = false;
            lblEckSchild.Text = "W-Schild R";
            lblWandSchild.Text = "W-Schild L";

          }
          else if (((Sonderkabine)lbxPositionen.SelectedItem).Typ == 5)
          {
            pnlSK5.BackColor = Color.FromArgb(255, 255, 192);
            tbxSKMittelschildR.Text = "0";
            tbxSKMittelschildR.Enabled = false;
            tbxSKStkTuer.Enabled = false;
            lblEckSchild.Text = "W-Schild R";
            lblWandSchild.Text = "W-Schild L";
          }

          tbxSKBreite.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Breite.ToString();
          tbxSKHoehe.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Hoehe.ToString();
          tbxSKBodenfreiheit.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();
          tbxSKTuer.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Tuerbreite.ToString();
          tbxSKStkTuer.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Tueranzahl.ToString();

          if (((Sonderkabine)lbxPositionen.SelectedItem).U == _zeichenparameter.GrossesU)
          {
            rdbSKUGross.Checked = true;
          }
          else
          {
            rdbSKUklein.Checked = true;
          }

          tbxSKTrennwand.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Trennwand.ToString();
          tbxSKWandschild.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Schildwand.ToString();
          tbxSKMittelschildL.Text = ((Sonderkabine)lbxPositionen.SelectedItem).MittelschildL.ToString();
          tbxSKMittelschildR.Text = ((Sonderkabine)lbxPositionen.SelectedItem).MittelschildR.ToString();
          tbxSKEckschild.Text = ((Sonderkabine)lbxPositionen.SelectedItem).Schildeck.ToString();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Schamwand))
        {
          tabControl1.SelectTab(tabSW);

          SetDisabledColorForPanelsSW();
          EnableControlsSW();

          if (((Schamwand)lbxPositionen.SelectedItem).Artikel == "frei")
          {
            pnlSWFrei.BackColor = Color.FromArgb(255, 255, 192);

          }
          else if (((Schamwand)lbxPositionen.SelectedItem).Artikel == "fuss")
          {
            pnlSWFuss.BackColor = Color.FromArgb(255, 255, 192);
          }

          tbxSWStk.Text = ((Schamwand)lbxPositionen.SelectedItem).Stk.ToString();
          tbxSWBreite.Text = ((Schamwand)lbxPositionen.SelectedItem).Breite.ToString();
          tbxSWHoehe.Text = ((Schamwand)lbxPositionen.SelectedItem).Hoehe.ToString();
          tbxSWBodenfreiheit.Text = ((Schamwand)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Trennwand))
        {
          tabControl1.SelectTab(tabTRW);

          SetDisabledColorForPanelsST();
          EnableControlsST();

          pnlTrennwand.BackColor = Color.FromArgb(255, 255, 192);

          tbxSTStk.Text = ((Trennwand)lbxPositionen.SelectedItem).Stk.ToString();
          tbxSTHoeheBruestung.Text = ((Trennwand)lbxPositionen.SelectedItem).Brüstungshöhe.ToString();
          tbxSTHoehe.Text = ((Trennwand)lbxPositionen.SelectedItem).Hoehe.ToString();
          tbxSTBreiteSchild.Text = ((Trennwand)lbxPositionen.SelectedItem).Schildbreite.ToString();
          tbxSTBreiteAussp.Text = ((Trennwand)lbxPositionen.SelectedItem).Aussparungsbreite.ToString();
          tbxSTBodenfreiheit.Text = ((Trennwand)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Schild))
        {
          tabControl1.SelectTab(tabTRW);

          SetDisabledColorForPanelsST();
          EnableControlsST();

          if (((Schild)lbxPositionen.SelectedItem).Artikel == "schildLinks")
          {
            pnlSchildLinks.BackColor = Color.FromArgb(255, 255, 192);
          }
          else if (((Schild)lbxPositionen.SelectedItem).Artikel == "schildRechts")
          {
            pnlSchildRechts.BackColor = Color.FromArgb(255, 255, 192);
          }

          tbxSTStk.Text = ((Schild)lbxPositionen.SelectedItem).Stk.ToString();
          tbxSTHoeheBruestung.Text = ((Schild)lbxPositionen.SelectedItem).Brüstungshöhe.ToString();
          tbxSTHoehe.Text = ((Schild)lbxPositionen.SelectedItem).Hoehe.ToString();
          tbxSTBreiteSchild.Text = ((Schild)lbxPositionen.SelectedItem).Schildbreite.ToString();
          tbxSTBreiteAussp.Text = ((Schild)lbxPositionen.SelectedItem).Aussparungsbreite.ToString();
          tbxSTBodenfreiheit.Text = ((Schild)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();
        }

        else if ((lbxPositionen.SelectedItem.GetType() == typeof(Seitenumbruch)))
        {
          // Bei einem Seitenumbruch-Objekt werden sämtliche Controls in den Defaultzustand versetzt.
          Clear(false, true);
        }
      }
    }


    #endregion

    #region toolstrip

    private void btnNeu_Click(object sender, EventArgs e)
    {
      Clear(true, true);
    }

    private void btnPosDel_Click(object sender, EventArgs e)
    {
      // Index des selektierten Items merken
      int index = lbxPositionen.SelectedIndex;

      if (lbxPositionen.SelectedItems.Count > 0)
      {
        lbxPositionen.BeginUpdate();

        // Selektiertes Item löschen.
        lbxPositionen.Items.Remove(lbxPositionen.SelectedItem);

        lbxPositionen.EndUpdate();
      }

      // Sind noch Items in der Auflistung vorhanden?
      if (lbxPositionen.Items.Count > 0)
      {
        //lbxPositionen.BeginUpdate();

        //// War das gelöschte Item nicht das erste Item in der Auflistung?
        //if (index != 0)
        //{
        //  // Item markieren, das über dem gelöschten Item steht.
        //  lbxPositionen.SelectedItem = lbxPositionen.Items[index - 1];
        //}
        //else
        //{
        //  lbxPositionen.SelectedItem = lbxPositionen.Items[0];
        //}

        //lbxPositionen.EndUpdate();
      }
      else
      {
        btnSeitenUmbr.Enabled = false;
        btnPrint.Enabled = false;
        btnPosDel.Enabled = false;
        btnPosDown.Enabled = false;
        btnPosUp.Enabled = false;
      }
    }

    private void btnSeitenUmbr_Click(object sender, EventArgs e)
    {
      // Index des selektierten Items merken
      int index = lbxPositionen.SelectedIndex;

      lbxPositionen.Items.Insert(index + 1, new Seitenumbruch());
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;

      using (var dbContext = new DataBaseDataContext())
      {
        // Tabellinhalt löschen
        dbContext.ExecuteCommand("TRUNCATE TABLE Zeichnungsdruck");
        dbContext.SubmitChanges();

        Zeichnungsdruck printPosition = null;

        for (int i = 0; i < lbxPositionen.Items.Count; i++)
        {
          if (lbxPositionen.Items[i].GetType() == typeof(Seitenumbruch))
          {
            printPosition = new Zeichnungsdruck()
                              {
                                Artikel = "Seitenumbruch"
                              };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Text))
          {
            printPosition = new Zeichnungsdruck()
                              {
                                Artikel = "Text",
                                TEXT_Beschreibung = ((Text)lbxPositionen.Items[i]).Beschreibung
                              };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Vorderwand))
          {
            printPosition = new Zeichnungsdruck()
                              {
                                Artikel = "Vorderwand",
                                VW_Typ = ((Vorderwand)lbxPositionen.Items[i]).Typ,
                                VW_Breite = ((Vorderwand)lbxPositionen.Items[i]).Breite,
                                VW_Hoehe = ((Vorderwand)lbxPositionen.Items[i]).Hoehe,
                                VW_Bodenfreiheit = ((Vorderwand)lbxPositionen.Items[i]).Bodenfreiheit,
                                VW_Tuerbreite = ((Vorderwand)lbxPositionen.Items[i]).Tuerbreite,
                                VW_SchildLinks = ((Vorderwand)lbxPositionen.Items[i]).Schildlinks,
                                VW_SchildRechts = ((Vorderwand)lbxPositionen.Items[i]).Schildrechts,
                                VW_Schildhoehe = ((Vorderwand)lbxPositionen.Items[i]).Schildhoehe,
                                VW_Tuerhoehe = ((Vorderwand)lbxPositionen.Items[i]).Tuerhoehe,
                                VW_PlatteSchildLinks = ((Vorderwand)lbxPositionen.Items[i]).PlatteSchildLinks,
                                VW_PlatteSchildRechts = ((Vorderwand)lbxPositionen.Items[i]).PlatteSchildRechts,
                                VW_Verbindungsstueck = ((Vorderwand)lbxPositionen.Items[i]).Verbindungsstueck,
                                VW_Verstaerkung = ((Vorderwand)lbxPositionen.Items[i]).Verstaerkung,
                                VW_Tuere = ((Vorderwand)lbxPositionen.Items[i]).Tuere
                              };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Reihenkabine))
          {
            printPosition = new Zeichnungsdruck()
                              {
                                Artikel = "Reihenkabine",
                                RK_Typ = ((Reihenkabine)lbxPositionen.Items[i]).Typ,
                                RK_Breite = ((Reihenkabine)lbxPositionen.Items[i]).Breite,
                                RK_Hoehe = ((Reihenkabine)lbxPositionen.Items[i]).Hoehe,
                                RK_Bodenfreiheit = ((Reihenkabine)lbxPositionen.Items[i]).Bodenfreiheit,
                                RK_Tuerbreite = ((Reihenkabine)lbxPositionen.Items[i]).Tuerbreite,
                                RK_Tueranzahl = ((Reihenkabine)lbxPositionen.Items[i]).Tueranzahl,
                                RK_Trennwand = ((Reihenkabine)lbxPositionen.Items[i]).Trennwand,
                                RK_PlatteTrennwand = ((Reihenkabine)lbxPositionen.Items[i]).PlatteTrennwand,
                                RK_PlatteMittelschild = ((Reihenkabine)lbxPositionen.Items[i]).PlatteMittelschild,
                                RK_SchildLinks = ((Reihenkabine)lbxPositionen.Items[i]).Schildlinks,
                                RK_SchildRechts = ((Reihenkabine)lbxPositionen.Items[i]).Schildrechts,
                                RK_Schildhoehe = ((Reihenkabine)lbxPositionen.Items[i]).Schildhoehe,
                                RK_Tuerhoehe = ((Reihenkabine)lbxPositionen.Items[i]).Tuerhoehe,
                                RK_PlatteSchildLinks = ((Reihenkabine)lbxPositionen.Items[i]).PlatteSchildLinks,
                                RK_PlatteSchildRechts = ((Reihenkabine)lbxPositionen.Items[i]).PlatteSchildRechts,
                                RK_Mittelschild = ((Reihenkabine)lbxPositionen.Items[i]).Mittelschild,
                                RK_Tuere = ((Reihenkabine)lbxPositionen.Items[i]).Tuere,
                                RK_Aussen = ((Reihenkabine)lbxPositionen.Items[i]).Aussen,
                                RK_Alu = ((Reihenkabine)lbxPositionen.Items[i]).Alu,
                                RK_Verbindungsstueck = ((Reihenkabine)lbxPositionen.Items[i]).Verbindungsstueck
                              };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Eckkabine))
          {
            printPosition = new Zeichnungsdruck()
                              {
                                Artikel = ((Eckkabine)lbxPositionen.Items[i]).Artikel,
                                EK_Typ = ((Eckkabine)lbxPositionen.Items[i]).Typ,
                                EK_Breite = ((Eckkabine)lbxPositionen.Items[i]).Breite,
                                EK_Hohe = ((Eckkabine)lbxPositionen.Items[i]).Hoehe,
                                EK_Bodenfreiheit = ((Eckkabine)lbxPositionen.Items[i]).Bodenfreiheit,
                                EK_Tuerbreite = ((Eckkabine)lbxPositionen.Items[i]).Tuerbreite,
                                EK_Tueranzahl = ((Eckkabine)lbxPositionen.Items[i]).Tueranzahl,
                                EK_Trennwand = ((Eckkabine)lbxPositionen.Items[i]).Trennwand,
                                EK_Wandschild = ((Eckkabine)lbxPositionen.Items[i]).Schildwand,
                                EK_Eckschild = ((Eckkabine)lbxPositionen.Items[i]).Schildeck,
                                EK_SchildHoehe = ((Eckkabine)lbxPositionen.Items[i]).Schildhoehe,
                                EK_Tuerhoehe = ((Eckkabine)lbxPositionen.Items[i]).Tuerhoehe,
                                EK_Mittelschild = ((Eckkabine)lbxPositionen.Items[i]).Mittelschild,
                                EK_Tuer = ((Eckkabine)lbxPositionen.Items[i]).Tuere,
                                EK_Plattetrennwand = ((Eckkabine)lbxPositionen.Items[i]).PlatteTrennwand,
                                EK_Plattewandschild = ((Eckkabine)lbxPositionen.Items[i]).PlatteSchildWand,
                                EK_Platteeckschild = ((Eckkabine)lbxPositionen.Items[i]).PlatteSchildEck,
                                EK_PlatteMittelschild = ((Eckkabine)lbxPositionen.Items[i]).PlatteMittelschild,
                                EK_Aussen = ((Eckkabine)lbxPositionen.Items[i]).Aussen,
                                EK_Alu = ((Eckkabine)lbxPositionen.Items[i]).Alu,
                                EK_Alueck = ((Eckkabine)lbxPositionen.Items[i]).AluEckTW,
                                EK_Verbindungsstueck = ((Eckkabine)lbxPositionen.Items[i]).Verbindungsstueck
                              };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Sonderkabine))
          {
            printPosition = new Zeichnungsdruck()
                              {
                                Artikel = "Sonderkabine",
                                SK_Typ = ((Sonderkabine)lbxPositionen.Items[i]).Typ,
                                SK_Breite = ((Sonderkabine)lbxPositionen.Items[i]).Breite,
                                SK_Hoehe = ((Sonderkabine)lbxPositionen.Items[i]).Hoehe,
                                SK_Bodenfreiheit = ((Sonderkabine)lbxPositionen.Items[i]).Bodenfreiheit,
                                SK_Tuerbreite = ((Sonderkabine)lbxPositionen.Items[i]).Tuerbreite,
                                SK_Tueranzahl = ((Sonderkabine)lbxPositionen.Items[i]).Tueranzahl,
                                SK_Trennwand = ((Sonderkabine)lbxPositionen.Items[i]).Trennwand,
                                SK_Wandschild = ((Sonderkabine)lbxPositionen.Items[i]).Schildwand,
                                SK_Eckschild = ((Sonderkabine)lbxPositionen.Items[i]).Schildeck,
                                SK_Schildhoehe = ((Sonderkabine)lbxPositionen.Items[i]).Schildhoehe,
                                SK_Tuerhoehe = ((Sonderkabine)lbxPositionen.Items[i]).Tuerhoehe,
                                SK_MittelschildLinks = ((Sonderkabine)lbxPositionen.Items[i]).MittelschildL,
                                SK_MittelschildRechts = ((Sonderkabine)lbxPositionen.Items[i]).MittelschildR,
                                SK_Tuer = ((Sonderkabine)lbxPositionen.Items[i]).Tuere,
                                SK_PlatteTrennwand = ((Sonderkabine)lbxPositionen.Items[i]).PlatteTrennwand,
                                SK_PlatteWandschild = ((Sonderkabine)lbxPositionen.Items[i]).PlatteSchildWand,
                                SK_PlatteEckschild = ((Sonderkabine)lbxPositionen.Items[i]).PlatteSchildEck,
                                SK_PlatteMittelschildLinks = ((Sonderkabine)lbxPositionen.Items[i]).PlatteMittelschildL,
                                SK_PlatteMittelschildRechts = ((Sonderkabine)lbxPositionen.Items[i]).PlatteMittelschildR,
                                SK_Aussen = ((Sonderkabine)lbxPositionen.Items[i]).Aussen,
                                SK_Alu = ((Sonderkabine)lbxPositionen.Items[i]).Alu,
                                SK_AluEck = ((Sonderkabine)lbxPositionen.Items[i]).AluEckTW,
                                SK_Verbindungsstueck = ((Sonderkabine)lbxPositionen.Items[i]).Verbindungsstueck
                              };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Schamwand))
          {
            printPosition = new Zeichnungsdruck()
            {
              Artikel = ((Schamwand)lbxPositionen.Items[i]).Artikel,
              SW_Bodenfreiheit = ((Schamwand)lbxPositionen.Items[i]).Bodenfreiheit,
              SW_Breite = ((Schamwand)lbxPositionen.Items[i]).Breite,
              SW_Hoehe = ((Schamwand)lbxPositionen.Items[i]).Hoehe,
              SW_PlatteBreite = ((Schamwand)lbxPositionen.Items[i]).PlatteBreite,
              SW_PlatteHoehe = ((Schamwand)lbxPositionen.Items[i]).PlatteHoehe,
              SW_Stk = ((Schamwand)lbxPositionen.Items[i]).Stk
            };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Trennwand))
          {
            printPosition = new Zeichnungsdruck()
            {
              Artikel = "trennwand",
              TW_Bodenfreiheit = ((Trennwand)lbxPositionen.Items[i]).Bodenfreiheit,
              TW_BreiteSchild = ((Trennwand)lbxPositionen.Items[i]).Schildbreite,
              TW_AluAussp = ((Trennwand)lbxPositionen.Items[i]).AluAussparung,
              TW_AluETW = ((Trennwand)lbxPositionen.Items[i]).AluETW,
              TW_AluTrennwand = ((Trennwand)lbxPositionen.Items[i]).AluTrennwand,
              TW_Stk = ((Trennwand)lbxPositionen.Items[i]).Stk,
              TW_BreiteAussp = ((Trennwand)lbxPositionen.Items[i]).Aussparungsbreite,
              TW_Bruestungshoehe = ((Trennwand)lbxPositionen.Items[i]).Brüstungshöhe,
              TW_Hoehe = ((Trennwand)lbxPositionen.Items[i]).Hoehe,
              TW_HoeheAussp = ((Trennwand)lbxPositionen.Items[i]).HöheAussparung,
              TW_PlatteBreiteAussp = ((Trennwand)lbxPositionen.Items[i]).PlatteAussparungBreite,
              TW_PlatteBreiteSchild = ((Trennwand)lbxPositionen.Items[i]).PlatteSchildBreite,
              TW_PlatteHoeheAussp = ((Trennwand)lbxPositionen.Items[i]).PlatteAussparungHöhe,
              TW_PlatteHoeheSchild = ((Trennwand)lbxPositionen.Items[i]).PlatteSchildHoehe
            };
          }
          else if (lbxPositionen.Items[i].GetType() == typeof(Schild))
          {
            printPosition = new Zeichnungsdruck()
                              {
                                Artikel = ((Schild)lbxPositionen.Items[i]).Artikel == "schildLinks" ? "schildLinks" : "schildRechts",
                                Schild_Bodenfreiheit = ((Schild)lbxPositionen.Items[i]).Bodenfreiheit,
                                Schild_BreiteSchild = ((Schild)lbxPositionen.Items[i]).Schildbreite,
                                Schild_AluAussp = ((Schild)lbxPositionen.Items[i]).AluAussparung,
                                Schild_Stk = ((Schild)lbxPositionen.Items[i]).Stk,
                                Schild_BreiteAussp = ((Schild)lbxPositionen.Items[i]).Aussparungsbreite,
                                Schild_Bruestungshoehe = ((Schild)lbxPositionen.Items[i]).Brüstungshöhe,
                                Schild_Hoehe = ((Schild)lbxPositionen.Items[i]).Hoehe,
                                Schild_HoeheAussp = ((Schild)lbxPositionen.Items[i]).HöheAussparung,
                                Schild_PlatteBreiteAussp = ((Schild)lbxPositionen.Items[i]).PlatteAussparungBreite,
                                Schild_PlatteBreiteSchild = ((Schild)lbxPositionen.Items[i]).PlatteSchildBreite,
                                Schild_PlatteHoeheSchild = ((Schild)lbxPositionen.Items[i]).PlatteSchildHoehe,
                                Schild_PlatteHoeheAussp = ((Schild)lbxPositionen.Items[i]).PlatteAussparungHöhe
                              };
          }

          dbContext.Zeichnungsdruck.InsertOnSubmit(printPosition);
        }

        dbContext.SubmitChanges();
      }

      // Report für die Zeichnungen laden.
      Form_Report_Zeichnen FReportZeichnen = new Form_Report_Zeichnen(ReportManager.GetReportByName(EReports.Zeichnen));

      FReportZeichnen.Show();
      FReportZeichnen.Refresh();
      this.Cursor = Cursors.Default;
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      DialogResult result =
               MessageBox.Show(
                   "Möchten Sie wirklich schließen?",
                   "Fenster schließen",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

      if (result == DialogResult.Yes)
      {
        this.Close();
        Func.Func.FZeichnen = null;
        _zeichenparameter = null;
      }

    }

    #endregion

    #region tabVW

    private void pnlV10_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 29, 10, 141, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 30, 10, 30, 90);

      // Rechte Wand
      graphics.DrawLine(thinPen, 140, 10, 140, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 30, 70, 50, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 140, 70, 120, 70);

      // Kloschüssel
      graphics.DrawLine(thickPen, 75, 25, 95, 25);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlV11_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 165, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 90);

      // Rechte Wand
      graphics.DrawLine(thinPen, 164, 10, 164, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 70, 40, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 164, 70, 90, 70);

      // Kloschüssel
      graphics.DrawLine(thickPen, 150, 30, 150, 50);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlV12_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 165, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 90);

      // Rechte Wand
      graphics.DrawLine(thinPen, 164, 10, 164, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 70, 90, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 164, 70, 130, 70);

      // Kloschüssel
      graphics.DrawLine(thickPen, 25, 30, 25, 50);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlV13_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      //graphics.DrawLine(thinPen, 10, 10, 165, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 90);

      // Rechte Wand
      graphics.DrawLine(thinPen, 164, 10, 164, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 70, 50, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 164, 70, 120, 70);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void lblV10_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand) & ((Vorderwand)lbxPositionen.SelectedItem).Typ != 10)
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsVW();
      pnlV10.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssVW();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      _vorderwandTyp = 10;
      EnableControlsVW();
      tbxVWBreite.Focus();
    }

    private void lblV11_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand) & ((Vorderwand)lbxPositionen.SelectedItem).Typ != 11)
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsVW();
      ClearControlssVW();
      pnlDraw.Refresh();
      pnlDraw.Controls.Clear();

      pnlV11.BackColor = Color.FromArgb(255, 255, 192);
      _vorderwandTyp = 11;
      EnableControlsVW();
      tbxVWBreite.Focus();
    }

    private void lblV12_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand) & ((Vorderwand)lbxPositionen.SelectedItem).Typ != 12)
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsVW();
      ClearControlssVW();
      pnlDraw.Refresh();
      pnlDraw.Controls.Clear();

      pnlV12.BackColor = Color.FromArgb(255, 255, 192);
      _vorderwandTyp = 12;
      EnableControlsVW();
      tbxVWBreite.Focus();
    }

    private void lblV13_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand) & ((Vorderwand)lbxPositionen.SelectedItem).Typ != 13)
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsVW();
      ClearControlssVW();
      pnlDraw.Refresh();
      pnlDraw.Controls.Clear();

      pnlV13.BackColor = Color.FromArgb(255, 255, 192);
      _vorderwandTyp = 13;
      EnableControlsVW();
      tbxVWBreite.Focus();
    }

    private void tbxVWSchildLinks_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxVWTuer.Text, false) && Func.Func.IsNumeric(tbxVWSchildLinks.Text, false) && tbxVWTuer.Text.Length > 0 & tbxVWSchildLinks.Text.Length > 0)
      {
        Double schild = Math.Round((Double.Parse(tbxVWBreite.Text) - Double.Parse(tbxVWTuer.Text) - Double.Parse(tbxVWSchildLinks.Text)), 1);

        tbxVWSchildRechts.Text = String.Format("{0:#,0.#}", (schild));
      }
    }

    private void tbxVWSchildRechts_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxVWTuer.Text, false) && Func.Func.IsNumeric(tbxVWSchildRechts.Text, false) && tbxVWTuer.Text.Length > 0 & tbxVWSchildLinks.Text.Length > 0)
      {
        Double schild = Math.Round((Double.Parse(tbxVWBreite.Text) - Double.Parse(tbxVWTuer.Text) - Double.Parse(tbxVWSchildRechts.Text)), 1);
        tbxVWSchildLinks.Text = String.Format("{0:#,0.#}", (schild));
      }
    }

    private void tbxVWBreite_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxVWBreite.Text, false) && tbxVWBreite.Text.Length > 0)
      {
        tbxVWBreite.Text = String.Format("{0:#,0.#}", Double.Parse(tbxVWBreite.Text));

        //if (Func.Func.IsNumeric(tbxVWTuer.Text, false) && tbxVWTuer.Text.Length > 0)
        //{
        //  if (Func.Func.IsNumeric(tbxVWSchildLinks.Text, false) && tbxVWSchildLinks.Text.Length > 0)
        //  {
        //    Double schild = (Double.Parse(tbxVWBreite.Text) - Double.Parse(tbxVWTuer.Text) - Double.Parse(tbxVWSchildLinks.Text));

        //    tbxVWSchildRechts.Text = String.Format("{0:#,0.#}", (schild));
        //  }

        //  if (Func.Func.IsNumeric(tbxVWSchildRechts.Text, false) && tbxVWSchildLinks.Text.Length > 0)
        //  {
        //    Double schild = (Double.Parse(tbxVWBreite.Text) - Double.Parse(tbxVWTuer.Text) - Double.Parse(tbxVWSchildRechts.Text));
        //    tbxVWSchildLinks.Text = String.Format("{0:#,0.#}", (schild));
        //  }
        //}
      }
    }

    private void tbxVWHoehe_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxVWHoehe.Text, false) && tbxVWHoehe.Text.Length > 0)
      {
        tbxVWHoehe.Text = String.Format("{0:#,0.#}", Double.Parse(tbxVWHoehe.Text));
      }
    }

    private void tbxVWBodenfreiheit_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxVWBodenfreiheit.Text, false) && tbxVWBodenfreiheit.Text.Length > 0)
      {
        tbxVWBodenfreiheit.Text = String.Format("{0:#,0.#}", Double.Parse(tbxVWBodenfreiheit.Text));
      }
    }

    private void tbxVWTuer_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxVWTuer.Text, false) && tbxVWTuer.Text.Length > 0)
      {
        tbxVWTuer.Text = String.Format("{0:#,0.#}", Double.Parse(tbxVWTuer.Text));
      }
    }

    #endregion

    #region tabRK

    private void tbxRKBreite_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKBreite.Text, false) && tbxRKBreite.Text.Length > 0)
      {
        tbxRKBreite.Text = String.Format("{0:#,0.#}", Double.Parse(tbxRKBreite.Text));

        //if (Func.Func.IsNumeric(tbxRKTuer.Text, false) && tbxRKTuer.Text.Length > 0)
        //{
        //  if (Func.Func.IsNumeric(tbxRKSchildLinks.Text, false) && tbxRKSchildLinks.Text.Length > 0)
        //  {
        //    Double schild = (Double.Parse(tbxRKBreite.Text) - Double.Parse(tbxRKTuer.Text) - Double.Parse(tbxRKSchildLinks.Text));

        //    tbxRKSchildRechts.Text = String.Format("{0:#,0.#}", (schild));
        //  }

        //  if (Func.Func.IsNumeric(tbxRKSchildRechts.Text, false) && tbxRKSchildLinks.Text.Length > 0)
        //  {
        //    Double schild = (Double.Parse(tbxRKBreite.Text) - Double.Parse(tbxRKTuer.Text) - Double.Parse(tbxRKSchildRechts.Text));
        //    tbxRKSchildLinks.Text = String.Format("{0:#,0.#}", (schild));
        //  }
        //}
      }
    }

    private void tbxRKHoehe_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKHoehe.Text, false) && tbxRKHoehe.Text.Length > 0)
      {
        tbxRKHoehe.Text = String.Format("{0:#,0.#}", Double.Parse(tbxRKHoehe.Text));
      }
    }

    private void tbxRKBodenfreiheit_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKBodenfreiheit.Text, false) && tbxRKBodenfreiheit.Text.Length > 0)
      {
        tbxRKBodenfreiheit.Text = String.Format("{0:#,0.#}", Double.Parse(tbxRKBodenfreiheit.Text));
      }
    }

    private void tbxRKTuer_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKTuer.Text, false) && tbxRKTuer.Text.Length > 0)
      {
        tbxRKTuer.Text = String.Format("{0:#,0.#}", Double.Parse(tbxRKTuer.Text));
      }
    }

    private void tbxRKSchildLinks_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKTuer.Text, false) && Func.Func.IsNumeric(tbxRKSchildLinks.Text, false) && tbxRKTuer.Text.Length > 0 & tbxRKSchildLinks.Text.Length > 0)
      {
        Double mittelschild = Math.Round((Double.Parse(tbxRKBreite.Text) / Double.Parse(tbxRKStkTuer.Text)) - Double.Parse(tbxRKTuer.Text), 1);
        Double summeTueren = Math.Round(Double.Parse(tbxRKStkTuer.Text) * Double.Parse(tbxRKTuer.Text), 1);
        Double summeMittelschilde = Math.Round((Double.Parse(tbxRKStkTuer.Text) - 1) * mittelschild, 1);

        Double schild = Math.Round(Double.Parse(tbxRKBreite.Text) - Double.Parse(tbxRKSchildLinks.Text) - summeMittelschilde - summeTueren, 1);

        tbxRKSchildRechts.Text = String.Format("{0:#,0.#}", (schild));
      }
    }

    private void tbxRKSchildRechts_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKTuer.Text, false) && Func.Func.IsNumeric(tbxRKSchildRechts.Text, false) && tbxRKTuer.Text.Length > 0 & tbxRKSchildRechts.Text.Length > 0)
      {
        Double mittelschild = Math.Round((Double.Parse(tbxRKBreite.Text) / Double.Parse(tbxRKStkTuer.Text)) - Double.Parse(tbxRKTuer.Text), 1);
        Double summeTueren = Math.Round(Double.Parse(tbxRKStkTuer.Text) * Double.Parse(tbxRKTuer.Text), 1);
        Double summeMittelschilde = Math.Round((Double.Parse(tbxRKStkTuer.Text) - 1) * mittelschild, 1);

        Double schild = Math.Round(Double.Parse(tbxRKBreite.Text) - Double.Parse(tbxRKSchildRechts.Text) - summeMittelschilde - summeTueren, 1);

        tbxRKSchildLinks.Text = String.Format("{0:#,0.#}", (schild));
      }
    }

    private void tbxRKStkTuer_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKStkTuer.Text, false) && tbxRKStkTuer.Text.Length > 0)
      {
        tbxRKStkTuer.Text = String.Format("{0:#,0}", Double.Parse(tbxRKStkTuer.Text));
      }
    }

    private void tbxRKTrennwand_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxRKTrennwand.Text, false) && tbxRKTrennwand.Text.Length > 0)
      {
        tbxRKTrennwand.Text = String.Format("{0:#,0.#}", Double.Parse(tbxRKTrennwand.Text));
      }
    }

    #region tabEck

    private void tbxEckBreite_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckBreite.Text, false) && tbxEckBreite.Text.Length > 0)
      {
        tbxEckBreite.Text = String.Format("{0:#,0.#}", Double.Parse(tbxEckBreite.Text));

        //if (Func.Func.IsNumeric(tbxEckTuer.Text, false) && tbxEckTuer.Text.Length > 0)
        //{
        //  if (Func.Func.IsNumeric(tbxEckSchildWand.Text, false) && tbxEckSchildWand.Text.Length > 0)
        //  {
        //    Double schild = (Double.Parse(tbxEckBreite.Text) - Double.Parse(tbxEckTuer.Text) - Double.Parse(tbxEckSchildWand.Text));

        //    tbxEckSchildEck.Text = String.Format("{0:#,0.#}", (schild));
        //  }

        //  if (Func.Func.IsNumeric(tbxEckSchildEck.Text, false) && tbxEckSchildEck.Text.Length > 0)
        //  {
        //    Double schild = (Double.Parse(tbxEckBreite.Text) - Double.Parse(tbxEckTuer.Text) - Double.Parse(tbxEckSchildEck.Text));
        //    tbxEckSchildWand.Text = String.Format("{0:#,0.#}", (schild));
        //  }
        //}
      }
    }

    private void tbxEckHoehe_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckHoehe.Text, false) && tbxEckHoehe.Text.Length > 0)
      {
        tbxEckHoehe.Text = String.Format("{0:#,0.#}", Double.Parse(tbxEckHoehe.Text));
      }
    }

    private void tbxEckBodenfreiheit_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckBodenfreiheit.Text, false) && tbxEckBodenfreiheit.Text.Length > 0)
      {
        tbxEckBodenfreiheit.Text = String.Format("{0:#,0.#}", Double.Parse(tbxEckBodenfreiheit.Text));
      }
    }

    private void tbxEckTuer_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckTuer.Text, false) && tbxEckTuer.Text.Length > 0)
      {
        tbxEckTuer.Text = String.Format("{0:#,0.#}", Double.Parse(tbxEckTuer.Text));
      }
    }

    private void tbxEckStkTuer_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckStkTuer.Text, false) && tbxEckStkTuer.Text.Length > 0)
      {
        tbxEckStkTuer.Text = String.Format("{0:#,0}", Double.Parse(tbxEckStkTuer.Text));
      }
    }

    private void tbxEckTrennwand_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckTrennwand.Text, false) && tbxEckTrennwand.Text.Length > 0)
      {
        tbxEckTrennwand.Text = String.Format("{0:#,0.#}", Double.Parse(tbxEckTrennwand.Text));
      }
    }

    private void tbxEckSchildWand_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckTuer.Text, false) && Func.Func.IsNumeric(tbxEckSchildWand.Text, false) && tbxEckTuer.Text.Length > 0 & tbxEckSchildWand.Text.Length > 0)
      {
        Double mittelschild = Math.Round((Double.Parse(tbxEckBreite.Text) / Double.Parse(tbxEckStkTuer.Text)) - Double.Parse(tbxEckTuer.Text), 1);
        Double summeTueren = Double.Parse(tbxEckStkTuer.Text) * Double.Parse(tbxEckTuer.Text);
        Double summeMittelschilde = Math.Round((Double.Parse(tbxEckStkTuer.Text) - 1) * mittelschild, 1);

        Double schild = Math.Round(Double.Parse(tbxEckBreite.Text) - Double.Parse(tbxEckSchildWand.Text) - summeMittelschilde - summeTueren, 1);

        tbxEckSchildEck.Text = String.Format("{0:#,0.#}", (schild));
      }
    }

    private void tbxEckSchildEck_Leave(object sender, EventArgs e)
    {
      if (Func.Func.IsNumeric(tbxEckTuer.Text, false) && Func.Func.IsNumeric(tbxEckSchildEck.Text, false) && tbxEckTuer.Text.Length > 0 & tbxEckSchildEck.Text.Length > 0)
      {
        Double mittelschild = Math.Round((Double.Parse(tbxEckBreite.Text) / Double.Parse(tbxEckStkTuer.Text)) - Double.Parse(tbxEckTuer.Text), 1);
        Double summeTueren = Double.Parse(tbxEckStkTuer.Text) * Double.Parse(tbxEckTuer.Text);
        Double summeMittelschilde = Math.Round((Double.Parse(tbxEckStkTuer.Text) - 1) * mittelschild, 1);

        Double schild = Math.Round(Double.Parse(tbxEckBreite.Text) - Double.Parse(tbxEckSchildEck.Text) - summeMittelschilde - summeTueren, 1);

        tbxEckSchildWand.Text = String.Format("{0:#,0.#}", (schild));
      }
    }

    # endregion

    #endregion

    #region tabEK

    private void pnlEckLinks_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 165, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 90);

      // Rechte Wand
      graphics.DrawLine(middlePen, 100, 10, 100, 74);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 70, 30, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 100, 70, 80, 70);

      // Kloschüssel
      graphics.DrawLine(thickPen, 45, 25, 65, 25);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlEckRechts_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 165, 10);

      // Linke Wand
      graphics.DrawLine(middlePen, 75, 10, 75, 74);

      // Rechte Wand
      graphics.DrawLine(thinPen, 165, 10, 165, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 75, 70, 95, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 164, 70, 144, 70);

      // Kloschüssel
      graphics.DrawLine(thickPen, 110, 25, 130, 25);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlEckEinzelRechts_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 166, 10);

      // Linke Wand
      graphics.DrawLine(middlePen, 30, 10, 30, 74);

      // Rechte Wand
      graphics.DrawLine(thinPen, 165, 10, 165, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 30, 70, 50, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 164, 70, 100, 70);

      // Kloschüssel
      graphics.DrawLine(thickPen, 145, 30, 145, 50);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlEckEinzelLinks_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 166, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 90);

      // Rechte Wand
      graphics.DrawLine(middlePen, 145, 10, 145, 74);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 70, 80, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 145, 70, 125, 70);

      // Kloschüssel
      graphics.DrawLine(thickPen, 25, 30, 25, 50);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlEckLinks_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Eckkabine) & ((Eckkabine)lbxPositionen.SelectedItem).Artikel != "Eckk. L")
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsEck();
      pnlEckLinks.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssEck();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsEck();
      tbxEckBreite.Focus();
    }

    private void pnlEckRechts_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Eckkabine) & ((Eckkabine)lbxPositionen.SelectedItem).Artikel != "Eckk. R")
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsEck();
      pnlEckRechts.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssEck();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsEck();
      tbxEckBreite.Focus();
    }

    private void pnlEckEinzelLinks_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Eckkabine) & ((Eckkabine)lbxPositionen.SelectedItem).Artikel != "Eckk. einzel L")
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsEck();
      pnlEckEinzelLinks.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssEck();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsEck();
      tbxEckStkTuer.Text = "1";
      tbxEckStkTuer.Enabled = false;
      tbxEckBreite.Focus();
    }

    private void pnlEckEinzelRechts_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Eckkabine) & ((Eckkabine)lbxPositionen.SelectedItem).Artikel != "Eckk. einzel R")
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsEck();
      pnlEckEinzelRechts.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssEck();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsEck();
      tbxEckStkTuer.Text = "1";
      tbxEckStkTuer.Enabled = false;
      tbxEckBreite.Focus();
    }

    #endregion

    #region tabSK

    private void lblSK1_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine) & ((Sonderkabine)lbxPositionen.SelectedItem).Typ == 1)
        {
          DeselectAllItems();
        }
      }

      _sonderkabinenTyp = 1;
      SetDisabledColorForPanelsSK();
      pnlSK1.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssSK();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsSK();
      tbxSKMittelschildR.Text = "0";
      tbxSKMittelschildR.Enabled = false;
      tbxSKStkTuer.Text = "2";
      tbxSKStkTuer.Enabled = false;
      tbxSKBreite.Focus();
    }

    private void lblSK3_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine) & ((Sonderkabine)lbxPositionen.SelectedItem).Typ == 3)
        {
          DeselectAllItems();
        }
      }

      _sonderkabinenTyp = 3;
      SetDisabledColorForPanelsSK();
      pnlSK3.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssSK();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsSK();
      tbxSKMittelschildR.Text = "0";
      tbxSKMittelschildR.Enabled = false;
      lblEckSchild.Text = "W-Schild R";
      lblWandSchild.Text = "W-Schild L";
      tbxSKStkTuer.Text = "2";
      tbxSKStkTuer.Enabled = false;
      tbxSKBreite.Focus();
    }

    private void lblSK4_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine) & ((Sonderkabine)lbxPositionen.SelectedItem).Typ == 4)
        {
          DeselectAllItems();
        }
      }

      _sonderkabinenTyp = 4;
      SetDisabledColorForPanelsSK();
      pnlSK4.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssSK();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsSK();
      tbxSKMittelschildR.Text = "";
      tbxSKMittelschildR.Enabled = true;
      lblEckSchild.Text = "W-Schild R";
      lblWandSchild.Text = "W-Schild L";
      tbxSKStkTuer.Text = "3";
      tbxSKStkTuer.Enabled = false;
      tbxSKBreite.Focus();
    }

    private void lblSK5_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine) & ((Sonderkabine)lbxPositionen.SelectedItem).Typ == 5)
        {
          DeselectAllItems();
        }
      }

      _sonderkabinenTyp = 5;
      SetDisabledColorForPanelsSK();
      pnlSK5.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssSK();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsSK();
      tbxSKMittelschildR.Text = "0";
      tbxSKMittelschildR.Enabled = false;
      lblEckSchild.Text = "W-Schild R";
      lblWandSchild.Text = "W-Schild L";
      tbxSKStkTuer.Text = "2";
      tbxSKStkTuer.Enabled = false;
      tbxSKBreite.Focus();
    }

    private void lblSK2_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine) & ((Sonderkabine)lbxPositionen.SelectedItem).Typ == 2)
        {
          DeselectAllItems();
        }
      }

      _sonderkabinenTyp = 2;
      SetDisabledColorForPanelsSK();
      pnlSK2.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssSK();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsSK();
      tbxSKMittelschildR.Text = "0";
      tbxSKMittelschildR.Enabled = false;
      tbxSKStkTuer.Text = "2";
      tbxSKStkTuer.Enabled = false;
      tbxSKBreite.Focus();
    }

    private void tbxSKMittelschildR_Leave(object sender, EventArgs e)
    {
      if (_sonderkabinenTyp == 4)
      {
        if (Func.Func.IsNumeric(tbxSKBreite.Text, false) && Func.Func.IsNumeric(tbxSKTuer.Text, false) && Func.Func.IsNumeric(tbxSKWandschild.Text, false) && Func.Func.IsNumeric(tbxSKMittelschildL.Text, false) && Func.Func.IsNumeric(tbxSKMittelschildR.Text, false))
        {
          Double summeTueren = Math.Round(Double.Parse(tbxSKStkTuer.Text) * Double.Parse(tbxSKTuer.Text), 1);

          Double schild = Math.Round(Double.Parse(tbxSKBreite.Text) - Double.Parse(tbxSKWandschild.Text) - Double.Parse(tbxSKMittelschildL.Text) - Double.Parse(tbxSKMittelschildR.Text) - summeTueren, 1);

          tbxSKEckschild.Text = String.Format("{0:#,0.#}", (schild));
        }
      }
    }

    private void tbxSKMittelschildL_Leave(object sender, EventArgs e)
    {
      if (_sonderkabinenTyp != 4)
      {
        if (Func.Func.IsNumeric(tbxSKBreite.Text, false) && Func.Func.IsNumeric(tbxSKTuer.Text, false) && Func.Func.IsNumeric(tbxSKWandschild.Text, false) && Func.Func.IsNumeric(tbxSKMittelschildL.Text, false))
        {
          Double summeTueren = Math.Round(Double.Parse(tbxSKStkTuer.Text) * Double.Parse(tbxSKTuer.Text), 1);

          Double schild = Math.Round(Double.Parse(tbxSKBreite.Text) - Double.Parse(tbxSKWandschild.Text) - Double.Parse(tbxSKMittelschildL.Text) - Double.Parse(tbxSKMittelschildR.Text) - summeTueren, 1);

          tbxSKEckschild.Text = String.Format("{0:#,0.#}", (schild));
        }

      }


    }

    #endregion

    #region common

    private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand) & tabControl1.SelectedTab != tabVW)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Reihenkabine) & tabControl1.SelectedTab != tabRK)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Text) & tabControl1.SelectedTab != tabText)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Eckkabine) & tabControl1.SelectedTab != tabEK)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine) & tabControl1.SelectedTab != tabSK)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Schamwand) & tabControl1.SelectedTab != tabSW)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Schild) & tabControl1.SelectedTab != tabTRW)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Trennwand) & tabControl1.SelectedTab != tabTRW)
        {
          DeselectAllItems();
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Schild) & tabControl1.SelectedTab != tabTRW)
        {
          DeselectAllItems();
        }
      }
      Clear(false, false);
    }

    private void btnSpeichern_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        // Wenn das aktuell selektiere Item vom Typ "Vorderwand" ist und der Tab für die Vorderwand aktiviert ist
        // und die Eingabewerte korrekt sind, dann werden die Änderungen gespeichert.
        if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand) & tabControl1.SelectedTab == tabVW)
        {
          if (ValidateInput())
          {
            ((Vorderwand)lbxPositionen.SelectedItem).Hoehe = (float)Double.Parse(tbxVWHoehe.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Breite = (float)Double.Parse(tbxVWBreite.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Bodenfreiheit =
              (float)Double.Parse(tbxVWBodenfreiheit.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Tuerbreite = (float)Double.Parse(tbxVWTuer.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Schildlinks =
              (float)Double.Parse(tbxVWSchildLinks.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Schildrechts =
              (float)Double.Parse(tbxVWSchildRechts.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).U = rdbVWUGroß.Checked
                                                            ? _zeichenparameter.GrossesU
                                                            : rdbVWUKlein.Checked ? _zeichenparameter.KleinesU : 0f;
          }
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Text) & tabControl1.SelectedTab == tabText)
        {
          if (ValidateInput())
          {
            ((Text)lbxPositionen.SelectedItem).Beschreibung = tbxText.Text;
          }
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Reihenkabine) & tabControl1.SelectedTab == tabRK)
        {
          if (ValidateInput())
          {
            // Das Ändern eines Reihenkabinen-Objekt in der Listbox muss folgendermaßen gelöst werden
            // da sonst der Typ der Reihenkabine in der Listbox nicht aktualisiert wird.
            // 
            // Es wird ein neues Objekt mit den geänderten Werten erzeugt.
            // Anschließend wird der Index des "alten" Objekt gespeichert.
            // Das "alte" Objekt wird aus der Listbox gelöscht.
            // Das "neue" Objekt wird an der ursprünglichen Stelle eingefügt.
            // Das eingefügte Objekt wird selektiert, damit die Anzeige der neuen Daten mit Maße-Lable korrekt ist

            var rk = new Reihenkabine
                       {
                         Typ = int.Parse(tbxRKStkTuer.Text),
                         Hoehe = (float)Double.Parse(tbxRKHoehe.Text),
                         Breite = (float)Double.Parse(tbxRKBreite.Text),
                         Bodenfreiheit = (float)Double.Parse(tbxRKBodenfreiheit.Text),
                         Tueranzahl = int.Parse(tbxRKStkTuer.Text),
                         Tuerbreite = (float)Double.Parse(tbxRKTuer.Text),
                         Trennwand = (float)Double.Parse(tbxRKTrennwand.Text),
                         Schildlinks = (float)Double.Parse(tbxRKSchildLinks.Text),
                         Schildrechts = (float)Double.Parse(tbxRKSchildRechts.Text),
                         U = rdbRKUGross.Checked ? _zeichenparameter.GrossesU : rdbRKUKlein.Checked ? _zeichenparameter.KleinesU : 0f,
                         Zeichenparameter = _zeichenparameter
                       };

            int index = lbxPositionen.SelectedIndex;

            lbxPositionen.Items.RemoveAt(index);
            lbxPositionen.Items.Insert(index, rk);
            lbxPositionen.SetSelected(index, true);

            //((Reihenkabine)lbxPositionen.SelectedItem).Typ = int.Parse(tbxRKStkTuer.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Breite = (float)Double.Parse(tbxRKBreite.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Hoehe = (float)Double.Parse(tbxRKHoehe.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Bodenfreiheit = (float)Double.Parse(tbxRKBodenfreiheit.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Tuerbreite = (float)Double.Parse(tbxRKTuer.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Tueranzahl = int.Parse(tbxRKStkTuer.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Trennwand = (float)Double.Parse(tbxRKTrennwand.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Schildwand = (float)Double.Parse(tbxRKSchildLinks.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).Schildrechts = (float)Double.Parse(tbxRKSchildRechts.Text);
            //((Reihenkabine)lbxPositionen.SelectedItem).U = rdbRKUGross.Checked
            //                                               ? _zeichenparameter.GrossesU
            //                                               : rdbRKUKlein.Checked ? _zeichenparameter.KleinesU : 0f;
          }
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Eckkabine) & tabControl1.SelectedTab == tabEK)
        {
          if (ValidateInput())
          {
            string artikel = "Eckk. ";

            if (pnlEckLinks.BackColor != Color.Gray)
            {
              artikel += "L";
            }
            else if (pnlEckRechts.BackColor != Color.Gray)
            {
              artikel += "R";
            }
            else if (pnlEckEinzelLinks.BackColor != Color.Gray)
            {
              artikel += "einzel L";
            }
            else if (pnlEckEinzelRechts.BackColor != Color.Gray)
            {
              artikel += "einzel R";
            }

            var rk = new Eckkabine()
                       {
                         Artikel = artikel,
                         Typ = int.Parse(tbxEckStkTuer.Text),
                         Hoehe = (float)Double.Parse(tbxEckHoehe.Text),
                         Breite = (float)Double.Parse(tbxEckBreite.Text),
                         Bodenfreiheit = (float)Double.Parse(tbxEckBodenfreiheit.Text),
                         Tueranzahl = int.Parse(tbxEckStkTuer.Text),
                         Tuerbreite = (float)Double.Parse(tbxEckTuer.Text),
                         Trennwand = (float)Double.Parse(tbxEckTrennwand.Text),
                         Schildwand = (float)Double.Parse(tbxEckSchildWand.Text),
                         Schildeck = (float)Double.Parse(tbxEckSchildEck.Text),
                         U = rdbEckUGross.Checked ? _zeichenparameter.GrossesU : rdbEckUKlein.Checked ? _zeichenparameter.KleinesU : 0f,
                         Zeichenparameter = _zeichenparameter
                       };

            int index = lbxPositionen.SelectedIndex;

            lbxPositionen.Items.RemoveAt(index);
            lbxPositionen.Items.Insert(index, rk);
            lbxPositionen.SetSelected(index, true);
            //((Eckkabine)lbxPositionen.SelectedItem).Hoehe = (float)Double.Parse(tbxEckHoehe.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).Breite = (float)Double.Parse(tbxEckBreite.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).Bodenfreiheit =
            //    (float)Double.Parse(tbxEckBodenfreiheit.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).Tuerbreite = (float)Double.Parse(tbxEckTuer.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).Tueranzahl = int.Parse(tbxEckStkTuer.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).Schildwand =
            //    (float)Double.Parse(tbxEckSchildWand.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).Schildeck =
            //    (float)Double.Parse(tbxEckSchildEck.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).Trennwand = (float)Double.Parse(tbxEckTrennwand.Text);
            //((Eckkabine)lbxPositionen.SelectedItem).U = rdbEckUGross.Checked
            //                                               ? _zeichenparameter.GrossesU
            //                                               : rdbEckUKlein.Checked ? _zeichenparameter.KleinesU : 0f;
          }
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Sonderkabine) & tabControl1.SelectedTab == tabSK)
        {
          if (ValidateInput())
          {
            ((Vorderwand)lbxPositionen.SelectedItem).Hoehe = (float)Double.Parse(tbxVWHoehe.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Breite = (float)Double.Parse(tbxVWBreite.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Bodenfreiheit =
              (float)Double.Parse(tbxVWBodenfreiheit.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Tuerbreite = (float)Double.Parse(tbxVWTuer.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Schildlinks =
              (float)Double.Parse(tbxVWSchildLinks.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).Schildrechts =
              (float)Double.Parse(tbxVWSchildRechts.Text);
            ((Vorderwand)lbxPositionen.SelectedItem).U = rdbVWUGroß.Checked
                                                            ? _zeichenparameter.GrossesU
                                                            : rdbVWUKlein.Checked ? _zeichenparameter.KleinesU : 0f;
          }
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Schamwand) & tabControl1.SelectedTab == tabSW)
        {
          if (ValidateInput())
          {
            ((Schamwand)lbxPositionen.SelectedItem).Hoehe = (float)Double.Parse(tbxSWHoehe.Text);
            ((Schamwand)lbxPositionen.SelectedItem).Breite = (float)Double.Parse(tbxSWBreite.Text);
            ((Schamwand)lbxPositionen.SelectedItem).Bodenfreiheit = (float)Double.Parse(tbxSWBodenfreiheit.Text);
            ((Schamwand)lbxPositionen.SelectedItem).Stk = (int)Double.Parse(tbxSWStk.Text);
          }
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Trennwand) & tabControl1.SelectedTab == tabTRW)
        {
          if (ValidateInput())
          {
            ((Trennwand)lbxPositionen.SelectedItem).Hoehe = (float)Double.Parse(tbxSTHoehe.Text);
            ((Trennwand)lbxPositionen.SelectedItem).Bodenfreiheit = (float)Double.Parse(tbxSTBodenfreiheit.Text);
            ((Trennwand)lbxPositionen.SelectedItem).Stk = (int)Double.Parse(tbxSTStk.Text);
            ((Trennwand)lbxPositionen.SelectedItem).Schildbreite = (float)Double.Parse(tbxSTBreiteSchild.Text);
            ((Trennwand)lbxPositionen.SelectedItem).Aussparungsbreite = (float)Double.Parse(tbxSTBreiteAussp.Text);
            ((Trennwand)lbxPositionen.SelectedItem).Brüstungshöhe = (float)Double.Parse(tbxSTHoeheBruestung.Text);
          }
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Schild) & tabControl1.SelectedTab == tabText)
        {
          if (ValidateInput())
          {
            ((Schild)lbxPositionen.SelectedItem).Hoehe = (float)Double.Parse(tbxSTHoehe.Text);
            ((Schild)lbxPositionen.SelectedItem).Bodenfreiheit = (float)Double.Parse(tbxSTBodenfreiheit.Text);
            ((Schild)lbxPositionen.SelectedItem).Stk = (int)Double.Parse(tbxSTStk.Text);
            ((Schild)lbxPositionen.SelectedItem).Schildbreite = (float)Double.Parse(tbxSTBreiteSchild.Text);
            ((Schild)lbxPositionen.SelectedItem).Aussparungsbreite = (float)Double.Parse(tbxSTBreiteAussp.Text);
            ((Schild)lbxPositionen.SelectedItem).Brüstungshöhe = (float)Double.Parse(tbxSTHoeheBruestung.Text);
          }
        }

        // Controls auf Draw-Panel löschen, damit neue Werte korrekt geschrieben werden.
        pnlDraw.Controls.Clear();
        pnlDraw.Refresh();

        lblMaße.Text = ((IPosition)lbxPositionen.SelectedItem).AsString();
      }
      //**********************************
      // Neuanlage eines Objekts
      //**********************************
      else
      {
        switch (tabControl1.SelectedTab.Name)
        {
          case "tabText":
            var t = new Text
                      {
                        Beschreibung = tbxText.Text
                      };

            lbxPositionen.Items.Add(t);

            break;
          case "tabVW":
            if (ValidateInput())
            {
              var v = new Vorderwand
                        {
                          Typ = _vorderwandTyp,
                          Hoehe = (float)Double.Parse(tbxVWHoehe.Text),
                          Breite = (float)Double.Parse(tbxVWBreite.Text),
                          Bodenfreiheit = (float)Double.Parse(tbxVWBodenfreiheit.Text),
                          Tuerbreite = (float)Double.Parse(tbxVWTuer.Text),
                          Schildlinks = (float)Double.Parse(tbxVWSchildLinks.Text),
                          Schildrechts = (float)Double.Parse(tbxVWSchildRechts.Text),
                          U = rdbVWUGroß.Checked ? _zeichenparameter.GrossesU : rdbVWUKlein.Checked ? _zeichenparameter.KleinesU : 0f,
                          Zeichenparameter = _zeichenparameter
                        };

              lbxPositionen.Items.Add(v);
            }
            break;
          case "tabRK":
            if (ValidateInput())
            {
              var rk = new Reihenkabine
                         {
                           Typ = int.Parse(tbxRKStkTuer.Text),
                           Hoehe = (float)Double.Parse(tbxRKHoehe.Text),
                           Breite = (float)Double.Parse(tbxRKBreite.Text),
                           Bodenfreiheit = (float)Double.Parse(tbxRKBodenfreiheit.Text),
                           Tueranzahl = int.Parse(tbxRKStkTuer.Text),
                           Tuerbreite = (float)Double.Parse(tbxRKTuer.Text),
                           Trennwand = (float)Double.Parse(tbxRKTrennwand.Text),
                           Schildlinks = (float)Double.Parse(tbxRKSchildLinks.Text),
                           Schildrechts = (float)Double.Parse(tbxRKSchildRechts.Text),
                           U = rdbRKUGross.Checked ? _zeichenparameter.GrossesU : rdbRKUKlein.Checked ? _zeichenparameter.KleinesU : 0f,
                           Zeichenparameter = _zeichenparameter
                         };

              lbxPositionen.Items.Add(rk);
            }

            break;

          case "tabEK":
            if (ValidateInput())
            {
              string artikel = "Eckk. ";

              if (pnlEckLinks.BackColor != Color.Gray)
              {
                artikel += "L";
              }
              else if (pnlEckRechts.BackColor != Color.Gray)
              {
                artikel += "R";
              }
              else if (pnlEckEinzelLinks.BackColor != Color.Gray)
              {
                artikel += "einzel L";
              }
              else if (pnlEckEinzelRechts.BackColor != Color.Gray)
              {
                artikel += "einzel R";
              }

              var rk = new Eckkabine()
                         {
                           Artikel = artikel,
                           Typ = int.Parse(tbxEckStkTuer.Text),
                           Hoehe = (float)Double.Parse(tbxEckHoehe.Text),
                           Breite = (float)Double.Parse(tbxEckBreite.Text),
                           Bodenfreiheit = (float)Double.Parse(tbxEckBodenfreiheit.Text),
                           Tueranzahl = int.Parse(tbxEckStkTuer.Text),
                           Tuerbreite = (float)Double.Parse(tbxEckTuer.Text),
                           Trennwand = (float)Double.Parse(tbxEckTrennwand.Text),
                           Schildwand = (float)Double.Parse(tbxEckSchildWand.Text),
                           Schildeck = (float)Double.Parse(tbxEckSchildEck.Text),
                           U = rdbEckUGross.Checked ? _zeichenparameter.GrossesU : rdbEckUKlein.Checked ? _zeichenparameter.KleinesU : 0f,
                           Zeichenparameter = _zeichenparameter
                         };

              lbxPositionen.Items.Add(rk);
            }
            break;

          case "tabSK":
            if (ValidateInput())
            {
              var sk = new Sonderkabine()
                         {
                           Typ = _sonderkabinenTyp,
                           Hoehe = (float)Double.Parse(tbxSKHoehe.Text),
                           Breite = (float)Double.Parse(tbxSKBreite.Text),
                           Bodenfreiheit = (float)Double.Parse(tbxSKBodenfreiheit.Text),
                           Tueranzahl = int.Parse(tbxSKStkTuer.Text),
                           Tuerbreite = (float)Double.Parse(tbxSKTuer.Text),
                           Trennwand = (float)Double.Parse(tbxSKTrennwand.Text),
                           Schildwand = (float)Double.Parse(tbxSKWandschild.Text),
                           Schildeck = (float)Double.Parse(tbxSKEckschild.Text),
                           MittelschildL = (float)Double.Parse(tbxSKMittelschildL.Text),
                           MittelschildR = (float)Double.Parse(tbxSKMittelschildR.Text),
                           U = rdbSKUGross.Checked ? _zeichenparameter.GrossesU : rdbSKUklein.Checked ? _zeichenparameter.KleinesU : 0f,
                           Zeichenparameter = _zeichenparameter
                         };

              lbxPositionen.Items.Add(sk);
            }

            break;
          case "tabSW":
            if (ValidateInput())
            {
              var sw = new Schamwand()
              {
                Artikel = _schamwandArtikel,
                Hoehe = (float)Double.Parse(tbxSWHoehe.Text),
                Breite = (float)Double.Parse(tbxSWBreite.Text),
                Bodenfreiheit = (float)Double.Parse(tbxSWBodenfreiheit.Text),
                Stk = int.Parse(tbxSWStk.Text),
                Zeichenparameter = _zeichenparameter
              };

              lbxPositionen.Items.Add(sw);
            }

            break;
          case "tabTRW":
            if (ValidateInput())
            {
              if (_schildOrTrennwand == "trennwand")
              {
                var trw = new Trennwand()
                           {
                             Artikel = _schildOrTrennwand,
                             Hoehe = (float)Double.Parse(tbxSTHoehe.Text),
                             Schildbreite = (float)Double.Parse(tbxSTBreiteSchild.Text),
                             Bodenfreiheit = (float)Double.Parse(tbxSTBodenfreiheit.Text),
                             Stk = int.Parse(tbxSTStk.Text),
                             Brüstungshöhe = (float)Double.Parse(tbxSTHoeheBruestung.Text),
                             Aussparungsbreite = (float)Double.Parse(tbxSTBreiteAussp.Text),
                             Zeichenparameter = _zeichenparameter
                           };
                lbxPositionen.Items.Add(trw);
              }
              else if (_schildOrTrennwand == "schildRechts" || _schildOrTrennwand == "schildLinks")
              {
                var schild = new Schild()
                {
                  Artikel = _schildOrTrennwand,
                  Hoehe = (float)Double.Parse(tbxSTHoehe.Text),
                  Schildbreite = (float)Double.Parse(tbxSTBreiteSchild.Text),
                  Bodenfreiheit = (float)Double.Parse(tbxSTBodenfreiheit.Text),
                  Stk = int.Parse(tbxSTStk.Text),
                  Brüstungshöhe = (float)Double.Parse(tbxSTHoeheBruestung.Text),
                  Aussparungsbreite = (float)Double.Parse(tbxSTBreiteAussp.Text),
                  Zeichenparameter = _zeichenparameter
                };
                lbxPositionen.Items.Add(schild);
              }

            }

            break;
        }
      }

      if (lbxPositionen.Items.Count > 0)
      {
        btnPrint.Enabled = true;
        btnPosDel.Enabled = true;
        btnPosUp.Enabled = true;
        btnPosDown.Enabled = true;
      }
    }

    private void pnlDraw_Paint(object sender, PaintEventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Vorderwand))
        {
          ((Vorderwand)lbxPositionen.SelectedItem).DrawOnPanel(e.Graphics);

          // Labels zeichnen
          DrawLabelsVW(((Vorderwand)lbxPositionen.SelectedItem).Typ);
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Text))
        {
          tabControl1.SelectTab(tabText);
          tbxText.Text = ((Text)lbxPositionen.SelectedItem).Beschreibung;
        }
        else if (lbxPositionen.SelectedItem.GetType() == typeof(Reihenkabine))
        {
          //((Reihenkabine)lbxPositionen.SelectedItem).DrawOnPanel(e.Graphics);

          // Labels zeichnen
          // DrawLabelsRK(((Vorderwand)lbxPositionen.SelectedItem).Typ);
        }
      }
      //else
      //{
      //  e.Graphics.Clear(Color.FromName("control"));
      //  if (pnlDraw.Controls.Count > 0)
      //  {
      //    pnlDraw.Controls["lblPnlTuerbreite"].Text = "";
      //  }
      //}
    }

    #endregion

    #endregion

    #region Methods

    #region Common

    /// <summary>
    /// Diese Methode deselektiert alle selektierten Items in der Listbox.
    /// Es dürfte eigentlich nur immer ein Item markiert sein.
    /// </summary>
    private void DeselectAllItems()
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        for (int i = 0; i < lbxPositionen.Items.Count; i++)
        {
          if (lbxPositionen.GetSelected(i) == true)
          {
            lbxPositionen.SetSelected(i, false);
          }
        }
      }
    }

    /// <summary>
    /// Diese Methode überprüft in Abhängigkeit des gewählten Artikels ob alle benötigten Eingabefelder korrekt befüllt wurden.
    /// </summary>
    /// <returns></returns>
    private bool ValidateInput()
    {
      bool result = false;
      if (tabControl1.SelectedTab == tabVW)
      {
        if (Func.Func.IsNumeric(tbxVWBreite.Text, false)
            && Func.Func.IsNumeric(tbxVWHoehe.Text, false)
            && Func.Func.IsNumeric(tbxVWBodenfreiheit.Text, false)
            && Func.Func.IsNumeric(tbxVWTuer.Text, false)
            && Func.Func.IsNumeric(tbxVWSchildLinks.Text, false)
            && Func.Func.IsNumeric(tbxVWSchildRechts.Text, false))
        {
          result = true;
        }
      }
      else if (tabControl1.SelectedTab == tabText)
      {
        if (tbxText.Text != "")
        {
          result = true;
        }
      }
      else if (tabControl1.SelectedTab == tabRK)
      {
        if (Func.Func.IsNumeric(tbxRKBreite.Text, false)
            && Func.Func.IsNumeric(tbxRKHoehe.Text, false)
            && Func.Func.IsNumeric(tbxRKBodenfreiheit.Text, false)
            && Func.Func.IsNumeric(tbxRKTuer.Text, false)
            && Func.Func.IsNumeric(tbxRKStkTuer.Text, false)
            && Func.Func.IsNumeric(tbxRKTrennwand.Text, false)
            && Func.Func.IsNumeric(tbxRKSchildLinks.Text, false)
            && Func.Func.IsNumeric(tbxRKSchildRechts.Text, false)
            && int.Parse(tbxRKStkTuer.Text) >= 2 & int.Parse(tbxRKStkTuer.Text) <= 7)
        {
          result = true;
        }
      }
      else if (tabControl1.SelectedTab == tabEK)
      {
        if (Func.Func.IsNumeric(tbxEckBreite.Text, false)
            && Func.Func.IsNumeric(tbxEckHoehe.Text, false)
            && Func.Func.IsNumeric(tbxEckBodenfreiheit.Text, false)
            && Func.Func.IsNumeric(tbxEckTuer.Text, false)
            && Func.Func.IsNumeric(tbxEckStkTuer.Text, false)
            && Func.Func.IsNumeric(tbxEckTrennwand.Text, false)
            && Func.Func.IsNumeric(tbxEckSchildWand.Text, false)
            && Func.Func.IsNumeric(tbxEckSchildEck.Text, false)
            && int.Parse(tbxEckStkTuer.Text) >= 1 & int.Parse(tbxEckStkTuer.Text) <= 7)
        {
          result = true;
        }
      }
      else if (tabControl1.SelectedTab == tabSK)
      {
        if (Func.Func.IsNumeric(tbxSKBreite.Text, false)
            && Func.Func.IsNumeric(tbxSKHoehe.Text, false)
            && Func.Func.IsNumeric(tbxSKBodenfreiheit.Text, false)
            && Func.Func.IsNumeric(tbxSKTuer.Text, false)
            && Func.Func.IsNumeric(tbxSKStkTuer.Text, false)
            && Func.Func.IsNumeric(tbxSKTrennwand.Text, false)
            && Func.Func.IsNumeric(tbxSKWandschild.Text, false)
            && Func.Func.IsNumeric(tbxSKMittelschildL.Text, false)
            && Func.Func.IsNumeric(tbxSKMittelschildR.Text, false)
            && Func.Func.IsNumeric(tbxSKEckschild.Text, false)
            && int.Parse(tbxSKStkTuer.Text) >= 1 & int.Parse(tbxSKStkTuer.Text) <= 3)
        {
          result = true;
        }
      }
      else if (tabControl1.SelectedTab == tabSW)
      {
        if (Func.Func.IsNumeric(tbxSWStk.Text, false)
            && Func.Func.IsNumeric(tbxSWBreite.Text, false)
            && Func.Func.IsNumeric(tbxSWHoehe.Text, false)
            && Func.Func.IsNumeric(tbxSWBodenfreiheit.Text, false))
        {
          result = true;
        }
      }
      else if (tabControl1.SelectedTab == tabTRW)
      {
        if (Func.Func.IsNumeric(tbxSTStk.Text, false)
            && Func.Func.IsNumeric(tbxSTHoeheBruestung.Text, false)
            && Func.Func.IsNumeric(tbxSTHoehe.Text, false)
            && Func.Func.IsNumeric(tbxSTBreiteSchild.Text, false)
           && Func.Func.IsNumeric(tbxSTBreiteAussp.Text, false)
           && Func.Func.IsNumeric(tbxSTBodenfreiheit.Text, false))
        {
          result = true;
        }
      }

      return result;
    }

    /// <summary>
    /// Diese Methode setzt alle Controls in den Default-Zustand. So als ob die Form gerade neu geöffnet wurde
    /// </summary>
    /// <param name="clearListboxItems">Flag, ob die Listbox-Items gelöscht werden sollen.</param>
    private void Clear(bool clearListboxItems, bool selectTabText)
    {
      // Listbox
      if (clearListboxItems)
      {
        lbxPositionen.Items.Clear();
      }

      if (selectTabText)
      {
        tabControl1.SelectTab(tabText);
      }

      // Text
      //tbxText.Text = "";

      // Vorderwand
      pnlV10.Enabled = true;
      pnlV11.Enabled = true;
      pnlV12.Enabled = true;
      pnlV13.Enabled = true;

      SetDisabledColorForPanelsVW();

      tbxVWBreite.Text = "";
      tbxVWHoehe.Text = "";
      tbxVWBodenfreiheit.Text = "";
      tbxVWTuer.Text = "";
      tbxVWSchildLinks.Text = "";
      tbxVWSchildRechts.Text = "";

      tbxVWBreite.Enabled = false;
      tbxVWHoehe.Enabled = false;
      tbxVWBodenfreiheit.Enabled = false;
      tbxVWTuer.Enabled = false;
      tbxVWSchildLinks.Enabled = false;
      tbxVWSchildRechts.Enabled = false;
      rdbVWUKlein.Enabled = false;
      rdbVWUKlein.Checked = true;
      rdbVWUGroß.Enabled = false;
      rdbVWUGroß.Checked = false;

      tbxVWBreite.BackColor = Color.Gray;
      tbxVWHoehe.BackColor = Color.Gray;
      tbxVWBodenfreiheit.BackColor = Color.Gray;
      tbxVWTuer.BackColor = Color.Gray;
      tbxVWSchildLinks.BackColor = Color.Gray;
      tbxVWSchildRechts.BackColor = Color.Gray;

      // Reihenkabine
      tbxRKBreite.Text = "";
      tbxRKHoehe.Text = "";
      tbxRKBodenfreiheit.Text = "";
      tbxRKTuer.Text = "";
      tbxRKStkTuer.Text = "";
      tbxRKTrennwand.Text = "";
      tbxRKSchildLinks.Text = "";
      tbxRKSchildRechts.Text = "";

      // Eckkabine
      pnlEckLinks.Enabled = true;
      pnlEckRechts.Enabled = true;
      pnlEckEinzelLinks.Enabled = true;
      pnlEckEinzelRechts.Enabled = true;

      SetDisabledColorForPanelsEck();

      tbxEckBreite.Text = "";
      tbxEckHoehe.Text = "";
      tbxEckBodenfreiheit.Text = "";
      tbxEckTuer.Text = "";
      tbxEckStkTuer.Text = "";
      tbxEckTrennwand.Text = "";
      tbxEckSchildWand.Text = "";
      tbxEckSchildEck.Text = "";

      tbxEckBreite.Enabled = false;
      tbxEckHoehe.Enabled = false;
      tbxEckBodenfreiheit.Enabled = false;
      tbxEckTuer.Enabled = false;
      tbxEckStkTuer.Enabled = false;
      tbxEckTrennwand.Enabled = false;
      tbxEckSchildWand.Enabled = false;
      tbxEckSchildEck.Enabled = false;


      rdbEckUKlein.Enabled = false;
      rdbEckUKlein.Checked = true;
      rdbEckUGross.Enabled = false;
      rdbEckUGross.Checked = false;

      tbxEckBreite.BackColor = Color.Gray;
      tbxEckHoehe.BackColor = Color.Gray;
      tbxEckBodenfreiheit.BackColor = Color.Gray;
      tbxEckTuer.BackColor = Color.Gray;
      tbxEckStkTuer.BackColor = Color.Gray;
      tbxEckTrennwand.BackColor = Color.Gray;
      tbxEckSchildWand.BackColor = Color.Gray;
      tbxEckSchildEck.BackColor = Color.Gray;

      // Sonderkabine
      SetDisabledColorForPanelsSK();

      tbxSKBreite.Text = "";
      tbxSKEckschild.Text = "";
      tbxSKHoehe.Text = "";
      tbxSKMittelschildL.Text = "";
      tbxSKMittelschildR.Text = "";
      tbxSKStkTuer.Text = "";
      tbxSKTrennwand.Text = "";
      tbxSKTuer.Text = "";
      tbxSKWandschild.Text = "";
      tbxSKBodenfreiheit.Text = "";

      tbxSKBreite.Enabled = false;
      tbxSKEckschild.Enabled = false;
      tbxSKHoehe.Enabled = false;
      tbxSKMittelschildL.Enabled = false;
      tbxSKMittelschildR.Enabled = false;
      tbxSKStkTuer.Enabled = false;
      tbxSKTrennwand.Enabled = false;
      tbxSKTuer.Enabled = false;
      tbxSKWandschild.Enabled = false;
      tbxSKBodenfreiheit.Enabled = false;

      rdbSKUGross.Enabled = false;
      rdbSKUGross.Checked = false;
      rdbSKUklein.Enabled = false;
      rdbSKUklein.Checked = true;

      tbxSKBreite.BackColor = Color.Gray;
      tbxSKEckschild.BackColor = Color.Gray;
      tbxSKHoehe.BackColor = Color.Gray;
      tbxSKMittelschildL.BackColor = Color.Gray;
      tbxSKMittelschildR.BackColor = Color.Gray;
      tbxSKStkTuer.BackColor = Color.Gray;
      tbxSKTrennwand.BackColor = Color.Gray;
      tbxSKTuer.BackColor = Color.Gray;
      tbxSKWandschild.BackColor = Color.Gray;
      tbxSKBodenfreiheit.BackColor = Color.Gray;

      //Schamwand
      SetDisabledColorForPanelsSW();

      tbxSWStk.Text = "";
      tbxSWBodenfreiheit.Text = "";
      tbxSWBreite.Text = "";
      tbxSWHoehe.Text = "";

      tbxSWStk.Enabled = false;
      tbxSWBodenfreiheit.Enabled = false;
      tbxSWBreite.Enabled = false;
      tbxSWHoehe.Enabled = false;

      tbxSWStk.BackColor = Color.Gray;
      tbxSWBodenfreiheit.BackColor = Color.Gray;
      tbxSWBreite.BackColor = Color.Gray;
      tbxSWHoehe.BackColor = Color.Gray;


      //Schild / Trennwand
      SetDisabledColorForPanelsST();

      tbxSTStk.Text = "";
      tbxSTBreiteSchild.Text = "";
      tbxSTBreiteAussp.Text = "";
      tbxSTHoehe.Text = "";
      tbxSTHoeheBruestung.Text = "";
      tbxSTBodenfreiheit.Text = "";

      tbxSTStk.Enabled = false;
      tbxSTBreiteSchild.Enabled = false;
      tbxSTBreiteAussp.Enabled = false;
      tbxSTHoehe.Enabled = false;
      tbxSTHoeheBruestung.Enabled = false;
      tbxSTBodenfreiheit.Enabled = false;

      tbxSTStk.BackColor = Color.Gray;
      tbxSTBreiteSchild.BackColor = Color.Gray;
      tbxSTBreiteAussp.BackColor = Color.Gray;
      tbxSTHoehe.BackColor = Color.Gray;
      tbxSTHoeheBruestung.BackColor = Color.Gray;
      tbxSTBodenfreiheit.BackColor = Color.Gray;


      // Anzeigebereich
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = "";
    }

    #endregion

    #region Vorderwand

    /// <summary>
    /// Setzt die Hintergrundfarbe aller Panles im Tab "Vorderwände" auf die Disabled-Farbe.
    /// </summary>
    private void SetDisabledColorForPanelsVW()
    {
      pnlV10.BackColor = Color.Gray;
      pnlV11.BackColor = Color.Gray;
      pnlV12.BackColor = Color.Gray;
      pnlV13.BackColor = Color.Gray;
    }

    /// <summary>
    /// Setzt alle Eingabecontrols im Tab "Vorderwände" auf den Defaultzustand.
    /// </summary>
    private void ClearControlssVW()
    {
      tbxVWBreite.Text = "";
      tbxVWHoehe.Text = "";
      tbxVWBodenfreiheit.Text = "";
      tbxVWTuer.Text = "";
      tbxVWSchildLinks.Text = "";
      tbxVWSchildRechts.Text = "";
      rdbVWUKlein.Checked = true;
      rdbVWUGroß.Checked = false;
    }

    /// <summary>
    /// Setzt für ale Eingabecontrols im Tab "Vorderwände" die Eigenschaft "Enabled" auf true
    /// </summary>
    private void EnableControlsVW()
    {
      tbxVWBreite.Enabled = true;
      tbxVWHoehe.Enabled = true;
      tbxVWBodenfreiheit.Enabled = true;
      tbxVWTuer.Enabled = true;
      tbxVWSchildLinks.Enabled = true;
      tbxVWSchildRechts.Enabled = true;
      rdbVWUKlein.Enabled = true;
      rdbVWUKlein.Checked = true;
      rdbVWUGroß.Enabled = true;

      tbxVWBreite.BackColor = Color.FromArgb(255, 255, 192);
      tbxVWHoehe.BackColor = Color.FromArgb(255, 255, 192);
      tbxVWBodenfreiheit.BackColor = Color.FromArgb(255, 255, 192);
      tbxVWTuer.BackColor = Color.FromArgb(255, 255, 192);
      tbxVWSchildLinks.BackColor = Color.FromArgb(255, 255, 192);
      tbxVWSchildRechts.BackColor = Color.FromArgb(255, 255, 192);
    }

    /// <summary>
    /// Diese Methode zeichnet die Labels fü die selektierte Vorderwand.
    /// </summary>
    /// <param name="typ">Typ der zu zeichnenden Vorderwand</param>
    private void DrawLabelsVW(int typ)
    {
      var lblPnlTuerbreite = new System.Windows.Forms.Label();
      var lblPnlSchildLinks = new System.Windows.Forms.Label();
      var lblPnlSchildRechts = new System.Windows.Forms.Label();
      var lblPnlBreite = new System.Windows.Forms.Label();
      var lblPnlHoeheBodenfreiheit = new System.Windows.Forms.Label();

      string hoehe = ((Vorderwand)lbxPositionen.SelectedItem).Hoehe.ToString();
      string bodenfreiheit = ((Vorderwand)lbxPositionen.SelectedItem).Bodenfreiheit.ToString();

      switch (typ)
      {
        case 10:
          //lblPnlTuerbreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlTuerbreite.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
          lblPnlTuerbreite.Location = new Point(100, 140);
          lblPnlTuerbreite.Name = "lblPnlTuerbreite";
          lblPnlTuerbreite.Size = new Size(80, 20);
          lblPnlTuerbreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);
          lblPnlTuerbreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Tuerbreite.ToString();
          pnlDraw.Controls.Add(lblPnlTuerbreite);

          // Label für Schild-Links

          //lblPnlSchildLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildLinks.Location = new Point(20, 170);
          lblPnlSchildLinks.Name = "lblPnlSchildLinks";
          lblPnlSchildLinks.Size = new Size(70, 20);
          lblPnlSchildLinks.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildLinks.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildlinks.ToString();
          pnlDraw.Controls.Add(lblPnlSchildLinks);

          // Label für Schild-Rechts

          //lblPnlSchildRechts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildRechts.Location = new Point(230, 170);
          lblPnlSchildRechts.Name = "lblPnlSchildRechts";
          lblPnlSchildRechts.Size = new Size(55, 20);
          lblPnlSchildRechts.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildRechts.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildrechts.ToString();
          pnlDraw.Controls.Add(lblPnlSchildRechts);

          // Label für Breite

          //lblPnlBreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlBreite.Location = new Point(110, 210);
          lblPnlBreite.Name = "lblPnlBreite";
          lblPnlBreite.Size = new Size(70, 20);
          lblPnlBreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlBreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Breite.ToString();
          pnlDraw.Controls.Add(lblPnlBreite);

          // Label für Höhe / Bodenfreiheit

          //lblPnlHoeheBodenfreiheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlHoeheBodenfreiheit.Location = new Point(110, 20);
          lblPnlHoeheBodenfreiheit.Name = "lblPnlHoeheBodenfreiheit";
          lblPnlHoeheBodenfreiheit.Size = new Size(150, 20);
          lblPnlHoeheBodenfreiheit.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlHoeheBodenfreiheit.Text = hoehe + " / " + bodenfreiheit;
          pnlDraw.Controls.Add(lblPnlHoeheBodenfreiheit);
          break;

        case 11:

          //lblPnlTuerbreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlTuerbreite.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
          lblPnlTuerbreite.Location = new Point(80, 140);
          lblPnlTuerbreite.Name = "lblPnlTuerbreite";
          lblPnlTuerbreite.Size = new Size(80, 20);
          lblPnlTuerbreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);
          lblPnlTuerbreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Tuerbreite.ToString();
          pnlDraw.Controls.Add(lblPnlTuerbreite);

          // Label für Schild-Links

          //lblPnlSchildLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildLinks.Location = new Point(20, 170);
          lblPnlSchildLinks.Name = "lblPnlSchildLinks";
          lblPnlSchildLinks.Size = new Size(70, 20);
          lblPnlSchildLinks.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildLinks.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildlinks.ToString();
          pnlDraw.Controls.Add(lblPnlSchildLinks);

          // Label für Schild-Rechts

          //lblPnlSchildRechts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildRechts.Location = new Point(200, 170);
          lblPnlSchildRechts.Name = "lblPnlSchildRechts";
          lblPnlSchildRechts.Size = new Size(70, 20);
          lblPnlSchildRechts.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildRechts.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildrechts.ToString();
          pnlDraw.Controls.Add(lblPnlSchildRechts);

          // Label für Breite

          //lblPnlBreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlBreite.Location = new Point(110, 210);
          lblPnlBreite.Name = "lblPnlBreite";
          lblPnlBreite.Size = new Size(70, 20);
          lblPnlBreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlBreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Breite.ToString();
          pnlDraw.Controls.Add(lblPnlBreite);

          // Label für Höhe / Bodenfreiheit

          //lblPnlHoeheBodenfreiheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlHoeheBodenfreiheit.Location = new Point(110, 20);
          lblPnlHoeheBodenfreiheit.Name = "lblPnlHoeheBodenfreiheit";
          lblPnlHoeheBodenfreiheit.Size = new Size(150, 20);
          lblPnlHoeheBodenfreiheit.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlHoeheBodenfreiheit.Text = hoehe + " / " + bodenfreiheit;
          pnlDraw.Controls.Add(lblPnlHoeheBodenfreiheit);
          break;

        case 12:
          //lblPnlTuerbreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlTuerbreite.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
          lblPnlTuerbreite.Location = new Point(130, 140);
          lblPnlTuerbreite.Name = "lblPnlTuerbreite";
          lblPnlTuerbreite.Size = new Size(80, 20);
          lblPnlTuerbreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);
          lblPnlTuerbreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Tuerbreite.ToString();
          pnlDraw.Controls.Add(lblPnlTuerbreite);

          // Label für Schild-Links

          //lblPnlSchildLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildLinks.Location = new Point(20, 170);
          lblPnlSchildLinks.Name = "lblPnlSchildLinks";
          lblPnlSchildLinks.Size = new Size(70, 20);
          lblPnlSchildLinks.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildLinks.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildlinks.ToString();
          pnlDraw.Controls.Add(lblPnlSchildLinks);

          // Label für Schild-Rechts

          //lblPnlSchildRechts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildRechts.Location = new Point(230, 170);
          lblPnlSchildRechts.Name = "lblPnlSchildRechts";
          lblPnlSchildRechts.Size = new Size(60, 20);
          lblPnlSchildRechts.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildRechts.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildrechts.ToString();
          pnlDraw.Controls.Add(lblPnlSchildRechts);

          // Label für Breite

          //lblPnlBreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlBreite.Location = new Point(110, 210);
          lblPnlBreite.Name = "lblPnlBreite";
          lblPnlBreite.Size = new Size(70, 20);
          lblPnlBreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlBreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Breite.ToString();
          pnlDraw.Controls.Add(lblPnlBreite);

          // Label für Höhe / Bodenfreiheit

          //lblPnlHoeheBodenfreiheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlHoeheBodenfreiheit.Location = new Point(110, 20);
          lblPnlHoeheBodenfreiheit.Name = "lblPnlHoeheBodenfreiheit";
          lblPnlHoeheBodenfreiheit.Size = new Size(150, 20);
          lblPnlHoeheBodenfreiheit.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlHoeheBodenfreiheit.Text = hoehe + " / " + bodenfreiheit;
          pnlDraw.Controls.Add(lblPnlHoeheBodenfreiheit);
          break;

        case 13:
          //lblPnlTuerbreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlTuerbreite.TextAlign = (ContentAlignment)HorizontalAlignment.Center;
          lblPnlTuerbreite.Location = new Point(100, 140);
          lblPnlTuerbreite.Name = "lblPnlTuerbreite";
          lblPnlTuerbreite.Size = new Size(80, 20);
          lblPnlTuerbreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);
          lblPnlTuerbreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Tuerbreite.ToString();
          pnlDraw.Controls.Add(lblPnlTuerbreite);

          // Label für Schild-Links

          //lblPnlSchildLinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildLinks.Location = new Point(20, 170);
          lblPnlSchildLinks.Name = "lblPnlSchildLinks";
          lblPnlSchildLinks.Size = new Size(70, 20);
          lblPnlSchildLinks.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildLinks.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildlinks.ToString();
          pnlDraw.Controls.Add(lblPnlSchildLinks);

          // Label für Schild-Rechts

          //lblPnlSchildRechts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlSchildRechts.Location = new Point(230, 170);
          lblPnlSchildRechts.Name = "lblPnlSchildRechts";
          lblPnlSchildRechts.Size = new Size(55, 20);
          lblPnlSchildRechts.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlSchildRechts.Text = ((Vorderwand)lbxPositionen.SelectedItem).Schildrechts.ToString();
          pnlDraw.Controls.Add(lblPnlSchildRechts);

          // Label für Breite

          //lblPnlBreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlBreite.Location = new Point(110, 210);
          lblPnlBreite.Name = "lblPnlBreite";
          lblPnlBreite.Size = new Size(70, 20);
          lblPnlBreite.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlBreite.Text = ((Vorderwand)lbxPositionen.SelectedItem).Breite.ToString();
          pnlDraw.Controls.Add(lblPnlBreite);

          // Label für Höhe / Bodenfreiheit

          //lblPnlHoeheBodenfreiheit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          lblPnlHoeheBodenfreiheit.Location = new Point(110, 20);
          lblPnlHoeheBodenfreiheit.Name = "lblPnlHoeheBodenfreiheit";
          lblPnlHoeheBodenfreiheit.Size = new Size(150, 20);
          lblPnlHoeheBodenfreiheit.Font = new Font("Verdana", 9.25f, FontStyle.Bold);

          lblPnlHoeheBodenfreiheit.Text = hoehe + " / " + bodenfreiheit;
          pnlDraw.Controls.Add(lblPnlHoeheBodenfreiheit);

          break;
      }
    }

    #endregion

    #region Eckkabine

    /// <summary>
    /// Setzt die Hintergrundfarbe aller Panles im Tab "Eckkabine" auf die Disabled-Farbe.
    /// </summary>
    private void SetDisabledColorForPanelsEck()
    {
      pnlEckLinks.BackColor = Color.Gray;
      pnlEckRechts.BackColor = Color.Gray;
      pnlEckEinzelLinks.BackColor = Color.Gray;
      pnlEckEinzelRechts.BackColor = Color.Gray;
    }

    /// <summary>
    /// Setzt alle Eingabecontrols im Tab "Eckkabine" auf den Defaultzustand.
    /// </summary>
    private void ClearControlssEck()
    {
      tbxEckBreite.Text = "";
      tbxEckHoehe.Text = "";
      tbxEckBodenfreiheit.Text = "";
      tbxEckTuer.Text = "";
      tbxEckStkTuer.Text = "";
      tbxEckTrennwand.Text = "";
      tbxEckSchildWand.Text = "";
      tbxEckSchildEck.Text = "";
      rdbEckUKlein.Checked = true;
      rdbEckUGross.Checked = false;
    }

    /// <summary>
    /// Setzt für ale Eingabecontrols im Tab "Eckkabine" die Eigenschaft "Enabled" auf true
    /// </summary>
    private void EnableControlsEck()
    {
      tbxEckBreite.Enabled = true;
      tbxEckHoehe.Enabled = true;
      tbxEckBodenfreiheit.Enabled = true;
      tbxEckTuer.Enabled = true;
      tbxEckStkTuer.Enabled = true;
      tbxEckTrennwand.Enabled = true;
      tbxEckSchildWand.Enabled = true;
      tbxEckSchildEck.Enabled = true;
      rdbEckUKlein.Enabled = true;
      rdbEckUKlein.Checked = true;
      rdbEckUGross.Enabled = true;
      rdbEckUGross.Checked = false;

      tbxEckBreite.BackColor = Color.FromArgb(255, 255, 192);
      tbxEckHoehe.BackColor = Color.FromArgb(255, 255, 192);
      tbxEckBodenfreiheit.BackColor = Color.FromArgb(255, 255, 192);
      tbxEckTuer.BackColor = Color.FromArgb(255, 255, 192);
      tbxEckStkTuer.BackColor = Color.FromArgb(255, 255, 192);
      tbxEckTrennwand.BackColor = Color.FromArgb(255, 255, 192);
      tbxEckSchildWand.BackColor = Color.FromArgb(255, 255, 192);
      tbxEckSchildEck.BackColor = Color.FromArgb(255, 255, 192);
    }

    #endregion

    #region Sonderkabine

    /// <summary>
    /// Setzt die Hintergrundfarbe aller Panles im Tab "Eckkabine" auf die Disabled-Farbe.
    /// </summary>
    private void SetDisabledColorForPanelsSK()
    {
      pnlSK1.BackColor = Color.Gray;
      pnlSK2.BackColor = Color.Gray;
      pnlSK3.BackColor = Color.Gray;
      pnlSK4.BackColor = Color.Gray;
      pnlSK5.BackColor = Color.Gray;
    }

    /// <summary>
    /// Setzt alle Eingabecontrols im Tab "Eckkabine" auf den Defaultzustand.
    /// </summary>
    private void ClearControlssSK()
    {
      tbxSKBreite.Text = "";
      tbxSKHoehe.Text = "";
      tbxSKBodenfreiheit.Text = "";
      tbxSKTuer.Text = "";
      tbxSKStkTuer.Text = "";
      tbxSKTrennwand.Text = "";
      tbxSKWandschild.Text = "";
      tbxSKMittelschildL.Text = "";
      tbxSKMittelschildR.Text = "";
      tbxSKEckschild.Text = "";
      rdbSKUklein.Checked = true;
      rdbSKUGross.Checked = false;
      lblWandSchild.Text = "W-Schild";
      lblEckSchild.Text = "E-Schild";
    }

    /// <summary>
    /// Setzt für ale Eingabecontrols im Tab "Eckkabine" die Eigenschaft "Enabled" auf true
    /// </summary>
    private void EnableControlsSK()
    {
      tbxSKBreite.Enabled = true;
      tbxSKHoehe.Enabled = true;
      tbxSKBodenfreiheit.Enabled = true;
      tbxSKTuer.Enabled = true;
      tbxSKStkTuer.Enabled = true;
      tbxSKTrennwand.Enabled = true;
      tbxSKWandschild.Enabled = true;
      tbxSKMittelschildL.Enabled = true;
      tbxSKMittelschildR.Enabled = true;
      tbxSKEckschild.Enabled = true;
      rdbSKUklein.Enabled = true;
      rdbSKUklein.Checked = true;
      rdbSKUGross.Enabled = true;
      rdbSKUGross.Checked = false;

      tbxSKBreite.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKHoehe.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKBodenfreiheit.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKTuer.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKStkTuer.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKTrennwand.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKWandschild.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKMittelschildL.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKMittelschildR.BackColor = Color.FromArgb(255, 255, 192);
      tbxSKEckschild.BackColor = Color.FromArgb(255, 255, 192);
    }

    #endregion

    /// <summary>
    /// Setzt alle Eingabecontrols im Tab "Eckkabine" auf den Defaultzustand.
    /// </summary>
    private void ClearControlssRK()
    {
      tbxRKBreite.Text = "";
      tbxRKHoehe.Text = "";
      tbxRKBodenfreiheit.Text = "";
      tbxRKTuer.Text = "";
      tbxRKStkTuer.Text = "";
      tbxRKTrennwand.Text = "";
      tbxRKSchildLinks.Text = "";
      tbxRKSchildRechts.Text = "";
      rdbRKUKlein.Checked = true;
      rdbRKUGross.Checked = false;
    }

    #endregion

    private void tbxText_DoubleClick(object sender, EventArgs e)
    {
      tbxText.SelectAll();
    }

    private void pnlSK1_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 166, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 90);

      // Trennwand
      graphics.DrawLine(middlePen, 75, 10, 75, 74);

      // Mittelschild
      graphics.DrawLine(middlePen, 60, 70, 90, 70);

      // Rechte Wand
      graphics.DrawLine(middlePen, 145, 10, 145, 74);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 70, 30, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 145, 70, 125, 70);

      // Kloschüssel links
      graphics.DrawLine(middlePen, 35, 20, 50, 20);

      // Kloschüssel rechts
      graphics.DrawLine(middlePen, 100, 20, 115, 20);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlSK2_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 166, 10);

      // Linke Wand
      graphics.DrawLine(middlePen, 30, 10, 30, 74);

      // Trennwand
      graphics.DrawLine(middlePen, 95, 10, 95, 74);

      // Mittelschild
      graphics.DrawLine(middlePen, 80, 70, 110, 70);

      // Rechte Wand
      graphics.DrawLine(thinPen, 165, 10, 165, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 30, 70, 50, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 164, 70, 144, 70);

      // Kloschüssel links
      graphics.DrawLine(middlePen, 55, 20, 70, 20);

      // Kloschüssel rechts
      graphics.DrawLine(middlePen, 120, 20, 135, 20);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlSK5_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 30, 10, 166, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 30, 10, 30, 90);

      // Trennwand
      graphics.DrawLine(middlePen, 95, 10, 95, 74);

      // Mittelschild
      graphics.DrawLine(middlePen, 80, 70, 110, 70);

      // Rechte Wand
      graphics.DrawLine(thinPen, 165, 10, 165, 90);

      // Schild-Links
      graphics.DrawLine(middlePen, 30, 70, 50, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 164, 70, 144, 70);

      // Kloschüssel links
      graphics.DrawLine(middlePen, 55, 20, 70, 20);

      // Kloschüssel rechts
      graphics.DrawLine(middlePen, 120, 20, 135, 20);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlSK4_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 210, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 90);

      // Rechte Wand
      graphics.DrawLine(thinPen, 210, 10, 210, 90);

      // Trennwand Links
      graphics.DrawLine(middlePen, 75, 10, 75, 74);

      // Mittelschild Links
      graphics.DrawLine(middlePen, 60, 70, 90, 70);

      // Mittelschild Rechts
      graphics.DrawLine(middlePen, 160, 70, 130, 70);

      // Trennwand rechts
      graphics.DrawLine(middlePen, 145, 10, 145, 74);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 70, 30, 70);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 190, 70, 210, 70);

      // Kloschüssel Links
      graphics.DrawLine(middlePen, 35, 20, 50, 20);

      // Kloschüssel Mitte
      graphics.DrawLine(middlePen, 100, 20, 115, 20);

      // Kloschüssel Rechts
      graphics.DrawLine(middlePen, 165, 20, 180, 20);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlSK3_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Rückwand
      graphics.DrawLine(thinPen, 10, 10, 210, 10);

      // Linke Wand
      graphics.DrawLine(thinPen, 11, 10, 11, 70);

      // Rechte Wand
      graphics.DrawLine(thinPen, 210, 10, 210, 70);

      // Trennwand 
      graphics.DrawLine(middlePen, 105, 10, 105, 54);

      // Mittelschild 
      graphics.DrawLine(middlePen, 90, 50, 120, 50);

      // Schild-Links
      graphics.DrawLine(middlePen, 10, 50, 50, 50);

      // Schild-Rechts
      graphics.DrawLine(middlePen, 160, 50, 210, 50);

      // Kloschüssel Links
      graphics.DrawLine(middlePen, 20, 20, 20, 40);

      // Kloschüssel Rechts
      graphics.DrawLine(middlePen, 195, 20, 195, 40);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlSWFrei_Paint(object sender, PaintEventArgs e)
    {
      /*
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Links
      graphics.DrawLine(thinPen, 41, 10, 41, 90);

      // Links
      graphics.DrawLine(middlePen, 90, 27, 90, 74);

      // Oben
      graphics.DrawLine(middlePen, 40, 30, 90, 30);

      // Unten
      graphics.DrawLine(middlePen, 40, 70, 90, 70);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
       */
    }

    private void pnlSWFuss_Paint(object sender, PaintEventArgs e)
    {
      /*
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Links
      graphics.DrawLine(thinPen, 41, 10, 41, 90);

      // Rechts
      graphics.DrawLine(middlePen, 90, 17, 90, 90);

      // Oben
      graphics.DrawLine(middlePen, 40, 20, 90, 20);

      // Unten
      graphics.DrawLine(middlePen, 40, 80, 90, 80);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
      */
    }

    private void lblSWFrei_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Schamwand) & ((Schamwand)lbxPositionen.SelectedItem).Artikel != "frei")
        {
          DeselectAllItems();
        }
      }

      _schamwandArtikel = "frei";
      SetDisabledColorForPanelsSW();
      pnlSWFrei.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssSW();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsSW();

      tbxSWStk.Focus();
    }

    private void SetDisabledColorForPanelsST()
    {
      pnlSchildLinks.BackColor = Color.Gray;
      pnlSchildRechts.BackColor = Color.Gray;
      pnlTrennwand.BackColor = Color.Gray;
    }

    private void ClearControlssST()
    {
      tbxSTStk.Text = "";
      tbxSTBreiteSchild.Text = "";
      tbxSTBreiteAussp.Text = "";
      tbxSTHoehe.Text = "";
      tbxSTHoeheBruestung.Text = "";
      tbxSTBodenfreiheit.Text = "";
    }

    private void EnableControlsST()
    {

      tbxSTStk.Enabled = true;
      tbxSTBreiteSchild.Enabled = true;
      tbxSTBreiteAussp.Enabled = true;
      tbxSTHoehe.Enabled = true;
      tbxSTHoeheBruestung.Enabled = true;
      tbxSTBodenfreiheit.Enabled = true;

      tbxSTStk.BackColor = Color.FromArgb(255, 255, 192);
      tbxSTBreiteSchild.BackColor = Color.FromArgb(255, 255, 192);
      tbxSTBreiteAussp.BackColor = Color.FromArgb(255, 255, 192);
      tbxSTHoehe.BackColor = Color.FromArgb(255, 255, 192);
      tbxSTHoeheBruestung.BackColor = Color.FromArgb(255, 255, 192);
      tbxSTBodenfreiheit.BackColor = Color.FromArgb(255, 255, 192);
    }

    /// <summary>
    /// Setzt die Hintergrundfarbe aller Panles im Tab "Schamwand" auf die Disabled-Farbe.
    /// </summary>
    private void SetDisabledColorForPanelsSW()
    {
      pnlSWFrei.BackColor = Color.Gray;
      pnlSWFuss.BackColor = Color.Gray;
    }

    /// <summary>
    /// Setzt alle Eingabecontrols im Tab "Schamwand" auf den Defaultzustand.
    /// </summary>
    private void ClearControlssSW()
    {
      tbxSWStk.Text = "";
      tbxSWBreite.Text = "";
      tbxSWHoehe.Text = "";
      tbxSWBodenfreiheit.Text = "";
    }

    /// <summary>
    /// Setzt für ale Eingabecontrols im Tab "Schamwand" die Eigenschaft "Enabled" auf true
    /// </summary>
    private void EnableControlsSW()
    {
      tbxSWStk.Enabled = true;
      tbxSWBreite.Enabled = true;
      tbxSWHoehe.Enabled = true;
      tbxSWBodenfreiheit.Enabled = true;

      tbxSWStk.BackColor = Color.FromArgb(255, 255, 192);
      tbxSWBreite.BackColor = Color.FromArgb(255, 255, 192);
      tbxSWHoehe.BackColor = Color.FromArgb(255, 255, 192);
      tbxSWBodenfreiheit.BackColor = Color.FromArgb(255, 255, 192);

    }

    private void lblSWFuss_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Schamwand) & ((Schamwand)lbxPositionen.SelectedItem).Artikel != "fuss")
        {
          DeselectAllItems();
        }
      }

      _schamwandArtikel = "fuss";
      SetDisabledColorForPanelsSW();
      pnlSWFuss.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssSW();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsSW();

      tbxSWStk.Focus();
    }

    private void btnPosUp_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        object selected = lbxPositionen.SelectedItem;
        int indx = lbxPositionen.Items.IndexOf(selected);
        int totl = lbxPositionen.Items.Count;

        if (indx == 0)
        {
          //  lbxPositionen.Items.Remove(selected);
          //  lbxPositionen.Items.Insert(totl - 1, selected);
          //  lbxPositionen.SetSelected(totl - 1, true);
        }
        else
        {
          lbxPositionen.Items.Remove(selected);
          lbxPositionen.Items.Insert(indx - 1, selected);
          lbxPositionen.SetSelected(indx - 1, true);
        }
      }
    }

    private void btnPosDown_Click(object sender, EventArgs e)
    {
      if (lbxPositionen.SelectedItems.Count > 0)
      {
        object selected = lbxPositionen.SelectedItem;
        int indx = lbxPositionen.Items.IndexOf(selected);
        int totl = lbxPositionen.Items.Count;

        if (indx == totl - 1)
        {
          //lbxPositionen.Items.Remove(selected);
          //lbxPositionen.Items.Insert(0, selected);
          //lbxPositionen.SetSelected(0, true);
        }
        else
        {
          lbxPositionen.Items.Remove(selected);
          lbxPositionen.Items.Insert(indx + 1, selected);
          lbxPositionen.SetSelected(indx + 1, true);
        }
      }
    }


    private void lblSchildLinks_Click(object sender, EventArgs e)
    {
      _schildOrTrennwand = "schildLinks";

      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() != typeof(Schild))
        {
          DeselectAllItems();
        }
        else if (((Schild)lbxPositionen.SelectedItem).Artikel != "schildLinks")
        {
          DeselectAllItems();
        }

      }

      SetDisabledColorForPanelsST();
      pnlSchildLinks.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssST();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsST();

      tbxSTStk.Focus();
    }

    private void lblSchildRechts_Click(object sender, EventArgs e)
    {
      _schildOrTrennwand = "schildRechts";

      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() != typeof(Schild))
        {
          DeselectAllItems();
        }
        else if (((Schild)lbxPositionen.SelectedItem).Artikel != "schildRechts")
        {
          DeselectAllItems();
        }

      }

      SetDisabledColorForPanelsST();
      pnlSchildRechts.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssST();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsST();

      tbxSTStk.Focus();
    }

    private void lblTrennwand_Click(object sender, EventArgs e)
    {

      _schildOrTrennwand = "trennwand";

      if (lbxPositionen.SelectedItems.Count > 0)
      {
        if (lbxPositionen.SelectedItem.GetType() == typeof(Trennwand) && (_schildOrTrennwand != "trennwand"))
        {
          DeselectAllItems();
        }
      }

      SetDisabledColorForPanelsST();
      pnlTrennwand.BackColor = Color.FromArgb(255, 255, 192);
      ClearControlssST();
      pnlDraw.Controls.Clear();
      pnlDraw.Refresh();

      lblMaße.Text = String.Empty;

      EnableControlsST();

      tbxSTStk.Focus();
    }

    private void pnlSchildLinks_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Oben
      graphics.DrawLine(thinPen, 30, 10, 145, 10);

      // Unten
      graphics.DrawLine(thinPen, 70, 74, 145, 74);

      // Aussparung-Unten
      graphics.DrawLine(thinPen, 30, 45, 70, 45);

      // Linke Wand
      graphics.DrawLine(thinPen, 30, 10, 30, 45);

      // Rechte Wand
      graphics.DrawLine(thinPen, 145, 10, 145, 74);

      // Mittlere Wand
      graphics.DrawLine(thinPen, 70, 10, 70, 74);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlSchildRechts_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Oben
      graphics.DrawLine(thinPen, 30, 10, 145, 10);

      // Unten
      graphics.DrawLine(thinPen, 30, 74, 100, 74);

      // Aussparung-Unten
      graphics.DrawLine(thinPen, 100, 45, 145, 45);

      // Linke Wand
      graphics.DrawLine(thinPen, 30, 10, 30, 74);

      // Rechte Wand
      graphics.DrawLine(thinPen, 145, 10, 145, 45);

      // Mittlere Wand
      graphics.DrawLine(thinPen, 100, 10, 100, 74);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

    private void pnlTrennwand_Paint(object sender, PaintEventArgs e)
    {
      Graphics graphics = e.Graphics;
      //graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

      Pen thickPen = new Pen(Color.Black, 10);
      Pen middlePen = new Pen(Color.Black, 7);
      Pen thinPen = new Pen(Color.Black, 2);

      // Oben
      graphics.DrawLine(thinPen, 30, 10, 145, 10);

      // Unten
      graphics.DrawLine(thinPen, 30, 74, 100, 74);

      // Aussparung-Unten
      graphics.DrawLine(thinPen, 100, 45, 145, 45);

      // Linke Wand
      graphics.DrawLine(thinPen, 30, 10, 30, 74);

      // Rechte Wand
      graphics.DrawLine(thinPen, 145, 10, 145, 45);

      // Mittlere Wand
      graphics.DrawLine(thinPen, 100, 10, 100, 74);

      thinPen.Dispose();
      middlePen.Dispose();
      thickPen.Dispose();
      graphics.Dispose();
    }

  }


}