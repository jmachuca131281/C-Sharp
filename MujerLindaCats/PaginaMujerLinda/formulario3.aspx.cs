using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PaginaMujerLinda
{
    public partial class Formulario3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void siguiente_Click(object sender, EventArgs e)
        {
            Datos.Formulario3 ingresoDatosVivienda = new Datos.Formulario3();

            string tipoDOC = id_numDcto.Text;
            int tipoID = int.Parse(tipoId.Text);
            string tipoVivi = tipoVivienda.Text;
            string suVivienda = suViviendaEs.Text;
            string permiteAnimals = permiteAnimales.Text;
            string veci = permiteAnimales.Text;
            string patiosTerrazas = patioTerraza.Text;
            string piso = pisoVive.Text;
            string mudanzas = mudanza.Text;
            string viajes = viaje.Text;

            ingresoDatosVivienda.ingresoInformacionVivienda
                (
                    tipoDOC, tipoID, tipoVivi, suVivienda, permiteAnimals, veci,
                    patiosTerrazas, piso, mudanzas, viajes
                );
        }
    }
}