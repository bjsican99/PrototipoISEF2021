using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Sergio;

namespace CapaVistaHRM.Sergio.Procesos
{
    public partial class frmCapacitacion : Form
    {
        ClsControladorSergio cn = new ClsControladorSergio();
        public frmCapacitacion()
        {
            InitializeComponent();
            CodigoMaximo("ENCABEZADOCAPACITACION", "idEncabezadoCapacitacion", txtCodigo);
            loadAllCourses();
            actualizardatagriew();
        }
        public void loadAllCourses()
        {
            cmbCourse.Items.Clear();
            cmbCourse.Items.Add("Seleccione...");
            llenarComboBoxCourseAll("curso", "idCurso", "nombreCurso", cmbCourse);
            cmbCourse.SelectedIndex = 0;
        }
        void llenarComboBoxCourseAll(string tabla, string campo1, string campo2, ComboBox ComboBox)
        {
            string[] items = cn.funcItemsCourseAll(tabla, campo1);
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
            var dt2 = cn.enviarComboCourse(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]) + " - " + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + " - " + Convert.ToString(row[campo1]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void frmCapacitacion_Load(object sender, EventArgs e)
        {

        }
        public void actualizardatagriew()
        {
            string tabla = "ENCABEZADOCAPACITACION";
            DataTable dt = cn.llenarTbl(tabla);
            dgvEncabezado.DataSource = dt;
        }

        public void CodigoMaximo(string tabla, string campo, TextBox txt)
        {
            string tbl = tabla;
            string cmp1 = campo;
            TextBox txt1 = txt;
            int codigo = cn.funcCodigoMaximo(tbl, cmp1);
            txt1.Text = codigo.ToString();
            txt1.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            lblFechaInicio.Text = dtpInicio.Value.ToString();
            if (dtpInicio.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha inicial no puede ser menor a la de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpInicio.Value = DateTime.Today;
            }
            else if (dtpInicio.Value > dtpFin.Value)
            {
                MessageBox.Show("La fecha Mayor a la final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpInicio.Value = dtpFin.Value;
            }
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            lblFechaFin.Text = dtpFin.Value.ToString();
            if (dtpFin.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha final no puede ser menor a la de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFin.Value = DateTime.Today;
            }
            else
            if (dtpFin.Value < dtpInicio.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor a la inicial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFin.Value = dtpInicio.Value;
            }
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseId = cmbCourse.SelectedItem.ToString();
            var data = Regex.Match(courseId, @"\d+").Value;
            txtCourse.Text = data.ToString();
        }

        private void rdbInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInterno.Checked == true)
            {
                txtExterno.Text = "0";
            }
        }

        private void rdbExterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExterno.Checked == true)
            {
                txtExterno.Text = "1";
            }
        }

        private void cmbCapacitador_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseId = cmbCapacitador.SelectedItem.ToString();
            var data = Regex.Match(courseId, @"\d+").Value;
            txtCapacitador.Text = data.ToString();
        }









        void llenarComboBox2Ca(string tabla1, string tabla2, string campo1, string campo2, string campo3, ComboBox ComboBox)
        {
            string[] items = cn.funcItems2Capacitador(tabla1, tabla2, campo1, campo2, campo3);
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
            var dt2 = cn.enviarCombo2(tabla1, tabla2, campo1, campo2, campo3);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo3]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo3]) + "-" + Convert.ToString(row[campo1]));
                coleccion.Add(Convert.ToString(row[campo3]) + "-" + Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));

            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        void llenarComboBox2Ca2(string tabla1, string tabla2, string campo1, string campo2, string campo3, ComboBox ComboBox)
        {
            string[] items = cn.funcItems2CapacitadorAll(tabla1, tabla2, campo1, campo2, campo3);
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
            var dt2 = cn.enviarCombo2(tabla1, tabla2, campo1, campo2, campo3);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo3]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo3]) + "-" + Convert.ToString(row[campo1]));
                coleccion.Add(Convert.ToString(row[campo3]) + "-" + Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));

            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void txtExterno_TextChanged(object sender, EventArgs e)
        {
            if (txtExterno.Text == "0")
            {
                cmbCapacitador.Items.Clear();
                cmbCapacitador.Items.Add("Seleccione...");
                llenarComboBox2Ca("reclutamiento", "empleado", "idRecluta", "nombre", "apellido", cmbCapacitador);
                cmbCapacitador.SelectedIndex = 0;
            }
            else if (txtExterno.Text == "1")
            {
                cmbCapacitador.Items.Clear();
                cmbCapacitador.Items.Add("Seleccione...");
                llenarComboBox2Ca2("reclutamiento", "empleado", "idRecluta", "nombre", "apellido", cmbCapacitador);
                cmbCapacitador.SelectedIndex = 0;
            }
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rdInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void txtActivo_TextChanged(object sender, EventArgs e)
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string codeEncabezado;
            string tituloEncabezado;
            string descripcionEncabezado;
            string externo;
            string idcapacitador;
            string fechainicio;
            string fechafin;
            string idcurso;
            string dificultad;
            string estado;
            List<string> DatosPeticion = new List<string>();
            DatosPeticion.Clear();
             codeEncabezado = txtCodigo.Text.ToString();
             tituloEncabezado=txtTitulo.Text.ToString();
             descripcionEncabezado=txtDescripcion.Text.ToString();
             externo = txtExterno.Text.ToString();
             idcapacitador = txtCapacitador.Text.ToString();
             fechainicio = dtpInicio.Value.ToString();
             fechafin = dtpFin.Value.ToString();
             idcurso = txtCourse.Text.ToString();
             dificultad = txtDificultad.Text.ToString();
             estado = txtEstado.Text.ToString();
            if (codeEncabezado=="" || tituloEncabezado == "" || descripcionEncabezado == "" || externo == "" || idcapacitador == "" || fechainicio == "" || fechafin == "" || idcurso == "" || dificultad == "" || estado == "")
            {
                MessageBox.Show("Hay campos vacios");
            }
            else
            {
                DatosPeticion.Add(codeEncabezado);
                DatosPeticion.Add(tituloEncabezado);
                DatosPeticion.Add(descripcionEncabezado);
                DatosPeticion.Add(externo);
                DatosPeticion.Add(idcapacitador);
                DatosPeticion.Add(fechainicio); 
                DatosPeticion.Add(fechafin);
                DatosPeticion.Add(idcurso);
                DatosPeticion.Add(dificultad);
                DatosPeticion.Add(estado);
                
                if (cn.procDatosInsertar("ENCABEZADOCAPACITACION", DatosPeticion))
                {
                   // MessageBox.Show("funciona");
                }
                else
                {
                   // MessageBox.Show("no funciona");
                }
               
            }

            MessageBox.Show("Datos Guardados con éxito");

            limpiarCampos();
            
            actualizardatagriew();
            CodigoMaximo("ENCABEZADOCAPACITACION", "idEncabezadoCapacitacion", txtCodigo);
        }

        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
            cmbCapacitador.SelectedIndex = 0;
            cmbCourse.SelectedIndex = 0;
            cmbDificultad.SelectedIndex = 0;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }

        private void cmbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDificultad.Text = cmbDificultad.SelectedIndex.ToString();
        }
    }
}
