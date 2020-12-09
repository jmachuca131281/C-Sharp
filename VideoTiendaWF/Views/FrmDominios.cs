using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoTiendaWF.Model;

namespace VideoTiendaWF.Views
{
    public partial class FrmDominios : Form
    {
        #region Helper
        public void CargarDatos()
        {
            //Conectar con la base de datos
            using (videotiendaEntities db = new videotiendaEntities())
            {
                // Consultar datos con linq lenguaje que se utiliza
                var LstDominios = from d in db.DOMINIOS
                                  select d;
                // En lazar lista de dominios con el dato Grig view
                DgvDatos.DataSource = LstDominios.ToList();
            }
        }
        #endregion
        public FrmDominios()
        {
            InitializeComponent();
        }

        private void FrmDominios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            using (videotiendaEntities db = new videotiendaEntities())
            {
                // Consultar todos los dominios
                var LstDominios = from d in db.DOMINIOS
                                  select d;
                // Aplicar filtros dependiendo de lo que se edite en el formulario
                if (!string.IsNullOrEmpty(this.txtTipoDominio.Text))
                {
                    LstDominios = LstDominios.Where(d => d.TIPO_DOMINIO.Contains(this.txtTipoDominio.Text));
                }

                if (!string.IsNullOrEmpty(this.txtDominioId.Text))
                {
                    LstDominios = LstDominios.Where(d => d.ID_DOMINIO.Contains(this.txtDominioId.Text));
                }

                if (!string.IsNullOrEmpty(this.txtVrldominio.Text))
                {
                    LstDominios = LstDominios.Where(d => d.VLRDOMINIO.Contains(this.txtVrldominio.Text));
                }

                DgvDatos.DataSource = LstDominios.ToList();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtDominioId.Text = "";
            this.txtTipoDominio.Text = "";
            this.txtVrldominio.Text = "";
            this.CargarDatos();
        }
    }
}