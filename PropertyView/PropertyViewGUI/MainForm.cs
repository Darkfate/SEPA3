using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyView;

namespace PropertyViewGUI
{
    public partial class CatalogView : Form
    {
        private Catalog catalog;

        public CatalogView()
        {
            InitializeComponent();
            catalog = new Catalog();
        }

        private void searchButton(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;

            List<Property> resultList =
                catalog.
                 search(keywordTextBox.Text).
                 ToList();
            
            resultList.
            ForEach(
                prop => 
                    resultTextBox.Text = resultTextBox.Text + prop.Address.fullAddress() + Environment.NewLine);

            if (resultList.Count == 0)
            {
                resultTextBox.Text = "No results found";
            }

        }
    }
}
