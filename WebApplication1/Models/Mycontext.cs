using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Mycontext:DbContext
    {
        public Mycontext(DbContextOptions<Mycontext> options) : base(options)
        {

        }
        public DbSet<City> sk_City { set; get; }
        public DbSet<State> sk_State { set; get; }
        public DbSet<Patient> sk_question { set; get; }
        public DbSet<Diet> sk_diet{ set; get; }
    }
}
