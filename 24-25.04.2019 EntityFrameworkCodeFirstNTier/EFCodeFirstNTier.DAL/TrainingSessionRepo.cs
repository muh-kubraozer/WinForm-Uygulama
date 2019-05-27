using EFCodeFirstNTier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.DAL
{
    public class TrainingSessionRepo : RepoBase<TrainingSession>, IRepo<TrainingSession>
    {
        public TrainingSessionRepo(DbContext gymCtx):base(gymCtx)
        {

        }
        public IList<TrainingSession> GetByStartDate(DateTime date)
        {
            return this.FindBy(x => x.SessionStartDate.Date == date.Date).ToList();
        }
    }
}
