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
    public partial class ArtikelForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;


        public ArtikelForm()
        {
            InitializeComponent();
            LoadArtikel();
        }

        public void LoadArtikel()
        {

            int i = 0;
            dataGridViewArt.Rows.Clear();
            cmm = new SqlCommand("SELECT * FROM [Artikel] WHERE CONCAT(ArtikelID, ArtikelName, Preis, ArtikelBeschreibung, ArtikelKategorie) LIKE '%"+textBoxSuchen.Text+"%' ", con);
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


        private void bttnAdd_Click(object sender, EventArgs e)
        {
            ArtikelModuleForm moduleForm = new ArtikelModuleForm();
            moduleForm.bttnSpeichern.Enabled = true;
            moduleForm.bttnAktualisieren.Enabled = false;
            moduleForm.ShowDialog();
            LoadArtikel();
        }

        private void dataGridViewArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewArt.Columns[e.ColumnIndex].Name;
            if (colName == "Bearbeiten")
            {
                ArtikelModuleForm artModule = new ArtikelModuleForm();
                artModule.textArtikelID.Text = dataGridViewArt.Rows[e.RowIndex].Cells[1].Value.ToString();
                artModule.textArtName.Text = dataGridViewArt.Rows[e.RowIndex].Cells[2].Value.ToString();
                artModule.textArtName.Text = dataGridViewArt.Rows[e.RowIndex].Cells[3].Value.ToString();
                artModule.textArtMenge.Text = dataGridViewArt.Rows[e.RowIndex].Cells[4].Value.ToString();
                artModule.textArtPreis.Text = dataGridViewArt.Rows[e.RowIndex].Cells[5].Value.ToString();
                artModule.textArtBeschreibung.Text = dataGridViewArt.Rows[e.RowIndex].Cells[6].Value.ToString();

                artModule.bttnSpeichern.Enabled = false;
                artModule.bttnAktualisieren.Enabled = true;
                artModule.textArtikelID.Enabled = false;
                artModule.ShowDialog();
            }
            else if (colName == "Löschen")
            {
                if (MessageBox.Show("Bist du sicher", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmm = new SqlCommand("DELETE FROM [Artikel] WHERE ArtikelID LIKE '" + dataGridViewArt.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Artikel war erfolgreich gelöscht!");


                }

            }
            LoadArtikel();
        }

        private void textBoxSuchen_TextChanged(object sender, EventArgs e)
        {
            LoadArtikel();
        }
    }
}
