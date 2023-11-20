using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 arabalar = new Class1();
            arabalar.marka = "Audi";
            arabalar.Model = "Sedan";
            arabalar.En = 2;

            richTextBox1.Text = "Otomobil markası :" + arabalar.marka + " " + "Otomobil Modeli:" + arabalar.Model + " " + "Otomobil eni:" + arabalar.En + " " + "Otomobil boyu:" + arabalar.getBoy();



        }
    }
}
