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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;

            catalog.
            search(textBox1.Text).
            ToList().
            ForEach(
                prop => 
                    textBox2.Text = textBox2.Text + prop.Address.fullAddress() + Environment.NewLine);


        }
    }
}
