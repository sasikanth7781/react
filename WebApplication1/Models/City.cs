using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class City
    {
        [Key]
        public int Id { set; get; }
        [MaxLength(25)]
        public string name { set; get; }
        [Required]
        [ForeignKey("State")]
        public int s_id { get; set; }
    }
}
