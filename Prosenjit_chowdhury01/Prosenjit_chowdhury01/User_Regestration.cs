using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;


namespace Prosenjit_chowdhury01
{
    public partial class User_Regestration : Form
    {
        SqlConnection con;

        public User_Regestration()
        {
            InitializeComponent();
        }

        private void btnconfram_Click(object sender, EventArgs e)
        {

            
            string txt1 = txtname.Text;
            string txt2 = txtemail.Text;
            SqlCommand cmd = new SqlCommand("INSERT INTO playerInfo(Name, Email) VALUES(@uN,@uE) ", con);
            cmd.Parameters.AddWithValue("@uN", txt1);
            cmd.Parameters.AddWithValue("@uE", txt2);

            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            Story f1 = new Story();
            f1.Show();
            this.Hide();

        }

        private void User_Regestration_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\DDOOCP\Prosenjit_chowdhury01\Prosenjit_chowdhury01\DB_dataCollection.mdf;Integrated Security=True");
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
