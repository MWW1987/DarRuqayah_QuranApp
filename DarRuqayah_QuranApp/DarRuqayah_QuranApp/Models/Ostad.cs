using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarRuqayah_QuranApp.Models
{
    public class Ostad
    {
        public int OstadId { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} الزامی میباشد")]
        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }

        [RegularExpression("^09[0-9]*$", ErrorMessage = "{0} باید به صورت عددی و با ۰۹ شروع شود")]
        [Required(ErrorMessage = "وارد کردن {0} ضروری میباشد")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} باید 11 رقمی باشد")]
        [Display(Name = "شماره تلفن استاد")]
        public string Tell { get; set; }

        [Display(Name = "نام کشور")]
        public string Country { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }

        [Display(Name = "خلاصه از سوابق")]
        public string CV { get; set; }

        [Display(Name = "تاریخ تولد")]
        public DateTime Birthday { get; set; }
    }
}
