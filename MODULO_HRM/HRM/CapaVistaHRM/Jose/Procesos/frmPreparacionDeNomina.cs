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
using CapaControladorHRM.Jose;

namespace CapaVistaHRM.Jose.Procesos
{
    public partial class frmPreparacionDeNomina : Form
    {
        ClsControladorJose Cn = new ClsControladorJose();
        Form MDI;
        public frmPreparacionDeNomina(Form FormularioMDI)
        {
            InitializeComponent();
            MDI = FormularioMDI;
            llenarCombos();
        }

        private void frmPreparacionDeNomina_Load(object sender, EventArgs e)
        {

        }

        void llenarCombos()
        {
            cmbPercepcionDeduccion.Items.Clear();
            cmbPercepcionDeduccion.Items.Add("Seleccione...");
            llenarse("tipopercepciondeduccion", "tipoPercepcionDeduccion", "idTipoPercepcionDeduccion", cmbPercepcionDeduccion);
            cmbPercepcionDeduccion.SelectedIndex = 0;
        }

        void llenarse(string tabla, string campo1,string campo2, ComboBox ComboBox)
        {

            string[] items = Cn.itemsDosParametros(tabla, campo1, campo2);
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
            var dt2 = Cn.enviarDosParametros(tabla, campo1,campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {
                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            llenarCombos();
            txtCodigo.Text = "";
        }

        private void cmbPercepcionDeduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPercepcionDeduccion.SelectedIndex != 0 )
            {
                if(cmbPercepcionDeduccion.SelectedItem != null)
                {
                string[] codigo = cmbPercepcionDeduccion.SelectedItem.ToString().Split('-');
               try
                  {
                   Int32.Parse(codigo[0]);
                   txtCodigo.Text = codigo[0];
                  }
                   catch(Exception)
                   {
                    Int32.Parse(codigo[1]);
                    txtCodigo.Text = codigo[1];
                   }
                }
            }
        }

        private void cmbPercepcionDeduccion_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cmbPercepcionDeduccion.SelectedIndex == 0 || cmbPercepcionDeduccion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un elemento valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool validar = true;
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvPercepciones);
                string Codigo = "";
                foreach (DataGridViewRow item in dgvPercepciones.Rows)
                {
                    Codigo = Convert.ToString(item.Cells["Column1"].Value);
                    if (Codigo == txtCodigo.Text)
                    {
                        MessageBox.Show("No se puede agregar la misma Percepcion / Deduccion 2 veces.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        validar = false;
                    }
                }
                if(validar)
                {
                    fila.Cells[0].Value = txtCodigo.Text;
                    fila.Cells[1].Value = cmbPercepcionDeduccion.SelectedItem.ToString();
                    dgvPercepciones.Rows.Add(fila);
                    cmbPercepcionDeduccion.SelectedIndex = 0;
                    txtCodigo.Text = "";
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int contador = 0;
                foreach (DataGridViewRow item in dgvPercepciones.Rows)
                {
                contador++;
                }
            if(contador > 0)
            {
                dgvPercepciones.Rows.Remove(dgvPercepciones.CurrentRow);
            }       
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (DataGridViewRow item in dgvPercepciones.Rows)
            {
                contador++;
            }
            if (contador == 0)
            {
                MessageBox.Show("No se puede dejar la tabla vacia, debe contener almenos una Percepcion/Deduccion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                List<string> PercepcionesDeducciones = new List<string>();
                string codigo = "";
                foreach (DataGridViewRow item in dgvPercepciones.Rows)
                {
                    codigo = Convert.ToString(item.Cells["Column1"].Value);         
                    PercepcionesDeducciones.Add(codigo);
                }
                frmGenerarNomina fr = new frmGenerarNomina(PercepcionesDeducciones,MDI);
                fr.MdiParent = MDI;
                fr.Show();
                this.Close();
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvPercepciones.Rows.Clear();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaJose/AyudaNomina.chm","PreparacionNomina.html");
        }
    }
}
