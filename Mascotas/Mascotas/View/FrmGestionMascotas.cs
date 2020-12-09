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
    public partial class FrmGestionMascotas : Form
    {
        // Variables globales
        mascota mascota = null;
        private int idMascota;
        private string modoForm;

        public FrmGestionMascotas(string modoForm)
        {
            this.modoForm = modoForm;
            InitializeComponent();
            if (modoForm.Equals("I"))
            {
                // Deshabilita el campo para que no se a editado
                this.txtId.ReadOnly = false;
            }
            else
            {
                this.txtId.ReadOnly = true;
                // Cargar datos
            }
        }

        private void FrmGestionMascotas_Load(object sender, EventArgs e)
        {
            // Colocar el cursor en el primer text box
            this.txtId.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los datos obligatorios hayan sido diligenciados
            if (string.IsNullOrEmpty(this.txtId.Text)
                || string.IsNullOrEmpty(this.txtNombre.Text)
                || string.IsNullOrEmpty(this.txtEdad.Text)
                || string.IsNullOrEmpty(this.txtColor.Text))
            {
                MessageBox.Show("Se debe diligencia todos los datos");
            }
            else
            {
                // Si estamos en modo inserción, inicialzamos un nuevo objeto Mascota
                if (this.modoForm.Equals("I"))
                {
                    this.mascota = new mascota();
                }
                // Asingar al onjeto ascota los datos diligenciados en el formulario
                this.mascota.idMascota = int.Parse(this.txtId.Text);
                this.mascota.nombreMascota = this.txtNombre.Text;
                this.mascota.edadMascota = this.txtEdad.Text;
                this.mascota.colorMascota = this.txtColor.Text;
                this.mascota.generoMascota = this.cboGenero.SelectedItem.ToString();

                // Modo inserción
                using(adopcionesEntities db = new adopcionesEntities())
                {
                    if (this.modoForm.Equals("I"))
                    {
                        db.mascotas.Add(this.mascota);
                    }else
                    {
                        db.Entry(this.mascota).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();
                }
                this.Close();
            }
        }
    }
}
