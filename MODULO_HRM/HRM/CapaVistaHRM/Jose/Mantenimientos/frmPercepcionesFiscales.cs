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

namespace CapaVistaHRM.Jose.Mantenimientos
{
    public partial class frmPercepcionesFiscales : Form
    {
        ClsValidaciones validar = new ClsValidaciones();
        ClsControladorJose Cn = new ClsControladorJose();
        string UsuarioAplicacion;
        static Form FormularioPadre;
        public frmPercepcionesFiscales(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            llenarCombos();
        }

        void llenarCombos()
        {
            cmbPercepcionDeduccion1.Items.Clear();        
            cmbOperacion.Items.Clear();
            cmbPercepcionDeduccion1.Items.Add("Seleccione...");        
            llenarse("tipopercepciondeduccion", "tipoPercepcionDeduccion", cmbPercepcionDeduccion1);
            cmbPercepcionDeduccion1.SelectedIndex = 0;          
            ComboOperaciones();
            cmbOperacion.SelectedIndex = 0;
        }

        void llenarse(string tabla, string campo1, ComboBox ComboBox)
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


        void ComboOperaciones()
        {
            cmbOperacion.Items.Add("Seleccione...");
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
            cmbOperacion.Items.Add("(");
            cmbOperacion.Items.Add(")");
        }
        private void rdActivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1

            if (rdActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rdInactivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  0
            if (rdInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }




        private void rdValor_CheckedChanged(object sender, EventArgs e)
        {
          
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1

            if (rdValor.Checked == true)
                {
                    txtCantidad.Text = "0.0";
                }
            
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
            if (rdFormula.Checked == true)
            {
                txtFormula.Text = "Sin Formula Especificada.";
            }
           
        }




        private void rdPositivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1

            if (rdPositivo.Checked == true)
            {
                txtSigno.Text = "+";
            }
        }

        private void rdNegativo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  0
            if (rdNegativo.Checked == true)
            {
                txtSigno.Text = "-";
            }
        }

        void LimpiarParametrosFormula()
        {
            cmbPercepcionDeduccion1.SelectedIndex = 0;
            cmbOperacion.SelectedIndex = 0;
            txtValorFormula.Text = "";
        }
        int validaciones()
        {
            if (rdTipoSi.Checked == true && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == true)
            {
                if (cmbPercepcionDeduccion1.SelectedIndex == 0 || cmbPercepcionDeduccion1.SelectedItem == null || cmbOperacion.SelectedIndex == 0 || txtValorFormula.Text == "")
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else if (rdTipoSi.Checked == true && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == false)
            {
                if (cmbPercepcionDeduccion1.SelectedIndex == 0 || cmbPercepcionDeduccion1.SelectedItem == null || cmbOperacion.SelectedIndex == 0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
            else if (rdTipoSi.Checked == true && rdOperacionSi.Checked == false && rdValorFormulaSi.Checked == false)
            {
                if (cmbPercepcionDeduccion1.SelectedIndex == 0 || cmbPercepcionDeduccion1.SelectedItem == null)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
            else if (rdTipoSi.Checked == false && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == true)
            {
                if (cmbOperacion.SelectedIndex == 0 || cmbOperacion.SelectedItem == null || txtValorFormula.Text == "")
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
            else if (rdTipoSi.Checked == false && rdOperacionSi.Checked == false && rdValorFormulaSi.Checked == true)
            {
                if (txtValorFormula.Text == "")
                {
                    return 8;
                }
                else
                {
                    return 9;
                }
            }
            else if (rdTipoSi.Checked == false && rdOperacionSi.Checked == true && rdValorFormulaSi.Checked == false)
            {
                if (cmbOperacion.SelectedIndex == 0 || cmbOperacion.SelectedItem == null)
                {
                    return 10;
                }
                else
                {
                    return 11;
                }
            }
            else
            {
                return 13;
            }
        }
        private void btnAgregarFormula_Click(object sender, EventArgs e)
        {
            if (rdTipoSi.Checked == false && rdOperacionSi.Checked == false && rdValorFormulaSi.Checked == false)
            {

                MessageBox.Show("Debe seleccionar una de las opciones, que desea agregar a la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                switch (validaciones())
                {
                    case 0:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 1:
                        txtFormula.Text += " ( " + cmbPercepcionDeduccion1.SelectedItem.ToString() + " " + cmbOperacion.SelectedItem.ToString() + " " + txtValorFormula.Text + " ) ";
                        rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;

                        LimpiarParametrosFormula();
                        break;
                    case 2:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 3:
                        txtFormula.Text += " ( " + cmbPercepcionDeduccion1.SelectedItem.ToString() + " " + cmbOperacion.SelectedItem.ToString() + " ";
                        rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                        LimpiarParametrosFormula();
                        break;
                    case 4:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 5:
                        txtFormula.Text += " ( " + cmbPercepcionDeduccion1.SelectedItem.ToString() + " ";
                        rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                        LimpiarParametrosFormula();
                        break;
                    case 6:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 7:
                        if (txtFormula.Text == "")
                        {
                            MessageBox.Show("No se puede agregar un operador como primer parametro de la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtFormula.Text += " " + cmbOperacion.SelectedItem.ToString() + " " + txtValorFormula.Text + " ";
                            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }

                        break;
                    case 8:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 9:
                        if (txtFormula.Text == "")
                        {
                            txtFormula.Text += " ( " + txtValorFormula.Text + " ";
                            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }
                        else
                        {
                            txtFormula.Text += " " + txtValorFormula.Text + " ";
                            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }
                        break;
                    case 10:
                        MessageBox.Show("Falta almenos uno de los parametros seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 11:
                        if (txtFormula.Text == "" && cmbOperacion.SelectedItem.ToString() != "(")
                        {
                            MessageBox.Show("No puede agregar un signo como primer parametro en la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            txtFormula.Text += " " + cmbOperacion.SelectedItem.ToString() + " ";
                            rdTipoNo.Checked = true; rdOperacionNo.Checked = true; rdValorFormulaNo.Checked = true;
                            LimpiarParametrosFormula();
                        }
                        break;
                    default:
                        MessageBox.Show("Debe seleccionar, lo que desea agregar a la formula.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }

        private void btnRestaurarValoresFormula_Click(object sender, EventArgs e)
        {
            txtFormula.Text = "";
            cmbPercepcionDeduccion1.SelectedIndex = 0;
            cmbOperacion.SelectedIndex = 0;
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            navegador1.aplicacion = 317;
            navegador1.tbl = "tipopercepciondeduccion";
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
            navegador1.DatosActualizar = dgvDatos;
            navegador1.procActualizarData();
            navegador1.procCargar();
            navegador1.ayudaRuta = "AyudaJose/AyudaMantenimientosJose.chm";
            navegador1.ruta = "AYUDA-FORMULARIO-PERCEPCIONES.html";
        }

        private void txtFormula_TextChanged(object sender, EventArgs e)
        {
            if (txtFormula.Text.Length == 0)
            {
                rdFormula.Checked = false;
                rdFormula.Enabled = true;
            }
            else
            {
                rdFormula.Enabled = false;
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            //si el campo estado esta vacio coloca los 2 radioButons en falso, para que se puedan volver a seleccionar
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

        private void txtSigno_TextChanged(object sender, EventArgs e)
        {
            if (txtSigno.Text == "")
            {
                rdPositivo.Checked = false;
                rdNegativo.Checked = false;
            }
            if (txtSigno.Text == "+")
            {
                rdPositivo.Checked = true;
            }
            if (txtSigno.Text == "-")
            {
                rdNegativo.Checked = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length == 0)
            {
                rdValor.Checked = false;
                rdValor.Enabled = true;
            }
            else
            {
                rdValor.Enabled = false;
            }
        }

        private void rdGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGeneral.Checked == true)
            {
                txtTipo.Text = "1";
            }
        }

        private void rdIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (rdIndividual.Checked == true)
            {
                txtTipo.Text = "2";
            }
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            if (txtTipo.Text == "")
            {
                rdGeneral.Checked = false;
                rdIndividual.Checked = false;
            }
            if (txtTipo.Text == "1")
            {
                rdGeneral.Checked = true;
            }
            if (txtTipo.Text == "2")
            {
                rdIndividual.Checked = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            validar.funcSoloNumerosDecimales(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.funcSoloLetras(e);
            validar.ValidadCantidad(e, txtNombre, 48);
        }
    }
}
