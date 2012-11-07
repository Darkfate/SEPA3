using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyView
{
    public  class Property
    {
        private int cost;
        private int propertyId;
        private int agentId;
        private String propertyType;
        private int available;
        public Address Address {get; private set;}

        public Property(int propertyId, String propertyType, int cost, int available, int agentId, String streetNo, String streetName, String suburb, String postCode, String state, String country)
        {
            this.propertyId = propertyId;
            this.propertyType = propertyType;
            this.cost = cost;
            this.agentId = agentId;
            this.available = available;
            this.Address = new Address(streetNo, streetName, suburb, postCode, state, country);
        }

        public String AddressText
        {
            get
            {
                return Address.ToString();
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
    }
    //public class Property
    //{
    //    private int propertyID;
    //    private string propertyName;
    //    private string propertyAddress;

    //    public Property(int propertyID, string propertyName, string propertyAddress)
    //    {
    //        this.propertyID = propertyID;
    //        this.propertyName = propertyName;
    //        this.propertyAddress = propertyAddress;

    //    }

    //    public Video getVideo()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int getPropertyID()
    //    {
    //        return propertyID;
    //    }

    //    public string getPropertyName()
    //    {
    //        return propertyName;
    //    }

    //    public string getPropertyAddress()
    //    {
    //        return propertyAddress;
    //    }
    //}
}
