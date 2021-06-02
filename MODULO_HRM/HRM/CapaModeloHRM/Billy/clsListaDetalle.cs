using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloHRM.Billy
{
    public class clsListaDetalle
    {
        private string fkIdEncabezado;
        private string fkidTipoRecurso;
        private string cantidadUtilizada;

        public string FkIdEncabezado { get => fkIdEncabezado; set => fkIdEncabezado = value; }
        public string FkidTipoRecurso { get => fkidTipoRecurso; set => fkidTipoRecurso = value; }
        public string CantidadUtilizada { get => cantidadUtilizada; set => cantidadUtilizada = value; }
    }
}
