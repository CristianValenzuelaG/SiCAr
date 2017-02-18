namespace SiSCar.Vista
{
    partial class frmMainUsuario
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grDatos = new System.Windows.Forms.DataGridView();
            this.sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbSatus = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 392);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 392);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(189, 392);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 30);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(488, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(551, 26);
            this.txtBuscar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // grDatos
            // 
            this.grDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sId,
            this.sEmail,
            this.sStatus});
            this.grDatos.Location = new System.Drawing.Point(12, 64);
            this.grDatos.Name = "grDatos";
            this.grDatos.Size = new System.Drawing.Size(551, 292);
            this.grDatos.TabIndex = 6;
            // 
            // sId
            // 
            this.sId.HeaderText = "Id";
            this.sId.Name = "sId";
            // 
            // sEmail
            // 
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.Width = 300;
            // 
            // sStatus
            // 
            this.sStatus.HeaderText = "Status";
            this.sStatus.Name = "sStatus";
            // 
            // ckbSatus
            // 
            this.ckbSatus.AutoSize = true;
            this.ckbSatus.Location = new System.Drawing.Point(488, 362);
            this.ckbSatus.Name = "ckbSatus";
            this.ckbSatus.Size = new System.Drawing.Size(75, 24);
            this.ckbSatus.TabIndex = 7;
            this.ckbSatus.Text = "Status";
            this.ckbSatus.UseVisualStyleBackColor = true;
            // 
            // frmMainUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 434);
            this.Controls.Add(this.ckbSatus);
            this.Controls.Add(this.grDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMainUsuario";
            this.Text = "frmMainUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.grDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStatus;
        private System.Windows.Forms.CheckBox ckbSatus;
    }
}