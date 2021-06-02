using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloHRM.Sergio;

namespace CapaControladorHRM.Sergio
{
    public class ClsControladorSergio
    {
        ClsSentenciasSergio Sn = new ClsSentenciasSergio();


        public string[] funcItems(string Tabla, string Campo)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo);
            return Items;
        }

        public string[] funcItemsCourse(string Tabla, string Campo, string CourseId)
        {
            string[] Items = Sn.funcLlenarCmbCourse(Tabla, Campo, CourseId);
            return Items;
        }

        //Obtener datos ascenso
         public string[] funcItemsAscensos(string Tabla, string Campo, string CourseId, string empleado)
        {
            string[] Items = Sn.funcObtenerDatosAscenso(Tabla, Campo, CourseId, empleado);
            return Items;
        }

        public string[] funcItemsCourseAll(string Tabla, string Campo)
        {
            string[] Items = Sn.funcLlenarCmbCourseAll(Tabla, Campo);
            return Items;
        }

        public string[] funcItems2(string Tabla1, string Tabla2, string Campo1, string Campo2, string Campo3)
        {
            string[] Items = Sn.funcLlenarCmbComplejo(Tabla1, Tabla2, Campo1, Campo2, Campo3);
            return Items;
        }

        public string[] funcItems2Capacitador(string Tabla1, string Tabla2, string Campo1, string Campo2, string Campo3)
        {
            string[] Items = Sn.funcLlenarCmbComplejoCapacitador(Tabla1, Tabla2, Campo1, Campo2, Campo3);
            return Items;
        }

        public string[] funcItems2CapacitadorAll(string Tabla1, string Tabla2, string Campo1, string Campo2, string Campo3)
        {
            string[] Items = Sn.funcLlenarCmbComplejoCapacitadorAll(Tabla1, Tabla2, Campo1, Campo2, Campo3);
            return Items;
        } 
        public DataTable enviarCombo(string tabla, string campo1)
        {
            var dt1 = Sn.obtenerCombo(tabla, campo1);
            return dt1;
        }

        public DataTable enviarComboCourse(string tabla, string campo1, string campo2)
        {
            var dt1 = Sn.obtenerComboCourse(tabla, campo1, campo2);
            return dt1;
        }

        public DataTable enviarCombo2(string Tabla1, string Tabla2, string Campo1, string Campo2, string Campo3)
        {
            var dt1 = Sn.obtenerCombo2(Tabla1, Tabla2, Campo1, Campo2, Campo3);
            return dt1;
        }

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = Sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblEmpleado(string tabla)
        {
            OdbcDataAdapter dt = Sn.llenarTblEmpleado(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblDepartamentos(string tabla, string department)
        {
            OdbcDataAdapter dt = Sn.llenarTblDepartametos(tabla, department);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblEmpleados(string tabla)
        {
            OdbcDataAdapter dt = Sn.llenarTblEmpleados(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblRangos(string tabla, string inicio, string fin)
        {
            OdbcDataAdapter dt = Sn.llenarTblRango(tabla,inicio,fin);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public int funcCodigoMaximo(string Tabla, string Campo)
        {
            int CodigoNuevo = Sn.funcObtenerCodigo(Tabla, Campo);
            return CodigoNuevo;
        }

        public string[] funcCodigoFULL(string codigo, string Campo)
        {
            string[] CodigoNuevo = Sn.funcObtenerDatosINFO(codigo, Campo);
            return CodigoNuevo;
        }


        public bool procDatosInsertar(string tabla, List<string> lista)
        {
            if (Sn.procInsertarDatos(tabla, lista)) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void procDatosInsertarAscensos(string recluta, string puesto, string departamento)
        {
            Sn.procInsertarAscensos(recluta, puesto, departamento);
        }
    }
}
