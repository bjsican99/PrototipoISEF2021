
    namespace CapaVistaHRM.Manuel.Procesos
{
    partial class frmEntrevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrevista));
            this.tbcEntrevista = new System.Windows.Forms.TabControl();
            this.tbpDatosRecluta = new System.Windows.Forms.TabPage();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbxDatosP1 = new System.Windows.Forms.GroupBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.gbxDatosP2 = new System.Windows.Forms.GroupBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.cmbPuestoTrabajo = new System.Windows.Forms.ComboBox();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.lblDepartamentoTrabajo = new System.Windows.Forms.Label();
            this.cmbDepartamentoTrabajo = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.btnReclutas = new System.Windows.Forms.Button();
            this.lblIngreseIdRecluta = new System.Windows.Forms.Label();
            this.txtIdBancoTalento = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbpDatosEntrevista = new System.Windows.Forms.TabPage();
            this.gbxDatosEntrevista = new System.Windows.Forms.GroupBox();
            this.gbxPunteos = new System.Windows.Forms.GroupBox();
            this.Punteo3 = new System.Windows.Forms.Label();
            this.Punteo2 = new System.Windows.Forms.Label();
            this.Punteo1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtPunteo = new System.Windows.Forms.TextBox();
            this.lblPunteoEntrevista = new System.Windows.Forms.Label();
            this.btnIngresoEntrevista = new System.Windows.Forms.Button();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.cmbTipoEntrevista = new System.Windows.Forms.ComboBox();
            this.lblResultadoEntrevista = new System.Windows.Forms.Label();
            this.lblTipoEntrevista = new System.Windows.Forms.Label();
            this.tbcEntrevista.SuspendLayout();
            this.tbpDatosRecluta.SuspendLayout();
            this.gbxDatosP1.SuspendLayout();
            this.gbxDatosP2.SuspendLayout();
            this.tbpDatosEntrevista.SuspendLayout();
            this.gbxDatosEntrevista.SuspendLayout();
            this.gbxPunteos.SuspendLayout();
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
            this.tbcEntrevista.Size = new System.Drawing.Size(766, 431);
            this.tbcEntrevista.TabIndex = 0;
            // 
            // tbpDatosRecluta
            // 
            this.tbpDatosRecluta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.tbpDatosRecluta.Controls.Add(this.btnAyuda);
            this.tbpDatosRecluta.Controls.Add(this.gbxDatosP1);
            this.tbpDatosRecluta.Controls.Add(this.gbxDatosP2);
            this.tbpDatosRecluta.Controls.Add(this.btnReclutas);
            this.tbpDatosRecluta.Controls.Add(this.lblIngreseIdRecluta);
            this.tbpDatosRecluta.Controls.Add(this.txtIdBancoTalento);
            this.tbpDatosRecluta.Controls.Add(this.btnBuscar);
            this.tbpDatosRecluta.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosRecluta.Name = "tbpDatosRecluta";
            this.tbpDatosRecluta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosRecluta.Size = new System.Drawing.Size(758, 398);
            this.tbpDatosRecluta.TabIndex = 0;
            this.tbpDatosRecluta.Text = "Datos Recluta";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(676, 16);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(72, 72);
            this.btnAyuda.TabIndex = 132;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // gbxDatosP1
            // 
            this.gbxDatosP1.Controls.Add(this.txtPrimerApellido);
            this.gbxDatosP1.Controls.Add(this.txtPrimerNombre);
            this.gbxDatosP1.Controls.Add(this.lblApellidos);
            this.gbxDatosP1.Controls.Add(this.lblNombres);
            this.gbxDatosP1.Enabled = false;
            this.gbxDatosP1.Location = new System.Drawing.Point(17, 127);
            this.gbxDatosP1.Name = "gbxDatosP1";
            this.gbxDatosP1.Size = new System.Drawing.Size(439, 136);
            this.gbxDatosP1.TabIndex = 37;
            this.gbxDatosP1.TabStop = false;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Location = new System.Drawing.Point(119, 92);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(298, 27);
            this.txtPrimerApellido.TabIndex = 7;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Location = new System.Drawing.Point(119, 39);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(298, 27);
            this.txtPrimerNombre.TabIndex = 5;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellidos.Location = new System.Drawing.Point(7, 95);
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
            this.lblNombres.Location = new System.Drawing.Point(7, 39);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(81, 20);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // gbxDatosP2
            // 
            this.gbxDatosP2.Controls.Add(this.lblHorario);
            this.gbxDatosP2.Controls.Add(this.cmbPuestoTrabajo);
            this.gbxDatosP2.Controls.Add(this.cmbHorario);
            this.gbxDatosP2.Controls.Add(this.lblDepartamentoTrabajo);
            this.gbxDatosP2.Controls.Add(this.cmbDepartamentoTrabajo);
            this.gbxDatosP2.Controls.Add(this.lblPuesto);
            this.gbxDatosP2.Enabled = false;
            this.gbxDatosP2.Location = new System.Drawing.Point(484, 127);
            this.gbxDatosP2.Name = "gbxDatosP2";
            this.gbxDatosP2.Size = new System.Drawing.Size(264, 231);
            this.gbxDatosP2.TabIndex = 36;
            this.gbxDatosP2.TabStop = false;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHorario.Location = new System.Drawing.Point(3, 164);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(157, 20);
            this.lblHorario.TabIndex = 36;
            this.lblHorario.Text = "Horario que Aplica";
            // 
            // cmbPuestoTrabajo
            // 
            this.cmbPuestoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbPuestoTrabajo.Enabled = false;
            this.cmbPuestoTrabajo.FormattingEnabled = true;
            this.cmbPuestoTrabajo.Location = new System.Drawing.Point(7, 46);
            this.cmbPuestoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuestoTrabajo.Name = "cmbPuestoTrabajo";
            this.cmbPuestoTrabajo.Size = new System.Drawing.Size(242, 28);
            this.cmbPuestoTrabajo.TabIndex = 29;
            // 
            // cmbHorario
            // 
            this.cmbHorario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbHorario.Enabled = false;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(7, 188);
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
            this.lblDepartamentoTrabajo.Location = new System.Drawing.Point(2, 89);
            this.lblDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartamentoTrabajo.Name = "lblDepartamentoTrabajo";
            this.lblDepartamentoTrabajo.Size = new System.Drawing.Size(209, 20);
            this.lblDepartamentoTrabajo.TabIndex = 18;
            this.lblDepartamentoTrabajo.Text = "Departamento que Aplica";
            // 
            // cmbDepartamentoTrabajo
            // 
            this.cmbDepartamentoTrabajo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDepartamentoTrabajo.Enabled = false;
            this.cmbDepartamentoTrabajo.FormattingEnabled = true;
            this.cmbDepartamentoTrabajo.Location = new System.Drawing.Point(7, 117);
            this.cmbDepartamentoTrabajo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartamentoTrabajo.Name = "cmbDepartamentoTrabajo";
            this.cmbDepartamentoTrabajo.Size = new System.Drawing.Size(242, 28);
            this.cmbDepartamentoTrabajo.TabIndex = 35;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPuesto.Location = new System.Drawing.Point(2, 20);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(150, 20);
            this.lblPuesto.TabIndex = 19;
            this.lblPuesto.Text = "Puesto que Aplica";
            // 
            // btnReclutas
            // 
            this.btnReclutas.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclutas.Location = new System.Drawing.Point(17, 315);
            this.btnReclutas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReclutas.Name = "btnReclutas";
            this.btnReclutas.Size = new System.Drawing.Size(184, 76);
            this.btnReclutas.TabIndex = 35;
            this.btnReclutas.Text = "Ver Lista Reclutas No Entrevistados";
            this.btnReclutas.UseVisualStyleBackColor = true;
            this.btnReclutas.Click += new System.EventHandler(this.btnReclutas_Click);
            // 
            // lblIngreseIdRecluta
            // 
            this.lblIngreseIdRecluta.AutoSize = true;
            this.lblIngreseIdRecluta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngreseIdRecluta.Location = new System.Drawing.Point(56, 78);
            this.lblIngreseIdRecluta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseIdRecluta.Name = "lblIngreseIdRecluta";
            this.lblIngreseIdRecluta.Size = new System.Drawing.Size(200, 20);
            this.lblIngreseIdRecluta.TabIndex = 34;
            this.lblIngreseIdRecluta.Text = "Ingrese el ID del Recluta";
            // 
            // txtIdBancoTalento
            // 
            this.txtIdBancoTalento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIdBancoTalento.Location = new System.Drawing.Point(300, 75);
            this.txtIdBancoTalento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBancoTalento.Name = "txtIdBancoTalento";
            this.txtIdBancoTalento.Size = new System.Drawing.Size(184, 27);
            this.txtIdBancoTalento.TabIndex = 33;
            this.txtIdBancoTalento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(517, 69);
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
            this.tbpDatosEntrevista.Controls.Add(this.gbxDatosEntrevista);
            this.tbpDatosEntrevista.Location = new System.Drawing.Point(4, 29);
            this.tbpDatosEntrevista.Name = "tbpDatosEntrevista";
            this.tbpDatosEntrevista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosEntrevista.Size = new System.Drawing.Size(758, 398);
            this.tbpDatosEntrevista.TabIndex = 1;
            this.tbpDatosEntrevista.Text = "Datos Entrevista";
            // 
            // gbxDatosEntrevista
            // 
            this.gbxDatosEntrevista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.gbxDatosEntrevista.Controls.Add(this.gbxPunteos);
            this.gbxDatosEntrevista.Controls.Add(this.txtResultado);
            this.gbxDatosEntrevista.Controls.Add(this.txtPunteo);
            this.gbxDatosEntrevista.Controls.Add(this.lblPunteoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.btnIngresoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.rtxtComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.lblComentarios);
            this.gbxDatosEntrevista.Controls.Add(this.cmbTipoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblResultadoEntrevista);
            this.gbxDatosEntrevista.Controls.Add(this.lblTipoEntrevista);
            this.gbxDatosEntrevista.Enabled = false;
            this.gbxDatosEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxDatosEntrevista.Location = new System.Drawing.Point(8, 23);
            this.gbxDatosEntrevista.Name = "gbxDatosEntrevista";
            this.gbxDatosEntrevista.Size = new System.Drawing.Size(750, 367);
            this.gbxDatosEntrevista.TabIndex = 10;
            this.gbxDatosEntrevista.TabStop = false;
            this.gbxDatosEntrevista.Text = "Datos de Entrevista";
            // 
            // gbxPunteos
            // 
            this.gbxPunteos.Controls.Add(this.Punteo3);
            this.gbxPunteos.Controls.Add(this.Punteo2);
            this.gbxPunteos.Controls.Add(this.Punteo1);
            this.gbxPunteos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPunteos.Location = new System.Drawing.Point(530, 104);
            this.gbxPunteos.Name = "gbxPunteos";
            this.gbxPunteos.Size = new System.Drawing.Size(212, 100);
            this.gbxPunteos.TabIndex = 18;
            this.gbxPunteos.TabStop = false;
            this.gbxPunteos.Text = "Rango Punteos";
            // 
            // Punteo3
            // 
            this.Punteo3.AutoSize = true;
            this.Punteo3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Punteo3.Location = new System.Drawing.Point(6, 68);
            this.Punteo3.Name = "Punteo3";
            this.Punteo3.Size = new System.Drawing.Size(143, 20);
            this.Punteo3.TabIndex = 21;
            this.Punteo3.Text = "0 a 50 Reprobado";
            // 
            // Punteo2
            // 
            this.Punteo2.AutoSize = true;
            this.Punteo2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Punteo2.Location = new System.Drawing.Point(6, 48);
            this.Punteo2.Name = "Punteo2";
            this.Punteo2.Size = new System.Drawing.Size(196, 20);
            this.Punteo2.TabIndex = 20;
            this.Punteo2.Text = "51 a 79 Segunda Opción";
            // 
            // Punteo1
            // 
            this.Punteo1.AutoSize = true;
            this.Punteo1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Punteo1.Location = new System.Drawing.Point(6, 28);
            this.Punteo1.Name = "Punteo1";
            this.Punteo1.Size = new System.Drawing.Size(200, 20);
            this.Punteo1.TabIndex = 19;
            this.Punteo1.Text = "80 a 100 Primera Opción";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(248, 120);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(128, 27);
            this.txtResultado.TabIndex = 17;
            // 
            // txtPunteo
            // 
            this.txtPunteo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPunteo.Location = new System.Drawing.Point(248, 72);
            this.txtPunteo.Name = "txtPunteo";
            this.txtPunteo.Size = new System.Drawing.Size(128, 27);
            this.txtPunteo.TabIndex = 15;
            this.txtPunteo.TextChanged += new System.EventHandler(this.txtPunteo_TextChanged);
            this.txtPunteo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            // 
            // lblPunteoEntrevista
            // 
            this.lblPunteoEntrevista.AutoSize = true;
            this.lblPunteoEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPunteoEntrevista.Location = new System.Drawing.Point(6, 79);
            this.lblPunteoEntrevista.Name = "lblPunteoEntrevista";
            this.lblPunteoEntrevista.Size = new System.Drawing.Size(189, 20);
            this.lblPunteoEntrevista.TabIndex = 14;
            this.lblPunteoEntrevista.Text = "Punteo de la Entrevista";
            // 
            // btnIngresoEntrevista
            // 
            this.btnIngresoEntrevista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresoEntrevista.Location = new System.Drawing.Point(563, 25);
            this.btnIngresoEntrevista.Name = "btnIngresoEntrevista";
            this.btnIngresoEntrevista.Size = new System.Drawing.Size(179, 73);
            this.btnIngresoEntrevista.TabIndex = 8;
            this.btnIngresoEntrevista.Text = "Ingresar Entrevista";
            this.btnIngresoEntrevista.UseVisualStyleBackColor = true;
            this.btnIngresoEntrevista.Click += new System.EventHandler(this.btnIngresoEntrevista_Click);
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtxtComentarios.Location = new System.Drawing.Point(12, 210);
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(730, 151);
            this.rtxtComentarios.TabIndex = 2;
            this.rtxtComentarios.Text = "";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblComentarios.Location = new System.Drawing.Point(8, 184);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(250, 20);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "Comentarios del Entrevistador";
            // 
            // cmbTipoEntrevista
            // 
            this.cmbTipoEntrevista.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoEntrevista.FormattingEnabled = true;
            this.cmbTipoEntrevista.Location = new System.Drawing.Point(248, 26);
            this.cmbTipoEntrevista.Name = "cmbTipoEntrevista";
            this.cmbTipoEntrevista.Size = new System.Drawing.Size(149, 28);
            this.cmbTipoEntrevista.TabIndex = 7;
            // 
            // lblResultadoEntrevista
            // 
            this.lblResultadoEntrevista.AutoSize = true;
            this.lblResultadoEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultadoEntrevista.Location = new System.Drawing.Point(8, 123);
            this.lblResultadoEntrevista.Name = "lblResultadoEntrevista";
            this.lblResultadoEntrevista.Size = new System.Drawing.Size(211, 20);
            this.lblResultadoEntrevista.TabIndex = 4;
            this.lblResultadoEntrevista.Text = "Resultado de la Entrevista";
            // 
            // lblTipoEntrevista
            // 
            this.lblTipoEntrevista.AutoSize = true;
            this.lblTipoEntrevista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTipoEntrevista.Location = new System.Drawing.Point(6, 34);
            this.lblTipoEntrevista.Name = "lblTipoEntrevista";
            this.lblTipoEntrevista.Size = new System.Drawing.Size(127, 20);
            this.lblTipoEntrevista.TabIndex = 6;
            this.lblTipoEntrevista.Text = "Tipo Entrevista";
            // 
            // frmEntrevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(766, 431);
            this.Controls.Add(this.tbcEntrevista);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntrevista";
            this.Text = "Entrevista";
            this.Load += new System.EventHandler(this.frmEntrevista_Load);
            this.tbcEntrevista.ResumeLayout(false);
            this.tbpDatosRecluta.ResumeLayout(false);
            this.tbpDatosRecluta.PerformLayout();
            this.gbxDatosP1.ResumeLayout(false);
            this.gbxDatosP1.PerformLayout();
            this.gbxDatosP2.ResumeLayout(false);
            this.gbxDatosP2.PerformLayout();
            this.tbpDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.ResumeLayout(false);
            this.gbxDatosEntrevista.PerformLayout();
            this.gbxPunteos.ResumeLayout(false);
            this.gbxPunteos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEntrevista;
        private System.Windows.Forms.TabPage tbpDatosRecluta;
        private System.Windows.Forms.TabPage tbpDatosEntrevista;
        private System.Windows.Forms.GroupBox gbxDatosEntrevista;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.ComboBox cmbTipoEntrevista;
        private System.Windows.Forms.Label lblResultadoEntrevista;
        private System.Windows.Forms.Label lblTipoEntrevista;
        private System.Windows.Forms.Label lblIngreseIdRecluta;
        private System.Windows.Forms.TextBox txtIdBancoTalento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbPuestoTrabajo;
        private System.Windows.Forms.Label lblDepartamentoTrabajo;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnIngresoEntrevista;
        private System.Windows.Forms.ComboBox cmbDepartamentoTrabajo;
        private System.Windows.Forms.Button btnReclutas;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.TextBox txtPunteo;
        private System.Windows.Forms.Label lblPunteoEntrevista;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox gbxDatosP1;
        private System.Windows.Forms.GroupBox gbxDatosP2;
        private System.Windows.Forms.GroupBox gbxPunteos;
        private System.Windows.Forms.Label Punteo3;
        private System.Windows.Forms.Label Punteo2;
        private System.Windows.Forms.Label Punteo1;
        private System.Windows.Forms.Button btnAyuda;
    }
}