namespace SiSCar.Vista
{
    partial class frmComprador
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
            this.grbComprador = new System.Windows.Forms.GroupBox();
            this.grbCarro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnBuscaPropie = new System.Windows.Forms.Button();
            this.btnBuscarCar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.grbComprador.SuspendLayout();
            this.grbCarro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbComprador
            // 
            this.grbComprador.Controls.Add(this.btnBuscaPropie);
            this.grbComprador.Controls.Add(this.label3);
            this.grbComprador.Controls.Add(this.txtCiudad);
            this.grbComprador.Controls.Add(this.txtDireccion);
            this.grbComprador.Controls.Add(this.label2);
            this.grbComprador.Controls.Add(this.txtNombre);
            this.grbComprador.Controls.Add(this.label1);
            this.grbComprador.Location = new System.Drawing.Point(12, 12);
            this.grbComprador.Name = "grbComprador";
            this.grbComprador.Size = new System.Drawing.Size(529, 186);
            this.grbComprador.TabIndex = 0;
            this.grbComprador.TabStop = false;
            this.grbComprador.Text = "Comprador";
            // 
            // grbCarro
            // 
            this.grbCarro.Controls.Add(this.label4);
            this.grbCarro.Controls.Add(this.txtColor);
            this.grbCarro.Controls.Add(this.btnBuscarCar);
            this.grbCarro.Controls.Add(this.txtModelo);
            this.grbCarro.Controls.Add(this.label6);
            this.grbCarro.Controls.Add(this.label5);
            this.grbCarro.Controls.Add(this.txtMarca);
            this.grbCarro.Location = new System.Drawing.Point(12, 204);
            this.grbCarro.Name = "grbCarro";
            this.grbCarro.Size = new System.Drawing.Size(529, 192);
            this.grbCarro.TabIndex = 1;
            this.grbCarro.TabStop = false;
            this.grbCarro.Text = "Carro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(312, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(6, 149);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(312, 26);
            this.txtCiudad.TabIndex = 4;
            // 
            // btnBuscaPropie
            // 
            this.btnBuscaPropie.Location = new System.Drawing.Point(448, 25);
            this.btnBuscaPropie.Name = "btnBuscaPropie";
            this.btnBuscaPropie.Size = new System.Drawing.Size(75, 31);
            this.btnBuscaPropie.TabIndex = 6;
            this.btnBuscaPropie.Text = "Buscar";
            this.btnBuscaPropie.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCar
            // 
            this.btnBuscarCar.Location = new System.Drawing.Point(448, 25);
            this.btnBuscarCar.Name = "btnBuscarCar";
            this.btnBuscarCar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscarCar.TabIndex = 7;
            this.btnBuscarCar.Text = "Buscar";
            this.btnBuscarCar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(6, 149);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(312, 26);
            this.txtColor.TabIndex = 11;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(6, 97);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(312, 26);
            this.txtModelo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 45);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(312, 26);
            this.txtMarca.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Marca";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(460, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(379, 415);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 31);
            this.btnPagar.TabIndex = 14;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // frmComprador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 458);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbCarro);
            this.Controls.Add(this.grbComprador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmComprador";
            this.Text = "frmComprador";
            this.grbComprador.ResumeLayout(false);
            this.grbComprador.PerformLayout();
            this.grbCarro.ResumeLayout(false);
            this.grbCarro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbComprador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbCarro;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnBuscaPropie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnBuscarCar;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
    }
}