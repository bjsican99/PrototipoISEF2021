using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloHRM.Jose
{
    public class ClsSentenciasJose
    {
        ClsConexion Con = new ClsConexion();
        public int funcObtenerCodigo(string NombreTabla, string Campo)
        {
            int Codigo = 0;
            string Sql = "SELECT MAX(" + Campo + ") FROM " + NombreTabla + " ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Codigo = Reader.GetInt32(0);
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError al obtener codigo automatico, revise los parametros " + NombreTabla + " y " + Campo + " "+Ex+" "+" \n -\n -"); }
            return Codigo + 1;
        }

        public string[] funcLlenarComboEspecifico(string Tabla1, string Campo1, int Id, string nombreID)
        {
            string campoTabla = Campo1;
            string nombreTabla = Tabla1;
            int Codigo = Id;
            string nombreCodigo = nombreID;
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + campoTabla + " FROM " + nombreTabla + "  WHERE  " + nombreCodigo + " = " + Codigo + "    ; ";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla1 + "\n -" + Campo1); }
            return Campos;
        }

        public string[] funcLlenarCmb(string Tabla, string Campo)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo + " FROM " + Tabla + " WHERE estado = 1 ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo); }
            return Campos;
        }

        public OdbcDataAdapter obtener(string consulta)
        {
            try
            {
                string sql = consulta;
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, Con.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados " + consulta + " --- " + ex);
                return null;
            }
        }


        public DataTable obtenerCombo(string tabla, string campo1)
        {
            string sql = "SELECT " + campo1 + " FROM " + tabla + " where estado = 1  ;";
            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        public bool procInsertarDatos(string tabla, List<string> lista)
        {
            OdbcConnection con = Con.conexion();
            OdbcCommand comando = con.CreateCommand();
            OdbcTransaction transaccion;
            transaccion = con.BeginTransaction();
            string sql = " INSERT INTO " + tabla + " VALUES (";
            string consulta = sql;
            int contador = lista.Count();
            int i = 1;
            foreach (var items in lista)
            {
                if (i != contador)
                {
                    try
                    {
                        //int 
                        int.Parse(items);
                        sql += " " + items + ", ";
                        consulta += " " + items + ", ";
                    }
                    catch (Exception)
                    {
                        try
                        {
                            //double
                            double.Parse(items);
                            sql += " " + items + ", ";
                            consulta += " " + items + ", ";
                        }
                        catch (Exception)
                        {
                            try
                            {
                                //DateTimePicker
                                DateTime.Parse(items);
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                            catch (Exception)
                            {
                                //string
                                sql += " '" + items + "', ";
                                consulta += " " + items + ", ";
                            }
                        }
                    }
                }
                else
                {
                    break;
                }

                i++;
            }
            var item = lista.Last();
            try
            {
                //int 
                int.Parse(item);
                sql += " " + item + ") ";
                consulta += " " + item + ") ";
            }
            catch (Exception)
            {
                sql += " '" + item + "') ";
                consulta += " " + item + ") ";
            }
            try
            {
               
        
                comando.Transaction = transaccion;
                OdbcCommand comm = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se guardaron correctamente");
                transaccion.Commit();
                Console.WriteLine("Transaccion exitosa!!!!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo existe la tabla o los campos indicados \n -" + tabla + "\n -" + ex + " " + sql);
                transaccion.Rollback();
                Console.WriteLine("Fallida!!!!");
                return false;
            }
        }

        public string[] llenarCmbDosParametros(string tabla, string campo1, string campo2)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            int i = 0;
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 and tipo = 1;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
            return Campos;
        }

        /// Modelo 2 //

        public DataTable obtenerDosParametros(string tabla, string campo1, string campo2)
        {
            string sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1  and tipo = 1 ;";
            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
        public string[] obtenerEmpleadoSalario()
        {
            string[] Campos = new string[300];
            int PosP = 0;
            string Sql = "SELECT E.idEmpleado,R.nombre,R.apellido,P.salario from empleado E, puesto P , reclutamiento R where E.idEmpleado = R.idRecluta and R.idPuesto =P.idPuesto and E.estado = 1; ";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                  Campos[PosP] = Reader.GetValue(0).ToString() + "-" +Reader.GetValue(1).ToString()+ "-"+ Reader.GetValue(2).ToString() + "-" + Reader.GetValue(3).ToString();
                  PosP++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Sql + "\n -" ); }
            return Campos;
        }

        public string[] obtenerPercepcionDeduccion(string codigo)
        {
            string[] Campos = new string[300];
            int Codigo = Int32.Parse(codigo);
            int PosP = 0;
            string Sql = "SELECT T.idTipoPercepcionDeduccion ,T.tipoPercepcionDeduccion,T.valor , T.formula FROM tipopercepciondeduccion T where T.idTipoPercepcionDeduccion = "+Codigo+""; ;
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, Con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[PosP] = Reader.GetValue(0).ToString() + "-"+ Reader.GetValue(1).ToString() + "-" + Reader.GetValue(2).ToString()+"-" + Reader.GetValue(3).ToString();
                    PosP++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Sql + "\n -"); }
            return Campos;
        }
        //percepciones Induviduales
        public string[] llenarCmbDosParametrosIndividuales(string tabla, string campo1, string campo2,int Consulta)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            string sql = "";
            int i = 0;
            if(Consulta == 0)
            {
                sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 and tipo = 2;";
            }
            else if(Consulta == 1)
            {
                sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " ";
            }else if(Consulta == 2)
            {
                sql = "SELECT R." + campo1 + ",R.apellido,P." + campo2+ " FROM " + tabla+" P,reclutamiento R where P.estado = 1 and P.idRecluta = R.idRecluta;";
            }

            try
            {          
                    OdbcCommand command = new OdbcCommand(sql, Con.conexion());
                    OdbcDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Campos[i] = reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString();
                        i++;
                    }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
            return Campos;
        }

        /// Modelo 2 //

        public DataTable obtenerDosParametrosIndividual(string tabla, string campo1, string campo2,int Consulta)
        {
            string sql = "";
            if (Consulta == 0)
            {
                sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " where estado = 1 and tipo = 2;";
            }
            else if (Consulta == 1)
            {
                sql = "SELECT " + campo1 + "," + campo2 + " FROM " + tabla + " ";
            }

            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
                OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
        }

        //percepciones Induviduales
        public string[] llenarComboEmpleado(string tabla, string campo1, string campo2,string campo3)
        {

            string[] Campos = new string[300];
            string[] auto = new string[300];
            string sql ;
            int i = 0;
            sql = "SELECT R." + campo1 + ",R." + campo2 + ",P." + campo3 + " FROM " + tabla + " P,reclutamiento R where P.estado = 1 and P.idRecluta = R.idRecluta;";

            try
            {
                OdbcCommand command = new OdbcCommand(sql, Con.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Campos[i] = reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString() + "-" + reader.GetValue(2).ToString();
                    i++;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + tabla + "\n -" + campo1); }
            return Campos;
        }

        /// Modelo 2 //

        public DataTable obtenerEmpleado(string tabla, string campo1, string campo2, string campo3)
        {
            string sql ;
            sql = "SELECT R." + campo1 + ",R." + campo2 + ",P." + campo3 + " FROM " + tabla + " P,reclutamiento R where P.estado = 1 and P.idRecluta = R.idRecluta;";
            OdbcCommand command = new OdbcCommand(sql, Con.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }
    }
}
