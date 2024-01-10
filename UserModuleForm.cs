using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AuftragApp1
{
    public partial class UserModuleForm : Form


    {
        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();

        public UserModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBoxSchliessen_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            try 
            {
                if(textPasswort.Text != textRePass.Text) 
                {
                    MessageBox.Show("Passwörter stimmen nicht überein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                
                }
                if(MessageBox.Show("Bist du sicher?", "User wird gespeichert", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cmm= new SqlCommand("INSERT INTO [User] (username, vorname, nachname, passwort, handynummer) VALUES (@username, @vorname, @nachname, @passwort, @handynummer)", con);
                    cmm.Parameters.AddWithValue("@username", textUsername.Text);
                    cmm.Parameters.AddWithValue("@vorname", textVorname.Text);
                    cmm.Parameters.AddWithValue("@nachname", textNachname.Text);
                    cmm.Parameters.AddWithValue("@passwort", textPasswort.Text);
                    cmm.Parameters.AddWithValue("@handynummer", textHandy.Text);

                    con.Open();
                    cmm.ExecuteNonQuery();  
                    con.Close();
                    MessageBox.Show("User war erfolreich gespeichert.");
                    Clear();
                }


                
            }
            catch (Exception ex) 
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void buttonLöschen_Click(object sender, EventArgs e)
        {
            Clear();
            bttnSpeichern.Enabled = true;
            bttnAktualisieren.Enabled = false;
        }

        public void Clear()
        {
            textUsername.Clear();
            textVorname.Clear();
            textNachname.Clear();
            textPasswort.Clear();
            textRePass.Clear();
            textHandy.Clear();

        }

        private void bttnAktualisieren_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPasswort.Text != textRePass.Text)
                {
                    MessageBox.Show("Passwörter stimmen nicht überein", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }


                if (MessageBox.Show("Bist du sicher?", "User wird Aktualisiert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("UPDATE [User] SET vorname = @vorname, nachname = @nachname, passwort = @passwort, handynummer = @handynummer WHERE username LIKE '"+textUsername.Text +"'", con);
                    cmm.Parameters.AddWithValue("@vorname", textVorname.Text);
                    cmm.Parameters.AddWithValue("@nachname", textNachname.Text);
                    cmm.Parameters.AddWithValue("@passwort", textPasswort.Text);
                    cmm.Parameters.AddWithValue("@handynummer", textHandy.Text);

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User war erfolreich aktualisiert.");
                    this.Dispose();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }


    }
}
