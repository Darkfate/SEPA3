using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyView
{
    public class Property
    {
        private int propertyID;
        private string propertyName;
        private string propertyAddress;

        public Property(int propertyID, string propertyName, string propertyAddress)
        {
            this.propertyID = propertyID;
            this.propertyName = propertyName;
            this.propertyAddress = propertyAddress;

        }
        public Video getVideo()
        {
            throw new NotImplementedException();
        }

        public int getPropertyID()
        {
            return propertyID;
        }

        public string getPropertyName()
        {
            return propertyName;
        }

        public string getPropertyAddress()
        {
            return propertyAddress;
        }
    }
}
