﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public int index { get; private set; }
        public int task { get; private set; }
        public Form1(int index, int task)
        {
            InitializeComponent();
            this.index = index;
            this.task = task;
        }
        Point lastpoint;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox2_MouseMove_1(object sender, MouseEventArgs e)
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

        private void label2_MouseDown_1(object sender, MouseEventArgs e)
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
        private void Form1_Load(object sender, EventArgs e)
        {
            string pattern = @"\s+";
            string target = "";
            Regex regex = new Regex(pattern);
            if (index!= -1) 
            {
                tabControl1.SelectedIndex = index;
            }
        }
        private void CalculateResult(TextBox textBox1, TextBox textBox2, Label label)
        {
            string pattern = @"\s+";
            string target = "";
            Regex regex = new Regex(pattern);
            string findSpaces1 = regex.Replace(textBox1.Text, target);
            string findSpaces2 = regex.Replace(textBox2.Text, target);
            Counting getAnswer = new Counting(findSpaces1, findSpaces2, index, task);
            string result = getAnswer.GetAnswer();
            if (result != "no_data")
            {
                label.Visible = true;
                label.Text = (index == 1) ? result + "%" : result;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CalculateResult(textBox1, textBox2, label5);
            label4.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CalculateResult(textBox3, textBox24, label8);
            label9.Visible = true;
        }
    }
}
