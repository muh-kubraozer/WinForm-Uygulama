using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyageFramework
{
    
        public class HostCollection<Host>
        {
            public int Length
            {
                get { return _length; }
                private set { _length = value; }
            }

            private Host[] _host;
            private int _length;
            

            public HostCollection()
        {
            _host = new Host[0];
            Length = 0;
        }
            public Host this[int index]
            {
                get
                {
                    return _host[index];
                }
                set
                {
                    _host[index] = value;
                }
            }
            public void Add(Host host)
            {
               
                if (_host == null)
                {
                    _host = new Host[1];
                    _host[0] = host;

                }
                if (_host.Length > 0 && !Contains(host) )
                {
                    Array.Resize(ref _host, ++Length);

                    _host[_host.Length - 1] = host;
                }

            }
            public void RemoveAt(int index)
            {

                for (int i = 0; i < _host.Length; i++)
                {
                    if (i == index)
                    {
                        index = i;
                        continue;

                    }
                    var yeniİndis = i > index ? i - 1 : i;
                    Array.Resize(ref _host, _host.Length - 1);

                }

            }
            public void Remove(Host host)
        {
            RemoveAt(IndexOf(host));
        }
            public Host GetDriverAt(int index)
            {
                return _host[index];
            }
            public int IndexOf(Host host)
            {
                for (int i = 0; i < _host.Length; i++)
                {
                    if (_host[i].Equals(host))
                        return i;
                }
                return -1;
            }
            public bool Contains(Host host)
            {
                for (int i = 0; i < _host.Length; i++)
                {
                    if (_host[i].Equals(host))
                    {
                        return true;
                    }
                }
                return false;

            }

        }
    }
