namespace Norka.Archiv
{
  partial class Form_Archiv
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Archiv));
        System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Angebote");
        System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Aufträge");
        System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Rechnungen");
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
        this.tsKunde = new System.Windows.Forms.ToolStrip();
        this.itemAnzeigen = new System.Windows.Forms.ToolStripButton();
        this.itemLoeschen = new System.Windows.Forms.ToolStripButton();
        this.itemArchivSchließen = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.itemDrucken = new System.Windows.Forms.ToolStripDropDownButton();
        this.vorschauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.sofortdruckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.faxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        this.itemAktualisieren = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        this.itemAlleMarkieren = new System.Windows.Forms.ToolStripButton();
        this.itemKeineMarkieren = new System.Windows.Forms.ToolStripButton();
        this.ctmArchivGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
        this.anzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.vorschauToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.sofortdruckToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        this.faxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
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
        this.sstpArchiv = new System.Windows.Forms.StatusStrip();
        this.slArchiv = new System.Windows.Forms.ToolStripStatusLabel();
        this.tsKunde.SuspendLayout();
        this.ctmArchivGrid.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.panel1.SuspendLayout();
        this.splitContainer1.Panel1.SuspendLayout();
        this.splitContainer1.Panel2.SuspendLayout();
        this.splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgrResults)).BeginInit();
        this.sstpArchiv.SuspendLayout();
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
            this.itemAnzeigen,
            this.itemLoeschen,
            this.itemArchivSchließen,
            this.toolStripSeparator2,
            this.itemDrucken,
            this.toolStripSeparator3,
            this.itemAktualisieren,
            this.toolStripSeparator1,
            this.itemAlleMarkieren,
            this.itemKeineMarkieren});
        this.tsKunde.Location = new System.Drawing.Point(0, 0);
        this.tsKunde.Name = "tsKunde";
        this.tsKunde.Size = new System.Drawing.Size(1156, 38);
        this.tsKunde.TabIndex = 0;
        this.tsKunde.Text = "toolStrip1";
        // 
        // itemAnzeigen
        // 
        this.itemAnzeigen.AutoSize = false;
        this.itemAnzeigen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.itemAnzeigen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.itemAnzeigen.Image = global::Norka.Properties.Resources.edit_user_32;
        this.itemAnzeigen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.itemAnzeigen.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.itemAnzeigen.Name = "itemAnzeigen";
        this.itemAnzeigen.Size = new System.Drawing.Size(50, 35);
        this.itemAnzeigen.Text = "Anzeigen";
        this.itemAnzeigen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
        this.itemAnzeigen.Click += new System.EventHandler(this.itemAnzeigen_Click);
        // 
        // itemLoeschen
        // 
        this.itemLoeschen.AutoSize = false;
        this.itemLoeschen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.itemLoeschen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.itemLoeschen.Image = global::Norka.Properties.Resources.remove_user_32;
        this.itemLoeschen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.itemLoeschen.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.itemLoeschen.Name = "itemLoeschen";
        this.itemLoeschen.Size = new System.Drawing.Size(50, 35);
        this.itemLoeschen.Text = "Löschen";
        this.itemLoeschen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
        this.itemLoeschen.Click += new System.EventHandler(this.itemLoeschen_Click);
        // 
        // itemArchivSchließen
        // 
        this.itemArchivSchließen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        this.itemArchivSchließen.AutoSize = false;
        this.itemArchivSchließen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.itemArchivSchließen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.itemArchivSchließen.Image = global::Norka.Properties.Resources.Close_32;
        this.itemArchivSchließen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.itemArchivSchließen.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.itemArchivSchließen.Name = "itemArchivSchließen";
        this.itemArchivSchließen.Size = new System.Drawing.Size(36, 36);
        this.itemArchivSchließen.Text = "Schließen";
        this.itemArchivSchließen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
        this.itemArchivSchließen.Click += new System.EventHandler(this.itemArchivSch_Click);
        // 
        // toolStripSeparator2
        // 
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
        // 
        // itemDrucken
        // 
        this.itemDrucken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.itemDrucken.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorschauToolStripMenuItem,
            this.sofortdruckToolStripMenuItem,
            this.faxToolStripMenuItem1});
        this.itemDrucken.Enabled = false;
        this.itemDrucken.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.itemDrucken.Image = global::Norka.Properties.Resources.print_32;
        this.itemDrucken.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.itemDrucken.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.itemDrucken.Name = "itemDrucken";
        this.itemDrucken.Size = new System.Drawing.Size(45, 35);
        this.itemDrucken.Text = "toolStripButton1";
        this.itemDrucken.ToolTipText = "Drucken";
        this.itemDrucken.Visible = false;
        // 
        // vorschauToolStripMenuItem
        // 
        this.vorschauToolStripMenuItem.Name = "vorschauToolStripMenuItem";
        this.vorschauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.vorschauToolStripMenuItem.Text = "Vorschau";
        this.vorschauToolStripMenuItem.Click += new System.EventHandler(this.vorschauToolStripMenuItem_Click);
        // 
        // sofortdruckToolStripMenuItem
        // 
        this.sofortdruckToolStripMenuItem.Name = "sofortdruckToolStripMenuItem";
        this.sofortdruckToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        this.sofortdruckToolStripMenuItem.Text = "Sofortdruck";
        this.sofortdruckToolStripMenuItem.Click += new System.EventHandler(this.sofortdruckToolStripMenuItem_Click);
        // 
        // faxToolStripMenuItem1
        // 
        this.faxToolStripMenuItem1.Name = "faxToolStripMenuItem1";
        this.faxToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
        this.faxToolStripMenuItem1.Text = "Fax";
        this.faxToolStripMenuItem1.Click += new System.EventHandler(this.faxToolStripMenuItem_Click);
        // 
        // toolStripSeparator3
        // 
        this.toolStripSeparator3.Name = "toolStripSeparator3";
        this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
        this.toolStripSeparator3.Visible = false;
        // 
        // itemAktualisieren
        // 
        this.itemAktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.itemAktualisieren.Image = global::Norka.Properties.Resources.refresh_32;
        this.itemAktualisieren.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
        this.itemAktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.itemAktualisieren.Name = "itemAktualisieren";
        this.itemAktualisieren.Size = new System.Drawing.Size(36, 35);
        this.itemAktualisieren.Text = "Aktuelle Auswahl aktualisieren";
        this.itemAktualisieren.Click += new System.EventHandler(this.itemAktualisieren_Click);
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
        // 
        // itemAlleMarkieren
        // 
        this.itemAlleMarkieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.itemAlleMarkieren.Image = ((System.Drawing.Image)(resources.GetObject("itemAlleMarkieren.Image")));
        this.itemAlleMarkieren.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.itemAlleMarkieren.Name = "itemAlleMarkieren";
        this.itemAlleMarkieren.Size = new System.Drawing.Size(106, 35);
        this.itemAlleMarkieren.Text = "Alle Markieren";
        this.itemAlleMarkieren.Click += new System.EventHandler(this.itemAlleMarkieren_Click);
        // 
        // itemKeineMarkieren
        // 
        this.itemKeineMarkieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        this.itemKeineMarkieren.Image = ((System.Drawing.Image)(resources.GetObject("itemKeineMarkieren.Image")));
        this.itemKeineMarkieren.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.itemKeineMarkieren.Name = "itemKeineMarkieren";
        this.itemKeineMarkieren.Size = new System.Drawing.Size(117, 35);
        this.itemKeineMarkieren.Text = "Keine Markieren";
        this.itemKeineMarkieren.Click += new System.EventHandler(this.itemKeineMarkieren_Click);
        // 
        // ctmArchivGrid
        // 
        this.ctmArchivGrid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.ctmArchivGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anzeigenToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.druckenToolStripMenuItem});
        this.ctmArchivGrid.Name = "ctmKundenGrid";
        this.ctmArchivGrid.Size = new System.Drawing.Size(135, 70);
        this.ctmArchivGrid.Opened += new System.EventHandler(this.ctmArchivGrid_Opened);
        // 
        // anzeigenToolStripMenuItem
        // 
        this.anzeigenToolStripMenuItem.Image = global::Norka.Properties.Resources.edit_user_32;
        this.anzeigenToolStripMenuItem.Name = "anzeigenToolStripMenuItem";
        this.anzeigenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
        this.anzeigenToolStripMenuItem.Text = "Anzeigen";
        this.anzeigenToolStripMenuItem.Click += new System.EventHandler(this.anzeigenToolStripMenuItem_Click);
        // 
        // löschenToolStripMenuItem
        // 
        this.löschenToolStripMenuItem.Image = global::Norka.Properties.Resources.remove_user_32;
        this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
        this.löschenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
        this.löschenToolStripMenuItem.Text = "Löschen";
        this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
        // 
        // druckenToolStripMenuItem
        // 
        this.druckenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorschauToolStripMenuItem2,
            this.sofortdruckToolStripMenuItem2,
            this.faxToolStripMenuItem2});
        this.druckenToolStripMenuItem.Image = global::Norka.Properties.Resources.print_32;
        this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
        this.druckenToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
        this.druckenToolStripMenuItem.Text = "Drucken";
        // 
        // vorschauToolStripMenuItem2
        // 
        this.vorschauToolStripMenuItem2.Name = "vorschauToolStripMenuItem2";
        this.vorschauToolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
        this.vorschauToolStripMenuItem2.Text = "Vorschau";
        this.vorschauToolStripMenuItem2.Click += new System.EventHandler(this.vorschauToolStripMenuItem_Click);
        // 
        // sofortdruckToolStripMenuItem2
        // 
        this.sofortdruckToolStripMenuItem2.Name = "sofortdruckToolStripMenuItem2";
        this.sofortdruckToolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
        this.sofortdruckToolStripMenuItem2.Text = "Sofortdruck";
        this.sofortdruckToolStripMenuItem2.Click += new System.EventHandler(this.sofortdruckToolStripMenuItem_Click);
        // 
        // faxToolStripMenuItem2
        // 
        this.faxToolStripMenuItem2.Name = "faxToolStripMenuItem2";
        this.faxToolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
        this.faxToolStripMenuItem2.Text = "Fax";
        this.faxToolStripMenuItem2.Click += new System.EventHandler(this.faxToolStripMenuItem_Click);
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
        this.splitContainer1.Panel2.Controls.Add(this.sstpArchiv);
        this.splitContainer1.Size = new System.Drawing.Size(1156, 744);
        this.splitContainer1.SplitterDistance = 133;
        this.splitContainer1.TabIndex = 3;
        // 
        // trvKategorie
        // 
        this.trvKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        this.trvKategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.trvKategorie.Dock = System.Windows.Forms.DockStyle.Fill;
        this.trvKategorie.FullRowSelect = true;
        this.trvKategorie.ItemHeight = 30;
        this.trvKategorie.Location = new System.Drawing.Point(0, 0);
        this.trvKategorie.Name = "trvKategorie";
        treeNode4.Name = "Angebote";
        treeNode4.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        treeNode4.Text = "Angebote";
        treeNode4.ToolTipText = "Alle Angebote anzeigen.";
        treeNode5.Name = "Aufträge";
        treeNode5.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        treeNode5.Text = "Aufträge";
        treeNode5.ToolTipText = "Alle Aufträge anzeigen:";
        treeNode6.Name = "Rechnungen";
        treeNode6.NodeFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        treeNode6.Text = "Rechnungen";
        treeNode6.ToolTipText = "Alle Rechnungen anzeigen.";
        this.trvKategorie.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
        this.trvKategorie.Size = new System.Drawing.Size(133, 744);
        this.trvKategorie.TabIndex = 0;
        this.trvKategorie.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvKategorie_NodeMouseClick);
        // 
        // dgrResults
        // 
        this.dgrResults.AllowUserToAddRows = false;
        this.dgrResults.AllowUserToDeleteRows = false;
        this.dgrResults.AllowUserToResizeRows = false;
        dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
        this.dgrResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        this.dgrResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        this.dgrResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
        dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
        dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.dgrResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        this.dgrResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgrResults.ContextMenuStrip = this.ctmArchivGrid;
        this.dgrResults.Cursor = System.Windows.Forms.Cursors.Arrow;
        dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
        dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgrResults.DefaultCellStyle = dataGridViewCellStyle6;
        this.dgrResults.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgrResults.Location = new System.Drawing.Point(0, 0);
        this.dgrResults.MultiSelect = false;
        this.dgrResults.Name = "dgrResults";
        this.dgrResults.ReadOnly = true;
        this.dgrResults.RowHeadersVisible = false;
        this.dgrResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgrResults.Size = new System.Drawing.Size(1019, 722);
        this.dgrResults.TabIndex = 0;
        this.dgrResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgrKunden_MouseDown);
        this.dgrResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrResults_CellDoubleClick);
        this.dgrResults.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrResults_ColumnHeaderMouseClick);
        this.dgrResults.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgrResults_RowsAdded);
        this.dgrResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrResults_CellClick);
        // 
        // sstpArchiv
        // 
        this.sstpArchiv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slArchiv});
        this.sstpArchiv.Location = new System.Drawing.Point(0, 722);
        this.sstpArchiv.Name = "sstpArchiv";
        this.sstpArchiv.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
        this.sstpArchiv.Size = new System.Drawing.Size(1019, 22);
        this.sstpArchiv.SizingGrip = false;
        this.sstpArchiv.TabIndex = 1;
        this.sstpArchiv.Text = "statusStrip1";
        // 
        // slArchiv
        // 
        this.slArchiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.slArchiv.Name = "slArchiv";
        this.slArchiv.Size = new System.Drawing.Size(0, 17);
        // 
        // Form_Archiv
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
        this.Name = "Form_Archiv";
        this.Text = "Archiv";
        this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        this.Load += new System.EventHandler(this.Form_Archiv_Load);
        this.tsKunde.ResumeLayout(false);
        this.tsKunde.PerformLayout();
        this.ctmArchivGrid.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.splitContainer1.Panel1.ResumeLayout(false);
        this.splitContainer1.Panel2.ResumeLayout(false);
        this.splitContainer1.Panel2.PerformLayout();
        this.splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dgrResults)).EndInit();
        this.sstpArchiv.ResumeLayout(false);
        this.sstpArchiv.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolStrip tsKunde;
    private System.Windows.Forms.ToolStripButton itemAnzeigen;
    private System.Windows.Forms.ToolStripButton itemLoeschen;
    private System.Windows.Forms.ToolStripButton itemArchivSchließen;
    private System.Windows.Forms.ContextMenuStrip ctmArchivGrid;
    private System.Windows.Forms.ToolStripMenuItem anzeigenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
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
    private System.Windows.Forms.ToolStripButton itemAlleMarkieren;
    private System.Windows.Forms.ToolStripButton itemKeineMarkieren;
    private System.Windows.Forms.ToolStripDropDownButton itemDrucken;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.TreeView trvKategorie;
    public System.Windows.Forms.DataGridView dgrResults;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton itemAktualisieren;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.StatusStrip sstpArchiv;
    public System.Windows.Forms.ToolStripStatusLabel slArchiv;
    private System.Windows.Forms.ToolStripMenuItem vorschauToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sofortdruckToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem faxToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem vorschauToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem sofortdruckToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem faxToolStripMenuItem2;
  }
}