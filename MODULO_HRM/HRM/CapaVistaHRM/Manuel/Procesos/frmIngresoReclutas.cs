using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorHRM.Manuel;
using System.Net;



namespace CapaVistaHRM.Manuel.Procesos
{
    public partial class frmIngresoReclutas : Form
    {

       // clsControladorDesarrollo Cont = new clsControladorDesarrollo();
        ClsControladorManuel Cont_R = new ClsControladorManuel();

        public frmIngresoReclutas()
        {
            InitializeComponent();
            funcLlenarPuesto();
            funcLlnearDepto();
            funcItemsHorario();

            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCivil.SelectedIndex = +1;
            cmbNivelEstudios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoLicencia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamentoTrabajo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHorario.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoNoEntrevistados = 0;

            funcItemsLicencia();
            funcItemsNivelEstudio();
        }

        //funcion para llenar el combo
        public void funcCmbEmpleado()
        {
            DataTable Datos = Cont_R.funcCmbEmpleado();
            cmbEncargado.DataSource = Datos;
            cmbEncargado.DisplayMember = "DATOS";
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in Datos.Rows)
            {
                coleccion.Add(Convert.ToString(row["DATOS"]));

            }
            cmbEncargado.AutoCompleteCustomSource = coleccion;
            cmbEncargado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEncargado.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }


        //Declaración de variables Entidad Reclutamiento
        string PrimerNom, PrimerAp, FechaNac, Email, NombreProf, EstadoCivil,Dpi, FechaReclu,EstadoCivil2;
        int NivelEstudio, Genero, Telefono, NumIgss, TipoLicencia, Puesto, Departamento, EstadoRecluta,Horario, EstadoNoEntrevistados;

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMantenimientosMan/AyudasProcesos.chm", "Ayuda_Ingreso_Reclutas.html");
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNo.Checked == true)
            {
                //estado 0 para los que deben pasar el proceso de entrevista y evaluación
                EstadoRecluta = 0;
                cmbEncargado.Enabled = false;
                cmbEncargado.Text = "";
            }
        }

        private void rbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSi.Checked == true)
            {
                //estado 5 para recomendados, no deben pasar el proceso de entrevista y evaluación
                EstadoRecluta = 5;
                cmbEncargado.Enabled = true;
            }
        }


       
      
        private void rbtnFemenino_CheckedChanged(object sender, EventArgs e){

            if (rbtnFemenino.Checked == true)
            {
                Genero = 2;
            }

        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMasculino.Checked == true)
            {
                Genero = 1;
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
        //metodo para llenar el combo departamento
        public void funcLlnearDepto()
        {
            DataTable Datos = Cont_R.funcItemsDepto();
            cmbDepartamentoTrabajo.DataSource = Datos;
            cmbDepartamentoTrabajo.DisplayMember = "NOMBREDEPARTAMENTO";
            cmbDepartamentoTrabajo.ResetText();
        }


        public void funcItemsHorario()
        {
            DataTable Datos = Cont_R.funcItemsHorario();
            cmbHorario.DataSource = Datos;
            cmbHorario.DisplayMember = "TIPOHORARIO";
            cmbHorario.ResetText();
        }


        //metodo para llenar el combo licencia
        public void funcItemsLicencia()
        {
            DataTable Datos = Cont_R.funcItemsLicencia();
            cmbTipoLicencia.DataSource = Datos;
            cmbTipoLicencia.DisplayMember = "TIPOLICENCIA";
            cmbTipoLicencia.ResetText();
        }
        
        //metodo para llenar el combo nivel de estudio
        public void funcItemsNivelEstudio()
        {
            DataTable Datos = Cont_R.funcItemsNivelEstudio();
            cmbNivelEstudios.DataSource = Datos;
            cmbNivelEstudios.DisplayMember = "NOMBREFORMACIONACADEMICA";
            cmbNivelEstudios.ResetText();

        }


        private void btnIngreso_Click(object sender, EventArgs e)
        {
            
            //primera verificación de datos de radiobuttons vacios
            if (rbtnMasculino.Checked==false && rbtnFemenino.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha seleccionado un sexo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else{
                //primera verificación de datos de radiobuttons vacios
                if (rbtnSi.Checked == false && rbtnNo.Checked == false) { MessageBox.Show("ADVERTENCIA: No ha indicado si el Recluta tiene Recomendación interna", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    //segunda verificación de datos de cajas de texto vacias
                    if (txtPrimerNombre.Text == "" || txtPrimerApellido.Text == "" || txtDpi.Text == "" || txtNumeroIgss.Text == "" || txtCorreoElectronico.Text == "" || txtTelefono.Text == "" || txtProfesion.Text == "") { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    else
                    {
                        //Se declara variable de DateTime para realizar validación de fecha nacimiento
                        DateTime FecharNac = dtpFechaNacimiento.Value.Date;
                        var DiasNac = (DateTime.Now - FecharNac).TotalDays;

                        //Mensaje de Pregunta
                        if (MessageBox.Show("¿Desea agregar un nuevo Recluta al Banco de Talento ?", "Recluta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                        else
                        {
                            //tercera verificación de datos, fecha de nacimiento mayor a 100 años
                            if (DiasNac > 36500)
                            {
                                MessageBox.Show("ADVERTENCIA: Edad errónea, no puede ingresar una edad mayor a 100 años.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                            }//fin if validación fecha nac


                            //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                            //datos Reclutamiento
                            PrimerNom = txtPrimerNombre.Text;
                            PrimerAp = txtPrimerApellido.Text;
                            Dpi = txtDpi.Text;
                            NombreProf = txtProfesion.Text;
                            FechaNac = dtpFechaNacimiento.Value.Date.ToShortDateString();
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


                            Email = txtCorreoElectronico.Text;
                            Telefono = Convert.ToInt32(txtTelefono.Text);
                            NumIgss = Convert.ToInt32(txtNumeroIgss.Text);
                            FechaReclu = dtpFechaRecluta.Value.Date.ToShortDateString();
                            TipoLicencia = cmbTipoLicencia.SelectedIndex + 1;
                            Puesto = cmbPuesto.SelectedIndex + 1;
                            Horario = cmbHorario.SelectedIndex + 1;
                            Departamento = cmbDepartamentoTrabajo.SelectedIndex + 1;
                            NivelEstudio = cmbNivelEstudios.SelectedIndex + 1;


                            //envío de datos hacia capa Controlador

                            Cont_R.funcInsertarRecluta(PrimerNom, PrimerAp, Dpi, NombreProf, FechaNac, Genero,
                                       EstadoCivil2, Email, Telefono, NumIgss, FechaReclu, TipoLicencia, Puesto, Horario, Departamento, NivelEstudio, EstadoRecluta);
                            MessageBox.Show("Se ha ingresado al Banco de Talento con Éxito", "FORMULARIO RECLUTAMIENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            funcLimpieza();



                        }//fin elseif Pregunta

                    }//fin elseif txt
                }//fin elseif rbtn si no

            }//fin elseif rbtn 
          
        }


        private void funcfrmIngreso_Load(object sender, EventArgs e)
        {
            txtDpi.MaxLength = 13;
            txtTelefono.MaxLength = 8;
            txtNumeroIgss.MaxLength = 8;
            funcCmbEmpleado();

        }

        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        //Función de Limpieza
        private void funcLimpieza()
        {


            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtCorreoElectronico.Text = "";
            txtProfesion.Text = "";
            dtpFechaNacimiento.Value= DateTime.Now;
            txtTelefono.Text = "";
            txtNumeroIgss.Text = "";
            txtDpi.Text = "";
            cmbNivelEstudios.Text = "";
            cmbEstadoCivil.Text = "";
            cmbTipoLicencia.Text = "";
            cmbPuesto.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            rbtnSi.Checked = false;
            rbtnNo.Checked = false;
            cmbEncargado.Enabled = false;

        }
     


    }
}
