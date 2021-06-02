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
    public partial class frmInduccion : Form
    {

        ClsControladorManuel Cont_R = new ClsControladorManuel();

        public frmInduccion()
        {
            InitializeComponent();
            funcLlenarTipoInduccion();
            cmbTipoInduccion.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoSinInduccion = 0;

        }

        //Declaración de variables Entidad Reclutamiento
        string IdEmpleado,FechaInduc;
        int TipoInduccion, EstadoSinInduccion, EstadoEmp,EstadoInd;

   
        //funcion para llenar el combo
        public void funcLlenarTipoInduccion()
        {
            DataTable Datos = Cont_R.funcItemsInduccion();
            cmbTipoInduccion.DataSource = Datos;
            cmbTipoInduccion.DisplayMember = "TIPOINDUCCION";
            cmbTipoInduccion.ResetText();
        }

        //funcion para llenar el combo
        public void funcCmbEmpleado()
        {
            DataTable Datos = Cont_R.funcCmbEmpleado();
            cmbEncargado.DataSource = Datos;  
            cmbEncargado.DisplayMember = "DATOS";
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach(DataRow row in Datos.Rows){
                coleccion.Add(Convert.ToString(row["DATOS"]));

            }
            cmbEncargado.AutoCompleteCustomSource = coleccion;
            cmbEncargado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEncargado.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdEmpleado.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                IdEmpleado = txtIdEmpleado.Text;
                gbxDatosInduccion.Enabled = true;
                
                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarEmpleado(txtIdEmpleado.Text, EstadoSinInduccion, EstadoSinInduccion);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        //Tabla reclutamiento
                        txtPrimerNombre.Text = Lector.GetString(0);
                        txtPrimerApellido.Text = Lector.GetString(1);
                        txtCorreoElectronico.Text = Lector.GetString(6);
                        txtTelefono.Text = Lector.GetString(7);
                        cmbPuestoTrabajo.Text = Lector.GetString(10);
                        cmbHorario.Text = Lector.GetString(11);
                        cmbDepartamentoTrabajo.Text = Lector.GetString(12);
                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El Id de ese Empleado no se encuentra Registrado o Ya se le realizó una inducción.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();


                }

            }//fin ifelse
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

   

        private void frmEntrevista_Load(object sender, EventArgs e)
        {
            funcCmbEmpleado();
            txtIdEmpleado.MaxLength = 8;
           
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMantenimientosMan/AyudasProcesos.chm", "Ayuda_Induccion.html");
        }

        private void btnReclutas_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarEmpleado MostrarReclu = new frmMostrarEmpleado(EstadoSinInduccion);
            MostrarReclu.ShowDialog();
        }



        private void btnIngresoEntrevista_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdEmpleado.Text == "" ) { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
          
                        //Mensaje de Pregunta
                            if (MessageBox.Show("¿Desea agregar un registro de Inducción ?", "Inducción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                            else
                            {

                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Reclutamiento

                                IdEmpleado = txtIdEmpleado.Text;
                                TipoInduccion = cmbTipoInduccion.SelectedIndex + 1;
                                FechaInduc = dtpFechaInduccion.Value.Date.ToShortDateString();
                                EstadoInd = 1;
                                EstadoEmp = 1;
                    //envío de datos hacia capa Controlador
                    Cont_R.funcInsertarInduccion(IdEmpleado, TipoInduccion, FechaInduc, EstadoInd, EstadoEmp);
                                MessageBox.Show("Se ha ingresado la Inducción con Éxito", "FORMULARIO INDUCCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                funcLimpieza();
                                funcBloqueo();

                            }//fin elseif Pregunta
  
            }

        }


        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdEmpleado.Text = "";
            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            cmbPuestoTrabajo.Text = "";
            cmbTipoInduccion.Text = "";
            dtpFechaInduccion.Value = DateTime.Now;
            cmbHorario.Text = "";
            txtTelefono.Text = "";
            txtCorreoElectronico.Text = "";
            cmbEncargado.Text = "";

        }
        //Función de Bloqueo
        private void funcBloqueo()
        {
            gbxDatosInduccion.Enabled = false;
           
        }





    }

}
