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
    public partial class FrmProvidersList : Form
    {
        public FrmProvidersList()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (detail.id == 0)
                MessageBox.Show("Please select a departament form table");
            else
            {
                FrmPrividers frm = new FrmPrividers();
                frm.isUpdate = true;
                frm.detail = detail;
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
                list = ProvidersBLL.GetProviders();
                dataGridView1.DataSource = list;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this provider?", "Warning!!", MessageBoxButtons.YesNo);
            if(DialogResult.Yes == result)
            {
                ProvidersBLL.DeleteProvider(detail.id);
                MessageBox.Show("Provider was deleted");
                list = ProvidersBLL.GetProviders();
                dataGridView1.DataSource = list;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            detail.id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            detail.provider = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPrividers frm = new FrmPrividers();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
            list = ProvidersBLL.GetProviders();
            dataGridView1.DataSource = list;
        }

        List<PROVIDERS> list = new List<PROVIDERS>();
        public PROVIDERS detail = new PROVIDERS();
        private void FrmProvidersList_Load(object sender, EventArgs e)
        {
            list = ProvidersBLL.GetProviders();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Provider ID";
            dataGridView1.Columns[1].HeaderText = "Provider Name";
        }
    }
}
