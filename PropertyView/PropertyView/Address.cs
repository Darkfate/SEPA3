using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyView
{
    public class Address
    {
        public string StreetNo { get; private set; }
        public string StreetName { get; private set; }
        public string Suburb { get; private set; }
        public string PostCode { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }

        public Address(string streetNo, string streetName, string suburb, string postCode, string state, string country)
        {
            this.StreetNo = streetNo;
            this.StreetName = streetName;
            this.Suburb = suburb;
            this.PostCode = postCode;
            this.State = state;
            this.Country = country;
        }
    }
}
