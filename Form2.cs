using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 課題_完成_
{
    public partial class Form2 : Form
    {
        int counter = 0;
        Form1 f1;

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;

            switch (counter)
            {
                case 1:
                    textBox1.Visible = false;
                    textBox2.Visible = true;
                    break;
                case 2:
                    textBox2.Visible = false;
                    textBox3.Visible = true;
                    break;
                case 3:
                    button1.Text = "対戦へ";
                    f1 = new Form1();
                    f1.Show();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter--;

            switch (counter)
            {
                case 1:
                    textBox3.Visible = false;
                    textBox2.Visible = true;
                    button1.Text = "Next";
                    break;
                case 0:
                    textBox2.Visible = false;
                    textBox1.Visible = true;
                    button2.Text = "Back";
                    break;
                default:
                    button2.Text = "erorr";
                    counter = 0;
                    break;
            }
        }
        }
    }

