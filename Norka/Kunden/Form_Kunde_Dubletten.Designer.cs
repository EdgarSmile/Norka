namespace Norka.Kunden
{
    partial class Form_Kunde_Dubletten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Kunde_Dubletten));
            this.dgrKundeDubletten = new System.Windows.Forms.DataGridView();
            this.btnJa = new System.Windows.Forms.Button();
            this.btnNein = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKundeDubletten)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrKundeDubletten
            // 
            this.dgrKundeDubletten.AllowUserToAddRows = false;
            this.dgrKundeDubletten.AllowUserToDeleteRows = false;
            this.dgrKundeDubletten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgrKundeDubletten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrKundeDubletten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrKundeDubletten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrKundeDubletten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrKundeDubletten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrKundeDubletten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrKundeDubletten.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrKundeDubletten.Location = new System.Drawing.Point(0, 0);
            this.dgrKundeDubletten.MultiSelect = false;
            this.dgrKundeDubletten.Name = "dgrKundeDubletten";
            this.dgrKundeDubletten.ReadOnly = true;
            this.dgrKundeDubletten.RowHeadersVisible = false;
            this.dgrKundeDubletten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrKundeDubletten.Size = new System.Drawing.Size(1141, 389);
            this.dgrKundeDubletten.TabIndex = 0;
            // 
            // btnJa
            // 
            this.btnJa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJa.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnJa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnJa.Location = new System.Drawing.Point(922, 395);
            this.btnJa.Name = "btnJa";
            this.btnJa.Size = new System.Drawing.Size(100, 35);
            this.btnJa.TabIndex = 1;
            this.btnJa.Text = "Ja";
            this.btnJa.UseVisualStyleBackColor = true;
            // 
            // btnNein
            // 
            this.btnNein.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNein.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNein.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNein.Location = new System.Drawing.Point(1028, 395);
            this.btnNein.Name = "btnNein";
            this.btnNein.Size = new System.Drawing.Size(100, 35);
            this.btnNein.TabIndex = 2;
            this.btnNein.Text = "Nein";
            this.btnNein.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Es wurden bereits ähnliche Kunden gefunden. Soll der Kunde trotzdem angelegt werd" +
                "en?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Kunde_Dubletten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNein);
            this.Controls.Add(this.btnJa);
            this.Controls.Add(this.dgrKundeDubletten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Kunde_Dubletten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dubletten gefunden";
            ((System.ComponentModel.ISupportInitialize)(this.dgrKundeDubletten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJa;
        private System.Windows.Forms.Button btnNein;
        public System.Windows.Forms.DataGridView dgrKundeDubletten;
        private System.Windows.Forms.Label label1;
    }
}