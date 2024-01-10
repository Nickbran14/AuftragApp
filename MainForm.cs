using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuftragApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)

        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);  
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bttnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());

        }

        private void bttnKunden_Click(object sender, EventArgs e)
        {
            openChildForm(new KundenForm());
        }

        private void bttnKategorien_Click(object sender, EventArgs e)
        {
            openChildForm(new KategorienForm());
        }

        private void bttnArtikel_Click(object sender, EventArgs e)
        {
            openChildForm(new ArtikelForm());
        }

        private void bttnAufträge_Click(object sender, EventArgs e)
        {
            openChildForm(new AuftragForm());   
        }
    }
}
