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
    public partial class Bag : Form
    {
        public Bag()
        {
            InitializeComponent();
        }

        private void Bag_Load(object sender, EventArgs e)
        {
            try
            {
                this.oRDERSTableAdapter.FillBy6(this.mssql2004466DataSet.ORDERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void checkoutButton_Click(object sender, EventArgs e)
        {

        }

        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.oRDERSTableAdapter.FillBy7(this.mssql2004466DataSet.ORDERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
