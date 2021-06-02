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
    public partial class faltas : Form
    {

        string UsuarioAplicacion;
        static Form FormularioPadre;

        public faltas(string usuario, Form formularioPadre)
        {
            InitializeComponent();

            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void faltas_Load(object sender, EventArgs e)
        {
          
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 306;
            navegador1.tbl = "tipofalta";
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

        private void Activo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1

            if (Activo.Checked == true)
            {
                textBox5.Text = "1";
            }
        }

        private void Inactivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  0
            if (Inactivo.Checked == true)
            {
                textBox5.Text = "0";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //si el campo estado esta vacio coloca los 2 radioButons en falso, para que se puedan volver a seleccionar
            if (textBox5.Text == "")
            {
                Activo.Checked = false;
                Inactivo.Checked = false;
            }
            if (textBox5.Text == "1")
            {
                Activo.Checked = true;
            }
        }
    }
}
