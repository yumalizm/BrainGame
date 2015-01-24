using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 課題;

namespace 課題_完成_
{
    public partial class Form1 : Form
    {
        Bitmap one = Properties.Resources._1個;
        Bitmap zero = Properties.Resources._0個;
        Bitmap two = Properties.Resources._2個;
        Bitmap three = Properties.Resources._3個;

        int[] box = new int[3];
        int count = 0;
        int turn = 0;
        bool win = false;

        課題._1tteme yuma1;
        課題._2teme yuma2;
        課題._3teme yuma3;

        Form2 f2;
        Form3 f3;
        Form4 f4;
        
        public Form1()
        {
            InitializeComponent();
           
        }
       
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (box[0] >= 1)
            {
                box[0] -= 1;

                switch (box[0])
                {
                    case 0:
                        pictureBox1.Image = zero;
                        break;
                    case 1:
                        pictureBox1.Image = one;
                        break;
                    case 2:
                        pictureBox1.Image = two;
                        break;
                }
            }
            else
            {
                textBox1.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {



            if (box[0] >= 2)
            {
                box[0] -= 2;

                switch (box[0])
                {
                    case 0:
                        pictureBox1.Image = zero;
                        break;
                    case 1:
                        pictureBox1.Image = one;
                        break;

                }
            }
            else
            {
                textBox1.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (box[0] >= 3)
            {
                box[0] -= 3;

                switch (box[0])
                {
                    case 0:
                        pictureBox1.Image = zero;
                        break;

                }
            }
            else
            {
                textBox1.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
                box[i] = 3;

            pictureBox1.Image = three;
            pictureBox2.Image = three;
            pictureBox3.Image = three;

            count = 0;
            turn = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            timer1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {


            if (box[1] >= 1)
            {
                box[1] -= 1;

                switch (box[1])
                {
                    case 0:
                        pictureBox2.Image = zero;
                        break;
                    case 1:
                        pictureBox2.Image = one;
                        break;
                    case 2:
                        pictureBox2.Image = two;
                        break;
                }
            }
            else
            {
                textBox2.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (box[1] >= 2)
            {
                box[1] -= 2;

                switch (box[1])
                {
                    case 0:
                        pictureBox2.Image = zero;
                        break;
                    case 1:
                        pictureBox2.Image = one;
                        break;

                }
            }
            else
            {
                textBox2.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (box[1] >= 3)
            {
                box[1] -= 3;

                switch (box[1])
                {
                    case 0:
                        pictureBox2.Image = zero;
                        break;

                }
            }
            else
            {
                textBox2.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (box[2] >= 1)
            {
                box[2] -= 1;

                switch (box[2])
                {
                    case 0:
                        pictureBox3.Image = zero;
                        break;
                    case 1:
                        pictureBox3.Image = one;
                        break;
                    case 2:
                        pictureBox3.Image = two;
                        break;
                }
            }
            else
            {
                textBox3.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (box[2] >= 2)
            {
                box[2] -= 2;

                switch (box[2])
                {
                    case 0:
                        pictureBox3.Image = zero;
                        break;
                    case 1:
                        pictureBox3.Image = one;
                        break;

                }
            }
            else
            {
                textBox3.Text = "error";
                timer1.Enabled = true;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
                if (box[2] >= 3)
                {
                    box[2] -= 3;

                    switch (box[2])
                    {
                        case 0:
                            pictureBox3.Image = zero;
                            break;

                    }
                }
                else
                {
                    textBox3.Text = "error";
                    timer1.Enabled = true;
                }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            turn++;
            count++;


            if (count == 1)
            {
                yuma1 = new _1tteme(box);
                yuma1.yuma1();
                box = yuma1.yuma2();
                this.change();

            }
            else if (count == 2)
            {
                yuma2 = new _2teme(box);
                yuma2.yuma1();
                yuma2.yuma2();
                box = yuma2.yuma3();
                this.change();
            }
            else if (count == 3)
            {
                yuma3 = new _3teme(box);
                yuma3.yuma1();
                yuma3.yuma2();
                box = yuma3.yuma3();
                this.change();
                win = yuma3.yuma4();
            }
            else
            {

                count = 0;
            }

        }

        public void change()
        {

            switch (box[0])
            {
                case 0:
                    pictureBox1.Image = zero;
                    break;
                case 1:
                    pictureBox1.Image = one;
                    break;
                case 2:
                    pictureBox1.Image = two;
                    break;
                case 3:
                    pictureBox1.Image = three;
                    break;
            }

            switch (box[1])
            {
                case 0:
                    pictureBox2.Image = zero;
                    break;
                case 1:
                    pictureBox2.Image = one;
                    break;
                case 2:
                    pictureBox2.Image = two;
                    break;
                case 3:
                    pictureBox2.Image = three;
                    break;
            }

            switch (box[2])
            {
                case 0:
                    pictureBox3.Image = zero;
                    break;
                case 1:
                    pictureBox3.Image = one;
                    break;
                case 2:
                    pictureBox3.Image = two;
                    break;
                case 3:
                    pictureBox3.Image = three;
                    break;
            }

            if (box[0] == 1 && box[1] == 0 && box[2] == 0)
                win = true;
            else if (box[0] == 0 && box[1] == 0 && box[2] == 0)
                win = true;
            else if (box[0] == 0 && box[1] == 0 && box[2] == 0)
                win = true;


                if (turn % 2 == 1)
                {
                    if (box[0] == 0 && box[1] == 0 && box[2] == 0 && win == false)
                    {
                        f4 = new Form4();
                        f4.Show();
                    }
                    else if(box[0] == 0 && box[1] == 0 && box[2] == 0 && win == true)
                    {
                        f3 = new Form3();
                        f3.Show();
                    }
                }
                

        }

        private void button12_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.Show();
        }



        }
    }

