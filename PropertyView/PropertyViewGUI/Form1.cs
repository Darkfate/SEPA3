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
        private List<Property> propertyList;

        public CatalogView()
        {
            InitializeComponent();
            catalog = new Catalog();
            propertyList = new List<Property>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            propertyList = catalog.search(textBox1.Text).ToList();
        }
    }
}
