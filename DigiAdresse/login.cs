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



namespace DigiAdresse
{
    public partial class login : Form
    {
        static int attempt = 3;
        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                lbl_Msg.Text = ("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");
                return;
            }
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from login where Username=@usr and Password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", txtpassword.Text);
            scmd.Parameters.AddWithValue("@pwd", txtusername.Text);
            scn.Open();
            if (scmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                this.Hide();
                client c1 = new client();
                c1.ShowDialog();
            }
            else
            {


                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
                lbl_Msg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
                txtpassword.Clear();
                txtusername.Clear();
            }
            scn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Msg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
