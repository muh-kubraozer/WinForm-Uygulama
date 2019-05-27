using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VoyageFramework
{
    public class Driver : Person 
    {
        public LicenseType LicenseType;

        public Driver(string FirsName, string LastName, DateTime DateOfBirth,LicenseType licenseType) : base(FirsName, LastName)
        {
            this.DateOfBirth = DateOfBirth;
            this.LicenseType = licenseType;
            
            if (this.Age < 25)
            {
                throw new Exception("Hata: Sürücü yaşı tutmuyor.");
            }
        }
    }
}
