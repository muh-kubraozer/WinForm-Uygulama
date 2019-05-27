using EFCodeFirstNTier.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.DAL
{
    public class CustomerRepo : RepoBase<Customer>, IRepo<Customer>
    {
        public CustomerRepo(DbContext gymCtx) : base(gymCtx)
        {

        }
    }
}
