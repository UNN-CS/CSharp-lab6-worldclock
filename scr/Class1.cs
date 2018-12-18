using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace lab6
{
    public class Class1
    {

        Dictionary<string, TimeSpan> zones = new Dictionary<string, TimeSpan>();
        private string zone;
        public TextBox tb;
        public delegate void Update(TextBox tb, DateTime dt);
        public Update upd;
        System.Timers.Timer timer;

        public Class1(string zone, TextBox tb, Update upd)
        {
            zones["World"] = new TimeSpan(-2, 0, 0);
            zones["Moscow"] = new TimeSpan(0, 0, 0);
            zones["Samara"] = new TimeSpan(1, 0, 0);
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
