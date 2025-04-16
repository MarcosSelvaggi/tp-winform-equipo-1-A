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
            cboCategorias.DataSource = null;
            cboCategorias.DataSource = managerCategoria.listar();
            cboCategorias.ValueMember = "Id";
            cboCategorias.DisplayMember = "Descripcion";
        }

        //Cambiar el formato de la ventana apenas carga, y de paso pone todos los botones superpuestos
        private void ajustarTamanios()
        {
            Size = new Size(370, 130);
            cboCategorias.Location = new Point(160, 12);
            txtModificarCategoria.Location = new Point(160, 38);
            btnModificarCategoria.Location = new Point(160, 67);
            btnEliminarCategoría.Location = new Point(160, 38);
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
                CategoriaManager managerCategoria = new CategoriaManager();
                managerCategoria.agregar(txtAgregarCategoria.Text);
                MessageBox.Show("Categoría agregada correctamente.");
                txtAgregarCategoria.Clear();
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
                CategoriaManager managerCategoria = new CategoriaManager();
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
            CategoriaManager managerCategoria = new CategoriaManager();
            managerCategoria.eliminar(Int32.Parse(cboCategorias.SelectedValue.ToString()));
            MessageBox.Show("Se ha eliminado la categoria");
        }
    }
}
