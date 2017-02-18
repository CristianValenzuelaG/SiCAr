namespace SiSCar.Vista
{
    partial class frmMainPropietario
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.ckbSatus = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pkPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(739, 26);
            this.txtBuscar.TabIndex = 6;
            // 
            // grDatos
            // 
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPropietario,
            this.pNombre,
            this.pDireccion,
            this.pCorreo,
            this.pIfe,
            this.pFoto});
            this.grDatos.Location = new System.Drawing.Point(12, 64);
            this.grDatos.Name = "grDatos";
            this.grDatos.Size = new System.Drawing.Size(783, 228);
            this.grDatos.TabIndex = 8;
            // 
            // ckbSatus
            // 
            this.ckbSatus.AutoSize = true;
            this.ckbSatus.Location = new System.Drawing.Point(720, 298);
            this.ckbSatus.Name = "ckbSatus";
            this.ckbSatus.Size = new System.Drawing.Size(75, 24);
            this.ckbSatus.TabIndex = 11;
            this.ckbSatus.Text = "Status";
            this.ckbSatus.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(720, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 328);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // pkPropietario
            // 
            this.pkPropietario.HeaderText = "Id";
            this.pkPropietario.Name = "pkPropietario";
            // 
            // pNombre
            // 
            this.pNombre.HeaderText = "Nombre";
            this.pNombre.Name = "pNombre";
            this.pNombre.Width = 150;
            // 
            // pDireccion
            // 
            this.pDireccion.HeaderText = "Direccion";
            this.pDireccion.Name = "pDireccion";
            this.pDireccion.Width = 150;
            // 
            // pCorreo
            // 
            this.pCorreo.HeaderText = "Correro";
            this.pCorreo.Name = "pCorreo";
            // 
            // pIfe
            // 
            this.pIfe.HeaderText = "Ife";
            this.pIfe.Name = "pIfe";
            // 
            // pFoto
            // 
            this.pFoto.HeaderText = "Foto";
            this.pFoto.Name = "pFoto";
            this.pFoto.Width = 140;
            // 
            // frmMainPropietario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 370);
            this.Controls.Add(this.ckbSatus);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainPropietario";
            this.Text = "frmMainPropietario";
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.CheckBox ckbSatus;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFoto;
    }
}