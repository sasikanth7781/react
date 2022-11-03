using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Diet
    {
        [Key]
        public int Id
        {
            set; get;
        }
        public string my_diet { get; set; }
        [ForeignKey("Patient")]
        public int p_id { get; set; }

    }
}
