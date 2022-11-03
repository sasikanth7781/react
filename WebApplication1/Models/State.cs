using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class State
    {
        [Key]
        public int Id { set; get; }
        [MaxLength(25)]
        public string name { set; get; }

    }
}
