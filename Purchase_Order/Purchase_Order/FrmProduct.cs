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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == ""
                || cbxCategory.Text.Trim() == ""
                || cbxProvider.Text.Trim() == ""
                || txtPrice.Text.Trim() == ""
                || cbxIva.Text.Trim() == ""
                || txtQuantity.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the field");
            }               
            else
            {
                PRODUCTS products = new PRODUCTS();
                if (!isUpdate)
                {
                    products.description = txtDescription.Text;
                    products.category = cbxCategory.Text;
                    products.provider = cbxProvider.Text;
                    products.price = Convert.ToInt32(txtPrice.Text);
                    products.iva = Convert.ToInt32(cbxIva.Text);
                    products.quantity = Convert.ToInt32(txtQuantity.Text);
                    BLL.ProductsBLL.AddProducts(products);
                    MessageBox.Show("Product was added");
                    txtDescription.Clear();
                    /* Falta limpiar los campos */
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!!", MessageBoxButtons.YesNo);
                    if(DialogResult.Yes == result)
                    {
                        products.id = detail.id;
                        products.description = txtDescription.Text;
                        products.category = cbxCategory.Text;
                        products.provider = cbxCategory.Text;
                        products.price = Convert.ToInt32(txtPrice.Text);
                        products.iva = Convert.ToInt32(cbxIva.Text);
                        products.quantity = Convert.ToInt32(txtQuantity.Text);
                        ProductsBLL.UpdateProduct(products);
                        MessageBox.Show("Department was updated");
                        this.Close();
                    }
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool isUpdate = false;
        public PRODUCTS detail = new PRODUCTS();
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pURCHASE_ORDERDataSet3.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.pURCHASE_ORDERDataSet3.IVA);
            // TODO: esta línea de código carga datos en la tabla 'pURCHASE_ORDERDataSet2.PROVIDERS' Puede moverla o quitarla según sea necesario.
            this.pROVIDERSTableAdapter.Fill(this.pURCHASE_ORDERDataSet2.PROVIDERS);
            // TODO: esta línea de código carga datos en la tabla 'pURCHASE_ORDERDataSet.CATEGORYS' Puede moverla o quitarla según sea necesario.
            this.cATEGORYSTableAdapter.Fill(this.pURCHASE_ORDERDataSet.CATEGORYS);
            if (isUpdate)
                txtDescription.Text = detail.description;
        }
    }
}
