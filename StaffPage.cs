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
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mssql2004466DataSet.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.mssql2004466DataSet.ORDERS);
            // TODO: This line of code loads data into the 'mssql2004466DataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.mssql2004466DataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'mssql2004466DataSet.PRODUCT' table. You can move, or remove it, as needed.
            this.pRODUCTTableAdapter.Fill(this.mssql2004466DataSet.PRODUCT);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userSubmitChanges_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Do you want to save the changes to Customer table?",
                "Commit changes",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                cUSTOMERTableAdapter.Update(mssql2004466DataSet.CUSTOMER);
            }
        }

        private void productSubmitChanges_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Do you want to save the changes to Product table?",
                "Commit changes",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                pRODUCTTableAdapter.Update(mssql2004466DataSet.PRODUCT);
            }
        }

        private void orderSubmitChanges_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Do you want to save the changes to Orders table?",
                "Commit changes",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                oRDERSTableAdapter.Update(mssql2004466DataSet.ORDERS);
            }
        }
    }
}
