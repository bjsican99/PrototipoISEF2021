
namespace CapaVistaHRM.Jose.Informes
{
    partial class frmReportes
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rdGeneral = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFechas = new System.Windows.Forms.RadioButton();
            this.rdEmpleado = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbNomina = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblNomina = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtCodigoNomina = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(38, 205);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(662, 349);
            this.dgvDatos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(290, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(239, 27);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Reportes de Nomina";
            // 
            // rdGeneral
            // 
            this.rdGeneral.AutoSize = true;
            this.rdGeneral.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdGeneral.Location = new System.Drawing.Point(23, 26);
            this.rdGeneral.Name = "rdGeneral";
            this.rdGeneral.Size = new System.Drawing.Size(95, 24);
            this.rdGeneral.TabIndex = 2;
            this.rdGeneral.TabStop = true;
            this.rdGeneral.Text = "General";
            this.rdGeneral.UseVisualStyleBackColor = true;
            this.rdGeneral.CheckedChanged += new System.EventHandler(this.rdGeneral_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFechas);
            this.groupBox1.Controls.Add(this.rdEmpleado);
            this.groupBox1.Controls.Add(this.rdGeneral);
            this.groupBox1.Location = new System.Drawing.Point(204, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdFechas
            // 
            this.rdFechas.AutoSize = true;
            this.rdFechas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdFechas.Location = new System.Drawing.Point(320, 26);
            this.rdFechas.Name = "rdFechas";
            this.rdFechas.Size = new System.Drawing.Size(116, 24);
            this.rdFechas.TabIndex = 4;
            this.rdFechas.TabStop = true;
            this.rdFechas.Text = "Por Fechas";
            this.rdFechas.UseVisualStyleBackColor = true;
            this.rdFechas.CheckedChanged += new System.EventHandler(this.rdFechas_CheckedChanged);
            // 
            // rdEmpleado
            // 
            this.rdEmpleado.AutoSize = true;
            this.rdEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdEmpleado.Location = new System.Drawing.Point(151, 26);
            this.rdEmpleado.Name = "rdEmpleado";
            this.rdEmpleado.Size = new System.Drawing.Size(141, 24);
            this.rdEmpleado.TabIndex = 3;
            this.rdEmpleado.TabStop = true;
            this.rdEmpleado.Text = "Por Empleado";
            this.rdEmpleado.UseVisualStyleBackColor = true;
            this.rdEmpleado.CheckedChanged += new System.EventHandler(this.rdEmpleado_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(712, 205);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 55);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(712, 266);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 55);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbNomina
            // 
            this.cmbNomina.FormattingEnabled = true;
            this.cmbNomina.Location = new System.Drawing.Point(120, 130);
            this.cmbNomina.Name = "cmbNomina";
            this.cmbNomina.Size = new System.Drawing.Size(270, 28);
            this.cmbNomina.TabIndex = 6;
            this.cmbNomina.SelectedIndexChanged += new System.EventHandler(this.cmbNomina_SelectedIndexChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(504, 132);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(372, 28);
            this.cmbEmpleado.TabIndex = 7;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNomina.Location = new System.Drawing.Point(34, 133);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(70, 20);
            this.lblNomina.TabIndex = 8;
            this.lblNomina.Text = "Nomina";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpleado.Location = new System.Drawing.Point(402, 133);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(89, 20);
            this.lblEmpleado.TabIndex = 9;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtCodigoNomina
            // 
            this.txtCodigoNomina.Location = new System.Drawing.Point(563, 20);
            this.txtCodigoNomina.Name = "txtCodigoNomina";
            this.txtCodigoNomina.Size = new System.Drawing.Size(75, 27);
            this.txtCodigoNomina.TabIndex = 10;
            this.txtCodigoNomina.Visible = false;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(644, 19);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(75, 27);
            this.txtCodigoEmpleado.TabIndex = 11;
            this.txtCodigoEmpleado.Visible = false;
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(120, 172);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(325, 27);
            this.dtInicio.TabIndex = 12;
            // 
            // dtFin
            // 
            this.dtFin.Location = new System.Drawing.Point(504, 172);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(372, 27);
            this.dtFin.TabIndex = 13;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInicio.Location = new System.Drawing.Point(34, 179);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(53, 20);
            this.lblInicio.TabIndex = 14;
            this.lblInicio.Text = "Inicio";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFin.Location = new System.Drawing.Point(465, 180);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(33, 20);
            this.lblFin.TabIndex = 15;
            this.lblFin.Text = "Fin";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(896, 582);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.txtCodigoNomina);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblNomina);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbNomina);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvDatos);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rdGeneral;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdFechas;
        private System.Windows.Forms.RadioButton rdEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbNomina;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtCodigoNomina;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
    }
}