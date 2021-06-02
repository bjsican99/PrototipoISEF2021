using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Sergio;
using CapaVistaHRM.Sergio.Procesos;

namespace CapaVistaHRM.Sergio.Mantenimientos
{
    public partial class frmCurso : Form
    {
        ClsControladorSergio Cn = new ClsControladorSergio();
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmCurso(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            llenarCombos();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 306;
            navegador1.tbl = "curso";
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
            navegador1.ayudaRuta = "AyudasSergio/AyudasMantenimiento.chm";
            navegador1.ruta = "AYUDA FORMULARIO CURSO.html";
        }

        private void rdActivo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdInactivo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        void llenarCombos()
        {
            cmbCompetencia.Items.Clear();

            cmbCompetencia.Items.Add("Seleccione...");
            llenarComboBox("competencia", "nombreCompetencia", cmbCompetencia); //tabla, campo, combo
            cmbCompetencia.SelectedIndex = 0;
        }
        void llenarComboBox(string tabla, string campo1, ComboBox ComboBox)
        {
            string[] items = Cn.funcItems(tabla, campo1);
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        ComboBox.Items.Add(items[i]);
                    }
                }

            }
            var dt2 = Cn.enviarCombo(tabla, campo1);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtCompetencia.Text = cmbCompetencia.SelectedIndex.ToString();
        }

        private void frmCurso_Load(object sender, EventArgs e)
        {

        }

        private void rdActivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void txtEstado_TextChanged_1(object sender, EventArgs e)
        {
            if (txtEstado.Text == "")
            {
                rdActivo.Checked = false;
                rdInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rdActivo.Checked = true;
            }
        }

        private void rdInactivo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }
    }
}
