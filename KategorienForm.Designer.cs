namespace AuftragApp1
{
    partial class KategorienForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategorienForm));
            this.dataGridViewKat = new System.Windows.Forms.DataGridView();
            this.Nummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bearbeiten = new System.Windows.Forms.DataGridViewImageColumn();
            this.Löschen = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnAdd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKat)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKat
            // 
            this.dataGridViewKat.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewKat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewKat.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewKat.ColumnHeadersHeight = 30;
            this.dataGridViewKat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewKat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nummer,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Bearbeiten,
            this.Löschen});
            this.dataGridViewKat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKat.EnableHeadersVisualStyles = false;
            this.dataGridViewKat.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKat.Name = "dataGridViewKat";
            this.dataGridViewKat.Size = new System.Drawing.Size(984, 572);
            this.dataGridViewKat.TabIndex = 2;
            this.dataGridViewKat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKat_CellContentClick);
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
            this.Column1.HeaderText = "Kategorie ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 105;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Bezeichnung";
            this.Column4.Name = "Column4";
            this.Column4.Width = 104;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.bttnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Location = new System.Drawing.Point(0, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 35);
            this.panel2.TabIndex = 3;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttnAdd.Image")));
            this.bttnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnAdd.Location = new System.Drawing.Point(157, 3);
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
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorien verwalten";
            // 
            // KategorienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewKat);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KategorienForm";
            this.Text = "KategorienForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Bearbeiten;
        private System.Windows.Forms.DataGridViewImageColumn Löschen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bttnAdd;
        private System.Windows.Forms.Label label1;
    }
}