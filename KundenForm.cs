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
    public partial class KundenForm : Form

    {
        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;


        public KundenForm()
        {
            InitializeComponent();
            LoadKunden();
        }

        private void dataGridViewKunden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewKunden.Columns[e.ColumnIndex].Name;
            if (colName == "Bearbeiten")
            {
                KundenModuleForm KundenModule = new KundenModuleForm();
                KundenModule.textKundennummer.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[1].Value.ToString();
                KundenModule.textVorname.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[2].Value.ToString();
                KundenModule.textNachname.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[3].Value.ToString();
                KundenModule.textAnschrift.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[4].Value.ToString();
                KundenModule.textPostzahl.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[5].Value.ToString();
                KundenModule.textOrt.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[6].Value.ToString();
                KundenModule.comboBoxLand.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[7].Value.ToString();
                KundenModule.textEmail.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[8].Value.ToString();
                KundenModule.textHandy.Text = dataGridViewKunden.Rows[e.RowIndex].Cells[5].Value.ToString();


                KundenModule.bttnSpeichern.Enabled = false;
                KundenModule.bttnAktualisieren.Enabled = true;
                KundenModule.textKundennummer.Enabled = false;
                KundenModule.ShowDialog();
            }
            else if (colName == "Löschen")
            {
                if (MessageBox.Show("Bist du sicher", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmm = new SqlCommand("DELETE FROM [Kunden] WHERE Kundennummer LIKE '" + dataGridViewKunden.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kunden war erfolgreich gelöscht!");


                }

            }
            LoadKunden();
        }

        public void LoadKunden()
        {

            int i = 0;
            dataGridViewKunden.Rows.Clear();
            cmm = new SqlCommand("SELECT * FROM Kunden", con);
            con.Open();
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewKunden.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            con.Close();


        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            KundenModuleForm KundenModule = new KundenModuleForm();
            KundenModule.bttnSpeichern.Enabled = true;
            KundenModule.bttnAktualisieren.Enabled = false;
            KundenModule.ShowDialog();
            LoadKunden();
        }
    }
}
