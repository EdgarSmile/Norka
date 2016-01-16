namespace Norka.Kunden
{
    partial class Form_Kunde_Uebersicht
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kunde_Uebersicht));
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
          this.tsKunde = new System.Windows.Forms.ToolStrip();
          this.tsItemKundeNeu = new System.Windows.Forms.ToolStripButton();
          this.tsItemKundeBearbeiten = new System.Windows.Forms.ToolStripButton();
          this.tsItemKundeLoeschen = new System.Windows.Forms.ToolStripButton();
          this.tsItemKundeUebersichtSchließen = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
          this.tsItemKundeAuswahl = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
          this.tsItemAngebotErstellen = new System.Windows.Forms.ToolStripButton();
          this.tsItemAuftragErstellen = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
          this.tsItemDrucken = new System.Windows.Forms.ToolStripDropDownButton();
          this.tsItemDruckenDatenblatt = new System.Windows.Forms.ToolStripMenuItem();
          this.tsItemDruckenDatenblattVorschau1 = new System.Windows.Forms.ToolStripMenuItem();
          this.tsItemDruckenDatenblattSofortdruck = new System.Windows.Forms.ToolStripMenuItem();
          this.tsItemDruckenAbsageProgramm = new System.Windows.Forms.ToolStripMenuItem();
          this.tsItemDruckenAbsageWirkungskreis = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
          this.tsItemAkualisieren = new System.Windows.Forms.ToolStripButton();
          this.tsItemAllMark = new System.Windows.Forms.ToolStripButton();
          this.tsItemKeineMark = new System.Windows.Forms.ToolStripButton();
          this.ctmKundenGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
          this.ctmAngebotErstellen = new System.Windows.Forms.ToolStripMenuItem();
          this.ctmAuftragErstellen = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.ctmKundeBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
          this.ctmKundeLoeschen = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
          this.ctmDrucken = new System.Windows.Forms.ToolStripMenuItem();
          this.ctmDruckenDatenblatt = new System.Windows.Forms.ToolStripMenuItem();
          this.ctmDruckenDatenblattVorschau = new System.Windows.Forms.ToolStripMenuItem();
          this.ctmDruckenDatenblattSofortdruck = new System.Windows.Forms.ToolStripMenuItem();
          this.absageNichtImProgrammToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
          this.absageAußerhalbWirkungskreisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.dgrKunden = new System.Windows.Forms.DataGridView();
          this.sstpKunde = new System.Windows.Forms.StatusStrip();
          this.slKunde = new System.Windows.Forms.ToolStripStatusLabel();
          this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
          this.ctmBrief = new System.Windows.Forms.ToolStripMenuItem();
          this.tsItemBrief = new System.Windows.Forms.ToolStripMenuItem();
          this.tsKunde.SuspendLayout();
          this.ctmKundenGrid.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dgrKunden)).BeginInit();
          this.sstpKunde.SuspendLayout();
          this.SuspendLayout();
          // 
          // tsKunde
          // 
          this.tsKunde.AllowDrop = true;
          this.tsKunde.AutoSize = false;
          this.tsKunde.BackColor = System.Drawing.SystemColors.MenuBar;
          this.tsKunde.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
          this.tsKunde.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsItemKundeNeu,
            this.tsItemKundeBearbeiten,
            this.tsItemKundeLoeschen,
            this.tsItemKundeUebersichtSchließen,
            this.toolStripSeparator2,
            this.tsItemKundeAuswahl,
            this.toolStripSeparator5,
            this.tsItemAngebotErstellen,
            this.tsItemAuftragErstellen,
            this.toolStripSeparator3,
            this.tsItemDrucken,
            this.toolStripSeparator6,
            this.tsItemAkualisieren,
            this.tsItemAllMark,
            this.tsItemKeineMark});
          this.tsKunde.Location = new System.Drawing.Point(0, 0);
          this.tsKunde.Name = "tsKunde";
          this.tsKunde.Size = new System.Drawing.Size(1156, 38);
          this.tsKunde.TabIndex = 0;
          this.tsKunde.Text = "toolStrip1";
          // 
          // tsItemKundeNeu
          // 
          this.tsItemKundeNeu.AutoSize = false;
          this.tsItemKundeNeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemKundeNeu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemKundeNeu.Image = global::Norka.Properties.Resources.add_user_32;
          this.tsItemKundeNeu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemKundeNeu.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemKundeNeu.Name = "tsItemKundeNeu";
          this.tsItemKundeNeu.Size = new System.Drawing.Size(50, 35);
          this.tsItemKundeNeu.Text = "Neuen Kunden hinzufügen";
          this.tsItemKundeNeu.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
          this.tsItemKundeNeu.Click += new System.EventHandler(this.tsItemKundeNeu_Click);
          // 
          // tsItemKundeBearbeiten
          // 
          this.tsItemKundeBearbeiten.AutoSize = false;
          this.tsItemKundeBearbeiten.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemKundeBearbeiten.Enabled = false;
          this.tsItemKundeBearbeiten.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemKundeBearbeiten.Image = global::Norka.Properties.Resources.edit_user_32;
          this.tsItemKundeBearbeiten.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemKundeBearbeiten.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemKundeBearbeiten.Name = "tsItemKundeBearbeiten";
          this.tsItemKundeBearbeiten.Size = new System.Drawing.Size(50, 35);
          this.tsItemKundeBearbeiten.Text = "Markierten Kunden bearbeiten";
          this.tsItemKundeBearbeiten.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
          this.tsItemKundeBearbeiten.Click += new System.EventHandler(this.tsItemKundeBearbeiten_Click);
          // 
          // tsItemKundeLoeschen
          // 
          this.tsItemKundeLoeschen.AutoSize = false;
          this.tsItemKundeLoeschen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemKundeLoeschen.Enabled = false;
          this.tsItemKundeLoeschen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemKundeLoeschen.Image = global::Norka.Properties.Resources.remove_user_32;
          this.tsItemKundeLoeschen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemKundeLoeschen.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemKundeLoeschen.Name = "tsItemKundeLoeschen";
          this.tsItemKundeLoeschen.Size = new System.Drawing.Size(50, 35);
          this.tsItemKundeLoeschen.Text = "Markierten Kunden löschen";
          this.tsItemKundeLoeschen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
          this.tsItemKundeLoeschen.Click += new System.EventHandler(this.tsItemKundeLoeschen_Click);
          // 
          // tsItemKundeUebersichtSchließen
          // 
          this.tsItemKundeUebersichtSchließen.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
          this.tsItemKundeUebersichtSchließen.AutoSize = false;
          this.tsItemKundeUebersichtSchließen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemKundeUebersichtSchließen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemKundeUebersichtSchließen.Image = global::Norka.Properties.Resources.Close_32;
          this.tsItemKundeUebersichtSchließen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemKundeUebersichtSchließen.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemKundeUebersichtSchließen.Name = "tsItemKundeUebersichtSchließen";
          this.tsItemKundeUebersichtSchließen.Size = new System.Drawing.Size(36, 36);
          this.tsItemKundeUebersichtSchließen.Text = "Schließen";
          this.tsItemKundeUebersichtSchließen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
          this.tsItemKundeUebersichtSchließen.Click += new System.EventHandler(this.itemKundeSch_Click);
          // 
          // toolStripSeparator2
          // 
          this.toolStripSeparator2.Name = "toolStripSeparator2";
          this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
          // 
          // tsItemKundeAuswahl
          // 
          this.tsItemKundeAuswahl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemKundeAuswahl.Image = global::Norka.Properties.Resources.Search;
          this.tsItemKundeAuswahl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemKundeAuswahl.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemKundeAuswahl.Name = "tsItemKundeAuswahl";
          this.tsItemKundeAuswahl.Size = new System.Drawing.Size(36, 35);
          this.tsItemKundeAuswahl.Text = "toolStripButton1";
          this.tsItemKundeAuswahl.ToolTipText = "Kunden auswählen / suchen";
          this.tsItemKundeAuswahl.Click += new System.EventHandler(this.tsItemKundeAuswahl_Click);
          // 
          // toolStripSeparator5
          // 
          this.toolStripSeparator5.Name = "toolStripSeparator5";
          this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
          // 
          // tsItemAngebotErstellen
          // 
          this.tsItemAngebotErstellen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemAngebotErstellen.Enabled = false;
          this.tsItemAngebotErstellen.Image = global::Norka.Properties.Resources.Text_edit_32;
          this.tsItemAngebotErstellen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemAngebotErstellen.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemAngebotErstellen.Name = "tsItemAngebotErstellen";
          this.tsItemAngebotErstellen.Size = new System.Drawing.Size(36, 35);
          this.tsItemAngebotErstellen.Text = "toolStripButton1";
          this.tsItemAngebotErstellen.ToolTipText = "Angebot erstellen";
          this.tsItemAngebotErstellen.Click += new System.EventHandler(this.tsItemAngebotErstellen_Click);
          // 
          // tsItemAuftragErstellen
          // 
          this.tsItemAuftragErstellen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemAuftragErstellen.Enabled = false;
          this.tsItemAuftragErstellen.Image = global::Norka.Properties.Resources.Text_32;
          this.tsItemAuftragErstellen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemAuftragErstellen.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemAuftragErstellen.Name = "tsItemAuftragErstellen";
          this.tsItemAuftragErstellen.Size = new System.Drawing.Size(36, 35);
          this.tsItemAuftragErstellen.Text = "toolStripButton2";
          this.tsItemAuftragErstellen.ToolTipText = "Auftrag erstellen";
          this.tsItemAuftragErstellen.Click += new System.EventHandler(this.tsItemAuftragErstellen_Click);
          // 
          // toolStripSeparator3
          // 
          this.toolStripSeparator3.Name = "toolStripSeparator3";
          this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
          // 
          // tsItemDrucken
          // 
          this.tsItemDrucken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemDrucken.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsItemDruckenDatenblatt,
            this.tsItemDruckenAbsageProgramm,
            this.tsItemDruckenAbsageWirkungskreis,
            this.tsItemBrief});
          this.tsItemDrucken.Enabled = false;
          this.tsItemDrucken.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemDrucken.Image = global::Norka.Properties.Resources.print_32;
          this.tsItemDrucken.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemDrucken.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemDrucken.Name = "tsItemDrucken";
          this.tsItemDrucken.Size = new System.Drawing.Size(45, 35);
          this.tsItemDrucken.Text = "Drucken";
          // 
          // tsItemDruckenDatenblatt
          // 
          this.tsItemDruckenDatenblatt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsItemDruckenDatenblattVorschau1,
            this.tsItemDruckenDatenblattSofortdruck});
          this.tsItemDruckenDatenblatt.Name = "tsItemDruckenDatenblatt";
          this.tsItemDruckenDatenblatt.Size = new System.Drawing.Size(303, 22);
          this.tsItemDruckenDatenblatt.Text = "Datenblatt";
          // 
          // tsItemDruckenDatenblattVorschau1
          // 
          this.tsItemDruckenDatenblattVorschau1.Name = "tsItemDruckenDatenblattVorschau1";
          this.tsItemDruckenDatenblattVorschau1.Size = new System.Drawing.Size(162, 22);
          this.tsItemDruckenDatenblattVorschau1.Text = "Vorschau";
          this.tsItemDruckenDatenblattVorschau1.Click += new System.EventHandler(this.tsItemDruckenDatenblattVorschau_Click);
          // 
          // tsItemDruckenDatenblattSofortdruck
          // 
          this.tsItemDruckenDatenblattSofortdruck.Name = "tsItemDruckenDatenblattSofortdruck";
          this.tsItemDruckenDatenblattSofortdruck.Size = new System.Drawing.Size(162, 22);
          this.tsItemDruckenDatenblattSofortdruck.Text = "Sofortdruck";
          this.tsItemDruckenDatenblattSofortdruck.Click += new System.EventHandler(this.tsItemDruckenDatenblattSofortdruck_Click);
          // 
          // tsItemDruckenAbsageProgramm
          // 
          this.tsItemDruckenAbsageProgramm.Name = "tsItemDruckenAbsageProgramm";
          this.tsItemDruckenAbsageProgramm.Size = new System.Drawing.Size(303, 22);
          this.tsItemDruckenAbsageProgramm.Text = "Absage - nicht im Programm";
          this.tsItemDruckenAbsageProgramm.Click += new System.EventHandler(this.tsItemDruckenAbsageProgramm_Click);
          // 
          // tsItemDruckenAbsageWirkungskreis
          // 
          this.tsItemDruckenAbsageWirkungskreis.Name = "tsItemDruckenAbsageWirkungskreis";
          this.tsItemDruckenAbsageWirkungskreis.Size = new System.Drawing.Size(303, 22);
          this.tsItemDruckenAbsageWirkungskreis.Text = "Absage - außerhalb Wirkunskreis";
          this.tsItemDruckenAbsageWirkungskreis.Click += new System.EventHandler(this.tsItemDruckenAbsageWirkungskreis_Click);
          // 
          // toolStripSeparator6
          // 
          this.toolStripSeparator6.Name = "toolStripSeparator6";
          this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
          // 
          // tsItemAkualisieren
          // 
          this.tsItemAkualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemAkualisieren.Enabled = false;
          this.tsItemAkualisieren.Image = global::Norka.Properties.Resources.refresh_32;
          this.tsItemAkualisieren.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemAkualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemAkualisieren.Name = "tsItemAkualisieren";
          this.tsItemAkualisieren.Size = new System.Drawing.Size(36, 35);
          this.tsItemAkualisieren.Text = "Aktuelle Auswahl aktualisieren";
          this.tsItemAkualisieren.Click += new System.EventHandler(this.tsItemAkualisieren_Click);
          // 
          // tsItemAllMark
          // 
          this.tsItemAllMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          this.tsItemAllMark.Enabled = false;
          this.tsItemAllMark.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemAllMark.Image = ((System.Drawing.Image)(resources.GetObject("tsItemAllMark.Image")));
          this.tsItemAllMark.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemAllMark.Name = "tsItemAllMark";
          this.tsItemAllMark.Size = new System.Drawing.Size(113, 35);
          this.tsItemAllMark.Text = "Alles Markieren";
          this.tsItemAllMark.Click += new System.EventHandler(this.itemAllMark_Click);
          // 
          // tsItemKeineMark
          // 
          this.tsItemKeineMark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          this.tsItemKeineMark.Enabled = false;
          this.tsItemKeineMark.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemKeineMark.Image = ((System.Drawing.Image)(resources.GetObject("tsItemKeineMark.Image")));
          this.tsItemKeineMark.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemKeineMark.Name = "tsItemKeineMark";
          this.tsItemKeineMark.Size = new System.Drawing.Size(117, 35);
          this.tsItemKeineMark.Text = "Keine Markieren";
          this.tsItemKeineMark.Click += new System.EventHandler(this.itemKeineMark_Click);
          // 
          // ctmKundenGrid
          // 
          this.ctmKundenGrid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.ctmKundenGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmAngebotErstellen,
            this.ctmAuftragErstellen,
            this.toolStripSeparator1,
            this.ctmKundeBearbeiten,
            this.ctmKundeLoeschen,
            this.toolStripSeparator4,
            this.ctmDrucken});
          this.ctmKundenGrid.Name = "ctmKundenGrid";
          this.ctmKundenGrid.Size = new System.Drawing.Size(202, 148);
          this.ctmKundenGrid.Opening += new System.ComponentModel.CancelEventHandler(this.ctmKundenGrid_Opening);
          // 
          // ctmAngebotErstellen
          // 
          this.ctmAngebotErstellen.Image = global::Norka.Properties.Resources.Text_edit_32;
          this.ctmAngebotErstellen.Name = "ctmAngebotErstellen";
          this.ctmAngebotErstellen.Size = new System.Drawing.Size(201, 22);
          this.ctmAngebotErstellen.Text = "Angebot erstellen";
          this.ctmAngebotErstellen.Click += new System.EventHandler(this.ctmAngebotErstellen_Click);
          // 
          // ctmAuftragErstellen
          // 
          this.ctmAuftragErstellen.Image = global::Norka.Properties.Resources.Text_32;
          this.ctmAuftragErstellen.Name = "ctmAuftragErstellen";
          this.ctmAuftragErstellen.Size = new System.Drawing.Size(201, 22);
          this.ctmAuftragErstellen.Text = "Auftrag erstellen";
          this.ctmAuftragErstellen.Click += new System.EventHandler(this.ctmAuftragErstellen_Click);
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
          // 
          // ctmKundeBearbeiten
          // 
          this.ctmKundeBearbeiten.Image = global::Norka.Properties.Resources.edit_user_32;
          this.ctmKundeBearbeiten.Name = "ctmKundeBearbeiten";
          this.ctmKundeBearbeiten.Size = new System.Drawing.Size(201, 22);
          this.ctmKundeBearbeiten.Text = "Bearbeiten";
          this.ctmKundeBearbeiten.Click += new System.EventHandler(this.ctmKundeBearbeiten_Click);
          // 
          // ctmKundeLoeschen
          // 
          this.ctmKundeLoeschen.Image = global::Norka.Properties.Resources.remove_user_32;
          this.ctmKundeLoeschen.Name = "ctmKundeLoeschen";
          this.ctmKundeLoeschen.Size = new System.Drawing.Size(201, 22);
          this.ctmKundeLoeschen.Text = "Löschen";
          this.ctmKundeLoeschen.Click += new System.EventHandler(this.ctmKundeLoeschen_Click);
          // 
          // toolStripSeparator4
          // 
          this.toolStripSeparator4.Name = "toolStripSeparator4";
          this.toolStripSeparator4.Size = new System.Drawing.Size(198, 6);
          // 
          // ctmDrucken
          // 
          this.ctmDrucken.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmDruckenDatenblatt,
            this.absageNichtImProgrammToolStripMenuItem1,
            this.absageAußerhalbWirkungskreisToolStripMenuItem,
            this.ctmBrief});
          this.ctmDrucken.Image = global::Norka.Properties.Resources.print_32;
          this.ctmDrucken.Name = "ctmDrucken";
          this.ctmDrucken.Size = new System.Drawing.Size(201, 22);
          this.ctmDrucken.Text = "Drucken";
          // 
          // ctmDruckenDatenblatt
          // 
          this.ctmDruckenDatenblatt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmDruckenDatenblattVorschau,
            this.ctmDruckenDatenblattSofortdruck});
          this.ctmDruckenDatenblatt.Name = "ctmDruckenDatenblatt";
          this.ctmDruckenDatenblatt.Size = new System.Drawing.Size(311, 22);
          this.ctmDruckenDatenblatt.Text = "Datenblatt";
          // 
          // ctmDruckenDatenblattVorschau
          // 
          this.ctmDruckenDatenblattVorschau.Name = "ctmDruckenDatenblattVorschau";
          this.ctmDruckenDatenblattVorschau.Size = new System.Drawing.Size(162, 22);
          this.ctmDruckenDatenblattVorschau.Text = "Vorschau";
          this.ctmDruckenDatenblattVorschau.Click += new System.EventHandler(this.tsItemDruckenDatenblattVorschau_Click);
          // 
          // ctmDruckenDatenblattSofortdruck
          // 
          this.ctmDruckenDatenblattSofortdruck.Name = "ctmDruckenDatenblattSofortdruck";
          this.ctmDruckenDatenblattSofortdruck.Size = new System.Drawing.Size(162, 22);
          this.ctmDruckenDatenblattSofortdruck.Text = "Sofortdruck";
          this.ctmDruckenDatenblattSofortdruck.Click += new System.EventHandler(this.tsItemDruckenDatenblattSofortdruck_Click);
          // 
          // absageNichtImProgrammToolStripMenuItem1
          // 
          this.absageNichtImProgrammToolStripMenuItem1.Name = "absageNichtImProgrammToolStripMenuItem1";
          this.absageNichtImProgrammToolStripMenuItem1.Size = new System.Drawing.Size(311, 22);
          this.absageNichtImProgrammToolStripMenuItem1.Text = "Absage - nicht im Programm";
          this.absageNichtImProgrammToolStripMenuItem1.Click += new System.EventHandler(this.tsItemDruckenAbsageProgramm_Click);
          // 
          // absageAußerhalbWirkungskreisToolStripMenuItem
          // 
          this.absageAußerhalbWirkungskreisToolStripMenuItem.Name = "absageAußerhalbWirkungskreisToolStripMenuItem";
          this.absageAußerhalbWirkungskreisToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
          this.absageAußerhalbWirkungskreisToolStripMenuItem.Text = "Absage - außerhalb Wirkungskreis";
          this.absageAußerhalbWirkungskreisToolStripMenuItem.Click += new System.EventHandler(this.tsItemDruckenAbsageWirkungskreis_Click);
          // 
          // dgrKunden
          // 
          this.dgrKunden.AllowUserToAddRows = false;
          this.dgrKunden.AllowUserToDeleteRows = false;
          this.dgrKunden.AllowUserToResizeRows = false;
          dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
          dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
          dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
          this.dgrKunden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
          this.dgrKunden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
          this.dgrKunden.BorderStyle = System.Windows.Forms.BorderStyle.None;
          dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
          dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
          dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
          dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
          dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
          dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
          this.dgrKunden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
          this.dgrKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgrKunden.ContextMenuStrip = this.ctmKundenGrid;
          this.dgrKunden.Cursor = System.Windows.Forms.Cursors.Arrow;
          dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
          dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
          dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
          dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
          dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
          dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
          this.dgrKunden.DefaultCellStyle = dataGridViewCellStyle3;
          this.dgrKunden.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dgrKunden.Location = new System.Drawing.Point(0, 38);
          this.dgrKunden.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
          this.dgrKunden.MultiSelect = false;
          this.dgrKunden.Name = "dgrKunden";
          this.dgrKunden.ReadOnly = true;
          this.dgrKunden.RowHeadersVisible = false;
          this.dgrKunden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
          this.dgrKunden.Size = new System.Drawing.Size(1156, 722);
          this.dgrKunden.TabIndex = 4;
          this.dgrKunden.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgrKunden_MouseDown);
          this.dgrKunden.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrKunden_CellDoubleClick);
          this.dgrKunden.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgrKunden_RowsAdded);
          this.dgrKunden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrKunden_CellClick);
          this.dgrKunden.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgrKunden_RowsRemoved);
          // 
          // sstpKunde
          // 
          this.sstpKunde.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slKunde,
            this.toolStripStatusLabel1});
          this.sstpKunde.Location = new System.Drawing.Point(0, 760);
          this.sstpKunde.Name = "sstpKunde";
          this.sstpKunde.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
          this.sstpKunde.Size = new System.Drawing.Size(1156, 22);
          this.sstpKunde.SizingGrip = false;
          this.sstpKunde.TabIndex = 2;
          this.sstpKunde.Text = "statusStrip1";
          // 
          // slKunde
          // 
          this.slKunde.Name = "slKunde";
          this.slKunde.Size = new System.Drawing.Size(0, 17);
          // 
          // toolStripStatusLabel1
          // 
          this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
          this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
          // 
          // ctmBrief
          // 
          this.ctmBrief.Name = "ctmBrief";
          this.ctmBrief.Size = new System.Drawing.Size(311, 22);
          this.ctmBrief.Text = "Brief";
          this.ctmBrief.Click += new System.EventHandler(this.tsItemBrief_Click);
          // 
          // tsItemBrief
          // 
          this.tsItemBrief.Name = "tsItemBrief";
          this.tsItemBrief.Size = new System.Drawing.Size(303, 22);
          this.tsItemBrief.Text = "Brief";
          this.tsItemBrief.Click += new System.EventHandler(this.tsItemBrief_Click);
          // 
          // Form_Kunde_Uebersicht
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.AutoScroll = true;
          this.ClientSize = new System.Drawing.Size(1156, 782);
          this.ControlBox = false;
          this.Controls.Add(this.dgrKunden);
          this.Controls.Add(this.sstpKunde);
          this.Controls.Add(this.tsKunde);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.MinimizeBox = false;
          this.Name = "Form_Kunde_Uebersicht";
          this.Text = "Kundenübersicht";
          this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
          this.tsKunde.ResumeLayout(false);
          this.tsKunde.PerformLayout();
          this.ctmKundenGrid.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.dgrKunden)).EndInit();
          this.sstpKunde.ResumeLayout(false);
          this.sstpKunde.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsKunde;
        private System.Windows.Forms.ToolStripButton tsItemKundeNeu;
        private System.Windows.Forms.ToolStripButton tsItemKundeBearbeiten;
        private System.Windows.Forms.ToolStripButton tsItemKundeLoeschen;
        private System.Windows.Forms.ToolStripButton tsItemKundeUebersichtSchließen;
        private System.Windows.Forms.ContextMenuStrip ctmKundenGrid;
        private System.Windows.Forms.ToolStripMenuItem ctmAngebotErstellen;
        private System.Windows.Forms.ToolStripMenuItem ctmAuftragErstellen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ctmKundeBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem ctmKundeLoeschen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsItemAngebotErstellen;
        private System.Windows.Forms.ToolStripButton tsItemAuftragErstellen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ctmDrucken;
        private System.Windows.Forms.ToolStripMenuItem ctmDruckenDatenblatt;
        private System.Windows.Forms.ToolStripMenuItem ctmDruckenDatenblattSofortdruck;
        private System.Windows.Forms.ToolStripMenuItem ctmDruckenDatenblattVorschau;
        private System.Windows.Forms.ToolStripButton tsItemKundeAuswahl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        public System.Windows.Forms.DataGridView dgrKunden;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsItemDrucken;
        private System.Windows.Forms.ToolStripMenuItem tsItemDruckenDatenblatt;
        private System.Windows.Forms.ToolStripMenuItem tsItemDruckenDatenblattVorschau1;
        private System.Windows.Forms.ToolStripMenuItem tsItemDruckenDatenblattSofortdruck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.ToolStripButton tsItemAkualisieren;
        private System.Windows.Forms.StatusStrip sstpKunde;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel slKunde;
        private System.Windows.Forms.ToolStripMenuItem tsItemDruckenAbsageProgramm;
        private System.Windows.Forms.ToolStripMenuItem tsItemDruckenAbsageWirkungskreis;
        private System.Windows.Forms.ToolStripMenuItem absageNichtImProgrammToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem absageAußerhalbWirkungskreisToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsItemAllMark;
        private System.Windows.Forms.ToolStripButton tsItemKeineMark;
        private System.Windows.Forms.ToolStripMenuItem tsItemBrief;
        private System.Windows.Forms.ToolStripMenuItem ctmBrief;
    }
}