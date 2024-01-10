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
    public partial class AuftragForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;


        public AuftragForm()
        {
            InitializeComponent();
            LoadAuftrag();
        }

        public void LoadAuftrag()
        {
            int i = 0;
            dataGridViewAuftrag.Rows.Clear();
            cmm = new SqlCommand("SELECT Auftragsnummer, Auftragsdatum, A.ArtikelID, Art.ArtikelName, A.Kundennummer, K.Nachname, A.Menge, Art.Preis, A.Total FROM [Aufträge] AS A JOIN Kunden AS K ON A.Kundennummer=K.Kundennummer JOIN Artikel as Art ON A.ArtikelID=Art.ArtikelID", con);
            con.Open();
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewAuftrag.Rows.Add(i, dr[0].ToString(), Convert.ToDateTime(dr[1].ToString()).ToString("dd/MM/yyyy"), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            con.Close();



        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            AuftragModuleForm auftragModuleForm = new AuftragModuleForm();
            auftragModuleForm.ShowDialog();
            LoadAuftrag();
        }

        private void dataGridViewAuftrag_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewAuftrag.Columns[e.ColumnIndex].Name;

            if (colName == "Löschen")
            {
                if (MessageBox.Show("Bist du sicher", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmm = new SqlCommand("DELETE FROM [Aufträge] WHERE Auftragsnummer LIKE '" + dataGridViewAuftrag.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Auftrag war erfolgreich gelöscht!");

                    cmm = new SqlCommand("UPDATE [Artikel] SET Menge = (Menge+@Menge) WHERE ArtikelID LIKE '" + dataGridViewAuftrag.Rows[e.RowIndex].Cells[3].Value.ToString() + "'", con);
                    cmm.Parameters.AddWithValue("@Menge", Convert.ToInt16(dataGridViewAuftrag.Rows[e.RowIndex].Cells[5].Value.ToString()));

                    con.Open();
                    cmm.ExecuteNonQuery();
                    con.Close();

                }

            }
            LoadAuftrag();
        }
    }
}
