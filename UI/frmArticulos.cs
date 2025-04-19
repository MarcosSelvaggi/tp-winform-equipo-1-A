using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
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

        List<Articulo> listaArticulosTotales = new List<Articulo>();
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
                MessageBox.Show("Por favor, seleccione una fila antes de ver los detalles.", "Sin selección.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            listaArticulosTotales = articuloManager.listarArticulos();
            listaImagenesTotales = imagenManager.listarImagenes();

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articuloManager.listarArticulos();

            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "F2";

            OcultarColumnas();
            dgvArticulos.CurrentCell = dgvArticulos.Rows[0].Cells[1];
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto para modificar.", "Seleccione un producto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MostrarImagenNueva("");
            frmAgregar agregar = new frmAgregar((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
            agregar.ShowDialog();
            if (agregar.articuloActualizado)
            {
                ActualizarGrillaArticulos();
            }
            pbxArticulo.Refresh();
            CargarImagen((Articulo)dgvArticulos.CurrentRow.DataBoundItem);
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto para eliminar.", "Seleccione un producto.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MostrarImagenNueva("");
            frmEliminar eliminar = new frmEliminar((Articulo)dgvArticulos.CurrentRow.DataBoundItem, listaImagenesTotales);
            eliminar.ShowDialog();
            if (eliminar.articuloEliminado)
            {
                ActualizarGrillaArticulos();
            }
        }

        private void btnModificarCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categoria = new frmCategorias();
            categoria.ShowDialog();
            ActualizarGrillaArticulos();
        }
        private void btnModificarMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marca = new frmMarcas();
            marca.ShowDialog();
            ActualizarGrillaArticulos();
        }

        private void txtBusquedaR_TextChanged(object sender, EventArgs e)
        {
            if (!seActivoElList)
                return;
            string texto = txtBusquedaR.Text.Trim().ToLower();

            if (texto.Length >= 3)
            {
                List<Articulo> listaFiltrada = new List<Articulo>();

                foreach (Articulo art in listaArticulosTotales)
                {
                    string nombre = art.Nombre.ToLower();
                    string marca = art.Marca.Descripcion.ToLower();
                    string categoria = art.Categoria.Descripcion.ToLower();
                    string descripcion = art.Categoria.Descripcion.ToLower();

                    if (nombre.Contains(texto) || marca.Contains(texto) || categoria.Contains(texto) || descripcion.Contains(texto))
                    {
                        listaFiltrada.Add(art);
                    }
                }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
            }
            else if (texto.Length == 0)
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaArticulosTotales;
            }
            OcultarColumnas();
        }

        private void btnBusquedaAv_Click(object sender, EventArgs e)
        {
            frmBusquedaAv busquedaAv = new frmBusquedaAv();
            ActualizarGrillaArticulos();
            busquedaAv.ShowDialog();

            if (busquedaAv.BusquedaRealizada)
            {
                Buscar(busquedaAv.CampoSeleccionado, busquedaAv.CriterioSeleccionado, busquedaAv.ValorBusqueda);
            }
        }
        private void Buscar(string campo, string criterio, string valor)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            valor = valor.Trim().ToLower();

            foreach (Articulo art in listaArticulosTotales)
            {
                switch (campo)
                {
                    case "Codigo":
                        if (CriterioTxt(art.Codigo, criterio, valor))
                            listaFiltrada.Add(art);
                        break;

                    case "Nombre":
                        if (CriterioTxt(art.Nombre, criterio, valor))
                            listaFiltrada.Add(art);
                        break;

                    case "Descripcion":
                        if (CriterioTxt(art.Descripcion, criterio, valor))
                            listaFiltrada.Add(art);
                        break;

                    case "Marca":
                        if (CriterioTxt(art.Marca.Descripcion, criterio, valor))
                            listaFiltrada.Add(art);
                        break;

                    case "Categoria":
                        if (CriterioTxt(art.Categoria.Descripcion, criterio, valor))
                            listaFiltrada.Add(art);
                        break;

                    case "Precio":
                        if (decimal.TryParse(valor, out decimal precio))
                        {
                            if (criterio == "Mayor a" && art.Precio > precio)
                                listaFiltrada.Add(art);
                            else if (criterio == "Menor a" && art.Precio < precio)
                                listaFiltrada.Add(art);
                            else if (criterio == "Igual a" && art.Precio == precio)
                                listaFiltrada.Add(art);
                        }
                        break;
                }
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }
        private bool CriterioTxt(string campo, string criterio, string valor)
        {
            if (string.IsNullOrEmpty(campo) || string.IsNullOrEmpty(valor))
                return false;

            campo = campo.ToLower();
            valor = valor.ToLower();

            bool cumple = (criterio == "Comienza con" && campo.StartsWith(valor)) ||
                          (criterio == "Termina con" && campo.EndsWith(valor)) ||
                          (criterio == "Contiene" && campo.Contains(valor));

            return cumple;
        }
    }
}
