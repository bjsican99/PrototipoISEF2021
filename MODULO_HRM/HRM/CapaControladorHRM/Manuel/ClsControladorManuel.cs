using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using CapaModeloHRM.Manuel;
using System.Data.Odbc;

namespace CapaControladorHRM.Manuel
{
    public class ClsControladorManuel
    {

        ClsSentenciasManuel sn = new ClsSentenciasManuel();

        //Paso de datos comboPuesto
        public DataTable funcItemsPuesto()
        {
            DataTable Items = sn.funcCmbHPuesto();
            return Items;
        }

        //Paso de datos Depto
        public DataTable funcItemsDepto()
        {
            DataTable Items = sn.funcCmbHDepto();
            return Items;
        }
        //Paso de datos Licencia de Conducir

        public DataTable funcItemsLicencia()
        {
            DataTable Items = sn.funcCmbLicencia();
            return Items;
        }
        //Paso de datos Horario
        public DataTable funcItemsHorario()
        {
            DataTable Items = sn.funcCmbHorario();
            return Items;
        }

        //Paso de datos Tipo Entrevista
        public DataTable funcItemsEntrevista()
        {
            DataTable Items = sn.funcItemsEntrevista();
            return Items;
        }

        //Paso de datos Tipo Entrevista
        public DataTable funcItemsEvaluacion()
        {
            DataTable Items = sn.funcItemsEvaluacion();
            return Items;
        }

        //Paso de datos Tipo Entrevista
        public DataTable funcItemsInduccion()
        {
            DataTable Items = sn.funcItemsInduccion();
            return Items;
        }


        //Paso de datos Formacion Academica
        public DataTable funcItemsNivelEstudio()
        {
            DataTable Items = sn.funcItemsNivelEstudio();
            return Items;
        }

        //Paso de datos Tipo Contrato
        public DataTable funcCmbContrato()
        {
            DataTable Items = sn.funcCmbContrato();
            return Items;
        }

        //consulta de busqueda por Id 
        public OdbcDataReader funcBuscarRecluta(string IdRecluta)
        {
            OdbcDataReader Lector = sn.funcBuscarRecluta(IdRecluta);
            return Lector;
        }

        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBuscarEmpleado(string IdEmpleado, int Estado,int Estado2)
        {
            OdbcDataReader Lector = sn.funcBuscarEmpleado(IdEmpleado, Estado, Estado2);
            return Lector;
        }

        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBusquedaCombosRec(string IdRecluta)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombosRec(IdRecluta);
            return Lector2;
        }

        //Paso de datos para consulta buscar en la entidad empleados
        public OdbcDataReader funcBusquedaCombosEmp(string IdEmpleado)
        {
            OdbcDataReader Lector2 = sn.funcBusquedaCombosEmp(IdEmpleado);
            return Lector2;
        }



        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcModificarEmpleado(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdEmpleado, string IdRecluta)
        {

            sn.funcModificarEmpleado(Nombres, Apellidos, Telefono, Email, Dpi, NumIgss,
                            Puesto, Departamento, Horario, EstadoCivil2, TipoLicencia, CuentaBanc, IdEmpleado, IdRecluta);

        }


        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcModificarRecluta(string Nombres, string Apellidos, int Telefono, string Email,
                int Dpi, int NumIgss, int Puesto, int Departamento, int Horario, string EstadoCivil2, int TipoLicencia,
                 string CuentaBanc, string IdRecluta)
        {


            sn.funcModificarRecluta(Nombres, Apellidos, Telefono, Email, Dpi, NumIgss,
                            Puesto, Departamento, Horario, EstadoCivil2, TipoLicencia, CuentaBanc, IdRecluta);

        }

        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcInsertarEntrevista(string IdRecluta, int TipoEntrevista, int Punteo, int Resultado,
                string Comentarios, string OpcionRecluta)
        {

            sn.funcInsertarEntrevista(IdRecluta, TipoEntrevista, Punteo, Resultado, Comentarios, OpcionRecluta);

        }

        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcInsertarInduccion(string IdEmpleado, int TipoInduccion, string FechaInduccion, int EstadoInd, int EstadoEmp)
        {

            sn.funcInsertarInduccion(IdEmpleado, TipoInduccion, FechaInduccion, EstadoInd, EstadoEmp);

        }


        //consulta para insertar a la entidad Reclutamiento
        public void funcInsertarRecluta(string PrimerNom, string PrimerAp, string Dpi, string NombreProf, string FechaNac,
            int Genero, string EstadoCivil, string Email, int Telefono, int NumIgss, string FechaReclu, int TipoLicencia,
            int Puesto, int Horario, int Departamento, int NivelEstudio, int EstadoRecluta)
        {
            sn.funcInsertarRecluta(PrimerNom, PrimerAp, Dpi, NombreProf, FechaNac, Genero,
                                   EstadoCivil, Email, Telefono, NumIgss, FechaReclu, TipoLicencia, Puesto, Horario, Departamento, NivelEstudio, EstadoRecluta);
        }


        //CODIGO DE PASO PARAMETROS BANCO TALENTO Y RECLUTAS
        //Paso de datos para consulta mostrar en la entidad reclutamiento
        public DataTable funcTablaBancoTalento(int PrOpcion, int SgOpcion, int Recomendados)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalento(PrOpcion, SgOpcion, Recomendados);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento por Id
        public DataTable funcTablaBancoTalentoId(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoId(PrOpcion, SgOpcion, Recomendados, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Primer Nombre
        public DataTable funcTablaBancoTalentoNombre(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoNombre(PrOpcion, SgOpcion, Recomendados, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Primer Apellido
        public DataTable funcTablaBancoTalentoApellido(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoApellido(PrOpcion, SgOpcion, Recomendados, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Puesto
        public DataTable funcTablaBancoTalentoPuesto(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoPuesto(PrOpcion, SgOpcion, Recomendados, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad reclutamiento por Departamento
        public DataTable funcTablaBancoTalentoDepartamento(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoDepartamento(PrOpcion, SgOpcion, Recomendados, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Paso de datos para consulta mostrar en la entidad reclutamiento por Profesion
        public DataTable funcTablaBancoTalentoHorario(int PrOpcion, int SgOpcion, int Recomendados, string Parametro)
        {
            OdbcDataAdapter dt = sn.funcTablaBancoTalentoHorario(PrOpcion, SgOpcion, Recomendados, Parametro);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //MOSTRAR DATOS DE EMPLEADO

        //Paso de datos para consulta mostrar en la entidad empleado
        public DataTable funcTablaEmpleado(int Estado)
        {
            OdbcDataAdapter dt = sn.funcTablaEmpleado(Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Id
        public DataTable funcFiltradoIdEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoIdEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Primer Nombre
        public DataTable funcFiltradoNombreEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoNombreEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;

        }
        //Paso de datos para consulta mostrar en la entidad empleado por Primer Apellido
        public DataTable funcFiltradoApellidoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoApellidoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Puesto
        public DataTable funcFiltradoPuestoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoPuestoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        //Paso de datos para consulta mostrar en la entidad empleado por Departamento
        public DataTable funcFiltradoDepartamentoEmpleado(string Parametro, int Estado)
        {
            OdbcDataAdapter dt = sn.funcFiltradoDepartamentoEmpleado(Parametro, Estado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //consulta de busqueda por Id 
        public OdbcDataReader funcBuscarReclutaEvaluado(string IdRecluta)
        {
            OdbcDataReader Lector = sn.funcBuscarReclutaEvaluado(IdRecluta);
            return Lector;
        }


        //Paso de datos para consulta modificar en la entidad Empleado
        public void funcInsertarEvaluacion(string IdRecluta, int TipoEvaluacion, int Punteo, int Resultado,
                string Comentarios, string OpcionRecluta)
        {

            sn.funcInsertarEvaluacion(IdRecluta, TipoEvaluacion, Punteo, Resultado, Comentarios, OpcionRecluta);

        }

        //Paso de datos para consulta ingresar en la entidad empleado
        public void funcContratar(string IdRecluta, int CuentaBanc, int TipoContrato, string LinkFoto, string FechaCont, int EstadoEmp, int EstadoRec)
        {
            sn.funcContratar(IdRecluta, CuentaBanc, TipoContrato, LinkFoto, FechaCont, EstadoEmp, EstadoRec);
        }


        public DataTable funcCmbEmpleado()
        {
            DataTable Items = sn.funcCmbEmpleado();
            return Items;
        }


    }
}
