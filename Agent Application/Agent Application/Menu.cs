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
            propertyBox.Enabled = true;
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
            agentIdText.Text = selection.AgentId() + "";
            propertyTypeText.Text = selection.PropertyType();
            costText.Text = selection.Cost() + "";
            List<Asset> assets = selection.Assets().AssetList();
            assetBox.DataSource = assets;
            assetBox.DisplayMember = "AssetName"; 
            assetBox.Visible = true;
        }

        private void propertyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFields();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            saveButton.Show();
            cancelButton.Show();
            propertyBox.Enabled = false;
            clearForm();
        }

        private void clearForm()
        {
            streetNoText.Text = "";
            streetNameText.Text = "";
            suburbText.Text = "";
            postCodeText.Text = "";
            stateText.Text = "";
            countryText.Text = "";
            agentIdText.Text = "";
            propertyTypeText.Text = "";
            costText.Text = "";
            assetBox.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            updateList();
            updateFields();
            saveButton.Hide();
            cancelButton.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String streetNo = streetNoText.Text;
            String streetName = streetNameText.Text;
            String suburb = suburbText.Text;
            String postCode = postCodeText.Text;
            String state = stateText.Text;
            String country = countryText.Text;
            Address address = new Address(streetNo, streetName, suburb, postCode, state, country);
            String agentId = agentIdText.Text;
            String propertyType = propertyTypeText.Text;
            String cost = costText.Text;
            String[] details = {propertyType, cost, agentId };
            agency.addProperty(address, details);
            updateList();
            saveButton.Hide();
            cancelButton.Hide();
        }
    }
}
