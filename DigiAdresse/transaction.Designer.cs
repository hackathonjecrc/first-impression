namespace DigiAdresse
{
    partial class transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.senderpincode = new System.Windows.Forms.TextBox();
            this.senderaddress = new System.Windows.Forms.TextBox();
            this.recieverpincode = new System.Windows.Forms.TextBox();
            this.recieveraddress = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.senderduid = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Receiverduid = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender Duid";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reciever Duid";
            // 
            // senderpincode
            // 
            this.senderpincode.Location = new System.Drawing.Point(249, 152);
            this.senderpincode.Name = "senderpincode";
            this.senderpincode.Size = new System.Drawing.Size(262, 20);
            this.senderpincode.TabIndex = 6;
            // 
            // senderaddress
            // 
            this.senderaddress.Location = new System.Drawing.Point(249, 205);
            this.senderaddress.Name = "senderaddress";
            this.senderaddress.Size = new System.Drawing.Size(262, 20);
            this.senderaddress.TabIndex = 7;
            // 
            // recieverpincode
            // 
            this.recieverpincode.Location = new System.Drawing.Point(866, 156);
            this.recieverpincode.Name = "recieverpincode";
            this.recieverpincode.Size = new System.Drawing.Size(262, 20);
            this.recieverpincode.TabIndex = 8;
            // 
            // recieveraddress
            // 
            this.recieveraddress.Location = new System.Drawing.Point(867, 208);
            this.recieveraddress.Name = "recieveraddress";
            this.recieveraddress.Size = new System.Drawing.Size(262, 20);
            this.recieveraddress.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(249, 258);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(866, 260);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(262, 20);
            this.textBox8.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sender Pincode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sender Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(756, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Reciever Pincode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(756, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Reciever Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sender\'s Address";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(756, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Reciever\'s Address";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(530, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 42);
            this.button3.TabIndex = 12;
            this.button3.Text = "Proceed Transaction";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // senderduid
            // 
            this.senderduid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.senderduid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.senderduid.FormattingEnabled = true;
            this.senderduid.Location = new System.Drawing.Point(140, 56);
            this.senderduid.Name = "senderduid";
            this.senderduid.Size = new System.Drawing.Size(303, 21);
            this.senderduid.TabIndex = 13;
            this.senderduid.SelectedIndexChanged += new System.EventHandler(this.senderduid_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sender Duid";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(866, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(756, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Reciever Duid";
            // 
            // Receiverduid
            // 
            this.Receiverduid.FormattingEnabled = true;
            this.Receiverduid.Location = new System.Drawing.Point(827, 56);
            this.Receiverduid.Name = "Receiverduid";
            this.Receiverduid.Size = new System.Drawing.Size(303, 21);
            this.Receiverduid.TabIndex = 14;
            this.Receiverduid.SelectedIndexChanged += new System.EventHandler(this.Receiverduid_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1248, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Signout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 368);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(592, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 13);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 544);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Receiverduid);
            this.Controls.Add(this.senderduid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.recieveraddress);
            this.Controls.Add(this.recieverpincode);
            this.Controls.Add(this.senderaddress);
            this.Controls.Add(this.senderpincode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "transaction";
            this.Text = "transaction";
            this.Load += new System.EventHandler(this.transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senderpincode;
        private System.Windows.Forms.TextBox senderaddress;
        private System.Windows.Forms.TextBox recieverpincode;
        private System.Windows.Forms.TextBox recieveraddress;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox senderduid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Receiverduid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
    }
}