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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ENTWICKLER-PC33\\SQL2019;Initial Catalog=AuftragApp;Integrated Security=True");
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;


        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {

            int i = 0;
            dataGridViewUser.Rows.Clear();
            cmm = new SqlCommand("SELECT * FROM [User]", con);
            con.Open(); 
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridViewUser.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();    


        }


        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewUser.Columns[e.ColumnIndex].Name;
            if (colName == "Bearbeiten")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.textUsername.Text = dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.textVorname.Text = dataGridViewUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.textNachname.Text = dataGridViewUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.textPasswort.Text = dataGridViewUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.textHandy.Text = dataGridViewUser.Rows[e.RowIndex].Cells[5].Value.ToString();

                userModule.bttnSpeichern.Enabled = false;
                userModule.bttnAktualisieren.Enabled = true;
                userModule.textUsername.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "Löschen")
            {
                if (MessageBox.Show("Bist du sicher", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    con.Open();
                    cmm = new SqlCommand("DELETE FROM [User] WHERE username LIKE '" + dataGridViewUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User war erfolgreich gelöscht!");
                  

                }

            }
            LoadUser();

        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule =  new UserModuleForm();
            userModule.bttnSpeichern.Enabled = true;
            userModule.bttnAktualisieren.Enabled = true;
            userModule.ShowDialog();
            LoadUser();
        }
    }
}
    