using EFCodeFirstNTier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.DAL
{
    public class TrainerRepo : RepoBase<Trainer>, IRepo<Trainer>
    {
        public TrainerRepo(DbContext gymCtx):base(gymCtx)
        {

        }
    }
}
