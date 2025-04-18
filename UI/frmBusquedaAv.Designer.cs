namespace UI
{
    partial class frmBusquedaAv
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.btnBusquedaAv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(17, 130);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(122, 26);
            this.txtValor.TabIndex = 1;
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(107, 20);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 28);
            this.cbxCampo.TabIndex = 2;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(107, 69);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 28);
            this.cbxCriterio.TabIndex = 3;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.Location = new System.Drawing.Point(13, 67);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(88, 26);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(12, 18);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(89, 26);
            this.lblCampo.TabIndex = 5;
            this.lblCampo.Text = "Campo:";
            // 
            // btnBusquedaAv
            // 
            this.btnBusquedaAv.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBusquedaAv.FlatAppearance.BorderSize = 0;
            this.btnBusquedaAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAv.ForeColor = System.Drawing.Color.Black;
            this.btnBusquedaAv.Location = new System.Drawing.Point(145, 123);
            this.btnBusquedaAv.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnBusquedaAv.Name = "btnBusquedaAv";
            this.btnBusquedaAv.Size = new System.Drawing.Size(83, 39);
            this.btnBusquedaAv.TabIndex = 10;
            this.btnBusquedaAv.Text = "Buscar";
            this.btnBusquedaAv.UseVisualStyleBackColor = false;
            this.btnBusquedaAv.Click += new System.EventHandler(this.btnBusquedaAv_Click);
            // 
            // frmBusquedaAv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(244, 182);
            this.Controls.Add(this.btnBusquedaAv);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.txtValor);
            this.Name = "frmBusquedaAv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaAv";
            this.Load += new System.EventHandler(this.frmBusquedaAv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnBusquedaAv;
    }
}