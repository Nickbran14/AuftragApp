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
    public partial class AuftragModuleForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;

        int menge = 0;


        public AuftragModuleForm()
        {
            InitializeComponent();
            LoadKunden();
            LoadArtikel();
        }

        private void pictureBoxSchliessen_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void LoadKunden()
        {

            int i = 0;
            dataGridViewKunden.Rows.Clear();
            cmm = new SqlCommand("SELECT Kundennummer, Vorname, Nachname, Anschrift, Email, Handynummer FROM Kunden WHERE CONCAT(Kundennummer, Vorname, Nachname, Anschrift, Email, Handynummer) LIKE '%"+textBoxSuchenKunden.Text+"%'", con);
            con.Open();
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewKunden.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();


        }

        public void LoadArtikel()
        {

            int i = 0;
            dataGridViewArt.Rows.Clear();
            cmm = new SqlCommand("SELECT * FROM [Artikel] WHERE CONCAT(ArtikelID, ArtikelName, Preis, ArtikelBeschreibung, ArtikelKategorie) LIKE '%" + textBoxSuchenArtikel.Text + "%' ", con);
            con.Open();
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewArt.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();


        }

        private void textBoxSuchenKunden_TextChanged(object sender, EventArgs e)
        {
            LoadKunden(); 
        }

        private void textBoxSuchenArtikel_TextChanged(object sender, EventArgs e)
        {
            LoadArtikel();
        }


        private void numericMenge_ValueChanged(object sender, EventArgs e)
        {

            getMenge(); 

            if(Convert.ToInt16(numericMenge.Value)> menge)
            {
                MessageBox.Show("Menge nicht genug", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericMenge.Value = numericMenge.Value - 1;
                return;

            }
            if(Convert.ToInt16(numericMenge.Text) > 0) 
            { 

            int Total = Convert.ToInt16(textPreis.Text) * Convert.ToInt16(numericMenge.Value);
            textTotal.Text = Total.ToString();
            }
        }

        private void dataGridViewKunden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textKundennummer.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[1].Value.ToString();
            textKundenname.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[2].Value.ToString() +" "+ dataGridViewKunden.Rows[e.RowIndex].Cells[3].Value.ToString();
            textEmail.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridViewArt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textArtID.Text = dataGridViewArt.Rows[e.RowIndex].Cells[1].Value.ToString();
            textArtName.Text = dataGridViewArt.Rows[e.RowIndex].Cells[2].Value.ToString();
            textPreis.Text = dataGridViewArt.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void bttnAuftragSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                if(textKundennummer.Text == "")
                {
                    MessageBox.Show("Bitte Kunden wählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;


                }
                if (textArtID.Text == "")
                {
                    MessageBox.Show("Bitte Artikel wählen", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;


                }


                if (MessageBox.Show("Bist du sicher?", "Auftrag wird gespeichert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("INSERT INTO [Aufträge] (Auftragsdatum, ArtikelID, Kundennummer, Menge, Betrag, Total) VALUES (@Auftragsdatum, @ArtikelID, @Kundennummer, @Menge, @Betrag, @Total)", con);
                    cmm.Parameters.AddWithValue("@Auftragsdatum", dateAuftrag.Value);
                    cmm.Parameters.AddWithValue("@ArtikelID", Convert.ToInt16(textArtID.Text));
                    cmm.Parameters.AddWithValue("@Kundennummer", Convert.ToInt16(textKundennummer.Text));
                    cmm.Parameters.AddWithValue("@Menge", Convert.ToInt16(numericMenge.Value));
                    cmm.Parameters.AddWithValue("@Betrag", Convert.ToInt16(textPreis.Text));
                    cmm.Parameters.AddWithValue("@Total",  Convert.ToInt16(textTotal.Text));

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Auftrag war erfolreich gespeichert.");

                    cmm = new SqlCommand("UPDATE [Artikel] SET Menge = (Menge-@Menge) WHERE ArtikelID LIKE '" + textArtID.Text + "'", con);
                    cmm.Parameters.AddWithValue("@Menge", Convert.ToInt16(numericMenge.Value));

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    Clear();
                    LoadArtikel();

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public void Clear()
        {
            textKundennummer.Clear();
            textKundenname.Clear();
            textEmail.Clear();

            textArtID.Clear();
            textArtName.Clear();

            textPreis.Clear();
            numericMenge.Value = 0;
            dateAuftrag.Value = DateTime.Now;
            textTotal.Clear();

        }

        private void bttnAuftragLöschen_Click(object sender, EventArgs e)
        {
            Clear();
            bttnAuftragSpeichern.Enabled = true;
            bttnAuftragAktualisieren.Enabled = false;


        }

        private void bttnAuftragAktualisieren_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Bist du sicher?", "Auftrag wird Aktualisiert", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmm = new SqlCommand("UPDATE [Aufträge] SET Auftragsdatum = @Auftragsdatum, ArtikelID = @ArtikelID, Kundennummer = @Kundennummer, Menge = @Menge, Betrag = @Betrag, Total = @Total WHERE ArtikelID LIKE '" + textArtID.Text + "'", con);
                    cmm.Parameters.AddWithValue("@Auftragsdatum", dateAuftrag.Value);
                    cmm.Parameters.AddWithValue("@ArtikelID", Convert.ToInt16(textArtID.Text));
                    cmm.Parameters.AddWithValue("@Kundennummer", Convert.ToInt16(textKundennummer.Text));
                    cmm.Parameters.AddWithValue("@Menge", Convert.ToInt16(numericMenge.Value));
                    cmm.Parameters.AddWithValue("@Betrag", Convert.ToInt16(textPreis.Text));
                    cmm.Parameters.AddWithValue("@Total", Convert.ToInt16(textTotal.Text));

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Auftrag war erfolreich aktualisiert.");
                    this.Dispose();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }


        public void getMenge()
        {
            cmm = new SqlCommand("SELECT Menge FROM [Artikel] WHERE ArtikelID = '" + textArtID.Text + "'", con);
            con.Open();
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                menge = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();


        }

        private void bttnAuftragLöschen_Click_1(object sender, EventArgs e)
        {

        }
    }



}
