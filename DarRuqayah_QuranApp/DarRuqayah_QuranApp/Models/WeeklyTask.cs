using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarRuqayah_QuranApp.Models
{
    public class WeeklyTask
    {
        public int WeeklyTaskId { get; set; }
        public byte GoodHefz { get; set; }
        public byte Tajvid { get; set; }
        public byte Ada { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public MonthTask MonthTask { get; set; }
    }
}
