using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchase_Order
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnProviders_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProviders_Click_1(object sender, EventArgs e)
        {
            FrmProvidersList frm = new FrmProvidersList();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategorysList frm = new FrmCategorysList();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProducts frm = new FrmProducts();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
