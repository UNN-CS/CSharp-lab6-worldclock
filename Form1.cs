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

namespace laba_6
{
    public partial class Form1 : Form
    {
        private Clock clock1;
        private Clock clock2;
        private Clock clock3;
        public Form1()
        {
            InitializeComponent();
            clock1 = new Clock("World", textBox1, updateTime1);
            clock2 = new Clock("Moscow", textBox2, updateTime2);
            clock3 = new Clock("Vlad", textBox3, updateTime3);
        }
        public void updateTime1(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = dt.ToString();

            }));
        }
        public void updateTime2(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                textBox2.Text = dt.ToString();
            }));
        }
        public void updateTime3(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                textBox3.Text = dt.ToString();
            }));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    public class Clock
    {
        private string zone;
        public TextBox tb;
        public delegate void
        Update(TextBox tb, DateTime dt);
        public Update upd;
        System.Timers.Timer timer;
        Dictionary<string, TimeSpan> zones;


        public Clock(string zone, TextBox tb, Update upd)
        {
            zones = new Dictionary<string, TimeSpan>();
            zones["World"] = new TimeSpan(-2, 0, 0);
            zones["Moscow"] = new TimeSpan(0, 0, 0);
            zones["Vlad"] = new TimeSpan(7, 0, 0);

            this.zone = zone;
            this.tb = tb;
            this.upd = upd;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimedEvent;

        }
        public void Start()
        {
            timer.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = false;
        }
        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            dt += zones[zone];
            this.upd(tb, dt);
        }



    }
}