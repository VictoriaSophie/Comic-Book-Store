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
    public partial class CustomerAccount : Form
    {
        public CustomerAccount()
        {
            InitializeComponent();
        }

        private void CustomerAccount_Load(object sender, EventArgs e)
        {
            try
            {
                this.oRDERSTableAdapter.FillBy3(this.mssql2004466DataSet.ORDERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.oRDERSTableAdapter.FillBy3(this.mssql2004466DataSet.ORDERS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
