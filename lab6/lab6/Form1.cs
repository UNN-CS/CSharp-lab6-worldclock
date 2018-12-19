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
    { private Clock clockw;
        private Clock clockm;
        private Clock clockv;
        
        public Form1()
        {
            InitializeComponent();
            clockw = new Clock("World", textBox1, updateTime1);
            clockm = new Clock("Moskow", textBox2, updateTime2);
            clockv = new Clock("Vlad", textBox3, updateTime3);
        }

        public void updateTime1(TextBox textBox1, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() => { textBox1.Text = dt.ToString(); }));

        }
        public void updateTime2(TextBox textBox1, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() => { textBox2.Text = dt.ToString(); }));

        }
        public void updateTime3(TextBox textBox1, DateTime dt)
        {
            this.Invoke(new MethodInvoker(() => { textBox3.Text = dt.ToString(); }));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clockw.Start();
            clockm.Start();
            clockv.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clockw.Stop();
            clockm.Stop();
            clockv.Stop();
        }
    }
    public class Clock
    {
        private string zone;
        public TextBox tb;
        public delegate void Update(TextBox tb, DateTime upd);
        public Update upd;
        System.Timers.Timer timer;
       public string name;
 Dictionary<string, TimeSpan> zones= new Dictionary<string, TimeSpan>();


        public Clock(string zone,TextBox tb, Update upd)
         { 
            zones["World"]=new TimeSpan(-2,0,0);
             zones["Moskow"] = new TimeSpan(0, 0, 0);
            zones["Vlad"] = new TimeSpan(7, 0, 0);
            name = zone;
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
        {this.zone = zone;
            DateTime dt = DateTime.Now+zones[name];
            this.upd(tb, dt);
       }


    }
}
