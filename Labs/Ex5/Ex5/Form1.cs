using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           if (textBox1.Text=="login@gmail.com")
            {
                if (textBox2.Text == "passwor")
                {
                    MessageBox.Show("OK");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '@')
                {
                    label1.Text = "true";



                }
                else
                    if(textBox1.Text[i] != '@')
                    label1.Text = "false";
            }
        }
    }
}
