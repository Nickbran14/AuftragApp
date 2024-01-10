namespace AuftragApp1
{
    partial class AuftragModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuftragModuleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSchliessen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textKundenname = new System.Windows.Forms.TextBox();
            this.textKundennummer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSuchenKunden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKunden = new System.Windows.Forms.DataGridView();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anschrift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericMenge = new System.Windows.Forms.NumericUpDown();
            this.bttnAuftragLöschen = new System.Windows.Forms.Button();
            this.bttnAuftragAktualisieren = new System.Windows.Forms.Button();
            this.bttnAuftragSpeichern = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateAuftrag = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textArtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.textPreis = new System.Windows.Forms.TextBox();
            this.textArtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSuchenArtikel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewArt = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchliessen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunden)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMenge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBoxSchliessen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 35);
            this.panel1.TabIndex = 30;
            // 
            // pictureBoxSchliessen
            // 
            this.pictureBoxSchliessen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchliessen.Image")));
            this.pictureBoxSchliessen.Location = new System.Drawing.Point(959, 0);
            this.pictureBoxSchliessen.Name = "pictureBoxSchliessen";
            this.pictureBoxSchliessen.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSchliessen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSchliessen.TabIndex = 14;
            this.pictureBoxSchliessen.TabStop = false;
            this.pictureBoxSchliessen.Click += new System.EventHandler(this.pictureBoxSchliessen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auftrag Verwaltung";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textKundenname);
            this.panel2.Controls.Add(this.textKundennummer);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxSuchenKunden);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridViewKunden);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 497);
            this.panel2.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(16, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Email:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(119, 377);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(205, 24);
            this.textEmail.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(16, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Kundenname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(16, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Kundennummer:";
            // 
            // textKundenname
            // 
            this.textKundenname.Location = new System.Drawing.Point(119, 343);
            this.textKundenname.Name = "textKundenname";
            this.textKundenname.Size = new System.Drawing.Size(205, 24);
            this.textKundenname.TabIndex = 37;
            // 
            // textKundennummer
            // 
            this.textKundennummer.Location = new System.Drawing.Point(119, 308);
            this.textKundennummer.Name = "textKundennummer";
            this.textKundennummer.Size = new System.Drawing.Size(205, 24);
            this.textKundennummer.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Suchen:";
            // 
            // textBoxSuchenKunden
            // 
            this.textBoxSuchenKunden.Location = new System.Drawing.Point(119, 242);
            this.textBoxSuchenKunden.Name = "textBoxSuchenKunden";
            this.textBoxSuchenKunden.Size = new System.Drawing.Size(205, 24);
            this.textBoxSuchenKunden.TabIndex = 34;
            this.textBoxSuchenKunden.TextChanged += new System.EventHandler(this.textBoxSuchenKunden_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kunden Info:";
            // 
            // dataGridViewKunden
            // 
            this.dataGridViewKunden.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewKunden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKunden.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKunden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKunden.ColumnHeadersHeight = 30;
            this.dataGridViewKunden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewKunden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nummer,
            this.Column1,
            this.Column2,
            this.Nachname,
            this.Anschrift,
            this.Email,
            this.Column4});
            this.dataGridViewKunden.EnableHeadersVisualStyles = false;
            this.dataGridViewKunden.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKunden.Name = "dataGridViewKunden";
            this.dataGridViewKunden.RowHeadersVisible = false;
            this.dataGridViewKunden.Size = new System.Drawing.Size(460, 229);
            this.dataGridViewKunden.TabIndex = 32;
            this.dataGridViewKunden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKunden_CellClick);
            // 
            // Nummer
            // 
            this.Nummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nummer.HeaderText = "Nummer";
            this.Nummer.Name = "Nummer";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Kundennummer";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Vorname";
            this.Column2.Name = "Column2";
            this.Column2.Width = 85;
            // 
            // Nachname
            // 
            this.Nachname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            this.Nachname.Width = 94;
            // 
            // Anschrift
            // 
            this.Anschrift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Anschrift.HeaderText = "Anschrift";
            this.Anschrift.Name = "Anschrift";
            this.Anschrift.Width = 82;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.Width = 69;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Handynummer";
            this.Column4.Name = "Column4";
            this.Column4.Width = 117;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.numericMenge);
            this.panel3.Controls.Add(this.bttnAuftragLöschen);
            this.panel3.Controls.Add(this.bttnAuftragAktualisieren);
            this.panel3.Controls.Add(this.bttnAuftragSpeichern);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.dateAuftrag);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textArtName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textTotal);
            this.panel3.Controls.Add(this.textPreis);
            this.panel3.Controls.Add(this.textArtID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBoxSuchenArtikel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridViewArt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(460, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 497);
            this.panel3.TabIndex = 33;
            // 
            // numericMenge
            // 
            this.numericMenge.Location = new System.Drawing.Point(401, 343);
            this.numericMenge.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericMenge.Name = "numericMenge";
            this.numericMenge.Size = new System.Drawing.Size(111, 24);
            this.numericMenge.TabIndex = 52;
            this.numericMenge.ValueChanged += new System.EventHandler(this.numericMenge_ValueChanged);
            // 
            // bttnAuftragLöschen
            // 
            this.bttnAuftragLöschen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnAuftragLöschen.FlatAppearance.BorderSize = 0;
            this.bttnAuftragLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAuftragLöschen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAuftragLöschen.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAuftragLöschen.Location = new System.Drawing.Point(332, 433);
            this.bttnAuftragLöschen.Name = "bttnAuftragLöschen";
            this.bttnAuftragLöschen.Size = new System.Drawing.Size(100, 40);
            this.bttnAuftragLöschen.TabIndex = 51;
            this.bttnAuftragLöschen.Text = "Auftrag Löschen";
            this.bttnAuftragLöschen.UseVisualStyleBackColor = false;
            this.bttnAuftragLöschen.Click += new System.EventHandler(this.bttnAuftragLöschen_Click_1);
            // 
            // bttnAuftragAktualisieren
            // 
            this.bttnAuftragAktualisieren.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnAuftragAktualisieren.FlatAppearance.BorderSize = 0;
            this.bttnAuftragAktualisieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAuftragAktualisieren.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAuftragAktualisieren.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAuftragAktualisieren.Location = new System.Drawing.Point(224, 433);
            this.bttnAuftragAktualisieren.Name = "bttnAuftragAktualisieren";
            this.bttnAuftragAktualisieren.Size = new System.Drawing.Size(100, 40);
            this.bttnAuftragAktualisieren.TabIndex = 50;
            this.bttnAuftragAktualisieren.Text = "Auftrag Aktualisieren";
            this.bttnAuftragAktualisieren.UseVisualStyleBackColor = false;
            this.bttnAuftragAktualisieren.Click += new System.EventHandler(this.bttnAuftragAktualisieren_Click);
            // 
            // bttnAuftragSpeichern
            // 
            this.bttnAuftragSpeichern.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnAuftragSpeichern.FlatAppearance.BorderSize = 0;
            this.bttnAuftragSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAuftragSpeichern.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAuftragSpeichern.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAuftragSpeichern.Location = new System.Drawing.Point(116, 433);
            this.bttnAuftragSpeichern.Name = "bttnAuftragSpeichern";
            this.bttnAuftragSpeichern.Size = new System.Drawing.Size(100, 40);
            this.bttnAuftragSpeichern.TabIndex = 49;
            this.bttnAuftragSpeichern.Text = "Auftrag Speichern";
            this.bttnAuftragSpeichern.UseVisualStyleBackColor = false;
            this.bttnAuftragSpeichern.Click += new System.EventHandler(this.bttnAuftragSpeichern_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(12, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "Datum:";
            // 
            // dateAuftrag
            // 
            this.dateAuftrag.CustomFormat = "dd/MM/yyyy";
            this.dateAuftrag.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateAuftrag.Location = new System.Drawing.Point(101, 382);
            this.dateAuftrag.Name = "dateAuftrag";
            this.dateAuftrag.Size = new System.Drawing.Size(205, 24);
            this.dateAuftrag.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(12, 348);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 46;
            this.label12.Text = "Artikelname:";
            // 
            // textArtName
            // 
            this.textArtName.Location = new System.Drawing.Point(101, 343);
            this.textArtName.Name = "textArtName";
            this.textArtName.Size = new System.Drawing.Size(205, 24);
            this.textArtName.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(340, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(340, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Menge:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(340, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Preis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(12, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Artikel ID:";
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(401, 379);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(111, 24);
            this.textTotal.TabIndex = 40;
            // 
            // textPreis
            // 
            this.textPreis.Location = new System.Drawing.Point(401, 308);
            this.textPreis.Name = "textPreis";
            this.textPreis.Size = new System.Drawing.Size(111, 24);
            this.textPreis.TabIndex = 38;
            // 
            // textArtID
            // 
            this.textArtID.Location = new System.Drawing.Point(101, 308);
            this.textArtID.Name = "textArtID";
            this.textArtID.Size = new System.Drawing.Size(205, 24);
            this.textArtID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(9, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Suchen:";
            // 
            // textBoxSuchenArtikel
            // 
            this.textBoxSuchenArtikel.Location = new System.Drawing.Point(177, 242);
            this.textBoxSuchenArtikel.Name = "textBoxSuchenArtikel";
            this.textBoxSuchenArtikel.Size = new System.Drawing.Size(205, 24);
            this.textBoxSuchenArtikel.TabIndex = 35;
            this.textBoxSuchenArtikel.TextChanged += new System.EventHandler(this.textBoxSuchenArtikel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(9, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Artikel Info:";
            // 
            // dataGridViewArt
            // 
            this.dataGridViewArt.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewArt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewArt.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewArt.ColumnHeadersHeight = 30;
            this.dataGridViewArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewArt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Preis,
            this.Column3,
            this.Column5});
            this.dataGridViewArt.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewArt.EnableHeadersVisualStyles = false;
            this.dataGridViewArt.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewArt.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewArt.Name = "dataGridViewArt";
            this.dataGridViewArt.RowHeadersVisible = false;
            this.dataGridViewArt.Size = new System.Drawing.Size(524, 229);
            this.dataGridViewArt.TabIndex = 4;
            this.dataGridViewArt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArt_CellClick);
            this.dataGridViewArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArt_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nummer";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Artikel ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 84;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 67;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Menge";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 73;
            // 
            // Preis
            // 
            this.Preis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            this.Preis.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Beschreibung";
            this.Column3.Name = "Column3";
            this.Column3.Width = 110;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Kategorie";
            this.Column5.Name = "Column5";
            this.Column5.Width = 89;
            // 
            // AuftragModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuftragModuleForm";
            this.Text = "AuftragModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchliessen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunden)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMenge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxSchliessen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewKunden;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anschrift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSuchenKunden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSuchenArtikel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button bttnAuftragLöschen;
        public System.Windows.Forms.Button bttnAuftragAktualisieren;
        public System.Windows.Forms.Button bttnAuftragSpeichern;
        public System.Windows.Forms.TextBox textKundennummer;
        public System.Windows.Forms.TextBox textKundenname;
        public System.Windows.Forms.TextBox textTotal;
        public System.Windows.Forms.TextBox textPreis;
        public System.Windows.Forms.TextBox textEmail;
        public System.Windows.Forms.NumericUpDown numericMenge;
        public System.Windows.Forms.TextBox textArtName;
        public System.Windows.Forms.TextBox textArtID;
        public System.Windows.Forms.DateTimePicker dateAuftrag;
    }
}