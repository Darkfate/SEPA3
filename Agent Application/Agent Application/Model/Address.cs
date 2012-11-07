using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agent_Application.Model
{
    class Address
    {
        private String streetNo;
        private String streetName;
        private String suburb;
        private String postCode;
        private String state;
        private String country;

        public Address(String streetNo, String streetName, String suburb, String postCode, String state, String country)
        {
            this.streetNo = streetNo;
            this.streetName = streetName;
            this.suburb = suburb;
            this.postCode = postCode;
            this.state = state;
            this.country = country;
        }
        
        override
        public String ToString() 
        {
            String s = streetNo + " ";
            s += streetName + " ";
            s += suburb + " ";
            s += postCode + "";
            return s;
        }

        

        public String StreetNo()
        {
            return streetNo;
        }

        public String StreetName()
        {
            return streetName;
        }

        public String Suburb()
        {
            return suburb;
        }

        public String PostCode()
        {
            return postCode;
        }

        public String State()
        {
            return state;
        }

        public String Country()
        {
            return country;
        }
    }
}
