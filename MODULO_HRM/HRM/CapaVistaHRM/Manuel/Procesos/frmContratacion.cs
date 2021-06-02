using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControladorHRM.Manuel;
using System.Net;

namespace CapaVistaHRM.Manuel.Procesos
{
    public partial class frmContratacion : Form
    {

        ClsControladorManuel Cont_R = new ClsControladorManuel();


        public frmContratacion()
        {
            InitializeComponent();
            cmbTipoContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            funcCmbContrato();
        }

        //Declaración de variables Entidad Reclutamiento
        string  FechaCont, IdRecluta,LinkFoto;
        int  Genero, EstadoCivil, EstadoRec,EstadoEmp,CuentaBanc,TipoContrato,VarFoto=0;

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            VarFoto = 1;
    
            //en este boton funciona a manera de mostrar la imagen en un pictureBox, posteriormente esta el link es
            //guardado en una variable para ser enviado a la base de datos
            try
            {
                if (txtLink.Text != "")
                {
                    WebRequest request = WebRequest.Create(txtLink.Text);
                    using (var response = request.GetResponse())
                    {
                        using (var str = response.GetResponseStream())
                        {
                            pcbFoto.BackgroundImage = Bitmap.FromStream(str);
                            pcbFoto.BackgroundImageLayout = ImageLayout.Stretch;
                            pcbFoto.Visible = true;
                        }
                    }
                   
                }else{
                    MessageBox.Show("Debe ingresar un link para la imagen", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El link de la imagen no se logró encontrar, intente con otro link", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pcbFoto.Visible = false;
                txtLink.Text = "";

            }
        }

        private void btnBancoTalento_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarBancoTalento MostrarBancoT = new frmMostrarBancoTalento();
            MostrarBancoT.ShowDialog();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMantenimientosMan/AyudasProcesos.chm", "Ayuda_Contratacion.html");
        }

        //metodo para llenar el combo nivel de estudio
        public void funcCmbContrato()
        {
            DataTable Datos = Cont_R.funcCmbContrato();
            cmbTipoContrato.DataSource = Datos;
            cmbTipoContrato.DisplayMember = "TIPOCONTRATO";
            cmbTipoContrato.ResetText();

        }

        private void btnBuscar_Click(object sender, EventArgs e){
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else{

                //se desbloquean los componentes en los que se puede agregar/cambiar información
                btnContratar.Enabled = true;
                gbxDatos1.Enabled = true;
                gbxFoto.Enabled = true;
                IdRecluta = txtIdBancoTalento.Text;
           

                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarRecluta(txtIdBancoTalento.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        //Tabla reclutamiento
                        
                        txtNombres.Text = Lector.GetString(0);
                        txtApellido.Text = Lector.GetString(1);
                        txtDpi.Text = Lector.GetString(2);
                        dtpFechaNacimiento.Text = Lector.GetString(3);
                        Genero = int.Parse(Lector.GetString(4));
                        //Condición para obtener el texto a mostrar en el txt de Genero
                        if (Genero == 1){txtGenero.Text = "Masculino";
                        }else{
                            txtGenero.Text = "Femenino";
                        }

                        EstadoCivil = int.Parse(Lector.GetString(5));
                        //Condición para obtener el texto a mostrar en el txt del Estado Civil
                        if (EstadoCivil == 1){cmbEstadoCivil.Text = "Soltero";
                        }
                        else if (EstadoCivil == 2){cmbEstadoCivil.Text = "Casado";
                        }
                        else if (EstadoCivil == 3){cmbEstadoCivil.Text = "Divorciado";
                        }

                        txtCorreoElectronico.Text = Lector.GetString(6);
                        txtTelefono.Text = Lector.GetString(7);
                        txtNumeroIgss.Text = Lector.GetString(8);
                        cmbTipoLicencia.Text = Lector.GetString(9);
                        cmbPuesto.Text = Lector.GetString(10);
                        cmbHorario.Text = Lector.GetString(11);
                        cmbDepartamentoTrabajo.Text = Lector.GetString(12);
                        cmbNivelEstudios.Text = Lector.GetString(13);   
                        txtProfesion.Text = Lector.GetString(14);

                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El Id de ese Recluta no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();

                }

            }//fin ifelse

        }

       
        private void btnContratar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "" || txtCuentaBanc.Text == "" || txtLink.Text == "" || VarFoto == 0) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacios.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea Contratar a este Recluta ?", "Contratación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {

                    IdRecluta = txtIdBancoTalento.Text;
                    CuentaBanc = Convert.ToInt32(txtCuentaBanc.Text);
                    TipoContrato = cmbTipoContrato.SelectedIndex + 1;
                    LinkFoto = txtLink.Text;
                    FechaCont = dtpFechaContratacion.Value.Date.ToShortDateString();
                    EstadoEmp = 0;
                    EstadoRec = 6;

                    //envío de datos hacia capa Controlador

                    Cont_R.funcContratar(IdRecluta, CuentaBanc, TipoContrato, LinkFoto, FechaCont, EstadoEmp, EstadoRec);
                    MessageBox.Show("Se ha contratado con Éxito al Empleado", "FORMULARIO CONTRATACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();
                    funcBloqueo();



                }//fin elseif Pregunta

            }

        }


        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void funcfrmContratacion_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 11;
            txtTelefono.MaxLength = 8;
            txtCuentaBanc.MaxLength = 8;
            txtIdBancoTalento.MaxLength = 8;
        }
        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdBancoTalento.Text = "";
            txtNombres.Text = "";
            txtApellido.Text = "";
            txtDpi.Text = "";
            txtNumeroIgss.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtGenero.Text = "";
            cmbPuesto.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            cmbHorario.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtCuentaBanc.Text = "";
            cmbEstadoCivil.Text = "";
            cmbTipoLicencia.Text = "";
            cmbNivelEstudios.Text = "";
            txtProfesion.Text = "";
            cmbTipoContrato.Text = "";
            txtCuentaBanc.Text = "";
            txtLink.Text = "";
            dtpFechaContratacion.Value = DateTime.Now;
            pcbFoto.Visible = false;


        }
        //Funcion de Bloqueo
        private void funcBloqueo()
        {

            btnContratar.Enabled = false;
            gbxDatos1.Enabled = false;
            gbxFoto.Enabled = false;




        }



    }
}
