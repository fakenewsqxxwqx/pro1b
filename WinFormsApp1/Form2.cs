using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        private int socre;
        private int num;
        private int num1;
        private int num2;
        private char oper;
        private bool flag;

        public Form2(int socre, int num)
        {
            this.socre = socre;
            this.num = num;
            InitializeComponent();
            Random random = new Random();
            num1 = random.Next(0, 100);
            num2 = random.Next(0, 100);
            int i = random.Next(0, 2);
            if (i == 0)
                this.oper = '+';
            else this.oper = '-';
            string s = num1 + " " + oper + " " + num2 + "=";
            label2.Text = s;
            flag = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool Judge(int value)
        {
            int v = 0;
            if (oper == '+')
                v = num1 + num2;
            else v = num1 - num2;

            return value == v;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (num > 0)
            {
                num--;
                Form form = new Form2(socre, num);
                this.Hide();
                timer1.Stop();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                Form form = new Form3(socre);
                this.Hide();
                timer1.Stop();
                form.ShowDialog();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int v = 0;
            if (int.TryParse(s, out v))
            {
                if (Judge(v))
                {
                    if (!flag)
                        socre++;
                    label3.Text = "Your answer is right!";
                }
                else
                {
                    label3.Text = "Your answer is wrong!";
                }
            }
            else
            {
                label3.Text = "Input wrong!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num > 0)
            {
                num--;
                Form form = new Form2(socre, num);
                this.Hide();
                timer1.Stop();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                Form form = new Form3(socre);
                this.Hide();
                timer1.Stop();
                form.ShowDialog();
                this.Close();
            }
        }


    }
}
