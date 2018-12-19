using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace world_clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clock1 = new Class1("Moscow", textBox1, updateTime);
            clock2 = new Class1("World", textBox2, updateTime);
            clock3 = new Class1("Vlad", textBox3, updateTime);
        }

        private Class1 clock1;
        private Class1 clock2;
        private Class1 clock3;

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
