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
using CapaVistaHRM.Jose.Informes;
using DGVPrinterHelper;

namespace CapaVistaHRM.Jose.Informes
{
    public partial class frmReportes : Form
    {
        ClsControladorJose Cn = new ClsControladorJose();
        int opcion = 0;
        public frmReportes()
        {
            InitializeComponent();
            llenarCombos();
            cmbEmpleado.Visible = false;
            cmbNomina.Visible = false;
            lblNomina.Visible = false;
            lblEmpleado.Visible = false;
            lblInicio.Visible = false;
            lblFin.Visible = false;
            dtInicio.Visible = false;
            dtFin.Visible = false;
        }
        void llenarCombos()
        {
            ////////////////
            cmbNomina.Items.Clear();
            cmbNomina.Items.Add("Seleccione...");
            llenarse("encabezadonomina", "nombreNomina", "idEncabezadoNomina", cmbNomina, 1);
            cmbNomina.SelectedIndex = 0;
            ////////////////
            cmbEmpleado.Items.Clear();
            cmbEmpleado.Items.Add("Seleccione...");
            llenarseEmpleado("empleado", "nombre", "apellido", "idEmpleado", cmbEmpleado);
            cmbEmpleado.SelectedIndex = 0;

        }
        void llenarseEmpleado(string tabla, string campo1, string campo2, string campo3, ComboBox ComboBox)
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
        void llenarse(string tabla, string campo1, string campo2, ComboBox ComboBox, int Consulta)
        {

            string[] items = Cn.itemsDosParametrosIndividual(tabla, campo1, campo2, Consulta);
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

        void separarCombo(ComboBox cmb, TextBox txt)
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(rdGeneral.Checked == true)
            {
                if(cmbNomina.SelectedIndex == 0  || cmbNomina.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un elemento valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string consulta = "select N.idEncabezadoNomina as Nomina, R.Nombre as Nombre ,R.Apellido as Apellido, P.tipoPercepcionDeduccion as Percepciones, N.valor as valor from detallenomina N, empleado E, reclutamiento R, tipopercepciondeduccion P where N.idEmpleado = E.idEmpleado and E.idRecluta = R.idRecluta and N.idTipoPercepcionDeduccion = P.idTipoPercepcionDeduccion   and N.idEncabezadoNomina = " + Int32.Parse(txtCodigoNomina.Text) + " order by N.idEmpleado; ";
                    DataTable dt = Cn.enviar(consulta);
                    dgvDatos.DataSource = dt;
                }
         
            }
            else if(rdEmpleado.Checked == true)
            {
                if (cmbNomina.SelectedIndex == 0 || cmbNomina.SelectedItem == null || cmbEmpleado.SelectedIndex == 0 || cmbEmpleado.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un elemento valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string consulta = "select N.idEncabezadoNomina as Codigo_Nomina, R.Nombre as Nombre ,R.Apellido as Apellido,  P.tipoPercepcionDeduccion as Percepcion, N.valor as valor from detallenomina N, empleado E, reclutamiento R, tipopercepciondeduccion P where N.idEmpleado = E.idEmpleado and E.idRecluta = R.idRecluta and N.idTipoPercepcionDeduccion = P.idTipoPercepcionDeduccion  and N.idEncabezadoNomina = " + Int32.Parse(txtCodigoNomina.Text) + " and N.idEmpleado = " + Int32.Parse(txtCodigoEmpleado.Text) + " order by N.idEmpleado; ";
                    DataTable dt = Cn.enviar(consulta);
                    dgvDatos.DataSource = dt;
                }
            }
            else if(rdFechas.Checked == true)
            {
                string fechaInicio = dtInicio.Value.ToString("yyyy-MM-dd");
                string fechaFin = dtFin.Value.ToString("yyyy-MM-dd");
                if(dtInicio.Value > dtFin.Value)
                {
                    MessageBox.Show("La fecha de inicio no puede ser mayor a la final", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    string consulta = "select  N.idEncabezadoNomina as Codigo_Nomina, R.Nombre as Nombre ,R.Apellido as Apellido,  P.tipoPercepcionDeduccion as Percepcion, N.valor as valor from detallenomina N, empleado E, reclutamiento R, tipopercepciondeduccion P , encabezadonomina G where N.idEmpleado = E.idEmpleado and E.idRecluta = R.idRecluta and N.idTipoPercepcionDeduccion = P.idTipoPercepcionDeduccion and G.idEncabezadoNomina = N.idEncabezadoNomina and(G.fechaInicio between '" + fechaInicio + "' and '" + fechaFin + "') and(G.fechaFin between '" + fechaInicio + "' and '" + fechaFin + "') order by N.idEncabezadoNomina and N.idEmpleado; ";
                    DataTable dt = Cn.enviar(consulta);
                    dgvDatos.DataSource = dt;
                }
               
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                if (opcion == 1)
                {
                    printer.Title = "Nomina general";
                }
                else if (opcion == 2)
                {
                    printer.Title = "Resumen de empleado";
                }
                else if (opcion == 3)
                {
                    printer.Title = "Reporte de nomina por Fechas";
                }
                printer.SubTitle = string.Format("Fecha: {0}", DateTime.Today.ToString("dd-MM-yyyy hh:mm tt"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvDatos);
                MessageBox.Show("El informe se ha IMPRESO / GUARDADO Exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ups!! ha ocurrido un error, consulte con soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNomina_SelectedIndexChanged(object sender, EventArgs e)
        {
            separarCombo(cmbNomina, txtCodigoNomina);
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            separarCombo(cmbEmpleado, txtCodigoEmpleado);
        }

        private void rdGeneral_CheckedChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            cmbEmpleado.Visible = false;
            cmbNomina.Visible = true;
            lblNomina.Visible = true;
            lblEmpleado.Visible = false;
            lblInicio.Visible = false;
            lblFin.Visible = false;
            dtInicio.Visible = false;
            dtFin.Visible = false;
            opcion = 1;
        }

        private void rdEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            cmbNomina.Visible = true;
            lblNomina.Visible = true;
            cmbEmpleado.Visible = true;
            lblEmpleado.Visible = true;
            lblInicio.Visible = false;
            lblFin.Visible = false;
            dtInicio.Visible = false;
            dtFin.Visible = false;
            opcion = 2;
        }

        private void rdFechas_CheckedChanged(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            cmbNomina.Visible = false;
            lblNomina.Visible = false;
            cmbEmpleado.Visible = false;
            lblEmpleado.Visible = false;
            lblInicio.Visible = true;
            lblFin.Visible = true;
            dtInicio.Visible = true;
            dtFin.Visible = true;
            opcion = 3;
        }
    }
}
