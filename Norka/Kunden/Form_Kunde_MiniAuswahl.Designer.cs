namespace Norka.Kunden
{
  partial class Form_Kunde_MiniAuswahl
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgrKundenMini = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dgrKundenMini)).BeginInit();
      this.SuspendLayout();
      // 
      // dgrKundenMini
      // 
      this.dgrKundenMini.AllowUserToAddRows = false;
      this.dgrKundenMini.AllowUserToDeleteRows = false;
      this.dgrKundenMini.AllowUserToResizeRows = false;
      this.dgrKundenMini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dgrKundenMini.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgrKundenMini.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgrKundenMini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgrKundenMini.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgrKundenMini.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgrKundenMini.Location = new System.Drawing.Point(0, 0);
      this.dgrKundenMini.MultiSelect = false;
      this.dgrKundenMini.Name = "dgrKundenMini";
      this.dgrKundenMini.ReadOnly = true;
      this.dgrKundenMini.RowHeadersVisible = false;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dgrKundenMini.RowsDefaultCellStyle = dataGridViewCellStyle3;
      this.dgrKundenMini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgrKundenMini.ShowEditingIcon = false;
      this.dgrKundenMini.Size = new System.Drawing.Size(767, 320);
      this.dgrKundenMini.TabIndex = 0;
      this.dgrKundenMini.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrKundenMini_CellDoubleClick);
      // 
      // Form_Kunde_MiniAuswahl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(767, 320);
      this.Controls.Add(this.dgrKundenMini);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form_Kunde_MiniAuswahl";
      this.Text = "Auswahl Kunde";
      ((System.ComponentModel.ISupportInitialize)(this.dgrKundenMini)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgrKundenMini;
  }
}