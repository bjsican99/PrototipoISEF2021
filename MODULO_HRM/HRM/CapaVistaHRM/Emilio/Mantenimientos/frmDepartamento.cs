using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVistaHRM.Emilio.Mantenimientos
{
    public partial class frmDepartamento : Form
    {

        string UsuarioAplicacion;
        static Form FormularioPadre;


        public frmDepartamento(string usuario, Form formularioPadre)
        {
            InitializeComponent();

            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Activo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1

            if (Activo.Checked == true)
            {
                textBox4.Text = "1";
            }
        }

        private void Inactivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  0
            if (Inactivo.Checked == true)
            {
                textBox4.Text = "0";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //si el campo estado esta vacio coloca los 2 radioButons en falso, para que se puedan volver a seleccionar
            if (textBox4.Text == "")
            {
                Activo.Checked = false;
                Inactivo.Checked = false;
            }
            if (textBox4.Text == "1")
            {
                Activo.Checked = true;
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 308;
            navegador1.tbl = "departamentoempresa";
            navegador1.campoEstado = "estado";
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
            navegador1.DatosActualizar = dataGridView1;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "";
            navegador1.ruta = "";

        }
    }
}
