
namespace CapaVistaHRM.Jose.Informes
{
    partial class Bitacoria
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
            this.txtIp = new System.Windows.Forms.TextBox();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.rdLogeo = new System.Windows.Forms.RadioButton();
            this.rdActualizacion = new System.Windows.Forms.RadioButton();
            this.rdInsercion = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.rdVarios = new System.Windows.Forms.RadioButton();
            this.rdIp = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdUsuario = new System.Windows.Forms.RadioButton();
            this.rdAplicacion = new System.Windows.Forms.RadioButton();
            this.rdFecha = new System.Windows.Forms.RadioButton();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.cmbCodigoUsuario = new System.Windows.Forms.ComboBox();
            this.cmbCodigoAplicacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.Location = new System.Drawing.Point(201, 327);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(341, 27);
            this.txtIp.TabIndex = 109;
            this.txtIp.Visible = false;
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBitacora.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(105, 414);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersWidth = 51;
            this.dgvBitacora.RowTemplate.Height = 24;
            this.dgvBitacora.Size = new System.Drawing.Size(891, 305);
            this.dgvBitacora.TabIndex = 108;
            // 
            // rdLogeo
            // 
            this.rdLogeo.AutoSize = true;
            this.rdLogeo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLogeo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdLogeo.Location = new System.Drawing.Point(493, 278);
            this.rdLogeo.Name = "rdLogeo";
            this.rdLogeo.Size = new System.Drawing.Size(90, 24);
            this.rdLogeo.TabIndex = 107;
            this.rdLogeo.TabStop = true;
            this.rdLogeo.Text = "Ingreso";
            this.rdLogeo.UseVisualStyleBackColor = true;
            this.rdLogeo.Visible = false;
            // 
            // rdActualizacion
            // 
            this.rdActualizacion.AutoSize = true;
            this.rdActualizacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActualizacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdActualizacion.Location = new System.Drawing.Point(333, 278);
            this.rdActualizacion.Name = "rdActualizacion";
            this.rdActualizacion.Size = new System.Drawing.Size(154, 24);
            this.rdActualizacion.TabIndex = 106;
            this.rdActualizacion.TabStop = true;
            this.rdActualizacion.Text = "Actualizaciones";
            this.rdActualizacion.UseVisualStyleBackColor = true;
            this.rdActualizacion.Visible = false;
            // 
            // rdInsercion
            // 
            this.rdInsercion.AutoSize = true;
            this.rdInsercion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInsercion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdInsercion.Location = new System.Drawing.Point(201, 278);
            this.rdInsercion.Name = "rdInsercion";
            this.rdInsercion.Size = new System.Drawing.Size(122, 24);
            this.rdInsercion.TabIndex = 105;
            this.rdInsercion.TabStop = true;
            this.rdInsercion.Text = "Inserciones";
            this.rdInsercion.UseVisualStyleBackColor = true;
            this.rdInsercion.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(869, 328);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 61);
            this.btnImprimir.TabIndex = 104;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(201, 81);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(243, 28);
            this.cmbUsuario.TabIndex = 95;
            this.cmbUsuario.Visible = false;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(719, 328);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 61);
            this.btnLimpiar.TabIndex = 103;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd-MM-yyyy HH:MM:ss";
            this.dtpFechaFinal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Location = new System.Drawing.Point(540, 223);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(323, 27);
            this.dtpFechaFinal.TabIndex = 100;
            this.dtpFechaFinal.Visible = false;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(561, 328);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 61);
            this.btnConsultar.TabIndex = 102;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.rdVarios);
            this.gbFiltros.Controls.Add(this.rdIp);
            this.gbFiltros.Controls.Add(this.radioButton2);
            this.gbFiltros.Controls.Add(this.radioButton1);
            this.gbFiltros.Controls.Add(this.rdUsuario);
            this.gbFiltros.Controls.Add(this.rdAplicacion);
            this.gbFiltros.Controls.Add(this.rdFecha);
            this.gbFiltros.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbFiltros.Location = new System.Drawing.Point(24, 38);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(171, 356);
            this.gbFiltros.TabIndex = 101;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtrar Por:";
            // 
            // rdVarios
            // 
            this.rdVarios.AutoSize = true;
            this.rdVarios.Location = new System.Drawing.Point(27, 327);
            this.rdVarios.Name = "rdVarios";
            this.rdVarios.Size = new System.Drawing.Size(81, 24);
            this.rdVarios.TabIndex = 93;
            this.rdVarios.TabStop = true;
            this.rdVarios.Text = "Varios";
            this.rdVarios.UseVisualStyleBackColor = true;
            this.rdVarios.CheckedChanged += new System.EventHandler(this.rdVarios_CheckedChanged);
            // 
            // rdIp
            // 
            this.rdIp.AutoSize = true;
            this.rdIp.Location = new System.Drawing.Point(27, 287);
            this.rdIp.Name = "rdIp";
            this.rdIp.Size = new System.Drawing.Size(45, 24);
            this.rdIp.TabIndex = 93;
            this.rdIp.TabStop = true;
            this.rdIp.Text = "IP";
            this.rdIp.UseVisualStyleBackColor = true;
            this.rdIp.CheckedChanged += new System.EventHandler(this.rdIp_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 234);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 24);
            this.radioButton2.TabIndex = 89;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Acción";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(24, 143);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "General";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdUsuario
            // 
            this.rdUsuario.AutoSize = true;
            this.rdUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdUsuario.Location = new System.Drawing.Point(27, 43);
            this.rdUsuario.Name = "rdUsuario";
            this.rdUsuario.Size = new System.Drawing.Size(91, 24);
            this.rdUsuario.TabIndex = 3;
            this.rdUsuario.TabStop = true;
            this.rdUsuario.Text = "Usuario";
            this.rdUsuario.UseVisualStyleBackColor = true;
            this.rdUsuario.CheckedChanged += new System.EventHandler(this.rdUsuario_CheckedChanged);
            // 
            // rdAplicacion
            // 
            this.rdAplicacion.AutoSize = true;
            this.rdAplicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdAplicacion.Location = new System.Drawing.Point(27, 91);
            this.rdAplicacion.Name = "rdAplicacion";
            this.rdAplicacion.Size = new System.Drawing.Size(114, 24);
            this.rdAplicacion.TabIndex = 4;
            this.rdAplicacion.TabStop = true;
            this.rdAplicacion.Text = "Aplicación";
            this.rdAplicacion.UseVisualStyleBackColor = true;
            this.rdAplicacion.CheckedChanged += new System.EventHandler(this.rdAplicacion_CheckedChanged);
            // 
            // rdFecha
            // 
            this.rdFecha.AutoSize = true;
            this.rdFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdFecha.Location = new System.Drawing.Point(27, 188);
            this.rdFecha.Name = "rdFecha";
            this.rdFecha.Size = new System.Drawing.Size(77, 24);
            this.rdFecha.TabIndex = 9;
            this.rdFecha.TabStop = true;
            this.rdFecha.Text = "Fecha";
            this.rdFecha.UseVisualStyleBackColor = true;
            this.rdFecha.CheckedChanged += new System.EventHandler(this.rdFecha_CheckedChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd-MM-yyyy HH:MM:ss";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(201, 223);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(333, 27);
            this.dtpFechaInicio.TabIndex = 99;
            this.dtpFechaInicio.Visible = false;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 68);
            this.label1.TabIndex = 94;
            this.label1.Text = "BITACORA";
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAplicacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Location = new System.Drawing.Point(201, 129);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(243, 28);
            this.cmbAplicacion.TabIndex = 97;
            this.cmbAplicacion.Visible = false;
            this.cmbAplicacion.SelectedIndexChanged += new System.EventHandler(this.cmbAplicacion_SelectedIndexChanged);
            // 
            // cmbCodigoUsuario
            // 
            this.cmbCodigoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoUsuario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoUsuario.FormattingEnabled = true;
            this.cmbCodigoUsuario.Location = new System.Drawing.Point(454, 81);
            this.cmbCodigoUsuario.Name = "cmbCodigoUsuario";
            this.cmbCodigoUsuario.Size = new System.Drawing.Size(80, 28);
            this.cmbCodigoUsuario.TabIndex = 96;
            this.cmbCodigoUsuario.Visible = false;
            this.cmbCodigoUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoUsuario_SelectedIndexChanged);
            // 
            // cmbCodigoAplicacion
            // 
            this.cmbCodigoAplicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoAplicacion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoAplicacion.FormattingEnabled = true;
            this.cmbCodigoAplicacion.Location = new System.Drawing.Point(454, 129);
            this.cmbCodigoAplicacion.Name = "cmbCodigoAplicacion";
            this.cmbCodigoAplicacion.Size = new System.Drawing.Size(80, 28);
            this.cmbCodigoAplicacion.TabIndex = 98;
            this.cmbCodigoAplicacion.Visible = false;
            // 
            // Bitacoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1071, 731);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.rdLogeo);
            this.Controls.Add(this.rdActualizacion);
            this.Controls.Add(this.rdInsercion);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAplicacion);
            this.Controls.Add(this.cmbCodigoUsuario);
            this.Controls.Add(this.cmbCodigoAplicacion);
            this.MaximizeBox = false;
            this.Name = "Bitacoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacoria";
            this.Load += new System.EventHandler(this.Bitacoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.RadioButton rdLogeo;
        private System.Windows.Forms.RadioButton rdActualizacion;
        private System.Windows.Forms.RadioButton rdInsercion;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.RadioButton rdVarios;
        private System.Windows.Forms.RadioButton rdIp;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdUsuario;
        private System.Windows.Forms.RadioButton rdAplicacion;
        private System.Windows.Forms.RadioButton rdFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.ComboBox cmbCodigoUsuario;
        private System.Windows.Forms.ComboBox cmbCodigoAplicacion;
    }
}