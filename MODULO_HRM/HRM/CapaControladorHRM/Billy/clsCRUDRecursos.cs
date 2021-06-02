using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable funcObtenerCamposCombobox(string Campo1, string Campo2, string Tabla, string Estado)
        {
            string Comando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + Estado + "= 1;");
            return Modelo.funcObtenerCamposCombobox(Comando);
        }
        //=============================================================================================
        clsListaEncabezado encabezado = new clsListaEncabezado();//clase encabezado en capa modelo
        List<clsListaDetalle> listDetalle = new List<clsListaDetalle>();//lista para llenar el detalle 

        public void funcLlenarListaEncabezado(string pkIdEncabezado1, string fechaEncabezado1, string fkIdRecluta1)
        {
            encabezado.PkIdEncabezadoRecursos = pkIdEncabezado1;
            encabezado.FechaEncabezado = fechaEncabezado1;
            encabezado.FkIdRecluta = fkIdRecluta1;
            encabezado.Estado = "1";
        }

        public void funcLlenarlistasDetalle(string fkIdEncabezado1, string fkidTipoRecurso1, string cantidadUtilizada1)
        {
            clsListaDetalle listaDetalle = new clsListaDetalle();
            listaDetalle.FkIdEncabezado = fkIdEncabezado1;
            listaDetalle.FkidTipoRecurso = fkidTipoRecurso1;
            listaDetalle.CantidadUtilizada = cantidadUtilizada1;
            listDetalle.Add(listaDetalle);
        }

        public void funcEliminar()
        {
            listDetalle.Clear();
        }
        public void pruebarecorrido()
        {
            Modelo.PruebaRecorrido(encabezado, listDetalle);
        }
        public void insertarEnTransaccion()
        {
            bool prueba = Modelo.InsertarEncabezadoDetalle(encabezado, listDetalle);
        }
    }
}
