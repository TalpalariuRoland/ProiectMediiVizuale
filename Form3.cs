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
    public partial class Form3 : Form
    {
        public Form3()
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
                            dv.RowFilter = "TeamID ="+int.Parse(Form1.selectedteamid);
                            dataGridView2.DataSource = dv;
                        }
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string ID;
        public void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            
            Form4 f4 = new Form4();
            f4.ShowDialog();
            
        }

        private void delmember_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
