using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloHRM;
using CapaModeloHRM.Billy;

namespace CapaControladorHRM.Billy
{
    public class clsCRUDRecursos
    {
        clsQuerrys Modelo = new clsQuerrys();
        public OdbcDataReader funcObtenerIdMovimientoEncabezado()
        {
            string strConsulta = "SELECT MAX(pkIdEncabezadoRecursos +1) FROM EncabezadoRecursos;";
            return Modelo.funcConsulta(strConsulta);
        }
    }
}
