namespace CapaVistaHRM.Manuel.Procesos
{
    partial class frmIngresoReclutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoReclutas));
            this.btnIngreso = new System.Windows.Forms.Button();
            this.tbpDatosPersonales = new System.Windows.Forms.TabPage();
            this.DatosP3 = new System.Windows.Forms.GroupBox();
            this.lblTipoLicencia = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.cmbTipoLicencia = new System.Windows.Forms.ComboBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.gbxFormacionAcademica = new System.Windows.Forms.GroupBox();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.cmbNivelEstudios = new System.Windows.Forms.ComboBox();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblNivelEstudios = new System.Windows.Forms.Label();
            this.tbpDatosGenerales = new System.Windows.Forms.TabPage();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbxDatosP1 = new System.Windows.Forms.GroupBox();
            this.lblFechaRecluta = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFechaRecluta = new System.Windows.Forms.DateTimePicker();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblNumeroIgss = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNumeroIgss = new System.Windows.Forms.TextBox();
            this.txtDpi = new System.Windows.Forms.TextBox();
            this.lblDpi = new System.Windows.Forms.Label();
            this.gbxDatosP2 = new System.Windows.Forms.GroupBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.gbxRecomendacion = new System.Windows.Forms.GroupBox();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.cmbEncargado = new System.Windows.Forms.ComboBox();
            this.lblEncargadoRecom = new System.Windows.Forms.Label();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.tbcIngresoRecluta = new System.Windows.Forms.TabControl();
            this.tbpDatosPersonales.SuspendLayout();
            this.DatosP3.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.gbxFormacionAcademica.SuspendLayout();
            this.tbpDatosGenerales.SuspendLayout();
            this.gbxDatosP1.SuspendLayout();
            this.gbxDatosP2.SuspendLayout();
            this.gbxRecomendacion.SuspendLayout();
            this.tbcIngresoRecluta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(908, 619);
            this.btnIngreso.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(369, 81);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "Ingresar a Banco de Talento";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // tbpDatosPersonales
            // 
            this.tbpDatosPersonales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosPersonales.Controls.Add(this.DatosP3);
            this.tbpDatosPersonales.Controls.Add(this.gbxSexo);
            this.tbpDatosPersonales.Controls.Add(this.gbxFormacionAcademica);
            this.tbpDatosPersonales.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosPersonales.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbpDatosPersonales.Name = "tbpDatosPersonales";
            this.tbpDatosPersonales.Size = new System.Drawing.Size(1275, 581);
            this.tbpDatosPersonales.TabIndex = 3;
            this.tbpDatosPersonales.Text = "Datos Personales";
            // 
            // DatosP3
            // 
            this.DatosP3.Controls.Add(this.lblTipoLicencia);
            this.DatosP3.Controls.Add(this.dtpFechaNacimiento);
            this.DatosP3.Controls.Add(this.lblFechaNacimiento);
            this.DatosP3.Controls.Add(this.cmbEstadoCivil);
            this.DatosP3.Controls.Add(this.lblEstadoCivil);
            this.DatosP3.Controls.Add(this.cmbTipoLicencia);
            this.DatosP3.Location = new System.Drawing.Point(20, 165);
            this.DatosP3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatosP3.Name = "DatosP3";
            this.DatosP3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatosP3.Size = new System.Drawing.Size(504, 256);
            this.DatosP3.TabIndex = 30;
            this.DatosP3.TabStop = false;
            // 
            // lblTipoLicencia
            // 
            this.lblTipoLicencia.AutoSize = true;
            this.lblTipoLicencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipoLicencia.Location = new System.Drawing.Point(11, 110);
            this.lblTipoLicencia.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTipoLicencia.Name = "lblTipoLicencia";
            this.lblTipoLicencia.Size = new System.Drawing.Size(192, 20);
            this.lblTipoLicencia.TabIndex = 22;
            this.lblTipoLicencia.Text = "Tipo Licencia Conducir";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(16, 209);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(457, 27);
            this.dtpFechaNacimiento.TabIndex = 29;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(11, 165);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(174, 20);
            this.lblFechaNacimiento.TabIndex = 28;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Divorciado"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(280, 32);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(193, 28);
            this.cmbEstadoCivil.TabIndex = 5;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstadoCivil.Location = new System.Drawing.Point(11, 36);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(103, 20);
            this.lblEstadoCivil.TabIndex = 3;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // cmbTipoLicencia
            // 
            this.cmbTipoLicencia.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoLicencia.FormattingEnabled = true;
            this.cmbTipoLicencia.Location = new System.Drawing.Point(280, 106);
            this.cmbTipoLicencia.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbTipoLicencia.Name = "cmbTipoLicencia";
            this.cmbTipoLicencia.Size = new System.Drawing.Size(193, 28);
            this.cmbTipoLicencia.TabIndex = 23;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnFemenino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxSexo.Location = new System.Drawing.Point(20, 48);
            this.gbxSexo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbxSexo.Size = new System.Drawing.Size(404, 92);
            this.gbxSexo.TabIndex = 27;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFemenino.Location = new System.Drawing.Point(252, 42);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(109, 24);
            this.rbtnFemenino.TabIndex = 1;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            this.rbtnFemenino.CheckedChanged += new System.EventHandler(this.rbtnFemenino_CheckedChanged);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnMasculino.Location = new System.Drawing.Point(27, 42);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(111, 24);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.CheckedChanged += new System.EventHandler(this.rbtnMasculino_CheckedChanged);
            // 
            // gbxFormacionAcademica
            // 
            this.gbxFormacionAcademica.Controls.Add(this.txtProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.cmbNivelEstudios);
            this.gbxFormacionAcademica.Controls.Add(this.lblProfesion);
            this.gbxFormacionAcademica.Controls.Add(this.lblNivelEstudios);
            this.gbxFormacionAcademica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxFormacionAcademica.Location = new System.Drawing.Point(583, 180);
            this.gbxFormacionAcademica.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbxFormacionAcademica.Name = "gbxFormacionAcademica";
            this.gbxFormacionAcademica.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbxFormacionAcademica.Size = new System.Drawing.Size(676, 241);
            this.gbxFormacionAcademica.TabIndex = 21;
            this.gbxFormacionAcademica.TabStop = false;
            this.gbxFormacionAcademica.Text = "Formación Académica";
            // 
            // txtProfesion
            // 
            this.txtProfesion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtProfesion.Location = new System.Drawing.Point(260, 166);
            this.txtProfesion.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(401, 27);
            this.txtProfesion.TabIndex = 7;
            this.txtProfesion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // cmbNivelEstudios
            // 
            this.cmbNivelEstudios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbNivelEstudios.FormattingEnabled = true;
            this.cmbNivelEstudios.Location = new System.Drawing.Point(260, 81);
            this.cmbNivelEstudios.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbNivelEstudios.Name = "cmbNivelEstudios";
            this.cmbNivelEstudios.Size = new System.Drawing.Size(401, 28);
            this.cmbNivelEstudios.TabIndex = 7;
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblProfesion.Location = new System.Drawing.Point(16, 170);
            this.lblProfesion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(84, 20);
            this.lblProfesion.TabIndex = 1;
            this.lblProfesion.Text = "Profesión";
            // 
            // lblNivelEstudios
            // 
            this.lblNivelEstudios.AutoSize = true;
            this.lblNivelEstudios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNivelEstudios.Location = new System.Drawing.Point(16, 81);
            this.lblNivelEstudios.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNivelEstudios.Name = "lblNivelEstudios";
            this.lblNivelEstudios.Size = new System.Drawing.Size(145, 20);
            this.lblNivelEstudios.TabIndex = 0;
            this.lblNivelEstudios.Text = "Nivel de Estudios";
            // 
            // tbpDatosGenerales
            // 
            this.tbpDatosGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosGenerales.Controls.Add(this.btnAyuda);
            this.tbpDatosGenerales.Controls.Add(this.gbxDatosP1);
            this.tbpDatosGenerales.Controls.Add(this.gbxDatosP2);
            this.tbpDatosGenerales.Controls.Add(this.gbxRecomendacion);
            this.tbpDatosGenerales.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosGenerales.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbpDatosGenerales.Name = "tbpDatosGenerales";
            this.tbpDatosGenerales.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbpDatosGenerales.Size = new System.Drawing.Size(1275, 581);
            this.tbpDatosGenerales.TabIndex = 0;
            this.tbpDatosGenerales.Text = "Datos Generales";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1165, 9);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(96, 89);
            this.btnAyuda.TabIndex = 131;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // gbxDatosP1
            // 
            this.gbxDatosP1.Controls.Add(this.lblFechaRecluta);
            this.gbxDatosP1.Controls.Add(this.txtTelefono);
            this.gbxDatosP1.Controls.Add(this.dtpFechaRecluta);
            this.gbxDatosP1.Controls.Add(this.lblApellidos);
            this.gbxDatosP1.Controls.Add(this.lblNombres);
            this.gbxDatosP1.Controls.Add(this.lblCorreoElectronico);
            this.gbxDatosP1.Controls.Add(this.txtPrimerNombre);
            this.gbxDatosP1.Controls.Add(this.txtCorreoElectronico);
            this.gbxDatosP1.Controls.Add(this.lblNumeroIgss);
            this.gbxDatosP1.Controls.Add(this.lblTelefono);
            this.gbxDatosP1.Controls.Add(this.txtPrimerApellido);
            this.gbxDatosP1.Controls.Add(this.txtNumeroIgss);
            this.gbxDatosP1.Controls.Add(this.txtDpi);
            this.gbxDatosP1.Controls.Add(this.lblDpi);
            this.gbxDatosP1.Location = new System.Drawing.Point(4, 4);
            this.gbxDatosP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatosP1.Name = "gbxDatosP1";
            this.gbxDatosP1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatosP1.Size = new System.Drawing.Size(747, 431);
            this.gbxDatosP1.TabIndex = 24;
            this.gbxDatosP1.TabStop = false;
            // 
            // lblFechaRecluta
            // 
            this.lblFechaRecluta.AutoSize = true;
            this.lblFechaRecluta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaRecluta.Location = new System.Drawing.Point(11, 389);
            this.lblFechaRecluta.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFechaRecluta.Name = "lblFechaRecluta";
            this.lblFechaRecluta.Size = new System.Drawing.Size(197, 20);
            this.lblFechaRecluta.TabIndex = 30;
            this.lblFechaRecluta.Text = "Fecha de Reclutamiento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefono.Location = new System.Drawing.Point(236, 153);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(348, 27);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // dtpFechaRecluta
            // 
            this.dtpFechaRecluta.Location = new System.Drawing.Point(287, 386);
            this.dtpFechaRecluta.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dtpFechaRecluta.Name = "dtpFechaRecluta";
            this.dtpFechaRecluta.Size = new System.Drawing.Size(447, 27);
            this.dtpFechaRecluta.TabIndex = 29;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidos.Location = new System.Drawing.Point(11, 98);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(80, 20);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellido ";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombres.Location = new System.Drawing.Point(11, 36);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(81, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(11, 219);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(161, 20);
            this.lblCorreoElectronico.TabIndex = 28;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Location = new System.Drawing.Point(236, 27);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(476, 27);
            this.txtPrimerNombre.TabIndex = 1;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(236, 210);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(476, 27);
            this.txtCorreoElectronico.TabIndex = 4;
            // 
            // lblNumeroIgss
            // 
            this.lblNumeroIgss.AutoSize = true;
            this.lblNumeroIgss.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroIgss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumeroIgss.Location = new System.Drawing.Point(11, 332);
            this.lblNumeroIgss.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNumeroIgss.Name = "lblNumeroIgss";
            this.lblNumeroIgss.Size = new System.Drawing.Size(137, 20);
            this.lblNumeroIgss.TabIndex = 11;
            this.lblNumeroIgss.Text = "Número del Igss";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefono.Location = new System.Drawing.Point(11, 161);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Location = new System.Drawing.Point(236, 90);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(476, 27);
            this.txtPrimerApellido.TabIndex = 2;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // txtNumeroIgss
            // 
            this.txtNumeroIgss.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNumeroIgss.Location = new System.Drawing.Point(236, 329);
            this.txtNumeroIgss.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNumeroIgss.Name = "txtNumeroIgss";
            this.txtNumeroIgss.Size = new System.Drawing.Size(348, 27);
            this.txtNumeroIgss.TabIndex = 6;
            this.txtNumeroIgss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // txtDpi
            // 
            this.txtDpi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDpi.Location = new System.Drawing.Point(236, 268);
            this.txtDpi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDpi.Name = "txtDpi";
            this.txtDpi.Size = new System.Drawing.Size(348, 27);
            this.txtDpi.TabIndex = 5;
            this.txtDpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDpi.Location = new System.Drawing.Point(11, 277);
            this.lblDpi.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(36, 20);
            this.lblDpi.TabIndex = 22;
            this.lblDpi.Text = "DPI";
            // 
            // gbxDatosP2
            // 
            this.gbxDatosP2.Controls.Add(this.cmbHorario);
            this.gbxDatosP2.Controls.Add(this.cmbDepartamentoTrabajo);
            this.gbxDatosP2.Controls.Add(this.lblHorario);
            this.gbxDatosP2.Controls.Add(this.lblDepartamentoTrabajo);
            this.gbxDatosP2.Controls.Add(this.lblPuesto);
            this.gbxDatosP2.Controls.Add(this.cmbPuesto);
            this.gbxDatosP2.Location = new System.Drawing.Point(820, 110);
            this.gbxDatosP2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatosP2.Name = "gbxDatosP2";
            this.gbxDatosP2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDatosP2.Size = new System.Drawing.Size(441, 316);
            this.gbxDatosP2.TabIndex = 23;
            this.gbxDatosP2.TabStop = false;
            // 
            // cmbHorario
            // 
            this.cmbHorario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(16, 256);
            this.cmbHorario.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(381, 28);
            this.cmbHorario.TabIndex = 22;
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(16, 151);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(381, 28);
            this.cmbDepartamentoTrabajo.TabIndex = 9;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHorario.Location = new System.Drawing.Point(11, 214);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(157, 20);
            this.lblHorario.TabIndex = 20;
            this.lblHorario.Text = "Horario que Aplica";
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(11, 110);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(209, 20);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento que Aplica";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuesto.Location = new System.Drawing.Point(11, 27);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(150, 20);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto que Aplica";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(16, 58);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(381, 28);
            this.cmbPuesto.TabIndex = 14;
            // 
            // gbxRecomendacion
            // 
            this.gbxRecomendacion.Controls.Add(this.lblPregunta);
            this.gbxRecomendacion.Controls.Add(this.cmbEncargado);
            this.gbxRecomendacion.Controls.Add(this.lblEncargadoRecom);
            this.gbxRecomendacion.Controls.Add(this.rbtnNo);
            this.gbxRecomendacion.Controls.Add(this.rbtnSi);
            this.gbxRecomendacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxRecomendacion.Location = new System.Drawing.Point(4, 433);
            this.gbxRecomendacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxRecomendacion.Name = "gbxRecomendacion";
            this.gbxRecomendacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxRecomendacion.Size = new System.Drawing.Size(985, 130);
            this.gbxRecomendacion.TabIndex = 22;
            this.gbxRecomendacion.TabStop = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPregunta.Location = new System.Drawing.Point(11, 28);
            this.lblPregunta.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(380, 20);
            this.lblPregunta.TabIndex = 25;
            this.lblPregunta.Text = "El Recluta cuenta con Recomendación Interna ?";
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.Enabled = false;
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(507, 78);
            this.cmbEncargado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(469, 28);
            this.cmbEncargado.TabIndex = 48;
            this.cmbEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // lblEncargadoRecom
            // 
            this.lblEncargadoRecom.AutoSize = true;
            this.lblEncargadoRecom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEncargadoRecom.Location = new System.Drawing.Point(11, 81);
            this.lblEncargadoRecom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncargadoRecom.Name = "lblEncargadoRecom";
            this.lblEncargadoRecom.Size = new System.Drawing.Size(314, 20);
            this.lblEncargadoRecom.TabIndex = 25;
            this.lblEncargadoRecom.Text = "Empleado que hizo la Recomendación:";
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnNo.Location = new System.Drawing.Point(699, 26);
            this.rbtnNo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(52, 24);
            this.rbtnNo.TabIndex = 24;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            this.rbtnNo.CheckedChanged += new System.EventHandler(this.rbtnNo_CheckedChanged);
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnSi.Location = new System.Drawing.Point(565, 28);
            this.rbtnSi.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(44, 24);
            this.rbtnSi.TabIndex = 23;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "Si";
            this.rbtnSi.UseVisualStyleBackColor = true;
            this.rbtnSi.CheckedChanged += new System.EventHandler(this.rbtnSi_CheckedChanged);
            // 
            // tbcIngresoRecluta
            // 
            this.tbcIngresoRecluta.Controls.Add(this.tbpDatosGenerales);
            this.tbcIngresoRecluta.Controls.Add(this.tbpDatosPersonales);
            this.tbcIngresoRecluta.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcIngresoRecluta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcIngresoRecluta.Location = new System.Drawing.Point(0, 0);
            this.tbcIngresoRecluta.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tbcIngresoRecluta.Name = "tbcIngresoRecluta";
            this.tbcIngresoRecluta.SelectedIndex = 0;
            this.tbcIngresoRecluta.Size = new System.Drawing.Size(1283, 614);
            this.tbcIngresoRecluta.TabIndex = 13;
            // 
            // frmIngresoReclutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1283, 703);
            this.Controls.Add(this.tbcIngresoRecluta);
            this.Controls.Add(this.btnIngreso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIngresoReclutas";
            this.Text = "Ingreso Reclutas";
            this.Load += new System.EventHandler(this.funcfrmIngreso_Load);
            this.tbpDatosPersonales.ResumeLayout(false);
            this.DatosP3.ResumeLayout(false);
            this.DatosP3.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxFormacionAcademica.ResumeLayout(false);
            this.gbxFormacionAcademica.PerformLayout();
            this.tbpDatosGenerales.ResumeLayout(false);
            this.gbxDatosP1.ResumeLayout(false);
            this.gbxDatosP1.PerformLayout();
            this.gbxDatosP2.ResumeLayout(false);
            this.gbxDatosP2.PerformLayout();
            this.gbxRecomendacion.ResumeLayout(false);
            this.gbxRecomendacion.PerformLayout();
            this.tbcIngresoRecluta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TabPage tbpDatosPersonales;
        private System.Windows.Forms.GroupBox gbxFormacionAcademica;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.ComboBox cmbNivelEstudios;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblNivelEstudios;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TabPage tbpDatosGenerales;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.TextBox txtNumeroIgss;
        private System.Windows.Forms.Label lblDpi;
        private System.Windows.Forms.TextBox txtDpi;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblNumeroIgss;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TabControl tbcIngresoRecluta;
        private System.Windows.Forms.ComboBox cmbTipoLicencia;
        private System.Windows.Forms.Label lblTipoLicencia;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblFechaRecluta;
        private System.Windows.Forms.DateTimePicker dtpFechaRecluta;
        private System.Windows.Forms.GroupBox gbxRecomendacion;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.GroupBox DatosP3;
        private System.Windows.Forms.GroupBox gbxDatosP1;
        private System.Windows.Forms.GroupBox gbxDatosP2;
        private System.Windows.Forms.Label lblEncargadoRecom;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnAyuda;
    }
}