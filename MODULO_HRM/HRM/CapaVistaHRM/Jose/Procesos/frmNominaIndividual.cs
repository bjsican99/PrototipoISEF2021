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
    public partial class frmNominaIndividual : Form
    {
        ClsControladorJose Cn = new ClsControladorJose();
        ClsValidaciones Validar = new ClsValidaciones();
        public frmNominaIndividual()
        {
            InitializeComponent();
            llenarCombos();
        }

        void llenarCombos()
        {
            cmbPercepciones.Items.Clear();
            cmbPercepciones.Items.Add("Seleccione...");
            llenarse("tipopercepciondeduccion", "tipoPercepcionDeduccion", "idTipoPercepcionDeduccion", cmbPercepciones, 0);
            cmbPercepciones.SelectedIndex = 0;
            ////////////////
            cmbNomina.Items.Clear();
            cmbNomina.Items.Add("Seleccione...");
            llenarse("encabezadonomina", "nombreNomina", "idEncabezadoNomina", cmbNomina,1);
            cmbNomina.SelectedIndex = 0;
            ////////////////
            cmbEmpleado.Items.Clear();
            cmbEmpleado.Items.Add("Seleccione...");
            llenarseEmpleado("empleado", "nombre","apellido" ,"idEmpleado", cmbEmpleado);
            cmbEmpleado.SelectedIndex = 0;

        }
        void llenarseEmpleado(string tabla, string campo1, string campo2,string campo3, ComboBox ComboBox)
        {
            string[] items = Cn.itemEmpleado(tabla, campo1, campo2, campo3);
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
            var dt2 = Cn.enviaritemEmpleado(tabla, campo1, campo2, campo3);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + " " + Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo3]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        void llenarse(string tabla, string campo1, string campo2, ComboBox ComboBox,int Consulta)
        {

            string[] items = Cn.itemsDosParametrosIndividual(tabla, campo1, campo2,Consulta);
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
                var dt2 = Cn.enviarDosParametrosIndividual(tabla, campo1, campo2, Consulta);
                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in dt2.Rows)
                {
                    coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                }
                ComboBox.AutoCompleteCustomSource = coleccion;
                ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cmbNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            separarCombo(cmbNomina, txtCodigoNomina);
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            separarCombo(cmbEmpleado,txtCodigoEmpleado);
        }

        void separarCombo(ComboBox cmb,TextBox txt)
        {
            if (cmb.SelectedIndex != 0)
            {
                if (cmb.SelectedItem != null)
                {
                    string[] codigo = cmb.SelectedItem.ToString().Split('-');
                    try
                    {
                        Int32.Parse(codigo[0]);
                        txt.Text = codigo[0];
                    }
                    catch (Exception)
                    {
                        Int32.Parse(codigo[1]);
                        txt.Text = codigo[1];
                    }
                }
            }
        }

        private void cmbPercepciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            separarCombo(cmbPercepciones, txtCodigoPercepciones);
        }
        void Limpiar()
        {
            cmbEmpleado.SelectedIndex = 0;
            cmbPercepciones.SelectedIndex = 0;
            txtCodigoPercepciones.Text = "";
            txtCodigoEmpleado.Text = "";
            txtValor.Text = "";
            txtCantidad.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex == 0 || cmbEmpleado.SelectedItem == null || cmbPercepciones.SelectedIndex == 0 || cmbPercepciones.SelectedItem == null  || cmbNomina.SelectedIndex == 0 || cmbNomina.SelectedItem == null || txtValor.Text == "")
            {
                MessageBox.Show("Debe seleccionar un elemento valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool validar = true;
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvNominaIndividual);
                string CodigoPercepcion , CodigoEmpleado,CodigoNomina;
                foreach (DataGridViewRow item in dgvNominaIndividual.Rows)
                {
                    CodigoNomina = Convert.ToString(item.Cells["Column1"].Value); 
                    CodigoEmpleado = Convert.ToString(item.Cells["Column2"].Value);
                    CodigoPercepcion = Convert.ToString(item.Cells["Column4"].Value);     
                    if (CodigoPercepcion == txtCodigoPercepciones.Text && CodigoEmpleado == txtCodigoEmpleado.Text)
                    {
                        MessageBox.Show("No se puede agregar la misma Percepcion / Deduccion 2 veces.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validar = false;
                    }
                }
                if (validar)
                {
                    float Total;
                    if(txtCantidad.Text.Length == 0)
                    {
                        fila.Cells[0].Value = txtCodigoNomina.Text;
                        fila.Cells[1].Value = txtCodigoEmpleado.Text;
                        fila.Cells[2].Value = cmbEmpleado.SelectedItem.ToString();
                        fila.Cells[3].Value = txtCodigoPercepciones.Text;
                        fila.Cells[4].Value = cmbPercepciones.SelectedItem.ToString();
                        fila.Cells[5].Value = txtValor.Text;
                        dgvNominaIndividual.Rows.Add(fila);
                        Limpiar();
                    }
                    else
                    {
                        Total = ((float.Parse(txtCantidad.Text)) * (float.Parse(txtValor.Text)));
                        fila.Cells[0].Value = txtCodigoNomina.Text;
                        fila.Cells[1].Value = txtCodigoEmpleado.Text;
                        fila.Cells[2].Value = cmbEmpleado.SelectedItem.ToString();
                        fila.Cells[3].Value = txtCodigoPercepciones.Text;
                        fila.Cells[4].Value = cmbPercepciones.SelectedItem.ToString();
                        fila.Cells[5].Value = Total;
                        dgvNominaIndividual.Rows.Add(fila);
                        Limpiar();
                    }
                    
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (DataGridViewRow item in dgvNominaIndividual.Rows)
            {
                contador++;
            }
            if (contador > 0)
            {
                dgvNominaIndividual.Rows.Remove(dgvNominaIndividual.CurrentRow);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int Contador = 0,VerificacionIngreso = 0;
            List<string> DatosGrid = new List<string>();
            foreach (DataGridViewRow item in dgvNominaIndividual.Rows)
            {
                Contador++;
            }
            if (Contador == 0)
            {
                MessageBox.Show("Debe agregar un registro en a la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
             
                string CodigoEmpleado, CodigoNomina, CodigoPercepcion, Valor;
                foreach (DataGridViewRow item in dgvNominaIndividual.Rows)
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
                   if(Cn.procDatosInsertar("detallenomina", DatosGrid))
                    {
                        VerificacionIngreso++;
                    }
                }
                if(VerificacionIngreso>0)
                {
                    MessageBox.Show("Los Datos han sido Guardados Exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    dgvNominaIndividual.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Upss, ha ocurrido un error, consulta con un experto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaJose/AyudaNomina.chm","NominaIndividual.html");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.funcSoloNumeros(e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.funcSoloNumerosDecimales(e);
        }
    }
}
