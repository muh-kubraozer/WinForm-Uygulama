namespace EFCodeFirstNTier.DAL.Migrations
{
    using EFCodeFirstNTier.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstNTier.DAL.GymContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true; //veri kaybý sorumluluðunu entity frameworkten üstümüze alýyoruz (person name max 64 dediðimiz için var olan örneðin 75 karakterli nameler silinebileceði için bunu yazmazsak veri kaybý olabilir hatasý veriyor.)
        }

        protected override void Seed(EFCodeFirstNTier.DAL.GymContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Customers.Add(new Customer() { CustomerId = 10, MembershipStartDate = DateTime.Now, Person = new Person() { PersonId = 15, Name = "Oguz", Lastname = "Gonca" } });
        }
    }
}
