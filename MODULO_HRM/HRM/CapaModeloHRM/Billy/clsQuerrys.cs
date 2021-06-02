using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloHRM.Billy
{
    public class clsQuerrys
    {
        ClsConexion cn = new ClsConexion();
        OdbcCommand Comm;
        OdbcTransaction transaction = null;
        string strSql = "";
        string Mensaje = "";

        //Funcion Consulta General
        public OdbcDataReader funcConsulta(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                return reader;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en Consulta General: " + Error);
                return null;
            }
        }
    }
}
