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
    public partial class frmCategorias : Form
    {
        CategoriaManager managerCategoria = new CategoriaManager();
        List<Categoria> listaCategorias = new List<Categoria>();
        public frmCategorias()
        {
            InitializeComponent();
            listaCategorias = managerCategoria.listar();
            ocultarTodo();
            ajustarTamanios();
            rbtnAgregarCategoria.Checked = true; //Para que empiece con el primer check listo
        }

        private void cargarCategorias()
        {
            listaCategorias = managerCategoria.listar();
            cboCategorias.DataSource = null;
            cboCategorias.DataSource = managerCategoria.listar();
            cboCategorias.ValueMember = "Id";
            cboCategorias.DisplayMember = "Descripcion";
        }

        //Cambiar el formato de la ventana apenas carga, y de paso pone todos los botones superpuestos
        private void ajustarTamanios()
        {
            Size = new Size(520, 180);
            cboCategorias.Location = new Point(220, 12);
            txtModificarCategoria.Location = new Point(220, 38);
            btnModificarCategoria.Location = new Point(220, 67);
            btnEliminarCategoría.Location = new Point(220, 38);
        }

        private void rbtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            txtAgregarCategoria.Visible = true;
            btnAgregarCategoria.Visible = true;
        }

        private void rbtnModificarCategoria_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            cboCategorias.Visible = true;
            cargarCategorias();
            txtModificarCategoria.Visible = true;
            btnModificarCategoria.Visible = true;
            cboCategorias.SelectedIndex = 0;
        }

        private void rbtnEliminarCategoria_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            cboCategorias.Visible = true;
            cargarCategorias();
            btnEliminarCategoría.Visible = true;

        }

        public void ocultarTodo()
        {
            txtAgregarCategoria.Visible = false;
            btnAgregarCategoria.Visible = false;
            cboCategorias.Visible = false;
            txtModificarCategoria.Visible = false;
            btnEliminarCategoría.Visible = false;
            btnModificarCategoria.Visible = false;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAgregarCategoria.Text))
            {
                //CategoriaManager managerCategoria = new CategoriaManager();

                string nuevaCategoria = txtAgregarCategoria.Text;
                bool yaExiste = false;

                foreach (Categoria categoria in listaCategorias)
                {
                    if (categoria.Descripcion != null && categoria.Descripcion.ToLower() == nuevaCategoria.ToLower())
                    {
                        yaExiste = true;
                        break;
                    }
                }

                if (yaExiste)
                {
                    MessageBox.Show("Esa categoría ya existe.");
                    return;
                }

                managerCategoria.agregar(nuevaCategoria);
                MessageBox.Show("Categoría agregada correctamente.");
                txtAgregarCategoria.Clear();
                cargarCategorias();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para la categoría.");
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtModificarCategoria.Text))
            {
                //CategoriaManager managerCategoria = new CategoriaManager();
                listaCategorias[cboCategorias.SelectedIndex].Descripcion = txtModificarCategoria.Text;
                managerCategoria.modificar(listaCategorias[cboCategorias.SelectedIndex]);
                MessageBox.Show("Categoría modificada correctamente.");
                txtModificarCategoria.Clear();
                cargarCategorias();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para la nueva categoría.");
            }
        }

        private void btnEliminarCategoría_Click(object sender, EventArgs e)
        {
            //CategoriaManager managerCategoria = new CategoriaManager();
            managerCategoria.eliminar(Int32.Parse(cboCategorias.SelectedValue.ToString()));
            MessageBox.Show("Se ha eliminado la categoria");
            cargarCategorias();
        }
    }
}
