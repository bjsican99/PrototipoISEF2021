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
using System.Text.RegularExpressions;
using CapaVistaHRM.Sergio.Mantenimientos;

namespace CapaVistaHRM.Sergio.Procesos
{
    public partial class frmPeticionCapacitacion : Form
    {
        ClsControladorSergio cn = new ClsControladorSergio();
        public frmPeticionCapacitacion()
        {
            InitializeComponent();
            actualizardatagriew();
            CodigoMaximo("peticioncapacitacion", "idPeticionCapacitacion", txtCodigo);
            cmbOpciones.SelectedIndex = 0;
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
        private void frmPeticionCapacitacion_Load(object sender, EventArgs e)
        {

        }
       
        public void actualizardatagriew()
        { 
            string tabla = "PETICIONCAPACITACION";
            DataTable dt = cn.llenarTbl(tabla);
            dgvPeticiones.DataSource = dt;
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*string EmployeeId = cmbEmpleado.SelectedItem.ToString();
            MessageBox.Show(":" + EmployeeId);
            var data = Regex.Match(EmployeeId,@"\d+").Value;*/
            txtEmpleado.Text = cmbEmpleado.SelectedIndex.ToString();
            /*
              try
            {
                numeros = int.Parse(numero[0]);

            }
            catch (Exception ex)
            {
                numeros = int.Parse(numero[1]);

            }
            txtEmpleado.Text = numeros.ToString();*/
            

        }

     
        void llenarCombos2()
        {
            cmbCompetencias.Items.Clear();
            cmbCompetencias.Items.Add("Seleccione...");
            llenarComboBox("competencia","nombreCompetencia",cmbCompetencias);
            cmbCompetencias.SelectedIndex = 0;
        }
        void llenarComboBox(string tabla, string campo1, ComboBox ComboBox)
        {
            string[] items = cn.funcItems(tabla, campo1);
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
            var dt2 = cn.enviarCombo(tabla, campo1);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Funcion para obtener cursos dependiendo de la competencia seleccionada.
        void llenarComboBoxCourse(string tabla, string campo1, string campo2, ComboBox ComboBox, string CourseId)
        {
            string[] items = cn.funcItemsCourse(tabla, campo1, CourseId);
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
            var dt2 = cn.enviarComboCourse(tabla, campo1,campo2);
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


        





        void llenarComboBoxCourseAll(string tabla, string campo1, string campo2, ComboBox ComboBox, string CourseId)
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

        //Funcion utilizada para la obtención de empleados
        void llenarComboBox2(string tabla1, string tabla2, string campo1, string campo2, string campo3, ComboBox ComboBox)
        {
            string[] items = cn.funcItems2(tabla1, tabla2, campo1,campo2, campo3);
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

        private void cmbEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCompetencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCompetencia.Text = cmbCompetencias.SelectedIndex.ToString();
            string courseId = txtCompetencia.Text.ToString();
            cmbCourse.Items.Clear();
            cmbCourse.Items.Add("Seleccione...");
            llenarComboBoxCourse("curso","idCurso", "nombreCurso", cmbCourse, courseId);
            cmbCourse.SelectedIndex = 0;
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string courseId = cmbCourse.SelectedItem.ToString();
            var data = Regex.Match(courseId, @"\d+").Value;
            txtCourse.Text = data.ToString();
        }

        private void txtCompetencia_TextChanged(object sender, EventArgs e)
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

        private void txtEstado_TextChanged(object sender, EventArgs e)
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

        string datagridInfo = "";
        private void btnSave_Click(object sender, EventArgs e)
        {
            string a;
            string b;
            string c;
            string d;
            string es;
            string fs;
            List<string> DatosPeticion = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                DatosPeticion.Clear();
                a = Convert.ToString(row.Cells["Column1"].Value);
                b = Convert.ToString(row.Cells["Column2"].Value);
                c = Convert.ToString(row.Cells["Column3"].Value);
                d = Convert.ToString(row.Cells["Column4"].Value);
                es = Convert.ToString(row.Cells["Column5"].Value);
                fs = Convert.ToString(row.Cells["Column6"].Value);

                if (a =="" || b == "" || c == "" || d == "" || es == "" || fs == "")
                {

                }
                else
                {
                    DatosPeticion.Add(a);
                    DatosPeticion.Add(b);
                    DatosPeticion.Add(c);
                    DatosPeticion.Add(d);
                    DatosPeticion.Add(es);
                    DatosPeticion.Add(fs);
                    if(cn.procDatosInsertar("peticioncapacitacion", DatosPeticion))
                    {
                        //MessageBox.Show("funciona");
                    }
                    else
                    {
                        //MessageBox.Show("no funciona");
                    }
                    //MessageBox.Show("Datos Guardados con éxito");
                    
                }

                /* for (int i=0; i<DatosPeticion.Count;i++)
                 {
                     string whatlista = DatosPeticion[i];
                     MessageBox.Show("LISTA: " + whatlista);
                 }*/
            }
            limpiarCampos();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            actualizardatagriew();
            CodigoMaximo("peticioncapacitacion", "idPeticionCapacitacion", txtCodigo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text=="" || txtDescripcion.Text==""||txtCourse.Text==""||txtEstado.Text=="")
            {
                MessageBox.Show("Llene todos los campos para poder ingresar elementos");
            }
            else
            {
                btnEmpleados.Visible = false;
                dgvEmpleados.Visible = false;
                lblTitle.Text = "asignación de capacitación";
                if (cmbOpciones.SelectedIndex == 1)
                {
                    string code = txtCodigo.Text.ToString();
                    string title = txtTitulo.Text.ToString();
                    string description = txtDescripcion.Text.ToString();
                    string employee = txtEmpleado.Text.ToString();
                    string courses = txtCourse.Text.ToString();
                    string state = txtEstado.Text.ToString();

                    if (dataGridView1.Rows.Count == 0)
                    {

                        dataGridView1.Rows.Add(code, title, description, employee, courses, state);
                        limpiarCampos();
                        txtCodigo.Text = (int.Parse(txtCodigo.Text) + 1).ToString();
                    }
                    else
                    {

                        dataGridView1.Rows.Add(code, title, description, employee, courses, state);
                        limpiarCampos();
                        txtCodigo.Text = (int.Parse(txtCodigo.Text) + 1).ToString();

                    }
                }
                else if (cmbOpciones.SelectedIndex == 3)
                {
                    string code = txtCodigo.Text.ToString();
                    string title = txtTitulo.Text.ToString();
                    string description = txtDescripcion.Text.ToString();
                    string department = txtEmpleado.Text.ToString();
                    string courses = txtCourse.Text.ToString();
                    string state = txtEstado.Text.ToString();

                    string tabla = "PETICIONCAPACITACION";
                    DataTable dt = cn.llenarTblDepartamentos(tabla, department);
                    var dtDepartamento = dt;
                    foreach (DataRow drow in dtDepartamento.Rows)
                    {
                        dataGridView1.Rows.Add(code, title, description, drow[0], courses, state);
                        code = (int.Parse(code) + 1).ToString();
                    }
                    limpiarCampos();
                    txtCodigo.Text = code;
                    //dgvPeticiones.DataSource =dt;

                }
                else if (cmbOpciones.SelectedIndex == 2)
                {
                    string code = txtCodigo.Text.ToString();
                    string title = txtTitulo.Text.ToString();
                    string description = txtDescripcion.Text.ToString();
                    string employee = txtEmpleado.Text.ToString();
                    string courses = txtCourse.Text.ToString();
                    string state = txtEstado.Text.ToString();

                    string start = txtRangoInicio.Text.ToString();
                    string end = txtRangoFinal.Text.ToString();

                    string tabla = "PETICIONCAPACITACION";
                    DataTable dt = cn.llenarTblRangos(tabla, start, end);
                    var dtDepartamento = dt;
                    foreach (DataRow drow in dtDepartamento.Rows)
                    {
                        dataGridView1.Rows.Add(code, title, description, drow[0], courses, state);
                        code = (int.Parse(code) + 1).ToString();
                    }
                    limpiarCampos();
                    txtCodigo.Text = code;
                }
            }
            

            


        }

        public void limpiarCampos()
        {
            txtTitulo.Text = "";
            txtDescripcion.Text = "";
            cmbEmpleado.SelectedIndex = 0;            
            cmbCourse.SelectedIndex = 0;
            rdActivo.Checked = false;
            rdInactivo.Checked = false;
            txtRangoFinal.Text="";
            txtRangoInicio.Text = "";
            cmbCompetencias.Visible = false;
            cmbCourse.Visible = false;
            
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbOpciones.SelectedIndex == 1)
            {
                txtRangoInicio.Text = "";
                txtRangoFinal.Text = "";
                txtRangoInicio.Visible = false;
                txtRangoFinal.Visible = false;
                cmbEmpleado.Visible = true;
                cmbEmpleado.Items.Clear();
                cmbEmpleado.Items.Add("Seleccione...");
                llenarComboBox2("reclutamiento", "empleado", "idRecluta", "nombre", "apellido", cmbEmpleado); //tabla, campo, combo|||| TABLAS(RECLUTAMIENTO, EMPLEADO),CAMPOS (R.nombre,R.apellido,R.idRecluta)
                cmbEmpleado.SelectedIndex = 0;
                btnEmpleados.Visible = false;
                dgvEmpleados.Visible = false;

            }
            else if (cmbOpciones.SelectedIndex == 3)
            {
                txtRangoInicio.Text = "";
                txtRangoFinal.Text = "";
                txtRangoInicio.Visible = false;
                txtRangoFinal.Visible = false;
                cmbEmpleado.Visible = true;
                cmbEmpleado.Items.Clear();
                cmbEmpleado.Items.Add("Seleccione...");
                llenarComboBox("departamentoempresa", "nombreDepartamento", cmbEmpleado); //tabla, campo, combo|||| TABLAS(RECLUTAMIENTO, EMPLEADO),CAMPOS (R.nombre,R.apellido,R.idRecluta)
                cmbEmpleado.SelectedIndex = 0;
                btnEmpleados.Visible = false;
                dgvEmpleados.Visible = false;

            }
            else if (cmbOpciones.SelectedIndex == 2)
            {
                txtRangoInicio.Visible = true;
                txtRangoFinal.Visible = true;
                cmbEmpleado.Visible = false;
                btnEmpleados.Visible = true;
                
            } else if (cmbOpciones.SelectedIndex ==0)
            {
                btnEmpleados.Visible = false;
                dgvEmpleados.Visible = false;
            }
        }

        private void dgvPeticiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdCompetencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCompetencia.Checked == true)
            {
                cmbCourse.Items.Clear();           
                cmbCompetencias.Visible = true;
                cmbCourse.Visible = true;
                llenarCombos2();
            }
        }

        private void rdCursosGenerales_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCursosGenerales.Checked == true)
            {
               
                cmbCompetencias.Visible = false;
                cmbCourse.Visible = true;
                string courseId = txtCompetencia.Text.ToString();
                cmbCourse.Items.Clear();
                cmbCourse.Items.Add("Seleccione...");
                llenarComboBoxCourseAll("curso", "idCurso", "nombreCurso", cmbCourse, courseId);
                cmbCourse.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {

                }
                else
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }

            }
            catch (Exception Exc) {
                MessageBox.Show("error en: "+Exc);
            }


        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmVerEmpleado frm = new frmVerEmpleado();
            frm.Show();
        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAgregarAcapacitacion frm = new frmAgregarAcapacitacion();
            frm.Show();
        }
    }
}
