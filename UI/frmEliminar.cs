using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace UI
{
    public partial class frmEliminar : Form
    {
        public bool articuloEliminado { get; set; } = false; 
        private Articulo articuloAux = new Articulo();
        private List<Imagen> imagenesDelProducto = new List<Imagen>();
        public frmEliminar(Articulo articuloAEliminar, List<Imagen> listaImagenes)
        {
            InitializeComponent();
            lblNombreArticulo.Text = "Desea eliminar el artículo: " + articuloAEliminar.Nombre;
            articuloAux = articuloAEliminar;
            foreach (var item in listaImagenes)
            {
                if (item.IdArticulo == articuloAux.Id)
                {
                    imagenesDelProducto.Add(item);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Imagen> listaImagenes = new List<Imagen>();
                ImagenManager imagenManager = new ImagenManager();
                listaImagenes = imagenManager.listarImagenes(); 

                foreach(var item in listaImagenes)
                {
                    if(item.ImagenUrl.Contains(@"\Imagenes\Articulo"))
                    {
                        File.Delete(item.ImagenUrl);
                    }
                }

                ArticuloManager articuloManager = new ArticuloManager();
                MessageBox.Show("Se ha eliminado " + articuloManager.eliminarArticulo(articuloAux, imagenesDelProducto ) + " artículo.");
                articuloEliminado = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al eliminar el producto."); 
            }
            finally
            {
                Close();
            }
        }
    }
}
