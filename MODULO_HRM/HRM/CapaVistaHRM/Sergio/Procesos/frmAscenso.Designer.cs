namespace CapaVistaHRM.Sergio.Procesos
{
    partial class frmAscenso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrevDepartamento = new System.Windows.Forms.TextBox();
            this.txtPrevPuesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNextDepartamento = new System.Windows.Forms.TextBox();
            this.txtNextPuesto = new System.Windows.Forms.TextBox();
            this.cmbNuevoDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbNuevoPuesto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRecluta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Codigo del Empleado";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(283, 45);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(143, 20);
            this.txtIdEmpleado.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(432, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(98, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(98, 137);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(238, 20);
            this.txtApellido.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrevDepartamento);
            this.groupBox1.Controls.Add(this.txtPrevPuesto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(362, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 232);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antiguo Cargo";
            // 
            // txtPrevDepartamento
            // 
            this.txtPrevDepartamento.Enabled = false;
            this.txtPrevDepartamento.Location = new System.Drawing.Point(18, 179);
            this.txtPrevDepartamento.Name = "txtPrevDepartamento";
            this.txtPrevDepartamento.Size = new System.Drawing.Size(176, 20);
            this.txtPrevDepartamento.TabIndex = 38;
            // 
            // txtPrevPuesto
            // 
            this.txtPrevPuesto.Enabled = false;
            this.txtPrevPuesto.Location = new System.Drawing.Point(18, 83);
            this.txtPrevPuesto.Name = "txtPrevPuesto";
            this.txtPrevPuesto.Size = new System.Drawing.Size(176, 20);
            this.txtPrevPuesto.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Puesto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNextDepartamento);
            this.groupBox2.Controls.Add(this.txtNextPuesto);
            this.groupBox2.Controls.Add(this.cmbNuevoDepartamento);
            this.groupBox2.Controls.Add(this.cmbNuevoPuesto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(568, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 232);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo Cargo";
            // 
            // txtNextDepartamento
            // 
            this.txtNextDepartamento.Location = new System.Drawing.Point(132, 153);
            this.txtNextDepartamento.Name = "txtNextDepartamento";
            this.txtNextDepartamento.Size = new System.Drawing.Size(60, 20);
            this.txtNextDepartamento.TabIndex = 38;
            this.txtNextDepartamento.Visible = false;
            // 
            // txtNextPuesto
            // 
            this.txtNextPuesto.Location = new System.Drawing.Point(132, 57);
            this.txtNextPuesto.Name = "txtNextPuesto";
            this.txtNextPuesto.Size = new System.Drawing.Size(60, 20);
            this.txtNextPuesto.TabIndex = 37;
            this.txtNextPuesto.Visible = false;
            // 
            // cmbNuevoDepartamento
            // 
            this.cmbNuevoDepartamento.FormattingEnabled = true;
            this.cmbNuevoDepartamento.Location = new System.Drawing.Point(21, 179);
            this.cmbNuevoDepartamento.Name = "cmbNuevoDepartamento";
            this.cmbNuevoDepartamento.Size = new System.Drawing.Size(171, 21);
            this.cmbNuevoDepartamento.TabIndex = 35;
            this.cmbNuevoDepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbNuevoDepartamento_SelectedIndexChanged);
            // 
            // cmbNuevoPuesto
            // 
            this.cmbNuevoPuesto.FormattingEnabled = true;
            this.cmbNuevoPuesto.Location = new System.Drawing.Point(21, 83);
            this.cmbNuevoPuesto.Name = "cmbNuevoPuesto";
            this.cmbNuevoPuesto.Size = new System.Drawing.Size(171, 21);
            this.cmbNuevoPuesto.TabIndex = 34;
            this.cmbNuevoPuesto.SelectedIndexChanged += new System.EventHandler(this.cmbNuevoPuesto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Puesto";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 36);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Guardar Ascenso";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRecluta
            // 
            this.txtRecluta.Location = new System.Drawing.Point(534, 47);
            this.txtRecluta.Name = "txtRecluta";
            this.txtRecluta.Size = new System.Drawing.Size(100, 20);
            this.txtRecluta.TabIndex = 32;
            this.txtRecluta.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Ver empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAscenso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(801, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRecluta);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmAscenso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAscenso";
            this.Load += new System.EventHandler(this.frmAscenso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbNuevoDepartamento;
        private System.Windows.Forms.ComboBox cmbNuevoPuesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNextDepartamento;
        private System.Windows.Forms.TextBox txtNextPuesto;
        private System.Windows.Forms.TextBox txtPrevDepartamento;
        private System.Windows.Forms.TextBox txtPrevPuesto;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRecluta;
        private System.Windows.Forms.Button button1;
    }
}