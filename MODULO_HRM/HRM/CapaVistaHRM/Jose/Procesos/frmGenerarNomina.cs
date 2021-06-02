using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Jose;
namespace CapaVistaHRM.Jose.Procesos
{
    public partial class frmGenerarNomina : Form
    {

        ClsControladorJose Cn = new ClsControladorJose();
        List<string> PercepcionesDeducciones = new List<string>();
        Form MDI;
        public frmGenerarNomina(List<string> Percepciones,Form FormularioPadre)
        {
            InitializeComponent();
            PercepcionesDeducciones = Percepciones;
            MDI = FormularioPadre;
            llenarCombos();
            CodigoMaximo("encabezadonomina","idEncabezadoNomina",txtCodigo);  
        }

        public void CodigoMaximo(string tabla, string campo, TextBox txt)
        {
            string tbl = tabla;
            string cmp1 = campo;
            TextBox txt1 = txt;
            int codigo = Cn.funcCodigoMaximo(tbl, cmp1);
            txt1.Text = codigo.ToString();
            txt1.Enabled = false;
        }
        void llenarCombos()
        {
            cmbMoneda.Items.Clear();
            cmbMoneda.Items.Add("Seleccione...");
            llenarComboBox("tipomoneda", "tipoMoneda", cmbMoneda);
            cmbMoneda.SelectedIndex = 0;
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

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoMoneda.Text = cmbMoneda.SelectedIndex.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int Contador = 0;
                foreach (DataGridViewRow item in dgvNomina.Rows)
                {
                    Contador++;
                }
                if (txtNombre.Text == "" || txtCodigoMoneda.Text == "" || cmbMoneda.SelectedIndex == 0 || cmbMoneda.SelectedItem == null || Contador == 0)
                {
                    MessageBox.Show("Asegurese de haber llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                if ((dtInicio.Value.Date > dtFinal.Value.Date) || (dtFinal.Value.Date < dtInicio.Value.Date))
                {
                    MessageBox.Show("Fechas no validas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string fechaInicio = dtInicio.Value.ToString("yyyy-MM-dd");
                    string fechaFinal = dtFinal.Value.ToString("yyyy-MM-dd");
                        ///////////////DATOS A INGRESAR DE NOMINA ENCABEZADO
                        List<string> DatosNomina = new List<string>();
                        List<string> DatosGrid = new List<string>();
                        DatosNomina.Add(txtCodigo.Text);
                        DatosNomina.Add(txtNombre.Text);
                        DatosNomina.Add(fechaInicio);
                        DatosNomina.Add(fechaFinal);
                        DatosNomina.Add("0.0");
                        DatosNomina.Add(txtCodigoMoneda.Text);
                        ///////////////DATOS A INGRESAR DE NOMINA DETALLE
                        string CodigoEmpleado = "";
                        string CodigoNomina = "";
                        string CodigoPercepcion = "";
                        string Valor = "";
                        /////////////////////////////////////////////////
                        if (Cn.procDatosInsertar("encabezadonomina", DatosNomina))
                        {
                            foreach (DataGridViewRow item in dgvNomina.Rows)
                            {
                                DatosGrid.Clear();
                                CodigoNomina = Convert.ToString(item.Cells["Column1"].Value);
                                CodigoEmpleado = Convert.ToString(item.Cells["Column2"].Value);
                                CodigoPercepcion = Convert.ToString(item.Cells["Column4"].Value);
                                Valor = Convert.ToString(item.Cells["Column6"].Value); ;
                                DatosGrid.Add(CodigoNomina);
                                DatosGrid.Add(CodigoEmpleado);
                                DatosGrid.Add(CodigoPercepcion);
                                DatosGrid.Add(Valor);
                                Cn.procDatosInsertar("detallenomina", DatosGrid);
                            }
                            MessageBox.Show("Los Datos han sido Guardados Exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CodigoMaximo("encabezadonomina", "idEncabezadoNomina", txtCodigo);
                            dgvNomina.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Upss, ha ocurrido un error, consulta con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                
            }
          
        }
        void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbMoneda.SelectedIndex = 0;
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvNomina.Rows.Clear();
        }
        
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int Contador = 0;
                foreach (DataGridViewRow item in dgvNomina.Rows)
                {
                    Contador++;
                }
                if (Contador > 0)
                {
                    MessageBox.Show("Debe Borrar la tabla primero si desea volver a generar la nomina.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<string> DatosPercepciones = new List<string>();
                    List<string> DatosEmpleado = new List<string>();
                    DataGridViewRow fila = new DataGridViewRow();
                    fila.CreateCells(dgvNomina);
                    //Se obtiene el codigo - valor - Formula de las percpeciones / deducciones que se seleccionaron en el formulario anterior y se almacenan en una nueva lista
                    foreach (var PD in PercepcionesDeducciones)
                    {
                        string[] percepcionDeduccion = Cn.ObtenePercepcionDeduccion(PD);
                        for (int i = 0; i < percepcionDeduccion.Length; i++)
                        {
                            if (percepcionDeduccion[i] != null)
                            {
                                if (percepcionDeduccion[i] != "")
                                {
                                    DatosPercepciones.Add(percepcionDeduccion[i]);
                                }
                            }
                        }
                    }
                    //se obtienen a todos los empleados de la base de datos
                    string[] empleados = Cn.ObtenerEmpleadoSalario();
                    for (int i = 0; i < empleados.Length; i++)
                    {
                        if (empleados[i] != null)
                        {
                            if (empleados[i] != "")
                            {
                                DatosEmpleado.Add(empleados[i]);
                            }
                        }
                    }
                    foreach (var item in DatosEmpleado)
                    {
                        string[] CodigoEmpleado = item.Split('-');
                        foreach (var item2 in DatosPercepciones)
                        {
                            string[] ValoresPercepciones = item2.Split('-');
                            dgvNomina.Rows.Add(txtCodigo.Text, CodigoEmpleado[0], (CodigoEmpleado[1] + " " + CodigoEmpleado[2]), ValoresPercepciones[0], ValoresPercepciones[1], ValoresPercepciones[2]);
                        }
                    }
                }
            }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (DataGridViewRow item in dgvNomina.Rows)
            {
                contador++;
            }
            if (contador > 0)
            {
                dgvNomina.Rows.Remove(dgvNomina.CurrentRow);
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtInicio.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha inicial no puede ser menor a la de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtInicio.Value = DateTime.Today;
            }else if(dtInicio.Value > dtFinal.Value)
            {
                MessageBox.Show("La fecha Mayor a la final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtInicio.Value = dtFinal.Value;
            }
        }
        private void dtFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtFinal.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha final no puede ser menor a la de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtFinal.Value = DateTime.Today;
            }else
            if (dtFinal.Value < dtInicio.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor a la inicial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtFinal.Value = dtInicio.Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPreparacionDeNomina frm = new frmPreparacionDeNomina(MDI);
            frm.MdiParent = MDI;
            frm.Show();
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"AyudaJose/AyudaNomina.chm","Generacion de nomina.html");
        }
    }
}
