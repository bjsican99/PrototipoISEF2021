
namespace CapaVistaHRM.Billy.Mantenimiento
{
    partial class frmMantenimientoRecursos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdTipoRecurso = new System.Windows.Forms.TextBox();
            this.txtNombreTipoRecurso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.rbHabilitado = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvTipoRecursos = new System.Windows.Forms.DataGridView();
            this.navegador1 = new CapaVistaNavegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Del Recurso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion Del Recurso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(154, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // txtIdTipoRecurso
            // 
            this.txtIdTipoRecurso.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtIdTipoRecurso.Location = new System.Drawing.Point(211, 170);
            this.txtIdTipoRecurso.Name = "txtIdTipoRecurso";
            this.txtIdTipoRecurso.Size = new System.Drawing.Size(157, 23);
            this.txtIdTipoRecurso.TabIndex = 5;
            this.txtIdTipoRecurso.Tag = "pkIdTipoRecurso";
            // 
            // txtNombreTipoRecurso
            // 
            this.txtNombreTipoRecurso.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtNombreTipoRecurso.Location = new System.Drawing.Point(211, 221);
            this.txtNombreTipoRecurso.Name = "txtNombreTipoRecurso";
            this.txtNombreTipoRecurso.Size = new System.Drawing.Size(157, 23);
            this.txtNombreTipoRecurso.TabIndex = 6;
            this.txtNombreTipoRecurso.Tag = "nombreDeRecurso";
            this.txtNombreTipoRecurso.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.txtDescripcion.Location = new System.Drawing.Point(211, 272);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(157, 73);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Tag = "descripcionRecurso";
            // 
            // rbHabilitado
            // 
            this.rbHabilitado.AutoSize = true;
            this.rbHabilitado.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.rbHabilitado.ForeColor = System.Drawing.Color.White;
            this.rbHabilitado.Location = new System.Drawing.Point(211, 361);
            this.rbHabilitado.Name = "rbHabilitado";
            this.rbHabilitado.Size = new System.Drawing.Size(92, 21);
            this.rbHabilitado.TabIndex = 8;
            this.rbHabilitado.TabStop = true;
            this.rbHabilitado.Tag = "saltar";
            this.rbHabilitado.Text = "Habilitado";
            this.rbHabilitado.UseVisualStyleBackColor = true;
            this.rbHabilitado.CheckedChanged += new System.EventHandler(this.rbHabilitado_CheckedChanged);
            // 
            // rbDeshabilitado
            // 
            this.rbDeshabilitado.AutoSize = true;
            this.rbDeshabilitado.Font = new System.Drawing.Font("Rockwell", 10.2F);
            this.rbDeshabilitado.ForeColor = System.Drawing.Color.White;
            this.rbDeshabilitado.Location = new System.Drawing.Point(211, 388);
            this.rbDeshabilitado.Name = "rbDeshabilitado";
            this.rbDeshabilitado.Size = new System.Drawing.Size(114, 21);
            this.rbDeshabilitado.TabIndex = 9;
            this.rbDeshabilitado.TabStop = true;
            this.rbDeshabilitado.Tag = "saltar";
            this.rbDeshabilitado.Text = "Deshabilitado";
            this.rbDeshabilitado.UseVisualStyleBackColor = true;
            this.rbDeshabilitado.CheckedChanged += new System.EventHandler(this.rbDeshabilitado_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(61, 361);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(87, 20);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.Tag = "estadoRecurso";
            this.txtEstado.Visible = false;
            // 
            // dgvTipoRecursos
            // 
            this.dgvTipoRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoRecursos.Location = new System.Drawing.Point(419, 147);
            this.dgvTipoRecursos.Name = "dgvTipoRecursos";
            this.dgvTipoRecursos.RowHeadersWidth = 51;
            this.dgvTipoRecursos.Size = new System.Drawing.Size(648, 280);
            this.dgvTipoRecursos.TabIndex = 29;
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(8, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1059, 105);
            this.navegador1.TabIndex = 30;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_1);
            // 
            // frmMantenimientoRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1079, 468);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dgvTipoRecursos);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbDeshabilitado);
            this.Controls.Add(this.rbHabilitado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreTipoRecurso);
            this.Controls.Add(this.txtIdTipoRecurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMantenimientoRecursos";
            this.Text = "frmMantenimientoRecursos";
            this.Load += new System.EventHandler(this.frmMantenimientoRecursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoRecursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdTipoRecurso;
        private System.Windows.Forms.TextBox txtNombreTipoRecurso;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.RadioButton rbHabilitado;
        private System.Windows.Forms.RadioButton rbDeshabilitado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvTipoRecursos;
        private CapaVistaNavegador.Navegador navegador1;
    }
}