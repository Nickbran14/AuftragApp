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
    public partial class KundenModuleForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();


        public KundenModuleForm()
        {
            InitializeComponent();
        }

        private void bttnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (MessageBox.Show("Bist du sicher?", "Kunden wird gespeichert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("INSERT INTO [Kunden] (Kundennummer, Vorname, Nachname, Anschrift, Postzahl, Ort, Land, Email, Handynummer) VALUES (@Kundennummer, @vorname, @nachname, @Anschrift, @Postzahl, @Ort, @Land, @Email,  @handynummer)", con);
                    cmm.Parameters.AddWithValue("@Kundennummer", textKundennummer.Text);
                    cmm.Parameters.AddWithValue("@Vorname", textVorname.Text);
                    cmm.Parameters.AddWithValue("@Nachname", textNachname.Text);
                    cmm.Parameters.AddWithValue("@Anschrift", textAnschrift.Text);
                    cmm.Parameters.AddWithValue("@Postzahl", textPostzahl.Text);
                    cmm.Parameters.AddWithValue("@Ort", textOrt.Text);
                    cmm.Parameters.AddWithValue("@Land", comboBoxLand.Text);
                    cmm.Parameters.AddWithValue("@Email", textEmail.Text);
                    cmm.Parameters.AddWithValue("@Handynummer", textHandy.Text);

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kunden war erfolreich gespeichert.");
                    Clear();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void bttnLöschen_Click(object sender, EventArgs e)
        {
            Clear();
            bttnSpeichern.Enabled = true;
            bttnAktualisieren.Enabled = false;
        }

        public void Clear()
        {
            textKundennummer.Clear();
            textVorname.Clear();
            textNachname.Clear();
            textAnschrift.Clear();
            textPostzahl.Clear();
            textOrt.Clear();
            textEmail.Clear();
            textHandy.Clear();

        }

        private void pictureBoxSchliessen_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttnAktualisieren_Click(object sender, EventArgs e)
        {
            try
            {
              

                if (MessageBox.Show("Bist du sicher?", "User wird Aktualisiert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("UPDATE [Kunden] SET vorname = @vorname, nachname = @nachname, Anschrift = @Anschrift, Postzahl = @Postzahl, Ort = @Ort, Land = @Land, Email = @Email, handynummer = @handynummer WHERE Kundennummer LIKE '" + textKundennummer.Text + "'", con);
                    cmm.Parameters.AddWithValue("@vorname", textVorname.Text);
                    cmm.Parameters.AddWithValue("@nachname", textNachname.Text);
                    cmm.Parameters.AddWithValue("@Anschrift", textAnschrift.Text);
                    cmm.Parameters.AddWithValue("@Postzahl", textPostzahl.Text);
                    cmm.Parameters.AddWithValue("@Ort", textOrt.Text);
                    cmm.Parameters.AddWithValue("@Land", comboBoxLand.Text);
                    cmm.Parameters.AddWithValue("@Email", textEmail.Text);
                    cmm.Parameters.AddWithValue("@handynummer", textHandy.Text);

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kunden war erfolreich aktualisiert.");
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
