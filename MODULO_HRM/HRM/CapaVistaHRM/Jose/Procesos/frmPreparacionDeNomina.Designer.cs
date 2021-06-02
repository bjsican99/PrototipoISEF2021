
namespace CapaVistaHRM.Jose.Procesos
{
    partial class frmPreparacionDeNomina
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
            this.lblPercepcionDeduccion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dgvPercepciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPercepcionDeduccion = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercepciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(143, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Preparacion de Nomina";
            // 
            // lblPercepcionDeduccion
            // 
            this.lblPercepcionDeduccion.AutoSize = true;
            this.lblPercepcionDeduccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPercepcionDeduccion.Location = new System.Drawing.Point(13, 62);
            this.lblPercepcionDeduccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercepcionDeduccion.Name = "lblPercepcionDeduccion";
            this.lblPercepcionDeduccion.Size = new System.Drawing.Size(48, 20);
            this.lblPercepcionDeduccion.TabIndex = 1;
            this.lblPercepcionDeduccion.Text = "TIPO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(383, 193);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(177, 53);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(383, 315);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(177, 50);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dgvPercepciones
            // 
            this.dgvPercepciones.AllowUserToAddRows = false;
            this.dgvPercepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPercepciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPercepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPercepciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPercepciones.Location = new System.Drawing.Point(17, 132);
            this.dgvPercepciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPercepciones.Name = "dgvPercepciones";
            this.dgvPercepciones.ReadOnly = true;
            this.dgvPercepciones.RowHeadersWidth = 51;
            this.dgvPercepciones.RowTemplate.Height = 24;
            this.dgvPercepciones.Size = new System.Drawing.Size(358, 288);
            this.dgvPercepciones.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Percepcion / Deduccion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 208;
            // 
            // cmbPercepcionDeduccion
            // 
            this.cmbPercepcionDeduccion.FormattingEnabled = true;
            this.cmbPercepcionDeduccion.Location = new System.Drawing.Point(17, 90);
            this.cmbPercepcionDeduccion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPercepcionDeduccion.Name = "cmbPercepcionDeduccion";
            this.cmbPercepcionDeduccion.Size = new System.Drawing.Size(543, 28);
            this.cmbPercepcionDeduccion.TabIndex = 5;
            this.cmbPercepcionDeduccion.SelectedIndexChanged += new System.EventHandler(this.cmbPercepcionDeduccion_SelectedIndexChanged);
            this.cmbPercepcionDeduccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPercepcionDeduccion_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(17, 26);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(61, 27);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.Visible = false;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(383, 254);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(177, 53);
            this.btnQuitar.TabIndex = 7;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(383, 373);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(177, 50);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::CapaVistaHRM.Properties.Resources.informacion;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.Location = new System.Drawing.Point(499, 13);
            this.btnAyuda.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(61, 52);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(383, 132);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(177, 53);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmPreparacionDeNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(57)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(581, 446);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbPercepcionDeduccion);
            this.Controls.Add(this.dgvPercepciones);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPercepcionDeduccion);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPreparacionDeNomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preparacion de nomina";
            this.Load += new System.EventHandler(this.frmPreparacionDeNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPercepciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPercepcionDeduccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgvPercepciones;
        private System.Windows.Forms.ComboBox cmbPercepcionDeduccion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}