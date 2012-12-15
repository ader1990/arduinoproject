using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FlowerPower.Models
{
    public class FlowerContext : DbContext
    {
        public FlowerContext()
            : base("FlowerConnection")
        {
        }
        public DbSet<Flower> Flowers { get; set; }
    }
}