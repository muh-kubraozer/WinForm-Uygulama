using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    public class Host : Person
    {
        public Host(string FirsName, string LastName, DateTime DateOfBirth) : base(FirsName, LastName)
        {
            this.DateOfBirth = DateOfBirth;
            if (this.Age < 18)
            {
                throw new Exception("Hata:Muavin yaşı tutmuyor.");
            }
        }
    }
}
