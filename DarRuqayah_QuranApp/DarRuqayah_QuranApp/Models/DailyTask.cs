using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarRuqayah_QuranApp.Models
{
    public class DailyTask
    {
        public int DailyTaskId { get; set; }
        public DateTime Date { get; set; }
        public byte DailyHefzValue { get; set; }
        public byte GoodBehavier { get; set; }
        public byte Hearing { get; set; }
        public byte Hefz { get; set; }
        public byte NewReapet { get; set; }
        public byte OldReapet { get; set; }
        public Ostad Ostad { get; set; }
        public User User { get; set; }
    }
}
