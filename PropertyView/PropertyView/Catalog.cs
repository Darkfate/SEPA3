using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyView
{
    public class Catalog
    {
        private Property[] properties;

        public Catalog()
        {
            //initialise properties here. With our current design it seems like we want properties will contain everything from the database at initiation
        }

        public Property[] search(string keyword)
        {
            // istead of this, it might want to call a method that talks to the database and filter it from there.
            return properties.Where(property => property.getPropertyName().Contains(keyword)).ToArray();
        }

        public void sort()
        {
            // MIght add another method to order by ID aswell. ALso like above, ordering might be better done in the database.
            properties.OrderBy(property => property.getPropertyName());
        }

        public void addProperty()
        {
            Console.WriteLine("Please enter Property Name");
            string propertyName = Console.ReadLine();
            
            Console.WriteLine("Please enter Property Address");
            string propertyAddress= Console.ReadLine();

            int propertyID = properties.Length + 1;


        }

        public void displayProperty()
        {
            for(int i=0;i<properties.Length; i++)
            {
                Console.WriteLine(properties[i].getPropertyID());
                Console.WriteLine(properties[i].getPropertyName());
                Console.WriteLine(properties[i].getPropertyAddress());
            }
        }
    }
}


