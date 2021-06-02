
namespace CapaVistaHRM.Jose.Procesos
{
    partial class frmNominaIndividual
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNomina = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNominaIndividual = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNomina = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbPercepciones = new System.Windows.Forms.ComboBox();
            this.txtCodigoNomina = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtCodigoPercepciones = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominaIndividual)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(347, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nomina Individual";
            // 
            // lblNomina
            // 
            this.lblNomina.AutoSize = true;
            this.lblNomina.ForeColor = System.Drawing.Color.White;
            this.lblNomina.Location = new System.Drawing.Point(38, 60);
            this.lblNomina.Name = "lblNomina";
            this.lblNomina.Size = new System.Drawing.Size(70, 20);
            this.lblNomina.TabIndex = 1;
            this.lblNomina.Text = "Nomina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Percepcion / Deduccion";
            // 
            // dgvNominaIndividual
            // 
            this.dgvNominaIndividual.AllowUserToAddRows = false;
            this.dgvNominaIndividual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNominaIndividual.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNominaIndividual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNominaIndividual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvNominaIndividual.Location = new System.Drawing.Point(42, 185);
            this.dgvNominaIndividual.Name = "dgvNominaIndividual";
            this.dgvNominaIndividual.ReadOnly = true;
            this.dgvNominaIndividual.RowHeadersWidth = 51;
            this.dgvNominaIndividual.RowTemplate.Height = 24;
            this.dgvNominaIndividual.Size = new System.Drawing.Size(933, 260);
            this.dgvNominaIndividual.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nomina";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 99;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo E.";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 107;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Empleado";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 118;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Codigo P / D";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 105;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Percepcion / Deduccion";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 208;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Valor";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 81;
            // 
            // cmbNomina
            // 
            this.cmbNomina.FormattingEnabled = true;
            this.cmbNomina.Location = new System.Drawing.Point(167, 52);
            this.cmbNomina.Name = "cmbNomina";
            this.cmbNomina.Size = new System.Drawing.Size(349, 28);
            this.cmbNomina.TabIndex = 5;
            this.cmbNomina.SelectedIndexChanged += new System.EventHandler(this.cmbNomina_SelectedIndexChanged);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(167, 94);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(349, 28);
            this.cmbEmpleado.TabIndex = 6;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // cmbPercepciones
            // 
            this.cmbPercepciones.FormattingEnabled = true;
            this.cmbPercepciones.Location = new System.Drawing.Point(243, 138);
            this.cmbPercepciones.Name = "cmbPercepciones";
            this.cmbPercepciones.Size = new System.Drawing.Size(273, 28);
            this.cmbPercepciones.TabIndex = 7;
            this.cmbPercepciones.SelectedIndexChanged += new System.EventHandler(this.cmbPercepciones_SelectedIndexChanged);
            // 
            // txtCodigoNomina
            // 
            this.txtCodigoNomina.Location = new System.Drawing.Point(12, 12);
            this.txtCodigoNomina.Name = "txtCodigoNomina";
            this.txtCodigoNomina.Size = new System.Drawing.Size(46, 27);
            this.txtCodigoNomina.TabIndex = 8;
            this.txtCodigoNomina.Visible = false;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(64, 12);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(46, 27);
            this.txtCodigoEmpleado.TabIndex = 9;
            this.txtCodigoEmpleado.Visible = false;
            // 
            // txtCodigoPercepciones
            // 
            this.txtCodigoPercepciones.Location = new System.Drawing.Point(116, 12);
            this.txtCodigoPercepciones.Name = "txtCodigoPercepciones";
            this.txtCodigoPercepciones.Size = new System.Drawing.Size(46, 27);
            this.txtCodigoPercepciones.TabIndex = 10;
            this.txtCodigoPercepciones.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(548, 138);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 28);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.Location = new System.Drawing.Point(681, 138);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(116, 28);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(818, 137);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 28);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(617, 57);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(126, 27);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(617, 99);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(126, 27);
            this.txtValor.TabIndex = 15;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(531, 60);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(80, 20);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(544, 105);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(52, 20);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::CapaVistaHRM.Properties.Resources.informacion;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.ForeColor = System.Drawing.Color.Black;
            this.btnAyuda.Location = new System.Drawing.Point(914, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(61, 52);
            this.btnAyuda.TabIndex = 18;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // frmNominaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(995, 460);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCodigoPercepciones);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.txtCodigoNomina);
            this.Controls.Add(this.cmbPercepciones);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.cmbNomina);
            this.Controls.Add(this.dgvNominaIndividual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomina);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNominaIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina Individual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNominaIndividual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNomina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNominaIndividual;
        private System.Windows.Forms.ComboBox cmbNomina;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbPercepciones;
        private System.Windows.Forms.TextBox txtCodigoNomina;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoPercepciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAyuda;
    }
}