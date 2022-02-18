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

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Team", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
      
        public void delmem(string col)
        {
            string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                string del = "DELETE from Member Where TeamID='" + col + "'";
                SqlCommand cmd = new SqlCommand(del, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
                using (SqlConnection con = new SqlConnection(constring))
                {

                    delmem(row.Cells["TeamID"].Value.ToString());
                    string del = "DELETE from Team Where TeamID='" + row.Cells["TeamID"].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(del, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    MessageBox.Show( row.Cells["TeamName"].Value.ToString() + "Was deleted");
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    this.Close();

                }
               



            }
        }
    }
}
