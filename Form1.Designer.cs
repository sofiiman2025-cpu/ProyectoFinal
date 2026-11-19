namespace ProyectoFianl
{
    partial class frmParcial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.optEgresoFiltro = new System.Windows.Forms.RadioButton();
            this.optIngresoFiltro = new System.Windows.Forms.RadioButton();
            this.btnBuscarMov = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.optEgreso = new System.Windows.Forms.RadioButton();
            this.optIngreso = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvMov = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMov)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnVerTodos);
            this.groupBox2.Controls.Add(this.optEgresoFiltro);
            this.groupBox2.Controls.Add(this.optIngresoFiltro);
            this.groupBox2.Controls.Add(this.btnBuscarMov);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 132);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(12, 84);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(171, 36);
            this.btnVerTodos.TabIndex = 10;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            // 
            // optEgresoFiltro
            // 
            this.optEgresoFiltro.AutoSize = true;
            this.optEgresoFiltro.Location = new System.Drawing.Point(78, 19);
            this.optEgresoFiltro.Name = "optEgresoFiltro";
            this.optEgresoFiltro.Size = new System.Drawing.Size(58, 17);
            this.optEgresoFiltro.TabIndex = 4;
            this.optEgresoFiltro.TabStop = true;
            this.optEgresoFiltro.Text = "Egreso";
            this.optEgresoFiltro.UseVisualStyleBackColor = true;
            // 
            // optIngresoFiltro
            // 
            this.optIngresoFiltro.AutoSize = true;
            this.optIngresoFiltro.Location = new System.Drawing.Point(12, 19);
            this.optIngresoFiltro.Name = "optIngresoFiltro";
            this.optIngresoFiltro.Size = new System.Drawing.Size(60, 17);
            this.optIngresoFiltro.TabIndex = 3;
            this.optIngresoFiltro.TabStop = true;
            this.optIngresoFiltro.Text = "Ingreso";
            this.optIngresoFiltro.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMov
            // 
            this.btnBuscarMov.Location = new System.Drawing.Point(11, 42);
            this.btnBuscarMov.Name = "btnBuscarMov";
            this.btnBuscarMov.Size = new System.Drawing.Size(171, 36);
            this.btnBuscarMov.TabIndex = 0;
            this.btnBuscarMov.Text = "Buscar por tipo";
            this.btnBuscarMov.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.optEgreso);
            this.groupBox1.Controls.Add(this.optIngreso);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 217);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar movimiento";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(13, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(13, 24);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(86, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // optEgreso
            // 
            this.optEgreso.AutoSize = true;
            this.optEgreso.Location = new System.Drawing.Point(13, 122);
            this.optEgreso.Name = "optEgreso";
            this.optEgreso.Size = new System.Drawing.Size(58, 17);
            this.optEgreso.TabIndex = 4;
            this.optEgreso.TabStop = true;
            this.optEgreso.Text = "Egreso";
            this.optEgreso.UseVisualStyleBackColor = true;
            // 
            // optIngreso
            // 
            this.optIngreso.AutoSize = true;
            this.optIngreso.Location = new System.Drawing.Point(13, 99);
            this.optIngreso.Name = "optIngreso";
            this.optIngreso.Size = new System.Drawing.Size(60, 17);
            this.optIngreso.TabIndex = 3;
            this.optIngreso.TabStop = true;
            this.optIngreso.Text = "Ingreso";
            this.optIngreso.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 45);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar movimiento";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvMov
            // 
            this.dgvMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMov.Location = new System.Drawing.Point(211, 12);
            this.dgvMov.Name = "dgvMov";
            this.dgvMov.Size = new System.Drawing.Size(498, 374);
            this.dgvMov.TabIndex = 14;
            // 
            // frmParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(726, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMov);
            this.Name = "frmParcial";
            this.Text = "Parcial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.RadioButton optEgresoFiltro;
        private System.Windows.Forms.RadioButton optIngresoFiltro;
        private System.Windows.Forms.Button btnBuscarMov;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optEgreso;
        private System.Windows.Forms.RadioButton optIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvMov;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMonto;
    }
}

