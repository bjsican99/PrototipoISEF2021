using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad;
using CapaVistaHRM.Jose.Mantenimientos;
using CapaVistaHRM.Manuel.Mantenimientos;
using CapaVistaHRM.Sergio.Mantenimientos;
using CapaVistaHRM.Emilio.Mantenimientos;
using CapaVistaHRM.Jose.Procesos;
using CapaVistaHRM.Manuel.Procesos;
using CapaVistaHRM.Sergio.Procesos;
using CapaVistaHRM.Jose.Informes;

namespace CapaVistaHRM.MDI
{

    public partial class frmMDI : Form
    {
        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
        clsVistaBitacora bit = new clsVistaBitacora();

        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCambioContraseña);
            if (frmFormulario != null)
            {
                frmFormulario.BringToFront();
                return;
            }

            frmFormulario = new frmCambioContraseña(txtUsuario.Text);
            frmFormulario.MdiParent = this;
            frmFormulario.Show();

        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de usuarios", 2);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMantenimientoUsuario);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMantenimientoUsuario(txtUsuario.Text);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de usuarios", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDeAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de aplicaciones", 3);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAplicativo);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAplicativo();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de aplicaciones", 3);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDePerfilYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("6", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la asignacion de aplicaciones", 6);


                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAsignacionDeAplicaciones);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAsignacionDeAplicaciones();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();


            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a l asignacion de aplicaciones", 6);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDeModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("8", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de Modulo", 8);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModulo);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmModulo(txtUsuario.Text);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de Modulo", 8);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDePerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("4", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de mantenimiento de perfil", 4);


                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMantenimientoPerfil);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMantenimientoPerfil(txtUsuario.Text);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de mantenimiento de perfil", 4);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDeAplicacionesAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("5", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de mantenimiento de perfil apliaciones a perfil", 5);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAsignarAplicacionesAPerfil);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAsignarAplicacionesAPerfil();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();

            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacione de mantenimiento de perfil apliaciones a perfil", 5);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("10", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion de Asignacion de permisos", 10);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarPermisos);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmModificarPermisos();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de Asignacion de permisos", 10);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCurso);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmCurso(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void dificultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("313", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de  Dificultad ", 313);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDificultad);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmDificultad(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Dificultad", 313);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void puestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("305", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Puestos", 305);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPuesto);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmPuesto(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Puestos", 305);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tiposDeContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("310", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Contratos", 310);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmContratos);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmContratos(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Contratos", 310);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void informacionPersonalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (seguridad.PermisosAcceso("309", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Datos Personales", 309);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is DatosPersonales);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new DatosPersonales();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Datos Personales", 309);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tiposDePercepcionesYDeduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("317", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Percepciones fiscales", 317);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPercepcionesFiscales);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmPercepcionesFiscales(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Percepciones fiscales", 317);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tiposDeHorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("315", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Horarios", 315);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTipoHorario);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmTipoHorario(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Horarios ", 315);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tipoDeEntrevistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("312", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Entrevista", 312);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTipoEntrevista);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }
                frmFormulario = new frmTipoEntrevista(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Entrevista", 312);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tiposDeMonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("311", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de  Moneda ", 311);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTipoMoneda);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }
                frmFormulario = new frmTipoMoneda(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Moneda", 311);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void formacionAcademicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("314", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de  Formacion Academica ", 314);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmFormacionAcademica);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }
                frmFormulario = new frmFormacionAcademica(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de  Formacion Academica", 314);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void tiposDeLicenciaDeConducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("318", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Licencia de conducir", 318);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmLicenciaDeConducir);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmLicenciaDeConducir(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Licencia de conducir", 318);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("307", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Departamento de la empresa", 307);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDepartamento);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmDepartamento(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Departamento de la empresa", 307);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void faltasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("308", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Departamento de la empresa", 308);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is faltas);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new faltas(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Departamento de la empresa", 308);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void generarNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmPreparacionDeNomina);
            if (frmFormulario != null)
            {
                frmFormulario.BringToFront();
                return;
            }

            frmFormulario = new frmPreparacionDeNomina(this);
            frmFormulario.MdiParent = this;
            frmFormulario.Show();
        }

        private void tipoDeEvaluaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("309", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Datos Personales", 309);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmTipoEvaluacion);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmTipoEvaluacion(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Datos Personales", 309);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void ingresarReclutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("309", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al proceso de Ingreso Recluta", 309);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmIngresoReclutas);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmIngresoReclutas();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al proceso de Ingreso Recluta", 309);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void entrevistaReclutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("309", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al proceso de Entrevista", 309);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmEntrevista);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmEntrevista();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al proceso Entrevista", 309);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void evaluaciónReclutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("309", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al proceso de Evaluación", 309);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmEvaluacion);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmEvaluacion();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al proceso Evaluación", 309);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }


        private void competenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCurso);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmCompetencias(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void capacitadorExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCurso);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmCapacitadorExterno(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void peticiónDeCapacitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCurso);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmPeticionCapacitacion();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void nominaIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {     
                    Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmNominaIndividual);
                    if (frmFormulario != null)
                    {
                        frmFormulario.BringToFront();
                        return;
                    }

                    frmFormulario = new frmNominaIndividual();
                    frmFormulario.MdiParent = this;
                    frmFormulario.Show();
        }

        private void ascensosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCurso);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAscenso();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void capacitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCurso);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmCapacitacion();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void contratacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmContratacion);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmContratacion();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void induccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmInduccion);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmInduccion();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void nominaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmReportes);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmReportes();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void bitacoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Bitacoria);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new Bitacoria();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void agregarACapacitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("306", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Cursos", 306);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCurso);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAgregarAcapacitacion();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Tipo de Cursos", 306);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}


