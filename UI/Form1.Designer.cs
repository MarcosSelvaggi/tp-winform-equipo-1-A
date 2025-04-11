namespace UI
{
    partial class frmPrincipal
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
            this.btnListaArt = new System.Windows.Forms.Button();
            this.lblBusquedaR = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tbxBusquedaR = new System.Windows.Forms.TextBox();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.pbxListaArt = new System.Windows.Forms.PictureBox();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.pbxAgregarArt = new System.Windows.Forms.PictureBox();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.pbxModificarArt = new System.Windows.Forms.PictureBox();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.pbxEliminarArt = new System.Windows.Forms.PictureBox();
            this.btnBusquedaAv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxListaArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminarArt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListaArt
            // 
            this.btnListaArt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnListaArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaArt.Location = new System.Drawing.Point(59, 166);
            this.btnListaArt.Name = "btnListaArt";
            this.btnListaArt.Size = new System.Drawing.Size(171, 50);
            this.btnListaArt.TabIndex = 0;
            this.btnListaArt.Text = "Lista de Articulos";
            this.btnListaArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaArt.UseVisualStyleBackColor = false;
            // 
            // lblBusquedaR
            // 
            this.lblBusquedaR.AutoSize = true;
            this.lblBusquedaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaR.ForeColor = System.Drawing.Color.White;
            this.lblBusquedaR.Location = new System.Drawing.Point(452, 351);
            this.lblBusquedaR.Name = "lblBusquedaR";
            this.lblBusquedaR.Size = new System.Drawing.Size(174, 22);
            this.lblBusquedaR.TabIndex = 1;
            this.lblBusquedaR.Text = "Busqueda Rapida:";
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(224, 157);
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // tbxBusquedaR
            // 
            this.tbxBusquedaR.Location = new System.Drawing.Point(632, 351);
            this.tbxBusquedaR.Name = "tbxBusquedaR";
            this.tbxBusquedaR.Size = new System.Drawing.Size(181, 26);
            this.tbxBusquedaR.TabIndex = 3;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlBotones.Controls.Add(this.pbxEliminarArt);
            this.pnlBotones.Controls.Add(this.btnEliminarArt);
            this.pnlBotones.Controls.Add(this.pbxModificarArt);
            this.pnlBotones.Controls.Add(this.btnModificarArt);
            this.pnlBotones.Controls.Add(this.pbxAgregarArt);
            this.pnlBotones.Controls.Add(this.btnAgregarArt);
            this.pnlBotones.Controls.Add(this.pbxListaArt);
            this.pnlBotones.Controls.Add(this.pbxLogo);
            this.pnlBotones.Controls.Add(this.btnListaArt);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(230, 384);
            this.pnlBotones.TabIndex = 4;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(236, 0);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.Size = new System.Drawing.Size(577, 340);
            this.dgvArticulos.TabIndex = 5;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxArticulo.Location = new System.Drawing.Point(819, 0);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(210, 210);
            this.pbxArticulo.TabIndex = 3;
            this.pbxArticulo.TabStop = false;
            // 
            // pbxListaArt
            // 
            this.pbxListaArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxListaArt.Location = new System.Drawing.Point(3, 166);
            this.pbxListaArt.Name = "pbxListaArt";
            this.pbxListaArt.Size = new System.Drawing.Size(50, 50);
            this.pbxListaArt.TabIndex = 6;
            this.pbxListaArt.TabStop = false;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Location = new System.Drawing.Point(819, 216);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(101, 36);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Location = new System.Drawing.Point(928, 216);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(101, 36);
            this.btnDerecha.TabIndex = 8;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalles.Location = new System.Drawing.Point(819, 258);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(210, 44);
            this.btnDetalles.TabIndex = 7;
            this.btnDetalles.Text = "Mas Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarArt.Location = new System.Drawing.Point(59, 222);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(171, 50);
            this.btnAgregarArt.TabIndex = 7;
            this.btnAgregarArt.Text = "Agregar Articulo";
            this.btnAgregarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArt.UseVisualStyleBackColor = false;
            // 
            // pbxAgregarArt
            // 
            this.pbxAgregarArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxAgregarArt.Location = new System.Drawing.Point(3, 222);
            this.pbxAgregarArt.Name = "pbxAgregarArt";
            this.pbxAgregarArt.Size = new System.Drawing.Size(50, 50);
            this.pbxAgregarArt.TabIndex = 8;
            this.pbxAgregarArt.TabStop = false;
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnModificarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarArt.Location = new System.Drawing.Point(59, 278);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(171, 50);
            this.btnModificarArt.TabIndex = 9;
            this.btnModificarArt.Text = "Modificar Articulo";
            this.btnModificarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarArt.UseVisualStyleBackColor = false;
            // 
            // pbxModificarArt
            // 
            this.pbxModificarArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxModificarArt.Location = new System.Drawing.Point(3, 278);
            this.pbxModificarArt.Name = "pbxModificarArt";
            this.pbxModificarArt.Size = new System.Drawing.Size(50, 50);
            this.pbxModificarArt.TabIndex = 10;
            this.pbxModificarArt.TabStop = false;
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnEliminarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarArt.Location = new System.Drawing.Point(59, 334);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(171, 50);
            this.btnEliminarArt.TabIndex = 11;
            this.btnEliminarArt.Text = "Eliminar Articulo";
            this.btnEliminarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarArt.UseVisualStyleBackColor = false;
            // 
            // pbxEliminarArt
            // 
            this.pbxEliminarArt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxEliminarArt.Location = new System.Drawing.Point(3, 334);
            this.pbxEliminarArt.Name = "pbxEliminarArt";
            this.pbxEliminarArt.Size = new System.Drawing.Size(50, 50);
            this.pbxEliminarArt.TabIndex = 12;
            this.pbxEliminarArt.TabStop = false;
            // 
            // btnBusquedaAv
            // 
            this.btnBusquedaAv.Location = new System.Drawing.Point(236, 346);
            this.btnBusquedaAv.Name = "btnBusquedaAv";
            this.btnBusquedaAv.Size = new System.Drawing.Size(210, 36);
            this.btnBusquedaAv.TabIndex = 9;
            this.btnBusquedaAv.Text = "Busqueda Avanzada";
            this.btnBusquedaAv.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1035, 384);
            this.Controls.Add(this.btnBusquedaAv);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.tbxBusquedaR);
            this.Controls.Add(this.lblBusquedaR);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1057, 440);
            this.MinimumSize = new System.Drawing.Size(1057, 440);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxListaArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminarArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaArt;
        private System.Windows.Forms.Label lblBusquedaR;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.TextBox tbxBusquedaR;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.PictureBox pbxListaArt;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.PictureBox pbxModificarArt;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.PictureBox pbxAgregarArt;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.PictureBox pbxEliminarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.Button btnBusquedaAv;
    }
}

