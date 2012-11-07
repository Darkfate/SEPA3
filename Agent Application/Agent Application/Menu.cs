using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agent_Application.Model;

namespace Agent_Application
{
    public partial class Menu : Form
    {
        private Agency agency;

        public Menu()
        {
            InitializeComponent();
            agency = new Agency();
            updateList();
            updateFields();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void updateList()
        {
            propertyBox.DataSource = null;
            List<Property> properties = agency.getProperties();
            propertyBox.DataSource = properties;
            propertyBox.DisplayMember = "AddressText";
            propertyBox.ValueMember = "PropertyId";
        }

        private void updateFields()
        {
            Property selection = (Property)propertyBox.SelectedItem;
            streetNoText.Text = selection.Address().StreetNo() + "";
            streetNameText.Text = selection.Address().StreetName();
            suburbText.Text = selection.Address().Suburb();
            postCodeText.Text = selection.Address().PostCode();
            stateText.Text = selection.Address().State();
            countryText.Text = selection.Address().Country();
        }

        private void propertyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFields();
        }

    }
}
