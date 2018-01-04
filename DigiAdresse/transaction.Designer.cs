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
            this.senderpincode = new System.Windows.Forms.TextBox();
            this.senderaddress = new System.Windows.Forms.TextBox();
            this.recieverpincode = new System.Windows.Forms.TextBox();
            this.recieveraddress = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.senderduid = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Receiverduid = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.recieveraddress);
            this.Controls.Add(this.recieverpincode);
            this.Controls.Add(this.senderaddress);
            this.Controls.Add(this.senderpincode);
            this.Name = "transaction";
            this.Text = "transaction";
            this.Load += new System.EventHandler(this.transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox senderpincode;
        private System.Windows.Forms.TextBox senderaddress;
        private System.Windows.Forms.TextBox recieverpincode;
        private System.Windows.Forms.TextBox recieveraddress;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox senderduid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox Receiverduid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
    }
}