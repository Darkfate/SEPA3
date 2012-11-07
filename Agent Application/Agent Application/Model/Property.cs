using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Application.Model
{
    class Property
    {
        private int cost;
        private int propertyId;
        private int agentId;
        private String propertyType;
        private int available;
        private Address address;
        private Assets assets;

        public Property(int propertyId, String propertyType, int cost, int available, int agentId, String streetNo, String streetName, String suburb, String postCode, String state, String country)
        {
            this.propertyId = propertyId;
            this.propertyType = propertyType;
            this.cost = cost;
            this.agentId = agentId;
            this.available = available;
            this.address = new Address(streetNo, streetName, suburb, postCode, state, country);
            this.assets = new Assets(propertyId);
        }

        public String AddressText
        {
            get
            {
                return address.ToString();
            }
        }

        public int PropertyId
        {
            get
            {
                return propertyId;
            }
        }

        public int Cost()
        {
            return cost;
        }

        public int Id()
        {
            return propertyId;
        }

        public int AgentId()
        {
            return agentId;
        }

        public String PropertyType()
        {
            return propertyType;
        }

        public int Available()
        {
            return available;
        }

        public Address Address()
        {
            return address;
        }

        public Assets Assets()
        {
            return assets;
        }
    }
}
