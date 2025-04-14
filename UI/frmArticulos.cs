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
        List<Imagen> listaImagenes = new List<Imagen>();
        string urlImagenCargada = "";
        int imagenesPorArticulo = 0;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnListaArt_Click(object sender, EventArgs e)
        {
            listaImagenes = imagenManager.listarImagenes();
            dgvArticulos.DataSource = articuloManager.listarArticulos();
            ocultarColumnas();
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                try
                {
                    foreach (var item in listaImagenes)
                    {
                        if (item.IdArticulo == seleccion.Id)
                        {
                            imagenesPorArticulo++;
                        }
                    }
                    foreach (var item in listaImagenes)
                    {
                        if (item.IdArticulo == seleccion.Id)
                        {
                            urlImagenCargada = item.ImagenUrl;
                            pbxArticulo.Load(urlImagenCargada);
                            break; //Una vez encontrada la imagen sale del foreach
                        }
                        //Esto es por si algún artículo no tiene una imagen cargada, evita que muestre la misma imagen del producto anterior
                        pbxArticulo.Load("https://ih1.redbubble.net/image.4905811447.8675/flat,750x,075,f-pad,750x1000,f8f8f8.jpg");
                    }
                }
                catch (Exception)
                {
                    pbxArticulo.Load("https://ih1.redbubble.net/image.4905811447.8675/flat,750x,075,f-pad,750x1000,f8f8f8.jpg");
                }
            }
            if (imagenesPorArticulo > 1)
            {
                btnDerecha.Visible = true;
                imagenesPorArticulo = 0;
            }
            else
            {
                btnDerecha.Visible = false;
                imagenesPorArticulo = 0;
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

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                foreach (var item in listaImagenes)
                {
                    if (item.ImagenUrl == urlImagenCargada)
                    {
                        urlImagenCargada = listaImagenes[listaImagenes.IndexOf(item) + 1].ImagenUrl;
                        pbxArticulo.Load(urlImagenCargada);
                        if (listaImagenes.IndexOf(item) + 2 == listaImagenes.Count() || listaImagenes[listaImagenes.IndexOf(item) + 2].IdArticulo != seleccion.Id)
                        {
                            btnDerecha.Visible = false;
                        }
                        break;
                    }
                }
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://ih1.redbubble.net/image.4905811447.8675/flat,750x,075,f-pad,750x1000,f8f8f8.jpg");
            }
            btnIzquierda.Visible = true;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            Articulo seleccion = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            try
            {
                foreach (var item in listaImagenes)
                {
                    if (item.ImagenUrl == urlImagenCargada)
                    {
                        if (listaImagenes.IndexOf(item) - 2 < 0 || listaImagenes[listaImagenes.IndexOf(item) - 2].IdArticulo != seleccion.Id)
                        {
                            btnIzquierda.Visible = false;
                        }
                        urlImagenCargada = listaImagenes[listaImagenes.IndexOf(item) - 1].ImagenUrl;
                        pbxArticulo.Load(urlImagenCargada);
                        
                        break;
                    }
                }
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://ih1.redbubble.net/image.4905811447.8675/flat,750x,075,f-pad,750x1000,f8f8f8.jpg");
            }
            btnDerecha.Visible = true;
        }

        private void cargarImagen(string urlImagen)
        {

        }
    }
}
