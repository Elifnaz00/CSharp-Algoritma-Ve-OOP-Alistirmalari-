﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_each
{
    public partial class Form1 : Form
    {
        string[] kisiler={"Ahmet, Mehmet, Seda, Ali"};
        int[] sayilar = { 2, 5, 8, 7, 1 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string s in kisiler)
            {
                listBox1.Items.Add(s);
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sayilar = { 2, 5, 8, 7, 1 };
            foreach (int i in sayilar)
            {
                
                
                toplam = toplam + i;
                listBox2.Items.Add(toplam);
                
            }
        }
    }
}
