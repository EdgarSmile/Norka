namespace Norka.Rechnungen
{
    partial class Form_Rechnung
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rechnung));
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
          this.itemMarkAll = new System.Windows.Forms.ToolStrip();
          this.itemAufNeu = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
          this.itemPosNeu = new System.Windows.Forms.ToolStripButton();
          this.itemPosEdit = new System.Windows.Forms.ToolStripButton();
          this.itemPosDelete = new System.Windows.Forms.ToolStripButton();
          this.itemClose = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
          this.itemStornieren = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
          this.itemPrint = new System.Windows.Forms.ToolStripDropDownButton();
          this.rechnungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.vorschauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
          this.sofortdruckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
          this.mahnungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.MahnungFreundlicheItem = new System.Windows.Forms.ToolStripMenuItem();
          this.MahnungErsteItem = new System.Windows.Forms.ToolStripMenuItem();
          this.MahnungErneuteItem = new System.Windows.Forms.ToolStripMenuItem();
          this.MahnungLetzteItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
          this.itemMail = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
          this.itemEinbehaltSetzen = new System.Windows.Forms.ToolStripButton();
          this.itemEinbehaltLoeschen = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.splitContainer1 = new System.Windows.Forms.SplitContainer();
          this.splitContainer2 = new System.Windows.Forms.SplitContainer();
          this.grpKunde = new System.Windows.Forms.GroupBox();
          this.panel2 = new System.Windows.Forms.Panel();
          this.label12 = new System.Windows.Forms.Label();
          this.tbxKdAnrede = new System.Windows.Forms.TextBox();
          this.tbxKdHaenden = new System.Windows.Forms.TextBox();
          this.tbxKdName = new System.Windows.Forms.TextBox();
          this.label20 = new System.Windows.Forms.Label();
          this.label21 = new System.Windows.Forms.Label();
          this.label22 = new System.Windows.Forms.Label();
          this.tbxKdNummer = new System.Windows.Forms.TextBox();
          this.groupBox3 = new System.Windows.Forms.GroupBox();
          this.panel1 = new System.Windows.Forms.Panel();
          this.tbxBV2 = new System.Windows.Forms.TextBox();
          this.cobNachlass = new System.Windows.Forms.ComboBox();
          this.cbxAnfahrt = new System.Windows.Forms.CheckBox();
          this.cbxAufmaß = new System.Windows.Forms.CheckBox();
          this.label8 = new System.Windows.Forms.Label();
          this.cobMwSt = new System.Windows.Forms.ComboBox();
          this.steuerBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dsSteuer = new Norka.Extras.dsSteuer();
          this.tbxNachlass = new System.Windows.Forms.TextBox();
          this.label5 = new System.Windows.Forms.Label();
          this.cobSkonto = new System.Windows.Forms.ComboBox();
          this.label19 = new System.Windows.Forms.Label();
          this.cobBetreff = new System.Windows.Forms.ComboBox();
          this.label3 = new System.Windows.Forms.Label();
          this.tbxBauvorhaben = new System.Windows.Forms.TextBox();
          this.tbxEigenerText = new System.Windows.Forms.TextBox();
          this.label6 = new System.Windows.Forms.Label();
          this.label4 = new System.Windows.Forms.Label();
          this.cobTyp = new System.Windows.Forms.ComboBox();
          this.label1 = new System.Windows.Forms.Label();
          this.dateRechnung = new System.Windows.Forms.DateTimePicker();
          this.lblVorname = new System.Windows.Forms.Label();
          this.tbxRechNummer = new System.Windows.Forms.TextBox();
          this.dgrPositionen = new System.Windows.Forms.DataGridView();
          this.label2 = new System.Windows.Forms.Label();
          this.tbxSondertext = new System.Windows.Forms.TextBox();
          this.panel3 = new System.Windows.Forms.Panel();
          this.label9 = new System.Windows.Forms.Label();
          this.lblAufGesamt = new System.Windows.Forms.Label();
          this.lblSteuer = new System.Windows.Forms.Label();
          this.label25 = new System.Windows.Forms.Label();
          this.lblZwischensumme = new System.Windows.Forms.Label();
          this.lblNachlass = new System.Windows.Forms.Label();
          this.label26 = new System.Windows.Forms.Label();
          this.lblGesPos = new System.Windows.Forms.Label();
          this.label11 = new System.Windows.Forms.Label();
          this.label7 = new System.Windows.Forms.Label();
          this.lblSum = new System.Windows.Forms.Label();
          this.btnEdit = new System.Windows.Forms.Button();
          this.btnAnlegen = new System.Windows.Forms.Button();
          this.ctmAngebot = new System.Windows.Forms.ContextMenuStrip(this.components);
          this.itemBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
          this.itemLoeschen = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
          this.rechnungÖffeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.itemKalkulationSchließen = new System.Windows.Forms.ToolStripButton();
          this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
          this.label17 = new System.Windows.Forms.Label();
          this.label15 = new System.Windows.Forms.Label();
          this.label14 = new System.Windows.Forms.Label();
          this.itemPositionNeu = new System.Windows.Forms.ToolStripButton();
          this.itemPositionLoe = new System.Windows.Forms.ToolStripButton();
          this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
          this.steuerTableAdapter = new Norka.Extras.dsSteuerTableAdapters.SteuerTableAdapter();
          this.itemMarkAll.SuspendLayout();
          this.splitContainer1.Panel1.SuspendLayout();
          this.splitContainer1.Panel2.SuspendLayout();
          this.splitContainer1.SuspendLayout();
          this.splitContainer2.Panel1.SuspendLayout();
          this.splitContainer2.Panel2.SuspendLayout();
          this.splitContainer2.SuspendLayout();
          this.grpKunde.SuspendLayout();
          this.panel2.SuspendLayout();
          this.groupBox3.SuspendLayout();
          this.panel1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.steuerBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsSteuer)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dgrPositionen)).BeginInit();
          this.panel3.SuspendLayout();
          this.ctmAngebot.SuspendLayout();
          this.tableLayoutPanel1.SuspendLayout();
          this.SuspendLayout();
          // 
          // itemMarkAll
          // 
          this.itemMarkAll.BackColor = System.Drawing.SystemColors.MenuBar;
          this.itemMarkAll.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.itemMarkAll.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
          this.itemMarkAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAufNeu,
            this.toolStripSeparator5,
            this.itemPosNeu,
            this.itemPosEdit,
            this.itemPosDelete,
            this.itemClose,
            this.toolStripSeparator2,
            this.itemStornieren,
            this.toolStripSeparator7,
            this.itemPrint,
            this.toolStripSeparator3,
            this.itemMail,
            this.toolStripSeparator6,
            this.itemEinbehaltSetzen,
            this.itemEinbehaltLoeschen,
            this.toolStripSeparator10});
          this.itemMarkAll.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
          this.itemMarkAll.Location = new System.Drawing.Point(0, 0);
          this.itemMarkAll.Name = "itemMarkAll";
          this.itemMarkAll.Size = new System.Drawing.Size(1156, 39);
          this.itemMarkAll.TabIndex = 6;
          this.itemMarkAll.Text = "toolStrip1";
          // 
          // itemAufNeu
          // 
          this.itemAufNeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemAufNeu.Enabled = false;
          this.itemAufNeu.Image = global::Norka.Properties.Resources.add_32;
          this.itemAufNeu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemAufNeu.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemAufNeu.Name = "itemAufNeu";
          this.itemAufNeu.Size = new System.Drawing.Size(36, 36);
          this.itemAufNeu.Text = "Neuer Auftrag";
          // 
          // toolStripSeparator5
          // 
          this.toolStripSeparator5.Name = "toolStripSeparator5";
          this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
          // 
          // itemPosNeu
          // 
          this.itemPosNeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemPosNeu.Enabled = false;
          this.itemPosNeu.Image = global::Norka.Properties.Resources.add_user_32;
          this.itemPosNeu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemPosNeu.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemPosNeu.Name = "itemPosNeu";
          this.itemPosNeu.Size = new System.Drawing.Size(36, 36);
          this.itemPosNeu.Text = "Neue Position hinzufügen";
          // 
          // itemPosEdit
          // 
          this.itemPosEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemPosEdit.Enabled = false;
          this.itemPosEdit.Image = global::Norka.Properties.Resources.edit_user_32;
          this.itemPosEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemPosEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemPosEdit.Name = "itemPosEdit";
          this.itemPosEdit.Size = new System.Drawing.Size(36, 36);
          this.itemPosEdit.Text = "Position ändern";
          // 
          // itemPosDelete
          // 
          this.itemPosDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemPosDelete.Enabled = false;
          this.itemPosDelete.Image = global::Norka.Properties.Resources.remove_user_32;
          this.itemPosDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemPosDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemPosDelete.Name = "itemPosDelete";
          this.itemPosDelete.Size = new System.Drawing.Size(36, 36);
          this.itemPosDelete.Text = "Position löschen";
          // 
          // itemClose
          // 
          this.itemClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
          this.itemClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemClose.Image = global::Norka.Properties.Resources.Close_32;
          this.itemClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemClose.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemClose.Name = "itemClose";
          this.itemClose.Size = new System.Drawing.Size(36, 36);
          this.itemClose.Text = "Schließen";
          this.itemClose.Click += new System.EventHandler(this.itemClose_Click);
          // 
          // toolStripSeparator2
          // 
          this.toolStripSeparator2.Name = "toolStripSeparator2";
          this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
          // 
          // itemStornieren
          // 
          this.itemStornieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemStornieren.Enabled = false;
          this.itemStornieren.Image = global::Norka.Properties.Resources.Storno;
          this.itemStornieren.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemStornieren.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemStornieren.Name = "itemStornieren";
          this.itemStornieren.Size = new System.Drawing.Size(36, 36);
          this.itemStornieren.Text = "Rechnung stornieren";
          this.itemStornieren.Click += new System.EventHandler(this.itemStornieren_Click);
          // 
          // toolStripSeparator7
          // 
          this.toolStripSeparator7.Name = "toolStripSeparator7";
          this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
          // 
          // itemPrint
          // 
          this.itemPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechnungToolStripMenuItem,
            this.toolStripSeparator9,
            this.mahnungToolStripMenuItem});
          this.itemPrint.Enabled = false;
          this.itemPrint.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.itemPrint.Image = global::Norka.Properties.Resources.print_32;
          this.itemPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemPrint.Name = "itemPrint";
          this.itemPrint.Size = new System.Drawing.Size(45, 36);
          this.itemPrint.Text = "Auftrag drucken";
          // 
          // rechnungToolStripMenuItem
          // 
          this.rechnungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vorschauToolStripMenuItem1,
            this.sofortdruckToolStripMenuItem1});
          this.rechnungToolStripMenuItem.Name = "rechnungToolStripMenuItem";
          this.rechnungToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
          this.rechnungToolStripMenuItem.Text = "Rechnung";
          // 
          // vorschauToolStripMenuItem1
          // 
          this.vorschauToolStripMenuItem1.Name = "vorschauToolStripMenuItem1";
          this.vorschauToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
          this.vorschauToolStripMenuItem1.Text = "Vorschau";
          this.vorschauToolStripMenuItem1.Click += new System.EventHandler(this.vorschauToolStripMenuItem_Click);
          // 
          // sofortdruckToolStripMenuItem1
          // 
          this.sofortdruckToolStripMenuItem1.Name = "sofortdruckToolStripMenuItem1";
          this.sofortdruckToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
          this.sofortdruckToolStripMenuItem1.Text = "Sofortdruck";
          this.sofortdruckToolStripMenuItem1.Click += new System.EventHandler(this.sofortdruckToolStripMenuItem_Click);
          // 
          // toolStripSeparator9
          // 
          this.toolStripSeparator9.Name = "toolStripSeparator9";
          this.toolStripSeparator9.Size = new System.Drawing.Size(134, 6);
          // 
          // mahnungToolStripMenuItem
          // 
          this.mahnungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MahnungFreundlicheItem,
            this.MahnungErsteItem,
            this.MahnungErneuteItem,
            this.MahnungLetzteItem});
          this.mahnungToolStripMenuItem.Name = "mahnungToolStripMenuItem";
          this.mahnungToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
          this.mahnungToolStripMenuItem.Text = "Mahnung";
          // 
          // MahnungFreundlicheItem
          // 
          this.MahnungFreundlicheItem.Name = "MahnungFreundlicheItem";
          this.MahnungFreundlicheItem.Size = new System.Drawing.Size(151, 22);
          this.MahnungFreundlicheItem.Text = "Freundliche";
          this.MahnungFreundlicheItem.Click += new System.EventHandler(this.MahnungFreundlicheItem_Click);
          // 
          // MahnungErsteItem
          // 
          this.MahnungErsteItem.Name = "MahnungErsteItem";
          this.MahnungErsteItem.Size = new System.Drawing.Size(151, 22);
          this.MahnungErsteItem.Text = "Erste";
          this.MahnungErsteItem.Click += new System.EventHandler(this.MahnungErsteItem_Click);
          // 
          // MahnungErneuteItem
          // 
          this.MahnungErneuteItem.Name = "MahnungErneuteItem";
          this.MahnungErneuteItem.Size = new System.Drawing.Size(151, 22);
          this.MahnungErneuteItem.Text = "Erneute";
          this.MahnungErneuteItem.Click += new System.EventHandler(this.MahnungErneuteItem_Click);
          // 
          // MahnungLetzteItem
          // 
          this.MahnungLetzteItem.Name = "MahnungLetzteItem";
          this.MahnungLetzteItem.Size = new System.Drawing.Size(151, 22);
          this.MahnungLetzteItem.Text = "Letzte";
          this.MahnungLetzteItem.Click += new System.EventHandler(this.MahnungLetzteItem_Click);
          // 
          // toolStripSeparator3
          // 
          this.toolStripSeparator3.Name = "toolStripSeparator3";
          this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
          // 
          // itemMail
          // 
          this.itemMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemMail.Enabled = false;
          this.itemMail.Image = global::Norka.Properties.Resources.mail_32;
          this.itemMail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemMail.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemMail.Name = "itemMail";
          this.itemMail.Size = new System.Drawing.Size(36, 36);
          this.itemMail.ToolTipText = "E-Mailversand";
          this.itemMail.Click += new System.EventHandler(this.itemMail_Click);
          // 
          // toolStripSeparator6
          // 
          this.toolStripSeparator6.Name = "toolStripSeparator6";
          this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
          // 
          // itemEinbehaltSetzen
          // 
          this.itemEinbehaltSetzen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          this.itemEinbehaltSetzen.Enabled = false;
          this.itemEinbehaltSetzen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.itemEinbehaltSetzen.Image = ((System.Drawing.Image)(resources.GetObject("itemEinbehaltSetzen.Image")));
          this.itemEinbehaltSetzen.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemEinbehaltSetzen.Name = "itemEinbehaltSetzen";
          this.itemEinbehaltSetzen.Size = new System.Drawing.Size(119, 36);
          this.itemEinbehaltSetzen.Text = "Einbehalt setzen";
          this.itemEinbehaltSetzen.Click += new System.EventHandler(this.itemEinbehaltSetzen_Click);
          // 
          // itemEinbehaltLoeschen
          // 
          this.itemEinbehaltLoeschen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          this.itemEinbehaltLoeschen.Enabled = false;
          this.itemEinbehaltLoeschen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.itemEinbehaltLoeschen.Image = ((System.Drawing.Image)(resources.GetObject("itemEinbehaltLoeschen.Image")));
          this.itemEinbehaltLoeschen.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemEinbehaltLoeschen.Name = "itemEinbehaltLoeschen";
          this.itemEinbehaltLoeschen.Size = new System.Drawing.Size(126, 36);
          this.itemEinbehaltLoeschen.Text = "Einbehalt löschen";
          this.itemEinbehaltLoeschen.Click += new System.EventHandler(this.itemEinbehaltLoeschen_Click);
          // 
          // toolStripSeparator10
          // 
          this.toolStripSeparator10.Name = "toolStripSeparator10";
          this.toolStripSeparator10.Size = new System.Drawing.Size(6, 39);
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
          // 
          // splitContainer1
          // 
          this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.splitContainer1.IsSplitterFixed = true;
          this.splitContainer1.Location = new System.Drawing.Point(0, 39);
          this.splitContainer1.Name = "splitContainer1";
          this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
          // 
          // splitContainer1.Panel1
          // 
          this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
          // 
          // splitContainer1.Panel2
          // 
          this.splitContainer1.Panel2.Controls.Add(this.label2);
          this.splitContainer1.Panel2.Controls.Add(this.tbxSondertext);
          this.splitContainer1.Panel2.Controls.Add(this.panel3);
          this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
          this.splitContainer1.Panel2.Controls.Add(this.btnAnlegen);
          this.splitContainer1.Size = new System.Drawing.Size(1156, 844);
          this.splitContainer1.SplitterDistance = 653;
          this.splitContainer1.TabIndex = 7;
          this.splitContainer1.TabStop = false;
          // 
          // splitContainer2
          // 
          this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
          this.splitContainer2.IsSplitterFixed = true;
          this.splitContainer2.Location = new System.Drawing.Point(0, 0);
          this.splitContainer2.Name = "splitContainer2";
          this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
          // 
          // splitContainer2.Panel1
          // 
          this.splitContainer2.Panel1.Controls.Add(this.grpKunde);
          this.splitContainer2.Panel1.Controls.Add(this.groupBox3);
          // 
          // splitContainer2.Panel2
          // 
          this.splitContainer2.Panel2.Controls.Add(this.dgrPositionen);
          this.splitContainer2.Panel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.splitContainer2.Size = new System.Drawing.Size(1156, 653);
          this.splitContainer2.SplitterDistance = 281;
          this.splitContainer2.TabIndex = 0;
          this.splitContainer2.TabStop = false;
          // 
          // grpKunde
          // 
          this.grpKunde.Controls.Add(this.panel2);
          this.grpKunde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.grpKunde.Location = new System.Drawing.Point(823, 12);
          this.grpKunde.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
          this.grpKunde.Name = "grpKunde";
          this.grpKunde.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
          this.grpKunde.Size = new System.Drawing.Size(328, 151);
          this.grpKunde.TabIndex = 1;
          this.grpKunde.TabStop = false;
          this.grpKunde.Text = "Kunde";
          // 
          // panel2
          // 
          this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
          this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.panel2.Controls.Add(this.label12);
          this.panel2.Controls.Add(this.tbxKdAnrede);
          this.panel2.Controls.Add(this.tbxKdHaenden);
          this.panel2.Controls.Add(this.tbxKdName);
          this.panel2.Controls.Add(this.label20);
          this.panel2.Controls.Add(this.label21);
          this.panel2.Controls.Add(this.label22);
          this.panel2.Controls.Add(this.tbxKdNummer);
          this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel2.Location = new System.Drawing.Point(5, 17);
          this.panel2.Name = "panel2";
          this.panel2.Size = new System.Drawing.Size(318, 131);
          this.panel2.TabIndex = 0;
          // 
          // label12
          // 
          this.label12.AutoSize = true;
          this.label12.Location = new System.Drawing.Point(4, 65);
          this.label12.Name = "label12";
          this.label12.Size = new System.Drawing.Size(44, 13);
          this.label12.TabIndex = 28;
          this.label12.Text = "Name";
          // 
          // tbxKdAnrede
          // 
          this.tbxKdAnrede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxKdAnrede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxKdAnrede.Enabled = false;
          this.tbxKdAnrede.Location = new System.Drawing.Point(83, 34);
          this.tbxKdAnrede.Name = "tbxKdAnrede";
          this.tbxKdAnrede.Size = new System.Drawing.Size(225, 21);
          this.tbxKdAnrede.TabIndex = 27;
          this.tbxKdAnrede.TabStop = false;
          this.tbxKdAnrede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          // 
          // tbxKdHaenden
          // 
          this.tbxKdHaenden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxKdHaenden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxKdHaenden.Enabled = false;
          this.tbxKdHaenden.Location = new System.Drawing.Point(84, 97);
          this.tbxKdHaenden.Name = "tbxKdHaenden";
          this.tbxKdHaenden.Size = new System.Drawing.Size(225, 21);
          this.tbxKdHaenden.TabIndex = 15;
          this.tbxKdHaenden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          this.tbxKdHaenden.TextChanged += new System.EventHandler(this.tbxKdHaenden_TextChanged);
          // 
          // tbxKdName
          // 
          this.tbxKdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxKdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxKdName.Enabled = false;
          this.tbxKdName.Location = new System.Drawing.Point(84, 62);
          this.tbxKdName.Name = "tbxKdName";
          this.tbxKdName.Size = new System.Drawing.Size(225, 21);
          this.tbxKdName.TabIndex = 23;
          this.tbxKdName.TabStop = false;
          this.tbxKdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          // 
          // label20
          // 
          this.label20.AutoSize = true;
          this.label20.Location = new System.Drawing.Point(3, 100);
          this.label20.Name = "label20";
          this.label20.Size = new System.Drawing.Size(75, 13);
          this.label20.TabIndex = 22;
          this.label20.Text = "zu Händen";
          // 
          // label21
          // 
          this.label21.AutoSize = true;
          this.label21.Location = new System.Drawing.Point(4, 37);
          this.label21.Name = "label21";
          this.label21.Size = new System.Drawing.Size(54, 13);
          this.label21.TabIndex = 21;
          this.label21.Text = "Anrede";
          // 
          // label22
          // 
          this.label22.AutoSize = true;
          this.label22.Location = new System.Drawing.Point(3, 11);
          this.label22.Name = "label22";
          this.label22.Size = new System.Drawing.Size(62, 13);
          this.label22.TabIndex = 1;
          this.label22.Text = "Nummer";
          // 
          // tbxKdNummer
          // 
          this.tbxKdNummer.AutoCompleteCustomSource.AddRange(new string[] {
            "Tobias"});
          this.tbxKdNummer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
          this.tbxKdNummer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
          this.tbxKdNummer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxKdNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxKdNummer.Enabled = false;
          this.tbxKdNummer.Location = new System.Drawing.Point(83, 8);
          this.tbxKdNummer.Name = "tbxKdNummer";
          this.tbxKdNummer.Size = new System.Drawing.Size(225, 21);
          this.tbxKdNummer.TabIndex = 14;
          this.tbxKdNummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          this.tbxKdNummer.TextChanged += new System.EventHandler(this.tbxKdNummer_TextChanged);
          // 
          // groupBox3
          // 
          this.groupBox3.Controls.Add(this.panel1);
          this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.groupBox3.Location = new System.Drawing.Point(5, 6);
          this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
          this.groupBox3.Name = "groupBox3";
          this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
          this.groupBox3.Size = new System.Drawing.Size(793, 273);
          this.groupBox3.TabIndex = 0;
          this.groupBox3.TabStop = false;
          this.groupBox3.Text = "Rechnung";
          // 
          // panel1
          // 
          this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
          this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.panel1.Controls.Add(this.tbxBV2);
          this.panel1.Controls.Add(this.cobNachlass);
          this.panel1.Controls.Add(this.cbxAnfahrt);
          this.panel1.Controls.Add(this.cbxAufmaß);
          this.panel1.Controls.Add(this.label8);
          this.panel1.Controls.Add(this.cobMwSt);
          this.panel1.Controls.Add(this.tbxNachlass);
          this.panel1.Controls.Add(this.label5);
          this.panel1.Controls.Add(this.cobSkonto);
          this.panel1.Controls.Add(this.label19);
          this.panel1.Controls.Add(this.cobBetreff);
          this.panel1.Controls.Add(this.label3);
          this.panel1.Controls.Add(this.tbxBauvorhaben);
          this.panel1.Controls.Add(this.tbxEigenerText);
          this.panel1.Controls.Add(this.label6);
          this.panel1.Controls.Add(this.label4);
          this.panel1.Controls.Add(this.cobTyp);
          this.panel1.Controls.Add(this.label1);
          this.panel1.Controls.Add(this.dateRechnung);
          this.panel1.Controls.Add(this.lblVorname);
          this.panel1.Controls.Add(this.tbxRechNummer);
          this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel1.Location = new System.Drawing.Point(5, 17);
          this.panel1.Name = "panel1";
          this.panel1.Size = new System.Drawing.Size(783, 253);
          this.panel1.TabIndex = 0;
          // 
          // tbxBV2
          // 
          this.tbxBV2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxBV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxBV2.Enabled = false;
          this.tbxBV2.Location = new System.Drawing.Point(83, 118);
          this.tbxBV2.Name = "tbxBV2";
          this.tbxBV2.Size = new System.Drawing.Size(630, 21);
          this.tbxBV2.TabIndex = 5;
          this.tbxBV2.TextChanged += new System.EventHandler(this.tbxBV2_TextChanged);
          // 
          // cobNachlass
          // 
          this.cobNachlass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.cobNachlass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.cobNachlass.Enabled = false;
          this.cobNachlass.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.cobNachlass.FormattingEnabled = true;
          this.cobNachlass.Items.AddRange(new object[] {
            "Prozent",
            "Euro"});
          this.cobNachlass.Location = new System.Drawing.Point(181, 197);
          this.cobNachlass.Name = "cobNachlass";
          this.cobNachlass.Size = new System.Drawing.Size(130, 21);
          this.cobNachlass.TabIndex = 9;
          this.cobNachlass.SelectedIndexChanged += new System.EventHandler(this.cobNachlass_SelectedIndexChanged);
          this.cobNachlass.TextChanged += new System.EventHandler(this.cobNachlass_TextChanged);
          // 
          // cbxAnfahrt
          // 
          this.cbxAnfahrt.AutoSize = true;
          this.cbxAnfahrt.Enabled = false;
          this.cbxAnfahrt.Location = new System.Drawing.Point(332, 220);
          this.cbxAnfahrt.Name = "cbxAnfahrt";
          this.cbxAnfahrt.Size = new System.Drawing.Size(143, 17);
          this.cbxAnfahrt.TabIndex = 12;
          this.cbxAnfahrt.Text = "Einmalige Anfahrt";
          this.cbxAnfahrt.UseVisualStyleBackColor = true;
          this.cbxAnfahrt.CheckedChanged += new System.EventHandler(this.cbxAnfahrt_CheckedChanged);
          // 
          // cbxAufmaß
          // 
          this.cbxAufmaß.AutoSize = true;
          this.cbxAufmaß.Enabled = false;
          this.cbxAufmaß.Location = new System.Drawing.Point(332, 197);
          this.cbxAufmaß.Name = "cbxAufmaß";
          this.cbxAufmaß.Size = new System.Drawing.Size(158, 17);
          this.cbxAufmaß.TabIndex = 11;
          this.cbxAufmaß.Text = "Aufmaß erforderlich";
          this.cbxAufmaß.UseVisualStyleBackColor = true;
          this.cbxAufmaß.CheckedChanged += new System.EventHandler(this.cbxAufmaß_CheckedChanged);
          // 
          // label8
          // 
          this.label8.AutoSize = true;
          this.label8.Location = new System.Drawing.Point(4, 226);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(58, 13);
          this.label8.TabIndex = 31;
          this.label8.Text = "MwSt %";
          // 
          // cobMwSt
          // 
          this.cobMwSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.cobMwSt.DataSource = this.steuerBindingSource;
          this.cobMwSt.DisplayMember = "Prozent";
          this.cobMwSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.cobMwSt.FormattingEnabled = true;
          this.cobMwSt.Location = new System.Drawing.Point(83, 222);
          this.cobMwSt.Name = "cobMwSt";
          this.cobMwSt.Size = new System.Drawing.Size(79, 21);
          this.cobMwSt.TabIndex = 10;
          this.cobMwSt.ValueMember = "Dezimal";
          this.cobMwSt.SelectedIndexChanged += new System.EventHandler(this.cobMwSt_SelectedIndexChanged);
          this.cobMwSt.TextChanged += new System.EventHandler(this.cobMwSt_TextChanged);
          // 
          // steuerBindingSource
          // 
          this.steuerBindingSource.DataMember = "Steuer";
          this.steuerBindingSource.DataSource = this.dsSteuer;
          // 
          // dsSteuer
          // 
          this.dsSteuer.DataSetName = "dsSteuer";
          this.dsSteuer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // tbxNachlass
          // 
          this.tbxNachlass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxNachlass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxNachlass.Enabled = false;
          this.tbxNachlass.Location = new System.Drawing.Point(83, 197);
          this.tbxNachlass.Name = "tbxNachlass";
          this.tbxNachlass.Size = new System.Drawing.Size(79, 21);
          this.tbxNachlass.TabIndex = 8;
          this.tbxNachlass.Text = "0";
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Location = new System.Drawing.Point(4, 200);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(65, 13);
          this.label5.TabIndex = 27;
          this.label5.Text = "Nachlass";
          // 
          // cobSkonto
          // 
          this.cobSkonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.cobSkonto.Enabled = false;
          this.cobSkonto.FormattingEnabled = true;
          this.cobSkonto.Items.AddRange(new object[] {
            "10 Tage 3%",
            "10 Tage 2%",
            "Zahlbar sofort rein netto",
            "Keine "});
          this.cobSkonto.Location = new System.Drawing.Point(83, 145);
          this.cobSkonto.Name = "cobSkonto";
          this.cobSkonto.Size = new System.Drawing.Size(630, 21);
          this.cobSkonto.TabIndex = 6;
          this.cobSkonto.SelectedIndexChanged += new System.EventHandler(this.cobSkonto_SelectedIndexChanged);
          this.cobSkonto.TextChanged += new System.EventHandler(this.cobSkonto_TextChanged);
          // 
          // label19
          // 
          this.label19.AutoSize = true;
          this.label19.Location = new System.Drawing.Point(4, 148);
          this.label19.Name = "label19";
          this.label19.Size = new System.Drawing.Size(23, 13);
          this.label19.TabIndex = 25;
          this.label19.Text = "ZB";
          // 
          // cobBetreff
          // 
          this.cobBetreff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.cobBetreff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.cobBetreff.DropDownWidth = 400;
          this.cobBetreff.Enabled = false;
          this.cobBetreff.FormattingEnabled = true;
          this.cobBetreff.Items.AddRange(new object[] {
            "Lieferung und Montage von WC-Trennwänden",
            "Lieferung und Montage von Duschtrennwänden",
            "Lieferung und Montage von WC- und Duschtrennwänden",
            "Lieferung und Montage von Trennwänden",
            "---",
            "Lieferung von WC-Trennwänden ab Werk ohne Montage",
            "Lieferung von Duschtrennwänden ab Werk ohne Montage",
            "Lieferung von Trennwänden ab Werk ohne Montage",
            "---",
            "Montagekosten",
            "Materiallieferung(en)"});
          this.cobBetreff.Location = new System.Drawing.Point(83, 171);
          this.cobBetreff.Name = "cobBetreff";
          this.cobBetreff.Size = new System.Drawing.Size(630, 21);
          this.cobBetreff.TabIndex = 7;
          this.cobBetreff.SelectedIndexChanged += new System.EventHandler(this.cobBetreff_SelectedIndexChanged);
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(4, 174);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(52, 13);
          this.label3.TabIndex = 25;
          this.label3.Text = "Betreff";
          // 
          // tbxBauvorhaben
          // 
          this.tbxBauvorhaben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxBauvorhaben.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxBauvorhaben.Enabled = false;
          this.tbxBauvorhaben.Location = new System.Drawing.Point(84, 91);
          this.tbxBauvorhaben.Name = "tbxBauvorhaben";
          this.tbxBauvorhaben.Size = new System.Drawing.Size(630, 21);
          this.tbxBauvorhaben.TabIndex = 4;
          this.tbxBauvorhaben.TextChanged += new System.EventHandler(this.tbxBauvorhaben_TextChanged);
          // 
          // tbxEigenerText
          // 
          this.tbxEigenerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxEigenerText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxEigenerText.Enabled = false;
          this.tbxEigenerText.Location = new System.Drawing.Point(84, 64);
          this.tbxEigenerText.Name = "tbxEigenerText";
          this.tbxEigenerText.Size = new System.Drawing.Size(630, 21);
          this.tbxEigenerText.TabIndex = 3;
          this.tbxEigenerText.TextChanged += new System.EventHandler(this.tbxEigenerText_TextChanged);
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Location = new System.Drawing.Point(4, 93);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(23, 13);
          this.label6.TabIndex = 21;
          this.label6.Text = "BV";
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(4, 41);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(31, 13);
          this.label4.TabIndex = 21;
          this.label4.Text = "Typ";
          // 
          // cobTyp
          // 
          this.cobTyp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.cobTyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.cobTyp.Enabled = false;
          this.cobTyp.FormattingEnabled = true;
          this.cobTyp.Items.AddRange(new object[] {
            "Normal",
            "Alternativ",
            "LV-abweichend",
            "Kurztext",
            "Eigener Text",
            "Neutral"});
          this.cobTyp.Location = new System.Drawing.Point(84, 38);
          this.cobTyp.Name = "cobTyp";
          this.cobTyp.Size = new System.Drawing.Size(630, 21);
          this.cobTyp.TabIndex = 2;
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(4, 9);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(62, 13);
          this.label1.TabIndex = 19;
          this.label1.Text = "Nummer";
          // 
          // dateRechnung
          // 
          this.dateRechnung.Enabled = false;
          this.dateRechnung.Format = System.Windows.Forms.DateTimePickerFormat.Short;
          this.dateRechnung.Location = new System.Drawing.Point(364, 4);
          this.dateRechnung.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
          this.dateRechnung.Name = "dateRechnung";
          this.dateRechnung.Size = new System.Drawing.Size(182, 21);
          this.dateRechnung.TabIndex = 1;
          this.dateRechnung.ValueChanged += new System.EventHandler(this.dateAuftrag_ValueChanged);
          // 
          // lblVorname
          // 
          this.lblVorname.AutoSize = true;
          this.lblVorname.Location = new System.Drawing.Point(284, 8);
          this.lblVorname.Name = "lblVorname";
          this.lblVorname.Size = new System.Drawing.Size(49, 13);
          this.lblVorname.TabIndex = 17;
          this.lblVorname.Text = "Datum";
          // 
          // tbxRechNummer
          // 
          this.tbxRechNummer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxRechNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxRechNummer.Location = new System.Drawing.Point(83, 6);
          this.tbxRechNummer.Name = "tbxRechNummer";
          this.tbxRechNummer.Size = new System.Drawing.Size(181, 21);
          this.tbxRechNummer.TabIndex = 0;
          this.tbxRechNummer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
          this.tbxRechNummer.TextChanged += new System.EventHandler(this.tbxRechNummer_TextChanged);
          // 
          // dgrPositionen
          // 
          this.dgrPositionen.AllowUserToAddRows = false;
          this.dgrPositionen.AllowUserToDeleteRows = false;
          this.dgrPositionen.AllowUserToResizeRows = false;
          dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
          dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
          dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
          this.dgrPositionen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
          this.dgrPositionen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
          this.dgrPositionen.BorderStyle = System.Windows.Forms.BorderStyle.None;
          this.dgrPositionen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgrPositionen.Cursor = System.Windows.Forms.Cursors.Arrow;
          dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
          dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
          dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
          dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
          dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
          dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
          this.dgrPositionen.DefaultCellStyle = dataGridViewCellStyle2;
          this.dgrPositionen.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dgrPositionen.Location = new System.Drawing.Point(0, 0);
          this.dgrPositionen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
          this.dgrPositionen.MultiSelect = false;
          this.dgrPositionen.Name = "dgrPositionen";
          this.dgrPositionen.ReadOnly = true;
          this.dgrPositionen.RowHeadersVisible = false;
          this.dgrPositionen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
          this.dgrPositionen.Size = new System.Drawing.Size(1156, 368);
          this.dgrPositionen.TabIndex = 4;
          this.dgrPositionen.DataSourceChanged += new System.EventHandler(this.dgrPositionen_DataSourceChanged);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label2.Location = new System.Drawing.Point(231, 12);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(79, 13);
          this.label2.TabIndex = 35;
          this.label2.Text = "Sondertext";
          // 
          // tbxSondertext
          // 
          this.tbxSondertext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.tbxSondertext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
          this.tbxSondertext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.tbxSondertext.Enabled = false;
          this.tbxSondertext.Location = new System.Drawing.Point(234, 38);
          this.tbxSondertext.Multiline = true;
          this.tbxSondertext.Name = "tbxSondertext";
          this.tbxSondertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
          this.tbxSondertext.Size = new System.Drawing.Size(611, 139);
          this.tbxSondertext.TabIndex = 13;
          this.tbxSondertext.TextChanged += new System.EventHandler(this.tbxSondertext_TextChanged);
          // 
          // panel3
          // 
          this.panel3.BackColor = System.Drawing.Color.Azure;
          this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
          this.panel3.Controls.Add(this.label9);
          this.panel3.Controls.Add(this.lblAufGesamt);
          this.panel3.Controls.Add(this.lblSteuer);
          this.panel3.Controls.Add(this.label25);
          this.panel3.Controls.Add(this.lblZwischensumme);
          this.panel3.Controls.Add(this.lblNachlass);
          this.panel3.Controls.Add(this.label26);
          this.panel3.Controls.Add(this.lblGesPos);
          this.panel3.Controls.Add(this.label11);
          this.panel3.Controls.Add(this.label7);
          this.panel3.Controls.Add(this.lblSum);
          this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
          this.panel3.Location = new System.Drawing.Point(849, 0);
          this.panel3.Name = "panel3";
          this.panel3.Size = new System.Drawing.Size(307, 187);
          this.panel3.TabIndex = 10;
          this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
          // 
          // label9
          // 
          this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label9.ForeColor = System.Drawing.Color.Red;
          this.label9.Location = new System.Drawing.Point(281, 158);
          this.label9.Name = "label9";
          this.label9.Size = new System.Drawing.Size(20, 18);
          this.label9.TabIndex = 12;
          this.label9.Text = "€";
          this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblAufGesamt
          // 
          this.lblAufGesamt.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblAufGesamt.ForeColor = System.Drawing.Color.Red;
          this.lblAufGesamt.Location = new System.Drawing.Point(187, 158);
          this.lblAufGesamt.Name = "lblAufGesamt";
          this.lblAufGesamt.Size = new System.Drawing.Size(98, 18);
          this.lblAufGesamt.TabIndex = 11;
          this.lblAufGesamt.Text = "0,00";
          this.lblAufGesamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblSteuer
          // 
          this.lblSteuer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblSteuer.Location = new System.Drawing.Point(157, 127);
          this.lblSteuer.Name = "lblSteuer";
          this.lblSteuer.Size = new System.Drawing.Size(144, 18);
          this.lblSteuer.TabIndex = 10;
          this.lblSteuer.Text = "0,00 €";
          this.lblSteuer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label25
          // 
          this.label25.AutoSize = true;
          this.label25.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label25.Location = new System.Drawing.Point(3, 127);
          this.label25.Name = "label25";
          this.label25.Size = new System.Drawing.Size(154, 18);
          this.label25.TabIndex = 9;
          this.label25.Text = "+ Mehrwertsteuer";
          this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // lblZwischensumme
          // 
          this.lblZwischensumme.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblZwischensumme.Location = new System.Drawing.Point(157, 99);
          this.lblZwischensumme.Name = "lblZwischensumme";
          this.lblZwischensumme.Size = new System.Drawing.Size(144, 18);
          this.lblZwischensumme.TabIndex = 8;
          this.lblZwischensumme.Text = "0,00 €";
          this.lblZwischensumme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // lblNachlass
          // 
          this.lblNachlass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblNachlass.Location = new System.Drawing.Point(158, 66);
          this.lblNachlass.Name = "lblNachlass";
          this.lblNachlass.Size = new System.Drawing.Size(144, 18);
          this.lblNachlass.TabIndex = 7;
          this.lblNachlass.Text = "0,00 €";
          this.lblNachlass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label26
          // 
          this.label26.AutoSize = true;
          this.label26.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label26.Location = new System.Drawing.Point(0, 66);
          this.label26.Name = "label26";
          this.label26.Size = new System.Drawing.Size(160, 18);
          this.label26.TabIndex = 6;
          this.label26.Text = "./. Sondernachlass";
          this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // lblGesPos
          // 
          this.lblGesPos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblGesPos.Location = new System.Drawing.Point(158, 36);
          this.lblGesPos.Name = "lblGesPos";
          this.lblGesPos.Size = new System.Drawing.Size(144, 18);
          this.lblGesPos.TabIndex = 3;
          this.lblGesPos.Text = "0,00 €";
          this.lblGesPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
          // 
          // label11
          // 
          this.label11.AutoSize = true;
          this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label11.Location = new System.Drawing.Point(0, 36);
          this.label11.Name = "label11";
          this.label11.Size = new System.Drawing.Size(118, 18);
          this.label11.TabIndex = 2;
          this.label11.Text = "    Positionen";
          this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // label7
          // 
          this.label7.Dock = System.Windows.Forms.DockStyle.Top;
          this.label7.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label7.Location = new System.Drawing.Point(0, 10);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(303, 18);
          this.label7.TabIndex = 1;
          this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // lblSum
          // 
          this.lblSum.Dock = System.Windows.Forms.DockStyle.Top;
          this.lblSum.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lblSum.Location = new System.Drawing.Point(0, 0);
          this.lblSum.Name = "lblSum";
          this.lblSum.Size = new System.Drawing.Size(303, 10);
          this.lblSum.TabIndex = 0;
          this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // btnEdit
          // 
          this.btnEdit.Enabled = false;
          this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btnEdit.Image = global::Norka.Properties.Resources.filesave_32;
          this.btnEdit.Location = new System.Drawing.Point(11, 93);
          this.btnEdit.Name = "btnEdit";
          this.btnEdit.Size = new System.Drawing.Size(198, 53);
          this.btnEdit.TabIndex = 17;
          this.btnEdit.Text = "Änderung speichern";
          this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
          this.btnEdit.UseVisualStyleBackColor = true;
          this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
          // 
          // btnAnlegen
          // 
          this.btnAnlegen.Enabled = false;
          this.btnAnlegen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btnAnlegen.Image = global::Norka.Properties.Resources.apply_32;
          this.btnAnlegen.Location = new System.Drawing.Point(11, 17);
          this.btnAnlegen.Name = "btnAnlegen";
          this.btnAnlegen.Size = new System.Drawing.Size(198, 53);
          this.btnAnlegen.TabIndex = 16;
          this.btnAnlegen.Text = "Anlegen";
          this.btnAnlegen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
          this.btnAnlegen.UseVisualStyleBackColor = true;
          // 
          // ctmAngebot
          // 
          this.ctmAngebot.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ctmAngebot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemBearbeiten,
            this.toolStripSeparator4,
            this.itemLoeschen,
            this.toolStripSeparator8,
            this.rechnungÖffeToolStripMenuItem});
          this.ctmAngebot.Name = "ctmAngebot";
          this.ctmAngebot.Size = new System.Drawing.Size(170, 82);
          // 
          // itemBearbeiten
          // 
          this.itemBearbeiten.Image = global::Norka.Properties.Resources.edit_user_32;
          this.itemBearbeiten.Name = "itemBearbeiten";
          this.itemBearbeiten.Size = new System.Drawing.Size(169, 22);
          this.itemBearbeiten.Text = "Bearbeiten";
          this.itemBearbeiten.Click += new System.EventHandler(this.itemBearbeiten_Click);
          // 
          // toolStripSeparator4
          // 
          this.toolStripSeparator4.Name = "toolStripSeparator4";
          this.toolStripSeparator4.Size = new System.Drawing.Size(166, 6);
          // 
          // itemLoeschen
          // 
          this.itemLoeschen.Image = global::Norka.Properties.Resources.delete_32;
          this.itemLoeschen.Name = "itemLoeschen";
          this.itemLoeschen.Size = new System.Drawing.Size(169, 22);
          this.itemLoeschen.Text = "Löschen";
          this.itemLoeschen.Click += new System.EventHandler(this.itemLoeschen_Click);
          // 
          // toolStripSeparator8
          // 
          this.toolStripSeparator8.Name = "toolStripSeparator8";
          this.toolStripSeparator8.Size = new System.Drawing.Size(166, 6);
          // 
          // rechnungÖffeToolStripMenuItem
          // 
          this.rechnungÖffeToolStripMenuItem.Enabled = false;
          this.rechnungÖffeToolStripMenuItem.Image = global::Norka.Properties.Resources.money_32;
          this.rechnungÖffeToolStripMenuItem.Name = "rechnungÖffeToolStripMenuItem";
          this.rechnungÖffeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
          this.rechnungÖffeToolStripMenuItem.Text = "Auftrag öffnen";
          // 
          // itemKalkulationSchließen
          // 
          this.itemKalkulationSchließen.Name = "itemKalkulationSchließen";
          this.itemKalkulationSchließen.Size = new System.Drawing.Size(23, 23);
          // 
          // tableLayoutPanel1
          // 
          this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
          this.tableLayoutPanel1.ColumnCount = 2;
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.31343F));
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.68657F));
          this.tableLayoutPanel1.Controls.Add(this.label17, 1, 4);
          this.tableLayoutPanel1.Controls.Add(this.label15, 1, 3);
          this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
          this.tableLayoutPanel1.Name = "tableLayoutPanel1";
          this.tableLayoutPanel1.RowCount = 5;
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
          this.tableLayoutPanel1.TabIndex = 0;
          // 
          // label17
          // 
          this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
          this.label17.AutoSize = true;
          this.label17.Location = new System.Drawing.Point(127, 88);
          this.label17.Name = "label17";
          this.label17.Size = new System.Drawing.Size(69, 13);
          this.label17.TabIndex = 9;
          // 
          // label15
          // 
          this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
          this.label15.AutoSize = true;
          this.label15.Location = new System.Drawing.Point(127, 67);
          this.label15.Name = "label15";
          this.label15.Size = new System.Drawing.Size(69, 13);
          this.label15.TabIndex = 7;
          // 
          // label14
          // 
          this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
          this.label14.AutoSize = true;
          this.label14.Location = new System.Drawing.Point(4, 67);
          this.label14.Name = "label14";
          this.label14.Size = new System.Drawing.Size(712, 14);
          this.label14.TabIndex = 6;
          this.label14.Text = "+ MwSt";
          // 
          // itemPositionNeu
          // 
          this.itemPositionNeu.AutoSize = false;
          this.itemPositionNeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemPositionNeu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.itemPositionNeu.Image = global::Norka.Properties.Resources.add_32;
          this.itemPositionNeu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemPositionNeu.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemPositionNeu.Name = "itemPositionNeu";
          this.itemPositionNeu.Size = new System.Drawing.Size(50, 35);
          this.itemPositionNeu.Text = "Position";
          this.itemPositionNeu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
          // 
          // itemPositionLoe
          // 
          this.itemPositionLoe.AutoSize = false;
          this.itemPositionLoe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.itemPositionLoe.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.itemPositionLoe.Image = global::Norka.Properties.Resources.delete_32;
          this.itemPositionLoe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.itemPositionLoe.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.itemPositionLoe.Name = "itemPositionLoe";
          this.itemPositionLoe.Size = new System.Drawing.Size(50, 35);
          this.itemPositionLoe.Text = "Position";
          this.itemPositionLoe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
          // 
          // toolStripButton2
          // 
          this.toolStripButton2.AutoSize = false;
          this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.toolStripButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
          this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.toolStripButton2.Name = "toolStripButton2";
          this.toolStripButton2.Size = new System.Drawing.Size(50, 35);
          this.toolStripButton2.Text = "Drucken";
          this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
          // 
          // steuerTableAdapter
          // 
          this.steuerTableAdapter.ClearBeforeFill = true;
          // 
          // Form_Rechnung
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.AutoScroll = true;
          this.BackColor = System.Drawing.SystemColors.MenuBar;
          this.ClientSize = new System.Drawing.Size(1156, 883);
          this.ControlBox = false;
          this.Controls.Add(this.splitContainer1);
          this.Controls.Add(this.itemMarkAll);
          this.Font = new System.Drawing.Font("Verdana", 9F);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
          this.MaximizeBox = false;
          this.Name = "Form_Rechnung";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "Rechnung";
          this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
          this.Load += new System.EventHandler(this.Rechnung_Load);
          this.itemMarkAll.ResumeLayout(false);
          this.itemMarkAll.PerformLayout();
          this.splitContainer1.Panel1.ResumeLayout(false);
          this.splitContainer1.Panel2.ResumeLayout(false);
          this.splitContainer1.Panel2.PerformLayout();
          this.splitContainer1.ResumeLayout(false);
          this.splitContainer2.Panel1.ResumeLayout(false);
          this.splitContainer2.Panel2.ResumeLayout(false);
          this.splitContainer2.ResumeLayout(false);
          this.grpKunde.ResumeLayout(false);
          this.panel2.ResumeLayout(false);
          this.panel2.PerformLayout();
          this.groupBox3.ResumeLayout(false);
          this.panel1.ResumeLayout(false);
          this.panel1.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.steuerBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsSteuer)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dgrPositionen)).EndInit();
          this.panel3.ResumeLayout(false);
          this.panel3.PerformLayout();
          this.ctmAngebot.ResumeLayout(false);
          this.tableLayoutPanel1.ResumeLayout(false);
          this.tableLayoutPanel1.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip itemMarkAll;
        private System.Windows.Forms.ToolStripButton itemPositionNeu;
        private System.Windows.Forms.ToolStripButton itemKalkulationSchließen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVorname;
        public System.Windows.Forms.TextBox tbxRechNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobTyp;
        private System.Windows.Forms.TextBox tbxEigenerText;
        private System.Windows.Forms.ComboBox cobBetreff;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbxNachlass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton itemPositionLoe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbxAufmaß;
        private System.Windows.Forms.Button btnAnlegen;
        private System.Windows.Forms.GroupBox grpKunde;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxKdHaenden;
        private System.Windows.Forms.TextBox tbxKdName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxKdAnrede;
        private System.Windows.Forms.ToolStripButton itemAufNeu;
        private System.Windows.Forms.ToolStripButton itemPosDelete;
        private System.Windows.Forms.ToolStripButton itemClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripButton itemMail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox cobSkonto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbxAnfahrt;
        private System.Windows.Forms.TextBox tbxBauvorhaben;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton itemPosEdit;
        private System.Windows.Forms.ToolStripDropDownButton itemPrint;
        public System.Windows.Forms.ComboBox cobMwSt;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.TextBox tbxKdNummer;
        private System.Windows.Forms.ContextMenuStrip ctmAngebot;
        private System.Windows.Forms.ToolStripMenuItem itemBearbeiten;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itemLoeschen;
        public System.Windows.Forms.DateTimePicker dateRechnung;
        private System.Windows.Forms.ToolStripButton itemPosNeu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.ComboBox cobNachlass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        public System.Windows.Forms.Label lblGesPos;
        public System.Windows.Forms.Label lblNachlass;
        public System.Windows.Forms.Label lblSteuer;
        public System.Windows.Forms.Label lblAufGesamt;
        public System.Windows.Forms.Label lblZwischensumme;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TextBox tbxBV2;
        private System.Windows.Forms.TextBox tbxSondertext;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem rechnungÖffeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton itemStornieren;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        public System.Windows.Forms.DataGridView dgrPositionen;
        private System.Windows.Forms.ToolStripMenuItem rechnungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vorschauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sofortdruckToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem mahnungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MahnungFreundlicheItem;
        private System.Windows.Forms.ToolStripMenuItem MahnungErsteItem;
        private System.Windows.Forms.ToolStripMenuItem MahnungErneuteItem;
        private System.Windows.Forms.ToolStripMenuItem MahnungLetzteItem;
        private Norka.Extras.dsSteuer dsSteuer;
        private System.Windows.Forms.BindingSource steuerBindingSource;
        private Norka.Extras.dsSteuerTableAdapters.SteuerTableAdapter steuerTableAdapter;
        private System.Windows.Forms.ToolStripButton itemEinbehaltSetzen;
        private System.Windows.Forms.ToolStripButton itemEinbehaltLoeschen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    }
}