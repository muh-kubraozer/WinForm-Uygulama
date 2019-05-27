using EFCodeFirstNTier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.DAL
{
    public class GymContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Trainer> Trainers{ get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<TrainingSession> TrainingSession { get; set; }

        public GymContext():base("GymConnection")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TrainingSession>().HasRequired<Trainer>(ts => ts.Trainer).WithMany().WillCascadeOnDelete(false);
            modelBuilder.Entity<TrainingSession>().HasRequired<Customer>(ts => ts.Customer).WithMany().WillCascadeOnDelete(false);
        }
    }
}
