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
            clock1 = new Clock("Moscow", tbMoscow, updateTime);
            clock2 = new Clock("World", tbWorld, updateTime);
            clock3 = new Clock("Vlad", tbVlad, updateTime);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void tbMoscow_TextChanged(object sender, EventArgs e)
        {

        }

        public void updateTime(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tb.Text = dt.ToString();
            }));
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            clock1.Start();
            clock2.Start();
            clock3.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            clock1.Stop();
            clock2.Stop();
            clock3.Stop();
        }

        private void tbWorld_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbVlad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
