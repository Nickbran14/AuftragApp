namespace AuftragApp1
{
    partial class UserModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModuleForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxSchliessen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textVorname = new System.Windows.Forms.TextBox();
            this.textPasswort = new System.Windows.Forms.TextBox();
            this.textHandy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelVorname = new System.Windows.Forms.Label();
            this.labelPasswort = new System.Windows.Forms.Label();
            this.labelHandy = new System.Windows.Forms.Label();
            this.labelNachname = new System.Windows.Forms.Label();
            this.textNachname = new System.Windows.Forms.TextBox();
            this.bttnSpeichern = new System.Windows.Forms.Button();
            this.bttnAktualisieren = new System.Windows.Forms.Button();
            this.bttnLöschen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textRePass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchliessen)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(575, 35);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Verwaltung";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(180, 65);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(316, 20);
            this.textUsername.TabIndex = 1;
            // 
            // textVorname
            // 
            this.textVorname.Location = new System.Drawing.Point(180, 115);
            this.textVorname.Name = "textVorname";
            this.textVorname.Size = new System.Drawing.Size(316, 20);
            this.textVorname.TabIndex = 2;
            // 
            // textPasswort
            // 
            this.textPasswort.Location = new System.Drawing.Point(180, 215);
            this.textPasswort.Name = "textPasswort";
            this.textPasswort.Size = new System.Drawing.Size(316, 20);
            this.textPasswort.TabIndex = 4;
            // 
            // textHandy
            // 
            this.textHandy.Location = new System.Drawing.Point(180, 315);
            this.textHandy.Name = "textHandy";
            this.textHandy.Size = new System.Drawing.Size(316, 20);
            this.textHandy.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // labelVorname
            // 
            this.labelVorname.AutoSize = true;
            this.labelVorname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVorname.Location = new System.Drawing.Point(69, 119);
            this.labelVorname.Name = "labelVorname";
            this.labelVorname.Size = new System.Drawing.Size(63, 16);
            this.labelVorname.TabIndex = 6;
            this.labelVorname.Text = "Vorname:";
            // 
            // labelPasswort
            // 
            this.labelPasswort.AutoSize = true;
            this.labelPasswort.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswort.Location = new System.Drawing.Point(69, 219);
            this.labelPasswort.Name = "labelPasswort";
            this.labelPasswort.Size = new System.Drawing.Size(62, 16);
            this.labelPasswort.TabIndex = 7;
            this.labelPasswort.Text = "Passwort:";
            // 
            // labelHandy
            // 
            this.labelHandy.AutoSize = true;
            this.labelHandy.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHandy.Location = new System.Drawing.Point(69, 319);
            this.labelHandy.Name = "labelHandy";
            this.labelHandy.Size = new System.Drawing.Size(95, 16);
            this.labelHandy.TabIndex = 8;
            this.labelHandy.Text = "Handynummer:";
            // 
            // labelNachname
            // 
            this.labelNachname.AutoSize = true;
            this.labelNachname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNachname.Location = new System.Drawing.Point(69, 168);
            this.labelNachname.Name = "labelNachname";
            this.labelNachname.Size = new System.Drawing.Size(72, 16);
            this.labelNachname.TabIndex = 10;
            this.labelNachname.Text = "Nachname:";
            // 
            // textNachname
            // 
            this.textNachname.Location = new System.Drawing.Point(180, 165);
            this.textNachname.Name = "textNachname";
            this.textNachname.Size = new System.Drawing.Size(316, 20);
            this.textNachname.TabIndex = 3;
            // 
            // bttnSpeichern
            // 
            this.bttnSpeichern.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnSpeichern.FlatAppearance.BorderSize = 0;
            this.bttnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSpeichern.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSpeichern.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnSpeichern.Location = new System.Drawing.Point(180, 362);
            this.bttnSpeichern.Name = "bttnSpeichern";
            this.bttnSpeichern.Size = new System.Drawing.Size(100, 40);
            this.bttnSpeichern.TabIndex = 6;
            this.bttnSpeichern.Text = "Speichern";
            this.bttnSpeichern.UseVisualStyleBackColor = false;
            this.bttnSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // bttnAktualisieren
            // 
            this.bttnAktualisieren.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnAktualisieren.FlatAppearance.BorderSize = 0;
            this.bttnAktualisieren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAktualisieren.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAktualisieren.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAktualisieren.Location = new System.Drawing.Point(288, 362);
            this.bttnAktualisieren.Name = "bttnAktualisieren";
            this.bttnAktualisieren.Size = new System.Drawing.Size(100, 40);
            this.bttnAktualisieren.TabIndex = 7;
            this.bttnAktualisieren.Text = "Aktualisieren";
            this.bttnAktualisieren.UseVisualStyleBackColor = false;
            this.bttnAktualisieren.Click += new System.EventHandler(this.bttnAktualisieren_Click);
            // 
            // bttnLöschen
            // 
            this.bttnLöschen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttnLöschen.FlatAppearance.BorderSize = 0;
            this.bttnLöschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLöschen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLöschen.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnLöschen.Location = new System.Drawing.Point(396, 362);
            this.bttnLöschen.Name = "bttnLöschen";
            this.bttnLöschen.Size = new System.Drawing.Size(100, 40);
            this.bttnLöschen.TabIndex = 8;
            this.bttnLöschen.Text = "Löschen";
            this.bttnLöschen.UseVisualStyleBackColor = false;
            this.bttnLöschen.Click += new System.EventHandler(this.buttonLöschen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 48);
            this.label3.TabIndex = 12;
            this.label3.Text = "Passwort erneut \r\neingeben:\r\n\r\n";
            // 
            // textRePass
            // 
            this.textRePass.Location = new System.Drawing.Point(180, 265);
            this.textRePass.Name = "textRePass";
            this.textRePass.Size = new System.Drawing.Size(316, 20);
            this.textRePass.TabIndex = 11;
            // 
            // UserModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textRePass);
            this.Controls.Add(this.bttnLöschen);
            this.Controls.Add(this.bttnAktualisieren);
            this.Controls.Add(this.bttnSpeichern);
            this.Controls.Add(this.labelNachname);
            this.Controls.Add(this.textNachname);
            this.Controls.Add(this.labelHandy);
            this.Controls.Add(this.labelPasswort);
            this.Controls.Add(this.labelVorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textHandy);
            this.Controls.Add(this.textPasswort);
            this.Controls.Add(this.textVorname);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.panel1);
            this.Name = "UserModuleForm";
            this.Text = "UserModuleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSchliessen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelVorname;
        private System.Windows.Forms.Label labelPasswort;
        private System.Windows.Forms.Label labelHandy;
        private System.Windows.Forms.Label labelNachname;
        private System.Windows.Forms.PictureBox pictureBoxSchliessen;
        public System.Windows.Forms.Button bttnSpeichern;
        public System.Windows.Forms.Button bttnAktualisieren;
        public System.Windows.Forms.Button bttnLöschen;
        public System.Windows.Forms.TextBox textUsername;
        public System.Windows.Forms.TextBox textVorname;
        public System.Windows.Forms.TextBox textPasswort;
        public System.Windows.Forms.TextBox textHandy;
        public System.Windows.Forms.TextBox textNachname;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textRePass;
    }
}