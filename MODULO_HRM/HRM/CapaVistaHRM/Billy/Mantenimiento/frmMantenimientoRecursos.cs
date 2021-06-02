using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaHRM.Billy.Mantenimiento
{
    public partial class frmMantenimientoRecursos : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmMantenimientoRecursos(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void frmMantenimientoRecursos_Load(object sender, EventArgs e)
        {

        }

        private void rbHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "1";
        }

        private void rbDeshabilitado_CheckedChanged(object sender, EventArgs e)
        {
            txtEstado.Text = "0";
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //llenado de  parametros para la aplicacion 
            navegador1.aplicacion = 309;
            navegador1.tbl = "tiporecurso";
            navegador1.campoEstado = "estadoRecurso";
            navegador1.MDIformulario = FormularioPadre;

            //se agregan los componentes del formulario a la lista tipo control
            foreach (Control C in this.Controls)
            {
                if (C.Tag != null)
                {
                    if (C.Tag.ToString() == "saltar")
                    {

                    }
                    else
                    {
                        if (C is TextBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is ComboBox)
                        {
                            lista.Add(C);
                        }
                        else if (C is DateTimePicker)
                        {
                            lista.Add(C);
                        }
                    }
                }
            }

            navegador1.control = lista;
            navegador1.formulario = this;
            navegador1.DatosActualizar = dgvTipoRecursos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudaMantenimientosMan/AyudaMantenimiento2.chm";
            navegador1.ruta = "Ayuda_Mantenimiento Tipo Evaluacion.html";
        }
    }
}
