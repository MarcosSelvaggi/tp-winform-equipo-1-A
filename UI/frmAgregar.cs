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
using Helper;
using Negocio;

namespace UI
{
    public partial class frmAgregar : Form
    {
        ErrorProvider errorP = new ErrorProvider();
        public bool SeGuardoElArticulo { get; set; } = false;
        public bool articuloActualizado { get; set; } = false;
        private bool seCargoImagenLocal { get; set; } = false;

        private string ubicacionDeImagenes = @"..\..\..\Imagenes\Articulos";

        List<string> listaArchivosEliminados = new List<string> { };

        public frmAgregar()
        {
            InitializeComponent();
        }
        private Articulo articuloAux;
        public frmAgregar(Articulo articuloAModificar)
        {
            InitializeComponent();

            ImagenManager imagenManager = new ImagenManager();
            List<Imagen> listaImagenes = imagenManager.listarImagenes();

            btnAgregar.Text = "Modificar";

            txtCodigo.Text = articuloAModificar.Codigo;
            txtNombre.Text = articuloAModificar.Nombre;
            txtDescripcion.Text = articuloAModificar.Descripcion;
            txtPrecio.Text = articuloAModificar.Precio.ToString("F2");
            articuloAux = articuloAModificar;

            foreach (var item in listaImagenes)
            {
                if (item.IdArticulo == articuloAModificar.Id)
                {
                    lbxImagenes.Items.Add(item.ImagenUrl);

                }
            }
            if (lbxImagenes.Items.Count > 0)
            {
                lbxImagenes.SelectedIndex = 0;
                CargarImagen(lbxImagenes.SelectedItem.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validarFormulario())
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios correctamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (articuloAux == null)
            {
                ArticuloManager articuloManager = new ArticuloManager();
                List<Articulo> listaArticulos = new List<Articulo>();
                listaArticulos = articuloManager.listarArticulos();
                foreach (var item in listaArticulos)
                {
                    if (txtCodigo.Text.ToLower() == item.Codigo.ToLower() && txtNombre.Text.ToLower() == item.Nombre.ToLower())
                    {
                        MessageBox.Show("Ya hay un artículo con ese nombre y código.");
                        return;
                    }
                }
            }
            Articulo articulo = new Articulo();

            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Precio = decimal.Parse(txtPrecio.Text);
            articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
            articulo.Marca = (Marca)cboMarca.SelectedItem;
            if (articulo.Categoria == null || articulo.Categoria.Id <= 0)
            {
                MessageBox.Show("Debe seleccionar una Categoría válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (articulo.Marca == null || articulo.Marca.Id <= 0)
            {
                MessageBox.Show("Debe seleccionar una Marca válida.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            pbxImagen.Image = null;
            pbxImagen.Dispose();

            //foreach que se encarga de eliminar las imagenes que fueron borradas del list box 
            foreach (var archivoEliminado in listaArchivosEliminados)
            {
                if (File.Exists(archivoEliminado))
                    File.Delete(archivoEliminado);
            }

            List<string> imagenesUrls = new List<string>();
            int indexDeImagenes = 0; //Variable auxiliar para darle unicidad a cada imágen

            foreach (string url in lbxImagenes.Items)
            {
                //if (!url.Contains("www."))
                if ((url.ToUpper().Contains("HTTP://")) || (url.ToUpper().Contains("HTTPS://")) || (url.ToUpper().Contains("WWW.")))
                {
                    imagenesUrls.Add(url);
                }
                else if (url.Contains(ubicacionDeImagenes))
                {
                    imagenesUrls.Add(url);
                }
                else
                {
                    //liberarImagen();
                    /*if (!Directory.Exists(ubicacionDeImagenes))
                    {
                        DirectoryInfo directorio = new DirectoryInfo(ubicacionDeImagenes);
                        directorio.Create();
                    }/*

                    //imagenesUrls.Add(nuevaUbicacion);

                    /*if (File.Exists(nuevaUbicacion))
                    {
                        File.Delete(nuevaUbicacion);
                    }*/


                    string nuevaUbicacion = ubicacionDeImagenes + @"\Articulo_" + txtCodigo.Text + "_" + txtNombre.Text + "_" + indexDeImagenes;
                    try
                    {
                        if (!File.Exists(url))
                        {
                            MessageBox.Show("La imagen local no existe.");
                            continue;
                        }

                        if (!Directory.Exists(ubicacionDeImagenes))
                        {
                            DirectoryInfo directorio = new DirectoryInfo(ubicacionDeImagenes);
                            directorio.Create();
                        }

                        if (File.Exists(nuevaUbicacion))
                        {
                            File.Delete(nuevaUbicacion);
                        }

                        File.Copy(url, nuevaUbicacion, true);

                        imagenesUrls.Add(nuevaUbicacion);

                    }
                    catch (Exception ex)
                    {
                        //File.Create(nuevaUbicacion);
                        MessageBox.Show("Error al copiar la imagen local: " + ex.Message);
                    }
                }
                indexDeImagenes++;
            }

            ArticuloManager negocio = new ArticuloManager();
            try
            {
                if (articuloAux != null)
                {
                    articulo.Id = articuloAux.Id;
                    negocio.ModificarArticuloEImagenes(articulo, imagenesUrls);
                    MessageBox.Show("Artículo modificado.");
                    articuloActualizado = true;
                }
                else
                {
                    negocio.agregarArticuloEImagenes(articulo, imagenesUrls);
                    MessageBox.Show("Artículo agregado exitosamente.");
                    SeGuardoElArticulo = true;
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error tipo: " + ex);
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
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
            SeleccionarComboBox();
        }

        private void SeleccionarComboBox()
        {
            if (articuloAux != null)
            {
                if (cboCategoria.DataSource != null)
                    cboCategoria.SelectedValue = articuloAux.Categoria.Id;

                if (cboMarca.DataSource != null)
                    cboMarca.SelectedValue = articuloAux.Marca.Id;
            }
        }


        private void lbxImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxImagenes.SelectedItem != null)
            {
                string urlImagenSeleccionada = lbxImagenes.SelectedItem.ToString();
                CargarImagen(urlImagenSeleccionada);
            }
        }

        private void txtRutaImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtRutaImagen.Text);
        }


        private void CargarImagen(string urlImagenSeleccionada)
        {
            try
            {
                pbxImagen.Load(urlImagenSeleccionada);
            }
            catch (Exception)
            {
                //MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
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

        private void btnEliminarImagenSeleccionada_Click(object sender, EventArgs e)
        {
            if (lbxImagenes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una imagen para eliminar", "Selecione una opción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lbxImagenes.SelectedItem.ToString().Contains(@"\Imagenes\Articulos\"))
                {
                    listaArchivosEliminados.Add(lbxImagenes.SelectedItem.ToString());
                }

                lbxImagenes.Items.RemoveAt(lbxImagenes.SelectedIndex);
                if (lbxImagenes.Items.Count > 0)
                {
                    lbxImagenes.SelectedIndex = 0;
                    CargarImagen(lbxImagenes.SelectedItem.ToString());
                }
                else
                {
                    CargarImagen("");
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validar = Validadores.txtSoloNumeros(txtPrecio, e);
            if (!validar)
                errorP.SetError(txtPrecio, "Solo números positivos.");
            else
                errorP.Clear();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {

            if (Validadores.txtVacio(txtCodigo))
                errorP.SetError(txtCodigo, "No puede quedar vacío.");
            else
                errorP.Clear();

        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (Validadores.txtVacio(txtNombre))
                errorP.SetError(txtNombre, "No puede quedar vacío.");
            else
                errorP.Clear();
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (Validadores.txtVacio(txtPrecio))
                errorP.SetError(txtPrecio, "No puede quedar vacío");
            else
                errorP.Clear();
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (Validadores.txtVacio(txtDescripcion))
                errorP.SetError(txtDescripcion, "No puede quedar vacío");
            else
                errorP.Clear();
        }

        private bool validarFormulario()
        {
            bool camposValidos = true;
            errorP.Clear();

            if (Validadores.txtVacio(txtCodigo))
            {
                errorP.SetError(txtCodigo, "No puede quedar vacío.");
                camposValidos = false;
            }

            if (Validadores.txtVacio(txtNombre))
            {
                errorP.SetError(txtNombre, "No puede quedar vacío.");
                camposValidos = false;
            }

            if (Validadores.txtVacio(txtDescripcion))
            {
                errorP.SetError(txtDescripcion, "No puede quedar vacío.");
                camposValidos = false;
            }

            if (Validadores.txtVacio(txtPrecio))
            {
                errorP.SetError(txtPrecio, "No puede quedar vacío.");
                camposValidos = false;
            }
            return camposValidos;
        }

        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagenLocal = new OpenFileDialog();
            imagenLocal.Filter = "Imágenes(*.jpg, *.png, *.gif) | *.jpg; *.png; *.gif";
            {
                if (imagenLocal.ShowDialog() == DialogResult.OK)
                {
                    txtRutaImagen.Text = imagenLocal.FileName;
                    CargarImagen(txtRutaImagen.Text);
                    seCargoImagenLocal = true;
                }
            }
        }

    }
}
