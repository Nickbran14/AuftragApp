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
    public partial class KategorienModuleForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();


        public KategorienModuleForm()
        {
            InitializeComponent();
        }

        private void bttnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bist du sicher?", "Kategorie wird gespeichert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("INSERT INTO [Kategorien] (KatID, KatName, KatBeschreibung) VALUES (@KatID, @KatName, @KatBeschreibung)", con);
                    cmm.Parameters.AddWithValue("@KatID", textKatID.Text);
                    cmm.Parameters.AddWithValue("@KatName", textKatName.Text);
                    cmm.Parameters.AddWithValue("@KatBeschreibung", textKatBeschreibung.Text);
           

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kategorie war erfolreich gespeichert.");
                    Clear();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void Clear()
        {
            textKatID.Clear();
            textKatName.Clear();
            textKatBeschreibung.Clear();

        }

        private void bttnLöschen_Click(object sender, EventArgs e)
        {
            Clear();
            bttnSpeichern.Enabled = true;
            bttnAktualisieren.Enabled = false;

        }

        private void pictureBoxSchliessen_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttnAktualisieren_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Bist du sicher?", "Kategorie wird Aktualisiert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("UPDATE [Kategorien] SET KatID = @KatID, KatName = @KatName, KatBeschreibung = @KatBeschreibung WHERE KatName LIKE '" + textKatName.Text + "'", con);
                    cmm.Parameters.AddWithValue("@KatID", textKatID.Text);
                    cmm.Parameters.AddWithValue("@KatName", textKatName.Text);
                    cmm.Parameters.AddWithValue("@KatBeschreibung", textKatBeschreibung.Text);


                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kategorie war erfolreich aktualisiert.");
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
