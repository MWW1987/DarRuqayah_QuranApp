using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarRuqayah_QuranApp.Models
{
    public class QuranAppContext : DbContext
    {
        public QuranAppContext(DbContextOptions<QuranAppContext> options) : base(options){}


        public DbSet<User> Users { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Ostad> Ostads { get; set; }
        public DbSet<DailyTask> DailyTasks { get; set; }
        public DbSet<WeeklyTask> WeeklyTasks { get; set; }
        public DbSet<MonthTask> MonthTasks { get; set; }
    }
}
