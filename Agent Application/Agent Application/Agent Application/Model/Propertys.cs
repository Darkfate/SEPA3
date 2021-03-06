﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Agent_Application.Model
{
    class Propertys
    {
        private List<Property> propertyList = new List<Property>();
        private DataConnection dc;

        public Propertys(DataConnection dc)
        {
            this.dc = dc;
            fillList();
        }

        private void fillList()
        {
            DataTable properties = dc.ExecuteQuery("select * from Property;");
            for (int i = 0; i < properties.Rows.Count; i++)
            {
                int propertyId = Convert.ToInt32(properties.Rows[i].ItemArray[0].ToString());
                String propertyType = properties.Rows[i].ItemArray[1].ToString();
                int cost = Convert.ToInt32(properties.Rows[i].ItemArray[2].ToString());
                int available = Convert.ToInt32(properties.Rows[i].ItemArray[3].ToString());
                int agentId = Convert.ToInt32(properties.Rows[i].ItemArray[4].ToString()); 
                DataTable address = dc.ExecuteQuery("select StreetNumber, StreetName, Suburb, PostCode, State, Country from Address where PropertyID = " + propertyId + ";");
                if (address.Rows.Count > 0)
                {
                    String streetNo = address.Rows[0].ItemArray[0].ToString();
                    String streetName = address.Rows[0].ItemArray[1].ToString();
                    String suburb = address.Rows[0].ItemArray[2].ToString();
                    String postCode = address.Rows[0].ItemArray[3].ToString();
                    String state = address.Rows[0].ItemArray[4].ToString();
                    String country = address.Rows[0].ItemArray[5].ToString();
                    propertyList.Add(new Property(propertyId, propertyType, cost, available, agentId, streetNo, streetName, suburb, postCode, state, country));
                }
            }
        }

        public List<Property> getProperties()
        {
            return propertyList;
        }

        public void refresh(){
            propertyList = null;
            propertyList = new List<Property>();
            fillList();
        }

        public void addProperty(Address address, String[] details)
        {
            dc.ExecuteNonQuery("insert into Property(PropertyType, Cost, Available, AgentID) values ('" + details[0] + "', " + details[1] + ", 1, " + details[2] + ");");
            DataTable idResult =  dc.ExecuteQuery("select PropertyID from Property where AgentId = " + details[2] + " ORDER BY PropertyID DESC;");
            String id = idResult.Rows[0].ItemArray[0].ToString();
            dc.ExecuteNonQuery("insert into Address values (" + id + ", " + address.StreetNo() + ", '" + address.StreetName() + "', '" + address.Suburb() + "', " + address.PostCode() + ", '" + address.State() + "', '" + address.Country() + "');");
            refresh();
        }
    }
}