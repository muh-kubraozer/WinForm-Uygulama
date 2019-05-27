using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace VoyageFramework
{
    public class DriverCollection<Driver>: IEnumerable<Driver>
    {
        public int Length
        {
            get { return _length; }
            private set { _length = value; }
        }

        private Driver[] _drivers;
        private int _length;
       

        public DriverCollection()
        {
            _drivers = new Driver[0];
            Length = 0;
        }
        public Driver this[int index]
        {
            get
            {
                return _drivers[index];
            }
            set
            {
                _drivers[index] = value;
            }
        }
        public void Add(Driver driver)
        {
            
            if (_drivers == null)
            {
                _drivers = new Driver[1];
                _drivers[0] = driver;

            }
            if (_drivers.Length > 0 && !Contains(driver) )
            {
                Array.Resize(ref _drivers, ++Length);

                _drivers[_drivers.Length - 1] = driver;
            }

        }
        public void Remove(Driver driver)
        {
           RemoveAt(IndexOf(driver));
        }
        public void RemoveAt(int index)
        {

            for (int i = 0; i < _drivers.Length; i++)
            {
                if (i == index)
                {
                    index = i;
                    continue;

                }
                var yeniİndis = i > index ? i - 1 : i;
                Array.Resize(ref _drivers, _drivers.Length - 1);

            }

        }
        public Driver GetDriverAt(int index)
        {
            return _drivers[index];
        }
        public int IndexOf(Driver driver)
        {
            for (int i = 0; i < _drivers.Length; i++)
            {
                if (_drivers[i].Equals(driver))
                    return i;
            }
            return -1;
        }
        public bool Contains(Driver driver)
        {
            for (int i = 0; i < _drivers.Length; i++)
            {
                if (_drivers[i].Equals(driver))
                {
                    return true;
                }
            }
            return false;

        }

        public IEnumerator<Driver> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}