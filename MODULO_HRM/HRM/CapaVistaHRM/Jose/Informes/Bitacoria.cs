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
using DGVPrinterHelper;

namespace CapaVistaHRM.Jose.Informes
{
    public partial class Bitacoria : Form
    {
        string consulta = "";
        int opcion = 0;
        ClsControladorJose cn = new ClsControladorJose();
        public Bitacoria()
        {
            InitializeComponent();
        }

        public void procLlenarComboBox(string Tabla1, string Campo1, int Id, string nombreID, ComboBox CmbAgregar)
        {
            string[] Items = cn.funcItemsComboBox(Tabla1, Campo1, Id, nombreID);
            for (int I = 0; I < Items.Length; I++)
            {
                if (Items[I] != null)
                {
                    if (Items[I] != "")
                    {
                        CmbAgregar.Items.Add(Items[I]);
                    }
                }
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (rdIp.Checked == false && rdVarios.Checked == false && radioButton1.Checked == false && rdAplicacion.Checked == false && rdFecha.Checked == false && rdUsuario.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Debe seleccionar uno de los fitros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rdUsuario.Checked == true)
                {
                    if (cmbCodigoUsuario.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar a un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = "SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and L.pk_id_login = " + Int32.Parse(cmbCodigoUsuario.SelectedItem.ToString()) + ";";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;

                    }
                }
                else if (rdAplicacion.Checked == true)
                {
                    if (cmbCodigoAplicacion.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar una aplicacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion AND A.pk_id_aplicacion = " + Int32.Parse(cmbCodigoAplicacion.SelectedItem.ToString()) + ";";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;

                    }
                }
                else if (radioButton1.Checked == true)
                {
                    consulta = "SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion;";
                    string CONSULTA = consulta;
                    DataTable dt = cn.enviar(CONSULTA);
                    dgvBitacora.DataSource = dt;
                }
                else if (rdFecha.Checked == true)
                {
                    if (dtpFechaFinal.Value.Date < dtpFechaInicio.Value.Date)
                    {
                        MessageBox.Show("La fecha final no puede ser menor a la fecha inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dtpFechaInicio.Value.Date > dtpFechaFinal.Value.Date)

                    {
                        MessageBox.Show("La fecha inicial no puede ser mayor a la fecha Final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string fechaInicial = "", fechaFinal = "";
                        fechaInicial = dtpFechaInicio.Value.ToString("dd-MM-yyyy");
                        fechaFinal = dtpFechaFinal.Value.ToString("dd-MM-yyyy");

                        consulta = "SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.fechahora_bitacora BETWEEN '" + fechaInicial + "' and '" + fechaFinal + "' ;";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }

                }
                else if (radioButton2.Checked == true)
                {
                    if (rdInsercion.Checked == false && rdActualizacion.Checked == false && rdLogeo.Checked == false)
                    {
                        MessageBox.Show("Debe seleccionar una opcion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (rdInsercion.Checked == true)
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.accion_bitacora LIKE '%INSERT%' ; ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }
                    else if (rdActualizacion.Checked == true)
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.accion_bitacora LIKE '%UPDATE%' ; ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }
                    else if (rdLogeo.Checked == true)
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.accion_bitacora LIKE '%Logeo%'; ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }
                }
                else if (rdIp.Checked == true)
                {
                    if (txtIp.Text.Length == 0)
                    {
                        MessageBox.Show("Debe llenar el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        consulta = " SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.direccionhost_bitacora = '" + txtIp.Text + "'; ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }
                }
                else if (rdVarios.Checked == true)
                {
                    if (cmbCodigoUsuario.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar a un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (cmbCodigoAplicacion.SelectedIndex == 0)
                    {
                        MessageBox.Show("Debe seleccionar una aplicacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                   if (dtpFechaFinal.Value.Date < dtpFechaInicio.Value.Date)
                    {
                        MessageBox.Show("La fecha final no puede ser menor a la fecha inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dtpFechaInicio.Value.Date > dtpFechaFinal.Value.Date)

                    {
                        MessageBox.Show("La fecha inicial no puede ser mayor a la fecha Final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        string fechaInicial = "", fechaFinal = "";
                        fechaInicial = dtpFechaInicio.Value.ToString("dd-MM-yyyy");
                        fechaFinal = dtpFechaFinal.Value.ToString("dd-MM-yyyy");
                        consulta = "SELECT pk_id_bitacora as Codigo,L.usuario_login as Usuario,A.nombre_aplicacion as Aplicacion,fechahora_bitacora Fecha,direccionhost_bitacora as Direccion_Host,nombrehost_bitacora as Nombre_Host, accion_bitacora as Accion FROM bitacora B, aplicacion A, login L where B.fk_idusuario_bitacora = L.pk_id_login and B.fk_idaplicacion_bitacora = A.pk_id_aplicacion and B.fk_idusuario_bitacora = " + Int32.Parse(cmbCodigoUsuario.SelectedItem.ToString()) + " and B.fk_idaplicacion_bitacora = " + Int32.Parse(cmbCodigoAplicacion.SelectedItem.ToString()) + " and B.fechahora_bitacora BETWEEN '" + fechaInicial + "' and '" + fechaFinal + "' ";
                        string CONSULTA = consulta;
                        DataTable dt = cn.enviar(CONSULTA);
                        dgvBitacora.DataSource = dt;
                    }

                }

            }
        }

        private void Bitacoria_Load(object sender, EventArgs e)
        {
            //llenado de comboBox Departamento y su Codigo
            cmbCodigoUsuario.Items.Add("Seleccione...");
            cmbUsuario.Items.Add("Seleccione...");
            procLlenarComboBox("login", "pk_id_login", 1, "estado_login", cmbCodigoUsuario);
            procLlenarComboBox("login", "usuario_login", 1, "estado_login", cmbUsuario);
            cmbUsuario.SelectedIndex = 0;

            cmbCodigoAplicacion.Items.Add("Seleccione...");
            cmbAplicacion.Items.Add("Seleccione...");
            procLlenarComboBox("aplicacion", "pk_id_aplicacion", 1, "estado_aplicacion", cmbCodigoAplicacion);
            procLlenarComboBox("aplicacion", "nombre_aplicacion", 1, "estado_aplicacion", cmbAplicacion);
            cmbAplicacion.SelectedIndex = 0;
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoUsuario.SelectedIndex = cmbUsuario.SelectedIndex;
        }

        private void cmbCodigoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoAplicacion.SelectedIndex = cmbAplicacion.SelectedIndex;
        }

        private void rdUsuario_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 1;
            dgvBitacora.DataSource = null;
            if (rdUsuario.Checked == true)
            {
                cmbUsuario.Visible = true;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbAplicacion.SelectedIndex = 0;
                txtIp.Visible = false;
                txtIp.Text = "";
            }
        }

        private void rdAplicacion_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 2;
            dgvBitacora.DataSource = null;
            consulta = "";
            if (rdAplicacion.Checked == true)
            {
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = true;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbUsuario.SelectedIndex = 0;
                txtIp.Visible = false;
                txtIp.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 3;
            dgvBitacora.DataSource = null;
            consulta = "";
            if (radioButton1.Checked == true)
            {
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                cmbUsuario.SelectedIndex = 0;
                cmbAplicacion.SelectedIndex = 0;
                txtIp.Visible = false;
                txtIp.Text = "";
            }
        }

        private void rdFecha_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 4;
            dgvBitacora.DataSource = null;
            consulta = "";
            if (rdFecha.Checked == true)
            {
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = true;
                dtpFechaFinal.Visible = true;
                txtIp.Visible = false;
                txtIp.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 5;
            dgvBitacora.DataSource = null;
            consulta = "";
            if (radioButton2.Checked == true)
            {
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                rdInsercion.Visible = true;
                rdActualizacion.Visible = true;
                rdLogeo.Visible = true;
                txtIp.Visible = false;
                txtIp.Text = "";
            }
        }

        private void rdIp_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 6;
            dgvBitacora.DataSource = null;
            consulta = "";
            if (rdIp.Checked == true)
            {
                cmbUsuario.Visible = false;
                cmbAplicacion.Visible = false;
                dtpFechaInicio.Visible = false;
                dtpFechaFinal.Visible = false;
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                txtIp.Visible = true;
            }
        }

        private void rdVarios_CheckedChanged(object sender, EventArgs e)
        {
            opcion = 7;
            dgvBitacora.DataSource = null;
            consulta = "";
            if (rdVarios.Checked == true)
            {
                cmbUsuario.Visible = true;
                cmbAplicacion.Visible = true;
                dtpFechaInicio.Visible = true;
                dtpFechaFinal.Visible = true;
                rdInsercion.Visible = false;
                rdActualizacion.Visible = false;
                rdLogeo.Visible = false;
                txtIp.Visible = false;
                cmbAplicacion.SelectedIndex = 0;
                cmbUsuario.SelectedIndex = 0;
                txtIp.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            rdFecha.Checked = false;
            rdAplicacion.Checked = false;
            rdUsuario.Checked = false;
            cmbAplicacion.Visible = false;
            cmbUsuario.Visible = false;
            dtpFechaInicio.Visible = false;
            dtpFechaFinal.Visible = false;
            rdInsercion.Visible = false;
            rdLogeo.Visible = false;
            rdActualizacion.Visible = false;
            radioButton2.Checked = false;
            cmbUsuario.SelectedIndex = 0;
            cmbAplicacion.SelectedIndex = 0;
            rdIp.Checked = false;
            rdVarios.Checked = false;
            txtIp.Text = "";
            txtIp.Visible = false;
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value > dtpFechaFinal.Value)
            {
                MessageBox.Show("La fecha Mayor a la final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaInicio.Value = dtpFechaFinal.Value;
            }
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFinal.Value < DateTime.Today)
            {
                MessageBox.Show("La fecha final no puede ser menor a la de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaFinal.Value = DateTime.Today;
            }
            else
            if (dtpFechaFinal.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor a la inicial.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaFinal.Value = dtpFechaInicio.Value;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                if (opcion == 1)
                {
                    printer.Title = "BITACORA POR USUARIO";
                }
                else if (opcion == 2)
                {
                    printer.Title = "BITACORA POR APLICACION";
                }
                else if (opcion == 3)
                {
                    printer.Title = "BITACORA GENERAL";
                }
                else if (opcion == 4)
                {
                    printer.Title = "BITACORA POR FECHA";
                }
                else if (opcion == 5)
                {
                    printer.Title = "BITACORA POR ACCION";
                }
                else if (opcion == 6)
                {
                    printer.Title = "BITACORA POR IP";
                }
                else if (opcion == 7)
                {
                    printer.Title = "BITACORA POR USUARIO - APLICACION -FECHA";
                }
                printer.SubTitle = string.Format("Fecha: {0}", DateTime.Today.ToString("dd-MM-yyyy hh:mm tt"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "";
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(dgvBitacora);
                MessageBox.Show("El informe se ha IMPRESO / GUARDADO Exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ups!! ha ocurrido un error, consulte con soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
