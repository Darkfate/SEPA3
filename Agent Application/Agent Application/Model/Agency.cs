using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Application.Model
{
    class Agency
    {
        private DataConnection dc = new DataConnection();
        private Propertys propertys;

        public Agency()
        {
            propertys = new Propertys(dc);
        }

        public List<Property> getProperties()
        {
            return propertys.getProperties();
        }

        public void addProperty(Address address, String[] propertyDetails)
        {
            propertys.addProperty(address, propertyDetails); 
        }
    }
}
