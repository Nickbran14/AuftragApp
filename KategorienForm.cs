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
    public partial class KategorienForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;


        public KategorienForm()
        {
            InitializeComponent();
            LoadKategorie();
        }

        public void LoadKategorie()
        {

            int i = 0;
            dataGridViewKat.Rows.Clear();
            cmm = new SqlCommand("SELECT * FROM [Kategorien]", con);
            con.Open();
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewKat.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();


        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            KategorienModuleForm moduleForm =new KategorienModuleForm();   
            moduleForm.bttnSpeichern.Enabled = true;
            moduleForm.bttnAktualisieren.Enabled = false;
            moduleForm.ShowDialog();
            LoadKategorie();
        }

        private void dataGridViewKat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewKat.Columns[e.ColumnIndex].Name;
            if (colName == "Bearbeiten")
            {
                KategorienModuleForm KatModule = new KategorienModuleForm();
                KatModule.textKatID.Text = dataGridViewKat.Rows[e.RowIndex].Cells[1].Value.ToString();
                KatModule.textKatName.Text = dataGridViewKat.Rows[e.RowIndex].Cells[2].Value.ToString();
                KatModule.textKatBeschreibung.Text = dataGridViewKat.Rows[e.RowIndex].Cells[3].Value.ToString();


                KatModule.bttnSpeichern.Enabled = false;
                KatModule.bttnAktualisieren.Enabled = true;
                KatModule.textKatID.Enabled = false;
                KatModule.ShowDialog();
            }
            else if (colName == "Löschen")
            {
                if (MessageBox.Show("Bist du sicher", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmm = new SqlCommand("DELETE FROM [Kategorien] WHERE KatName LIKE '" + dataGridViewKat.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kategorie war erfolgreich gelöscht!");


                }

            }
            LoadKategorie();
        }
    }
}
