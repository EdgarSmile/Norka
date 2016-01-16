namespace Norka.Cockpit
{
  partial class Form_Cockpit_Auswahl
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cockpit_Auswahl));
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.tbxUmsatzProJahrKundeNr = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tbxUmsatzProJahrName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.pnlNettoUmsatzProJahrKunde = new System.Windows.Forms.Panel();
      this.cbxUmsatzProJahrJahrBis = new System.Windows.Forms.ComboBox();
      this.umsatzJahrBisBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsYears = new Norka.Cockpit.dsYears();
      this.cbxUmsatzProJahrJahrVon = new System.Windows.Forms.ComboBox();
      this.umsatzJahrVonBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.pnlAngeboteAufträgeRechnungen = new System.Windows.Forms.Panel();
      this.cbxAARJahrBis = new System.Windows.Forms.ComboBox();
      this.aARJahrBisBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cbxAARJahrVon = new System.Windows.Forms.ComboBox();
      this.aARJahrVonBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbxAARKundeNr = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.tbxAARKundeName = new System.Windows.Forms.TextBox();
      this.umsatzJahrVonTableAdapter = new Norka.Cockpit.dsYearsTableAdapters.UmsatzJahrVonTableAdapter();
      this.umsatzJahrBisTableAdapter = new Norka.Cockpit.dsYearsTableAdapters.UmsatzJahrBisTableAdapter();
      this.aARJahrVonTableAdapter = new Norka.Cockpit.dsYearsTableAdapters.AARJahrVonTableAdapter();
      this.aARJahrBisTableAdapter = new Norka.Cockpit.dsYearsTableAdapters.AARJahrBisTableAdapter();
      this.pnlNettoUmsatzProMonatKunde = new System.Windows.Forms.Panel();
      this.cbxUmsatzProMonatJahrBis = new System.Windows.Forms.ComboBox();
      this.cbxUmsatzProMonatJahrVon = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.tbxUmsatzProMonatKundeNr = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.tbxUmsatzProMonatName = new System.Windows.Forms.TextBox();
      this.pnlNettoUmsatzProJahrMonat = new System.Windows.Forms.Panel();
      this.cbxUmsatzProJahrMonatJahrBis = new System.Windows.Forms.ComboBox();
      this.cbxUmsatzProJahrMonatJahrVon = new System.Windows.Forms.ComboBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.pnlNettoUmsatzProJahrKunde.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.umsatzJahrBisBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsYears)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.umsatzJahrVonBindingSource)).BeginInit();
      this.pnlAngeboteAufträgeRechnungen.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.aARJahrBisBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.aARJahrVonBindingSource)).BeginInit();
      this.pnlNettoUmsatzProMonatKunde.SuspendLayout();
      this.pnlNettoUmsatzProJahrMonat.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOK.Location = new System.Drawing.Point(116, 173);
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
      this.btnCancel.Location = new System.Drawing.Point(263, 173);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(125, 30);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Abbrechen";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClear.Location = new System.Drawing.Point(410, 173);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(125, 30);
      this.btnClear.TabIndex = 3;
      this.btnClear.Text = "Auswahl löschen";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClear_KeyDown);
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(283, 53);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(86, 20);
      this.label4.TabIndex = 19;
      this.label4.Text = "Jahr bis:";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxUmsatzProJahrKundeNr
      // 
      this.tbxUmsatzProJahrKundeNr.AllowDrop = true;
      this.tbxUmsatzProJahrKundeNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxUmsatzProJahrKundeNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxUmsatzProJahrKundeNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxUmsatzProJahrKundeNr.Location = new System.Drawing.Point(129, 14);
      this.tbxUmsatzProJahrKundeNr.Name = "tbxUmsatzProJahrKundeNr";
      this.tbxUmsatzProJahrKundeNr.Size = new System.Drawing.Size(123, 21);
      this.tbxUmsatzProJahrKundeNr.TabIndex = 0;
      this.tbxUmsatzProJahrKundeNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxUmsatzProJahrKundeNr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngKundenNr_KeyDown);
      this.tbxUmsatzProJahrKundeNr.Enter += new System.EventHandler(this.tbxAngKundenNr_Enter);
      this.tbxUmsatzProJahrKundeNr.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAngKundenNr_Validating);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(12, 14);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 20);
      this.label2.TabIndex = 17;
      this.label2.Text = "Kunde-Nr.:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxUmsatzProJahrName
      // 
      this.tbxUmsatzProJahrName.AllowDrop = true;
      this.tbxUmsatzProJahrName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxUmsatzProJahrName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxUmsatzProJahrName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxUmsatzProJahrName.Location = new System.Drawing.Point(404, 12);
      this.tbxUmsatzProJahrName.Name = "tbxUmsatzProJahrName";
      this.tbxUmsatzProJahrName.Size = new System.Drawing.Size(199, 21);
      this.tbxUmsatzProJahrName.TabIndex = 1;
      this.tbxUmsatzProJahrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbxUmsatzProJahrName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxAngName_KeyDown_1);
      this.tbxUmsatzProJahrName.Enter += new System.EventHandler(this.tbxAngName_Enter);
      // 
      // label3
      // 
      this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(12, 52);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(86, 20);
      this.label3.TabIndex = 13;
      this.label3.Text = "Jahr von:";
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
      // pnlNettoUmsatzProJahrKunde
      // 
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.cbxUmsatzProJahrJahrBis);
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.cbxUmsatzProJahrJahrVon);
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.label2);
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.label4);
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.tbxUmsatzProJahrKundeNr);
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.label5);
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.label3);
      this.pnlNettoUmsatzProJahrKunde.Controls.Add(this.tbxUmsatzProJahrName);
      this.pnlNettoUmsatzProJahrKunde.Location = new System.Drawing.Point(12, 12);
      this.pnlNettoUmsatzProJahrKunde.Name = "pnlNettoUmsatzProJahrKunde";
      this.pnlNettoUmsatzProJahrKunde.Size = new System.Drawing.Size(630, 150);
      this.pnlNettoUmsatzProJahrKunde.TabIndex = 0;
      this.pnlNettoUmsatzProJahrKunde.Tag = "x";
      this.pnlNettoUmsatzProJahrKunde.Visible = false;
      // 
      // cbxUmsatzProJahrJahrBis
      // 
      this.cbxUmsatzProJahrJahrBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxUmsatzProJahrJahrBis.DataSource = this.umsatzJahrBisBindingSource;
      this.cbxUmsatzProJahrJahrBis.DisplayMember = "Jahr";
      this.cbxUmsatzProJahrJahrBis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxUmsatzProJahrJahrBis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxUmsatzProJahrJahrBis.FormattingEnabled = true;
      this.cbxUmsatzProJahrJahrBis.Location = new System.Drawing.Point(404, 51);
      this.cbxUmsatzProJahrJahrBis.Name = "cbxUmsatzProJahrJahrBis";
      this.cbxUmsatzProJahrJahrBis.Size = new System.Drawing.Size(121, 21);
      this.cbxUmsatzProJahrJahrBis.TabIndex = 22;
      this.cbxUmsatzProJahrJahrBis.ValueMember = "Jahr";
      // 
      // umsatzJahrBisBindingSource
      // 
      this.umsatzJahrBisBindingSource.DataMember = "UmsatzJahrBis";
      this.umsatzJahrBisBindingSource.DataSource = this.dsYears;
      // 
      // dsYears
      // 
      this.dsYears.DataSetName = "dsYears";
      this.dsYears.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // cbxUmsatzProJahrJahrVon
      // 
      this.cbxUmsatzProJahrJahrVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxUmsatzProJahrJahrVon.DataSource = this.umsatzJahrVonBindingSource;
      this.cbxUmsatzProJahrJahrVon.DisplayMember = "Jahr";
      this.cbxUmsatzProJahrJahrVon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxUmsatzProJahrJahrVon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxUmsatzProJahrJahrVon.FormattingEnabled = true;
      this.cbxUmsatzProJahrJahrVon.Location = new System.Drawing.Point(129, 51);
      this.cbxUmsatzProJahrJahrVon.Name = "cbxUmsatzProJahrJahrVon";
      this.cbxUmsatzProJahrJahrVon.Size = new System.Drawing.Size(121, 21);
      this.cbxUmsatzProJahrJahrVon.TabIndex = 22;
      this.cbxUmsatzProJahrJahrVon.ValueMember = "Jahr";
      // 
      // umsatzJahrVonBindingSource
      // 
      this.umsatzJahrVonBindingSource.DataMember = "UmsatzJahrVon";
      this.umsatzJahrVonBindingSource.DataSource = this.dsYears;
      // 
      // pnlAngeboteAufträgeRechnungen
      // 
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.cbxAARJahrBis);
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.cbxAARJahrVon);
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.label1);
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.label6);
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.tbxAARKundeNr);
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.label7);
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.label8);
      this.pnlAngeboteAufträgeRechnungen.Controls.Add(this.tbxAARKundeName);
      this.pnlAngeboteAufträgeRechnungen.Location = new System.Drawing.Point(12, 12);
      this.pnlAngeboteAufträgeRechnungen.Name = "pnlAngeboteAufträgeRechnungen";
      this.pnlAngeboteAufträgeRechnungen.Size = new System.Drawing.Size(630, 150);
      this.pnlAngeboteAufträgeRechnungen.TabIndex = 4;
      this.pnlAngeboteAufträgeRechnungen.Tag = "x";
      this.pnlAngeboteAufträgeRechnungen.Visible = false;
      // 
      // cbxAARJahrBis
      // 
      this.cbxAARJahrBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxAARJahrBis.DataSource = this.aARJahrBisBindingSource;
      this.cbxAARJahrBis.DisplayMember = "Jahr";
      this.cbxAARJahrBis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxAARJahrBis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxAARJahrBis.FormattingEnabled = true;
      this.cbxAARJahrBis.Location = new System.Drawing.Point(404, 51);
      this.cbxAARJahrBis.Name = "cbxAARJahrBis";
      this.cbxAARJahrBis.Size = new System.Drawing.Size(121, 21);
      this.cbxAARJahrBis.TabIndex = 22;
      this.cbxAARJahrBis.ValueMember = "Jahr";
      // 
      // aARJahrBisBindingSource
      // 
      this.aARJahrBisBindingSource.DataMember = "AARJahrBis";
      this.aARJahrBisBindingSource.DataSource = this.dsYears;
      // 
      // cbxAARJahrVon
      // 
      this.cbxAARJahrVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxAARJahrVon.DataSource = this.aARJahrVonBindingSource;
      this.cbxAARJahrVon.DisplayMember = "Jahr";
      this.cbxAARJahrVon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxAARJahrVon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxAARJahrVon.FormattingEnabled = true;
      this.cbxAARJahrVon.Location = new System.Drawing.Point(129, 51);
      this.cbxAARJahrVon.Name = "cbxAARJahrVon";
      this.cbxAARJahrVon.Size = new System.Drawing.Size(121, 21);
      this.cbxAARJahrVon.TabIndex = 22;
      this.cbxAARJahrVon.ValueMember = "Jahr";
      // 
      // aARJahrVonBindingSource
      // 
      this.aARJahrVonBindingSource.DataMember = "AARJahrVon";
      this.aARJahrVonBindingSource.DataSource = this.dsYears;
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 20);
      this.label1.TabIndex = 17;
      this.label1.Text = "Kunde-Nr.:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(283, 53);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(86, 20);
      this.label6.TabIndex = 19;
      this.label6.Text = "Jahr bis:";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAARKundeNr
      // 
      this.tbxAARKundeNr.AllowDrop = true;
      this.tbxAARKundeNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAARKundeNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAARKundeNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAARKundeNr.Location = new System.Drawing.Point(129, 14);
      this.tbxAARKundeNr.Name = "tbxAARKundeNr";
      this.tbxAARKundeNr.Size = new System.Drawing.Size(123, 21);
      this.tbxAARKundeNr.TabIndex = 0;
      this.tbxAARKundeNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label7
      // 
      this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(283, 12);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(94, 20);
      this.label7.TabIndex = 12;
      this.label7.Text = "Name:";
      this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label8
      // 
      this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(12, 52);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(86, 20);
      this.label8.TabIndex = 13;
      this.label8.Text = "Jahr von:";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxAARKundeName
      // 
      this.tbxAARKundeName.AllowDrop = true;
      this.tbxAARKundeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxAARKundeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxAARKundeName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxAARKundeName.Location = new System.Drawing.Point(404, 12);
      this.tbxAARKundeName.Name = "tbxAARKundeName";
      this.tbxAARKundeName.Size = new System.Drawing.Size(199, 21);
      this.tbxAARKundeName.TabIndex = 1;
      this.tbxAARKundeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // umsatzJahrVonTableAdapter
      // 
      this.umsatzJahrVonTableAdapter.ClearBeforeFill = true;
      // 
      // umsatzJahrBisTableAdapter
      // 
      this.umsatzJahrBisTableAdapter.ClearBeforeFill = true;
      // 
      // aARJahrVonTableAdapter
      // 
      this.aARJahrVonTableAdapter.ClearBeforeFill = true;
      // 
      // aARJahrBisTableAdapter
      // 
      this.aARJahrBisTableAdapter.ClearBeforeFill = true;
      // 
      // pnlNettoUmsatzProMonatKunde
      // 
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.cbxUmsatzProMonatJahrBis);
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.cbxUmsatzProMonatJahrVon);
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.label9);
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.label10);
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.tbxUmsatzProMonatKundeNr);
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.label11);
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.label12);
      this.pnlNettoUmsatzProMonatKunde.Controls.Add(this.tbxUmsatzProMonatName);
      this.pnlNettoUmsatzProMonatKunde.Location = new System.Drawing.Point(9, 11);
      this.pnlNettoUmsatzProMonatKunde.Name = "pnlNettoUmsatzProMonatKunde";
      this.pnlNettoUmsatzProMonatKunde.Size = new System.Drawing.Size(630, 150);
      this.pnlNettoUmsatzProMonatKunde.TabIndex = 5;
      this.pnlNettoUmsatzProMonatKunde.Tag = "x";
      this.pnlNettoUmsatzProMonatKunde.Visible = false;
      // 
      // cbxUmsatzProMonatJahrBis
      // 
      this.cbxUmsatzProMonatJahrBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxUmsatzProMonatJahrBis.DataSource = this.umsatzJahrBisBindingSource;
      this.cbxUmsatzProMonatJahrBis.DisplayMember = "Jahr";
      this.cbxUmsatzProMonatJahrBis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxUmsatzProMonatJahrBis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxUmsatzProMonatJahrBis.FormattingEnabled = true;
      this.cbxUmsatzProMonatJahrBis.Location = new System.Drawing.Point(404, 51);
      this.cbxUmsatzProMonatJahrBis.Name = "cbxUmsatzProMonatJahrBis";
      this.cbxUmsatzProMonatJahrBis.Size = new System.Drawing.Size(121, 21);
      this.cbxUmsatzProMonatJahrBis.TabIndex = 22;
      this.cbxUmsatzProMonatJahrBis.ValueMember = "Jahr";
      // 
      // cbxUmsatzProMonatJahrVon
      // 
      this.cbxUmsatzProMonatJahrVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxUmsatzProMonatJahrVon.DataSource = this.umsatzJahrVonBindingSource;
      this.cbxUmsatzProMonatJahrVon.DisplayMember = "Jahr";
      this.cbxUmsatzProMonatJahrVon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxUmsatzProMonatJahrVon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxUmsatzProMonatJahrVon.FormattingEnabled = true;
      this.cbxUmsatzProMonatJahrVon.Location = new System.Drawing.Point(129, 51);
      this.cbxUmsatzProMonatJahrVon.Name = "cbxUmsatzProMonatJahrVon";
      this.cbxUmsatzProMonatJahrVon.Size = new System.Drawing.Size(121, 21);
      this.cbxUmsatzProMonatJahrVon.TabIndex = 22;
      this.cbxUmsatzProMonatJahrVon.ValueMember = "Jahr";
      // 
      // label9
      // 
      this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(12, 14);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(76, 20);
      this.label9.TabIndex = 17;
      this.label9.Text = "Kunde-Nr.:";
      this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label10
      // 
      this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(283, 53);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(86, 20);
      this.label10.TabIndex = 19;
      this.label10.Text = "Jahr bis:";
      this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxUmsatzProMonatKundeNr
      // 
      this.tbxUmsatzProMonatKundeNr.AllowDrop = true;
      this.tbxUmsatzProMonatKundeNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxUmsatzProMonatKundeNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxUmsatzProMonatKundeNr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxUmsatzProMonatKundeNr.Location = new System.Drawing.Point(129, 14);
      this.tbxUmsatzProMonatKundeNr.Name = "tbxUmsatzProMonatKundeNr";
      this.tbxUmsatzProMonatKundeNr.Size = new System.Drawing.Size(123, 21);
      this.tbxUmsatzProMonatKundeNr.TabIndex = 0;
      this.tbxUmsatzProMonatKundeNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label11
      // 
      this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(283, 12);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(94, 20);
      this.label11.TabIndex = 12;
      this.label11.Text = "Name:";
      this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(12, 52);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(86, 20);
      this.label12.TabIndex = 13;
      this.label12.Text = "Jahr von:";
      this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // tbxUmsatzProMonatName
      // 
      this.tbxUmsatzProMonatName.AllowDrop = true;
      this.tbxUmsatzProMonatName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.tbxUmsatzProMonatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbxUmsatzProMonatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbxUmsatzProMonatName.Location = new System.Drawing.Point(404, 12);
      this.tbxUmsatzProMonatName.Name = "tbxUmsatzProMonatName";
      this.tbxUmsatzProMonatName.Size = new System.Drawing.Size(199, 21);
      this.tbxUmsatzProMonatName.TabIndex = 1;
      this.tbxUmsatzProMonatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // pnlNettoUmsatzProJahrMonat
      // 
      this.pnlNettoUmsatzProJahrMonat.Controls.Add(this.cbxUmsatzProJahrMonatJahrBis);
      this.pnlNettoUmsatzProJahrMonat.Controls.Add(this.cbxUmsatzProJahrMonatJahrVon);
      this.pnlNettoUmsatzProJahrMonat.Controls.Add(this.label14);
      this.pnlNettoUmsatzProJahrMonat.Controls.Add(this.label16);
      this.pnlNettoUmsatzProJahrMonat.Location = new System.Drawing.Point(6, 12);
      this.pnlNettoUmsatzProJahrMonat.Name = "pnlNettoUmsatzProJahrMonat";
      this.pnlNettoUmsatzProJahrMonat.Size = new System.Drawing.Size(630, 150);
      this.pnlNettoUmsatzProJahrMonat.TabIndex = 6;
      this.pnlNettoUmsatzProJahrMonat.Tag = "x";
      this.pnlNettoUmsatzProJahrMonat.Visible = false;
      // 
      // cbxUmsatzProJahrMonatJahrBis
      // 
      this.cbxUmsatzProJahrMonatJahrBis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxUmsatzProJahrMonatJahrBis.DataSource = this.umsatzJahrBisBindingSource;
      this.cbxUmsatzProJahrMonatJahrBis.DisplayMember = "Jahr";
      this.cbxUmsatzProJahrMonatJahrBis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxUmsatzProJahrMonatJahrBis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxUmsatzProJahrMonatJahrBis.FormattingEnabled = true;
      this.cbxUmsatzProJahrMonatJahrBis.Location = new System.Drawing.Point(404, 51);
      this.cbxUmsatzProJahrMonatJahrBis.Name = "cbxUmsatzProJahrMonatJahrBis";
      this.cbxUmsatzProJahrMonatJahrBis.Size = new System.Drawing.Size(121, 21);
      this.cbxUmsatzProJahrMonatJahrBis.TabIndex = 22;
      this.cbxUmsatzProJahrMonatJahrBis.ValueMember = "Jahr";
      // 
      // cbxUmsatzProJahrMonatJahrVon
      // 
      this.cbxUmsatzProJahrMonatJahrVon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.cbxUmsatzProJahrMonatJahrVon.DataSource = this.umsatzJahrVonBindingSource;
      this.cbxUmsatzProJahrMonatJahrVon.DisplayMember = "Jahr";
      this.cbxUmsatzProJahrMonatJahrVon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxUmsatzProJahrMonatJahrVon.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxUmsatzProJahrMonatJahrVon.FormattingEnabled = true;
      this.cbxUmsatzProJahrMonatJahrVon.Location = new System.Drawing.Point(129, 51);
      this.cbxUmsatzProJahrMonatJahrVon.Name = "cbxUmsatzProJahrMonatJahrVon";
      this.cbxUmsatzProJahrMonatJahrVon.Size = new System.Drawing.Size(121, 21);
      this.cbxUmsatzProJahrMonatJahrVon.TabIndex = 22;
      this.cbxUmsatzProJahrMonatJahrVon.ValueMember = "Jahr";
      // 
      // label14
      // 
      this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(283, 53);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(86, 20);
      this.label14.TabIndex = 19;
      this.label14.Text = "Jahr bis:";
      this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label16
      // 
      this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label16.Location = new System.Drawing.Point(12, 52);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(86, 20);
      this.label16.TabIndex = 13;
      this.label16.Text = "Jahr von:";
      this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Form_Cockpit_Auswahl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(634, 215);
      this.Controls.Add(this.pnlNettoUmsatzProJahrMonat);
      this.Controls.Add(this.pnlNettoUmsatzProMonatKunde);
      this.Controls.Add(this.pnlAngeboteAufträgeRechnungen);
      this.Controls.Add(this.pnlNettoUmsatzProJahrKunde);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(650, 250);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(650, 250);
      this.Name = "Form_Cockpit_Auswahl";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Auswahl";
      this.Load += new System.EventHandler(this.Form_Cockpit_Auswahl_Load);
      this.pnlNettoUmsatzProJahrKunde.ResumeLayout(false);
      this.pnlNettoUmsatzProJahrKunde.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.umsatzJahrBisBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsYears)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.umsatzJahrVonBindingSource)).EndInit();
      this.pnlAngeboteAufträgeRechnungen.ResumeLayout(false);
      this.pnlAngeboteAufträgeRechnungen.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.aARJahrBisBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.aARJahrVonBindingSource)).EndInit();
      this.pnlNettoUmsatzProMonatKunde.ResumeLayout(false);
      this.pnlNettoUmsatzProMonatKunde.PerformLayout();
      this.pnlNettoUmsatzProJahrMonat.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbxUmsatzProJahrKundeNr;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbxUmsatzProJahrName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    public System.Windows.Forms.Panel pnlNettoUmsatzProJahrKunde;
    private System.Windows.Forms.ComboBox cbxUmsatzProJahrJahrVon;


    private System.Windows.Forms.ComboBox cbxUmsatzProJahrJahrBis;
    
    public System.Windows.Forms.Panel pnlAngeboteAufträgeRechnungen;
    private System.Windows.Forms.ComboBox cbxAARJahrBis;
    private System.Windows.Forms.ComboBox cbxAARJahrVon;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbxAARKundeNr;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox tbxAARKundeName;
    private dsYears dsYears;
    private System.Windows.Forms.BindingSource umsatzJahrVonBindingSource;
    private Norka.Cockpit.dsYearsTableAdapters.UmsatzJahrVonTableAdapter umsatzJahrVonTableAdapter;
    private System.Windows.Forms.BindingSource umsatzJahrBisBindingSource;
    private Norka.Cockpit.dsYearsTableAdapters.UmsatzJahrBisTableAdapter umsatzJahrBisTableAdapter;
    private System.Windows.Forms.BindingSource aARJahrVonBindingSource;
    private Norka.Cockpit.dsYearsTableAdapters.AARJahrVonTableAdapter aARJahrVonTableAdapter;
    private System.Windows.Forms.BindingSource aARJahrBisBindingSource;
    private Norka.Cockpit.dsYearsTableAdapters.AARJahrBisTableAdapter aARJahrBisTableAdapter;
    public System.Windows.Forms.Panel pnlNettoUmsatzProMonatKunde;
    private System.Windows.Forms.ComboBox cbxUmsatzProMonatJahrBis;
    private System.Windows.Forms.ComboBox cbxUmsatzProMonatJahrVon;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox tbxUmsatzProMonatKundeNr;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox tbxUmsatzProMonatName;
    public System.Windows.Forms.Panel pnlNettoUmsatzProJahrMonat;
    private System.Windows.Forms.ComboBox cbxUmsatzProJahrMonatJahrBis;
    private System.Windows.Forms.ComboBox cbxUmsatzProJahrMonatJahrVon;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label16;
  }
}