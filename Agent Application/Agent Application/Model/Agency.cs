using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Application.Model
{
    class Agency
    {
        private Propertys propertys = new Propertys();

        public List<Property> getProperties()
        {
            return propertys.getProperties();
        }
    }
}
