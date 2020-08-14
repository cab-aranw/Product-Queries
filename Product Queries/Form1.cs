using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Queries
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productDataSet);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);

        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByPrice(this.productDataSet.Product);

        }

        private void unitsGreater100Button_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnits(this.productDataSet.Product);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
