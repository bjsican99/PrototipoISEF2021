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
using CapaVistaHRM.Manuel.Procesos;

namespace CapaVistaHRM.Manuel.Mantenimientos
{
    public partial class DatosPersonales : Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
            funcLlenarPuesto();
            funcLlnearDepto();
            funcItemsLicencia();
            funcItemsHorario();

            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorario.DropDownStyle = ComboBoxStyle.DropDownList;


            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            ParamBusqueda = 0;

        }

        ClsControladorManuel Cont_R = new ClsControladorManuel();

        //Declaración de variables Entidad Reclutamiento
        string PrimerNom, PrimerAp, Email, IdEmp,IdRec, EstadoCivil,EstadoCivil2,Foto, CuentaBanc;
        int Genero, Telefono, TipoLicencia, Puesto, Departamento,Horario,Dpi,NumIgss, ParamBusqueda;

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMantenimientosMan/AyudaMantenimientoMan.chm", "DatosPersonales.html");
        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        int Estado = 1;
        int Estado2 = 0;

        string TipoEntidad;
        private void Rbtn_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Empleado.Checked == true)
            {
                funcLimpieza();
                lblIngreseIdEmpleado.Visible = true;
                lblIngreseIdEmpleado.Text = "Ingrese el ID del Empleado ";
                txtId.Enabled = true;
                btnEmpleados.Text = "Ver Lista Empleados";
                btnEmpleados.Visible = true;
                btnBuscar.Enabled = true;
                TipoEntidad = "Empleado";
                lblFoto.Visible = true;
                lblCuentaBanc.Visible = true;
                txtCuentaBanc.Visible = true;
            }
        }



        //metodo para llenar el combo puesto
        public void funcLlenarPuesto()
        {
            DataTable Datos = Cont_R.funcItemsPuesto();
            cmbPuesto.DataSource = Datos;
            cmbPuesto.DisplayMember = "NOMBREPUESTO";
            cmbPuesto.ResetText();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
  
            if (Rbtn_Empleado.Checked == true)
            {
                //Se llama al formulario que contiene todos una tabla de todos los empleados
                frmMostrarEmpleado MostrarEmp = new frmMostrarEmpleado(ParamBusqueda);
                MostrarEmp.ShowDialog();
            }

            if (Rbtn_Recluta.Checked == true)
            {
                //Se llama al formulario que contiene todos una tabla de todos los empleados
                frmMostrarReclutas MostrarReclu = new frmMostrarReclutas(ParamBusqueda);
                MostrarReclu.ShowDialog();
            }
    
        }

        //metodo para llenar el combo departamento
        public void funcLlnearDepto()
        {
            DataTable Datos = Cont_R.funcItemsDepto();
            cmbDepartamento.DataSource = Datos;
            cmbDepartamento.DisplayMember = "NOMBREDEPARTAMENTO";
            cmbDepartamento.ResetText();
        }

        //metodo para llenar el combo licencia
        public void funcItemsLicencia()
        {
            DataTable Datos = Cont_R.funcItemsLicencia();
            cmbTipoLicencia.DataSource = Datos;
            cmbTipoLicencia.DisplayMember = "TIPOLICENCIA";
            cmbTipoLicencia.ResetText();
        }

        public void funcItemsHorario()
        {
            DataTable Datos = Cont_R.funcItemsHorario();
            cmbHorario.DataSource = Datos;
            cmbHorario.DisplayMember = "TIPOHORARIO";
            cmbHorario.ResetText();
        }

     




        private void Rbtn_Recluta_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Recluta.Checked == true){
                funcLimpieza();
                lblIngreseIdEmpleado.Visible = true;
                lblIngreseIdEmpleado.Text = "Ingrese el ID del Recluta ";
                txtId.Enabled = true;
                btnEmpleados.Text = "Ver Lista Reclutas";
                btnEmpleados.Visible = true;
                btnBuscar.Enabled = true;
                TipoEntidad = "Recluta";
                lblFoto.Visible = false;
                lblCuentaBanc.Visible = false;
                txtCuentaBanc.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtId.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                if (TipoEntidad== "Recluta"){

                    //RECLUTAS
                    funcDesbloqueo();
                    lblFoto.Visible = false;
                    IdRec = txtId.Text;
                    //Inicio para Busqueda
                    OdbcDataReader Lector = Cont_R.funcBuscarRecluta(txtId.Text);
                    if (Lector.HasRows == true)
                    {
                        while (Lector.Read())
                        {
                            //Se agrega el valor del lector a los textbox dependiendo la posicion 
                            //Tabla reclutamiento

                            txtPrimerNombre.Text = Lector.GetString(0);
                            txtPrimerApellido.Text = Lector.GetString(1);
                            txtDpi.Text = Lector.GetString(2);
                            dtpFechaNacimiento.Text = Lector.GetString(3);
                            

                            Genero = int.Parse(Lector.GetString(4));
                            //Condición para obtener el texto a mostrar en el txt de Genero
                            if (Genero == 1)
                            {
                                txtGenero.Text = "Masculino";

                            }
                            else
                            {
                                txtGenero.Text = "Femenino";
                            }

                            EstadoCivil = Lector.GetString(5);

                            if (EstadoCivil == "1")
                            {

                                cmbEstadoCivil.Text = "Soltero";

                            }else if (EstadoCivil == "2"){

                                    cmbEstadoCivil.Text = "Casado";

                            }else if (EstadoCivil == "3")
                            {
                                    cmbEstadoCivil.Text = "Divorciado";
                            }


                            txtCorreoElectronico.Text = Lector.GetString(6);
                            txtTelefono.Text = Lector.GetString(7);
                            txtNumeroIgss.Text = Lector.GetString(8);
                            cmbTipoLicencia.Text = Lector.GetString(9);
                            cmbPuesto.Text = Lector.GetString(10);
                            cmbHorario.Text = Lector.GetString(11);
                            cmbDepartamento.Text = Lector.GetString(12);
                            

                        }//fin while


                    }else{


                    }


                    //Segunda Busqueda para obtener el Id de los combos
                    OdbcDataReader Lector2 = Cont_R.funcBusquedaCombosRec(txtId.Text);
                    if (Lector2.HasRows == true)
                    {
                        while (Lector2.Read())
                        {

                            TipoLicencia = int.Parse(Lector2.GetString(0));
                            Puesto = int.Parse(Lector2.GetString(1));
                            Horario = int.Parse(Lector2.GetString(2));
                            Departamento = int.Parse(Lector2.GetString(3));

                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: El Id de este Empleado no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        funcBloqueo();
                        funcLimpieza();
                    }

                    //----------------------------------------------------------------------------------
                    //----------------------------------------------------------------------------------
                }
                else
                {

                    //EMPLEADOS
                    funcDesbloqueo();
                    lblFoto.Visible = true;
                    IdEmp = txtId.Text;
                    //Inicio para Busqueda
                    OdbcDataReader Lector = Cont_R.funcBuscarEmpleado(txtId.Text, Estado, Estado2);
                    if (Lector.HasRows == true)
                    {
                        while (Lector.Read())
                        {
                            //Se agrega el valor del lector a los textbox dependiendo la posicion 
                            //Tabla reclutamiento

                            txtPrimerNombre.Text = Lector.GetString(0);
                            txtPrimerApellido.Text = Lector.GetString(1);
                            txtDpi.Text = Lector.GetString(2);
                            dtpFechaNacimiento.Text = Lector.GetString(3);
                            

                            Genero = int.Parse(Lector.GetString(4));
                            //Condición para obtener el texto a mostrar en el txt de Genero
                            if (Genero == 1)
                            {
                                txtGenero.Text = "Masculino";

                            }
                            else
                            {
                                txtGenero.Text = "Femenino";
                            }

                            EstadoCivil = Lector.GetString(5);

                            if (EstadoCivil == "1")
                            {

                                cmbEstadoCivil.Text = "Soltero";

                            }
                            else if (EstadoCivil == "2")
                            {

                                cmbEstadoCivil.Text = "Casado";

                            }
                            else if (EstadoCivil == "3")
                            {
                                cmbEstadoCivil.Text = "Divorciado";
                            }


                            txtCorreoElectronico.Text = Lector.GetString(6);
                            txtTelefono.Text = Lector.GetString(7);
                            txtNumeroIgss.Text = Lector.GetString(8);
                            cmbTipoLicencia.Text = Lector.GetString(9);


                            cmbPuesto.Text = Lector.GetString(10);
                            cmbHorario.Text = Lector.GetString(11);
                            cmbDepartamento.Text = Lector.GetString(12);
                            txtCuentaBanc.Text = Lector.GetString(13);
                            IdRec = Lector.GetString(14);
                            
                            try
                            {
                                Foto = Lector.GetString(15);
                                WebRequest request = WebRequest.Create(Foto);
                                using (var response = request.GetResponse())
                                {
                                    using (var str = response.GetResponseStream())
                                    {

                                        pbxFoto.BackgroundImage = Bitmap.FromStream(str);
                                        pbxFoto.BackgroundImageLayout = ImageLayout.Stretch;
                                    }
                                }


                            }catch (Exception ex){
                                MessageBox.Show("La imagen no se ha logrado cargar correctamente");
                                pbxFoto.Visible = false;
                            }//fin try catch


                        }


                    }else{



                    }



                    //Segunda Busqueda para obtener el Id de los combos
                    OdbcDataReader Lector2 = Cont_R.funcBusquedaCombosEmp(txtId.Text);
                    if (Lector2.HasRows == true)
                    {
                        while (Lector2.Read())
                        {

                            TipoLicencia = int.Parse(Lector2.GetString(0));
                            Puesto = int.Parse(Lector2.GetString(1));
                            Horario = int.Parse(Lector2.GetString(2));
                            Departamento = int.Parse(Lector2.GetString(3));

                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR: El Id de este Empleado no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        funcBloqueo();
                        funcLimpieza();
                    }


                }//fin else if que divide reclutas y empleados
               


            }//fin ifelse
        }


        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtId.Text = "";
            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtDpi.Text = "";
            txtNumeroIgss.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtGenero.Text = "";
            cmbPuesto.Text = "";
            cmbDepartamento.Text = "";
            cmbHorario.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefono.Text = "";
            txtCuentaBanc.Text = "";
            cmbEstadoCivil.Text = "";
            cmbTipoLicencia.Text = "";
            lblFoto.Visible = false;
            btnEmpleados.Visible = false;
            pbxFoto.Visible = false;

        }

        //Funcion de Bloqueo
        private void funcDesbloqueo()
        {

            btnModificar.Enabled = true;
            pnlDatosGenerales.Enabled = true;
            pnlPuesto.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            cmbTipoLicencia.Enabled = true;
            txtCuentaBanc.Enabled = true;
            txtDpi.Enabled = true;
            txtNumeroIgss.Enabled = true;
            pbxFoto.Visible = true;
        }

        //Funcion de Desbloqueo
        private void funcBloqueo()
        {
            btnModificar.Enabled = false;
            pnlDatosGenerales.Enabled = false;
            pnlPuesto.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            cmbTipoLicencia.Enabled = false;
            txtCuentaBanc.Enabled = false;
            txtDpi.Enabled = false;
            txtNumeroIgss.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 13;
            txtTelefono.MaxLength = 8;
            txtNumeroIgss.MaxLength = 8;
            txtCuentaBanc.MaxLength = 8;
            txtId.MaxLength = 8;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (TipoEntidad == "Recluta")
            {
                //Reclutas



                //Mensaje de Validación
                //Revisar la variable de cuenta bancaria
                if (txtId.Text == "" || txtPrimerNombre.Text == "" || txtPrimerApellido.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtDpi.Text == "" || txtNumeroIgss.Text == "" ) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {

                    //Mensaje de Pregunta
                    if (MessageBox.Show("¿Desea modificar este Recluta?", "Recluta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {


                        //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                        //datos Reclutamiento
                        PrimerNom = txtPrimerNombre.Text;
                        PrimerAp = txtPrimerApellido.Text;
                        Telefono = Convert.ToInt32(txtTelefono.Text);
                        Email = txtCorreoElectronico.Text;
                        Dpi = Convert.ToInt32(txtDpi.Text);
                        NumIgss = Convert.ToInt32(txtNumeroIgss.Text);
                        Puesto = cmbPuesto.SelectedIndex + 1;
                        Departamento = cmbDepartamento.SelectedIndex + 1;
                        Horario = cmbHorario.SelectedIndex + 1;
                        EstadoCivil = cmbEstadoCivil.SelectedItem.ToString();

                        if (EstadoCivil == "Soltero")
                        {

                            EstadoCivil2 = "1";

                        }
                        else if (EstadoCivil == "Casado")
                        {

                            EstadoCivil2 = "2";

                        }
                        else if (EstadoCivil == "Divorciado")
                        {
                            EstadoCivil2 = "3";
                        }

                        TipoLicencia = cmbTipoLicencia.SelectedIndex + 1;

                        CuentaBanc = txtCuentaBanc.Text;

                        IdRec = txtId.Text;

                        //envío de datos hacia capa Controlador

                        Cont_R.funcModificarRecluta(PrimerNom, PrimerAp, Telefono, Email, Dpi, NumIgss,
                            Puesto, Departamento, Horario, EstadoCivil2, TipoLicencia, CuentaBanc, IdRec);
                        MessageBox.Show("Se han modificado los datos del Recluta con Éxito", "FORMULARIO MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        funcLimpieza();
                        funcBloqueo();






                    }//fin elseif Pregunta
                }//fin elseif txt




            }
            else{
                //Empleados


                //Mensaje de Validación
                //Revisar la variable de cuenta bancaria
                if (txtId.Text == "" || txtPrimerNombre.Text == "" || txtPrimerApellido.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtDpi.Text == "" || txtNumeroIgss.Text == "" || txtCuentaBanc.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {

                    //Mensaje de Pregunta
                    if (MessageBox.Show("¿Desea modificar este Empleado?", "Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {


                        //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                        //datos Reclutamiento
                        PrimerNom = txtPrimerNombre.Text;
                        PrimerAp = txtPrimerApellido.Text;
                        Telefono = Convert.ToInt32(txtTelefono.Text);
                        Email = txtCorreoElectronico.Text;
                        Dpi = Convert.ToInt32(txtDpi.Text);
                        NumIgss= Convert.ToInt32(txtNumeroIgss.Text);
                        Puesto = cmbPuesto.SelectedIndex + 1;
                        Departamento = cmbDepartamento.SelectedIndex + 1;
                        Horario = cmbHorario.SelectedIndex + 1;
                        EstadoCivil = cmbEstadoCivil.SelectedItem.ToString();

                        if (EstadoCivil == "Soltero")
                        {

                            EstadoCivil2 = "1";

                        }
                        else if (EstadoCivil == "Casado")
                        {

                            EstadoCivil2 = "2";

                        }
                        else if (EstadoCivil == "Divorciado")
                        {
                            EstadoCivil2 = "3";
                        }

                        TipoLicencia = cmbTipoLicencia.SelectedIndex + 1;
                        
                        CuentaBanc = txtCuentaBanc.Text;

                        IdEmp = txtId.Text;
                        //EstadoRecluta = 0;



                        //envío de datos hacia capa Controlador

                        Cont_R.funcModificarEmpleado(PrimerNom, PrimerAp, Telefono, Email,Dpi,NumIgss,
                            Puesto, Departamento, Horario, EstadoCivil2, TipoLicencia, CuentaBanc, IdEmp, IdRec);
                        MessageBox.Show("Se han modificado los datos del Empleado con Éxito", "FORMULARIO MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        funcLimpieza();
                        funcBloqueo();




                    }//fin elseif Pregunta
                }//fin elseif txt


            }//fin else if que divide reclutas y empleados





        }
    }
}
