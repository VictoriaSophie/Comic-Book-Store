using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIUnit2
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2004466DataSet1.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.mssql2004466DataSet1.PRODUCT);
            // TODO: This line of code loads data into the 'mssql2004466DataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.mssql2004466DataSet.PRODUCT);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //string searchQuery = searchBox.Text;
            try
            {
                this.pRODUCTTableAdapter.FillBy8(this.mssql2004466DataSet.PRODUCT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void searchQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillBy7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pRODUCTTableAdapter.FillBy7(this.mssql2004466DataSet1.PRODUCT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy8ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pRODUCTTableAdapter.FillBy8(this.mssql2004466DataSet.PRODUCT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
