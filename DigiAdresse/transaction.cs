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
    public partial class transaction : Form
    {
        public static SqlConnection duid = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
        
        public transaction()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            duid.Open();
            SqlCommand cmd = duid.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Digitaluid where Digitaluid='"+senderduid.ToString()+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                senderpincode.Text = dr["Sender's Pincode"].ToString();
                senderaddress.Text = dr["Sender's Address"].ToString();
            }

            duid.Close();
        }

        private void senderduid_SelectedIndexChanged(object sender, EventArgs e)
        {
            duid.Open();
            SqlCommand cmd = duid.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Digitaluid where Digitaluid='" + senderduid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                senderpincode.Text = dr["Sender's Pincode"].ToString();
                senderaddress.Text = dr["Sender's Address"].ToString();
                textBox1.Text = dr["Digitaluid"].ToString();
                textBox2.Text = dateTimePicker1.Value.ToString();
            }


            duid.Close();
        }

        private void transaction_Load(object sender, EventArgs e)
        {
            duid.Open();
            SqlCommand cmd = duid.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Digitaluid ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Receiverduid.Items.Add(dr["Digitaluid"].ToString());
                    
                senderduid.Items.Add(dr["Digitaluid"].ToString());
            }

            duid.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Receiverduid_SelectedIndexChanged(object sender, EventArgs e)
        {
            duid.Open();
            SqlCommand cmd = duid.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Digitaluid where Digitaluid='" + Receiverduid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                recieverpincode.Text = dr["Sender's Pincode"].ToString();
                recieveraddress.Text = dr["Sender's Address"].ToString();
                textBox3.Text = dr["Digitaluid"].ToString();
                textBox2.Text = dateTimePicker1.Value.ToString();
            }

            duid.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            client c1 = new client();
            c1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l1 = new login();
            l1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            duid.Open();
            SqlCommand cmd = duid.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Recieverdb values('"+textBox3.Text+"','"+recieverpincode.Text+"','"+textBox8.Text+"','"+recieveraddress.Text+"','"+textBox1.Text+"','"+senderpincode.Text+"','"+textBox7.Text+"','"+senderaddress.Text+"','"+textBox2.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted Succesfully");
            duid.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToString();

        }
    }
}
