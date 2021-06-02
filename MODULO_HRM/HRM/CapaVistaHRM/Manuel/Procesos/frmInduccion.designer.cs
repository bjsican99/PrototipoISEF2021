
    namespace CapaVistaHRM.Manuel.Procesos
{
    partial class frmInduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInduccion));
            this.tbcEntrevista = new System.Windows.Forms.TabControl();
            this.tbpDatosRecluta = new System.Windows.Forms.TabPage();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbxDatosP2 = new System.Windows.Forms.GroupBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.cmbPuestoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.gbxDatos1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbpDatosEntrevista = new System.Windows.Forms.TabPage();
            this.gbxDatosInduccion = new System.Windows.Forms.GroupBox();
            this.cmbEncargado = new System.Windows.Forms.ComboBox();
            this.dtpFechaInduccion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInduc = new System.Windows.Forms.Label();
            this.btnIngresoInduccion = new System.Windows.Forms.Button();
            this.cmbTipoInduccion = new System.Windows.Forms.ComboBox();
            this.lblEncargadoInduc = new System.Windows.Forms.Label();
            this.lblTipoEntrevista = new System.Windows.Forms.Label();
            this.tbcEntrevista.SuspendLayout();
            this.tbpDatosRecluta.SuspendLayout();
            this.gbxDatosP2.SuspendLayout();
            this.gbxDatos1.SuspendLayout();
            this.tbpDatosEntrevista.SuspendLayout();
            this.gbxDatosInduccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEntrevista
            // 
            this.tbcEntrevista.Controls.Add(this.tbpDatosRecluta);
            this.tbcEntrevista.Controls.Add(this.tbpDatosEntrevista);
            this.tbcEntrevista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcEntrevista.Location = new System.Drawing.Point(0, 0);
            this.tbcEntrevista.Name = "tbcEntrevista";
            this.tbcEntrevista.SelectedIndex = 0;
            this.tbcEntrevista.Size = new System.Drawing.Size(753, 432);
            this.tbcEntrevista.TabIndex = 0;
            // 
            // tbpDatosRecluta
            // 
            this.tbpDatosRecluta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosRecluta.Controls.Add(this.btnAyuda);
            this.tbpDatosRecluta.Controls.Add(this.gbxDatosP2);
            this.tbpDatosRecluta.Controls.Add(this.gbxDatos1);
            this.tbpDatosRecluta.Controls.Add(this.btnEmpleados);
            this.tbpDatosRecluta.Controls.Add(this.lblIdEmpleado);
            this.tbpDatosRecluta.Controls.Add(this.txtIdEmpleado);
            this.tbpDatosRecluta.Controls.Add(this.btnBuscar);
            this.tbpDatosRecluta.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosRecluta.Name = "tbpDatosRecluta";
            this.tbpDatosRecluta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosRecluta.Size = new System.Drawing.Size(745, 399);
            this.tbpDatosRecluta.TabIndex = 0;
            this.tbpDatosRecluta.Text = "Datos Recluta";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(667, 6);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 130;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // gbxDatosP2
            // 
            this.gbxDatosP2.Controls.Add(this.lblHorario);
            this.gbxDatosP2.Controls.Add(this.cmbDepartamentoTrabajo);
            this.gbxDatosP2.Controls.Add(this.cmbHorario);
            this.gbxDatosP2.Controls.Add(this.lblDepartamentoTrabajo);
            this.gbxDatosP2.Controls.Add(this.cmbPuestoTrabajo);
            this.gbxDatosP2.Controls.Add(this.lblPuesto);
            this.gbxDatosP2.Enabled = false;
            this.gbxDatosP2.Location = new System.Drawing.Point(472, 100);
            this.gbxDatosP2.Name = "gbxDatosP2";
            this.gbxDatosP2.Size = new System.Drawing.Size(262, 233);
            this.gbxDatosP2.TabIndex = 37;
            this.gbxDatosP2.TabStop = false;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHorario.Location = new System.Drawing.Point(3, 166);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(73, 20);
            this.lblHorario.TabIndex = 36;
            this.lblHorario.Text = "Horario ";
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoTrabajo.Enabled = false;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(7, 119);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(242, 28);
            this.cmbDepartamentoTrabajo.TabIndex = 35;
            // 
            // cmbHorario
            // 
            this.cmbHorario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHorario.Enabled = false;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(7, 190);
            this.cmbHorario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(242, 28);
            this.cmbHorario.TabIndex = 36;
            // 
            // lblDepartamentoTrabajo
            // 
            this.lblDepartamentoTrabajo.AutoSize = true;
            this.lblDepartamentoTrabajo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoTrabajo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(2, 91);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(121, 20);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento";
            // 
            // cmbPuestoTrabajo
            // 
            this.cmbPuestoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoTrabajo.Enabled = false;
            this.cmbPuestoTrabajo.FormattingEnabled = true;
            this.cmbPuestoTrabajo.Location = new System.Drawing.Point(7, 48);
            this.cmbPuestoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuestoTrabajo.Name = "cmbPuestoTrabajo";
            this.cmbPuestoTrabajo.Size = new System.Drawing.Size(242, 28);
            this.cmbPuestoTrabajo.TabIndex = 29;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuesto.Location = new System.Drawing.Point(2, 22);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(62, 20);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto";
            // 
            // gbxDatos1
            // 
            this.gbxDatos1.Controls.Add(this.txtTelefono);
            this.gbxDatos1.Controls.Add(this.txtCorreoElectronico);
            this.gbxDatos1.Controls.Add(this.lblCorreoElectronico);
            this.gbxDatos1.Controls.Add(this.lblTelefono);
            this.gbxDatos1.Controls.Add(this.txtPrimerApellido);
            this.gbxDatos1.Controls.Add(this.txtPrimerNombre);
            this.gbxDatos1.Controls.Add(this.lblApellidos);
            this.gbxDatos1.Controls.Add(this.lblNombres);
            this.gbxDatos1.Enabled = false;
            this.gbxDatos1.Location = new System.Drawing.Point(8, 100);
            this.gbxDatos1.Name = "gbxDatos1";
            this.gbxDatos1.Size = new System.Drawing.Size(448, 199);
            this.gbxDatos1.TabIndex = 36;
            this.gbxDatos1.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(186, 159);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(145, 27);
            this.txtTelefono.TabIndex = 25;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCorreoElectronico.Enabled = false;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(186, 112);
            this.txtCorreoElectronico.Margin = new System.Windows.Forms.Padding(5);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(254, 27);
            this.txtCorreoElectronico.TabIndex = 23;
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(1, 115);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(161, 20);
            this.lblCorreoElectronico.TabIndex = 26;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTelefono.Location = new System.Drawing.Point(1, 162);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(186, 69);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(229, 27);
            this.txtPrimerApellido.TabIndex = 7;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(186, 20);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(229, 27);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidos.Location = new System.Drawing.Point(5, 76);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(84, 20);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombres.Location = new System.Drawing.Point(5, 20);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(81, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(8, 314);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(207, 76);
            this.btnEmpleados.TabIndex = 35;
            this.btnEmpleados.Text = "Ver Lista Empleados sin Inducción Realizada";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnReclutas_Click);
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdEmpleado.Location = new System.Drawing.Point(42, 49);
            this.lblIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(222, 20);
            this.lblIdEmpleado.TabIndex = 34;
            this.lblIdEmpleado.Text = "Ingrese el ID del Empleado";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdEmpleado.Location = new System.Drawing.Point(272, 46);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(184, 27);
            this.txtIdEmpleado.TabIndex = 33;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(488, 40);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 38);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbpDatosEntrevista
            // 
            this.tbpDatosEntrevista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosEntrevista.Controls.Add(this.gbxDatosInduccion);
            this.tbpDatosEntrevista.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosEntrevista.Name = "tbpDatosEntrevista";
            this.tbpDatosEntrevista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosEntrevista.Size = new System.Drawing.Size(745, 399);
            this.tbpDatosEntrevista.TabIndex = 1;
            this.tbpDatosEntrevista.Text = "Datos Inducción";
            // 
            // gbxDatosInduccion
            // 
            this.gbxDatosInduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.gbxDatosInduccion.Controls.Add(this.cmbEncargado);
            this.gbxDatosInduccion.Controls.Add(this.dtpFechaInduccion);
            this.gbxDatosInduccion.Controls.Add(this.lblFechaInduc);
            this.gbxDatosInduccion.Controls.Add(this.btnIngresoInduccion);
            this.gbxDatosInduccion.Controls.Add(this.cmbTipoInduccion);
            this.gbxDatosInduccion.Controls.Add(this.lblEncargadoInduc);
            this.gbxDatosInduccion.Controls.Add(this.lblTipoEntrevista);
            this.gbxDatosInduccion.Enabled = false;
            this.gbxDatosInduccion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDatosInduccion.Location = new System.Drawing.Point(8, 23);
            this.gbxDatosInduccion.Name = "gbxDatosInduccion";
            this.gbxDatosInduccion.Size = new System.Drawing.Size(729, 368);
            this.gbxDatosInduccion.TabIndex = 10;
            this.gbxDatosInduccion.TabStop = false;
            this.gbxDatosInduccion.Text = "Datos de Induccion";
            // 
            // cmbEncargado
            // 
            this.cmbEncargado.FormattingEnabled = true;
            this.cmbEncargado.Location = new System.Drawing.Point(27, 233);
            this.cmbEncargado.Name = "cmbEncargado";
            this.cmbEncargado.Size = new System.Drawing.Size(262, 28);
            this.cmbEncargado.TabIndex = 47;
            this.cmbEncargado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            // 
            // dtpFechaInduccion
            // 
            this.dtpFechaInduccion.Location = new System.Drawing.Point(292, 120);
            this.dtpFechaInduccion.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFechaInduccion.Name = "dtpFechaInduccion";
            this.dtpFechaInduccion.Size = new System.Drawing.Size(324, 27);
            this.dtpFechaInduccion.TabIndex = 45;
            // 
            // lblFechaInduc
            // 
            this.lblFechaInduc.AutoSize = true;
            this.lblFechaInduc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFechaInduc.Location = new System.Drawing.Point(23, 127);
            this.lblFechaInduc.Name = "lblFechaInduc";
            this.lblFechaInduc.Size = new System.Drawing.Size(232, 20);
            this.lblFechaInduc.TabIndex = 14;
            this.lblFechaInduc.Text = "Fecha Realización Inducción";
            // 
            // btnIngresoInduccion
            // 
            this.btnIngresoInduccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresoInduccion.Location = new System.Drawing.Point(534, 282);
            this.btnIngresoInduccion.Name = "btnIngresoInduccion";
            this.btnIngresoInduccion.Size = new System.Drawing.Size(180, 68);
            this.btnIngresoInduccion.TabIndex = 8;
            this.btnIngresoInduccion.Text = "Ingresar Inducción";
            this.btnIngresoInduccion.UseVisualStyleBackColor = true;
            this.btnIngresoInduccion.Click += new System.EventHandler(this.btnIngresoEntrevista_Click);
            // 
            // cmbTipoInduccion
            // 
            this.cmbTipoInduccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoInduccion.FormattingEnabled = true;
            this.cmbTipoInduccion.Location = new System.Drawing.Point(292, 57);
            this.cmbTipoInduccion.Name = "cmbTipoInduccion";
            this.cmbTipoInduccion.Size = new System.Drawing.Size(149, 28);
            this.cmbTipoInduccion.TabIndex = 7;
            // 
            // lblEncargadoInduc
            // 
            this.lblEncargadoInduc.AutoSize = true;
            this.lblEncargadoInduc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEncargadoInduc.Location = new System.Drawing.Point(23, 191);
            this.lblEncargadoInduc.Name = "lblEncargadoInduc";
            this.lblEncargadoInduc.Size = new System.Drawing.Size(223, 20);
            this.lblEncargadoInduc.TabIndex = 4;
            this.lblEncargadoInduc.Text = "Encargado de la Inducción:";
            // 
            // lblTipoEntrevista
            // 
            this.lblTipoEntrevista.AutoSize = true;
            this.lblTipoEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipoEntrevista.Location = new System.Drawing.Point(23, 65);
            this.lblTipoEntrevista.Name = "lblTipoEntrevista";
            this.lblTipoEntrevista.Size = new System.Drawing.Size(126, 20);
            this.lblTipoEntrevista.TabIndex = 6;
            this.lblTipoEntrevista.Text = "Tipo Induccion";
            // 
            // frmInduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(753, 432);
            this.Controls.Add(this.tbcEntrevista);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInduccion";
            this.Text = "Induccion";
            this.Load += new System.EventHandler(this.frmEntrevista_Load);
            this.tbcEntrevista.ResumeLayout(false);
            this.tbpDatosRecluta.ResumeLayout(false);
            this.tbpDatosRecluta.PerformLayout();
            this.gbxDatosP2.ResumeLayout(false);
            this.gbxDatosP2.PerformLayout();
            this.gbxDatos1.ResumeLayout(false);
            this.gbxDatos1.PerformLayout();
            this.tbpDatosEntrevista.ResumeLayout(false);
            this.gbxDatosInduccion.ResumeLayout(false);
            this.gbxDatosInduccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEntrevista;
        private System.Windows.Forms.TabPage tbpDatosRecluta;
        private System.Windows.Forms.TabPage tbpDatosEntrevista;
        private System.Windows.Forms.GroupBox gbxDatosInduccion;
        private System.Windows.Forms.ComboBox cmbTipoInduccion;
        private System.Windows.Forms.Label lblEncargadoInduc;
        private System.Windows.Forms.Label lblTipoEntrevista;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuestoTrabajo;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnIngresoInduccion;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label lblFechaInduc;
        private System.Windows.Forms.DateTimePicker dtpFechaInduccion;
        private System.Windows.Forms.GroupBox gbxDatos1;
        private System.Windows.Forms.GroupBox gbxDatosP2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbEncargado;
        private System.Windows.Forms.Button btnAyuda;
    }
}