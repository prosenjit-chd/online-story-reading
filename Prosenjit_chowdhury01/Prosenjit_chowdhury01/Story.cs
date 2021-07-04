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
    public partial class Story : Form
    {
        SqlConnection con;

        int id;

      

        string ques;

        public List<int> quid;
        public List<string> qudeatil;

        string stid;

        public string t;

        int storyid;
        public Story()
        {
            InitializeComponent();
            quid = new List<int>();
            qudeatil = new List<string>();
        }

        private void Story_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\DDOOCP\Prosenjit_chowdhury01\Prosenjit_chowdhury01\DB_dataCollection.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Story", con);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            cmbshow.DataSource = dt;
            cmbshow.DisplayMember = "S_Id";
            cmbshow.ValueMember = "Story";
            lblshowstory.Text = "Select Story";


            int x = 0;
            storyid=0;
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(plyId) AS total FROM dbo.playerInfo", con);
            con.Open();
            SqlDataReader rd = cmd2.ExecuteReader();

            if (rd.Read())
            {
                x = int.Parse(rd["total"].ToString());
            }
            con.Close();
            if (x > 0)
            {
                SqlCommand cmd3 = new SqlCommand("SELECT S_Id FROM playerInfo", con);
                con.Open();
                SqlDataReader red = cmd3.ExecuteReader();
                if (red.Read())
                {
                    storyid = int.Parse(red["S_Id"].ToString());
                    cmbshow.SelectedIndex = storyid - 1;
                }

                con.Close();
            }
            else
            {
                User_Regestration f2 = new User_Regestration();

                f2.Show();
                this.Visible = false;

            }
        }

        private void cmbshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblshowstory.Text = cmbshow.SelectedValue.ToString();
            id = cmbshow.SelectedIndex + 1;
        }

        private void btnshowquestion_Click(object sender, EventArgs e)
        {
            lstshow.Items.Clear();


            SqlCommand cmd = new SqlCommand("SELECT * FROM Question WHERE Story_Id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                quid.Add(int.Parse(rd["Q_Id"].ToString()));
                qudeatil.Add(rd["Question"].ToString());
                lstshow.Items.Add(rd["Question"].ToString());
            }
            con.Close();
        }

        private void btnshowans_Click(object sender, EventArgs e)
        {
            try
            {
                ques = lstshow.SelectedItem.ToString();
                int id = 0;

                for (int i = 0; i <= qudeatil.Count(); i++)
                {
                    if (ques.Equals(qudeatil.ElementAt(i)))
                    {
                        id = quid.ElementAt(i);
                        break;
                    }

                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Join_collection WHERE Q_Id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                lblshowstory.Text = "";
                while (rd.Read())
                {
                    stid = rd["S_ID"].ToString();

                }
                con.Close();

                SqlCommand cmd2 = new SqlCommand("SELECT Story FROM Story where S_Id=@id ", con);
                cmd2.Parameters.AddWithValue("@id", int.Parse(stid));
                con.Open();
                SqlDataReader rd2 = cmd2.ExecuteReader();
                t = "";
                while (rd2.Read())
                {


                    t = rd2["Story"].ToString();
                }
                lblshowstory.Text = t;
                cmbshow.SelectedIndex = int.Parse(stid) - 1;
                con.Close();
                lstshow.Items.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Story_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message = "Do you want to save";
            const string caption = "Save???";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO playerInfo (S_Id) VALUES (@id)", con);
                cmd.Parameters.AddWithValue("@id",id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Saves Successfully");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void lstshow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblshowstory_Click(object sender, EventArgs e)
        {

        }
    }
}
