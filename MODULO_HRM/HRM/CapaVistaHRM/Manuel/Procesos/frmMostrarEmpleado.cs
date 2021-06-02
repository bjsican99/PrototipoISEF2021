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
    public partial class frmMostrarEmpleado : Form
    {
        public frmMostrarEmpleado(int EstadoE)
        {
            InitializeComponent();
            funcMostrarTabla(EstadoE);
        }


        int Estado;
        ClsControladorManuel Cont_R = new ClsControladorManuel();
        //función para mostrar los datos de la BD en el datagrid
        public void funcMostrarTabla(int EstadoE)
        {


            DataTable dt = Cont_R.funcTablaEmpleado(EstadoE);
            dgvMostrarEmpleados.DataSource = dt;
            Estado = EstadoE;
            funcNombresEncabezados();
            

        }
        //función para cambiarle el nombre a las columnas del datagrid para el filtrado de datos
        public void funcNombresParametros()
        {
            dgvMostrarEmpleados.Columns[0].HeaderText = "Código ID";
            dgvMostrarEmpleados.Columns[1].HeaderText = "Nombres";
            dgvMostrarEmpleados.Columns[2].HeaderText = "Apellidos";
            dgvMostrarEmpleados.Columns[3].HeaderText = "Puesto";
            dgvMostrarEmpleados.Columns[4].HeaderText = "Departamento";
            dgvMostrarEmpleados.Columns[5].HeaderText = "Horario";
        }
        //función para cambiarle el nombre a las columnas del datagrid al momento de mostrar todos los datos
        public void funcNombresEncabezados()
        {
            funcNombresParametros();
            dgvMostrarEmpleados.Columns[6].HeaderText = "Email";
            dgvMostrarEmpleados.Columns[7].HeaderText = "Telefono";
            dgvMostrarEmpleados.Columns[8].HeaderText = "Num. IGSS";
            dgvMostrarEmpleados.Columns[9].HeaderText = "Tipo Licencia";
            dgvMostrarEmpleados.Columns[10].HeaderText = "Num.Cuenta Bancaria";

        }
        //función que bloquea todos los txt
        public void funcBloqueoTxt()
        {
            txtDepartamento.Enabled = false;
            txtIdEmpleado.Enabled = false;
            txtPrimerNombre.Enabled = false;
            txtPrimerApellido.Enabled = false;
            txtPuesto.Enabled = false;
            txtDepartamento.Enabled = false;

        }

        //función que limpia todos los texbox
        public void funcLimpieza()
        {
            txtDepartamento.Text = "";
            txtIdEmpleado.Text = "";
            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtPuesto.Text = "";
            txtDepartamento.Text = "";
        }

        //funcion que limpia todos los radiobuttons(les quita la seleccion)
        public void funcLimpiezaRbtn()
        {
            rbtnFiltradoId.Checked = false;
            rbtnFiltradoNombres.Checked = false;
            rbtnFiltradoApellidos.Checked = false;
            rbtnFiltradoPuesto.Checked = false;
            rbtnFiltradoDepto.Checked = false;

        }



        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoId.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtIdEmpleado.Enabled = true;
            }

        }
        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void FiltradoNombre1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoNombres.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtPrimerNombre.Enabled = true;
            }
        }
        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoApellido1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoApellidos.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtPrimerApellido.Enabled = true;
            }
        }
        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoPuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoPuesto.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtPuesto.Enabled = true;
            }
        }
        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoDepto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoDepto.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtDepartamento.Enabled = true;
            }
        }

        //Validacion para solo ingresar números en el txt Id

        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }
        //Validacion para solo ingresar letras
        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }

        //Evento KeyUp para realizar el filtrado de los datos por id 
        private void txtIdEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtIdEmpleado.Text;


            DataTable dt = Cont_R.funcFiltradoIdEmpleado(Parametro, Estado);
            dgvMostrarEmpleados.DataSource = dt;
            funcNombresParametros();
        }
        //Evento KeyUp para realizar el filtrado de los datos por primer nombre
        private void txtPrimerNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtPrimerNombre.Text;
            DataTable dt = Cont_R.funcFiltradoNombreEmpleado(Parametro, Estado);
            dgvMostrarEmpleados.DataSource = dt;
            funcNombresParametros();
        }
        //Evento KeyUp para realizar el filtrado de los datos por primer apellido
        private void txtPrimerApellido_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtPrimerApellido.Text;
            DataTable dt = Cont_R.funcFiltradoApellidoEmpleado(Parametro, Estado);
            dgvMostrarEmpleados.DataSource = dt;
            funcNombresParametros();
        }

        //Evento KeyUp para realizar el filtrado de los datos por puesto
        private void txtPuesto_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtPuesto.Text;
            DataTable dt = Cont_R.funcFiltradoPuestoEmpleado(Parametro, Estado);
            dgvMostrarEmpleados.DataSource = dt;
            funcNombresParametros();

        }
        //Evento KeyUp para realizar el filtrado de los datos por departamento
        private void txtDepartamento_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtDepartamento.Text;
            DataTable dt = Cont_R.funcFiltradoDepartamentoEmpleado(Parametro, Estado);
            dgvMostrarEmpleados.DataSource = dt;
            funcNombresParametros();
        }

        //Se muestran nuevamente todos los datos de la entidad Empleado
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            //Se llama a la funcion funcLimpiezaRbtn
            funcLimpiezaRbtn();
            //Se llama a la funcion funcLimpieza
            funcLimpieza();
            //Se llama a la funcion funcBloqueoTxt
            funcBloqueoTxt();
            //Se llama a la funcion funcMostrarTabla
            funcMostrarTabla(Estado);
        }
        //se coloca un máximo de dígitos para el textbox del id
        private void frmMostrarEmpleado_Load(object sender, EventArgs e)
        {
            txtIdEmpleado.MaxLength = 8;


        }
    }
}
