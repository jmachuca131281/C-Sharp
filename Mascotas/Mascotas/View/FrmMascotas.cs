using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mascotas.Model;

namespace Mascotas.View
{
    public partial class FrmMascotas : Form
    {

        #region Generales
        public void ConsultarDatos()
        {
            using (adopcionesEntities db = new adopcionesEntities())

            { 
            //onusltar datos s traces de lingk
            var LstMascotas = from m in db.mascotas
                              select new
                              {
                                  idMascota = m.idMascota,
                                  nombreMascota = m.nombreMascota,
                                  edadMascota = m.edadMascota,
                                  colorMascota = m.colorMascota,
                                  generoMascota = m.generoMascota
                              };
            //Mapear el conjunto de datos al DatGrid
            grdDatos.DataSource = LstMascotas.ToList();
        }
        }
        #endregion

        public FrmMascotas()
        {
            InitializeComponent();
        }

        private void FrmMascotas_Load(object sender, EventArgs e)
        {
            // Cargar datos a registrados en la base de datos
            ConsultarDatos();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // leer lo que tenemos en la base de datos
            using(adopcionesEntities db = new adopcionesEntities())
            {
                // Consultar todas las mascotas
                var LstMascotas = from m in db.mascotas
                                  select new
                                  {
                                      idMascota = m.idMascota,
                                      nombreMascota = m.nombreMascota,
                                      edadMascota = m.edadMascota,
                                      colorMascota = m.colorMascota,
                                      generoMascota = m.generoMascota
                                  };
                // Aplicar los filtros
                if (!string.IsNullOrEmpty(this.txtIDMascota.Text))
                {
                    LstMascotas = LstMascotas.Where(m => m.idMascota.Equals(this.txtIDMascota.Text));
                }
                if (!string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    LstMascotas = LstMascotas.Where(m => m.nombreMascota.Contains(this.txtNombre.Text));
                }
                // Mapear datos con el DataGrid
                grdDatos.DataSource = LstMascotas.ToList();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmGestionMascotas frmGestionMascotas = new FrmGestionMascotas("I");
            frmGestionMascotas.Show();
            this.ConsultarDatos();
        }
    }
}
