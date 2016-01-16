namespace Norka.Cockpit
{
  partial class Form_Cockpit
  {

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("pro Jahr und Kunde");
      System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("pro Monat und Kunde");
      System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("pro Jahr und Monat");
      System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("akt. Jahr - verg. Jahr");
      System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nettoumsatz", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
      System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Angebote Aufträge Rechnungen");
      System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Sonstiges", new System.Windows.Forms.TreeNode[] {
            treeNode6});
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tsKunde = new System.Windows.Forms.ToolStrip();
      this.itemCockpitSchließen = new System.Windows.Forms.ToolStripButton();
      this.itemDrucken = new System.Windows.Forms.ToolStripDropDownButton();
      this.ctmCockpitGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.trvKategorie = new System.Windows.Forms.TreeView();
      this.dgrResults = new System.Windows.Forms.DataGridView();
      this.sstpCockpit = new System.Windows.Forms.StatusStrip();
      this.slArchiv = new System.Windows.Forms.ToolStripStatusLabel();
      this.tsKunde.SuspendLayout();
      this.ctmCockpitGrid.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgrResults)).BeginInit();
      this.sstpCockpit.SuspendLayout();
      this.SuspendLayout();
      // 
      // tsKunde
      // 
      this.tsKunde.AllowDrop = true;
      this.tsKunde.AutoSize = false;
      this.tsKunde.BackColor = System.Drawing.SystemColors.MenuBar;
      this.tsKunde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tsKunde.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.tsKunde.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCockpitSchließen,
            this.itemDrucken});
      this.tsKunde.Location = new System.Drawing.Point(0, 0);
      this.tsKunde.Name = "tsKunde";
      this.tsKunde.Size = new System.Drawing.Size(1156, 38);
      this.tsKunde.TabIndex = 0;
      this.tsKunde.Text = "toolStrip1";
      // 
      // itemCockpitSchließen
      // 
      this.itemCockpitSchließen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.itemCockpitSchließen.AutoSize = false;
      this.itemCockpitSchließen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.itemCockpitSchließen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.itemCockpitSchließen.Image = global::Norka.Properties.Resources.Close_32;
      this.itemCockpitSchließen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.itemCockpitSchließen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.itemCockpitSchließen.Name = "itemCockpitSchließen";
      this.itemCockpitSchließen.Size = new System.Drawing.Size(36, 36);
      this.itemCockpitSchließen.Text = "Schließen";
      this.itemCockpitSchließen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
      this.itemCockpitSchließen.Click += new System.EventHandler(this.itemCockpitSch_Click);
      // 
      // itemDrucken
      // 
      this.itemDrucken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.itemDrucken.Enabled = false;
      this.itemDrucken.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.itemDrucken.Image = global::Norka.Properties.Resources.print_32;
      this.itemDrucken.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.itemDrucken.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.itemDrucken.Name = "itemDrucken";
      this.itemDrucken.Size = new System.Drawing.Size(45, 35);
      this.itemDrucken.Text = "toolStripButton1";
      this.itemDrucken.ToolTipText = "Drucken";
      // 
      // ctmCockpitGrid
      // 
      this.ctmCockpitGrid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ctmCockpitGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.druckenToolStripMenuItem});
      this.ctmCockpitGrid.Name = "ctmKundenGrid";
      this.ctmCockpitGrid.Size = new System.Drawing.Size(129, 26);
      this.ctmCockpitGrid.Opened += new System.EventHandler(this.ctmCockpitGrid_Opened);
      // 
      // druckenToolStripMenuItem
      // 
      this.druckenToolStripMenuItem.Image = global::Norka.Properties.Resources.print_32;
      this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
      this.druckenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
      this.druckenToolStripMenuItem.Text = "Drucken";
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.panel1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1148, 124);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Suchen - Angebote";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Window;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Controls.Add(this.label7);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.textBox2);
      this.panel1.Controls.Add(this.textBox3);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.label10);
      this.panel1.Controls.Add(this.textBox4);
      this.panel1.Controls.Add(this.textBox5);
      this.panel1.Controls.Add(this.label11);
      this.panel1.Controls.Add(this.label12);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1142, 118);
      this.panel1.TabIndex = 9;
      // 
      // textBox1
      // 
      this.textBox1.AllowDrop = true;
      this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox1.Location = new System.Drawing.Point(331, 8);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(199, 21);
      this.textBox1.TabIndex = 8;
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(249, 8);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(63, 20);
      this.label7.TabIndex = 7;
      this.label7.Text = "Name:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(249, 74);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(159, 13);
      this.label8.TabIndex = 6;
      this.label8.Text = "* = Platzhalter für Text";
      // 
      // textBox2
      // 
      this.textBox2.AllowDrop = true;
      this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox2.Location = new System.Drawing.Point(98, 40);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(123, 21);
      this.textBox2.TabIndex = 5;
      // 
      // textBox3
      // 
      this.textBox3.AllowDrop = true;
      this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox3.Location = new System.Drawing.Point(331, 39);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(199, 21);
      this.textBox3.TabIndex = 5;
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(16, 40);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(63, 20);
      this.label9.TabIndex = 4;
      this.label9.Text = "PLZ:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label10
      // 
      this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(249, 39);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(76, 20);
      this.label10.TabIndex = 4;
      this.label10.Text = "Matchode:";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // textBox4
      // 
      this.textBox4.AllowDrop = true;
      this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox4.Location = new System.Drawing.Point(98, 70);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(123, 21);
      this.textBox4.TabIndex = 3;
      // 
      // textBox5
      // 
      this.textBox5.AllowDrop = true;
      this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox5.Location = new System.Drawing.Point(98, 10);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(123, 21);
      this.textBox5.TabIndex = 3;
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(16, 70);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(77, 20);
      this.label11.TabIndex = 2;
      this.label11.Text = "Ort:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(16, 10);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(77, 20);
      this.label12.TabIndex = 2;
      this.label12.Text = "Kunden-Nr.:";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Image = global::Norka.Properties.Resources.search_64;
      this.button1.Location = new System.Drawing.Point(551, 8);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(155, 83);
      this.button1.TabIndex = 1;
      this.button1.Text = "Suchen";
      this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.button1.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.IsSplitterFixed = true;
      this.splitContainer1.Location = new System.Drawing.Point(0, 38);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.trvKategorie);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dgrResults);
      this.splitContainer1.Panel2.Controls.Add(this.sstpCockpit);
      this.splitContainer1.Size = new System.Drawing.Size(1156, 744);
      this.splitContainer1.SplitterDistance = 190;
      this.splitContainer1.TabIndex = 3;
      // 
      // trvKategorie
      // 
      this.trvKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.trvKategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.trvKategorie.Dock = System.Windows.Forms.DockStyle.Fill;
      this.trvKategorie.ItemHeight = 19;
      this.trvKategorie.Location = new System.Drawing.Point(0, 0);
      this.trvKategorie.Name = "trvKategorie";
      treeNode1.Name = "NettoUmsatzProJahrKunde";
      treeNode1.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      treeNode1.Text = "pro Jahr und Kunde";
      treeNode1.ToolTipText = "Anzeige des Jahresumsatzes für die Auswahl.";
      treeNode2.Name = "NettoUmsatzProMonatKunde";
      treeNode2.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
      treeNode2.Text = "pro Monat und Kunde";
      treeNode2.ToolTipText = "Anzeige des Monatsumsatzes für die Auswahl.";
      treeNode3.Name = "NettoUmsatzProJahrMonat";
      treeNode3.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
      treeNode3.Text = "pro Jahr und Monat";
      treeNode3.ToolTipText = "Anzeige des Monatsumsatzes pro Jahr.";
      treeNode4.Name = "NettoUmsatzProJahrMonatVergangenheit";
      treeNode4.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
      treeNode4.Text = "akt. Jahr - verg. Jahr";
      treeNode5.Name = "Nettoumsatz";
      treeNode5.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
      treeNode5.Text = "Nettoumsatz";
      treeNode6.Name = "AngeboteAufträgeRechnungen";
      treeNode6.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
      treeNode6.Text = "Angebote Aufträge Rechnungen";
      treeNode7.Name = "Sonstiges";
      treeNode7.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
      treeNode7.Text = "Sonstiges";
      this.trvKategorie.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode7});
      this.trvKategorie.Size = new System.Drawing.Size(190, 744);
      this.trvKategorie.TabIndex = 0;
      this.trvKategorie.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvKategorie_NodeMouseClick);
      // 
      // dgrResults
      // 
      this.dgrResults.AllowUserToAddRows = false;
      this.dgrResults.AllowUserToDeleteRows = false;
      this.dgrResults.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
      this.dgrResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgrResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgrResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgrResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgrResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgrResults.ContextMenuStrip = this.ctmCockpitGrid;
      this.dgrResults.Cursor = System.Windows.Forms.Cursors.Arrow;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgrResults.DefaultCellStyle = dataGridViewCellStyle3;
      this.dgrResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgrResults.Location = new System.Drawing.Point(0, 0);
      this.dgrResults.MultiSelect = false;
      this.dgrResults.Name = "dgrResults";
      this.dgrResults.ReadOnly = true;
      this.dgrResults.RowHeadersVisible = false;
      this.dgrResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgrResults.Size = new System.Drawing.Size(962, 722);
      this.dgrResults.TabIndex = 0;
      this.dgrResults.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgrResults_RowsAdded);
      this.dgrResults.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgrResults_RowsRemoved);
      this.dgrResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgrKunden_MouseDown);
      // 
      // sstpCockpit
      // 
      this.sstpCockpit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slArchiv});
      this.sstpCockpit.Location = new System.Drawing.Point(0, 722);
      this.sstpCockpit.Name = "sstpCockpit";
      this.sstpCockpit.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
      this.sstpCockpit.Size = new System.Drawing.Size(962, 22);
      this.sstpCockpit.SizingGrip = false;
      this.sstpCockpit.TabIndex = 1;
      this.sstpCockpit.Text = "statusStrip1";
      // 
      // slArchiv
      // 
      this.slArchiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.slArchiv.Name = "slArchiv";
      this.slArchiv.Size = new System.Drawing.Size(0, 17);
      // 
      // Form_Cockpit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(1156, 782);
      this.ControlBox = false;
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.tsKunde);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.KeyPreview = true;
      this.MinimizeBox = false;
      this.Name = "Form_Cockpit";
      this.Text = "Archiv";
      this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
      this.Load += new System.EventHandler(this.Form_Cockpit_Load);
      this.tsKunde.ResumeLayout(false);
      this.tsKunde.PerformLayout();
      this.ctmCockpitGrid.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgrResults)).EndInit();
      this.sstpCockpit.ResumeLayout(false);
      this.sstpCockpit.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStrip tsKunde;
    private System.Windows.Forms.ToolStripButton itemCockpitSchließen;
    private System.Windows.Forms.ContextMenuStrip ctmCockpitGrid;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem druckenToolStripMenuItem;
    private System.Windows.Forms.ToolStripDropDownButton itemDrucken;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView trvKategorie;
    public System.Windows.Forms.DataGridView dgrResults;
    private System.Windows.Forms.StatusStrip sstpCockpit;
    public System.Windows.Forms.ToolStripStatusLabel slArchiv;
  }
}