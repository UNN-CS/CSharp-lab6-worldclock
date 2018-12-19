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

namespace lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clock1 = new Clock("Moscow", textBox1, updateTime);
            clock2 = new Clock("World", textBox2, updateTime);
            clock3 = new Clock("Vlad", textBox3, updateTime);
        }
        private Clock clock1;
        private Clock clock2;
        private Clock clock3;
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
    public class Clock
    {
        Dictionary<string, TimeSpan> zones = new Dictionary<string, TimeSpan>();
        public delegate void Update(TextBox tb, DateTime dt);
        public Update upd;
        System.Timers.Timer timer;
        public TextBox tb;
        string name;
        public Clock(string zone, TextBox tb, Update upd)
        {
            zones["World"] = new TimeSpan(-2, 0, 0);
            zones["Moscow"] = new TimeSpan(0, 0, 0);
            zones["Vlad"] = new TimeSpan(7, 0, 0);
            this.upd = upd;
            this.tb = tb;
            this.name = zone;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
        }
        public void Start()
        {
            timer.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = false;
        }

        public void OnTimeEvent(Object source, ElapsedEventArgs e)
        {
            DateTime dt = DateTime.Now + zones[name];
            this.upd(tb, dt);
        }
    }
}
