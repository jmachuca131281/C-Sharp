using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Purchase_Order
{
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            list = ProductsBLL.GetProducts();
            dataGridView1.DataSource = list;

        }
        List<PRODUCTS> list = new List<PRODUCTS>();
        public PRODUCTS detail = new PRODUCTS();
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            
            list = ProductsBLL.GetProducts();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "DESCRIPTION";
            dataGridView1.Columns[2].HeaderText = "CATEGORY";
            dataGridView1.Columns[3].HeaderText = "PROVIDER";
            dataGridView1.Columns[4].HeaderText = "PRICE";
            dataGridView1.Columns[5].HeaderText = "IVA";
            dataGridView1.Columns[6].HeaderText = "QUANTITY";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.description = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            detail.category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            detail.provider = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            detail.price = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            detail.iva = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            detail.quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.id == 0)
                MessageBox.Show("Please select a product from table");
            else
            {
                FrmProduct frm = new FrmProduct();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                list = ProductsBLL.GetProducts();
                dataGridView1.DataSource = list;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this product", "Warning!!", MessageBoxButtons.YesNo);
            if(DialogResult.Yes == result)
            {
                ProductsBLL.DeleteProduct(detail.id);
                MessageBox.Show("Departament was deleted");
                list = ProductsBLL.GetProducts();
                dataGridView1.DataSource = list;
            }
        }
    }
}
