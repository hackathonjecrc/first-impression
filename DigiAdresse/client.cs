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
    public partial class client : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        

        public client()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void client_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
            
           
        }

        private void client_MouseMove(object sender, MouseEventArgs e)
        {
            if(_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void client_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Signout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                login l1 = new login();
                l1.ShowDialog();
                
                
                
                
                
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
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
            if(WindowState == FormWindowState.Normal)
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

        private void New_Click(object sender, EventArgs e)
        {
            this.Hide();
            Newdb db = new Newdb();
            db.ShowDialog();
        }

        private void Existing_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaction t1 = new transaction();
            t1.ShowDialog();
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            if (comboBox1.Text == "Sender UID")
            {
                SqlConnection tr = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select RecieverUID, Reciever Pincode, Reciever Address ,Reciever Name, Sender UID ,Sender Pincode ,Sender Address ,Sender Name FROM Recieverdb WHERE Sender UID like '" + textBox1.Text+"%'  ", tr);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
            else if(comboBox1.Text =="Sender Pincode")
            {
                SqlConnection tr = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select RecieverUID, Reciever Pincode, Reciever Address ,Reciever Name, Sender UID ,Sender Pincode ,Sender Address ,Sender Name FROM Recieverdb WHERE Sender Pincode like '" + textBox1.Text + "%'", tr);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
            else if(comboBox1.Text == "Reciever UID")
            {
                SqlConnection tr = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select RecieverUID, Reciever Pincode, Reciever Address ,Reciever Name, Sender UID ,Sender Pincode ,Sender Address ,Sender Name FROM Recieverdb WHERE RecieverUID  like '" + textBox1.Text + "%'", tr);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
            else if(comboBox1.Text =="Reciever Pincode")
            {
                SqlConnection tr = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Select RecieverUID, Reciever Pincode, Reciever Address ,Reciever Name, Sender UID ,Sender Pincode ,Sender Address ,Sender Name FROM Recieverdb WHERE Reciever Pincode like '" + textBox1.Text + "%'", tr);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection tr = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Recieverdb", tr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
    
    
 }
