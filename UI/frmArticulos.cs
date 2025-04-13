using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        ArticuloManager articuloManager = new ArticuloManager();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnListaArt_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = articuloManager.listarArticulos();
            ocultarColumnas();
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            }
        }
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalle detalles = new frmDetalle(seleccionado);
                detalles.ShowDialog();
                dgvArticulos.DataSource = articuloManager.listarArticulos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila antes de ver los detalles.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
        }
    }
}
