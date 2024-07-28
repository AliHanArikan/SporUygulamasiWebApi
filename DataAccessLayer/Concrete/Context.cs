using EntityLayer.Entities;
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

        public DbSet<ReadyTraining> ReadyTrainings { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// ReadyTraining - Exercise ilişkisini belirtin
            //modelBuilder.Entity<ReadyTraining>()
            //    .HasMany(rt => rt.ReadyExercise)
            //    .WithOne() // Exercise sınıfında ReadyTraining ile ilişki özelliği olmadan
            //    .OnDelete(DeleteBehavior.Cascade); // ReadyTraining silindiğinde Exercise nesnelerinin de silinmesini sağlamak

     //       modelBuilder.Entity<ReadyTrainingInform>()
     //.HasOne(rt => rt.ReadyTraining)
     //.WithOne()
     //.HasForeignKey<ReadyTrainingInform>(rt => rt.ReadyTrainingInformId)
     //.OnDelete(DeleteBehavior.Cascade);


            

            base.OnModelCreating(modelBuilder);
        }

    }
}
