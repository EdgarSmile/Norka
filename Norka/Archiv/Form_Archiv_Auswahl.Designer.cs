namespace Norka.Archiv
{
  partial class Form_Archiv_Auswahl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Archiv_Auswahl));
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.mtbxAngDatumBis = new System.Windows.Forms.MaskedTextBox();
      this.mtbxAngDatumVon = new System.Windows.Forms.MaskedTextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.tbxAngKundenNr = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbxAngName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.tbxAngebotNr = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pnlAngebote = new System.Windows.Forms.Panel();
      this.tbxAngBV = new System.Windows.Forms.TextBox();
      this.label25 = new System.Windows.Forms.Label();
      this.tbxAngebotMaxZeilen = new System.Windows.Forms.TextBox();
      this.label21 = new System.Windows.Forms.Label();
      this.tbxAngOrt = new System.Windows.Forms.TextBox();
      this.label16 = new System.Windows.Forms.Label();
      this.pnlRechnungen = new System.Windows.Forms.Panel();
      this.cbxEinbehalt = new System.Windows.Forms.CheckBox();
      this.tbxRechnungMaxZeilen = new System.Windows.Forms.TextBox();
      this.label23 = new System.Windows.Forms.Label();
      this.cbxSchlussrechnung = new System.Windows.Forms.CheckBox();
      this.cbxAngemahnt = new System.Windows.Forms.CheckBox();
      this.cbxRechStorniert = new System.Windows.Forms.CheckBox();
      this.tbxRechBV = new System.Windows.Forms.TextBox();
      this.tbxRechOrt = new System.Windows.Forms.TextBox();
      this.label26 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.mtbxRechDatumBis = new System.Windows.Forms.MaskedTextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.mtbxRechDatumVon = new System.Windows.Forms.MaskedTextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.tbxRechnungNr = new System.Windows.Forms.TextBox();
      this.tbxRechKundenNr = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.tbxRechName = new System.Windows.Forms.TextBox();
      this.pnlAufträge = new System.Windows.Forms.Panel();
      this.tbxAuftragMaxZeilen = new System.Windows.Forms.TextBox();
      this.label24 = new System.Windows.Forms.Label();
      this.tbxAufOrt = new System.Windows.Forms.TextBox();
      this.label17 = new System.Windows.Forms.Label();
      this.mtbxAufDatumBis = new System.Windows.Forms.MaskedTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.mtbxAufDatumVon = new System.Windows.Forms.MaskedTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tbxAuftragNr = new System.Windows.Forms.TextBox();
      this.tbxAufKundenNr = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.tbxAufName = new System.Windows.Forms.TextBox();
      this.pnlAngebote.SuspendLayout();
      this.pnlRechnungen.SuspendLayout();
      this.pnlAufträge.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOK.Location = new System.Drawing.Point(116, 194);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(125, 30);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      this.btnOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnOK_KeyDown);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Location = new System.Drawing.Point(263, 194);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(125, 30);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Abbrechen";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(410, 194);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(125, 30);
      this.btnClear.TabIndex = 3;
      this.btnClear.Text = "Auswahl löschen";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
      // 
      // mtbxAngDatumBis
      // 
      this.mtbxAngDatumBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.mtbxAngDatumBis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mtbxAngDatumBis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mtbxAngDatumBis.Location = new System.Drawing.Point(404, 77);
      this.mtbxAngDatumBis.Mask = "00/00/0000";
      this.mtbxAngDatumBis.Name = "mtbxAngDatumBis";
      this.mtbxAngDatumBis.PromptChar = '#';
      this.mtbxAngDatumBis.Size = new System.Drawing.Size(123, 21);
      this.mtbxAngDatumBis.TabIndex = 6;
      this.mtbxAngDatumBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.mtbxAngDatumBis.ValidatingType = typeof(System.DateTime);
      this.mtbxAngDatumBis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxAngDatumBis_KeyDown);
      this.mtbxAngDatumBis.Enter += new System.EventHandler(this.mtbxAngDatumBis_Enter);
      // 
      // mtbxAngDatumVon
      // 
      this.mtbxAngDatumVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.mtbxAngDatumVon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mtbxAngDatumVon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mtbxAngDatumVon.Location = new System.Drawing.Point(129, 76);
      this.mtbxAngDatumVon.Mask = "00/00/0000";
      this.mtbxAngDatumVon.Name = "mtbxAngDatumVon";
      this.mtbxAngDatumVon.PromptChar = '#';
      this.mtbxAngDatumVon.Size = new System.Drawing.Size(123, 21);
      this.mtbxAngDatumVon.TabIndex = 5;
      this.mtbxAngDatumVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.mtbxAngDatumVon.ValidatingType = typeof(System.DateTime);
      this.mtbxAngDatumVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxAngDatumVon_KeyDown);
      this.mtbxAngDatumVon.Enter += new System.EventHandler(this.mtbxAngDatumVon_Enter);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(283, 77);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(86, 20);
      this.label4.TabIndex = 19;
      this.label4.Text = "Datum bis:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAngKundenNr
      // 
      this.tbxAngKundenNr.AllowDrop = true;
      this.tbxAngKundenNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAngKundenNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAngKundenNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAngKundenNr.Location = new System.Drawing.Point(128, 42);
      this.tbxAngKundenNr.Name = "tbxAngKundenNr";
      this.tbxAngKundenNr.Size = new System.Drawing.Size(123, 21);
      this.tbxAngKundenNr.TabIndex = 3;
      this.tbxAngKundenNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAngKundenNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngKundenNr_KeyDown);
      this.tbxAngKundenNr.Enter += new System.EventHandler(this.tbxAngKundenNr_Enter);
      this.tbxAngKundenNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAngKundenNr_Validating);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 20);
      this.label2.TabIndex = 17;
      this.label2.Text = "Kunde-Nr.:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAngName
      // 
      this.tbxAngName.AllowDrop = true;
      this.tbxAngName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAngName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAngName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAngName.Location = new System.Drawing.Point(404, 12);
      this.tbxAngName.Name = "tbxAngName";
      this.tbxAngName.Size = new System.Drawing.Size(199, 21);
      this.tbxAngName.TabIndex = 2;
      this.tbxAngName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAngName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngName_KeyDown_1);
      this.tbxAngName.Enter += new System.EventHandler(this.tbxAngName_Enter);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 20);
      this.label3.TabIndex = 13;
      this.label3.Text = "Datum von:";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(283, 12);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(94, 20);
      this.label5.TabIndex = 12;
      this.label5.Text = "Name:";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAngebotNr
      // 
      this.tbxAngebotNr.AllowDrop = true;
      this.tbxAngebotNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAngebotNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAngebotNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAngebotNr.Location = new System.Drawing.Point(128, 11);
      this.tbxAngebotNr.Name = "tbxAngebotNr";
      this.tbxAngebotNr.Size = new System.Drawing.Size(123, 21);
      this.tbxAngebotNr.TabIndex = 1;
      this.tbxAngebotNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAngebotNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngebotNr_KeyDown_1);
      this.tbxAngebotNr.Enter += new System.EventHandler(this.tbxAngebotNr_Enter);
      this.tbxAngebotNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAngebotNr_Validating);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(97, 20);
      this.label1.TabIndex = 10;
      this.label1.Text = "Angebot-Nr.:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnlAngebote
      // 
      this.pnlAngebote.Controls.Add(this.tbxAngBV);
      this.pnlAngebote.Controls.Add(this.label25);
      this.pnlAngebote.Controls.Add(this.tbxAngebotMaxZeilen);
      this.pnlAngebote.Controls.Add(this.label21);
      this.pnlAngebote.Controls.Add(this.tbxAngOrt);
      this.pnlAngebote.Controls.Add(this.label16);
      this.pnlAngebote.Controls.Add(this.mtbxAngDatumBis);
      this.pnlAngebote.Controls.Add(this.label2);
      this.pnlAngebote.Controls.Add(this.mtbxAngDatumVon);
      this.pnlAngebote.Controls.Add(this.label1);
      this.pnlAngebote.Controls.Add(this.label4);
      this.pnlAngebote.Controls.Add(this.tbxAngebotNr);
      this.pnlAngebote.Controls.Add(this.tbxAngKundenNr);
      this.pnlAngebote.Controls.Add(this.label5);
      this.pnlAngebote.Controls.Add(this.label3);
      this.pnlAngebote.Controls.Add(this.tbxAngName);
      this.pnlAngebote.Location = new System.Drawing.Point(12, 12);
      this.pnlAngebote.Name = "pnlAngebote";
      this.pnlAngebote.Size = new System.Drawing.Size(630, 150);
      this.pnlAngebote.TabIndex = 0;
      this.pnlAngebote.Tag = "x";
      this.pnlAngebote.Visible = false;
      // 
      // tbxAngBV
      // 
      this.tbxAngBV.AllowDrop = true;
      this.tbxAngBV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAngBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAngBV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAngBV.Location = new System.Drawing.Point(404, 114);
      this.tbxAngBV.Name = "tbxAngBV";
      this.tbxAngBV.Size = new System.Drawing.Size(199, 21);
      this.tbxAngBV.TabIndex = 24;
      this.tbxAngBV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAngBV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngBV_KeyDown);
      this.tbxAngBV.Enter += new System.EventHandler(this.tbxAngBV_Enter);
      // 
      // label25
      // 
      this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label25.Location = new System.Drawing.Point(283, 117);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(94, 20);
      this.label25.TabIndex = 23;
      this.label25.Text = "BV:";
      this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label25.Click += new System.EventHandler(this.label25_Click);
      // 
      // tbxAngebotMaxZeilen
      // 
      this.tbxAngebotMaxZeilen.AllowDrop = true;
      this.tbxAngebotMaxZeilen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAngebotMaxZeilen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAngebotMaxZeilen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAngebotMaxZeilen.Location = new System.Drawing.Point(129, 115);
      this.tbxAngebotMaxZeilen.Name = "tbxAngebotMaxZeilen";
      this.tbxAngebotMaxZeilen.Size = new System.Drawing.Size(123, 21);
      this.tbxAngebotMaxZeilen.TabIndex = 22;
      this.tbxAngebotMaxZeilen.Text = "20";
      this.tbxAngebotMaxZeilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAngebotMaxZeilen.TextChanged += new System.EventHandler(this.tbxAngebotMaxZeilen_TextChanged);
      this.tbxAngebotMaxZeilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngebotMaxZeilen_KeyDown);
      // 
      // label21
      // 
      this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label21.Location = new System.Drawing.Point(12, 109);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(102, 35);
      this.label21.TabIndex = 21;
      this.label21.Text = "max. Anzeige\r\nZeilen:";
      this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAngOrt
      // 
      this.tbxAngOrt.AllowDrop = true;
      this.tbxAngOrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAngOrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAngOrt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAngOrt.Location = new System.Drawing.Point(404, 44);
      this.tbxAngOrt.Name = "tbxAngOrt";
      this.tbxAngOrt.Size = new System.Drawing.Size(199, 21);
      this.tbxAngOrt.TabIndex = 4;
      this.tbxAngOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAngOrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngOrt_KeyDown);
      this.tbxAngOrt.Enter += new System.EventHandler(this.tbxAngOrt_Enter);
      // 
      // label16
      // 
      this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(283, 43);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(94, 20);
      this.label16.TabIndex = 20;
      this.label16.Text = "Ort:";
      this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // pnlRechnungen
      // 
      this.pnlRechnungen.Controls.Add(this.cbxEinbehalt);
      this.pnlRechnungen.Controls.Add(this.tbxRechnungMaxZeilen);
      this.pnlRechnungen.Controls.Add(this.label23);
      this.pnlRechnungen.Controls.Add(this.cbxSchlussrechnung);
      this.pnlRechnungen.Controls.Add(this.cbxAngemahnt);
      this.pnlRechnungen.Controls.Add(this.cbxRechStorniert);
      this.pnlRechnungen.Controls.Add(this.tbxRechBV);
      this.pnlRechnungen.Controls.Add(this.tbxRechOrt);
      this.pnlRechnungen.Controls.Add(this.label26);
      this.pnlRechnungen.Controls.Add(this.label18);
      this.pnlRechnungen.Controls.Add(this.mtbxRechDatumBis);
      this.pnlRechnungen.Controls.Add(this.label11);
      this.pnlRechnungen.Controls.Add(this.mtbxRechDatumVon);
      this.pnlRechnungen.Controls.Add(this.label12);
      this.pnlRechnungen.Controls.Add(this.label13);
      this.pnlRechnungen.Controls.Add(this.tbxRechnungNr);
      this.pnlRechnungen.Controls.Add(this.tbxRechKundenNr);
      this.pnlRechnungen.Controls.Add(this.label14);
      this.pnlRechnungen.Controls.Add(this.label15);
      this.pnlRechnungen.Controls.Add(this.tbxRechName);
      this.pnlRechnungen.Location = new System.Drawing.Point(12, 12);
      this.pnlRechnungen.Name = "pnlRechnungen";
      this.pnlRechnungen.Size = new System.Drawing.Size(630, 176);
      this.pnlRechnungen.TabIndex = 2;
      this.pnlRechnungen.Visible = false;
      // 
      // cbxEinbehalt
      // 
      this.cbxEinbehalt.AutoSize = true;
      this.cbxEinbehalt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.cbxEinbehalt.Checked = true;
      this.cbxEinbehalt.CheckState = System.Windows.Forms.CheckState.Indeterminate;
      this.cbxEinbehalt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxEinbehalt.Location = new System.Drawing.Point(281, 141);
      this.cbxEinbehalt.Name = "cbxEinbehalt";
      this.cbxEinbehalt.Size = new System.Drawing.Size(91, 17);
      this.cbxEinbehalt.TabIndex = 27;
      this.cbxEinbehalt.Text = "Einbehalt:";
      this.cbxEinbehalt.ThreeState = true;
      this.cbxEinbehalt.UseVisualStyleBackColor = true;
      // 
      // tbxRechnungMaxZeilen
      // 
      this.tbxRechnungMaxZeilen.AllowDrop = true;
      this.tbxRechnungMaxZeilen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxRechnungMaxZeilen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxRechnungMaxZeilen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxRechnungMaxZeilen.Location = new System.Drawing.Point(128, 111);
      this.tbxRechnungMaxZeilen.Name = "tbxRechnungMaxZeilen";
      this.tbxRechnungMaxZeilen.Size = new System.Drawing.Size(123, 21);
      this.tbxRechnungMaxZeilen.TabIndex = 24;
      this.tbxRechnungMaxZeilen.Text = "20";
      this.tbxRechnungMaxZeilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxRechnungMaxZeilen.TextChanged += new System.EventHandler(this.tbxRechnungMaxZeilen_TextChanged);
      this.tbxRechnungMaxZeilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRechnungMaxZeilen_KeyDown);
      // 
      // label23
      // 
      this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label23.Location = new System.Drawing.Point(12, 102);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(102, 35);
      this.label23.TabIndex = 23;
      this.label23.Text = "max. Anzeige\r\nZeilen:";
      this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cbxSchlussrechnung
      // 
      this.cbxSchlussrechnung.AutoSize = true;
      this.cbxSchlussrechnung.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.cbxSchlussrechnung.Checked = true;
      this.cbxSchlussrechnung.CheckState = System.Windows.Forms.CheckState.Indeterminate;
      this.cbxSchlussrechnung.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxSchlussrechnung.Location = new System.Drawing.Point(11, 140);
      this.cbxSchlussrechnung.Name = "cbxSchlussrechnung";
      this.cbxSchlussrechnung.Size = new System.Drawing.Size(112, 17);
      this.cbxSchlussrechnung.TabIndex = 26;
      this.cbxSchlussrechnung.Text = "Schlussrech.:";
      this.cbxSchlussrechnung.ThreeState = true;
      this.cbxSchlussrechnung.UseVisualStyleBackColor = true;
      // 
      // cbxAngemahnt
      // 
      this.cbxAngemahnt.AutoSize = true;
      this.cbxAngemahnt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.cbxAngemahnt.Checked = true;
      this.cbxAngemahnt.CheckState = System.Windows.Forms.CheckState.Indeterminate;
      this.cbxAngemahnt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxAngemahnt.Location = new System.Drawing.Point(149, 140);
      this.cbxAngemahnt.Name = "cbxAngemahnt";
      this.cbxAngemahnt.Size = new System.Drawing.Size(103, 17);
      this.cbxAngemahnt.TabIndex = 25;
      this.cbxAngemahnt.Text = "angemahnt:";
      this.cbxAngemahnt.ThreeState = true;
      this.cbxAngemahnt.UseVisualStyleBackColor = true;
      // 
      // cbxRechStorniert
      // 
      this.cbxRechStorniert.AutoSize = true;
      this.cbxRechStorniert.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.cbxRechStorniert.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxRechStorniert.Location = new System.Drawing.Point(400, 141);
      this.cbxRechStorniert.Name = "cbxRechStorniert";
      this.cbxRechStorniert.Size = new System.Drawing.Size(87, 17);
      this.cbxRechStorniert.TabIndex = 7;
      this.cbxRechStorniert.Text = "storniert:";
      this.cbxRechStorniert.ThreeState = true;
      this.cbxRechStorniert.UseVisualStyleBackColor = true;
      // 
      // tbxRechBV
      // 
      this.tbxRechBV.AllowDrop = true;
      this.tbxRechBV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxRechBV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxRechBV.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxRechBV.Location = new System.Drawing.Point(404, 111);
      this.tbxRechBV.Name = "tbxRechBV";
      this.tbxRechBV.Size = new System.Drawing.Size(199, 21);
      this.tbxRechBV.TabIndex = 4;
      this.tbxRechBV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxRechBV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRechBV_KeyDown);
      this.tbxRechBV.Enter += new System.EventHandler(this.tbxRechBV_Enter);
      // 
      // tbxRechOrt
      // 
      this.tbxRechOrt.AllowDrop = true;
      this.tbxRechOrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxRechOrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxRechOrt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxRechOrt.Location = new System.Drawing.Point(404, 44);
      this.tbxRechOrt.Name = "tbxRechOrt";
      this.tbxRechOrt.Size = new System.Drawing.Size(199, 21);
      this.tbxRechOrt.TabIndex = 4;
      this.tbxRechOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxRechOrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRechOrt_KeyDown);
      this.tbxRechOrt.Enter += new System.EventHandler(this.tbxRechOrt_Enter);
      // 
      // label26
      // 
      this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label26.Location = new System.Drawing.Point(283, 112);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(94, 20);
      this.label26.TabIndex = 22;
      this.label26.Text = "BV:";
      this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label18
      // 
      this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.Location = new System.Drawing.Point(283, 43);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(94, 20);
      this.label18.TabIndex = 22;
      this.label18.Text = "Ort:";
      this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // mtbxRechDatumBis
      // 
      this.mtbxRechDatumBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.mtbxRechDatumBis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mtbxRechDatumBis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mtbxRechDatumBis.Location = new System.Drawing.Point(404, 77);
      this.mtbxRechDatumBis.Mask = "00/00/0000";
      this.mtbxRechDatumBis.Name = "mtbxRechDatumBis";
      this.mtbxRechDatumBis.PromptChar = '#';
      this.mtbxRechDatumBis.Size = new System.Drawing.Size(123, 21);
      this.mtbxRechDatumBis.TabIndex = 6;
      this.mtbxRechDatumBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.mtbxRechDatumBis.ValidatingType = typeof(System.DateTime);
      this.mtbxRechDatumBis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxRechDatumBis_KeyDown);
      this.mtbxRechDatumBis.Enter += new System.EventHandler(this.mtbxRechDatumBis_Enter);
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(12, 46);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(76, 20);
      this.label11.TabIndex = 17;
      this.label11.Text = "Kunde-Nr.:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // mtbxRechDatumVon
      // 
      this.mtbxRechDatumVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.mtbxRechDatumVon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mtbxRechDatumVon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mtbxRechDatumVon.Location = new System.Drawing.Point(129, 76);
      this.mtbxRechDatumVon.Mask = "00/00/0000";
      this.mtbxRechDatumVon.Name = "mtbxRechDatumVon";
      this.mtbxRechDatumVon.PromptChar = '#';
      this.mtbxRechDatumVon.Size = new System.Drawing.Size(123, 21);
      this.mtbxRechDatumVon.TabIndex = 5;
      this.mtbxRechDatumVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.mtbxRechDatumVon.ValidatingType = typeof(System.DateTime);
      this.mtbxRechDatumVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxRechDatumVon_KeyDown);
      this.mtbxRechDatumVon.Enter += new System.EventHandler(this.mtbxRechDatumVon_Enter);
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(12, 15);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(100, 20);
      this.label12.TabIndex = 10;
      this.label12.Text = "Rechnung-Nr.:";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label13
      // 
      this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(283, 77);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(86, 20);
      this.label13.TabIndex = 19;
      this.label13.Text = "Datum bis:";
      this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxRechnungNr
      // 
      this.tbxRechnungNr.AllowDrop = true;
      this.tbxRechnungNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxRechnungNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxRechnungNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxRechnungNr.Location = new System.Drawing.Point(129, 11);
      this.tbxRechnungNr.Name = "tbxRechnungNr";
      this.tbxRechnungNr.Size = new System.Drawing.Size(123, 21);
      this.tbxRechnungNr.TabIndex = 1;
      this.tbxRechnungNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxRechnungNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRechnungNr_KeyDown);
      this.tbxRechnungNr.Enter += new System.EventHandler(this.tbxRechnungNr_Enter);
      this.tbxRechnungNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxRechnungNr_Validating);
      // 
      // tbxRechKundenNr
      // 
      this.tbxRechKundenNr.AllowDrop = true;
      this.tbxRechKundenNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxRechKundenNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxRechKundenNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxRechKundenNr.Location = new System.Drawing.Point(129, 43);
      this.tbxRechKundenNr.Name = "tbxRechKundenNr";
      this.tbxRechKundenNr.Size = new System.Drawing.Size(123, 21);
      this.tbxRechKundenNr.TabIndex = 3;
      this.tbxRechKundenNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxRechKundenNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRechKundenNr_KeyDown);
      this.tbxRechKundenNr.Enter += new System.EventHandler(this.tbxRechKundenNr_Enter);
      this.tbxRechKundenNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxRechKundenNr_Validating);
      // 
      // label14
      // 
      this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(283, 12);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(94, 20);
      this.label14.TabIndex = 12;
      this.label14.Text = "Name:";
      this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label15
      // 
      this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label15.Location = new System.Drawing.Point(12, 76);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(86, 20);
      this.label15.TabIndex = 13;
      this.label15.Text = "Datum von:";
      this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxRechName
      // 
      this.tbxRechName.AllowDrop = true;
      this.tbxRechName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxRechName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxRechName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxRechName.Location = new System.Drawing.Point(404, 12);
      this.tbxRechName.Name = "tbxRechName";
      this.tbxRechName.Size = new System.Drawing.Size(199, 21);
      this.tbxRechName.TabIndex = 2;
      this.tbxRechName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxRechName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxRechName_KeyDown);
      this.tbxRechName.Enter += new System.EventHandler(this.tbxRechName_Enter);
      // 
      // pnlAufträge
      // 
      this.pnlAufträge.Controls.Add(this.tbxAuftragMaxZeilen);
      this.pnlAufträge.Controls.Add(this.label24);
      this.pnlAufträge.Controls.Add(this.tbxAufOrt);
      this.pnlAufträge.Controls.Add(this.label17);
      this.pnlAufträge.Controls.Add(this.mtbxAufDatumBis);
      this.pnlAufträge.Controls.Add(this.label6);
      this.pnlAufträge.Controls.Add(this.mtbxAufDatumVon);
      this.pnlAufträge.Controls.Add(this.label7);
      this.pnlAufträge.Controls.Add(this.label8);
      this.pnlAufträge.Controls.Add(this.tbxAuftragNr);
      this.pnlAufträge.Controls.Add(this.tbxAufKundenNr);
      this.pnlAufträge.Controls.Add(this.label9);
      this.pnlAufträge.Controls.Add(this.label10);
      this.pnlAufträge.Controls.Add(this.tbxAufName);
      this.pnlAufträge.Location = new System.Drawing.Point(12, 12);
      this.pnlAufträge.Name = "pnlAufträge";
      this.pnlAufträge.Size = new System.Drawing.Size(630, 150);
      this.pnlAufträge.TabIndex = 1;
      this.pnlAufträge.Visible = false;
      // 
      // tbxAuftragMaxZeilen
      // 
      this.tbxAuftragMaxZeilen.AllowDrop = true;
      this.tbxAuftragMaxZeilen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAuftragMaxZeilen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAuftragMaxZeilen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAuftragMaxZeilen.Location = new System.Drawing.Point(129, 106);
      this.tbxAuftragMaxZeilen.Name = "tbxAuftragMaxZeilen";
      this.tbxAuftragMaxZeilen.Size = new System.Drawing.Size(123, 21);
      this.tbxAuftragMaxZeilen.TabIndex = 24;
      this.tbxAuftragMaxZeilen.Text = "20";
      this.tbxAuftragMaxZeilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAuftragMaxZeilen.TextChanged += new System.EventHandler(this.tbxAuftragMaxZeilen_TextChanged);
      this.tbxAuftragMaxZeilen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAuftragMaxZeilen_KeyDown);
      // 
      // label24
      // 
      this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label24.Location = new System.Drawing.Point(12, 100);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(102, 35);
      this.label24.TabIndex = 23;
      this.label24.Text = "max. Anzeige\r\nZeilen:";
      this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAufOrt
      // 
      this.tbxAufOrt.AllowDrop = true;
      this.tbxAufOrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAufOrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAufOrt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAufOrt.Location = new System.Drawing.Point(404, 47);
      this.tbxAufOrt.Name = "tbxAufOrt";
      this.tbxAufOrt.Size = new System.Drawing.Size(199, 21);
      this.tbxAufOrt.TabIndex = 4;
      this.tbxAufOrt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAufOrt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAufOrt_KeyDown);
      this.tbxAufOrt.Enter += new System.EventHandler(this.tbxAufOrt_Enter);
      // 
      // label17
      // 
      this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label17.Location = new System.Drawing.Point(283, 43);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(94, 20);
      this.label17.TabIndex = 21;
      this.label17.Text = "Ort:";
      this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // mtbxAufDatumBis
      // 
      this.mtbxAufDatumBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.mtbxAufDatumBis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mtbxAufDatumBis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mtbxAufDatumBis.Location = new System.Drawing.Point(404, 77);
      this.mtbxAufDatumBis.Mask = "00/00/0000";
      this.mtbxAufDatumBis.Name = "mtbxAufDatumBis";
      this.mtbxAufDatumBis.PromptChar = '#';
      this.mtbxAufDatumBis.Size = new System.Drawing.Size(123, 21);
      this.mtbxAufDatumBis.TabIndex = 6;
      this.mtbxAufDatumBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.mtbxAufDatumBis.ValidatingType = typeof(System.DateTime);
      this.mtbxAufDatumBis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxAufDaumBix_KeyDown);
      this.mtbxAufDatumBis.Enter += new System.EventHandler(this.mtbxAufDaumBis_Enter);
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(12, 48);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(76, 20);
      this.label6.TabIndex = 17;
      this.label6.Text = "Kunde-Nr.:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // mtbxAufDatumVon
      // 
      this.mtbxAufDatumVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.mtbxAufDatumVon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mtbxAufDatumVon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mtbxAufDatumVon.Location = new System.Drawing.Point(129, 76);
      this.mtbxAufDatumVon.Mask = "00/00/0000";
      this.mtbxAufDatumVon.Name = "mtbxAufDatumVon";
      this.mtbxAufDatumVon.PromptChar = '#';
      this.mtbxAufDatumVon.Size = new System.Drawing.Size(123, 21);
      this.mtbxAufDatumVon.TabIndex = 5;
      this.mtbxAufDatumVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.mtbxAufDatumVon.ValidatingType = typeof(System.DateTime);
      this.mtbxAufDatumVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbxAufDatumVon_KeyDown);
      this.mtbxAufDatumVon.Enter += new System.EventHandler(this.mtbxAufDatumVon_Enter);
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(12, 15);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(97, 20);
      this.label7.TabIndex = 10;
      this.label7.Text = "Auftrag-Nr.:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(283, 77);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(86, 20);
      this.label8.TabIndex = 19;
      this.label8.Text = "Datum bis:";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAuftragNr
      // 
      this.tbxAuftragNr.AllowDrop = true;
      this.tbxAuftragNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAuftragNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAuftragNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAuftragNr.Location = new System.Drawing.Point(129, 12);
      this.tbxAuftragNr.Name = "tbxAuftragNr";
      this.tbxAuftragNr.Size = new System.Drawing.Size(123, 21);
      this.tbxAuftragNr.TabIndex = 1;
      this.tbxAuftragNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAuftragNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAuftragNr_KeyDown);
      this.tbxAuftragNr.Enter += new System.EventHandler(this.tbxAuftragNr_Enter);
      this.tbxAuftragNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAuftragNr_Validating);
      // 
      // tbxAufKundenNr
      // 
      this.tbxAufKundenNr.AllowDrop = true;
      this.tbxAufKundenNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAufKundenNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAufKundenNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAufKundenNr.Location = new System.Drawing.Point(129, 47);
      this.tbxAufKundenNr.Name = "tbxAufKundenNr";
      this.tbxAufKundenNr.Size = new System.Drawing.Size(123, 21);
      this.tbxAufKundenNr.TabIndex = 3;
      this.tbxAufKundenNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAufKundenNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAufKundenNr_KeyDown);
      this.tbxAufKundenNr.Enter += new System.EventHandler(this.tbxAufKundenNr_Enter);
      this.tbxAufKundenNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAufKundenNr_Validating);
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(283, 12);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(94, 20);
      this.label9.TabIndex = 12;
      this.label9.Text = "Name:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label10
      // 
      this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(12, 76);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(86, 20);
      this.label10.TabIndex = 13;
      this.label10.Text = "Datum von:";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAufName
      // 
      this.tbxAufName.AllowDrop = true;
      this.tbxAufName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAufName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAufName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAufName.Location = new System.Drawing.Point(404, 12);
      this.tbxAufName.Name = "tbxAufName";
      this.tbxAufName.Size = new System.Drawing.Size(199, 21);
      this.tbxAufName.TabIndex = 2;
      this.tbxAufName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxAufName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAufName_KeyDown);
      this.tbxAufName.Enter += new System.EventHandler(this.tbxAufName_Enter);
      // 
      // Form_Archiv_Auswahl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(642, 241);
      this.Controls.Add(this.pnlRechnungen);
      this.Controls.Add(this.pnlAufträge);
      this.Controls.Add(this.pnlAngebote);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(650, 275);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(650, 275);
      this.Name = "Form_Archiv_Auswahl";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Auswahl";
      this.pnlAngebote.ResumeLayout(false);
      this.pnlAngebote.PerformLayout();
      this.pnlRechnungen.ResumeLayout(false);
      this.pnlRechnungen.PerformLayout();
      this.pnlAufträge.ResumeLayout(false);
      this.pnlAufträge.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.MaskedTextBox mtbxAngDatumBis;
    private System.Windows.Forms.MaskedTextBox mtbxAngDatumVon;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbxAngKundenNr;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbxAngName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox tbxAngebotNr;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MaskedTextBox mtbxRechDatumBis;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.MaskedTextBox mtbxRechDatumVon;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox tbxRechnungNr;
    private System.Windows.Forms.TextBox tbxRechKundenNr;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.TextBox tbxRechName;
    public System.Windows.Forms.Panel pnlAngebote;
    public System.Windows.Forms.Panel pnlRechnungen;
    public System.Windows.Forms.Panel pnlAufträge;
    private System.Windows.Forms.MaskedTextBox mtbxAufDatumBis;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.MaskedTextBox mtbxAufDatumVon;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbxAuftragNr;
    private System.Windows.Forms.TextBox tbxAufKundenNr;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox tbxAufName;
    private System.Windows.Forms.TextBox tbxAngOrt;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.TextBox tbxRechOrt;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.TextBox tbxAufOrt;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.CheckBox cbxRechStorniert;
    private System.Windows.Forms.CheckBox cbxAngemahnt;
    private System.Windows.Forms.CheckBox cbxSchlussrechnung;
    private System.Windows.Forms.TextBox tbxAngebotMaxZeilen;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.TextBox tbxRechnungMaxZeilen;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.TextBox tbxAuftragMaxZeilen;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.TextBox tbxAngBV;
    private System.Windows.Forms.TextBox tbxRechBV;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.CheckBox cbxEinbehalt;
  }
}