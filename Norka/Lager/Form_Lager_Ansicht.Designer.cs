using Norka.Common.Controls;

namespace Norka.Lager
{
  partial class Form_Lager_Ansicht
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lager_Ansicht));
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.rdbLager = new System.Windows.Forms.RadioButton();
      this.rdbKunde = new System.Windows.Forms.RadioButton();
      this.cbxKategorie = new System.Windows.Forms.ComboBox();
      this.lagerkategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsKategorieFilter = new Norka.dsKategorieFilter();
      this.ntbxProzent = new Norka.Common.Controls.NumericTextBox();
      this.lagerkategorieTableAdapter = new Norka.dsKategorieFilterTableAdapters.LagerkategorieTableAdapter();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblZuschlag = new System.Windows.Forms.Label();
      this.lblEingabemodus = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.lagerkategorieBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsKategorieFilter)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOK.Location = new System.Drawing.Point(97, 165);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(125, 30);
      this.btnOK.TabIndex = 8;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(249, 165);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(125, 30);
      this.btnCancel.TabIndex = 9;
      this.btnCancel.Text = "Abbrechen";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // rdbLager
      // 
      this.rdbLager.AutoSize = true;
      this.rdbLager.Checked = true;
      this.rdbLager.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbLager.Location = new System.Drawing.Point(23, 35);
      this.rdbLager.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbLager.Name = "rdbLager";
      this.rdbLager.Size = new System.Drawing.Size(62, 17);
      this.rdbLager.TabIndex = 12;
      this.rdbLager.TabStop = true;
      this.rdbLager.Text = "Lager";
      this.rdbLager.UseVisualStyleBackColor = true;
      this.rdbLager.CheckedChanged += new System.EventHandler(this.rdbLager_CheckedChanged);
      // 
      // rdbKunde
      // 
      this.rdbKunde.AutoSize = true;
      this.rdbKunde.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbKunde.Location = new System.Drawing.Point(23, 74);
      this.rdbKunde.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.rdbKunde.Name = "rdbKunde";
      this.rdbKunde.Size = new System.Drawing.Size(65, 17);
      this.rdbKunde.TabIndex = 13;
      this.rdbKunde.Text = "Kunde";
      this.rdbKunde.UseVisualStyleBackColor = true;
      this.rdbKunde.CheckedChanged += new System.EventHandler(this.rdbKunde_CheckedChanged);
      // 
      // cbxKategorie
      // 
      this.cbxKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxKategorie.DataSource = this.lagerkategorieBindingSource;
      this.cbxKategorie.DisplayMember = "Bezeichnung";
      this.cbxKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxKategorie.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxKategorie.FormattingEnabled = true;
      this.cbxKategorie.Location = new System.Drawing.Point(293, 43);
      this.cbxKategorie.Name = "cbxKategorie";
      this.cbxKategorie.Size = new System.Drawing.Size(163, 21);
      this.cbxKategorie.TabIndex = 15;
      this.cbxKategorie.ValueMember = "ID";
      this.cbxKategorie.SelectedIndexChanged += new System.EventHandler(this.cbxKategorie_SelectedIndexChanged);
      // 
      // lagerkategorieBindingSource
      // 
      this.lagerkategorieBindingSource.DataMember = "Lagerkategorie";
      this.lagerkategorieBindingSource.DataSource = this.dsKategorieFilter;
      // 
      // dsKategorieFilter
      // 
      this.dsKategorieFilter.DataSetName = "dsKategorieFilter";
      this.dsKategorieFilter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // ntbxProzent
      // 
      this.ntbxProzent.AllowSpace = false;
      this.ntbxProzent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.ntbxProzent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ntbxProzent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ntbxProzent.Location = new System.Drawing.Point(293, 86);
      this.ntbxProzent.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
      this.ntbxProzent.Name = "ntbxProzent";
      this.ntbxProzent.Size = new System.Drawing.Size(81, 21);
      this.ntbxProzent.TabIndex = 16;
      this.ntbxProzent.Text = "0";
      this.ntbxProzent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.ntbxProzent.Visible = false;
      this.ntbxProzent.Validating += new System.ComponentModel.CancelEventHandler(this.ntbxProzent_Validating);
      // 
      // lagerkategorieTableAdapter
      // 
      this.lagerkategorieTableAdapter.ClearBeforeFill = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(187, 47);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 13);
      this.label1.TabIndex = 17;
      this.label1.Text = "Kategorie:";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rdbLager);
      this.groupBox1.Controls.Add(this.rdbKunde);
      this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(23, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(145, 113);
      this.groupBox1.TabIndex = 18;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Ansicht";
      // 
      // lblZuschlag
      // 
      this.lblZuschlag.AutoSize = true;
      this.lblZuschlag.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblZuschlag.Location = new System.Drawing.Point(187, 90);
      this.lblZuschlag.Name = "lblZuschlag";
      this.lblZuschlag.Size = new System.Drawing.Size(103, 13);
      this.lblZuschlag.TabIndex = 19;
      this.lblZuschlag.Text = "Zuschlag in %:";
      this.lblZuschlag.Visible = false;
      // 
      // lblEingabemodus
      // 
      this.lblEingabemodus.AutoSize = true;
      this.lblEingabemodus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEingabemodus.ForeColor = System.Drawing.Color.Red;
      this.lblEingabemodus.Location = new System.Drawing.Point(289, 12);
      this.lblEingabemodus.Name = "lblEingabemodus";
      this.lblEingabemodus.Size = new System.Drawing.Size(175, 23);
      this.lblEingabemodus.TabIndex = 20;
      this.lblEingabemodus.Text = "Eingabemodus!";
      // 
      // Form_Lager_Ansicht
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(470, 226);
      this.ControlBox = false;
      this.Controls.Add(this.lblEingabemodus);
      this.Controls.Add(this.lblZuschlag);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ntbxProzent);
      this.Controls.Add(this.cbxKategorie);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form_Lager_Ansicht";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Ansicht auswählen";
      this.Load += new System.EventHandler(this.Form_Lager_Ansicht_Load);
      ((System.ComponentModel.ISupportInitialize)(this.lagerkategorieBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsKategorieFilter)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.RadioButton rdbLager;
    private System.Windows.Forms.RadioButton rdbKunde;
    private System.Windows.Forms.ComboBox cbxKategorie;
    private dsKategorieFilter dsKategorieFilter;
    private System.Windows.Forms.BindingSource lagerkategorieBindingSource;
    private Norka.dsKategorieFilterTableAdapters.LagerkategorieTableAdapter lagerkategorieTableAdapter;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblZuschlag;
    private Norka.Common.Controls.NumericTextBox ntbxProzent;
    private System.Windows.Forms.Label lblEingabemodus;
  }
}