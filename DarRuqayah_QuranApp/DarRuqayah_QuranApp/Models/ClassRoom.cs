using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarRuqayah_QuranApp.Models
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} الزامی میباشد")]
        [Display(Name = "نام کلاس")]
        public string Name { get; set; }

        [Display(Name = "زمان کلاس")]
        public string ClassTime { get; set; }

        [Display(Name = "نام استاد")]
        public int OstadId { get; set; }

        [Display(Name = "نام استاد")]
        public Ostad Ostad { get; set; }


        public int UserId { get; set; }

        [Display(Name = "طلاب")]
        public ICollection<User> Users { get; set; }

        [Display(Name = "لینک عکس کلاس")]
        public string Image { get; set; }
    }
}
