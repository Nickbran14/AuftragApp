namespace AuftragApp1
{
    partial class KategorienModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategorienModuleForm));
            this.bttnLöschen = new System.Windows.Forms.Button();
            this.bttnAktualisieren = new System.Windows.Forms.Button();
            this.bttnSpeichern = new System.Windows.Forms.Button();
            this.labelBeschreibung = new System.Windows.Forms.Label();
            this.textKatBeschreibung = new System.Windows.Forms.TextBox();
            this.labelKatName = new System.Windows.Forms.Label();
            this.labelKategorieID = new System.Windows.Forms.Label();
            this.textKatName = new System.Windows.Forms.TextBox();
            this.textKatID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSchliessen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchliessen)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnLöschen
            // 
            this.bttnLöschen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnLöschen.FlatAppearance.BorderSize = 0;
            this.bttnLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLöschen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLöschen.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnLöschen.Location = new System.Drawing.Point(396, 241);
            this.bttnLöschen.Name = "bttnLöschen";
            this.bttnLöschen.Size = new System.Drawing.Size(100, 40);
            this.bttnLöschen.TabIndex = 24;
            this.bttnLöschen.Text = "Löschen";
            this.bttnLöschen.UseVisualStyleBackColor = false;
            this.bttnLöschen.Click += new System.EventHandler(this.bttnLöschen_Click);
            // 
            // bttnAktualisieren
            // 
            this.bttnAktualisieren.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnAktualisieren.FlatAppearance.BorderSize = 0;
            this.bttnAktualisieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAktualisieren.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAktualisieren.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAktualisieren.Location = new System.Drawing.Point(288, 241);
            this.bttnAktualisieren.Name = "bttnAktualisieren";
            this.bttnAktualisieren.Size = new System.Drawing.Size(100, 40);
            this.bttnAktualisieren.TabIndex = 22;
            this.bttnAktualisieren.Text = "Aktualisieren";
            this.bttnAktualisieren.UseVisualStyleBackColor = false;
            this.bttnAktualisieren.Click += new System.EventHandler(this.bttnAktualisieren_Click);
            // 
            // bttnSpeichern
            // 
            this.bttnSpeichern.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnSpeichern.FlatAppearance.BorderSize = 0;
            this.bttnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSpeichern.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSpeichern.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnSpeichern.Location = new System.Drawing.Point(180, 241);
            this.bttnSpeichern.Name = "bttnSpeichern";
            this.bttnSpeichern.Size = new System.Drawing.Size(100, 40);
            this.bttnSpeichern.TabIndex = 20;
            this.bttnSpeichern.Text = "Speichern";
            this.bttnSpeichern.UseVisualStyleBackColor = false;
            this.bttnSpeichern.Click += new System.EventHandler(this.bttnSpeichern_Click);
            // 
            // labelBeschreibung
            // 
            this.labelBeschreibung.AutoSize = true;
            this.labelBeschreibung.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeschreibung.Location = new System.Drawing.Point(69, 192);
            this.labelBeschreibung.Name = "labelBeschreibung";
            this.labelBeschreibung.Size = new System.Drawing.Size(88, 16);
            this.labelBeschreibung.TabIndex = 26;
            this.labelBeschreibung.Text = "Beschreibung:";
            // 
            // textKatBeschreibung
            // 
            this.textKatBeschreibung.Location = new System.Drawing.Point(180, 189);
            this.textKatBeschreibung.Name = "textKatBeschreibung";
            this.textKatBeschreibung.Size = new System.Drawing.Size(316, 20);
            this.textKatBeschreibung.TabIndex = 16;
            // 
            // labelKatName
            // 
            this.labelKatName.AutoSize = true;
            this.labelKatName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKatName.Location = new System.Drawing.Point(69, 143);
            this.labelKatName.Name = "labelKatName";
            this.labelKatName.Size = new System.Drawing.Size(45, 16);
            this.labelKatName.TabIndex = 21;
            this.labelKatName.Text = "Name:";
            // 
            // labelKategorieID
            // 
            this.labelKategorieID.AutoSize = true;
            this.labelKategorieID.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKategorieID.Location = new System.Drawing.Point(69, 93);
            this.labelKategorieID.Name = "labelKategorieID";
            this.labelKategorieID.Size = new System.Drawing.Size(83, 16);
            this.labelKategorieID.TabIndex = 18;
            this.labelKategorieID.Text = "Kategorie ID:";
            // 
            // textKatName
            // 
            this.textKatName.Location = new System.Drawing.Point(180, 139);
            this.textKatName.Name = "textKatName";
            this.textKatName.Size = new System.Drawing.Size(316, 20);
            this.textKatName.TabIndex = 15;
            // 
            // textKatID
            // 
            this.textKatID.Location = new System.Drawing.Point(180, 89);
            this.textKatID.Name = "textKatID";
            this.textKatID.Size = new System.Drawing.Size(316, 20);
            this.textKatID.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBoxSchliessen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 35);
            this.panel1.TabIndex = 13;
            // 
            // pictureBoxSchliessen
            // 
            this.pictureBoxSchliessen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSchliessen.Image")));
            this.pictureBoxSchliessen.Location = new System.Drawing.Point(550, 0);
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
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorie verwaltung";
            // 
            // KategorienModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 312);
            this.Controls.Add(this.bttnLöschen);
            this.Controls.Add(this.bttnAktualisieren);
            this.Controls.Add(this.bttnSpeichern);
            this.Controls.Add(this.labelBeschreibung);
            this.Controls.Add(this.textKatBeschreibung);
            this.Controls.Add(this.labelKatName);
            this.Controls.Add(this.labelKategorieID);
            this.Controls.Add(this.textKatName);
            this.Controls.Add(this.textKatID);
            this.Controls.Add(this.panel1);
            this.Name = "KategorienModuleForm";
            this.Text = "KategorienModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchliessen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bttnLöschen;
        public System.Windows.Forms.Button bttnAktualisieren;
        public System.Windows.Forms.Button bttnSpeichern;
        private System.Windows.Forms.Label labelBeschreibung;
        public System.Windows.Forms.TextBox textKatBeschreibung;
        private System.Windows.Forms.Label labelKatName;
        private System.Windows.Forms.Label labelKategorieID;
        public System.Windows.Forms.TextBox textKatName;
        public System.Windows.Forms.TextBox textKatID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxSchliessen;
        private System.Windows.Forms.Label label1;
    }
}