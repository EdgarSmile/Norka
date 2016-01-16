namespace Norka.Kunden
{
    partial class Form_Land
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Land));
          this.lbxLand = new System.Windows.Forms.ListBox();
          this.landBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.dsLand = new Norka.Kunden.dsLand();
          this.btnUebernehmen = new System.Windows.Forms.Button();
          this.landTableAdapter = new Norka.Kunden.dsLandTableAdapters.LandTableAdapter();
          ((System.ComponentModel.ISupportInitialize)(this.landBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLand)).BeginInit();
          this.SuspendLayout();
          // 
          // lbxLand
          // 
          this.lbxLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
          this.lbxLand.DataSource = this.landBindingSource;
          this.lbxLand.DisplayMember = "LandLang";
          this.lbxLand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.lbxLand.FormattingEnabled = true;
          this.lbxLand.Location = new System.Drawing.Point(16, 12);
          this.lbxLand.Name = "lbxLand";
          this.lbxLand.Size = new System.Drawing.Size(317, 80);
          this.lbxLand.TabIndex = 0;
          this.lbxLand.ValueMember = "LandKurz";
          // 
          // landBindingSource
          // 
          this.landBindingSource.DataMember = "Land";
          this.landBindingSource.DataSource = this.dsLand;
          // 
          // dsLand
          // 
          this.dsLand.DataSetName = "dsLand";
          this.dsLand.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
          // 
          // btnUebernehmen
          // 
          this.btnUebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
          this.btnUebernehmen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btnUebernehmen.Location = new System.Drawing.Point(120, 112);
          this.btnUebernehmen.Name = "btnUebernehmen";
          this.btnUebernehmen.Size = new System.Drawing.Size(109, 33);
          this.btnUebernehmen.TabIndex = 1;
          this.btnUebernehmen.Text = "Übernehmen";
          this.btnUebernehmen.UseVisualStyleBackColor = true;
          this.btnUebernehmen.Click += new System.EventHandler(this.btnUebernehmen_Click);
          // 
          // landTableAdapter
          // 
          this.landTableAdapter.ClearBeforeFill = true;
          // 
          // Form_Land
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(348, 181);
          this.Controls.Add(this.btnUebernehmen);
          this.Controls.Add(this.lbxLand);
          this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.Name = "Form_Land";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "Land auswählen";
          this.Load += new System.EventHandler(this.Land_Load);
          ((System.ComponentModel.ISupportInitialize)(this.landBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.dsLand)).EndInit();
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxLand;
        private System.Windows.Forms.Button btnUebernehmen;
        private dsLand dsLand;
        private System.Windows.Forms.BindingSource landBindingSource;
        private Norka.Kunden.dsLandTableAdapters.LandTableAdapter landTableAdapter;
    }
}