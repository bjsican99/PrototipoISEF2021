namespace CapaVistaHRM.Manuel.Procesos
{
    partial class frmMostrarEmpleado
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
            this.dgvMostrarEmpleados = new System.Windows.Forms.DataGridView();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.pnlDatosFiltro = new System.Windows.Forms.Panel();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.gbxFiltrado = new System.Windows.Forms.GroupBox();
            this.rbtnFiltradoDepto = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoPuesto = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoApellidos = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoNombres = new System.Windows.Forms.RadioButton();
            this.rbtnFiltradoId = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarEmpleados)).BeginInit();
            this.pnlDatosFiltro.SuspendLayout();
            this.gbxFiltrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrarEmpleados
            // 
            this.dgvMostrarEmpleados.AllowUserToAddRows = false;
            this.dgvMostrarEmpleados.AllowUserToDeleteRows = false;
            this.dgvMostrarEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMostrarEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMostrarEmpleados.Location = new System.Drawing.Point(0, 167);
            this.dgvMostrarEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMostrarEmpleados.Name = "dgvMostrarEmpleados";
            this.dgvMostrarEmpleados.RowHeadersVisible = false;
            this.dgvMostrarEmpleados.RowHeadersWidth = 51;
            this.dgvMostrarEmpleados.RowTemplate.Height = 24;
            this.dgvMostrarEmpleados.Size = new System.Drawing.Size(800, 288);
            this.dgvMostrarEmpleados.TabIndex = 0;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmpleados.Location = new System.Drawing.Point(356, 21);
            this.lblEmpleados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(109, 21);
            this.lblEmpleados.TabIndex = 3;
            this.lblEmpleados.Text = "Empleados";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Enabled = false;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(169, 74);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(96, 23);
            this.txtPrimerNombre.TabIndex = 5;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPrimerNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrimerNombre_KeyUp);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(335, 74);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(96, 23);
            this.txtPrimerApellido.TabIndex = 6;
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPrimerApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrimerApellido_KeyUp);
            // 
            // txtPuesto
            // 
            this.txtPuesto.Enabled = false;
            this.txtPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuesto.Location = new System.Drawing.Point(493, 74);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(96, 23);
            this.txtPuesto.TabIndex = 7;
            this.txtPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtPuesto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPuesto_KeyUp);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(656, 74);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(96, 23);
            this.txtDepartamento.TabIndex = 8;
            this.txtDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcLetra);
            this.txtDepartamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDepartamento_KeyUp);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmpleado.Location = new System.Drawing.Point(20, 74);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(96, 23);
            this.txtIdEmpleado.TabIndex = 9;
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.funcNumero);
            this.txtIdEmpleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIdEmpleado_KeyUp);
            // 
            // pnlDatosFiltro
            // 
            this.pnlDatosFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.pnlDatosFiltro.Controls.Add(this.btnMostrarTodo);
            this.pnlDatosFiltro.Controls.Add(this.gbxFiltrado);
            this.pnlDatosFiltro.Controls.Add(this.lblEmpleados);
            this.pnlDatosFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDatosFiltro.Name = "pnlDatosFiltro";
            this.pnlDatosFiltro.Size = new System.Drawing.Size(800, 167);
            this.pnlDatosFiltro.TabIndex = 10;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(657, 9);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(138, 50);
            this.btnMostrarTodo.TabIndex = 11;
            this.btnMostrarTodo.Text = "Mostrar Todos los Datos";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // gbxFiltrado
            // 
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoDepto);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoPuesto);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoApellidos);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoNombres);
            this.gbxFiltrado.Controls.Add(this.rbtnFiltradoId);
            this.gbxFiltrado.Controls.Add(this.txtIdEmpleado);
            this.gbxFiltrado.Controls.Add(this.txtPrimerNombre);
            this.gbxFiltrado.Controls.Add(this.txtDepartamento);
            this.gbxFiltrado.Controls.Add(this.txtPrimerApellido);
            this.gbxFiltrado.Controls.Add(this.txtPuesto);
            this.gbxFiltrado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxFiltrado.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltrado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxFiltrado.Location = new System.Drawing.Point(0, 56);
            this.gbxFiltrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxFiltrado.Name = "gbxFiltrado";
            this.gbxFiltrado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxFiltrado.Size = new System.Drawing.Size(800, 111);
            this.gbxFiltrado.TabIndex = 10;
            this.gbxFiltrado.TabStop = false;
            this.gbxFiltrado.Text = "Filtrado De Datos";
            // 
            // rbtnFiltradoDepto
            // 
            this.rbtnFiltradoDepto.AutoSize = true;
            this.rbtnFiltradoDepto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoDepto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFiltradoDepto.Location = new System.Drawing.Point(637, 41);
            this.rbtnFiltradoDepto.Name = "rbtnFiltradoDepto";
            this.rbtnFiltradoDepto.Size = new System.Drawing.Size(143, 21);
            this.rbtnFiltradoDepto.TabIndex = 14;
            this.rbtnFiltradoDepto.TabStop = true;
            this.rbtnFiltradoDepto.Text = "Por Departamento";
            this.rbtnFiltradoDepto.UseVisualStyleBackColor = true;
            this.rbtnFiltradoDepto.CheckedChanged += new System.EventHandler(this.rbtnFiltradoDepto_CheckedChanged);
            // 
            // rbtnFiltradoPuesto
            // 
            this.rbtnFiltradoPuesto.AutoSize = true;
            this.rbtnFiltradoPuesto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFiltradoPuesto.Location = new System.Drawing.Point(493, 41);
            this.rbtnFiltradoPuesto.Name = "rbtnFiltradoPuesto";
            this.rbtnFiltradoPuesto.Size = new System.Drawing.Size(94, 21);
            this.rbtnFiltradoPuesto.TabIndex = 13;
            this.rbtnFiltradoPuesto.TabStop = true;
            this.rbtnFiltradoPuesto.Text = "Por Puesto";
            this.rbtnFiltradoPuesto.UseVisualStyleBackColor = true;
            this.rbtnFiltradoPuesto.CheckedChanged += new System.EventHandler(this.rbtnFiltradoPuesto_CheckedChanged);
            // 
            // rbtnFiltradoApellidos
            // 
            this.rbtnFiltradoApellidos.AutoSize = true;
            this.rbtnFiltradoApellidos.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFiltradoApellidos.Location = new System.Drawing.Point(335, 41);
            this.rbtnFiltradoApellidos.Name = "rbtnFiltradoApellidos";
            this.rbtnFiltradoApellidos.Size = new System.Drawing.Size(114, 21);
            this.rbtnFiltradoApellidos.TabIndex = 12;
            this.rbtnFiltradoApellidos.TabStop = true;
            this.rbtnFiltradoApellidos.Text = "Por Apellidos";
            this.rbtnFiltradoApellidos.UseVisualStyleBackColor = true;
            this.rbtnFiltradoApellidos.CheckedChanged += new System.EventHandler(this.rbtnFiltradoApellido1_CheckedChanged);
            // 
            // rbtnFiltradoNombres
            // 
            this.rbtnFiltradoNombres.AutoSize = true;
            this.rbtnFiltradoNombres.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoNombres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFiltradoNombres.Location = new System.Drawing.Point(158, 41);
            this.rbtnFiltradoNombres.Name = "rbtnFiltradoNombres";
            this.rbtnFiltradoNombres.Size = new System.Drawing.Size(111, 21);
            this.rbtnFiltradoNombres.TabIndex = 11;
            this.rbtnFiltradoNombres.TabStop = true;
            this.rbtnFiltradoNombres.Text = "Por Nombres";
            this.rbtnFiltradoNombres.UseVisualStyleBackColor = true;
            this.rbtnFiltradoNombres.CheckedChanged += new System.EventHandler(this.FiltradoNombre1_CheckedChanged);
            // 
            // rbtnFiltradoId
            // 
            this.rbtnFiltradoId.AutoSize = true;
            this.rbtnFiltradoId.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFiltradoId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnFiltradoId.Location = new System.Drawing.Point(38, 41);
            this.rbtnFiltradoId.Name = "rbtnFiltradoId";
            this.rbtnFiltradoId.Size = new System.Drawing.Size(65, 21);
            this.rbtnFiltradoId.TabIndex = 10;
            this.rbtnFiltradoId.TabStop = true;
            this.rbtnFiltradoId.Text = "Por Id";
            this.rbtnFiltradoId.UseVisualStyleBackColor = true;
            this.rbtnFiltradoId.CheckedChanged += new System.EventHandler(this.rbtnFiltradoId_CheckedChanged);
            // 
            // frmMostrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.pnlDatosFiltro);
            this.Controls.Add(this.dgvMostrarEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarEmpleado";
            this.Text = "322 - Empleados";
            this.Load += new System.EventHandler(this.frmMostrarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarEmpleados)).EndInit();
            this.pnlDatosFiltro.ResumeLayout(false);
            this.pnlDatosFiltro.PerformLayout();
            this.gbxFiltrado.ResumeLayout(false);
            this.gbxFiltrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarEmpleados;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Panel pnlDatosFiltro;
        private System.Windows.Forms.GroupBox gbxFiltrado;
        private System.Windows.Forms.RadioButton rbtnFiltradoDepto;
        private System.Windows.Forms.RadioButton rbtnFiltradoPuesto;
        private System.Windows.Forms.RadioButton rbtnFiltradoApellidos;
        private System.Windows.Forms.RadioButton rbtnFiltradoNombres;
        private System.Windows.Forms.RadioButton rbtnFiltradoId;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}