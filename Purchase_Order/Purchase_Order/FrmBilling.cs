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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pURCHASE_ORDERDataSet4.IVA' Puede moverla o quitarla según sea necesario.
            this.iVATableAdapter.Fill(this.pURCHASE_ORDERDataSet4.IVA);
            // TODO: esta línea de código carga datos en la tabla 'pURCHASE_ORDERDataSet1.PROVIDERS' Puede moverla o quitarla según sea necesario.
            this.pROVIDERSTableAdapter.Fill(this.pURCHASE_ORDERDataSet1.PROVIDERS);
            // TODO: esta línea de código carga datos en la tabla 'pURCHASE_ORDERDataSet.CATEGORYS' Puede moverla o quitarla según sea necesario.
            this.cATEGORYSTableAdapter.Fill(this.pURCHASE_ORDERDataSet.CATEGORYS);

            txtPrice.Enabled = false;

        }

        List<PRODUCTS> list = new List<PRODUCTS>();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            list = ProductsBLL.GetProducts();
            dataGridView1.DataSource = list;

        }
    }
}
