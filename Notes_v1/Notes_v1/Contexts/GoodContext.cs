using Microsoft.EntityFrameworkCore;
using Notes_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notes_v1.Contexts
{
    public class GoodContext : DbContext
    {
        public GoodContext(DbContextOptions<GoodContext> options)
            : base(options)
        {
        }

        public DbSet<Good> Good { get; set; }
    }
}
