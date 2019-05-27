using EFCodeFirstNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.DAL
{
    public class DALUnitOfWork : IDisposable //Hocaya sorulacak
    {
        private GymContext ctx;
        public IRepo<Person> People { get; set; }
        public IRepo<Customer> Customers { get; set; }
        public IRepo<Trainer> Trainers { get; set; }
        public IRepo<TrainingSession> TrainingSessions { get; set; }

        public DALUnitOfWork()
        {
            ctx = new GymContext();
            People = new PersonRepo(ctx);
            Customers = new CustomerRepo(ctx);
            Trainers = new TrainerRepo(ctx);
            TrainingSessions = new TrainingSessionRepo(ctx);
        }

        public void SaveChanges()
        {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
