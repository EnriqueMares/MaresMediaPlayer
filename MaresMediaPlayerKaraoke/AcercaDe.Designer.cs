namespace MaresMediaPlayerKaraoke
{
    partial class AcercaDe
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.pctMaresMedia = new System.Windows.Forms.PictureBox();
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaresMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // pctMaresMedia
            // 
            this.pctMaresMedia.Image = ((System.Drawing.Image)(resources.GetObject("pctMaresMedia.Image")));
            this.pctMaresMedia.Location = new System.Drawing.Point(76, 57);
            this.pctMaresMedia.Name = "pctMaresMedia";
            this.pctMaresMedia.Size = new System.Drawing.Size(165, 103);
            this.pctMaresMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMaresMedia.TabIndex = 6;
            this.pctMaresMedia.TabStop = false;
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeyenda.Location = new System.Drawing.Point(247, 60);
            this.txtLeyenda.Multiline = true;
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.ReadOnly = true;
            this.txtLeyenda.Size = new System.Drawing.Size(288, 91);
            this.txtLeyenda.TabIndex = 5;
            this.txtLeyenda.Text = "MaresPad es un reproductor de Audio\r\ncreado por los alumnos:\r\nLuis Enrique Mares " +
                "Ortega\r\nDoraly Lozano San Miguel ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(460, 157);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 31);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 437);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pctMaresMedia);
            this.Controls.Add(this.txtLeyenda);
            this.Name = "AcercaDe";
            this.Text = "AcercaDe";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctMaresMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMaresMedia;
        private System.Windows.Forms.TextBox txtLeyenda;
        private System.Windows.Forms.Button btnAceptar;
    }
}