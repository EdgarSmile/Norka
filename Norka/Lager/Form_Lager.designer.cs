namespace Norka.Lager
{
    partial class Form_Lager
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
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
          System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
          this.tsLager = new System.Windows.Forms.ToolStrip();
          this.tsNeueZeile = new System.Windows.Forms.ToolStripButton();
          this.tsItemZeileLoeschen = new System.Windows.Forms.ToolStripButton();
          this.tsItemKundeUebersichtSchließen = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
          this.tsItemDrucken = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
          this.dgrLager = new System.Windows.Forms.DataGridView();
          this.lagerkategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dsLagerkategorie = new Norka.dsLagerkategorie();
          this.lagereinheitBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dsLagereinheit = new Norka.dsLagereinheit();
          this.sstLager = new System.Windows.Forms.StatusStrip();
          this.slKunde = new System.Windows.Forms.ToolStripStatusLabel();
          this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
          this.lagerkategorieTableAdapter = new Norka.dsLagerkategorieTableAdapters.LagerkategorieTableAdapter();
          this.lagereinheitTableAdapter = new Norka.dsLagereinheitTableAdapters.LagereinheitTableAdapter();
          this.lagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dsLager = new Norka.dsLager();
          this.lagerTableAdapter = new Norka.dsLagerTableAdapters.LagerTableAdapter();
          this.splitContainer1 = new System.Windows.Forms.SplitContainer();
          this.dataGridView1 = new System.Windows.Forms.DataGridView();
          this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.summeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
          this.dsSummen1BindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dsSummen1 = new Norka.dsSummen();
          this.label1 = new System.Windows.Forms.Label();
          this.SummenTableAdapter = new Norka.dsSummenTableAdapters.SummenTableAdapter();
          this.lagerkategorieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
          this.dsKategorieFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dsKategorieFilter = new Norka.dsKategorieFilter();
          this.lagerkategorieTableAdapter1 = new Norka.dsKategorieFilterTableAdapters.LagerkategorieTableAdapter();
          this.tsLager.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dgrLager)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.lagerkategorieBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLagerkategorie)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.lagereinheitBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLagereinheit)).BeginInit();
          this.sstLager.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.lagerBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLager)).BeginInit();
          this.splitContainer1.Panel1.SuspendLayout();
          this.splitContainer1.Panel2.SuspendLayout();
          this.splitContainer1.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsSummen1BindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsSummen1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.lagerkategorieBindingSource1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsKategorieFilterBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsKategorieFilter)).BeginInit();
          this.SuspendLayout();
          // 
          // tsLager
          // 
          this.tsLager.AllowDrop = true;
          this.tsLager.AutoSize = false;
          this.tsLager.BackColor = System.Drawing.SystemColors.MenuBar;
          this.tsLager.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
          this.tsLager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNeueZeile,
            this.tsItemZeileLoeschen,
            this.tsItemKundeUebersichtSchließen,
            this.toolStripSeparator5,
            this.tsItemDrucken,
            this.toolStripSeparator6});
          this.tsLager.Location = new System.Drawing.Point(0, 0);
          this.tsLager.Name = "tsLager";
          this.tsLager.Size = new System.Drawing.Size(1349, 38);
          this.tsLager.TabIndex = 0;
          this.tsLager.Text = "toolStrip1";
          // 
          // tsNeueZeile
          // 
          this.tsNeueZeile.AutoSize = false;
          this.tsNeueZeile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsNeueZeile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsNeueZeile.Image = global::Norka.Properties.Resources.add_user_32;
          this.tsNeueZeile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsNeueZeile.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsNeueZeile.Name = "tsNeueZeile";
          this.tsNeueZeile.Size = new System.Drawing.Size(50, 35);
          this.tsNeueZeile.Text = "Neue Zeile einfügen";
          this.tsNeueZeile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
          this.tsNeueZeile.Click += new System.EventHandler(this.tsNeueZeile_Click);
          // 
          // tsItemZeileLoeschen
          // 
          this.tsItemZeileLoeschen.AutoSize = false;
          this.tsItemZeileLoeschen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemZeileLoeschen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemZeileLoeschen.Image = global::Norka.Properties.Resources.remove_user_32;
          this.tsItemZeileLoeschen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemZeileLoeschen.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemZeileLoeschen.Name = "tsItemZeileLoeschen";
          this.tsItemZeileLoeschen.Size = new System.Drawing.Size(50, 35);
          this.tsItemZeileLoeschen.Text = "Markierte Zeile löschen";
          this.tsItemZeileLoeschen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
          this.tsItemZeileLoeschen.Click += new System.EventHandler(this.tsItemZeileLoeschen_Click);
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
          this.tsItemKundeUebersichtSchließen.Click += new System.EventHandler(this.tsItemKundeUebersichtSchließen_Click);
          // 
          // toolStripSeparator5
          // 
          this.toolStripSeparator5.Name = "toolStripSeparator5";
          this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
          // 
          // tsItemDrucken
          // 
          this.tsItemDrucken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.tsItemDrucken.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.tsItemDrucken.Image = global::Norka.Properties.Resources.print_32;
          this.tsItemDrucken.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
          this.tsItemDrucken.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.tsItemDrucken.Name = "tsItemDrucken";
          this.tsItemDrucken.Size = new System.Drawing.Size(36, 35);
          this.tsItemDrucken.Text = "Drucken";
          this.tsItemDrucken.Click += new System.EventHandler(this.tsItemDrucken_Click);
          // 
          // toolStripSeparator6
          // 
          this.toolStripSeparator6.Name = "toolStripSeparator6";
          this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
          // 
          // dgrLager
          // 
          this.dgrLager.AllowUserToResizeRows = false;
          dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
          dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
          dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
          this.dgrLager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
          this.dgrLager.BorderStyle = System.Windows.Forms.BorderStyle.None;
          this.dgrLager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dgrLager.Cursor = System.Windows.Forms.Cursors.Arrow;
          dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
          dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
          dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
          dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
          dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
          dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
          this.dgrLager.DefaultCellStyle = dataGridViewCellStyle7;
          this.dgrLager.Dock = System.Windows.Forms.DockStyle.Fill;
          this.dgrLager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
          this.dgrLager.EnableHeadersVisualStyles = false;
          this.dgrLager.Location = new System.Drawing.Point(0, 0);
          this.dgrLager.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
          this.dgrLager.MultiSelect = false;
          this.dgrLager.Name = "dgrLager";
          this.dgrLager.RowHeadersWidth = 25;
          this.dgrLager.Size = new System.Drawing.Size(1004, 722);
          this.dgrLager.TabIndex = 4;
          this.dgrLager.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgrLager_RowsAdded);
          this.dgrLager.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrLager_CellEndEdit);
          this.dgrLager.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrLager_CellEnter);
          this.dgrLager.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgrLager_RowsRemoved);
          // 
          // lagerkategorieBindingSource
          // 
          this.lagerkategorieBindingSource.DataMember = "Lagerkategorie";
          this.lagerkategorieBindingSource.DataSource = this.dsLagerkategorie;
          // 
          // dsLagerkategorie
          // 
          this.dsLagerkategorie.DataSetName = "dsLagerkategorie";
          this.dsLagerkategorie.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // lagereinheitBindingSource
          // 
          this.lagereinheitBindingSource.DataMember = "Lagereinheit";
          this.lagereinheitBindingSource.DataSource = this.dsLagereinheit;
          // 
          // dsLagereinheit
          // 
          this.dsLagereinheit.DataSetName = "dsLagereinheit";
          this.dsLagereinheit.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // sstLager
          // 
          this.sstLager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slKunde,
            this.toolStripStatusLabel1});
          this.sstLager.Location = new System.Drawing.Point(0, 760);
          this.sstLager.Name = "sstLager";
          this.sstLager.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
          this.sstLager.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
          this.sstLager.Size = new System.Drawing.Size(1349, 22);
          this.sstLager.SizingGrip = false;
          this.sstLager.TabIndex = 2;
          this.sstLager.Text = "statusStrip1";
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
          // lagerkategorieTableAdapter
          // 
          this.lagerkategorieTableAdapter.ClearBeforeFill = true;
          // 
          // lagereinheitTableAdapter
          // 
          this.lagereinheitTableAdapter.ClearBeforeFill = true;
          // 
          // lagerBindingSource
          // 
          this.lagerBindingSource.DataMember = "Lager";
          this.lagerBindingSource.DataSource = this.dsLager;
          // 
          // dsLager
          // 
          this.dsLager.DataSetName = "dsLager";
          this.dsLager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // lagerTableAdapter
          // 
          this.lagerTableAdapter.ClearBeforeFill = true;
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
          this.splitContainer1.Panel1.Controls.Add(this.dgrLager);
          // 
          // splitContainer1.Panel2
          // 
          this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
          this.splitContainer1.Panel2.Controls.Add(this.label1);
          this.splitContainer1.Size = new System.Drawing.Size(1349, 722);
          this.splitContainer1.SplitterDistance = 1004;
          this.splitContainer1.TabIndex = 5;
          // 
          // dataGridView1
          // 
          this.dataGridView1.AllowUserToAddRows = false;
          this.dataGridView1.AllowUserToDeleteRows = false;
          this.dataGridView1.AllowUserToResizeColumns = false;
          this.dataGridView1.AllowUserToResizeRows = false;
          dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
          dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
          this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
          this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.dataGridView1.AutoGenerateColumns = false;
          this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
          this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
          this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezeichnungDataGridViewTextBoxColumn,
            this.summeDataGridViewTextBoxColumn});
          this.dataGridView1.DataMember = "Summen";
          this.dataGridView1.DataSource = this.dsSummen1BindingSource;
          this.dataGridView1.EnableHeadersVisualStyles = false;
          this.dataGridView1.Location = new System.Drawing.Point(3, 50);
          this.dataGridView1.MultiSelect = false;
          this.dataGridView1.Name = "dataGridView1";
          this.dataGridView1.ReadOnly = true;
          this.dataGridView1.RowHeadersVisible = false;
          this.dataGridView1.Size = new System.Drawing.Size(335, 672);
          this.dataGridView1.TabIndex = 1;
          // 
          // bezeichnungDataGridViewTextBoxColumn
          // 
          this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
          dataGridViewCellStyle9.NullValue = null;
          this.bezeichnungDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
          this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
          this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
          this.bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
          this.bezeichnungDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
          // 
          // summeDataGridViewTextBoxColumn
          // 
          this.summeDataGridViewTextBoxColumn.DataPropertyName = "Summe";
          dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
          dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          dataGridViewCellStyle10.Format = "N2";
          dataGridViewCellStyle10.NullValue = null;
          this.summeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
          this.summeDataGridViewTextBoxColumn.HeaderText = "Summe";
          this.summeDataGridViewTextBoxColumn.Name = "summeDataGridViewTextBoxColumn";
          this.summeDataGridViewTextBoxColumn.ReadOnly = true;
          this.summeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
          // 
          // dsSummen1BindingSource
          // 
          this.dsSummen1BindingSource.DataSource = this.dsSummen1;
          this.dsSummen1BindingSource.Position = 0;
          // 
          // dsSummen1
          // 
          this.dsSummen1.DataSetName = "dsSummen";
          this.dsSummen1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // label1
          // 
          this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label1.Location = new System.Drawing.Point(3, 10);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(335, 25);
          this.label1.TabIndex = 0;
          this.label1.Text = "Summen";
          this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
          // 
          // SummenTableAdapter
          // 
          this.SummenTableAdapter.ClearBeforeFill = true;
          // 
          // lagerkategorieBindingSource1
          // 
          this.lagerkategorieBindingSource1.DataMember = "Lagerkategorie";
          this.lagerkategorieBindingSource1.DataSource = this.dsKategorieFilterBindingSource;
          // 
          // dsKategorieFilterBindingSource
          // 
          this.dsKategorieFilterBindingSource.DataSource = this.dsKategorieFilter;
          this.dsKategorieFilterBindingSource.Position = 0;
          // 
          // dsKategorieFilter
          // 
          this.dsKategorieFilter.DataSetName = "dsKategorieFilter";
          this.dsKategorieFilter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // lagerkategorieTableAdapter1
          // 
          this.lagerkategorieTableAdapter1.ClearBeforeFill = true;
          // 
          // Form_Lager
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.AutoScroll = true;
          this.ClientSize = new System.Drawing.Size(1349, 782);
          this.ControlBox = false;
          this.Controls.Add(this.splitContainer1);
          this.Controls.Add(this.sstLager);
          this.Controls.Add(this.tsLager);
          this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.MinimizeBox = false;
          this.Name = "Form_Lager";
          this.Text = "Lager";
          this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
          this.Load += new System.EventHandler(this.Form_Lager_Load);
          this.tsLager.ResumeLayout(false);
          this.tsLager.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.dgrLager)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.lagerkategorieBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLagerkategorie)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.lagereinheitBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLagereinheit)).EndInit();
          this.sstLager.ResumeLayout(false);
          this.sstLager.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.lagerBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLager)).EndInit();
          this.splitContainer1.Panel1.ResumeLayout(false);
          this.splitContainer1.Panel2.ResumeLayout(false);
          this.splitContainer1.ResumeLayout(false);
          ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsSummen1BindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsSummen1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.lagerkategorieBindingSource1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsKategorieFilterBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsKategorieFilter)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsLager;
        private System.Windows.Forms.ToolStripButton tsItemKundeUebersichtSchließen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.StatusStrip sstLager;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel slKunde;
        private System.Windows.Forms.DataGridView dgrLager;
        private dsLager dsLager;
        private System.Windows.Forms.BindingSource lagerBindingSource;
        private Norka.dsLagerTableAdapters.LagerTableAdapter lagerTableAdapter;
        private dsLagerkategorie dsLagerkategorie;
        private System.Windows.Forms.BindingSource lagerkategorieBindingSource;
        private Norka.dsLagerkategorieTableAdapters.LagerkategorieTableAdapter lagerkategorieTableAdapter;
        private dsLagereinheit dsLagereinheit;
        private System.Windows.Forms.BindingSource lagereinheitBindingSource;
        private Norka.dsLagereinheitTableAdapters.LagereinheitTableAdapter lagereinheitTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Norka.dsSummenTableAdapters.SummenTableAdapter SummenTableAdapter;
        private dsSummen dsSummen1;
        private System.Windows.Forms.BindingSource dsSummen1BindingSource;
        private System.Windows.Forms.BindingSource dsKategorieFilterBindingSource;
        private dsKategorieFilter dsKategorieFilter;
        private System.Windows.Forms.BindingSource lagerkategorieBindingSource1;
        private Norka.dsKategorieFilterTableAdapters.LagerkategorieTableAdapter lagerkategorieTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsItemDrucken;
        public System.Windows.Forms.ToolStripButton tsNeueZeile;
        public System.Windows.Forms.ToolStripButton tsItemZeileLoeschen;
    }
}