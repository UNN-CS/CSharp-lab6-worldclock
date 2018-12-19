using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        private Clock clock1;
        private Clock clock2;
        private Clock clock3;
        public Form1()
        {
            InitializeComponent();
            clock1 = new Clock("Moscow", Moscow, updateTime);
            clock2 = new Clock("World", World, updateTime);
            clock3 = new Clock("Vlad", Vlad, updateTime);
        }
        public void updateTime(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tb.Text = dt.ToString();
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clock1.Start();
            clock2.Start();
            clock3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clock1.Stop();
            clock2.Stop();
            clock3.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
