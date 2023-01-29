namespace MaresMediaPlayerKaraoke
{
    partial class AgregarCancion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCancion));
            this.lblCancion = new System.Windows.Forms.Label();
            this.txtCancion = new System.Windows.Forms.TextBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.cboGeneros = new System.Windows.Forms.ComboBox();
            this.lblDisco = new System.Windows.Forms.Label();
            this.txtDisco = new System.Windows.Forms.TextBox();
            this.lblImagenArtista = new System.Windows.Forms.Label();
            this.txtImagenArtista = new System.Windows.Forms.TextBox();
            this.btnImagenArtista = new System.Windows.Forms.Button();
            this.lblCaratula = new System.Windows.Forms.Label();
            this.txtCaratula = new System.Windows.Forms.TextBox();
            this.btnCaratula = new System.Windows.Forms.Button();
            this.lblLyrics = new System.Windows.Forms.Label();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.btnLyrics = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.pctCaratula = new System.Windows.Forms.PictureBox();
            this.pctArtista = new System.Windows.Forms.PictureBox();
            this.rctLetra = new System.Windows.Forms.RichTextBox();
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregarOtra = new System.Windows.Forms.Button();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.lblBiografia = new System.Windows.Forms.Label();
            this.btnBiografia = new System.Windows.Forms.Button();
            this.rctBiografia = new System.Windows.Forms.RichTextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.btnObtenerEtiquetas = new System.Windows.Forms.Button();
            this.axWmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmEscuchar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctCaratula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArtista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpReproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCancion.Location = new System.Drawing.Point(2, 9);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(156, 18);
            this.lblCancion.TabIndex = 0;
            this.lblCancion.Text = "Nombre de la Cancion";
            // 
            // txtCancion
            // 
            this.txtCancion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCancion.Location = new System.Drawing.Point(164, 6);
            this.txtCancion.Name = "txtCancion";
            this.txtCancion.Size = new System.Drawing.Size(304, 24);
            this.txtCancion.TabIndex = 1;
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArtista.Location = new System.Drawing.Point(28, 37);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(130, 18);
            this.lblArtista.TabIndex = 0;
            this.lblArtista.Text = "Nombre del Artista";
            // 
            // txtArtista
            // 
            this.txtArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtista.Location = new System.Drawing.Point(164, 34);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(304, 24);
            this.txtArtista.TabIndex = 1;
            // 
            // lblGeneros
            // 
            this.lblGeneros.AutoSize = true;
            this.lblGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGeneros.Location = new System.Drawing.Point(100, 62);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(58, 18);
            this.lblGeneros.TabIndex = 0;
            this.lblGeneros.Text = "Genero";
            // 
            // cboGeneros
            // 
            this.cboGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGeneros.FormattingEnabled = true;
            this.cboGeneros.Items.AddRange(new object[] {
            "Balada",
            "Grupero",
            "Pop",
            "Rock",
            "Romantico"});
            this.cboGeneros.Location = new System.Drawing.Point(164, 62);
            this.cboGeneros.Name = "cboGeneros";
            this.cboGeneros.Size = new System.Drawing.Size(304, 26);
            this.cboGeneros.TabIndex = 2;
            // 
            // lblDisco
            // 
            this.lblDisco.AutoSize = true;
            this.lblDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisco.Location = new System.Drawing.Point(111, 92);
            this.lblDisco.Name = "lblDisco";
            this.lblDisco.Size = new System.Drawing.Size(47, 18);
            this.lblDisco.TabIndex = 0;
            this.lblDisco.Text = "Disco";
            // 
            // txtDisco
            // 
            this.txtDisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisco.Location = new System.Drawing.Point(164, 92);
            this.txtDisco.Name = "txtDisco";
            this.txtDisco.Size = new System.Drawing.Size(304, 24);
            this.txtDisco.TabIndex = 1;
            // 
            // lblImagenArtista
            // 
            this.lblImagenArtista.AutoSize = true;
            this.lblImagenArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenArtista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImagenArtista.Location = new System.Drawing.Point(181, 119);
            this.lblImagenArtista.Name = "lblImagenArtista";
            this.lblImagenArtista.Size = new System.Drawing.Size(124, 18);
            this.lblImagenArtista.TabIndex = 0;
            this.lblImagenArtista.Text = "Imagen del Artista";
            // 
            // txtImagenArtista
            // 
            this.txtImagenArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagenArtista.Location = new System.Drawing.Point(259, 328);
            this.txtImagenArtista.Name = "txtImagenArtista";
            this.txtImagenArtista.ReadOnly = true;
            this.txtImagenArtista.Size = new System.Drawing.Size(248, 24);
            this.txtImagenArtista.TabIndex = 1;
            this.txtImagenArtista.Visible = false;
            // 
            // btnImagenArtista
            // 
            this.btnImagenArtista.Location = new System.Drawing.Point(310, 118);
            this.btnImagenArtista.Name = "btnImagenArtista";
            this.btnImagenArtista.Size = new System.Drawing.Size(27, 21);
            this.btnImagenArtista.TabIndex = 3;
            this.btnImagenArtista.Text = "...";
            this.btnImagenArtista.UseVisualStyleBackColor = true;
            this.btnImagenArtista.Click += new System.EventHandler(this.btnImagenArtista_Click);
            // 
            // lblCaratula
            // 
            this.lblCaratula.AutoSize = true;
            this.lblCaratula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaratula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaratula.Location = new System.Drawing.Point(12, 118);
            this.lblCaratula.Name = "lblCaratula";
            this.lblCaratula.Size = new System.Drawing.Size(129, 18);
            this.lblCaratula.TabIndex = 0;
            this.lblCaratula.Text = "Caratula del Disco";
            // 
            // txtCaratula
            // 
            this.txtCaratula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaratula.Location = new System.Drawing.Point(5, 328);
            this.txtCaratula.Name = "txtCaratula";
            this.txtCaratula.ReadOnly = true;
            this.txtCaratula.Size = new System.Drawing.Size(248, 24);
            this.txtCaratula.TabIndex = 1;
            this.txtCaratula.Visible = false;
            // 
            // btnCaratula
            // 
            this.btnCaratula.Location = new System.Drawing.Point(142, 118);
            this.btnCaratula.Name = "btnCaratula";
            this.btnCaratula.Size = new System.Drawing.Size(27, 21);
            this.btnCaratula.TabIndex = 3;
            this.btnCaratula.Text = "...";
            this.btnCaratula.UseVisualStyleBackColor = true;
            this.btnCaratula.Click += new System.EventHandler(this.btnCaratula_Click);
            // 
            // lblLyrics
            // 
            this.lblLyrics.AutoSize = true;
            this.lblLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyrics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLyrics.Location = new System.Drawing.Point(350, 119);
            this.lblLyrics.Name = "lblLyrics";
            this.lblLyrics.Size = new System.Drawing.Size(131, 18);
            this.lblLyrics.TabIndex = 0;
            this.lblLyrics.Text = "Letra Sincronizada";
            // 
            // txtLyrics
            // 
            this.txtLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyrics.Location = new System.Drawing.Point(4, 358);
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.ReadOnly = true;
            this.txtLyrics.Size = new System.Drawing.Size(248, 24);
            this.txtLyrics.TabIndex = 1;
            this.txtLyrics.Visible = false;
            // 
            // btnLyrics
            // 
            this.btnLyrics.Location = new System.Drawing.Point(447, 186);
            this.btnLyrics.Name = "btnLyrics";
            this.btnLyrics.Size = new System.Drawing.Size(27, 21);
            this.btnLyrics.TabIndex = 3;
            this.btnLyrics.Text = "...";
            this.btnLyrics.UseVisualStyleBackColor = true;
            this.btnLyrics.Click += new System.EventHandler(this.btnLyrics_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(514, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUbicacion.Location = new System.Drawing.Point(123, 259);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(74, 18);
            this.lblUbicacion.TabIndex = 0;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(126, 279);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.ReadOnly = true;
            this.txtUbicacion.Size = new System.Drawing.Size(365, 24);
            this.txtUbicacion.TabIndex = 1;
            // 
            // pctCaratula
            // 
            this.pctCaratula.Image = ((System.Drawing.Image)(resources.GetObject("pctCaratula.Image")));
            this.pctCaratula.Location = new System.Drawing.Point(18, 139);
            this.pctCaratula.Name = "pctCaratula";
            this.pctCaratula.Size = new System.Drawing.Size(107, 67);
            this.pctCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCaratula.TabIndex = 4;
            this.pctCaratula.TabStop = false;
            // 
            // pctArtista
            // 
            this.pctArtista.Image = ((System.Drawing.Image)(resources.GetObject("pctArtista.Image")));
            this.pctArtista.Location = new System.Drawing.Point(191, 140);
            this.pctArtista.Name = "pctArtista";
            this.pctArtista.Size = new System.Drawing.Size(118, 67);
            this.pctArtista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctArtista.TabIndex = 4;
            this.pctArtista.TabStop = false;
            // 
            // rctLetra
            // 
            this.rctLetra.Location = new System.Drawing.Point(353, 139);
            this.rctLetra.Name = "rctLetra";
            this.rctLetra.ReadOnly = true;
            this.rctLetra.Size = new System.Drawing.Size(88, 66);
            this.rctLetra.TabIndex = 5;
            this.rctLetra.Text = "";
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanciones.Location = new System.Drawing.Point(496, 6);
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.Size = new System.Drawing.Size(379, 271);
            this.dgvCanciones.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(715, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 34);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(801, 278);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(73, 34);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregarOtra
            // 
            this.btnAgregarOtra.Location = new System.Drawing.Point(610, 279);
            this.btnAgregarOtra.Name = "btnAgregarOtra";
            this.btnAgregarOtra.Size = new System.Drawing.Size(99, 34);
            this.btnAgregarOtra.TabIndex = 3;
            this.btnAgregarOtra.Text = "Agregar Otra";
            this.btnAgregarOtra.UseVisualStyleBackColor = true;
            this.btnAgregarOtra.Click += new System.EventHandler(this.btnAgregarOtra_Click);
            // 
            // txtBiografia
            // 
            this.txtBiografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiografia.Location = new System.Drawing.Point(259, 358);
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.ReadOnly = true;
            this.txtBiografia.Size = new System.Drawing.Size(248, 24);
            this.txtBiografia.TabIndex = 1;
            this.txtBiografia.Visible = false;
            // 
            // lblBiografia
            // 
            this.lblBiografia.AutoSize = true;
            this.lblBiografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiografia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBiografia.Location = new System.Drawing.Point(15, 218);
            this.lblBiografia.Name = "lblBiografia";
            this.lblBiografia.Size = new System.Drawing.Size(66, 18);
            this.lblBiografia.TabIndex = 0;
            this.lblBiografia.Text = "Biografia";
            // 
            // btnBiografia
            // 
            this.btnBiografia.Location = new System.Drawing.Point(79, 218);
            this.btnBiografia.Name = "btnBiografia";
            this.btnBiografia.Size = new System.Drawing.Size(27, 21);
            this.btnBiografia.TabIndex = 3;
            this.btnBiografia.Text = "...";
            this.btnBiografia.UseVisualStyleBackColor = true;
            this.btnBiografia.Click += new System.EventHandler(this.btnBiografia_Click);
            // 
            // rctBiografia
            // 
            this.rctBiografia.Location = new System.Drawing.Point(18, 238);
            this.rctBiografia.Name = "rctBiografia";
            this.rctBiografia.ReadOnly = true;
            this.rctBiografia.Size = new System.Drawing.Size(88, 66);
            this.rctBiografia.TabIndex = 5;
            this.rctBiografia.Text = "";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDuracion.Location = new System.Drawing.Point(123, 230);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(68, 18);
            this.lblDuracion.TabIndex = 0;
            this.lblDuracion.Text = "Duracion";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.Location = new System.Drawing.Point(190, 225);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(95, 24);
            this.txtDuracion.TabIndex = 1;
            // 
            // btnObtenerEtiquetas
            // 
            this.btnObtenerEtiquetas.Location = new System.Drawing.Point(341, 223);
            this.btnObtenerEtiquetas.Name = "btnObtenerEtiquetas";
            this.btnObtenerEtiquetas.Size = new System.Drawing.Size(133, 34);
            this.btnObtenerEtiquetas.TabIndex = 3;
            this.btnObtenerEtiquetas.Text = "Obtener Etiquetas";
            this.btnObtenerEtiquetas.UseVisualStyleBackColor = true;
            this.btnObtenerEtiquetas.Click += new System.EventHandler(this.btnObtenerEtiquetas_Click);
            // 
            // axWmpReproductor
            // 
            this.axWmpReproductor.Enabled = true;
            this.axWmpReproductor.Location = new System.Drawing.Point(547, 119);
            this.axWmpReproductor.Name = "axWmpReproductor";
            this.axWmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmpReproductor.OcxState")));
            this.axWmpReproductor.Size = new System.Drawing.Size(238, 152);
            this.axWmpReproductor.TabIndex = 7;
            this.axWmpReproductor.Visible = false;
            // 
            // tmEscuchar
            // 
            this.tmEscuchar.Tick += new System.EventHandler(this.tmEscuchar_Tick);
            // 
            // AgregarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(887, 321);
            this.Controls.Add(this.axWmpReproductor);
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.rctBiografia);
            this.Controls.Add(this.rctLetra);
            this.Controls.Add(this.pctArtista);
            this.Controls.Add(this.pctCaratula);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarOtra);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBiografia);
            this.Controls.Add(this.btnObtenerEtiquetas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLyrics);
            this.Controls.Add(this.btnCaratula);
            this.Controls.Add(this.btnImagenArtista);
            this.Controls.Add(this.cboGeneros);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtBiografia);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.txtCaratula);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblBiografia);
            this.Controls.Add(this.txtImagenArtista);
            this.Controls.Add(this.lblLyrics);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.lblCaratula);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.lblImagenArtista);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.txtDisco);
            this.Controls.Add(this.lblDisco);
            this.Controls.Add(this.txtCancion);
            this.Controls.Add(this.lblCancion);
            this.Name = "AgregarCancion";
            this.Text = "Agregar Cancion";
            ((System.ComponentModel.ISupportInitialize)(this.pctCaratula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctArtista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWmpReproductor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.TextBox txtCancion;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.ComboBox cboGeneros;
        private System.Windows.Forms.Label lblDisco;
        private System.Windows.Forms.TextBox txtDisco;
        private System.Windows.Forms.Label lblImagenArtista;
        private System.Windows.Forms.TextBox txtImagenArtista;
        private System.Windows.Forms.Button btnImagenArtista;
        private System.Windows.Forms.Label lblCaratula;
        private System.Windows.Forms.TextBox txtCaratula;
        private System.Windows.Forms.Button btnCaratula;
        private System.Windows.Forms.Label lblLyrics;
        private System.Windows.Forms.TextBox txtLyrics;
        private System.Windows.Forms.Button btnLyrics;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.PictureBox pctCaratula;
        private System.Windows.Forms.PictureBox pctArtista;
        private System.Windows.Forms.RichTextBox rctLetra;
        private System.Windows.Forms.DataGridView dgvCanciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregarOtra;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.Label lblBiografia;
        private System.Windows.Forms.Button btnBiografia;
        private System.Windows.Forms.RichTextBox rctBiografia;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Button btnObtenerEtiquetas;
        private AxWMPLib.AxWindowsMediaPlayer axWmpReproductor;
        private System.Windows.Forms.Timer tmEscuchar;
    }
}