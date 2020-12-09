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
    public partial class FrmCategorysList : Form
    {
        public FrmCategorysList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmCategorys frm = new FrmCategorys();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            list = CategorysBLL.GetCategorys();
            dataGridView1.DataSource = list;
        }
        List<CATEGORYS> list = new List<CATEGORYS>();
        public CATEGORYS detail = new CATEGORYS();
        private void FrmCategorysList_Load(object sender, EventArgs e)
        {
            list = BLL.CategorysBLL.GetCategorys();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Category id";
            dataGridView1.Columns[1].HeaderText = "Category Name";
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            detail.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.category = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.id == 0)
                MessageBox.Show("Please select a departament from table");
            else
            {
                FrmCategorys frm = new FrmCategorys();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                list = CategorysBLL.GetCategorys();
                dataGridView1.DataSource = list;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this category", "Warning!!", MessageBoxButtons.YesNo);
            if(DialogResult.Yes == result)
            {
                CategorysBLL.DeleteCategory(detail.id);
                MessageBox.Show("Departament was deleted");
                list = BLL.CategorysBLL.GetCategorys();
                dataGridView1.DataSource = list;
            }
        }
    }
}
