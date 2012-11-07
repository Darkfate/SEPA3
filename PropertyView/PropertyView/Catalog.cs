using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyView
{
    public class Catalog
    {
        private List<Property> properties;
        private DataConnection dataConnection;

        public Catalog()
        {
            //initialise properties here. With our current design it seems like we want properties will contain everything from the database at initiation
            properties = new List<Property>();
            fillProperties();
        }

        private void fillProperties()
        {
            dataConnection = new DataConnection();
            DataTable dataTable = dataConnection.ExecuteQuery("select * from Property;");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                int propertyId = Convert.ToInt32(dataTable.Rows[i].ItemArray[0].ToString());
                String propertyType = dataTable.Rows[i].ItemArray[1].ToString();
                int cost = Convert.ToInt32(dataTable.Rows[i].ItemArray[2].ToString());
                int available = Convert.ToInt32(dataTable.Rows[i].ItemArray[3].ToString());
                int agentId = Convert.ToInt32(dataTable.Rows[i].ItemArray[4].ToString());
                DataTable address = dataConnection.ExecuteQuery("select StreetNumber, StreetName, Suburb, PostCode, State, Country from Address where PropertyID = " + propertyId + ";");
                if (address.Rows.Count > 0)
                {
                    String streetNo = address.Rows[0].ItemArray[0].ToString();
                    String streetName = address.Rows[0].ItemArray[1].ToString();
                    String suburb = address.Rows[0].ItemArray[2].ToString();
                    String postCode = address.Rows[0].ItemArray[3].ToString();
                    String state = address.Rows[0].ItemArray[4].ToString();
                    String country = address.Rows[0].ItemArray[5].ToString();
                    properties.Add(new Property(propertyId, propertyType, cost, available, agentId, streetNo, streetName, suburb, postCode, state, country));
                }
            }
        }

        public Property[] search(string keyword)
        {
            // istead of this, it might want to call a method that talks to the database and filter it from there.
                return properties.Where(property => property.Address.StreetName.Contains(keyword)).ToArray();
        }

        public void sort()
        {
            // MIght add another method to order by ID aswell. ALso like above, ordering might be better done in the database.
            properties.OrderBy(property => property.Address.StreetName);
        }

        public void addProperty()
        {
            Console.WriteLine("Please enter Property Name");
            string propertyName = Console.ReadLine();
            
            Console.WriteLine("Please enter Property Address");
            string propertyAddress= Console.ReadLine();

            int propertyID = properties.Count() + 1;


        }

        public void displayProperty()
        {
            for(int i=0;i<properties.Count(); i++)
            {
                Console.WriteLine(properties[i].Id());
                Console.WriteLine(properties[i].Address.ToString());
            }
        }
    }
}


