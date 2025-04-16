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
        ImagenManager imagenManager = new ImagenManager();

        List<Imagen> listaImagenesTotales = new List<Imagen>();
        List<Imagen> listaImagenesDelArticulo = new List<Imagen>();
        private int indiceActualDeImagenes = 0;

        bool seActivoElList = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnListaArt_Click(object sender, EventArgs e)
        {
            seActivoElList = true;
            ActualizarGrillaArticulos();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            listaImagenesTotales = imagenManager.listarImagenes();
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccion);
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
        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (indiceActualDeImagenes < listaImagenesDelArticulo.Count - 1)
            {
                indiceActualDeImagenes++;
                MostrarImagenNueva(listaImagenesDelArticulo[indiceActualDeImagenes].ImagenUrl);
                ActualizarVisibilidadBotones();
            }
        }
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (indiceActualDeImagenes > 0)
            {
                indiceActualDeImagenes--;
                MostrarImagenNueva(listaImagenesDelArticulo[indiceActualDeImagenes].ImagenUrl);
                ActualizarVisibilidadBotones();
            }
        }
        private void ActualizarVisibilidadBotones()
        {
            if (indiceActualDeImagenes > 0)
                btnIzquierda.Visible = true;
            else
                btnIzquierda.Visible = false;


            if (indiceActualDeImagenes < listaImagenesDelArticulo.Count - 1)
                btnDerecha.Visible = true;
            else
                btnDerecha.Visible = false;
        }
        private void CargarImagen(Articulo articulo)
        {
            listaImagenesDelArticulo = ListarImagenesPorId(listaImagenesTotales, articulo);
            indiceActualDeImagenes = 0;

            try
            {
                if (listaImagenesDelArticulo.Count > 0 && !string.IsNullOrWhiteSpace(listaImagenesDelArticulo[0].ImagenUrl))
                {
                    pbxArticulo.Load(listaImagenesDelArticulo[0].ImagenUrl);
                }
                else
                {
                    pbxArticulo.Load("https://th.bing.com/th/id/OIP.mSzrXbopNaal5jPsMxNHHwHaHa?rs=1&pid=ImgDetMain");
                }
            }
            catch
            {
                pbxArticulo.Load("https://th.bing.com/th/id/OIP.mSzrXbopNaal5jPsMxNHHwHaHa?rs=1&pid=ImgDetMain");
            }
            ActualizarVisibilidadBotones();
        }
        private void MostrarImagenNueva(string url)
        {
            try
            {
                pbxArticulo.Load(url);
            }
            catch
            {
                pbxArticulo.Load("https://th.bing.com/th/id/OIP.mSzrXbopNaal5jPsMxNHHwHaHa?rs=1&pid=ImgDetMain");
            }
        }
        private List<Imagen> ListarImagenesPorId(List<Imagen> listaImagenes, Articulo articulo)
        {
            List<Imagen> listaImagenesPorArticulo = new List<Imagen>();

            foreach (Imagen img in listaImagenes)
            {
                if (articulo.Id == img.IdArticulo)
                {
                    listaImagenesPorArticulo.Add(img);
                }
            }
            return listaImagenesPorArticulo;
        }
        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            if (seActivoElList && agregar.SeGuardoElArticulo)
            {
                ActualizarGrillaArticulos();
            }
        }
        private void ActualizarGrillaArticulos()
        {
            listaImagenesTotales = imagenManager.listarImagenes();
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articuloManager.listarArticulos();
            OcultarColumnas();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto para modificar", "Seleccione un producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmAgregar agregar = new frmAgregar((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
            agregar.ShowDialog();
            if (agregar.articuloActualizado)
            {
                ActualizarGrillaArticulos();
            }
        }
    }
}
