using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloHRM.Billy
{
    public class clsListaEncabezado
    {
        private string pkIdEncabezadoRecursos;
        private string fechaEncabezado;
        private string fkIdRecluta;
        private string estado;

        public string PkIdEncabezadoRecursos { get => pkIdEncabezadoRecursos; set => pkIdEncabezadoRecursos = value; }
        public string FechaEncabezado { get => fechaEncabezado; set => fechaEncabezado = value; }
        public string FkIdRecluta { get => fkIdRecluta; set => fkIdRecluta = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
