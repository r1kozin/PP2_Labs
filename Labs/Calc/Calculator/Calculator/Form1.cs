using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Interface C = new Interface();
        public string operation = "";
        public Double value = 0;
        public bool operatorclick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operatorclick)
                result.Clear();
            operatorclick = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if (!result.Text.Contains(","))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }
        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                
                //button16.PerformClick();
                operation = b.Text;
                operatorclick = true;
                label.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operatorclick = true;
                label.Text = value + " " + operation;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";
        }


        private void button19_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            label.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int length = result.Text.Length - 1;
            string text = result.Text;
            result.Clear();
            for (int i = 0; i < length; i++)
            {
                result.Text = result.Text + text[i];
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (result.Text == "0")
            {
                return;
            }
            else
            {
                if (result.Text[0] == '-')
                {
                    result.Text = result.Text.Remove(0, 1);
                }
                else
                    result.Text = '-' + result.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Pow(Double.Parse(result.Text), 2)).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Sqrt(Double.Parse(result.Text))).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            result.Text = C.MemoryShow().ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            C.MemorySave(double.Parse(result.Text));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            C.Memory_Clear();
            result.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            C.M_Sum(double.Parse(result.Text));

        }

        private void button26_Click(object sender, EventArgs e)
        {
            C.M_Minus(double.Parse(result.Text));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            result.Text = (Double.Parse(result.Text) / 100).ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            result.Text = (1/(double.Parse(result.Text))).ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            int fact = 1;
            for (int i=1; i <=double.Parse(result.Text); i++)
            {
                fact = fact * i;

            }
            result.Text = fact.ToString();

        }
    }
}
