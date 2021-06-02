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
    public partial class frmAgregarAcapacitacion : Form
    {
        ClsControladorSergio cn = new ClsControladorSergio();
        public frmAgregarAcapacitacion()
        {
            InitializeComponent();
            actualizardatagriew();
            CodigoMaximo("DETALLECAPACITACION", "idEncabezadoCapacitacion", txtCodigo);
            cmbOpciones.SelectedIndex = 0;
            cmbCapacitacion.Items.Clear();
            cmbCapacitacion.Items.Add("Seleccione...");
            llenarComboBox("ENCABEZADOCAPACITACION", "tituloCapacitacion",cmbCapacitacion ); //tabla, campo, combo|||| TABLAS(RECLUTAMIENTO, EMPLEADO),CAMPOS (R.nombre,R.apellido,R.idRecluta)
            
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
                //  dgvEmpleados.Visible = false;

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
                //dgvEmpleados.Visible = false;

            }
            else if (cmbOpciones.SelectedIndex == 2)
            {
                txtRangoInicio.Visible = true;
                txtRangoFinal.Visible = true;
                cmbEmpleado.Visible = false;
                btnEmpleados.Visible = true;

            }
            else if (cmbOpciones.SelectedIndex == 0)
            {
                btnEmpleados.Visible = false;
                //dgvEmpleados.Visible = false;
            }



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

        public void actualizardatagriew()
        {
            string tabla = "DETALLECAPACITACION";
            DataTable dt = cn.llenarTbl(tabla);
            dataGridView2.DataSource = dt;
        }

        private void frmAgregarAcapacitacion_Load(object sender, EventArgs e)
        {

        }

        public void limpiarCampos()
        {
            cmbEmpleado.SelectedIndex = 0;
            txtRangoFinal.Text = "";
            txtRangoInicio.Text = "";
        }

        void llenarComboBox2(string tabla1, string tabla2, string campo1, string campo2, string campo3, ComboBox ComboBox)
        {
            string[] items = cn.funcItems2(tabla1, tabla2, campo1, campo2, campo3);
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

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmpleado.Text = cmbEmpleado.SelectedIndex.ToString();
        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            string b;
            string c;
            string d;
         
            List<string> DatosPeticion = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                DatosPeticion.Clear();
                a = Convert.ToString(row.Cells["Column1"].Value);
                b = Convert.ToString(row.Cells["Column2"].Value);
                c = Convert.ToString(row.Cells["Column3"].Value);
                d = Convert.ToString(row.Cells["Column4"].Value);
                

                if (a == "" || b == "" || c == "" || d == "" )
                {

                }
                else
                {
                    DatosPeticion.Add(a);
                    DatosPeticion.Add(b);
                    DatosPeticion.Add(c);
                    DatosPeticion.Add(d);
                   
                    if (cn.procDatosInsertar("DETALLECAPACITACION", DatosPeticion))
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEmpleado.Text=="")
            {
                MessageBox.Show("Llene todos los campos para poder ingresar elementos");
            }
            else
            {
              
                if (cmbOpciones.SelectedIndex == 1)
                {

                    
                    string code = txtCapacitacion.Text.ToString();                   
                    string employee = txtEmpleado.Text.ToString();
                    string resultado = "0";
                    string estado = "1";
                    // string[] gettingd = cn.funcCodigoFULL(employee,code);
                    //gettingd[0]+" "+gettingd[1]

                    if (dataGridView1.Rows.Count == 0)
                    {

                        dataGridView1.Rows.Add(code,employee, resultado, estado);
                        limpiarCampos();
                        txtCodigo.Text = (int.Parse(txtCodigo.Text) + 1).ToString();
                    }
                    else
                    {

                        dataGridView1.Rows.Add(code,employee, resultado, estado);
                        limpiarCampos();
                        txtCodigo.Text = (int.Parse(txtCodigo.Text) + 1).ToString();

                    }
                }
                else if (cmbOpciones.SelectedIndex == 3)
                {
                  
                    string department = txtEmpleado.Text.ToString();
                    string code = txtCapacitacion.Text.ToString();
                    string employee = txtEmpleado.Text.ToString();
                    string resultado = "0";
                    string estado = "1";

                    string tabla = "PETICIONCAPACITACION";
                    DataTable dt = cn.llenarTblDepartamentos(tabla, department);
                    var dtDepartamento = dt;
                    foreach (DataRow drow in dtDepartamento.Rows)
                    {
                        dataGridView1.Rows.Add(code, drow[0], resultado, estado);
                        code = (int.Parse(code) + 1).ToString();
                    }
                    limpiarCampos();
                    txtCodigo.Text = code;
                    //dgvPeticiones.DataSource =dt;

                }
                else if (cmbOpciones.SelectedIndex == 2)
                {
                    string department = txtEmpleado.Text.ToString();
                    string code = txtCapacitacion.Text.ToString();
                    string employee = txtEmpleado.Text.ToString();
                    string resultado = "0";
                    string estado = "1";

                    string start = txtRangoInicio.Text.ToString();
                    string end = txtRangoFinal.Text.ToString();

                    string tabla = "PETICIONCAPACITACION";
                    DataTable dt = cn.llenarTblRangos(tabla, start, end);
                    var dtDepartamento = dt;
                    foreach (DataRow drow in dtDepartamento.Rows)
                    {
                        dataGridView1.Rows.Add(code, drow[0], resultado, estado);
                        code = (int.Parse(code) + 1).ToString();
                    }
                    limpiarCampos();
                    txtCodigo.Text = code;
                }
            }
        }

        private void cmbCapacitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                txtCapacitacion.Text = cmbCapacitacion.SelectedIndex.ToString();
           
           
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmVerEmpleado frm = new frmVerEmpleado();
            frm.Show();
        }
    }
}
