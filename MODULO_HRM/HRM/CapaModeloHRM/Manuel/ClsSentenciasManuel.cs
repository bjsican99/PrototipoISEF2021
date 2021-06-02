using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloHRM.Manuel
{
    public class ClsSentenciasManuel
    {

        ClsConexion Con = new ClsConexion();

        //Muestra datos en combo Puesto
        public DataTable funcCmbHPuesto()
        {

            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM PUESTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin

        //Muestra datos en combo Departamento
        public DataTable funcCmbHDepto()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM DEPARTAMENTOEMPRESA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Licencia
        public DataTable funcCmbLicencia()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM LICENCIACONDUCIR";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Horario
        public DataTable funcCmbHorario()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPOHORARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Entrevista
        public DataTable funcItemsEntrevista()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPOENTREVISTA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 

        //Muestra datos en combo Induccion
        public DataTable funcItemsInduccion()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPOINDUCCION";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 


        //Muestra datos en combo Horario
        public DataTable funcItemsEvaluacion()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPOEVALUACION";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 



        //Muestra datos en combo Formacion Academica
        public DataTable funcItemsNivelEstudio()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM FORMACIONACADEMICA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 



        //Consulta para buscar un recluta por el Id
        public OdbcDataReader funcBuscarRecluta(string IdRecluta)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.NOMBRE, RE.APELLIDO, RE.DPI, RE.FECHANACIMIENTO, RE.GENERO, RE.ESTADOCIVIL, RE.CORREO, RE.TELEFONO, RE.NUMEROIGSS, LC.TIPOLICENCIA, P.NOMBREPUESTO, HR.TIPOHORARIO, DE.NOMBREDEPARTAMENTO, FA.NOMBREFORMACIONACADEMICA, RE.PROFESIONACTUAL FROM RECLUTAMIENTO AS RE, LICENCIACONDUCIR AS LC, PUESTO AS P, TIPOHORARIO AS HR,DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA WHERE RE.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND RE.IDLICENCIA = LC.IDLICENCIA AND RE.IDPUESTO = P.IDPUESTO AND RE.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND RE.IDHORARIO = HR.IDTIPOHORARIO AND RE.IDRECLUTA = '" + IdRecluta + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //consulta para buscar en la entidad empleados
        public OdbcDataReader funcBuscarEmpleado(string IdEmpleado, int Estado,int Estado2)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.NOMBRE, RE.APELLIDO, RE.DPI, RE.FECHANACIMIENTO, RE.GENERO, RE.ESTADOCIVIL, RE.CORREO, RE.TELEFONO, RE.NUMEROIGSS, LC.TIPOLICENCIA, P.NOMBREPUESTO, HR.TIPOHORARIO, DE.NOMBREDEPARTAMENTO, E.CUENTABANCARIA, E.IDRECLUTA, E.fotografiaPerfil FROM RECLUTAMIENTO AS RE, LICENCIACONDUCIR AS LC, PUESTO AS P, TIPOHORARIO AS HR,DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, EMPLEADO AS E WHERE RE.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND RE.IDLICENCIA = LC.IDLICENCIA AND RE.IDPUESTO = P.IDPUESTO AND RE.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND RE.IDHORARIO = HR.IDTIPOHORARIO AND E.IDRECLUTA = RE.IDRECLUTA AND E.IDEMPLEADO = '" + IdEmpleado + "' AND (E.ESTADO = '" + Estado + "'|| E.ESTADO = '" + Estado2 + "')";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        //consulta para buscar y obtener el valor Id de los combobox
        public OdbcDataReader funcBusquedaCombosRec(string IdRecluta)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.IDLICENCIA, RE.IDPUESTO, RE.IDHORARIO, RE.IDDEPATAMENTOEMPRESA FROM RECLUTAMIENTO AS RE WHERE RE.IDRECLUTA = '" + IdRecluta + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        //Muestra datos en combo Horario
        public DataTable funcCmbContrato()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaPuestos = "SELECT * FROM TIPOCONTRATO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 



        //consulta para buscar y obtener el valor Id de los combobox
        public OdbcDataReader funcBusquedaCombosEmp(string IdEmpleado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.IDLICENCIA, RE.IDPUESTO, RE.IDHORARIO, RE.IDDEPATAMENTOEMPRESA FROM RECLUTAMIENTO AS RE, EMPLEADO AS E WHERE E.IDRECLUTA = RE.IDRECLUTA AND E.IDEMPLEADO = '" + IdEmpleado + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        //consulta para modificar en la entidad Empleado
        public void funcModificarEmpleado(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdEmpleado, string IdRecluta)
        {
            try
            {
                string sentencia = "UPDATE RECLUTAMIENTO SET NOMBRE='" + Nombres + "', APELLIDO='" + Apellidos +
                    "', TELEFONO='" + Telefono + "', CORREO='" + Email + "', DPI='" + Dpi +
                    "', NUMEROIGSS='" + NumIgss + "', 	IDPUESTO='" + Puesto +
                    "', 	IDDEPATAMENTOEMPRESA='" + Departamento + "', IDHORARIO='" + Horario +
                    "', 	ESTADOCIVIL='" + EstadoCivil2 + "', IDLICENCIA='" + TipoLicencia + "' WHERE IDRECLUTA= '" + IdRecluta + "'";


                string sentencia2 = "UPDATE EMPLEADO SET CUENTABANCARIA ='" + CuentaBanc + "' WHERE IDEMPLEADO='" + IdEmpleado + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia2, Con.conexion());
                Query_Validacion1.ExecuteNonQuery();
                Query_Validacion2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //consulta para modificar en la entidad Empleado
        public void funcModificarRecluta(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdRecluta)
        {
            try
            {
                string sentencia = "UPDATE RECLUTAMIENTO SET NOMBRE='" + Nombres + "', APELLIDO='" + Apellidos +
                    "', TELEFONO='" + Telefono + "', CORREO='" + Email + "', DPI='" + Dpi +
                    "', NUMEROIGSS='" + NumIgss + "', 	IDPUESTO='" + Puesto +
                    "', 	IDDEPATAMENTOEMPRESA='" + Departamento + "', IDHORARIO='" + Horario +
                    "', 	ESTADOCIVIL='" + EstadoCivil2 + "', IDLICENCIA='" + TipoLicencia + "' WHERE IDRECLUTA= '" + IdRecluta + "'";


                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());

                Query_Validacion1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Consulta para ingresar una Entrevista
        public void funcInsertarEntrevista(string IdRecluta, int TipoEntrevista, int Punteo, int Resultado,
                string Comentarios, string OpcionRecluta)
        {
            try
            {

                int IdEntrevista;
                string CorrelativoReclu = "SELECT IFNULL(MAX(IDENTREVISTA),0) +1 FROM ENTREVISTA";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.conexion());
                IdEntrevista = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO ENTREVISTA (IDENTREVISTA, IDTIPOENTREVISTA, PUNTEO, " +
                    "RESULTADOENTREVISTA, COMENTARIOS) VALUES " + "('" + IdEntrevista + "','" + TipoEntrevista + "','" + Punteo + "','" + OpcionRecluta + "','"
                    + Comentarios + "')";

                string sentencia = "UPDATE RECLUTAMIENTO SET ESTADO='" + Resultado + "', IDENTREVISTA='" + IdEntrevista + "' WHERE IDRECLUTA='" + IdRecluta + "'";


                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.conexion());
                Query_IngresoRec.ExecuteNonQuery();

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());
                Query_Validacion1.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Consulta para ingresar una Entrevista
        public void funcInsertarInduccion(string IdEmpleado, int TipoInduccion, string FechaInduccion, int EstadoInd, int EstadoEmp)
        {
            try
            {

                int IdInduccion;
                string CorrelativoReclu = "SELECT IFNULL(MAX(idInduccion),0) +1 FROM induccion";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.conexion());
                IdInduccion = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO induccion (idInduccion, idEmpleado, idtipoInduccion, " +
                    "FechaInduccion, Estado) VALUES " + "('" + IdInduccion + "','" + IdEmpleado + "','" + TipoInduccion + "','" + FechaInduccion + "','"
                    + EstadoInd + "')";

                string sentencia = "UPDATE empleado SET estado ='" + EstadoEmp + "' WHERE idEmpleado ='" + IdEmpleado + "'";


                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.conexion());
                Query_IngresoRec.ExecuteNonQuery();

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());
                Query_Validacion1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Consulta para ingresar datos en la entidad reclutamiento
        public void funcInsertarRecluta(string PrimerNom, string PrimerAp, string Dpi, string NombreProf, string FechaNac,
            int Genero, string EstadoCivil, string Email, int Telefono, int NumIgss, string FechaReclu, int TipoLicencia,
            int Puesto, int Horario, int Departamento, int NivelEstudio, int EstadoRecluta)
        {
            try
            {
                int IdRecluta;
                string CorrelativoReclu = "SELECT IFNULL(MAX(IDRECLUTA),0) +1 FROM RECLUTAMIENTO";

                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.conexion());
                IdRecluta = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO RECLUTAMIENTO (IDRECLUTA, NOMBRE, APELLIDO, " +
                    "DPI, PROFESIONACTUAL, FECHANACIMIENTO, GENERO, ESTADOCIVIL," +
                    "CORREO, TELEFONO, NUMEROIGSS,FECHARECLUTAMIENTO, IDLICENCIA," +
                    "IDPUESTO, IDHORARIO,IDDEPATAMENTOEMPRESA,IDFORMACIONACADEMICA," +
                    "ESTADO) VALUES " + "('" + IdRecluta + "','" + PrimerNom + "','" + PrimerAp + "','" + Dpi + "','"
                    + NombreProf + "','" + FechaNac + "','" + Genero + "','" + EstadoCivil + "','" + Email + "','" + Telefono + "','" + NumIgss + "','"
                    + FechaReclu + "','" + TipoLicencia + "','" + Puesto + "','" + Horario + "','" + Departamento + "','" + NivelEstudio + "','" + EstadoRecluta + "')";


                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.conexion());
                Query_IngresoRec.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //SENTENCIAS PARA MOSTRAR DATOS BANCO TALENTO Y RECLUTAS
        //consulta para mostrar datos de la entidad reclutamiento

        public OdbcDataAdapter funcTablaBancoTalento(int PrOpcion, int SgOpcion, int Recomendados)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.IDRECLUTA,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO,H.TIPOHORARIO, R.CORREO, R.TELEFONO, LC.TIPOLICENCIA, R.PROFESIONACTUAL, FA.NOMBREFORMACIONACADEMICA FROM RECLUTAMIENTO AS R, FORMACIONACADEMICA AS FA, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, TIPOHORARIO AS H WHERE R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND (R.ESTADO='" + PrOpcion + "' OR R.ESTADO='" + SgOpcion + "' OR R.ESTADO='" + Recomendados + "') ORDER BY R.ESTADO DESC ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Id
        public OdbcDataAdapter funcTablaBancoTalentoId(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.IDRECLUTA,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO,H.TIPOHORARIO, R.CORREO, R.TELEFONO, LC.TIPOLICENCIA, R.PROFESIONACTUAL, FA.NOMBREFORMACIONACADEMICA FROM RECLUTAMIENTO AS R, FORMACIONACADEMICA AS FA, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, TIPOHORARIO AS H WHERE R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND (R.ESTADO='" + PrOpcion + "' OR R.ESTADO='" + SgOpcion + "' OR R.ESTADO='" + Recomendados + "') AND R.IDRECLUTA LIKE ('" + Parametro + "%') ORDER BY R.ESTADO DESC ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por primer nombre
        public OdbcDataAdapter funcTablaBancoTalentoNombre(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.IDRECLUTA,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO,H.TIPOHORARIO, R.CORREO, R.TELEFONO, LC.TIPOLICENCIA, R.PROFESIONACTUAL, FA.NOMBREFORMACIONACADEMICA FROM RECLUTAMIENTO AS R, FORMACIONACADEMICA AS FA, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, TIPOHORARIO AS H WHERE R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND (R.ESTADO='" + PrOpcion + "' OR R.ESTADO='" + SgOpcion + "' OR R.ESTADO='" + Recomendados + "') AND R.NOMBRE LIKE ('" + Parametro + "%') ORDER BY R.ESTADO DESC ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por primer apellido
        public OdbcDataAdapter funcTablaBancoTalentoApellido(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.IDRECLUTA,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO,H.TIPOHORARIO, R.CORREO, R.TELEFONO, LC.TIPOLICENCIA, R.PROFESIONACTUAL, FA.NOMBREFORMACIONACADEMICA FROM RECLUTAMIENTO AS R, FORMACIONACADEMICA AS FA, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, TIPOHORARIO AS H WHERE R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND (R.ESTADO='" + PrOpcion + "' OR R.ESTADO='" + SgOpcion + "' OR R.ESTADO='" + Recomendados + "') AND R.APELLIDO LIKE ('" + Parametro + "%') ORDER BY R.ESTADO DESC ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Puesto
        public OdbcDataAdapter funcTablaBancoTalentoPuesto(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.IDRECLUTA,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO,H.TIPOHORARIO, R.CORREO, R.TELEFONO, LC.TIPOLICENCIA, R.PROFESIONACTUAL, FA.NOMBREFORMACIONACADEMICA FROM RECLUTAMIENTO AS R, FORMACIONACADEMICA AS FA, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, TIPOHORARIO AS H WHERE R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND (R.ESTADO='" + PrOpcion + "' OR R.ESTADO='" + SgOpcion + "' OR R.ESTADO='" + Recomendados + "') AND P.NOMBREPUESTO LIKE ('" + Parametro + "%') ORDER BY R.ESTADO DESC ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Departamento
        public OdbcDataAdapter funcTablaBancoTalentoDepartamento(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.IDRECLUTA,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO,H.TIPOHORARIO, R.CORREO, R.TELEFONO, LC.TIPOLICENCIA, R.PROFESIONACTUAL, FA.NOMBREFORMACIONACADEMICA FROM RECLUTAMIENTO AS R, FORMACIONACADEMICA AS FA, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, TIPOHORARIO AS H WHERE R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND (R.ESTADO='" + PrOpcion + "' OR R.ESTADO='" + SgOpcion + "' OR R.ESTADO='" + Recomendados + "') AND DE.NOMBREDEPARTAMENTO LIKE ('" + Parametro + "%') ORDER BY R.ESTADO DESC ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Reclutamiento por Profesion
        public OdbcDataAdapter funcTablaBancoTalentoHorario(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT R.IDRECLUTA,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO,H.TIPOHORARIO, R.CORREO, R.TELEFONO, LC.TIPOLICENCIA, R.PROFESIONACTUAL, FA.NOMBREFORMACIONACADEMICA FROM RECLUTAMIENTO AS R, FORMACIONACADEMICA AS FA, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, TIPOHORARIO AS H WHERE R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND (R.ESTADO='" + PrOpcion + "' OR R.ESTADO='" + SgOpcion + "' OR R.ESTADO='" + Recomendados + "') AND H.TIPOHORARIO LIKE ('" + Parametro + "%') ORDER BY R.ESTADO DESC ";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());


                return dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //MOSTRAR DATOS DE EMPLEADO

        //consulta para mostrar datos de la entidad empleado
        public OdbcDataAdapter funcTablaEmpleado(int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.IDEMPLEADO,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO, H.TIPOHORARIO, R.CORREO, R.TELEFONO, R.NUMEROIGSS, LC.TIPOLICENCIA, E.CUENTABANCARIA FROM EMPLEADO AS E, RECLUTAMIENTO AS R, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, TIPOHORARIO AS H , TIPOCONTRATO AS TP WHERE E.IDRECLUTA = R.IDRECLUTA AND E.IDTIPOCONTRATO = TP.IDTIPOCONTRATO AND R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND E.ESTADO = '" + Estado + "'";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //consulta para mostrar datos de la entidad Empleado por Id
        public OdbcDataAdapter funcFiltradoIdEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.IDEMPLEADO,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO, H.TIPOHORARIO, R.CORREO, R.TELEFONO, R.NUMEROIGSS, LC.TIPOLICENCIA, E.CUENTABANCARIA FROM EMPLEADO AS E, RECLUTAMIENTO AS R, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, TIPOHORARIO AS H , TIPOCONTRATO AS TP WHERE E.IDRECLUTA = R.IDRECLUTA AND E.IDTIPOCONTRATO = TP.IDTIPOCONTRATO AND R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND E.ESTADO = '" + Estado + "' AND E.IDEMPLEADO LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }

        //consulta para mostrar datos de la entidad Empleado por Primer Nombre
        public OdbcDataAdapter funcFiltradoNombreEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.IDEMPLEADO,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO, H.TIPOHORARIO, R.CORREO, R.TELEFONO, R.NUMEROIGSS, LC.TIPOLICENCIA, E.CUENTABANCARIA FROM EMPLEADO AS E, RECLUTAMIENTO AS R, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, TIPOHORARIO AS H , TIPOCONTRATO AS TP WHERE E.IDRECLUTA = R.IDRECLUTA AND E.IDTIPOCONTRATO = TP.IDTIPOCONTRATO AND R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND E.ESTADO = '" + Estado + "' AND R.NOMBRE LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
        //consulta para mostrar datos de la entidad Empleado por Primer Apellido
        public OdbcDataAdapter funcFiltradoApellidoEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.IDEMPLEADO,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO, H.TIPOHORARIO, R.CORREO, R.TELEFONO, R.NUMEROIGSS, LC.TIPOLICENCIA, E.CUENTABANCARIA FROM EMPLEADO AS E, RECLUTAMIENTO AS R, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, TIPOHORARIO AS H , TIPOCONTRATO AS TP WHERE E.IDRECLUTA = R.IDRECLUTA AND E.IDTIPOCONTRATO = TP.IDTIPOCONTRATO AND R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND E.ESTADO = '" + Estado + "' AND R.APELLIDO LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }
        //consulta para mostrar datos de la entidad Empleado por Puesto
        public OdbcDataAdapter funcFiltradoPuestoEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.IDEMPLEADO,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO, H.TIPOHORARIO, R.CORREO, R.TELEFONO, R.NUMEROIGSS, LC.TIPOLICENCIA, E.CUENTABANCARIA FROM EMPLEADO AS E, RECLUTAMIENTO AS R, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, TIPOHORARIO AS H , TIPOCONTRATO AS TP WHERE E.IDRECLUTA = R.IDRECLUTA AND E.IDTIPOCONTRATO = TP.IDTIPOCONTRATO AND R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND E.ESTADO = '" + Estado + "' AND P.NOMBREPUESTO LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }



        //consulta para mostrar datos de la entidad Empleado por Departamento
        public OdbcDataAdapter funcFiltradoDepartamentoEmpleado(string Parametro, int Estado)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT E.IDEMPLEADO,R.NOMBRE, R.APELLIDO, P.NOMBREPUESTO, DE.NOMBREDEPARTAMENTO, H.TIPOHORARIO, R.CORREO, R.TELEFONO, R.NUMEROIGSS, LC.TIPOLICENCIA, E.CUENTABANCARIA FROM EMPLEADO AS E, RECLUTAMIENTO AS R, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, TIPOHORARIO AS H , TIPOCONTRATO AS TP WHERE E.IDRECLUTA = R.IDRECLUTA AND E.IDTIPOCONTRATO = TP.IDTIPOCONTRATO AND R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND E.ESTADO = '" + Estado + "' AND DE.NOMBREDEPARTAMENTOEMPRESA LIKE ('" + Parametro + "%')";

                OdbcDataAdapter dataTable = new OdbcDataAdapter(sentencia, Con.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


        }

        //Consulta para buscar un recluta Evaluado
        public OdbcDataReader funcBuscarReclutaEvaluado(string IdRecluta)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT RE.NOMBRE, RE.APELLIDO, P.NOMBREPUESTO, HR.TIPOHORARIO, DE.NOMBREDEPARTAMENTO, E.PUNTEO, E.RESULTADOENTREVISTA, E.COMENTARIOS FROM RECLUTAMIENTO AS RE, LICENCIACONDUCIR AS LC, PUESTO AS P, TIPOHORARIO AS HR,DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, ENTREVISTA AS E, TIPOENTREVISTA AS TP WHERE RE.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND RE.IDLICENCIA = LC.IDLICENCIA AND RE.IDPUESTO = P.IDPUESTO AND RE.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND RE.IDHORARIO = HR.IDTIPOHORARIO AND E.IDTIPOENTREVISTA = TP.IDTIPOENTREVISTA AND E.IDENTREVISTA = RE.IDENTREVISTA AND RE.IDRECLUTA = '" + IdRecluta + "'";


                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Consulta para ingresar una Evaluacion
        public void funcInsertarEvaluacion(string IdRecluta, int TipoEvaluacion, int Punteo, int Resultado,
                string Comentarios, string OpcionRecluta)
        {
            try
            {
                
                int IdEvaluacion;
                string CorrelativoReclu = "SELECT IFNULL(MAX(idEvaluacion),0) +1 FROM EVALUACION ";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.conexion());
                IdEvaluacion = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO EVALUACION  (idEvaluacion, idRecluta, idtipoEvaluacion, PunteoEvaluacion	, " +
                    "ResultadoEvaluacion, Comentarios) VALUES " + "('" + IdEvaluacion + "','" + IdRecluta + "','" + TipoEvaluacion + "','" + Punteo + "','" + OpcionRecluta + "','"
                    + Comentarios + "')";

                string sentencia = "UPDATE RECLUTAMIENTO SET estado ='" + Resultado + "' WHERE idRecluta='" + IdRecluta + "'";


                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.conexion());
                Query_IngresoRec.ExecuteNonQuery();

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());
                Query_Validacion1.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //consulta para ingresar datos en la entidad empleado
        //Consulta para Contratar un Recluta
        public void funcContratar(string IdRecluta, int CuentaBanc, int TipoContrato, string LinkFoto, string FechaCont, int EstadoEmp, int EstadoRec)
        {
            try
            {
                int IdEmpleado;
                string CorrelativoEmpleado = "SELECT IFNULL(MAX(IDEMPLEADO),0) +1 FROM EMPLEADO";

                OdbcCommand QueryIdEmpleado = new OdbcCommand(CorrelativoEmpleado, Con.conexion());
                IdEmpleado = Convert.ToInt32(QueryIdEmpleado.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdEmpleado.ExecuteReader();


                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaEmpleado = "INSERT INTO EMPLEADO(IDEMPLEADO, IDRECLUTA,CUENTABANCARIA, IDTIPOCONTRATO," +
                    " FOTOGRAFIAPERFIL, FECHACONTRATACION, ESTADO) VALUES " + "('" + IdEmpleado + "','" + IdRecluta + "','" + CuentaBanc + "','"
                    + TipoContrato + "','" + LinkFoto + "','" + FechaCont + "','" + EstadoEmp + "')";

                string sentencia = "UPDATE RECLUTAMIENTO SET ESTADO= '" + EstadoRec + "'WHERE IDRECLUTA='" + IdRecluta + "'";

                OdbcCommand Query_IngresoEmp = new OdbcCommand(SentenciaEmpleado, Con.conexion());
                Query_IngresoEmp.ExecuteNonQuery();

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());
                Query_Validacion1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Muestra datos en combo Recomendado
        public DataTable funcCmbEmpleado()
        {
            DataTable Datos = new DataTable();
            try
            {
                
                string CargaPuestos = "SELECT concat(R.NOMBRE,' ',R.APELLIDO) AS DATOS FROM EMPLEADO AS E, RECLUTAMIENTO AS R, LICENCIACONDUCIR AS LC, PUESTO AS P, DEPARTAMENTOEMPRESA AS DE, FORMACIONACADEMICA AS FA, TIPOHORARIO AS H , TIPOCONTRATO AS TP WHERE E.IDRECLUTA = R.IDRECLUTA AND E.IDTIPOCONTRATO = TP.IDTIPOCONTRATO AND R.IDFORMACIONACADEMICA = FA.IDFORMACIONACADEMICA AND R.IDLICENCIA = LC.IDLICENCIA AND R.IDPUESTO = P.IDPUESTO AND R.IDDEPATAMENTOEMPRESA = DE.IDDEPARTAMENTOEMPRESA AND R.IDHORARIO = H.IDTIPOHORARIO AND R.ESTADO='" + 6 + "' AND E.ESTADO='"+1+"'";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin 


    

    }
}
