using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaHRM.Manuel.Mantenimientos
{
    public partial class frmTipoEvaluacion : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;

        public frmTipoEvaluacion(string usuario, Form formularioPadre)
        {
            InitializeComponent();

            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            

        }

        private void rbtnActivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rbtnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }


        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //el numero de aplicacion se debe cambiar por el numero asignado en la base de datos 
            navegador1.aplicacion = 312;
            //banco se debe cambiar por la tabla a la que se quiere hacer el mantenimiento
            navegador1.tbl = "tipoevaluacion";
            //estado_banco se debe cambiar por el estado de la tabla a la que se desea hacer mantenimiento
            navegador1.campoEstado = "Estado";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
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
            navegador1.control = lista;
            navegador1.formulario = this;
            //el dataGridView1 se debe cambiar por el que se tiene en el formulario
            navegador1.DatosActualizar = dgvTipoEvaluacion;
            navegador1.procActualizarData();
            navegador1.procCargar();

            navegador1.ayudaRuta = "AyudaMantenimientosMan/AyudaMantenimiento2.chm";
            navegador1.ruta = "Ayuda_Mantenimiento Tipo Evaluacion.html";

        }

  
        private void txtEstado_TextChanged_1(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (txtEstado.Text == "")
            {
                rbtnActivo.Checked = false;
                rbtnInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rbtnActivo.Checked = true;
            }
        }

        private void funcLetras(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
    }
}
