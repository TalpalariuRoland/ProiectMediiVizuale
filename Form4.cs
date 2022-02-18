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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //RoleIDBox.Items.Add();
            Bindlist();

        }
        private void Bindlist()
        {
            string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Role", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            
                            for(int i=1;i<=dt.Rows.Count;i++)
                            RoleIDBox.Items.Add(i.ToString());
                        }
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Addbutt_Click(object sender, EventArgs e)
        {
            string line;


            string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                line = "INSERT INTO Member Values ('" + FnameBox.Text + "','" + LNameBox.Text + "','"+ int.Parse(Form1.selectedteamid)+"','"+ int.Parse(RoleIDBox.SelectedItem.ToString())+"')";
                SqlCommand cmd = new SqlCommand(line, con);
                cmd.ExecuteNonQuery();
                con.Close();
                FnameBox.Text = "";
                LNameBox.Text = "";
                
                this.Hide();
               
                this.Close();
            }
        }
    }
}
