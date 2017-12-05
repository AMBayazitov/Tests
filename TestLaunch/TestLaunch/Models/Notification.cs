using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch
{
    public class Notification
    {
        public Notification(string title, string note)
        {
            Title = title;
            Note = note;
        }
        public string Title { get; set; }
        public string Note { get; set; }
        public Notification() { }
    }
}
