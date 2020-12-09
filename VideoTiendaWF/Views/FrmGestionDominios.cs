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
    public partial class PnlDominios : Form
    {
        // El objeto que se va a insertar o consultar en la deb
        DOMINIO ODominio = null;
        // Variables que identifican la llave primaria

        // Si las variables son nulas el formulario esta en modo inseción 
        private string TipoDominio;
        private string IdDominio;

        public PnlDominios(String TipoDominio, String IdDominio)
        {
            // Constructor
            InitializeComponent();  // con this a los locales y sin a los globales
            this.TipoDominio = TipoDominio;
            this.IdDominio = IdDominio;
        }

        private void PnlDominios_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.TipoDominio) && !string.IsNullOrEmpty(this.IdDominio))
            {
                // Cargar los datos en el formulario
                // Todo
                this.txtTipoDominio.ReadOnly = true;
                this.txtIdDominio.ReadOnly = true;
            }
            else
            {
                // Cargar los datos en el formulario
                // Todo
                this.txtTipoDominio.ReadOnly = false;
                this.txtIdDominio.ReadOnly = false;
            }
        }
    }
}
