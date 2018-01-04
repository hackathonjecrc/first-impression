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
    public partial class Newdb : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\digitaluid.mdf;Integrated Security=True;Connect Timeout=30");

        public Newdb()
        {
            InitializeComponent();
        }

        private void sendername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Digitaluid values ('" + digitaluid.Text + "','" + Pincode.Text+ "','" + senderaddress.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted Succesfully");
            digitaluid.Text = "";
            Pincode.Text = "";
            senderaddress.Text = "";
            sendername.Text = "";


        }


        private void minimize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string newguid = System.Guid.NewGuid().ToString().Replace("-","").ToUpper();
            digitaluid.Text = (newguid);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            client c1 = new client();
            c1.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l1 = new login();
            l1.ShowDialog();
            
        }
    }
}
