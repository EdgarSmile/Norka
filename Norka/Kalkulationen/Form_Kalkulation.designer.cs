using System.Windows.Forms;

namespace Norka.Kalkulationen
{
  partial class Form_Kalkualtion
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kalkualtion));
      this.gbxTyp = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.rdbNK = new System.Windows.Forms.RadioButton();
      this.rdbTM = new System.Windows.Forms.RadioButton();
      this.rdbTS = new System.Windows.Forms.RadioButton();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.rdbVorderwand = new System.Windows.Forms.RadioButton();
      this.rdbTrennwand = new System.Windows.Forms.RadioButton();
      this.rdbAussparung = new System.Windows.Forms.RadioButton();
      this.rdbVorOTuer = new System.Windows.Forms.RadioButton();
      this.rdbSchamwand = new System.Windows.Forms.RadioButton();
      this.rdbKabinen = new System.Windows.Forms.RadioButton();
      this.gbxParameter = new System.Windows.Forms.GroupBox();
      this.panel4 = new System.Windows.Forms.Panel();
      this.cbxVK = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbxVK = new System.Windows.Forms.TextBox();
      this.tbxZuschlag = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbxTrw = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tbxTiefe = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbxTüren = new System.Windows.Forms.TextBox();
      this.tbxAnlagen = new System.Windows.Forms.TextBox();
      this.tbxBreite = new System.Windows.Forms.TextBox();
      this.gbxErgebnisse = new System.Windows.Forms.GroupBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.tbxAlupulv = new System.Windows.Forms.TextBox();
      this.lblOberlichtG = new System.Windows.Forms.Label();
      this.tbxOberlichtLfm = new System.Windows.Forms.TextBox();
      this.tbxEinzelVK = new System.Windows.Forms.TextBox();
      this.lblVK = new System.Windows.Forms.Label();
      this.lblHundert = new System.Windows.Forms.Label();
      this.lblGesamtVK = new System.Windows.Forms.Label();
      this.cbxOberlicht = new System.Windows.Forms.CheckBox();
      this.cbxAlupulver = new System.Windows.Forms.CheckBox();
      this.cbxMontage = new System.Windows.Forms.CheckBox();
      this.label18 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.lblGesamt = new System.Windows.Forms.Label();
      this.lblEinzel = new System.Windows.Forms.Label();
      this.lblLohnPreisGesamt = new System.Windows.Forms.Label();
      this.lblLohnPreis = new System.Windows.Forms.Label();
      this.lblLohnteile = new System.Windows.Forms.Label();
      this.lblMontagePreisGesamt = new System.Windows.Forms.Label();
      this.lblMontagePreis = new System.Windows.Forms.Label();
      this.lblMontageTeile = new System.Windows.Forms.Label();
      this.lblDiverseKosten = new System.Windows.Forms.Label();
      this.lblBeschlagPreisGesamt = new System.Windows.Forms.Label();
      this.lblFixkosten = new System.Windows.Forms.Label();
      this.lblAluPreisGesamt = new System.Windows.Forms.Label();
      this.lblAluPreis = new System.Windows.Forms.Label();
      this.lblAluMenge = new System.Windows.Forms.Label();
      this.lblBeschlagPreis = new System.Windows.Forms.Label();
      this.lblBeschlagMenge = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label40 = new System.Windows.Forms.Label();
      this.label25 = new System.Windows.Forms.Label();
      this.label39 = new System.Windows.Forms.Label();
      this.label24 = new System.Windows.Forms.Label();
      this.label38 = new System.Windows.Forms.Label();
      this.label31 = new System.Windows.Forms.Label();
      this.label37 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.label29 = new System.Windows.Forms.Label();
      this.label36 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label28 = new System.Windows.Forms.Label();
      this.lblPlattenPreisGesamt = new System.Windows.Forms.Label();
      this.lblPlattenPreis = new System.Windows.Forms.Label();
      this.lblPlattenMenge = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.gbxSondertext = new System.Windows.Forms.GroupBox();
      this.panel5 = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tbxSondertextUnten = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tbxSondertextOben = new System.Windows.Forms.TextBox();
      this.btnAendSpeichern = new System.Windows.Forms.Button();
      this.btnSchließen = new System.Windows.Forms.Button();
      this.btnPosAnlegen = new System.Windows.Forms.Button();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.itemKalkulationNeu = new System.Windows.Forms.ToolStripButton();
      this.itemKalkulationSchließen = new System.Windows.Forms.ToolStripButton();
      this.tbxAussparungGesamt = new System.Windows.Forms.TextBox();
      this.label21 = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.btnKalkulieren = new System.Windows.Forms.Button();
      this.tabSwitch = new System.Windows.Forms.TabControl();
      this.gbxAussparung = new System.Windows.Forms.TabPage();
      this.cobAussaprungBeschreibung = new System.Windows.Forms.ComboBox();
      this.cbxSonderartikelEinheit = new System.Windows.Forms.ComboBox();
      this.tbxAussparungenPreis = new System.Windows.Forms.TextBox();
      this.label26 = new System.Windows.Forms.Label();
      this.tabAlternativ = new System.Windows.Forms.TabPage();
      this.gpxAlternativ2 = new System.Windows.Forms.GroupBox();
      this.cbxAlternativ2 = new System.Windows.Forms.CheckBox();
      this.Alternativpanel2 = new System.Windows.Forms.Panel();
      this.tbxAlt2Preis = new System.Windows.Forms.TextBox();
      this.label30 = new System.Windows.Forms.Label();
      this.rdbNK2 = new System.Windows.Forms.RadioButton();
      this.rdbTM2 = new System.Windows.Forms.RadioButton();
      this.rdbTS2 = new System.Windows.Forms.RadioButton();
      this.gpxAlternativ1 = new System.Windows.Forms.GroupBox();
      this.cbxAlternativ1 = new System.Windows.Forms.CheckBox();
      this.Alternativpanel1 = new System.Windows.Forms.Panel();
      this.tbxAlt1Preis = new System.Windows.Forms.TextBox();
      this.label27 = new System.Windows.Forms.Label();
      this.rdbNK1 = new System.Windows.Forms.RadioButton();
      this.rdbTM1 = new System.Windows.Forms.RadioButton();
      this.rdbTS1 = new System.Windows.Forms.RadioButton();
      this.pnlSteuerung = new System.Windows.Forms.Panel();
      this.cbxEventual = new System.Windows.Forms.CheckBox();
      this.grpSteuerung = new System.Windows.Forms.GroupBox();
      this.gbxTyp.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.panel2.SuspendLayout();
      this.gbxParameter.SuspendLayout();
      this.panel4.SuspendLayout();
      this.gbxErgebnisse.SuspendLayout();
      this.panel3.SuspendLayout();
      this.gbxSondertext.SuspendLayout();
      this.panel5.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.tabSwitch.SuspendLayout();
      this.gbxAussparung.SuspendLayout();
      this.tabAlternativ.SuspendLayout();
      this.gpxAlternativ2.SuspendLayout();
      this.Alternativpanel2.SuspendLayout();
      this.gpxAlternativ1.SuspendLayout();
      this.Alternativpanel1.SuspendLayout();
      this.pnlSteuerung.SuspendLayout();
      this.grpSteuerung.SuspendLayout();
      this.SuspendLayout();
      // 
      // gbxTyp
      // 
      this.gbxTyp.Controls.Add(this.panel1);
      this.gbxTyp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbxTyp.Location = new System.Drawing.Point(31, 45);
      this.gbxTyp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.gbxTyp.Name = "gbxTyp";
      this.gbxTyp.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.gbxTyp.Size = new System.Drawing.Size(347, 65);
      this.gbxTyp.TabIndex = 1;
      this.gbxTyp.TabStop = false;
      this.gbxTyp.Text = "Typ";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.rdbNK);
      this.panel1.Controls.Add(this.rdbTM);
      this.panel1.Controls.Add(this.rdbTS);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.panel1.Location = new System.Drawing.Point(5, 17);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(337, 45);
      this.panel1.TabIndex = 0;
      // 
      // rdbNK
      // 
      this.rdbNK.AutoSize = true;
      this.rdbNK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbNK.ForeColor = System.Drawing.Color.Blue;
      this.rdbNK.Location = new System.Drawing.Point(252, 13);
      this.rdbNK.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbNK.Name = "rdbNK";
      this.rdbNK.Size = new System.Drawing.Size(42, 17);
      this.rdbNK.TabIndex = 2;
      this.rdbNK.Text = "NK";
      this.rdbNK.UseVisualStyleBackColor = true;
      this.rdbNK.CheckedChanged += new System.EventHandler(this.rdbNK_CheckedChanged);
      // 
      // rdbTM
      // 
      this.rdbTM.AutoSize = true;
      this.rdbTM.Checked = true;
      this.rdbTM.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbTM.ForeColor = System.Drawing.Color.Brown;
      this.rdbTM.Location = new System.Drawing.Point(42, 13);
      this.rdbTM.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbTM.Name = "rdbTM";
      this.rdbTM.Size = new System.Drawing.Size(43, 17);
      this.rdbTM.TabIndex = 0;
      this.rdbTM.TabStop = true;
      this.rdbTM.Text = "TM";
      this.rdbTM.UseVisualStyleBackColor = true;
      this.rdbTM.CheckedChanged += new System.EventHandler(this.rdbTM_CheckedChanged);
      // 
      // rdbTS
      // 
      this.rdbTS.AutoSize = true;
      this.rdbTS.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbTS.ForeColor = System.Drawing.Color.Fuchsia;
      this.rdbTS.Location = new System.Drawing.Point(148, 13);
      this.rdbTS.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbTS.Name = "rdbTS";
      this.rdbTS.Size = new System.Drawing.Size(41, 17);
      this.rdbTS.TabIndex = 1;
      this.rdbTS.Text = "TS";
      this.rdbTS.UseVisualStyleBackColor = true;
      this.rdbTS.CheckedChanged += new System.EventHandler(this.rdbTS_CheckedChanged);
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.panel2);
      this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox4.Location = new System.Drawing.Point(394, 45);
      this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.groupBox4.Size = new System.Drawing.Size(726, 65);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Artikel";
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.rdbVorderwand);
      this.panel2.Controls.Add(this.rdbTrennwand);
      this.panel2.Controls.Add(this.rdbAussparung);
      this.panel2.Controls.Add(this.rdbVorOTuer);
      this.panel2.Controls.Add(this.rdbSchamwand);
      this.panel2.Controls.Add(this.rdbKabinen);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.panel2.Location = new System.Drawing.Point(5, 17);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(716, 45);
      this.panel2.TabIndex = 0;
      // 
      // rdbVorderwand
      // 
      this.rdbVorderwand.AutoSize = true;
      this.rdbVorderwand.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbVorderwand.Location = new System.Drawing.Point(15, 16);
      this.rdbVorderwand.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbVorderwand.Name = "rdbVorderwand";
      this.rdbVorderwand.Size = new System.Drawing.Size(103, 17);
      this.rdbVorderwand.TabIndex = 0;
      this.rdbVorderwand.Text = "Vorderwand";
      this.rdbVorderwand.UseVisualStyleBackColor = true;
      this.rdbVorderwand.CheckedChanged += new System.EventHandler(this.rdbVorderwand_CheckedChanged);
      // 
      // rdbTrennwand
      // 
      this.rdbTrennwand.AutoSize = true;
      this.rdbTrennwand.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbTrennwand.Location = new System.Drawing.Point(241, 16);
      this.rdbTrennwand.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbTrennwand.Name = "rdbTrennwand";
      this.rdbTrennwand.Size = new System.Drawing.Size(97, 17);
      this.rdbTrennwand.TabIndex = 2;
      this.rdbTrennwand.Text = "Trennwand";
      this.rdbTrennwand.UseVisualStyleBackColor = true;
      this.rdbTrennwand.CheckedChanged += new System.EventHandler(this.rdbTrennwand_CheckedChanged);
      // 
      // rdbAussparung
      // 
      this.rdbAussparung.AutoSize = true;
      this.rdbAussparung.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbAussparung.Location = new System.Drawing.Point(591, 16);
      this.rdbAussparung.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbAussparung.Name = "rdbAussparung";
      this.rdbAussparung.Size = new System.Drawing.Size(114, 17);
      this.rdbAussparung.TabIndex = 5;
      this.rdbAussparung.Text = "Sonderartikel";
      this.rdbAussparung.UseVisualStyleBackColor = true;
      this.rdbAussparung.CheckedChanged += new System.EventHandler(this.rdbAussparung_CheckedChanged);
      // 
      // rdbVorOTuer
      // 
      this.rdbVorOTuer.AutoSize = true;
      this.rdbVorOTuer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbVorOTuer.Location = new System.Drawing.Point(472, 16);
      this.rdbVorOTuer.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbVorOTuer.Name = "rdbVorOTuer";
      this.rdbVorOTuer.Size = new System.Drawing.Size(103, 17);
      this.rdbVorOTuer.TabIndex = 4;
      this.rdbVorOTuer.Text = "Vorw. o. Tür";
      this.rdbVorOTuer.UseVisualStyleBackColor = true;
      this.rdbVorOTuer.CheckedChanged += new System.EventHandler(this.rdbOTrw_CheckedChanged);
      // 
      // rdbSchamwand
      // 
      this.rdbSchamwand.AutoSize = true;
      this.rdbSchamwand.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbSchamwand.Location = new System.Drawing.Point(354, 16);
      this.rdbSchamwand.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbSchamwand.Name = "rdbSchamwand";
      this.rdbSchamwand.Size = new System.Drawing.Size(102, 17);
      this.rdbSchamwand.TabIndex = 3;
      this.rdbSchamwand.Text = "Schamwand";
      this.rdbSchamwand.UseVisualStyleBackColor = true;
      this.rdbSchamwand.CheckedChanged += new System.EventHandler(this.rdbSchamwand_CheckedChanged);
      // 
      // rdbKabinen
      // 
      this.rdbKabinen.AutoSize = true;
      this.rdbKabinen.Checked = true;
      this.rdbKabinen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbKabinen.Location = new System.Drawing.Point(134, 16);
      this.rdbKabinen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbKabinen.Name = "rdbKabinen";
      this.rdbKabinen.Size = new System.Drawing.Size(91, 17);
      this.rdbKabinen.TabIndex = 1;
      this.rdbKabinen.TabStop = true;
      this.rdbKabinen.Text = "R-Kabinen";
      this.rdbKabinen.UseVisualStyleBackColor = true;
      this.rdbKabinen.CheckedChanged += new System.EventHandler(this.rdbKabinen_CheckedChanged);
      // 
      // gbxParameter
      // 
      this.gbxParameter.Controls.Add(this.panel4);
      this.gbxParameter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbxParameter.Location = new System.Drawing.Point(31, 110);
      this.gbxParameter.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.gbxParameter.Name = "gbxParameter";
      this.gbxParameter.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.gbxParameter.Size = new System.Drawing.Size(848, 111);
      this.gbxParameter.TabIndex = 3;
      this.gbxParameter.TabStop = false;
      this.gbxParameter.Text = "Parameter";
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel4.Controls.Add(this.cbxVK);
      this.panel4.Controls.Add(this.label1);
      this.panel4.Controls.Add(this.label2);
      this.panel4.Controls.Add(this.label3);
      this.panel4.Controls.Add(this.tbxVK);
      this.panel4.Controls.Add(this.tbxZuschlag);
      this.panel4.Controls.Add(this.label4);
      this.panel4.Controls.Add(this.tbxTrw);
      this.panel4.Controls.Add(this.label5);
      this.panel4.Controls.Add(this.tbxTiefe);
      this.panel4.Controls.Add(this.label14);
      this.panel4.Controls.Add(this.label6);
      this.panel4.Controls.Add(this.tbxTüren);
      this.panel4.Controls.Add(this.tbxAnlagen);
      this.panel4.Controls.Add(this.tbxBreite);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.panel4.Location = new System.Drawing.Point(5, 17);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(838, 91);
      this.panel4.TabIndex = 0;
      // 
      // cbxVK
      // 
      this.cbxVK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxVK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxVK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxVK.FormattingEnabled = true;
      this.cbxVK.Items.AddRange(new object[] {
            "Prozent",
            "Euro"});
      this.cbxVK.Location = new System.Drawing.Point(742, 54);
      this.cbxVK.Name = "cbxVK";
      this.cbxVK.Size = new System.Drawing.Size(80, 21);
      this.cbxVK.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(39, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 32);
      this.label1.TabIndex = 6;
      this.label1.Text = "Anlagen \r\nStk";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(144, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 32);
      this.label2.TabIndex = 7;
      this.label2.Text = "Breite\r\ncm";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(249, 9);
      this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 32);
      this.label3.TabIndex = 8;
      this.label3.Text = "Türen\r\nStk";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbxVK
      // 
      this.tbxVK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxVK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxVK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxVK.Location = new System.Drawing.Point(663, 55);
      this.tbxVK.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tbxVK.Name = "tbxVK";
      this.tbxVK.Size = new System.Drawing.Size(68, 21);
      this.tbxVK.TabIndex = 6;
      this.tbxVK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxVK.Enter += new System.EventHandler(this.tbxVK_Enter);
      this.tbxVK.Validating += new System.ComponentModel.CancelEventHandler(this.tbxVK_Validating);
      // 
      // tbxZuschlag
      // 
      this.tbxZuschlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxZuschlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxZuschlag.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxZuschlag.Location = new System.Drawing.Point(568, 55);
      this.tbxZuschlag.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tbxZuschlag.Name = "tbxZuschlag";
      this.tbxZuschlag.Size = new System.Drawing.Size(68, 21);
      this.tbxZuschlag.TabIndex = 5;
      this.tbxZuschlag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxZuschlag.Enter += new System.EventHandler(this.tbxZuschlag_Enter);
      this.tbxZuschlag.Validating += new System.ComponentModel.CancelEventHandler(this.tbxZuschlag_Validating);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(354, 9);
      this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 32);
      this.label4.TabIndex = 9;
      this.label4.Text = "Tiefe\r\ncm";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbxTrw
      // 
      this.tbxTrw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxTrw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxTrw.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxTrw.Location = new System.Drawing.Point(463, 55);
      this.tbxTrw.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tbxTrw.Name = "tbxTrw";
      this.tbxTrw.Size = new System.Drawing.Size(68, 21);
      this.tbxTrw.TabIndex = 4;
      this.tbxTrw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxTrw.Enter += new System.EventHandler(this.tbxTrw_Enter);
      this.tbxTrw.Validating += new System.ComponentModel.CancelEventHandler(this.tbxTrw_Validating);
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(459, 9);
      this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 32);
      this.label5.TabIndex = 10;
      this.label5.Text = "Trw\r\nStk";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbxTiefe
      // 
      this.tbxTiefe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxTiefe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxTiefe.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxTiefe.Location = new System.Drawing.Point(358, 55);
      this.tbxTiefe.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tbxTiefe.Name = "tbxTiefe";
      this.tbxTiefe.Size = new System.Drawing.Size(68, 21);
      this.tbxTiefe.TabIndex = 3;
      this.tbxTiefe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxTiefe.Enter += new System.EventHandler(this.tbxTiefe_Enter);
      this.tbxTiefe.Validating += new System.ComponentModel.CancelEventHandler(this.tbxTiefe_Validating);
      // 
      // label14
      // 
      this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(659, 9);
      this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(73, 32);
      this.label14.TabIndex = 11;
      this.label14.Text = "VK ";
      this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(564, 9);
      this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 32);
      this.label6.TabIndex = 11;
      this.label6.Text = "Zuschlag\r\nje Tür";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbxTüren
      // 
      this.tbxTüren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxTüren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxTüren.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxTüren.Location = new System.Drawing.Point(253, 55);
      this.tbxTüren.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tbxTüren.Name = "tbxTüren";
      this.tbxTüren.Size = new System.Drawing.Size(68, 21);
      this.tbxTüren.TabIndex = 2;
      this.tbxTüren.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxTüren.Enter += new System.EventHandler(this.tbxTüren_Enter);
      this.tbxTüren.Validating += new System.ComponentModel.CancelEventHandler(this.tbxTüren_Validating);
      // 
      // tbxAnlagen
      // 
      this.tbxAnlagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAnlagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAnlagen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAnlagen.Location = new System.Drawing.Point(43, 55);
      this.tbxAnlagen.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tbxAnlagen.Name = "tbxAnlagen";
      this.tbxAnlagen.Size = new System.Drawing.Size(68, 21);
      this.tbxAnlagen.TabIndex = 0;
      this.tbxAnlagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAnlagen.Enter += new System.EventHandler(this.tbxAnlagen_Enter);
      this.tbxAnlagen.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAnlagen_Validating);
      // 
      // tbxBreite
      // 
      this.tbxBreite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxBreite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxBreite.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxBreite.Location = new System.Drawing.Point(148, 55);
      this.tbxBreite.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.tbxBreite.Name = "tbxBreite";
      this.tbxBreite.Size = new System.Drawing.Size(68, 21);
      this.tbxBreite.TabIndex = 1;
      this.tbxBreite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxBreite.Enter += new System.EventHandler(this.tbxBreite_Enter);
      this.tbxBreite.Validating += new System.ComponentModel.CancelEventHandler(this.tbxBreite_Validating);
      // 
      // gbxErgebnisse
      // 
      this.gbxErgebnisse.Controls.Add(this.panel3);
      this.gbxErgebnisse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbxErgebnisse.Location = new System.Drawing.Point(31, 221);
      this.gbxErgebnisse.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.gbxErgebnisse.Name = "gbxErgebnisse";
      this.gbxErgebnisse.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.gbxErgebnisse.Size = new System.Drawing.Size(535, 412);
      this.gbxErgebnisse.TabIndex = 6;
      this.gbxErgebnisse.TabStop = false;
      this.gbxErgebnisse.Text = "Ergebnisse";
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.tbxAlupulv);
      this.panel3.Controls.Add(this.lblOberlichtG);
      this.panel3.Controls.Add(this.tbxOberlichtLfm);
      this.panel3.Controls.Add(this.tbxEinzelVK);
      this.panel3.Controls.Add(this.lblVK);
      this.panel3.Controls.Add(this.lblHundert);
      this.panel3.Controls.Add(this.lblGesamtVK);
      this.panel3.Controls.Add(this.cbxOberlicht);
      this.panel3.Controls.Add(this.cbxAlupulver);
      this.panel3.Controls.Add(this.cbxMontage);
      this.panel3.Controls.Add(this.label18);
      this.panel3.Controls.Add(this.label17);
      this.panel3.Controls.Add(this.label13);
      this.panel3.Controls.Add(this.label12);
      this.panel3.Controls.Add(this.label11);
      this.panel3.Controls.Add(this.label10);
      this.panel3.Controls.Add(this.label9);
      this.panel3.Controls.Add(this.lblGesamt);
      this.panel3.Controls.Add(this.lblEinzel);
      this.panel3.Controls.Add(this.lblLohnPreisGesamt);
      this.panel3.Controls.Add(this.lblLohnPreis);
      this.panel3.Controls.Add(this.lblLohnteile);
      this.panel3.Controls.Add(this.lblMontagePreisGesamt);
      this.panel3.Controls.Add(this.lblMontagePreis);
      this.panel3.Controls.Add(this.lblMontageTeile);
      this.panel3.Controls.Add(this.lblDiverseKosten);
      this.panel3.Controls.Add(this.lblBeschlagPreisGesamt);
      this.panel3.Controls.Add(this.lblFixkosten);
      this.panel3.Controls.Add(this.lblAluPreisGesamt);
      this.panel3.Controls.Add(this.lblAluPreis);
      this.panel3.Controls.Add(this.lblAluMenge);
      this.panel3.Controls.Add(this.lblBeschlagPreis);
      this.panel3.Controls.Add(this.lblBeschlagMenge);
      this.panel3.Controls.Add(this.label8);
      this.panel3.Controls.Add(this.label40);
      this.panel3.Controls.Add(this.label25);
      this.panel3.Controls.Add(this.label39);
      this.panel3.Controls.Add(this.label24);
      this.panel3.Controls.Add(this.label38);
      this.panel3.Controls.Add(this.label31);
      this.panel3.Controls.Add(this.label37);
      this.panel3.Controls.Add(this.label19);
      this.panel3.Controls.Add(this.label29);
      this.panel3.Controls.Add(this.label36);
      this.panel3.Controls.Add(this.label16);
      this.panel3.Controls.Add(this.label20);
      this.panel3.Controls.Add(this.label15);
      this.panel3.Controls.Add(this.label28);
      this.panel3.Controls.Add(this.lblPlattenPreisGesamt);
      this.panel3.Controls.Add(this.lblPlattenPreis);
      this.panel3.Controls.Add(this.lblPlattenMenge);
      this.panel3.Controls.Add(this.label7);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.panel3.Location = new System.Drawing.Point(5, 17);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(525, 392);
      this.panel3.TabIndex = 0;
      // 
      // tbxAlupulv
      // 
      this.tbxAlupulv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
      this.tbxAlupulv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAlupulv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAlupulv.Location = new System.Drawing.Point(14, 255);
      this.tbxAlupulv.Name = "tbxAlupulv";
      this.tbxAlupulv.Size = new System.Drawing.Size(83, 21);
      this.tbxAlupulv.TabIndex = 51;
      this.tbxAlupulv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAlupulv.WordWrap = false;
      // 
      // lblOberlichtG
      // 
      this.lblOberlichtG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblOberlichtG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblOberlichtG.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblOberlichtG.Location = new System.Drawing.Point(186, 318);
      this.lblOberlichtG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblOberlichtG.Name = "lblOberlichtG";
      this.lblOberlichtG.Size = new System.Drawing.Size(37, 21);
      this.lblOberlichtG.TabIndex = 50;
      this.lblOberlichtG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // tbxOberlichtLfm
      // 
      this.tbxOberlichtLfm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxOberlichtLfm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxOberlichtLfm.Enabled = false;
      this.tbxOberlichtLfm.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxOberlichtLfm.Location = new System.Drawing.Point(107, 318);
      this.tbxOberlichtLfm.Name = "tbxOberlichtLfm";
      this.tbxOberlichtLfm.Size = new System.Drawing.Size(37, 21);
      this.tbxOberlichtLfm.TabIndex = 4;
      this.tbxOberlichtLfm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // tbxEinzelVK
      // 
      this.tbxEinzelVK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(125)))));
      this.tbxEinzelVK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxEinzelVK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxEinzelVK.Location = new System.Drawing.Point(305, 317);
      this.tbxEinzelVK.Name = "tbxEinzelVK";
      this.tbxEinzelVK.Size = new System.Drawing.Size(83, 21);
      this.tbxEinzelVK.TabIndex = 49;
      this.tbxEinzelVK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxEinzelVK.Enter += new System.EventHandler(this.tbxEinzelVK_Enter);
      // 
      // lblVK
      // 
      this.lblVK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lblVK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVK.Location = new System.Drawing.Point(230, 316);
      this.lblVK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblVK.Name = "lblVK";
      this.lblVK.Size = new System.Drawing.Size(72, 24);
      this.lblVK.TabIndex = 44;
      this.lblVK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblHundert
      // 
      this.lblHundert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lblHundert.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHundert.Location = new System.Drawing.Point(244, 257);
      this.lblHundert.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblHundert.Name = "lblHundert";
      this.lblHundert.Size = new System.Drawing.Size(55, 24);
      this.lblHundert.TabIndex = 44;
      this.lblHundert.Text = "100 %";
      this.lblHundert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblGesamtVK
      // 
      this.lblGesamtVK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblGesamtVK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblGesamtVK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGesamtVK.Location = new System.Drawing.Point(418, 318);
      this.lblGesamtVK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblGesamtVK.Name = "lblGesamtVK";
      this.lblGesamtVK.Size = new System.Drawing.Size(83, 19);
      this.lblGesamtVK.TabIndex = 45;
      this.lblGesamtVK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cbxOberlicht
      // 
      this.cbxOberlicht.AutoSize = true;
      this.cbxOberlicht.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxOberlicht.Location = new System.Drawing.Point(14, 322);
      this.cbxOberlicht.Name = "cbxOberlicht";
      this.cbxOberlicht.Size = new System.Drawing.Size(85, 17);
      this.cbxOberlicht.TabIndex = 3;
      this.cbxOberlicht.Text = "Oberlicht";
      this.cbxOberlicht.UseVisualStyleBackColor = true;
      this.cbxOberlicht.CheckedChanged += new System.EventHandler(this.cbxOberlicht_CheckedChanged);
      // 
      // cbxAlupulver
      // 
      this.cbxAlupulver.AutoSize = true;
      this.cbxAlupulver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxAlupulver.Location = new System.Drawing.Point(14, 292);
      this.cbxAlupulver.Name = "cbxAlupulver";
      this.cbxAlupulver.Size = new System.Drawing.Size(89, 17);
      this.cbxAlupulver.TabIndex = 1;
      this.cbxAlupulver.Text = "Alupulver";
      this.cbxAlupulver.UseVisualStyleBackColor = true;
      this.cbxAlupulver.CheckedChanged += new System.EventHandler(this.cbxAlupulver_CheckedChanged);
      // 
      // cbxMontage
      // 
      this.cbxMontage.AutoSize = true;
      this.cbxMontage.Checked = true;
      this.cbxMontage.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbxMontage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxMontage.Location = new System.Drawing.Point(107, 292);
      this.cbxMontage.Name = "cbxMontage";
      this.cbxMontage.Size = new System.Drawing.Size(81, 17);
      this.cbxMontage.TabIndex = 2;
      this.cbxMontage.Text = "Montage";
      this.cbxMontage.UseVisualStyleBackColor = true;
      this.cbxMontage.CheckedChanged += new System.EventHandler(this.cbxMontage_CheckedChanged);
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.Location = new System.Drawing.Point(430, 240);
      this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(55, 13);
      this.label18.TabIndex = 28;
      this.label18.Text = "gesamt";
      this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.Location = new System.Drawing.Point(306, 240);
      this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(78, 13);
      this.label17.TabIndex = 28;
      this.label17.Text = "pro Anlage";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label13
      // 
      this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(11, 206);
      this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(73, 24);
      this.label13.TabIndex = 28;
      this.label13.Text = "Lohn";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label12
      // 
      this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(11, 176);
      this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(73, 24);
      this.label12.TabIndex = 31;
      this.label12.Text = "Montage";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label11
      // 
      this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(11, 148);
      this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(73, 24);
      this.label11.TabIndex = 30;
      this.label11.Text = "Diverse";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label10
      // 
      this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(11, 119);
      this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(73, 24);
      this.label10.TabIndex = 27;
      this.label10.Text = "Fixkosten";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label9
      // 
      this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(11, 90);
      this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(87, 24);
      this.label9.TabIndex = 24;
      this.label9.Text = "Beschläge";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblGesamt
      // 
      this.lblGesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblGesamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblGesamt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblGesamt.Location = new System.Drawing.Point(417, 260);
      this.lblGesamt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblGesamt.Name = "lblGesamt";
      this.lblGesamt.Size = new System.Drawing.Size(83, 19);
      this.lblGesamt.TabIndex = 23;
      this.lblGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblEinzel
      // 
      this.lblEinzel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblEinzel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblEinzel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEinzel.Location = new System.Drawing.Point(304, 260);
      this.lblEinzel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblEinzel.Name = "lblEinzel";
      this.lblEinzel.Size = new System.Drawing.Size(83, 19);
      this.lblEinzel.TabIndex = 26;
      this.lblEinzel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblLohnPreisGesamt
      // 
      this.lblLohnPreisGesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLohnPreisGesamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblLohnPreisGesamt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLohnPreisGesamt.Location = new System.Drawing.Point(417, 204);
      this.lblLohnPreisGesamt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblLohnPreisGesamt.Name = "lblLohnPreisGesamt";
      this.lblLohnPreisGesamt.Size = new System.Drawing.Size(83, 19);
      this.lblLohnPreisGesamt.TabIndex = 25;
      this.lblLohnPreisGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblLohnPreis
      // 
      this.lblLohnPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLohnPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblLohnPreis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLohnPreis.Location = new System.Drawing.Point(345, 204);
      this.lblLohnPreis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblLohnPreis.Name = "lblLohnPreis";
      this.lblLohnPreis.Size = new System.Drawing.Size(43, 19);
      this.lblLohnPreis.TabIndex = 32;
      this.lblLohnPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblLohnteile
      // 
      this.lblLohnteile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblLohnteile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblLohnteile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLohnteile.Location = new System.Drawing.Point(107, 206);
      this.lblLohnteile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblLohnteile.Name = "lblLohnteile";
      this.lblLohnteile.Size = new System.Drawing.Size(83, 19);
      this.lblLohnteile.TabIndex = 39;
      this.lblLohnteile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblMontagePreisGesamt
      // 
      this.lblMontagePreisGesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblMontagePreisGesamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMontagePreisGesamt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMontagePreisGesamt.Location = new System.Drawing.Point(417, 176);
      this.lblMontagePreisGesamt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblMontagePreisGesamt.Name = "lblMontagePreisGesamt";
      this.lblMontagePreisGesamt.Size = new System.Drawing.Size(83, 19);
      this.lblMontagePreisGesamt.TabIndex = 38;
      this.lblMontagePreisGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblMontagePreis
      // 
      this.lblMontagePreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblMontagePreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMontagePreis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMontagePreis.Location = new System.Drawing.Point(345, 176);
      this.lblMontagePreis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblMontagePreis.Name = "lblMontagePreis";
      this.lblMontagePreis.Size = new System.Drawing.Size(43, 19);
      this.lblMontagePreis.TabIndex = 41;
      this.lblMontagePreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblMontageTeile
      // 
      this.lblMontageTeile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblMontageTeile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMontageTeile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblMontageTeile.Location = new System.Drawing.Point(107, 176);
      this.lblMontageTeile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblMontageTeile.Name = "lblMontageTeile";
      this.lblMontageTeile.Size = new System.Drawing.Size(83, 19);
      this.lblMontageTeile.TabIndex = 40;
      this.lblMontageTeile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblDiverseKosten
      // 
      this.lblDiverseKosten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblDiverseKosten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblDiverseKosten.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDiverseKosten.Location = new System.Drawing.Point(417, 147);
      this.lblDiverseKosten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblDiverseKosten.Name = "lblDiverseKosten";
      this.lblDiverseKosten.Size = new System.Drawing.Size(83, 19);
      this.lblDiverseKosten.TabIndex = 37;
      this.lblDiverseKosten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblBeschlagPreisGesamt
      // 
      this.lblBeschlagPreisGesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblBeschlagPreisGesamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblBeschlagPreisGesamt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBeschlagPreisGesamt.Location = new System.Drawing.Point(417, 89);
      this.lblBeschlagPreisGesamt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblBeschlagPreisGesamt.Name = "lblBeschlagPreisGesamt";
      this.lblBeschlagPreisGesamt.Size = new System.Drawing.Size(83, 19);
      this.lblBeschlagPreisGesamt.TabIndex = 34;
      this.lblBeschlagPreisGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblFixkosten
      // 
      this.lblFixkosten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblFixkosten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblFixkosten.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFixkosten.Location = new System.Drawing.Point(417, 118);
      this.lblFixkosten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblFixkosten.Name = "lblFixkosten";
      this.lblFixkosten.Size = new System.Drawing.Size(83, 19);
      this.lblFixkosten.TabIndex = 33;
      this.lblFixkosten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblAluPreisGesamt
      // 
      this.lblAluPreisGesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblAluPreisGesamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblAluPreisGesamt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAluPreisGesamt.Location = new System.Drawing.Point(417, 60);
      this.lblAluPreisGesamt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblAluPreisGesamt.Name = "lblAluPreisGesamt";
      this.lblAluPreisGesamt.Size = new System.Drawing.Size(83, 19);
      this.lblAluPreisGesamt.TabIndex = 36;
      this.lblAluPreisGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblAluPreis
      // 
      this.lblAluPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblAluPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblAluPreis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAluPreis.Location = new System.Drawing.Point(345, 60);
      this.lblAluPreis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblAluPreis.Name = "lblAluPreis";
      this.lblAluPreis.Size = new System.Drawing.Size(43, 19);
      this.lblAluPreis.TabIndex = 35;
      this.lblAluPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblAluMenge
      // 
      this.lblAluMenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblAluMenge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblAluMenge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAluMenge.Location = new System.Drawing.Point(107, 60);
      this.lblAluMenge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblAluMenge.Name = "lblAluMenge";
      this.lblAluMenge.Size = new System.Drawing.Size(83, 19);
      this.lblAluMenge.TabIndex = 29;
      this.lblAluMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblBeschlagPreis
      // 
      this.lblBeschlagPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblBeschlagPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblBeschlagPreis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBeschlagPreis.Location = new System.Drawing.Point(345, 89);
      this.lblBeschlagPreis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblBeschlagPreis.Name = "lblBeschlagPreis";
      this.lblBeschlagPreis.Size = new System.Drawing.Size(43, 19);
      this.lblBeschlagPreis.TabIndex = 8;
      this.lblBeschlagPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblBeschlagMenge
      // 
      this.lblBeschlagMenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblBeschlagMenge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblBeschlagMenge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBeschlagMenge.Location = new System.Drawing.Point(107, 89);
      this.lblBeschlagMenge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblBeschlagMenge.Name = "lblBeschlagMenge";
      this.lblBeschlagMenge.Size = new System.Drawing.Size(83, 19);
      this.lblBeschlagMenge.TabIndex = 7;
      this.lblBeschlagMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label8
      // 
      this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(11, 60);
      this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(73, 24);
      this.label8.TabIndex = 9;
      this.label8.Text = "Aluprofile";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label40
      // 
      this.label40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label40.Location = new System.Drawing.Point(285, 206);
      this.label40.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label40.Name = "label40";
      this.label40.Size = new System.Drawing.Size(31, 24);
      this.label40.TabIndex = 11;
      this.label40.Text = "x";
      this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label25
      // 
      this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label25.Location = new System.Drawing.Point(227, 206);
      this.label25.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(45, 24);
      this.label25.TabIndex = 10;
      this.label25.Text = "Teile";
      this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label39
      // 
      this.label39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label39.Location = new System.Drawing.Point(285, 176);
      this.label39.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label39.Name = "label39";
      this.label39.Size = new System.Drawing.Size(31, 24);
      this.label39.TabIndex = 3;
      this.label39.Text = "x";
      this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label24
      // 
      this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label24.Location = new System.Drawing.Point(227, 176);
      this.label24.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(45, 24);
      this.label24.TabIndex = 2;
      this.label24.Text = "Teile";
      this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label38
      // 
      this.label38.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label38.Location = new System.Drawing.Point(285, 90);
      this.label38.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label38.Name = "label38";
      this.label38.Size = new System.Drawing.Size(31, 24);
      this.label38.TabIndex = 4;
      this.label38.Text = "x";
      this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label31
      // 
      this.label31.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label31.Location = new System.Drawing.Point(227, 90);
      this.label31.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label31.Name = "label31";
      this.label31.Size = new System.Drawing.Size(45, 24);
      this.label31.TabIndex = 6;
      this.label31.Text = "Stk";
      this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label37
      // 
      this.label37.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label37.Location = new System.Drawing.Point(285, 60);
      this.label37.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label37.Name = "label37";
      this.label37.Size = new System.Drawing.Size(31, 24);
      this.label37.TabIndex = 5;
      this.label37.Text = "x";
      this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label19
      // 
      this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.Location = new System.Drawing.Point(145, 317);
      this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(50, 24);
      this.label19.TabIndex = 18;
      this.label19.Text = "lfm =";
      this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label29
      // 
      this.label29.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label29.Location = new System.Drawing.Point(227, 60);
      this.label29.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(31, 24);
      this.label29.TabIndex = 18;
      this.label29.Text = "lfm";
      this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label36
      // 
      this.label36.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label36.Location = new System.Drawing.Point(285, 32);
      this.label36.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label36.Name = "label36";
      this.label36.Size = new System.Drawing.Size(31, 24);
      this.label36.TabIndex = 17;
      this.label36.Text = "x";
      this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label16
      // 
      this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(414, 7);
      this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(82, 24);
      this.label16.TabIndex = 19;
      this.label16.Text = "€";
      this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label20
      // 
      this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label20.Location = new System.Drawing.Point(183, 294);
      this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(44, 24);
      this.label20.TabIndex = 19;
      this.label20.Text = "€";
      this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label15
      // 
      this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.Location = new System.Drawing.Point(344, 7);
      this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(44, 24);
      this.label15.TabIndex = 19;
      this.label15.Text = "€";
      this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label28
      // 
      this.label28.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label28.Location = new System.Drawing.Point(227, 32);
      this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(31, 24);
      this.label28.TabIndex = 19;
      this.label28.Text = "lfm";
      this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblPlattenPreisGesamt
      // 
      this.lblPlattenPreisGesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblPlattenPreisGesamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblPlattenPreisGesamt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlattenPreisGesamt.Location = new System.Drawing.Point(417, 32);
      this.lblPlattenPreisGesamt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblPlattenPreisGesamt.Name = "lblPlattenPreisGesamt";
      this.lblPlattenPreisGesamt.Size = new System.Drawing.Size(83, 19);
      this.lblPlattenPreisGesamt.TabIndex = 21;
      this.lblPlattenPreisGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblPlattenPreis
      // 
      this.lblPlattenPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblPlattenPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblPlattenPreis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlattenPreis.Location = new System.Drawing.Point(345, 32);
      this.lblPlattenPreis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblPlattenPreis.Name = "lblPlattenPreis";
      this.lblPlattenPreis.Size = new System.Drawing.Size(43, 19);
      this.lblPlattenPreis.TabIndex = 20;
      this.lblPlattenPreis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblPlattenMenge
      // 
      this.lblPlattenMenge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lblPlattenMenge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblPlattenMenge.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPlattenMenge.Location = new System.Drawing.Point(107, 32);
      this.lblPlattenMenge.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.lblPlattenMenge.Name = "lblPlattenMenge";
      this.lblPlattenMenge.Size = new System.Drawing.Size(83, 19);
      this.lblPlattenMenge.TabIndex = 14;
      this.lblPlattenMenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label7
      // 
      this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(11, 32);
      this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(73, 24);
      this.label7.TabIndex = 22;
      this.label7.Text = "Platten";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // gbxSondertext
      // 
      this.gbxSondertext.Controls.Add(this.panel5);
      this.gbxSondertext.Location = new System.Drawing.Point(569, 373);
      this.gbxSondertext.Name = "gbxSondertext";
      this.gbxSondertext.Size = new System.Drawing.Size(443, 143);
      this.gbxSondertext.TabIndex = 15;
      this.gbxSondertext.TabStop = false;
      this.gbxSondertext.Text = "Sondertext";
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.White;
      this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel5.Controls.Add(this.tabControl1);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(3, 17);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(437, 123);
      this.panel5.TabIndex = 0;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(9, 3);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(393, 115);
      this.tabControl1.TabIndex = 21;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.tbxSondertextUnten);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(385, 89);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Unten";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tbxSondertextUnten
      // 
      this.tbxSondertextUnten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxSondertextUnten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxSondertextUnten.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbxSondertextUnten.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxSondertextUnten.Location = new System.Drawing.Point(3, 3);
      this.tbxSondertextUnten.MaxLength = 198;
      this.tbxSondertextUnten.Multiline = true;
      this.tbxSondertextUnten.Name = "tbxSondertextUnten";
      this.tbxSondertextUnten.Size = new System.Drawing.Size(379, 83);
      this.tbxSondertextUnten.TabIndex = 50;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.tbxSondertextOben);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(385, 89);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Oben";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tbxSondertextOben
      // 
      this.tbxSondertextOben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxSondertextOben.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxSondertextOben.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbxSondertextOben.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxSondertextOben.Location = new System.Drawing.Point(3, 3);
      this.tbxSondertextOben.MaxLength = 198;
      this.tbxSondertextOben.Multiline = true;
      this.tbxSondertextOben.Name = "tbxSondertextOben";
      this.tbxSondertextOben.Size = new System.Drawing.Size(379, 83);
      this.tbxSondertextOben.TabIndex = 51;
      // 
      // btnAendSpeichern
      // 
      this.btnAendSpeichern.Enabled = false;
      this.btnAendSpeichern.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAendSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("btnAendSpeichern.Image")));
      this.btnAendSpeichern.Location = new System.Drawing.Point(14, 47);
      this.btnAendSpeichern.Name = "btnAendSpeichern";
      this.btnAendSpeichern.Size = new System.Drawing.Size(160, 47);
      this.btnAendSpeichern.TabIndex = 2;
      this.btnAendSpeichern.Text = "Änderungen speichern";
      this.btnAendSpeichern.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnAendSpeichern.UseVisualStyleBackColor = true;
      this.btnAendSpeichern.Click += new System.EventHandler(this.btnAendSpeichern_Click);
      // 
      // btnSchließen
      // 
      this.btnSchließen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSchließen.Image = ((System.Drawing.Image)(resources.GetObject("btnSchließen.Image")));
      this.btnSchließen.Location = new System.Drawing.Point(236, 47);
      this.btnSchließen.Name = "btnSchließen";
      this.btnSchließen.Size = new System.Drawing.Size(160, 47);
      this.btnSchließen.TabIndex = 8;
      this.btnSchließen.Text = "Schließen";
      this.btnSchließen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSchließen.UseVisualStyleBackColor = true;
      this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
      // 
      // btnPosAnlegen
      // 
      this.btnPosAnlegen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPosAnlegen.Image = ((System.Drawing.Image)(resources.GetObject("btnPosAnlegen.Image")));
      this.btnPosAnlegen.Location = new System.Drawing.Point(235, 3);
      this.btnPosAnlegen.Name = "btnPosAnlegen";
      this.btnPosAnlegen.Size = new System.Drawing.Size(160, 42);
      this.btnPosAnlegen.TabIndex = 5;
      this.btnPosAnlegen.Text = "Anlegen";
      this.btnPosAnlegen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPosAnlegen.UseVisualStyleBackColor = true;
      this.btnPosAnlegen.Click += new System.EventHandler(this.btnPosAnlegen_Click);
      // 
      // toolStrip1
      // 
      this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
      this.toolStrip1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemKalkulationNeu,
            this.itemKalkulationSchließen});
      this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1156, 39);
      this.toolStrip1.TabIndex = 5;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // itemKalkulationNeu
      // 
      this.itemKalkulationNeu.AutoSize = false;
      this.itemKalkulationNeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.itemKalkulationNeu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.itemKalkulationNeu.Image = ((System.Drawing.Image)(resources.GetObject("itemKalkulationNeu.Image")));
      this.itemKalkulationNeu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.itemKalkulationNeu.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.itemKalkulationNeu.Name = "itemKalkulationNeu";
      this.itemKalkulationNeu.Size = new System.Drawing.Size(50, 35);
      this.itemKalkulationNeu.Text = "Neu";
      this.itemKalkulationNeu.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
      this.itemKalkulationNeu.Click += new System.EventHandler(this.itemKalkulationNeu_Click);
      // 
      // itemKalkulationSchließen
      // 
      this.itemKalkulationSchließen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.itemKalkulationSchließen.AutoSize = false;
      this.itemKalkulationSchließen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.itemKalkulationSchließen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.itemKalkulationSchließen.Image = ((System.Drawing.Image)(resources.GetObject("itemKalkulationSchließen.Image")));
      this.itemKalkulationSchließen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.itemKalkulationSchließen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.itemKalkulationSchließen.Name = "itemKalkulationSchließen";
      this.itemKalkulationSchließen.Size = new System.Drawing.Size(36, 36);
      this.itemKalkulationSchließen.Text = "Schließen";
      this.itemKalkulationSchließen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
      this.itemKalkulationSchließen.Click += new System.EventHandler(this.itemKundeSchließen_Click);
      // 
      // tbxAussparungGesamt
      // 
      this.tbxAussparungGesamt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAussparungGesamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAussparungGesamt.Location = new System.Drawing.Point(333, 32);
      this.tbxAussparungGesamt.Name = "tbxAussparungGesamt";
      this.tbxAussparungGesamt.Size = new System.Drawing.Size(86, 21);
      this.tbxAussparungGesamt.TabIndex = 20;
      this.tbxAussparungGesamt.TabStop = false;
      this.tbxAussparungGesamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAussparungGesamt.Enter += new System.EventHandler(this.tbxAussparungGesamt_Enter);
      // 
      // label21
      // 
      this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label21.Location = new System.Drawing.Point(297, 29);
      this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(31, 24);
      this.label21.TabIndex = 17;
      this.label21.Text = "=";
      this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label23
      // 
      this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label23.Location = new System.Drawing.Point(348, 6);
      this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(44, 24);
      this.label23.TabIndex = 19;
      this.label23.Text = "€";
      this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnKalkulieren
      // 
      this.btnKalkulieren.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnKalkulieren.Image = ((System.Drawing.Image)(resources.GetObject("btnKalkulieren.Image")));
      this.btnKalkulieren.Location = new System.Drawing.Point(880, 127);
      this.btnKalkulieren.Name = "btnKalkulieren";
      this.btnKalkulieren.Size = new System.Drawing.Size(240, 91);
      this.btnKalkulieren.TabIndex = 5;
      this.btnKalkulieren.Text = "Kalkulieren";
      this.btnKalkulieren.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnKalkulieren.UseVisualStyleBackColor = true;
      this.btnKalkulieren.Click += new System.EventHandler(this.btnKalkulieren_Click);
      // 
      // tabSwitch
      // 
      this.tabSwitch.Controls.Add(this.gbxAussparung);
      this.tabSwitch.Controls.Add(this.tabAlternativ);
      this.tabSwitch.Location = new System.Drawing.Point(572, 227);
      this.tabSwitch.Name = "tabSwitch";
      this.tabSwitch.SelectedIndex = 0;
      this.tabSwitch.Size = new System.Drawing.Size(440, 146);
      this.tabSwitch.TabIndex = 5;
      this.tabSwitch.TabStop = false;
      // 
      // gbxAussparung
      // 
      this.gbxAussparung.Controls.Add(this.cobAussaprungBeschreibung);
      this.gbxAussparung.Controls.Add(this.cbxSonderartikelEinheit);
      this.gbxAussparung.Controls.Add(this.tbxAussparungenPreis);
      this.gbxAussparung.Controls.Add(this.label26);
      this.gbxAussparung.Controls.Add(this.tbxAussparungGesamt);
      this.gbxAussparung.Controls.Add(this.label23);
      this.gbxAussparung.Controls.Add(this.label21);
      this.gbxAussparung.Location = new System.Drawing.Point(4, 22);
      this.gbxAussparung.Name = "gbxAussparung";
      this.gbxAussparung.Padding = new System.Windows.Forms.Padding(3);
      this.gbxAussparung.Size = new System.Drawing.Size(432, 120);
      this.gbxAussparung.TabIndex = 0;
      this.gbxAussparung.Text = "Sonderartikel";
      this.gbxAussparung.UseVisualStyleBackColor = true;
      // 
      // cobAussaprungBeschreibung
      // 
      this.cobAussaprungBeschreibung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cobAussaprungBeschreibung.Font = new System.Drawing.Font("Verdana", 8.25F);
      this.cobAussaprungBeschreibung.FormattingEnabled = true;
      this.cobAussaprungBeschreibung.Items.AddRange(new object[] {
            "Aussparung(en)",
            "Edelstahl-WC-Beschläge",
            "Edelstahl-Mantelhaken"});
      this.cobAussaprungBeschreibung.Location = new System.Drawing.Point(6, 33);
      this.cobAussaprungBeschreibung.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.cobAussaprungBeschreibung.Name = "cobAussaprungBeschreibung";
      this.cobAussaprungBeschreibung.Size = new System.Drawing.Size(291, 21);
      this.cobAussaprungBeschreibung.TabIndex = 52;
      // 
      // cbxSonderartikelEinheit
      // 
      this.cbxSonderartikelEinheit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxSonderartikelEinheit.Font = new System.Drawing.Font("Verdana", 8.25F);
      this.cbxSonderartikelEinheit.FormattingEnabled = true;
      this.cbxSonderartikelEinheit.Items.AddRange(new object[] {
            "St",
            "lfm",
            "qm"});
      this.cbxSonderartikelEinheit.Location = new System.Drawing.Point(159, 6);
      this.cbxSonderartikelEinheit.Name = "cbxSonderartikelEinheit";
      this.cbxSonderartikelEinheit.Size = new System.Drawing.Size(138, 21);
      this.cbxSonderartikelEinheit.TabIndex = 51;
      // 
      // tbxAussparungenPreis
      // 
      this.tbxAussparungenPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAussparungenPreis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAussparungenPreis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAussparungenPreis.Location = new System.Drawing.Point(6, 4);
      this.tbxAussparungenPreis.Name = "tbxAussparungenPreis";
      this.tbxAussparungenPreis.Size = new System.Drawing.Size(60, 21);
      this.tbxAussparungenPreis.TabIndex = 7;
      this.tbxAussparungenPreis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAussparungenPreis.Enter += new System.EventHandler(this.textBox1_Enter);
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label26.Location = new System.Drawing.Point(71, 7);
      this.label26.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(79, 13);
      this.label26.TabIndex = 50;
      this.label26.Text = "Einzelpreis";
      this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tabAlternativ
      // 
      this.tabAlternativ.Controls.Add(this.gpxAlternativ2);
      this.tabAlternativ.Controls.Add(this.gpxAlternativ1);
      this.tabAlternativ.Location = new System.Drawing.Point(4, 22);
      this.tabAlternativ.Name = "tabAlternativ";
      this.tabAlternativ.Padding = new System.Windows.Forms.Padding(3);
      this.tabAlternativ.Size = new System.Drawing.Size(432, 120);
      this.tabAlternativ.TabIndex = 1;
      this.tabAlternativ.Text = "Alternativposition";
      this.tabAlternativ.UseVisualStyleBackColor = true;
      // 
      // gpxAlternativ2
      // 
      this.gpxAlternativ2.Controls.Add(this.cbxAlternativ2);
      this.gpxAlternativ2.Controls.Add(this.Alternativpanel2);
      this.gpxAlternativ2.Location = new System.Drawing.Point(9, 67);
      this.gpxAlternativ2.Name = "gpxAlternativ2";
      this.gpxAlternativ2.Size = new System.Drawing.Size(394, 15);
      this.gpxAlternativ2.TabIndex = 17;
      this.gpxAlternativ2.TabStop = false;
      this.gpxAlternativ2.Text = "Alternativposition 2";
      // 
      // cbxAlternativ2
      // 
      this.cbxAlternativ2.AutoSize = true;
      this.cbxAlternativ2.BackColor = System.Drawing.Color.White;
      this.cbxAlternativ2.Location = new System.Drawing.Point(300, -1);
      this.cbxAlternativ2.Name = "cbxAlternativ2";
      this.cbxAlternativ2.Size = new System.Drawing.Size(94, 17);
      this.cbxAlternativ2.TabIndex = 41;
      this.cbxAlternativ2.Text = "Aktivieren";
      this.cbxAlternativ2.UseVisualStyleBackColor = false;
      this.cbxAlternativ2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
      // 
      // Alternativpanel2
      // 
      this.Alternativpanel2.BackColor = System.Drawing.Color.White;
      this.Alternativpanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Alternativpanel2.Controls.Add(this.tbxAlt2Preis);
      this.Alternativpanel2.Controls.Add(this.label30);
      this.Alternativpanel2.Controls.Add(this.rdbNK2);
      this.Alternativpanel2.Controls.Add(this.rdbTM2);
      this.Alternativpanel2.Controls.Add(this.rdbTS2);
      this.Alternativpanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Alternativpanel2.Location = new System.Drawing.Point(3, 17);
      this.Alternativpanel2.Name = "Alternativpanel2";
      this.Alternativpanel2.Size = new System.Drawing.Size(388, 0);
      this.Alternativpanel2.TabIndex = 0;
      // 
      // tbxAlt2Preis
      // 
      this.tbxAlt2Preis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAlt2Preis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAlt2Preis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAlt2Preis.Location = new System.Drawing.Point(298, 5);
      this.tbxAlt2Preis.Name = "tbxAlt2Preis";
      this.tbxAlt2Preis.Size = new System.Drawing.Size(83, 21);
      this.tbxAlt2Preis.TabIndex = 51;
      this.tbxAlt2Preis.Text = "0";
      this.tbxAlt2Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAlt2Preis.Enter += new System.EventHandler(this.tbxAlt2Preis_Enter);
      // 
      // label30
      // 
      this.label30.AutoSize = true;
      this.label30.Location = new System.Drawing.Point(252, 9);
      this.label30.Name = "label30";
      this.label30.Size = new System.Drawing.Size(40, 13);
      this.label30.TabIndex = 42;
      this.label30.Text = "Preis";
      // 
      // rdbNK2
      // 
      this.rdbNK2.AutoSize = true;
      this.rdbNK2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbNK2.Location = new System.Drawing.Point(142, 6);
      this.rdbNK2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbNK2.Name = "rdbNK2";
      this.rdbNK2.Size = new System.Drawing.Size(42, 17);
      this.rdbNK2.TabIndex = 40;
      this.rdbNK2.Text = "NK";
      this.rdbNK2.UseVisualStyleBackColor = true;
      this.rdbNK2.CheckedChanged += new System.EventHandler(this.rdbNK2_CheckedChanged);
      // 
      // rdbTM2
      // 
      this.rdbTM2.AutoSize = true;
      this.rdbTM2.Checked = true;
      this.rdbTM2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbTM2.Location = new System.Drawing.Point(26, 6);
      this.rdbTM2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbTM2.Name = "rdbTM2";
      this.rdbTM2.Size = new System.Drawing.Size(43, 17);
      this.rdbTM2.TabIndex = 38;
      this.rdbTM2.TabStop = true;
      this.rdbTM2.Text = "TM";
      this.rdbTM2.UseVisualStyleBackColor = true;
      this.rdbTM2.CheckedChanged += new System.EventHandler(this.rdbTM2_CheckedChanged);
      // 
      // rdbTS2
      // 
      this.rdbTS2.AutoSize = true;
      this.rdbTS2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbTS2.Location = new System.Drawing.Point(86, 6);
      this.rdbTS2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbTS2.Name = "rdbTS2";
      this.rdbTS2.Size = new System.Drawing.Size(41, 17);
      this.rdbTS2.TabIndex = 39;
      this.rdbTS2.Text = "TS";
      this.rdbTS2.UseVisualStyleBackColor = true;
      this.rdbTS2.CheckedChanged += new System.EventHandler(this.rdbTS2_CheckedChanged);
      // 
      // gpxAlternativ1
      // 
      this.gpxAlternativ1.Controls.Add(this.cbxAlternativ1);
      this.gpxAlternativ1.Controls.Add(this.Alternativpanel1);
      this.gpxAlternativ1.Location = new System.Drawing.Point(9, 10);
      this.gpxAlternativ1.Name = "gpxAlternativ1";
      this.gpxAlternativ1.Size = new System.Drawing.Size(394, 15);
      this.gpxAlternativ1.TabIndex = 16;
      this.gpxAlternativ1.TabStop = false;
      this.gpxAlternativ1.Text = "Alternativposition 1";
      // 
      // cbxAlternativ1
      // 
      this.cbxAlternativ1.AutoSize = true;
      this.cbxAlternativ1.BackColor = System.Drawing.Color.White;
      this.cbxAlternativ1.Location = new System.Drawing.Point(300, -1);
      this.cbxAlternativ1.Name = "cbxAlternativ1";
      this.cbxAlternativ1.Size = new System.Drawing.Size(94, 17);
      this.cbxAlternativ1.TabIndex = 41;
      this.cbxAlternativ1.Text = "Aktivieren";
      this.cbxAlternativ1.UseVisualStyleBackColor = false;
      this.cbxAlternativ1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
      // 
      // Alternativpanel1
      // 
      this.Alternativpanel1.BackColor = System.Drawing.Color.White;
      this.Alternativpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Alternativpanel1.Controls.Add(this.tbxAlt1Preis);
      this.Alternativpanel1.Controls.Add(this.label27);
      this.Alternativpanel1.Controls.Add(this.rdbNK1);
      this.Alternativpanel1.Controls.Add(this.rdbTM1);
      this.Alternativpanel1.Controls.Add(this.rdbTS1);
      this.Alternativpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Alternativpanel1.Location = new System.Drawing.Point(3, 17);
      this.Alternativpanel1.Name = "Alternativpanel1";
      this.Alternativpanel1.Size = new System.Drawing.Size(388, 0);
      this.Alternativpanel1.TabIndex = 0;
      // 
      // tbxAlt1Preis
      // 
      this.tbxAlt1Preis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAlt1Preis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAlt1Preis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAlt1Preis.Location = new System.Drawing.Point(298, 4);
      this.tbxAlt1Preis.Name = "tbxAlt1Preis";
      this.tbxAlt1Preis.Size = new System.Drawing.Size(83, 21);
      this.tbxAlt1Preis.TabIndex = 50;
      this.tbxAlt1Preis.Text = "0";
      this.tbxAlt1Preis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAlt1Preis.Enter += new System.EventHandler(this.tbxAlt1Preis_Enter);
      // 
      // label27
      // 
      this.label27.AutoSize = true;
      this.label27.Location = new System.Drawing.Point(252, 9);
      this.label27.Name = "label27";
      this.label27.Size = new System.Drawing.Size(40, 13);
      this.label27.TabIndex = 41;
      this.label27.Text = "Preis";
      // 
      // rdbNK1
      // 
      this.rdbNK1.AutoSize = true;
      this.rdbNK1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbNK1.Location = new System.Drawing.Point(145, 5);
      this.rdbNK1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbNK1.Name = "rdbNK1";
      this.rdbNK1.Size = new System.Drawing.Size(42, 17);
      this.rdbNK1.TabIndex = 40;
      this.rdbNK1.Text = "NK";
      this.rdbNK1.UseVisualStyleBackColor = true;
      this.rdbNK1.CheckedChanged += new System.EventHandler(this.rdbNK1_CheckedChanged);
      // 
      // rdbTM1
      // 
      this.rdbTM1.AutoSize = true;
      this.rdbTM1.Checked = true;
      this.rdbTM1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbTM1.Location = new System.Drawing.Point(29, 5);
      this.rdbTM1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbTM1.Name = "rdbTM1";
      this.rdbTM1.Size = new System.Drawing.Size(43, 17);
      this.rdbTM1.TabIndex = 38;
      this.rdbTM1.TabStop = true;
      this.rdbTM1.Text = "TM";
      this.rdbTM1.UseVisualStyleBackColor = true;
      this.rdbTM1.CheckedChanged += new System.EventHandler(this.rdbTM1_CheckedChanged);
      // 
      // rdbTS1
      // 
      this.rdbTS1.AutoSize = true;
      this.rdbTS1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbTS1.Location = new System.Drawing.Point(89, 5);
      this.rdbTS1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbTS1.Name = "rdbTS1";
      this.rdbTS1.Size = new System.Drawing.Size(41, 17);
      this.rdbTS1.TabIndex = 39;
      this.rdbTS1.Text = "TS";
      this.rdbTS1.UseVisualStyleBackColor = true;
      this.rdbTS1.CheckedChanged += new System.EventHandler(this.rdbTS1_CheckedChanged);
      // 
      // pnlSteuerung
      // 
      this.pnlSteuerung.BackColor = System.Drawing.Color.Azure;
      this.pnlSteuerung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlSteuerung.Controls.Add(this.cbxEventual);
      this.pnlSteuerung.Controls.Add(this.btnAendSpeichern);
      this.pnlSteuerung.Controls.Add(this.btnSchließen);
      this.pnlSteuerung.Controls.Add(this.btnPosAnlegen);
      this.pnlSteuerung.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlSteuerung.Location = new System.Drawing.Point(5, 17);
      this.pnlSteuerung.Name = "pnlSteuerung";
      this.pnlSteuerung.Size = new System.Drawing.Size(429, 100);
      this.pnlSteuerung.TabIndex = 0;
      // 
      // cbxEventual
      // 
      this.cbxEventual.AutoSize = true;
      this.cbxEventual.Location = new System.Drawing.Point(14, 17);
      this.cbxEventual.Name = "cbxEventual";
      this.cbxEventual.Size = new System.Drawing.Size(83, 17);
      this.cbxEventual.TabIndex = 9;
      this.cbxEventual.Text = "Eventual";
      this.cbxEventual.UseVisualStyleBackColor = true;
      // 
      // grpSteuerung
      // 
      this.grpSteuerung.Controls.Add(this.pnlSteuerung);
      this.grpSteuerung.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grpSteuerung.Location = new System.Drawing.Point(569, 513);
      this.grpSteuerung.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.grpSteuerung.Name = "grpSteuerung";
      this.grpSteuerung.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.grpSteuerung.Size = new System.Drawing.Size(439, 120);
      this.grpSteuerung.TabIndex = 7;
      this.grpSteuerung.TabStop = false;
      this.grpSteuerung.Text = "Steuerung";
      this.grpSteuerung.Visible = false;
      // 
      // Form_Kalkualtion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.BackColor = System.Drawing.SystemColors.MenuBar;
      this.ClientSize = new System.Drawing.Size(1156, 700);
      this.ControlBox = false;
      this.Controls.Add(this.tabSwitch);
      this.Controls.Add(this.grpSteuerung);
      this.Controls.Add(this.gbxSondertext);
      this.Controls.Add(this.gbxErgebnisse);
      this.Controls.Add(this.gbxParameter);
      this.Controls.Add(this.btnKalkulieren);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.gbxTyp);
      this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.MaximizeBox = false;
      this.Name = "Form_Kalkualtion";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Kalkulation";
      this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
      this.Load += new System.EventHandler(this.Form_Kalkulation_Load);
      this.gbxTyp.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.gbxParameter.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.gbxErgebnisse.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.gbxSondertext.ResumeLayout(false);
      this.panel5.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.tabSwitch.ResumeLayout(false);
      this.gbxAussparung.ResumeLayout(false);
      this.gbxAussparung.PerformLayout();
      this.tabAlternativ.ResumeLayout(false);
      this.gpxAlternativ2.ResumeLayout(false);
      this.gpxAlternativ2.PerformLayout();
      this.Alternativpanel2.ResumeLayout(false);
      this.Alternativpanel2.PerformLayout();
      this.gpxAlternativ1.ResumeLayout(false);
      this.gpxAlternativ1.PerformLayout();
      this.Alternativpanel1.ResumeLayout(false);
      this.Alternativpanel1.PerformLayout();
      this.pnlSteuerung.ResumeLayout(false);
      this.pnlSteuerung.PerformLayout();
      this.grpSteuerung.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox gbxTyp;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.GroupBox gbxErgebnisse;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.GroupBox gbxParameter;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbxZuschlag;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbxTrw;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbxTiefe;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbxTüren;
    private System.Windows.Forms.TextBox tbxAnlagen;
    private System.Windows.Forms.TextBox tbxBreite;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.CheckBox cbxAlupulver;
    private System.Windows.Forms.CheckBox cbxMontage;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblGesamt;
    private System.Windows.Forms.Label lblEinzel;
    public System.Windows.Forms.Label lblLohnPreisGesamt;
    private System.Windows.Forms.Label lblLohnPreis;
    private System.Windows.Forms.Label lblLohnteile;
    private System.Windows.Forms.Label lblMontagePreisGesamt;
    private System.Windows.Forms.Label lblMontagePreis;
    private System.Windows.Forms.Label lblMontageTeile;
    private System.Windows.Forms.Label lblDiverseKosten;
    private System.Windows.Forms.Label lblBeschlagPreisGesamt;
    private System.Windows.Forms.Label lblFixkosten;
    private System.Windows.Forms.Label lblAluPreisGesamt;
    private System.Windows.Forms.Label lblAluPreis;
    private System.Windows.Forms.Label lblAluMenge;
    private System.Windows.Forms.Label lblBeschlagPreis;
    private System.Windows.Forms.Label lblBeschlagMenge;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label40;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.Label label39;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Label label38;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.Label label37;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.Label label36;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label lblPlattenPreisGesamt;
    private System.Windows.Forms.Label lblPlattenPreis;
    private System.Windows.Forms.Label lblPlattenMenge;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblHundert;
    private System.Windows.Forms.Label lblGesamtVK;
    private System.Windows.Forms.Button btnKalkulieren;
    private System.Windows.Forms.TextBox tbxVK;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.GroupBox gbxSondertext;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Button btnSchließen;
    private System.Windows.Forms.ToolStripButton itemKalkulationNeu;
    private System.Windows.Forms.ToolStripButton itemKalkulationSchließen;
    public System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.TextBox tbxEinzelVK;
    private System.Windows.Forms.RadioButton rdbNK;
    private System.Windows.Forms.RadioButton rdbTM;
    private System.Windows.Forms.RadioButton rdbTS;
    private System.Windows.Forms.RadioButton rdbVorderwand;
    private System.Windows.Forms.RadioButton rdbTrennwand;
    private System.Windows.Forms.RadioButton rdbVorOTuer;
    private System.Windows.Forms.RadioButton rdbSchamwand;
    private System.Windows.Forms.RadioButton rdbKabinen;
    private System.Windows.Forms.CheckBox cbxOberlicht;
    private System.Windows.Forms.TextBox tbxOberlichtLfm;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.ComboBox cbxVK;
    private System.Windows.Forms.Label lblOberlichtG;
    private System.Windows.Forms.Label lblVK;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.RadioButton rdbAussparung;
    private System.Windows.Forms.TextBox tbxAussparungGesamt;
    private System.Windows.Forms.TabControl tabSwitch;
    private System.Windows.Forms.TabPage gbxAussparung;
    private System.Windows.Forms.TabPage tabAlternativ;
    private System.Windows.Forms.GroupBox gpxAlternativ1;
    private System.Windows.Forms.Panel Alternativpanel1;
    private System.Windows.Forms.RadioButton rdbNK1;
    private System.Windows.Forms.RadioButton rdbTM1;
    private System.Windows.Forms.RadioButton rdbTS1;
    private System.Windows.Forms.GroupBox gpxAlternativ2;
    private System.Windows.Forms.CheckBox cbxAlternativ2;
    private System.Windows.Forms.Panel Alternativpanel2;
    private System.Windows.Forms.RadioButton rdbNK2;
    private System.Windows.Forms.RadioButton rdbTM2;
    private System.Windows.Forms.RadioButton rdbTS2;
    private System.Windows.Forms.CheckBox cbxAlternativ1;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.TextBox tbxAlt2Preis;
    private System.Windows.Forms.TextBox tbxAlt1Preis;
    private System.Windows.Forms.TextBox tbxAussparungenPreis;
    private System.Windows.Forms.Label label26;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TextBox tbxSondertextUnten;
    private TabPage tabPage2;
    private TextBox tbxSondertextOben;
    public Button btnAendSpeichern;
    public Button btnPosAnlegen;
    private Panel pnlSteuerung;
    public GroupBox grpSteuerung;
    private TextBox tbxAlupulv;
    private ComboBox cbxSonderartikelEinheit;
    private CheckBox cbxEventual;
    private ComboBox cobAussaprungBeschreibung;

   
  }
}

