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
    public partial class ArtikelModuleForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;

        public ArtikelModuleForm()
        {
            InitializeComponent();
            LoadKategorie();
        }

        private void pictureBoxSchliessen_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadKategorie()
        {
            comboKategorie.Items.Clear();
            cmm = new SqlCommand("SELECT KatName FROM [Kategorien]", con);
            con.Open();
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                comboKategorie.Items.Add(dr[0].ToString()); 

            }
            dr.Close(); 
            con.Close();

        }

        private void bttnSpeichern_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bist du sicher?", "Artikel wird gespeichert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("INSERT INTO [Artikel] (ArtikelID, ArtikelName, Menge, Preis, ArtikelBeschreibung, ArtikelKategorie) VALUES (@ArtikelID, @ArtikelName, @Menge, @Preis, @ArtikelBeschreibung, @ArtikelKategorie)", con);
                    cmm.Parameters.AddWithValue("@ArtikelID", textArtikelID.Text);
                    cmm.Parameters.AddWithValue("@ArtikelName", textArtName.Text);
                    cmm.Parameters.AddWithValue("@Menge", Convert.ToInt16(textArtMenge.Text));
                    cmm.Parameters.AddWithValue("@Preis", Convert.ToInt16(textArtPreis.Text));
                    cmm.Parameters.AddWithValue("@ArtikelBeschreibung", textArtBeschreibung.Text);
                    cmm.Parameters.AddWithValue("@ArtikelKategorie", comboKategorie.Text);

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Artikel war erfolreich gespeichert.");
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
            textArtName.Clear();
            textArtMenge.Clear();
            textArtPreis.Clear();
            textArtBeschreibung.Clear();
            comboKategorie.Text = "";
        }

        private void bttnLöschen_Click(object sender, EventArgs e)
        {
            Clear();
            bttnSpeichern.Enabled = true;
            bttnAktualisieren.Enabled = false;

        }

        private void bttnAktualisieren_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bist du sicher?", "Artikel wird Aktualisiert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("UPDATE [Artikel] SET ArtikelName = @ArtikelName, Menge = @Menge, Preis = @Preis, ArtikelBeschreibung = @ArtikelBeschreibung WHERE ArtikelID LIKE '" + textArtikelID.Text + "'", con);
                    cmm.Parameters.AddWithValue("@ArtikelName", textArtName.Text);
                    cmm.Parameters.AddWithValue("@Menge", Convert.ToInt16(textArtMenge.Text));
                    cmm.Parameters.AddWithValue("@Preis", Convert.ToInt16(textArtPreis.Text));
                    cmm.Parameters.AddWithValue("@ArtikelBeschreibung", textArtBeschreibung.Text);
                    cmm.Parameters.AddWithValue("@ArtikelKategorie", comboKategorie.Text);

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Artikel war erfolreich aktualisiert.");
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
