using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmBusquedaAv: Form
    {
        public string CampoSeleccionado { get; set; }
        public string CriterioSeleccionado { get; set; }
        public string ValorBusqueda { get; set; }
        public bool BusquedaRealizada { get; set; }

        public frmBusquedaAv()
        {
            InitializeComponent();
        }
        private void frmBusquedaAv_Load(object sender, EventArgs e)
        {
            cbxCampo.Items.Add("Codigo");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
            cbxCampo.Items.Add("Precio");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoria");
        }
        private void btnBusquedaAv_Click(object sender, EventArgs e)
        {
            CampoSeleccionado = cbxCampo.SelectedItem?.ToString();
            CriterioSeleccionado = cbxCriterio.SelectedItem?.ToString();
            ValorBusqueda = txtValor.Text;
            BusquedaRealizada = true;

            if (string.IsNullOrEmpty(cbxCampo.Text)) 
            {
                MessageBox.Show("Por favor, ingrese un campo para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(cbxCriterio.Text))
            {
                MessageBox.Show("Por favor, ingrese un criterio para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Close();
        }
        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCriterio.Items.Clear();

            string campo = cbxCampo.SelectedItem.ToString();

            if (campo == "Precio")
            {
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Add("Contiene");
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
            }

            cbxCriterio.SelectedIndex = 0;
        }
    }
}
