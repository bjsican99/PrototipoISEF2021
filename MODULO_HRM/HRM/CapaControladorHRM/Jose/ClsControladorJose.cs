using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloHRM.Jose;

namespace CapaControladorHRM.Jose
{
    
    public class ClsControladorJose
    {
        ClsSentenciasJose Sn = new ClsSentenciasJose();
        public string[] funcItemsComboBox(string Tabla1, string Campo1, int Id, string nombreID)
        {
            string[] Items = Sn.funcLlenarComboEspecifico(Tabla1, Campo1, Id, nombreID);
            return Items;
        }
        public int funcCodigoMaximo(string Tabla, string Campo)
        {
            int CodigoNuevo = Sn.funcObtenerCodigo(Tabla, Campo);
            return CodigoNuevo;
        }
        public DataTable enviarCombo(string tabla, string campo1)
        {
            var dt1 = Sn.obtenerCombo(tabla, campo1);
            return dt1;
        }
        public DataTable enviar(string consulta)
        {
            try
            {
                OdbcDataAdapter dt = Sn.obtener(consulta);
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }

        }

        public string[] funcItems(string Tabla, string Campo)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo);
            return Items;
        }

        public bool procDatosInsertar(string tabla, List<string> lista)
        {
            if (Sn.procInsertarDatos(tabla, lista))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] itemsDosParametros(string tabla, string campo1, string campo2)
        {
            string[] Items = Sn.llenarCmbDosParametros(tabla, campo1, campo2);
            return Items;
        }
        ///Controlador 2///
        public DataTable enviarDosParametros(string tabla, string campo1, string campo2)
        {
            var dt1 = Sn.obtenerDosParametros(tabla, campo1, campo2);
            return dt1;
        }

        public string[] itemsDosParametrosIndividual(string tabla, string campo1, string campo2,int Consulta)
        {
            string[] Items = Sn.llenarCmbDosParametrosIndividuales(tabla, campo1, campo2, Consulta);
            return Items;
        }
        ///Controlador 2///
        public DataTable enviarDosParametrosIndividual(string tabla, string campo1, string campo2,int Consulta)
        {
            var dt1 = Sn.obtenerDosParametrosIndividual(tabla, campo1, campo2, Consulta);
            return dt1;
        }

        public string[] ObtenerEmpleadoSalario()
        {
            string[] items = Sn.obtenerEmpleadoSalario();
            return items;
        }
        public string[] ObtenePercepcionDeduccion(string Codigo)
        {
            string[] items = Sn.obtenerPercepcionDeduccion(Codigo);
            return items;
        }


        public string[] itemEmpleado(string tabla, string campo1, string campo2, string campo3)
        {
            string[] Items = Sn.llenarComboEmpleado(tabla, campo1, campo2, campo3);
            return Items;
        }
        ///Controlador 2///
        public DataTable enviaritemEmpleado(string tabla, string campo1, string campo2, string campo3)
        {
            var dt1 = Sn.obtenerEmpleado(tabla, campo1, campo2, campo3);
            return dt1;
        }
    }
}
