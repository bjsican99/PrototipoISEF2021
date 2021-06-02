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
    public partial class frmEvaluacion : Form
    {

        ClsControladorManuel Cont_R = new ClsControladorManuel();

        public frmEvaluacion()
        {
            InitializeComponent();
            funcLlenarTipoEvaluacion();
            cmbTipoEntrevista.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoNoEntrevistados = 1;
        }

        //Declaración de variables Entidad Reclutamiento
        string IdRecluta,Comentarios,OpcionRecluta;
        int Resultado,TipoEntrevista,Punteo, EstadoNoEntrevistados, PunteoE;

        

        //funcion para llenar el combo
        public void funcLlenarTipoEvaluacion()
        {
            DataTable Datos = Cont_R.funcItemsEvaluacion();
            cmbTipoEntrevista.DataSource = Datos;
            cmbTipoEntrevista.DisplayMember = "TIPOEVALUACION";
            cmbTipoEntrevista.ResetText();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                IdRecluta = txtIdBancoTalento.Text;
                gbxDatosEvaluacion.Enabled = true;
                //Inicio para Busqueda
                OdbcDataReader Lector = Cont_R.funcBuscarReclutaEvaluado(txtIdBancoTalento.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        //Tabla reclutamiento

                        txtPrimerNombre.Text = Lector.GetString(0);
                        txtPrimerApellido.Text = Lector.GetString(1);
                        cmbPuestoTrabajo.Text = Lector.GetString(2);
                        cmbHorario.Text = Lector.GetString(3);
                        cmbDepartamentoTrabajo.Text = Lector.GetString(4);
                        txtPunteoEntrevista.Text = Lector.GetString(5);
                        txtResultadoEntrevista.Text = Lector.GetString(6);
                        rtbxComentariosEntrevista.Text = Lector.GetString(7);

      
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

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaMantenimientosMan/AyudasProcesos.chm", "Ayuda_Evaluacion.html");

        }

        private void frmEntrevista_Load(object sender, EventArgs e)
        {
            
            txtIdBancoTalento.MaxLength = 8;
            txtPunteo.MaxLength = 3;
        }

        private void btnReclutas_Click(object sender, EventArgs e)
        {
            //Se llama al formulario que contiene todos una tabla de todos los empleados
            frmMostrarReclutas MostrarReclu = new frmMostrarReclutas(EstadoNoEntrevistados);
            MostrarReclu.ShowDialog();
        }

    

        private void txtPunteo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PunteoE = Convert.ToInt32(txtPunteo.Text);
                if (PunteoE >= 0 && PunteoE < 50)
                {
                    txtResultado.Text = "";
                    OpcionRecluta = "Reprobado";
                    txtResultado.Text = "Reprobado";
                    Resultado = 4;
                }
                else if (PunteoE > 50 && PunteoE < 80)
                {
                    txtResultado.Text = "";
                    OpcionRecluta = "Segunda Opción";
                    txtResultado.Text = "Segunda Opción";
                    Resultado = 3;
                }
                else if (PunteoE >= 80 && PunteoE <= 100)
                {
                    txtResultado.Text = "";
                    OpcionRecluta = "Primera Opción";
                    txtResultado.Text = "Primera Opción";
                    Resultado = 2;

                }
                else if (PunteoE < 0 || PunteoE > 100)
                {
                    txtResultado.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ha ingresado un valor válido en el Punteo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultado.Text = "";
            }
        }



        private void btnIngresoEntrevista_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdBancoTalento.Text == "" ||  txtPunteo.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //Mensaje de validación del Punteo
                if (PunteoE < 0 || PunteoE > 100 || txtPunteo.Text == "") { MessageBox.Show("ADVERTENCIA: Ha ingresado un punteo que se sale del Rango de 0 a 100", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {
                    //segunda verificación de datos de cajas de texto vacias
                    if (rtxtComentarios.Text == "") { MessageBox.Show("ADVERTENCIA: No ha ingresado sus Comentarios sobre el Recluta Evaluado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    else
                    {
                        //Mensaje de Pregunta
                            if (MessageBox.Show("¿Desea agregar un nuevo Resultado de Evaluacion ?", "Evaluacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                            else
                            {

                                //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                                //datos Reclutamiento
                                
                                Punteo = Convert.ToInt32(txtPunteo.Text);
                                TipoEntrevista = cmbTipoEntrevista.SelectedIndex + 1;
                                Comentarios = rtxtComentarios.Text;
                              
                                //envío de datos hacia capa Controlador
                                Cont_R.funcInsertarEvaluacion(IdRecluta, TipoEntrevista,Punteo, Resultado, Comentarios, OpcionRecluta);
                                MessageBox.Show("Se ha ingresado la Evaluacion con Éxito", "FORMULARIO EVALUACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                funcLimpieza();
                                funcBloqueo();

                            }//fin elseif Pregunta

                    }//fin elseif txt

                }//fin elseif rbtn
            }

        }


        //Funcion de Limpieza
        private void funcLimpieza()
        {
            txtIdBancoTalento.Text = "";
            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            cmbDepartamentoTrabajo.Text = "";
            cmbPuestoTrabajo.Text = "";
            cmbHorario.Text = "";
            cmbTipoEntrevista.Text = "";
            rtxtComentarios.Text = "";
            txtPunteo.Text = "0";
            txtResultado.Text = "";
            txtPunteoEntrevista.Text = "";
            txtResultadoEntrevista.Text = "";
            rtbxComentariosEntrevista.Text = "";


        }
        //Función de Bloqueo
        private void funcBloqueo()
        {
            gbxDatosEvaluacion.Enabled = false;
            
        }


    }

}
