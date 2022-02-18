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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            string line;
           

            string constring = @"Data Source=(Local);Initial Catalog=Medii Vizuale;Integrated Security=SSPI";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                line = "INSERT INTO Team Values ('"+TeamNameBox.Text + "','"+TeamLeaderBox.Text+"')";
                SqlCommand cmd = new SqlCommand(line, con);
                cmd.ExecuteNonQuery();
                con.Close();
                TeamNameBox.Text = "";
                TeamLeaderBox.Text = "";
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }   
            
        }
    }
}
