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

        public Property[] search(string keyword)
        {
            throw new NotImplementedException();
        }

        public void sort()
        {
            throw new NotImplementedException();
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


