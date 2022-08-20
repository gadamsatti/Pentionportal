using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessPensionMicroservice.Model
{
    public class PentionDb : DbContext
    {
        public PentionDb()
        { 
        }


        public PentionDb(DbContextOptions<PentionDb> options) : base(options)
        { 
        
        }

        public DbSet<ProcessPension> ProcessPensions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProcessPention;Integrated Security=True");
             
            }

        
        }

    }
}
