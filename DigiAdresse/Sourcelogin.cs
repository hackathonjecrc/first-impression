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
    public partial class Sourcelogin : Form
    {
        public Sourcelogin()
        {
            InitializeComponent();
        }
        static int attempt = 3;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from loginsource where username='"+txtusername.Text+"' and password='"+txtpassword.Text+"' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(attempt==0)
            {
                if (attempt == 0)

                {

                    lbl_Msg.Text = ("ALL 3 ATTEMPTS HAVE FAILED - CONTACT ADMIN");

                    return;

                }
            }
            if (dt.Rows[0][0].ToString()=="1" )
            {
                SqlDataAdapter sda1 = new SqlDataAdapter("Select Role from loginsource where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "' ", con);
                DataTable dt1 = new DataTable();
                sda.Fill(dt1);
                if(dt1.Rows[0][0].ToString()=="Admin")
                {
                    this.Hide();

                }
                if(dt1.Rows[0][0].ToString()=="User")
                {
                    this.Hide();
                    client c1 = new client();
                    c1.Show();
                }
                
            }
            else
            {
                MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");

                lbl_Msg.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");

                --attempt;

                txtpassword.Clear();

                txtusername.Clear();
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sourcelogin_Load(object sender, EventArgs e)
        {

        }
    }
}
