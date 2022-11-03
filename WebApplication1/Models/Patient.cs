using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication1.Models
{
    public class Patient
    {
        [Key]
        public int Id
        {
            set; get;
        }
        [Required]
        [MaxLength(25)]
        public string first_name { set; get; }
        [MaxLength(25)]
        [Required]
        public string last_name { get; set; }
        [Required]
        public bool gender { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [MaxLength(50)]
        [RegularExpression("^([a-z]|[A-Z])([a-z]|[A-Z])([a-z]|[A-Z]|[0-9])*@([a-z]|[A-Z]){5,}[.]com$", ErrorMessage = "Email must be in correct format i.e. example@example.com")]
        public string Email { get; set; }
        [Required]
        [ForeignKey("State")]
        public int s_id { get; set; }
        [Required]
        [ForeignKey("City")]
        public int c_id { get; set; }
        [Required]
        public int height { get; set; }
        [Required]
        public int weight { get; set; }
        [MaxLength(100)]
        public string question1 { get; set; }
        public string question2 { get; set; }
        public bool question3 { get; set; }
        [MaxLength(500)]
        public string problems { get; set; }
        public bool regular_exercise { get; set; }
        [Required]
        public bool need_trainer { get; set; }
        public DateTime created_date { get; set; }
        public bool is_deleted { get; set; }
        public DateTime modified_date { get; set; }
    }
}

