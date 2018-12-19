using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Lab6
{
   public class Clock1
    {
        Dictionary<string, TimeSpan> zones= new Dictionary<string, TimeSpan>();
        public delegate void Update(TextBox tb, DateTime dt);
        public Update upd;
        System.Timers.Timer timer;
        public TextBox tb;
        string name;
        public Clock1(string zone,TextBox tb,Update upd)
        {
            zones["World"] = new TimeSpan(-2, 0, 0);
            zones["Moscow"] = new TimeSpan(0, 0, 0);
            zones["Vladivostok"] = new TimeSpan(7, 0, 0);
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
