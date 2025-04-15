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
    public partial class frmAgregar : Form
    {
        public bool SeGuardoElArticulo { get; set; } = false;

        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();

            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Precio = decimal.Parse(txtPrecio.Text);
            articulo.Marca = (Marca)cboMarca.SelectedItem;
            articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

            List<string> imagenesUrls = new List<string>();
            foreach (string url in lbxImagenes.Items)  
            {
                imagenesUrls.Add(url);
            }

            ArticuloManager negocio = new ArticuloManager();
            try
            {
                negocio.agregarArticuloEImagenes(articulo, imagenesUrls);
                MessageBox.Show("Artículo agregado exitosamente.");
                SeGuardoElArticulo = true;
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            } 


              
        }


       

        private void frmAgregar_Load(object sender, EventArgs e)
        {

            txtNuevaCategoria.Visible = false;
            txtNuevaMarca.Visible = false;
            MarcaManager managerMarca = new MarcaManager();
            CategoriaManager managerCategoria = new CategoriaManager();
            try
            {
                cboMarca.DataSource = managerMarca.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = managerCategoria.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if(txtNuevaCategoria.Visible == false)
            {
                txtNuevaCategoria.Visible = true;
            }
            else
            {
                string nuevaCategoria = txtNuevaCategoria.Text;
                if (!string.IsNullOrEmpty(nuevaCategoria))
                {
                    CategoriaManager managerCategoria = new CategoriaManager();
                    managerCategoria.agregar(nuevaCategoria);

                    cboCategoria.DataSource = managerCategoria.listar();
                    cboCategoria.ValueMember = "Id";
                    cboCategoria.DisplayMember = "Descripcion";

                    txtNuevaCategoria.Visible = false;
                    txtNuevaCategoria.Clear();

                    MessageBox.Show("Categoría agregada correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre para la categoría.");
                }
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            
            if (txtNuevaMarca.Visible == false)
            {
                txtNuevaMarca.Visible = true;
            }
            else
            {
                string nuevaMarca = txtNuevaMarca.Text;
                if (!string.IsNullOrEmpty(nuevaMarca))
                {
                    
                    MarcaManager managerMarca = new MarcaManager();
                    managerMarca.agregar(nuevaMarca);

                    
                    cboMarca.DataSource = managerMarca.listar();
                    cboMarca.ValueMember = "Id";
                    cboMarca.DisplayMember = "Descripcion";

                    
                    txtNuevaMarca.Visible = false;
                    txtNuevaMarca.Clear();

                    MessageBox.Show("Marca agregada correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre para la marca.");
                }
            }
        }

        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxImagenes.SelectedItem != null)
            {
                string urlImagenSeleccionada = lbxImagenes.SelectedItem.ToString();
                cargarImagen(urlImagenSeleccionada);
            }
        }

        private void txtRutaImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtRutaImagen.Text);
        }

        
        private void cargarImagen(string urlImagenSeleccionada)
        {
            try
            {
                pbxImagen.Load(urlImagenSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                pbxImagen.Load("https://ih1.redbubble.net/image.4905811447.8675/flat,750x,075,f-pad,750x1000,f8f8f8.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            string urlImagen = txtRutaImagen.Text.Trim();

            if (string.IsNullOrEmpty(urlImagen))
            {
                MessageBox.Show("Por favor, ingrese una URL válida de imagen.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if((txtRutaImagen.Text.ToUpper().Contains("HTTP")) || (txtRutaImagen.Text.ToUpper().Contains("HTTPS")))
            {
                if (!lbxImagenes.Items.Contains(urlImagen))
                {
                    lbxImagenes.Items.Add(urlImagen);
                    txtRutaImagen.Clear();  
                }
                else
                {
                    MessageBox.Show("La imagen ya está en la lista.", "URL duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una URL válida de imagen.", "URL inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
