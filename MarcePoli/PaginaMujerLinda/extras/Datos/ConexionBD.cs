using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Modelo;

namespace Datos
{
    public class ConexionBD
    {
        private string bdLocal = @"packet size=4096; persist security info=True; Data Source=DESKTOP-D4K75HQ\MARCE; Initial Catalog=mujerlinda; Integrated Security=SSPI; Timeout=300";
        private string nombre = "Daniel";

        public Mascota ejecutarProcedimineto()
        {
            Database SqlBdd = new SqlDatabase(bdLocal);
            DbCommand Comando = SqlBdd.GetStoredProcCommand("ConsultarMascotasPorNombre");
            SqlBdd.AddInParameter(Comando, "@nombre", DbType.String, nombre);

            DataSet DS = SqlBdd.ExecuteDataSet(Comando);
            
            DataTable dtConsulta;
            dtConsulta = DS.Tables[0];

            Mascota mas = new Mascota();
            mas.nombre = dtConsulta.Rows[0]["nombres"].ToString();
            mas.direccion = dtConsulta.Rows[0]["direccion_hogar"].ToString();
            mas.telefono = dtConsulta.Rows[0]["telefono1"].ToString();
            return mas;
        }
    }
}
