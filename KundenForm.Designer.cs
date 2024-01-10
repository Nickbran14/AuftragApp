namespace AuftragApp1
{
    partial class KundenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KundenForm));
            this.dataGridViewKunden = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anschrift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postleitzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Land = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bearbeiten = new System.Windows.Forms.DataGridViewImageColumn();
            this.Löschen = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunden)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKunden
            // 
            this.dataGridViewKunden.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewKunden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKunden.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
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
            this.Postleitzahl,
            this.Ort,
            this.Land,
            this.Email,
            this.Column4,
            this.Bearbeiten,
            this.Löschen});
            this.dataGridViewKunden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKunden.EnableHeadersVisualStyles = false;
            this.dataGridViewKunden.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKunden.Name = "dataGridViewKunden";
            this.dataGridViewKunden.Size = new System.Drawing.Size(1000, 611);
            this.dataGridViewKunden.TabIndex = 1;
            this.dataGridViewKunden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKunden_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.bttnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 576);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 35);
            this.panel2.TabIndex = 2;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdd.Image")));
            this.bttnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnAdd.Location = new System.Drawing.Point(147, 4);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(25, 25);
            this.bttnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnAdd.TabIndex = 10;
            this.bttnAdd.TabStop = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kunden verwalten";
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
            this.Anschrift.HeaderText = "Anschrift";
            this.Anschrift.Name = "Anschrift";
            // 
            // Postleitzahl
            // 
            this.Postleitzahl.HeaderText = "Postleitzahl";
            this.Postleitzahl.Name = "Postleitzahl";
            // 
            // Ort
            // 
            this.Ort.HeaderText = "Ort";
            this.Ort.Name = "Ort";
            // 
            // Land
            // 
            this.Land.HeaderText = "Land";
            this.Land.Name = "Land";
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Handynummer";
            this.Column4.Name = "Column4";
            this.Column4.Width = 117;
            // 
            // Bearbeiten
            // 
            this.Bearbeiten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bearbeiten.HeaderText = "";
            this.Bearbeiten.Image = ((System.Drawing.Image)(resources.GetObject("Bearbeiten.Image")));
            this.Bearbeiten.Name = "Bearbeiten";
            this.Bearbeiten.Width = 5;
            // 
            // Löschen
            // 
            this.Löschen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Löschen.HeaderText = "";
            this.Löschen.Image = ((System.Drawing.Image)(resources.GetObject("Löschen.Image")));
            this.Löschen.Name = "Löschen";
            this.Löschen.Width = 5;
            // 
            // KundenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewKunden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KundenForm";
            this.Text = "KundenForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKunden)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKunden;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bttnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anschrift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postleitzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Land;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Bearbeiten;
        private System.Windows.Forms.DataGridViewImageColumn Löschen;
    }
}