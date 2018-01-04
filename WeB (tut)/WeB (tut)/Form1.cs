using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeB__tut_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)//This will check that if web browser can go back or not
                webBrowser1.GoBack();
        }

        private void goForwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = "WeB - Loading - " + toolStripTextBox1.Text;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Text = "WeB - " + webBrowser1.DocumentTitle;//this will display the title of webpage like this...
            toolStripTextBox1.Text = webBrowser1.Url.ToString();//this will set the text to the orignal url :) you will see how...
        }
    }
}
