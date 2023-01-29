namespace MaresMediaPlayerKaraoke
{
    partial class Entrada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.tmEntrada = new System.Windows.Forms.Timer(this.components);
            // this.axAnimacionFlash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            // ((System.ComponentModel.ISupportInitialize)(this.axAnimacionFlash)).BeginInit();
            this.SuspendLayout();
            // 
            // tmEntrada
            // 
            this.tmEntrada.Enabled = true;
            this.tmEntrada.Interval = 1000;
            this.tmEntrada.Tick += new System.EventHandler(this.tmEntrada_Tick);
            // 
            // axAnimacionFlash
            // 
            //this.axAnimacionFlash.Enabled = true;
            //this.axAnimacionFlash.Location = new System.Drawing.Point(119, 52);
            //this.axAnimacionFlash.Name = "axAnimacionFlash";
            //this.axAnimacionFlash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAnimacionFlash.OcxState")));
            //this.axAnimacionFlash.Size = new System.Drawing.Size(192, 192);
            //this.axAnimacionFlash.TabIndex = 0;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 290);
            // this.Controls.Add(this.axAnimacionFlash);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.Activated += new System.EventHandler(this.Entrada_Activated);
            // ((System.ComponentModel.ISupportInitialize)(this.axAnimacionFlash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmEntrada;
        // private AxShockwaveFlashObjects.AxShockwaveFlash axAnimacionFlash;
    }
}