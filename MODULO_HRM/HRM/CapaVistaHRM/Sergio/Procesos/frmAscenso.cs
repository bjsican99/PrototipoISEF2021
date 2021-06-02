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
using CapaVistaHRM.Sergio.Mantenimientos;

namespace CapaVistaHRM.Sergio.Procesos
{
    public partial class frmAscenso : Form
    {
        ClsControladorSergio cn = new ClsControladorSergio();
        public frmAscenso()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text=="")
            {

            }
            else
            {
                string nombre = "txtNombre";
                string apellido = "txtApellido";
                string prevPuesto = "txtPrevPuesto";
                string prevDepartamento = "txtPrevDepartamento";
                string empleado = txtIdEmpleado.Text.ToString();
                llenarComboseInfoAscenso(nombre, apellido, prevPuesto, prevDepartamento, empleado);

            }

        }

        //ASCENSOS
        void llenarComboseInfoAscenso(string campo1, string campo2, string campo3, string campo4, string empleado)
        {
            string[] items = cn.funcItemsAscensos(campo1, campo1, campo1, empleado);
            
            string datosAsc ="";
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        datosAsc += items[i].ToString();
                    }
                }

            }
            //MessageBox.Show("Items:" +datosAsc);
            Char delimiter = '-';
            String[] substrings = datosAsc.Split(delimiter);
            txtRecluta.Text = substrings[0];
            txtNombre.Text =substrings[1];
            txtApellido.Text = substrings[2];
            txtPrevPuesto.Text = substrings[3];
            txtPrevDepartamento.Text = substrings[4];
        }

        private void frmAscenso_Load(object sender, EventArgs e)
        {
            cmbNuevoPuesto.Items.Clear();
            cmbNuevoPuesto.Items.Add("Seleccione...");
            llenarComboBox("puesto", "nombrePuesto", cmbNuevoPuesto);
            cmbNuevoPuesto.SelectedIndex = 0;

            cmbNuevoDepartamento.Items.Clear();
            cmbNuevoDepartamento.Items.Add("Seleccione...");
            llenarComboBox("departamentoempresa", "nombreDepartamento", cmbNuevoDepartamento);
            cmbNuevoDepartamento.SelectedIndex = 0;
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

        private void cmbNuevoPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNextPuesto.Text = cmbNuevoPuesto.SelectedIndex.ToString();
        }

        private void cmbNuevoDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNextDepartamento.Text = cmbNuevoDepartamento.SelectedIndex.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cn.procDatosInsertarAscensos(txtRecluta.Text.ToString(), txtNextPuesto.Text.ToString(), txtNextDepartamento.Text.ToString());
            MessageBox.Show("Actualización de puesto realizada con éxito");
            procLimpiar();
        }

        public void procLimpiar()
        {
            txtRecluta.Text = "";
            txtIdEmpleado.Text = "";
            cmbNuevoDepartamento.SelectedIndex=0;
            cmbNuevoPuesto.SelectedIndex=0;
            txtPrevDepartamento.Text = "";
            txtPrevPuesto.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerEmpleado frm = new frmVerEmpleado();
            frm.Show();

        }
    }
}
