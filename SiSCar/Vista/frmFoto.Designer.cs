﻿namespace SiSCar.Vista
{
    partial class frmFoto
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
            this.EspacioCamara = new System.Windows.Forms.PictureBox();
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picMostrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // EspacioCamara
            // 
            this.EspacioCamara.BackColor = System.Drawing.SystemColors.Control;
            this.EspacioCamara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EspacioCamara.Location = new System.Drawing.Point(12, 12);
            this.EspacioCamara.Name = "EspacioCamara";
            this.EspacioCamara.Size = new System.Drawing.Size(327, 369);
            this.EspacioCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspacioCamara.TabIndex = 4;
            this.EspacioCamara.TabStop = false;
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(12, 424);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(298, 28);
            this.cbxDispositivos.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(604, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 31);
            this.button3.TabIndex = 32;
            this.button3.Text = "Guardar Foto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 31);
            this.button2.TabIndex = 31;
            this.button2.Text = "Tomar Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "Encender Camara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picMostrar
            // 
            this.picMostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMostrar.Location = new System.Drawing.Point(348, 12);
            this.picMostrar.Name = "picMostrar";
            this.picMostrar.Size = new System.Drawing.Size(343, 369);
            this.picMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMostrar.TabIndex = 34;
            this.picMostrar.TabStop = false;
            // 
            // frmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 465);
            this.Controls.Add(this.picMostrar);
            this.Controls.Add(this.cbxDispositivos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EspacioCamara);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFoto";
            this.Text = "Foto Propietario";
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox EspacioCamara;
        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picMostrar;
    }
}