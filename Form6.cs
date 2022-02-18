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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            BindGrid();

        }
        private void BindGrid()
        {
            string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Member", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            DataView dv = new DataView(dt);
                            dv.RowFilter = "TeamID =" + int.Parse(Form1.selectedteamid);
                            DataTable d = dv.ToTable();
                            tabel.DataSource = d;
                        }
                    }
                }
            }
        }
private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void tabel_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.tabel.Rows[e.RowIndex];
                string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
                using (SqlConnection con = new SqlConnection(constring))
                {

                    
                    string del = "DELETE from Member Where MemberID='" + row.Cells["MemberID"].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(del, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(row.Cells["FirstName"].Value.ToString() + "Was deleted");
                    this.Hide();

                    this.Close();

                }
            
              }

            }

       
    }
}
