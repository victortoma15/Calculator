using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double x;
        public Form1()
        {
            InitializeComponent();
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            textBox_Calcul.Enabled = false;
            textBox_Semn.Enabled = false;
            textBox_Preview.Enabled = false;
            textBox_Calcul.Text = "0";
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            if (textBox_Calcul.Text == "0")
                textBox_Calcul.Clear();
            Button cif = sender as Button;
            textBox_Calcul.Text = textBox_Calcul.Text + cif.Text;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            button16.PerformClick();
            if (textBox_Calcul.Text == String.Empty)
                textBox_Semn.Text = "+";
            else
            {
                x = double.Parse(textBox_Calcul.Text);
                textBox_Calcul.Text = String.Empty;
                textBox_Semn.Text = "+";
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            button16.PerformClick();
            if (textBox_Calcul.Text == String.Empty)
                textBox_Semn.Text = "-";
            else
            {
                x = double.Parse(textBox_Calcul.Text);
                textBox_Calcul.Text = String.Empty;
                textBox_Semn.Text = "-";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            button16.PerformClick();
            if (textBox_Calcul.Text == String.Empty)
                textBox_Semn.Text = "*";
            else
            {
                x = double.Parse(textBox_Calcul.Text);
                textBox_Calcul.Text = String.Empty;
                textBox_Semn.Text = "*";
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            button16.PerformClick();
            if (textBox_Calcul.Text == String.Empty)
                textBox_Semn.Text = "/";
            else
            {
                x = double.Parse(textBox_Calcul.Text);
                textBox_Calcul.Text = String.Empty;
                textBox_Semn.Text = "/";
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            x = double.Parse(textBox_Calcul.Text);
            textBox_Semn.Text = "√";
            //textBox_Preview.Text = "√" + x.ToString();
            x = Math.Sqrt(x);
            x = Math.Round(x, 9);
            textBox_Calcul.Text = x.ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            double y = double.Parse(textBox_Calcul.Text);
            if (textBox_Semn.Text == "+")
                textBox_Calcul.Text = (x + y).ToString();
            else
                if (textBox_Semn.Text == "-")
                textBox_Calcul.Text = (x - y).ToString();
            else
                if (textBox_Semn.Text == "*")
                textBox_Calcul.Text = (x * y).ToString();
            else
                if (textBox_Semn.Text == "/")
                {
                    if (y == 0)
                    {
                        textBox_Calcul.Text = "Cannot divide by 0";
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                        button7.Enabled = false;
                        button8.Enabled = false;
                        button9.Enabled = false;
                        button10.Enabled = false;
                        button11.Enabled = false;
                        button12.Enabled = false;
                        button13.Enabled = false;
                        button14.Enabled = false;
                        button15.Enabled = false;
                        button16.Enabled = false;
                        button17.Enabled = false;
                        button18.Enabled = false;
                        button20.Enabled = false;
                }
                    else
                         textBox_Calcul.Text = Math.Round((x / y), 9).ToString();
                }
            textBox_Semn.Text = String.Empty;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox_Calcul.Text += ",";
            button17.Enabled = false;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox_Calcul.Text.StartsWith("-"))
                textBox_Calcul.Text = textBox_Calcul.Text.Substring(1);
            else
                textBox_Calcul.Text = "-" + textBox_Calcul.Text;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            x = 0;
            textBox_Calcul.Text = String.Empty;
            textBox_Semn.Text = String.Empty;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = true;
            button18.Enabled = true;
            button20.Enabled = true;
        }
        private void textBox_Semn_TextChanged(object sender, EventArgs e)
        {
            button16.Enabled = true;
        }
        private void textBox_Calcul_TextChanged(object sender, EventArgs e)
        {
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            if(textBox_Calcul.Text != String.Empty)
                textBox_Calcul.Text = textBox_Calcul.Text.Substring(0, textBox_Calcul.Text.Length - 1);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "0":
                    button10.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button2.PerformClick();
                    break;
                case "3":
                    button3.PerformClick();
                    break;
                case "4":
                    button4.PerformClick();
                    break;
                case "5":
                    button5.PerformClick();
                    break;
                case "6":
                    button6.PerformClick();
                    break;
                case "7":
                    button7.PerformClick();
                    break;
                case "8":
                    button8.PerformClick();
                    break;
                case "9":
                    button9.PerformClick();
                    break;
                case "+":
                    button11.PerformClick();
                    break;
                case "-":
                    button12.PerformClick();
                    break;
                case "*":
                    button13.PerformClick();
                    break;
                case "/":
                    button14.PerformClick();
                    break;
                case "=":
                    button16.PerformClick();
                    break;
                case "\r":
                    button16.PerformClick();
                    break;
                case ".":
                    button17.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
