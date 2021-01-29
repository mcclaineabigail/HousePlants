using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HousePlants.Models;

namespace HousePlants.Data
{
    public class HousePlantsContext : DbContext
    {
        public HousePlantsContext (DbContextOptions<HousePlantsContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plant { get; set; }
    }
}
