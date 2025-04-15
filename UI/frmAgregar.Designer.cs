namespace UI
{
    partial class frmAgregar
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
            this.lblCategoriaA = new System.Windows.Forms.Label();
            this.lblMarcaA = new System.Windows.Forms.Label();
            this.lblPrecioA = new System.Windows.Forms.Label();
            this.lblDescripcionA = new System.Windows.Forms.Label();
            this.lblNombreA = new System.Windows.Forms.Label();
            this.lblCodigoA = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.lblImagenA = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lbxImagenes = new System.Windows.Forms.ListBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblImagenesCargadas = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.btnEliminarImagenSeleccionada = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoriaA
            // 
            this.lblCategoriaA.AutoSize = true;
            this.lblCategoriaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaA.Location = new System.Drawing.Point(13, 124);
            this.lblCategoriaA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaA.Name = "lblCategoriaA";
            this.lblCategoriaA.Size = new System.Drawing.Size(73, 17);
            this.lblCategoriaA.TabIndex = 30;
            this.lblCategoriaA.Text = "Categoría:";
            // 
            // lblMarcaA
            // 
            this.lblMarcaA.AutoSize = true;
            this.lblMarcaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaA.Location = new System.Drawing.Point(33, 154);
            this.lblMarcaA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcaA.Name = "lblMarcaA";
            this.lblMarcaA.Size = new System.Drawing.Size(51, 17);
            this.lblMarcaA.TabIndex = 29;
            this.lblMarcaA.Text = "Marca:";
            // 
            // lblPrecioA
            // 
            this.lblPrecioA.AutoSize = true;
            this.lblPrecioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA.Location = new System.Drawing.Point(33, 92);
            this.lblPrecioA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioA.Name = "lblPrecioA";
            this.lblPrecioA.Size = new System.Drawing.Size(52, 17);
            this.lblPrecioA.TabIndex = 28;
            this.lblPrecioA.Text = "Precio:";
            // 
            // lblDescripcionA
            // 
            this.lblDescripcionA.AutoSize = true;
            this.lblDescripcionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionA.Location = new System.Drawing.Point(1, 63);
            this.lblDescripcionA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionA.Name = "lblDescripcionA";
            this.lblDescripcionA.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcionA.TabIndex = 27;
            this.lblDescripcionA.Text = "Descripción:";
            // 
            // lblNombreA
            // 
            this.lblNombreA.AutoSize = true;
            this.lblNombreA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreA.Location = new System.Drawing.Point(23, 34);
            this.lblNombreA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreA.Name = "lblNombreA";
            this.lblNombreA.Size = new System.Drawing.Size(62, 17);
            this.lblNombreA.TabIndex = 26;
            this.lblNombreA.Text = "Nombre:";
            // 
            // lblCodigoA
            // 
            this.lblCodigoA.AutoSize = true;
            this.lblCodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoA.Location = new System.Drawing.Point(27, 7);
            this.lblCodigoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoA.Name = "lblCodigoA";
            this.lblCodigoA.Size = new System.Drawing.Size(56, 17);
            this.lblCodigoA.TabIndex = 22;
            this.lblCodigoA.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(87, 6);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(195, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 35);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(195, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(87, 64);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(195, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(87, 93);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(195, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Location = new System.Drawing.Point(79, 188);
            this.txtRutaImagen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtRutaImagen.Multiline = true;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(170, 18);
            this.txtRutaImagen.TabIndex = 8;
            this.txtRutaImagen.Leave += new System.EventHandler(this.txtRutaImagen_Leave);
            // 
            // lblImagenA
            // 
            this.lblImagenA.AutoSize = true;
            this.lblImagenA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenA.Location = new System.Drawing.Point(26, 188);
            this.lblImagenA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenA.Name = "lblImagenA";
            this.lblImagenA.Size = new System.Drawing.Size(58, 17);
            this.lblImagenA.TabIndex = 37;
            this.lblImagenA.Text = "Imagen:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(306, 330);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 25);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(200, 330);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 25);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackColor = System.Drawing.Color.LavenderBlush;
            this.pbxImagen.Location = new System.Drawing.Point(306, 146);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(170, 166);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 41;
            this.pbxImagen.TabStop = false;
            // 
            // lbxImagenes
            // 
            this.lbxImagenes.FormattingEnabled = true;
            this.lbxImagenes.Location = new System.Drawing.Point(27, 244);
            this.lbxImagenes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lbxImagenes.Name = "lbxImagenes";
            this.lbxImagenes.Size = new System.Drawing.Size(255, 69);
            this.lbxImagenes.TabIndex = 10;
            this.lbxImagenes.SelectedIndexChanged += new System.EventHandler(this.lbxImagenes_SelectedIndexChanged);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImagen.Location = new System.Drawing.Point(253, 184);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(30, 25);
            this.btnAgregarImagen.TabIndex = 9;
            this.btnAgregarImagen.Text = "[+]";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblImagenesCargadas
            // 
            this.lblImagenesCargadas.AutoSize = true;
            this.lblImagenesCargadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenesCargadas.Location = new System.Drawing.Point(23, 222);
            this.lblImagenesCargadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImagenesCargadas.Name = "lblImagenesCargadas";
            this.lblImagenesCargadas.Size = new System.Drawing.Size(164, 17);
            this.lblImagenesCargadas.TabIndex = 45;
            this.lblImagenesCargadas.Text = "Cargar Varias Imagenes:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(87, 125);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(133, 21);
            this.cboCategoria.TabIndex = 6;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(87, 155);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(133, 21);
            this.cboMarca.TabIndex = 4;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(306, 5);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(170, 23);
            this.btnAgregarCategoria.TabIndex = 7;
            this.btnAgregarCategoria.Text = "Agregar Nueva Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Location = new System.Drawing.Point(306, 63);
            this.btnAgregarMarca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(170, 23);
            this.btnAgregarMarca.TabIndex = 5;
            this.btnAgregarMarca.Text = "Agregar Nueva Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(306, 35);
            this.txtNuevaCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(171, 20);
            this.txtNuevaCategoria.TabIndex = 36;
            this.txtNuevaCategoria.Visible = false;
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.Location = new System.Drawing.Point(306, 93);
            this.txtNuevaMarca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(171, 20);
            this.txtNuevaMarca.TabIndex = 35;
            this.txtNuevaMarca.Visible = false;
            // 
            // btnEliminarImagenSeleccionada
            // 
            this.btnEliminarImagenSeleccionada.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminarImagenSeleccionada.Location = new System.Drawing.Point(27, 319);
            this.btnEliminarImagenSeleccionada.Name = "btnEliminarImagenSeleccionada";
            this.btnEliminarImagenSeleccionada.Size = new System.Drawing.Size(98, 30);
            this.btnEliminarImagenSeleccionada.TabIndex = 46;
            this.btnEliminarImagenSeleccionada.Text = "Eliminar imagen";
            this.btnEliminarImagenSeleccionada.UseVisualStyleBackColor = false;
            this.btnEliminarImagenSeleccionada.Click += new System.EventHandler(this.btnEliminarImagenSeleccionada_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(489, 361);
            this.Controls.Add(this.btnEliminarImagenSeleccionada);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblImagenesCargadas);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lbxImagenes);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.lblImagenA);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCategoriaA);
            this.Controls.Add(this.lblMarcaA);
            this.Controls.Add(this.lblPrecioA);
            this.Controls.Add(this.lblDescripcionA);
            this.Controls.Add(this.lblNombreA);
            this.Controls.Add(this.lblCodigoA);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoriaA;
        private System.Windows.Forms.Label lblMarcaA;
        private System.Windows.Forms.Label lblPrecioA;
        private System.Windows.Forms.Label lblDescripcionA;
        private System.Windows.Forms.Label lblNombreA;
        private System.Windows.Forms.Label lblCodigoA;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Label lblImagenA;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.ListBox lbxImagenes;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblImagenesCargadas;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.Button btnEliminarImagenSeleccionada;
    }
}