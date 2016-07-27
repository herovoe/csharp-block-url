using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace urlBlocker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            //If you get an error it will be probably system permission exception.So run it as administrator. 
            try
            {
                //We're creating our path variable.
                String path = @"C:\Windows\System32\drivers\etc\hosts";
                //We're creating our StreamWriter to write in a file.
                StreamWriter sw = new StreamWriter(path, true);
                //For blocking some urls we have to add a line as 'Server site or url'
                string blocking_site = "\n 127.0.0.1 google.com \n 127.0.0.1 facebook.com \n 127.0.0.1 twitter.com \n 127.0.0.1 youtube.com";
                //We're writing our lines in hosts file.
                sw.Write(blocking_site);
                //Closing StreamWriter
                sw.Close();
                MessageBox.Show("Complete!");
            }
            catch(Exception ex) { MessageBox.Show("Try to run program as adminisrator. {0}" , ex.ToString());  }
        }
    }
}
