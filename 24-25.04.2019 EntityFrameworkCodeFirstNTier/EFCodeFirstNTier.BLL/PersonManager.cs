using EFCodeFirstNTier.DAL;
using EFCodeFirstNTier.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstNTier.BLL
{
    public class PersonManager
    {
        public PersonManager()
        {
        }

        public List<Person> GetByName(string searchTerm)
        {
            var result = default(List<Person>);
            using (DALUnitOfWork uow = new DALUnitOfWork())
            {
                result = uow.People.FindBy(x => x.Name.StartsWith(searchTerm)).ToList();
            }

            return result;
        }
    }
}
