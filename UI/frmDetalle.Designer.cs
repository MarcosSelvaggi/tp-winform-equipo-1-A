namespace UI
{
    partial class frmDetalle
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
            this.lblCodigoH = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.lblNombreH = new System.Windows.Forms.Label();
            this.lblDescripcionH = new System.Windows.Forms.Label();
            this.lblPrecioH = new System.Windows.Forms.Label();
            this.lblMarcaH = new System.Windows.Forms.Label();
            this.lblCategoriaH = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoH
            // 
            this.lblCodigoH.AutoSize = true;
            this.lblCodigoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoH.Location = new System.Drawing.Point(318, 11);
            this.lblCodigoH.Name = "lblCodigoH";
            this.lblCodigoH.Size = new System.Drawing.Size(81, 25);
            this.lblCodigoH.TabIndex = 0;
            this.lblCodigoH.Text = "Codigo:";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.pbxArticulo.Location = new System.Drawing.Point(12, 11);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(300, 300);
            this.pbxArticulo.TabIndex = 4;
            this.pbxArticulo.TabStop = false;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIzquierda.FlatAppearance.BorderSize = 0;
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.ForeColor = System.Drawing.Color.Black;
            this.btnIzquierda.Location = new System.Drawing.Point(12, 315);
            this.btnIzquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(81, 38);
            this.btnIzquierda.TabIndex = 8;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = false;
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDerecha.FlatAppearance.BorderSize = 0;
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.ForeColor = System.Drawing.Color.Black;
            this.btnDerecha.Location = new System.Drawing.Point(231, 314);
            this.btnDerecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(81, 38);
            this.btnDerecha.TabIndex = 9;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = false;
            // 
            // lblNombreH
            // 
            this.lblNombreH.AutoSize = true;
            this.lblNombreH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreH.Location = new System.Drawing.Point(318, 55);
            this.lblNombreH.Name = "lblNombreH";
            this.lblNombreH.Size = new System.Drawing.Size(87, 25);
            this.lblNombreH.TabIndex = 10;
            this.lblNombreH.Text = "Nombre:";
            // 
            // lblDescripcionH
            // 
            this.lblDescripcionH.AutoSize = true;
            this.lblDescripcionH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionH.Location = new System.Drawing.Point(318, 98);
            this.lblDescripcionH.Name = "lblDescripcionH";
            this.lblDescripcionH.Size = new System.Drawing.Size(120, 25);
            this.lblDescripcionH.TabIndex = 11;
            this.lblDescripcionH.Text = "Descripcion:";
            // 
            // lblPrecioH
            // 
            this.lblPrecioH.AutoSize = true;
            this.lblPrecioH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioH.Location = new System.Drawing.Point(318, 146);
            this.lblPrecioH.Name = "lblPrecioH";
            this.lblPrecioH.Size = new System.Drawing.Size(73, 25);
            this.lblPrecioH.TabIndex = 12;
            this.lblPrecioH.Text = "Precio:";
            // 
            // lblMarcaH
            // 
            this.lblMarcaH.AutoSize = true;
            this.lblMarcaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaH.Location = new System.Drawing.Point(318, 189);
            this.lblMarcaH.Name = "lblMarcaH";
            this.lblMarcaH.Size = new System.Drawing.Size(73, 25);
            this.lblMarcaH.TabIndex = 14;
            this.lblMarcaH.Text = "Marca:";
            // 
            // lblCategoriaH
            // 
            this.lblCategoriaH.AutoSize = true;
            this.lblCategoriaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaH.Location = new System.Drawing.Point(318, 233);
            this.lblCategoriaH.Name = "lblCategoriaH";
            this.lblCategoriaH.Size = new System.Drawing.Size(103, 25);
            this.lblCategoriaH.TabIndex = 15;
            this.lblCategoriaH.Text = "Categoria:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(427, 233);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(17, 25);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = ".";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(397, 189);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(17, 25);
            this.lblMarca.TabIndex = 20;
            this.lblMarca.Text = ".";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(397, 146);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(17, 25);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = ".";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(444, 98);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(17, 25);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = ".";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(411, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(17, 25);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = ".";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(405, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(17, 25);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = ".";
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(735, 363);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCategoriaH);
            this.Controls.Add(this.lblMarcaH);
            this.Controls.Add(this.lblPrecioH);
            this.Controls.Add(this.lblDescripcionH);
            this.Controls.Add(this.lblNombreH);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblCodigoH);
            this.MaximumSize = new System.Drawing.Size(757, 419);
            this.MinimumSize = new System.Drawing.Size(757, 419);
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles del Articulo";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoH;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Label lblNombreH;
        private System.Windows.Forms.Label lblDescripcionH;
        private System.Windows.Forms.Label lblPrecioH;
        private System.Windows.Forms.Label lblMarcaH;
        private System.Windows.Forms.Label lblCategoriaH;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
    }
}