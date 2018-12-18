using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace lab6
{
    public partial class Form1 : Form
    {
            
        private Class1 clock1;
        private Class1 clock2;
        private Class1 clock3;
        public Form1()
        {
            InitializeComponent();
            clock1 = new Class1("Moscow", textBox1, updateTime);
            clock2 = new Class1("World", textBox2, updateTime);
            clock3 = new Class1("Samara", textBox3 , updateTime);
        }

        public void updateTime(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tb.Text = dt.ToString();
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clock1.Start();
            clock2.Start();
            clock3.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clock1.Stop();
            clock2.Stop();
            clock3.Stop();
        }
    }   
}

