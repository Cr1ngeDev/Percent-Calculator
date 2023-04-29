using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }
        Point lastpoint;
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true) 
            {
                label10.Text = "Select an operation and press the button";
                First.Text = "Find the % of a num";
                Sec.Text = "What % one num. is of another num";
                Third.Text = "Add a % to a num";
                Four.Text = "Subtract a % from a num";
                Five.Text = "By what % is one n. greater than another";
                Sixth.Text = "By what % is one num. less than another";
                Sev.Text = "Find 100%";
            }
            First.Click += Button_Click;
            Sec.Click += Button_Click;
            Third.Click+= Button_Click;
            Four.Click += Button_Click;
            Five.Click += Button_Click;
            Sixth.Click += Button_Click;
            Sev.Click += Button_Click;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label10.Text = "Select an operation and press the button";
                First.Text = "Find the % of a num";
                Sec.Text = "What % one num. is of another num";
                Third.Text = "Add a % to a num";
                Four.Text = "Subtract a % from a num";
                Five.Text = "By what % is one n. greater than another";
                Sixth.Text = "By what % is one num. less than another";
                Sev.Text = "Find 100%";
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true) 
            {
                label10.Text = "Оберіть операцію та натисніть кнопку";
                First.Text = "Знайти % від числа";
                Sec.Text = "Скільки % складає одне число від іншого числа";
                Third.Text = "Додати % до числа";
                Four.Text = "Відняти % від числа";
                Five.Text = "На скільки % одне число більше іншого";
                Sixth.Text = "На скільки % одне число менше іншого";
                Sev.Text = "Знайти 100%";
            }
        }
        private void Button_Click(object sender, EventArgs e) 
        {
            Button clickButton = sender as Button;
            if(clickButton != null) 
            {
                int index = -1;
                int task = -1;
                switch (clickButton.Name) 
                {
                    case "First":
                        index = 0;
                        task = 1;
                        break;
                    case "Sec":
                        index = 1;
                        task = 2;
                        break;
                    case "Third":
                        index = 0;
                        task = 3;
                        break;
                    case "Four":
                        index = 0;
                        task = 4;
                        break;
                    case "Five":
                        index = 1;
                        task = 5;
                        break;
                    case "Sixth":
                        index = 1;
                        task = 6;
                        break;
                    case "Sev":
                        index = 0;
                        task = 7;
                        break;
                }
                Form1 ResForm = new Form1(index, task);
                ResForm.Show();
            }
        }
    }
}
