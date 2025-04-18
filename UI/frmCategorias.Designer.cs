namespace UI
{
    partial class frmCategorias
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
            this.txtModificarCategoria = new System.Windows.Forms.TextBox();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.txtAgregarCategoria = new System.Windows.Forms.TextBox();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoría = new System.Windows.Forms.Button();
            this.rbtnAgregarCategoria = new System.Windows.Forms.RadioButton();
            this.rbtnModificarCategoria = new System.Windows.Forms.RadioButton();
            this.rbtnEliminarCategoria = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtModificarCategoria
            // 
            this.txtModificarCategoria.Location = new System.Drawing.Point(159, 97);
            this.txtModificarCategoria.Name = "txtModificarCategoria";
            this.txtModificarCategoria.Size = new System.Drawing.Size(171, 20);
            this.txtModificarCategoria.TabIndex = 0;
            this.txtModificarCategoria.Visible = false;
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(159, 67);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(171, 21);
            this.cboCategorias.TabIndex = 2;
            this.cboCategorias.Visible = false;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(160, 38);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(170, 23);
            this.btnAgregarCategoria.TabIndex = 37;
            this.btnAgregarCategoria.Text = "Agregar Nueva Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Visible = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // txtAgregarCategoria
            // 
            this.txtAgregarCategoria.Location = new System.Drawing.Point(160, 12);
            this.txtAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtAgregarCategoria.Name = "txtAgregarCategoria";
            this.txtAgregarCategoria.Size = new System.Drawing.Size(171, 20);
            this.txtAgregarCategoria.TabIndex = 38;
            this.txtAgregarCategoria.Visible = false;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategoria.Location = new System.Drawing.Point(160, 123);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(170, 23);
            this.btnModificarCategoria.TabIndex = 42;
            this.btnModificarCategoria.Text = "Modificar Categoría";
            this.btnModificarCategoria.UseVisualStyleBackColor = false;
            this.btnModificarCategoria.Visible = false;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnEliminarCategoría
            // 
            this.btnEliminarCategoría.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminarCategoría.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCategoría.Location = new System.Drawing.Point(161, 152);
            this.btnEliminarCategoría.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarCategoría.Name = "btnEliminarCategoría";
            this.btnEliminarCategoría.Size = new System.Drawing.Size(170, 23);
            this.btnEliminarCategoría.TabIndex = 44;
            this.btnEliminarCategoría.Text = "Eliminar Categoría";
            this.btnEliminarCategoría.UseVisualStyleBackColor = false;
            this.btnEliminarCategoría.Visible = false;
            this.btnEliminarCategoría.Click += new System.EventHandler(this.btnEliminarCategoría_Click);
            // 
            // rbtnAgregarCategoria
            // 
            this.rbtnAgregarCategoria.AutoSize = true;
            this.rbtnAgregarCategoria.Location = new System.Drawing.Point(22, 15);
            this.rbtnAgregarCategoria.Name = "rbtnAgregarCategoria";
            this.rbtnAgregarCategoria.Size = new System.Drawing.Size(112, 17);
            this.rbtnAgregarCategoria.TabIndex = 45;
            this.rbtnAgregarCategoria.Text = "Agregar Categoría";
            this.rbtnAgregarCategoria.UseVisualStyleBackColor = true;
            this.rbtnAgregarCategoria.Click += new System.EventHandler(this.rbtnAgregarCategoria_Click);
            // 
            // rbtnModificarCategoria
            // 
            this.rbtnModificarCategoria.AutoSize = true;
            this.rbtnModificarCategoria.Location = new System.Drawing.Point(22, 39);
            this.rbtnModificarCategoria.Name = "rbtnModificarCategoria";
            this.rbtnModificarCategoria.Size = new System.Drawing.Size(118, 17);
            this.rbtnModificarCategoria.TabIndex = 46;
            this.rbtnModificarCategoria.TabStop = true;
            this.rbtnModificarCategoria.Text = "Modificar Categoría";
            this.rbtnModificarCategoria.UseVisualStyleBackColor = true;
            this.rbtnModificarCategoria.Click += new System.EventHandler(this.rbtnModificarCategoria_Click);
            // 
            // rbtnEliminarCategoria
            // 
            this.rbtnEliminarCategoria.AutoSize = true;
            this.rbtnEliminarCategoria.Location = new System.Drawing.Point(22, 62);
            this.rbtnEliminarCategoria.Name = "rbtnEliminarCategoria";
            this.rbtnEliminarCategoria.Size = new System.Drawing.Size(111, 17);
            this.rbtnEliminarCategoria.TabIndex = 47;
            this.rbtnEliminarCategoria.TabStop = true;
            this.rbtnEliminarCategoria.Text = "Eliminar Categoría";
            this.rbtnEliminarCategoria.UseVisualStyleBackColor = true;
            this.rbtnEliminarCategoria.Click += new System.EventHandler(this.rbtnEliminarCategoria_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 186);
            this.Controls.Add(this.rbtnEliminarCategoria);
            this.Controls.Add(this.rbtnModificarCategoria);
            this.Controls.Add(this.rbtnAgregarCategoria);
            this.Controls.Add(this.btnEliminarCategoría);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txtAgregarCategoria);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.txtModificarCategoria);
            this.MaximumSize = new System.Drawing.Size(357, 230);
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModificarCategoria;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtAgregarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoría;
        private System.Windows.Forms.RadioButton rbtnAgregarCategoria;
        private System.Windows.Forms.RadioButton rbtnModificarCategoria;
        private System.Windows.Forms.RadioButton rbtnEliminarCategoria;
    }
}