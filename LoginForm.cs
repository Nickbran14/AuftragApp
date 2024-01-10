using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuftragApp1
{
    public partial class LoginForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void checkBoxPasswort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswort.Checked == false)
                textPass.UseSystemPasswordChar = true;
            else 
                textPass.UseSystemPasswordChar = false;
        }

        private void TextLöschen_Click(object sender, EventArgs e)
        {
            textUser.Clear();
            textPass.Clear();
        }

        private void pictureBoxSchliessen_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("App Schliessen","Bestätigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cmm = new SqlCommand("SELECT username, passwort FROM [User] WHERE username = @username AND passwort = @passwort", con);
                cmm.Parameters.AddWithValue("@username", textUser.Text);
                cmm.Parameters.AddWithValue("@passwort", textPass.Text);
                con.Open();
                dr = cmm.ExecuteReader(); 
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Willkommen", "Zugang erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                    this.Hide();
                    MainForm main = new MainForm();
                    main.ShowDialog();
                    

                }
                else
                {

                    MessageBox.Show("Ungültige username oder passwort");
                    con.Close();
                }

                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
    }
}
