using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarRuqayah_QuranApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} الزامی میباشد")]
        [Display(Name = "نام و نام خانوادگی")]
        public string Name { get; set; }

        [RegularExpression("^09[0-9]*$", ErrorMessage = "{0} باید به صورت عددی و با ۰۹ شروع شود")]
        [Required(ErrorMessage = "وارد کردن {0} ضروری میباشد")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} باید 11 رقمی باشد")]
        [Display(Name = "شماره تلفن طلبه")]
        public string Tell { get; set; }

        [RegularExpression("^09[0-9]*$", ErrorMessage = "{0} باید به صورت عددی و با ۰۹ شروع شود")]
        [Required(ErrorMessage = "وارد کردن {0} ضروری میباشد")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} باید 11 رقمی باشد")]
        [Display(Name = "شماره تلفن ولی طلبه")]
        public string ParentTell { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} الزامی میباشد")]
        [Display(Name = "کشور")]
        public string Country { get; set; }

        [Required(ErrorMessage = "وارد کردن {0} الزامی میباشد")]
        [Display(Name = "تاریخ تولد")]
        public DateTime Birthday { get; set; }

        [Display(Name = "مقدار حفظ")]
        public int HefzValue { get; set; }

        [Display(Name = "آدرس")]
        public string Address { get; set; }
    }
}
