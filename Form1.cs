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

namespace _6_лаба
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
            clock2 = new Clock("World", tbWorld, updateTime1);
            clock3 = new Clock("Lensk", tbLensk, updateTime2);
        }
        public void updateTime(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tbMoscow.Text = dt.ToString();
            }));
        }
        public void updateTime1(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tbWorld.Text = dt.ToString();
            }));
        }
        public void updateTime2(TextBox tb, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tbLensk.Text = dt.ToString();
            }));
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clock1.Stop();
            clock2.Stop();
            clock3.Stop();
        }
    }
    public class Clock
    { Dictionary<string, TimeSpan> zones = new Dictionary<string, TimeSpan>();
        private string zone;
        public TextBox tb;
        public delegate void Update(TextBox tb, DateTime dt);
        public Update upd;
        System.Timers.Timer timer;

        public Clock(string zone, TextBox tb, Update upd)
        {

            zones["World"] = new TimeSpan(-2, 0, 0);
            zones["Moscow"] = new TimeSpan(0, 0, 0);
            zones["Lensk"] = new TimeSpan(6, 0, 0);
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
            DateTime dt = DateTime.Now+zones[zone];
            this.upd(tb, dt);
        }
    }
}
