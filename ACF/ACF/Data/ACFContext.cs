using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ACF.Model;

namespace ACF.Models
{
    public class ACFContext : DbContext
    {
        public ACFContext (DbContextOptions<ACFContext> options)
            : base(options)
        {
        }

        public DbSet<ACF.Model.Employee> Employee { get; set; }
    }
}
