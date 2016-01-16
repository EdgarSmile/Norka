namespace Norka.Kunden
{
  partial class Form_Kunde_Auswahl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kunde_Auswahl));
      this.tbxKundenNr = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.tbxName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.tbxMatchcode = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbxPLZ = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.tbxOrt = new System.Windows.Forms.TextBox();
      this.cbxGesperrt = new System.Windows.Forms.CheckBox();
      this.label6 = new System.Windows.Forms.Label();
      this.cobKategorie = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbxKundenNr
      // 
      this.tbxKundenNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxKundenNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxKundenNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxKundenNr.Location = new System.Drawing.Point(110, 71);
      this.tbxKundenNr.Name = "tbxKundenNr";
      this.tbxKundenNr.Size = new System.Drawing.Size(183, 21);
      this.tbxKundenNr.TabIndex = 1;
      this.tbxKundenNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxKundenNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxKundenNr_KeyDown);
      this.tbxKundenNr.Enter += new System.EventHandler(this.tbxKundenNr_Enter);
      this.tbxKundenNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxKundenNr_Validating);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(22, 73);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Kunden-Nr.:";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOK.Location = new System.Drawing.Point(23, 326);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(125, 30);
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(168, 326);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(125, 30);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Abbrechen";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(99, 371);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(125, 30);
      this.btnClear.TabIndex = 9;
      this.btnClear.Text = "Auswahl löschen";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(22, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Name:";
      // 
      // tbxName
      // 
      this.tbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxName.Location = new System.Drawing.Point(110, 29);
      this.tbxName.Name = "tbxName";
      this.tbxName.Size = new System.Drawing.Size(183, 21);
      this.tbxName.TabIndex = 0;
      this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxName_KeyDown);
      this.tbxName.Enter += new System.EventHandler(this.tbxName_Enter);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(22, 157);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Matchcode:";
      // 
      // tbxMatchcode
      // 
      this.tbxMatchcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxMatchcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxMatchcode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxMatchcode.Location = new System.Drawing.Point(110, 155);
      this.tbxMatchcode.Name = "tbxMatchcode";
      this.tbxMatchcode.Size = new System.Drawing.Size(183, 21);
      this.tbxMatchcode.TabIndex = 3;
      this.tbxMatchcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxMatchcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMatchcode_KeyDown);
      this.tbxMatchcode.Enter += new System.EventHandler(this.tbxMatchcode_Enter);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(22, 115);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "PLZ:";
      // 
      // tbxPLZ
      // 
      this.tbxPLZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxPLZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxPLZ.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxPLZ.Location = new System.Drawing.Point(110, 113);
      this.tbxPLZ.Name = "tbxPLZ";
      this.tbxPLZ.Size = new System.Drawing.Size(183, 21);
      this.tbxPLZ.TabIndex = 2;
      this.tbxPLZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxPLZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPLZ_KeyDown);
      this.tbxPLZ.Enter += new System.EventHandler(this.tbxPLZ_Enter);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(22, 199);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(31, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Ort:";
      // 
      // tbxOrt
      // 
      this.tbxOrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxOrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxOrt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxOrt.Location = new System.Drawing.Point(110, 197);
      this.tbxOrt.Name = "tbxOrt";
      this.tbxOrt.Size = new System.Drawing.Size(183, 21);
      this.tbxOrt.TabIndex = 4;
      this.tbxOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxOrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxOrt_KeyDown);
      this.tbxOrt.Enter += new System.EventHandler(this.tbxOrt_Enter);
      // 
      // cbxGesperrt
      // 
      this.cbxGesperrt.AutoSize = true;
      this.cbxGesperrt.Checked = true;
      this.cbxGesperrt.CheckState = System.Windows.Forms.CheckState.Indeterminate;
      this.cbxGesperrt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxGesperrt.Location = new System.Drawing.Point(112, 277);
      this.cbxGesperrt.Name = "cbxGesperrt";
      this.cbxGesperrt.Size = new System.Drawing.Size(15, 14);
      this.cbxGesperrt.TabIndex = 6;
      this.cbxGesperrt.ThreeState = true;
      this.cbxGesperrt.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(20, 277);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(67, 13);
      this.label6.TabIndex = 14;
      this.label6.Text = "gesperrt:";
      // 
      // cobKategorie
      // 
      this.cobKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cobKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cobKategorie.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cobKategorie.FormattingEnabled = true;
      this.cobKategorie.Items.AddRange(new object[] {
            "Kunde",
            "Privat",
            "Verein"});
      this.cobKategorie.Location = new System.Drawing.Point(112, 236);
      this.cobKategorie.MaxDropDownItems = 3;
      this.cobKategorie.Name = "cobKategorie";
      this.cobKategorie.Size = new System.Drawing.Size(181, 21);
      this.cobKategorie.TabIndex = 5;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(22, 239);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(74, 13);
      this.label7.TabIndex = 16;
      this.label7.Text = "Kategorie:";
      // 
      // Form_Kunde_Auswahl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(323, 421);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.cobKategorie);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.cbxGesperrt);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.tbxOrt);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.tbxMatchcode);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.tbxPLZ);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbxName);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbxKundenNr);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(331, 455);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(331, 455);
      this.Name = "Form_Kunde_Auswahl";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Auswahl Kunde";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbxKundenNr;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbxName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbxMatchcode;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbxPLZ;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbxOrt;
    private System.Windows.Forms.CheckBox cbxGesperrt;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cobKategorie;
    private System.Windows.Forms.Label label7;
  }
}