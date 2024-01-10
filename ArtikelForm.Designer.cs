namespace AuftragApp1
{
    partial class ArtikelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtikelForm));
            this.dataGridViewArt = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bearbeiten = new System.Windows.Forms.DataGridViewImageColumn();
            this.Löschen = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxSuchen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArt)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArt
            // 
            this.dataGridViewArt.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewArt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewArt.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArt.ColumnHeadersHeight = 30;
            this.dataGridViewArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewArt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nummer,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Preis,
            this.Column3,
            this.Column5,
            this.Bearbeiten,
            this.Löschen});
            this.dataGridViewArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewArt.EnableHeadersVisualStyles = false;
            this.dataGridViewArt.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewArt.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewArt.Name = "dataGridViewArt";
            this.dataGridViewArt.Size = new System.Drawing.Size(984, 572);
            this.dataGridViewArt.TabIndex = 3;
            this.dataGridViewArt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArt_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSuchen);
            this.panel2.Controls.Add(this.bttnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 529);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 43);
            this.panel2.TabIndex = 4;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdd.Image")));
            this.bttnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnAdd.Location = new System.Drawing.Point(183, 4);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(29, 31);
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
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artikel verwalten";
            // 
            // Nummer
            // 
            this.Nummer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nummer.HeaderText = "Nummer";
            this.Nummer.Name = "Nummer";
            this.Nummer.Width = 83;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Artikel ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 84;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 67;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Menge";
            this.Column4.Name = "Column4";
            this.Column4.Width = 73;
            // 
            // Preis
            // 
            this.Preis.HeaderText = "Preis";
            this.Preis.Name = "Preis";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Beschreibung";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Kategorie";
            this.Column5.Name = "Column5";
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
            // textBoxSuchen
            // 
            this.textBoxSuchen.Location = new System.Drawing.Point(504, 10);
            this.textBoxSuchen.Name = "textBoxSuchen";
            this.textBoxSuchen.Size = new System.Drawing.Size(458, 24);
            this.textBoxSuchen.TabIndex = 11;
            this.textBoxSuchen.TextChanged += new System.EventHandler(this.textBoxSuchen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(447, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Suchen:";
            // 
            // ArtikelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewArt);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArtikelForm";
            this.Text = "ArtikelForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bttnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Bearbeiten;
        private System.Windows.Forms.DataGridViewImageColumn Löschen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSuchen;
    }
}