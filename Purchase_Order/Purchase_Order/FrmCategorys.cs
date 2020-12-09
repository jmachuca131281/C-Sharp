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
    public partial class FrmCategorys : Form
    {
        public FrmCategorys()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text.Trim() == "")
                MessageBox.Show("Please fill the nama field");
            else
            {
                CATEGORYS category = new CATEGORYS();
                if (!isUpdate)
                {
                    category.category = txtCategory.Text;
                    BLL.CategorysBLL.AddCategory(category);
                    MessageBox.Show("Category was added");
                    txtCategory.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you sure)", "Warning!!", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        category.id = detail.id;
                        category.category = txtCategory.Text;
                        CategorysBLL.UpdateCategory(category);
                        MessageBox.Show("Category was Updated");
                        this.Close();
                    }
                }
            }

            
        }
        public bool isUpdate = false;
        public CATEGORYS detail = new CATEGORYS();
        private void FrmCategorys_Load(object sender, EventArgs e)
        {
            if (isUpdate)
                txtCategory.Text = detail.category;
        }
    }
}
