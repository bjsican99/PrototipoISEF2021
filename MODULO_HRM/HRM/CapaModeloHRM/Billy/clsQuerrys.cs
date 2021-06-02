using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloHRM.Billy
{
    public class clsQuerrys
    {
        private DataTable tabla;
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
        public DataTable funcObtenerCamposCombobox(string Comando)
        {
            try
            {
                OdbcDataAdapter datos = new OdbcDataAdapter(Comando, cn.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        //=============================================================================================


        public bool InsertarEncabezadoDetalle(clsListaEncabezado encabezado, List<clsListaDetalle> listaDetalles)
        {
            int bandera = 0;
            var resultado = cn.ObtenerConexion();
            OdbcTransaction transaction = resultado.Item2;
            OdbcCommand cmd = resultado.Item1.CreateCommand();
            cmd.Transaction = transaction;
            try
            {
                strSql = "INSERT INTO encabezadorecursos (pkIdEncabezadoRecursos, fechaEncabezado, fkIdRecluta, estado) " +
                    "VALUES ('" + encabezado.PkIdEncabezadoRecursos + "', '" + encabezado.FechaEncabezado + "', '" + encabezado.FkIdRecluta + "', '" + encabezado.Estado + "');";
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizacion encabezado");
                //Llenado del detalle
                foreach (clsListaDetalle detalle in listaDetalles)
                {
                    try
                    {
                        Console.WriteLine("Entro al foreach");
                        strSql = "INSERT INTO detallerecursos (fkIdEncabezado, fkidTipoRecurso, cantidadUtilizada) " +
                            "VALUES ('" + detalle.FkIdEncabezado + "', '" + detalle.FkidTipoRecurso + "', '" + detalle.CantidadUtilizada + "');";
                        cmd.CommandText = strSql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Guardado En DETALLE");


                    }
                    catch (OdbcException err)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error Rollback\nGuardado en Detalle " + err.Message);
                        Console.WriteLine("eroro", err.Message);
                        bandera = 1;

                        return false;
                    }
                }
            }
            catch (OdbcException err)
            {
                transaction.Rollback();
                MessageBox.Show("Error Rollback\nRealizadio en Insertar Encabezado: " + err.Message);
                bandera = 1;
                return false;
            }
            if (bandera == 0)
            {
                transaction.Commit();
                MessageBox.Show("Realizando commit datos guardados");
            }
            else
            {
                bandera = 0;
            }
            return true;
        }

        public void PruebaRecorrido(clsListaEncabezado encabezado, List<clsListaDetalle> listaDetalles)
        {
            Console.WriteLine(encabezado.PkIdEncabezadoRecursos + "\n" +
                encabezado.FkIdRecluta + "\n" +
                encabezado.FechaEncabezado + "\n" +
                encabezado.Estado + "\n");
            foreach (clsListaDetalle detalle in listaDetalles)
            {
                Console.WriteLine(detalle.FkIdEncabezado + "\n" +
                    detalle.FkidTipoRecurso + "\n" +
                    detalle.CantidadUtilizada + "\n");
            }
        }
    }
}
