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
    public partial class Existing : Form
    {
        public static SqlConnection duid = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Documents\login_database.mdf;Integrated Security=True;Connect Timeout=30");
        public static string Myconnectionstring = "server=Evil-Hunter;user id=root;pwd=Root;database=digital";
        MySqlConnection duid1 = new MySqlConnection(Myconnectionstring);

        public Existing()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection duid1 = new MySqlConnection(Myconnectionstring);
            duid1.Open();

            try
            {
                MySqlCommand cmd = duid1.CreateCommand();
                MySqlCommand cmd1 = duid1.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd1.CommandType = CommandType.Text;

                cmd.CommandText = "select * from book3 ";
                cmd1.CommandText = "select * from allcolleges";
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
                da.Fill(dt);
                da1.Fill(dt1);
                foreach (DataRow dr in dt1.Rows)

                {

                    Receiverduid.Items.Add(dr["CollegeName"].ToString());



                    senderduid.Items.Add(dr["CollegeName"].ToString());

                }
                foreach (DataRow dr in dt.Rows)

                {

                    Receiverduid.Items.Add(dr["IFSC"].ToString());



                    senderduid.Items.Add(dr["IFSC"].ToString());

                }
            }
            catch
            {
                throw;
            }
            finally

            {
                if (duid1.State == ConnectionState.Open)
                {
                    duid1.Close();
                }
            }




        }

        private void senderduid_SelectedIndexChanged(object sender, EventArgs e)
        {
            duid1.Open();

            MySqlCommand cmd = duid1.CreateCommand();
            MySqlCommand cmd1 = duid1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Book3 where IFSC='" + senderduid.SelectedItem.ToString() + "'";
            cmd1.CommandText = "select * from allcolleges where CollegeName='" + senderduid.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da.Fill(dt);
            da1.Fill(dt1);
            foreach (DataRow dr in dt.Rows)

            {

                textIFSC1.Text = dr["﻿BANK"].ToString();

                senderaddress.Text = dr["ADDRESS"].ToString();

                textIFSC1.Text = dr["BRANCH"].ToString();

                textBox9.Text = dateTimePicker1.Value.ToString();

            }

            foreach (DataRow dr in dt1.Rows)

            {

                textIFSC1.Text = dr["﻿CollegeName"].ToString();

                senderaddress.Text = dr["State Name"].ToString();

                textIFSC1.Text = dr["District Name"].ToString();

                textBox9.Text = dateTimePicker1.Value.ToString();

            }




            duid1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            client c1 = new client();

            c1.ShowDialog();
        }

        private void Receiverduid_SelectedIndexChanged(object sender, EventArgs e)
        {
              duid1.Open();

            MySqlCommand cmd = duid1.CreateCommand();
            MySqlCommand cmd1 = duid1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;


            cmd.CommandText = "select * from Book3 where Name='" + Receiverduid.SelectedItem.ToString() + "'";

            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmd1);
            da.Fill(dt);
            da1.Fill(dt1);
            foreach (DataRow dr in dt.Rows)

            {

                recieverbank.Text = dr["NAME"].ToString();

                recieveraddress.Text = dr["ADDRESS"].ToString();

                textIFSC2.Text = dr["BRANCH"].ToString();

                textBox9.Text = dateTimePicker1.Value.ToString();

            }
            foreach (DataRow dr in dt1.Rows)

            {

                textIFSC1.Text = dr["﻿CollegeName"].ToString();

                senderaddress.Text = dr["State Name"].ToString();

                textIFSC1.Text = dr["District Name"].ToString();

                textBox9.Text = dateTimePicker1.Value.ToString();

            }



            duid.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            login l1 = new login();

            l1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            duid1.Open();

            MySqlCommand cmd = duid1.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Recieverdb values('" + textIFSC2.Text + "','" + recieverbank.Text + "','" + recieveraddress.Text + "','" + textBox8.Text + "','" + textIFSC1.Text + "','" + senderbank.Text + "','" + senderaddress.Text + "','" + textBox7.Text + "','" + textBox9.Text + "')";

            cmd.ExecuteNonQuery();

            MessageBox.Show("Record inserted Succesfully");

            duid1.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
