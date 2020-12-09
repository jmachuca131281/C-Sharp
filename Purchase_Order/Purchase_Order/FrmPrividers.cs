using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace Purchase_Order
{
    public partial class FrmPrividers : Form
    {
        public FrmPrividers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProvider.Text.Trim() == "")
                MessageBox.Show("Please fill name field");
            else
            {
                PROVIDERS providers = new PROVIDERS();
                if (!isUpdate)
                {
                    providers.provider = txtProvider.Text;
                    BLL.ProvidersBLL.AddProvider(providers);
                    MessageBox.Show("Provider was add");
                    txtProvider.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!!", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        providers.id = detail.id;
                        providers.provider = txtProvider.Text;
                        ProvidersBLL.UpdateProvider(providers);
                        MessageBox.Show("Provider was updated");
                        this.Close();
                    }
                }
            }
           
        }

        public bool isUpdate = false;
        public PROVIDERS detail = new PROVIDERS();
        private void FrmPrividers_Load(object sender, EventArgs e)
        {
            if (isUpdate)
                txtProvider.Text = detail.provider;
        }
    }
}
