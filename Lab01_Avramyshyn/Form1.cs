﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_Avramyshyn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "Andriy" && textBox_password.Text == "123")
            {
                label_Ok.BackColor = Color.Green;
                MessageBox.Show("Hello Andriy");
            }
            else
            {
                label_Ok.BackColor = Color.Blue;
                MessageBox.Show("eror login or password");
            }
        }
    }
}