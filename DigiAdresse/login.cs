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
using MySql.Data.MySqlClient;


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
            try
            {
                MySqlConnection scn = new MySqlConnection();
                scn.ConnectionString = @"server=Evil-Hunter;database=digital;uid=root;pwd=Root;";
                MySqlCommand scmd = new MySqlCommand("select * from login1 where Username='" + this.txtusername.Text + "' and Password='" + this.txtpassword.Text + "'", scn);

                scn.Open();
                MySqlDataReader myreader;
                myreader = scmd.ExecuteReader();
                int count = 0;
                while (myreader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password are correct");
                    this.Hide();
                    client c1 = new client();
                    c1.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Incorrect data");
                }
                else
                {
                    MessageBox.Show("Incoreect");

                }
                scn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
