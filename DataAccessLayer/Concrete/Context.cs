﻿using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<ReadyTrainingInform> ReadyTrainingInforms { get; set; }

    }
}
