using Dominio;
using Negocio;
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
    public partial class frmMarcas: Form
    {
        MarcaManager managerMarca = new MarcaManager();
        List<Marca> listaMarcas = new List<Marca>();
        public frmMarcas()
        {
            InitializeComponent();
            listaMarcas = managerMarca.listar();
            ocultarTodo();
            ajustarTamanios();
            rbtnAgregarMarca.Checked = true;
        }

        private void cargarMarcas()
        {
            cboMarcas.DataSource = null;
            cboMarcas.DataSource = managerMarca.listar();
            cboMarcas.ValueMember = "Id";
            cboMarcas.DisplayMember = "Descripcion";
        }

        private void ajustarTamanios()
        {
            Size = new Size(520, 180);
            cboMarcas.Location = new Point(220, 12);
            txtModificarMarca.Location = new Point(220, 38);
            btnModificarMarca.Location = new Point(220, 67);
            btnEliminarMarca.Location = new Point(220, 38);
        }
        private void rbtnAgregarMarca_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            txtAgregarMarca.Visible = true;
            btnAgregarMarca.Visible = true;
        }
        private void rbtnModificarMarca_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            cboMarcas.Visible = true;
            cargarMarcas();
            txtModificarMarca.Visible = true;
            btnModificarMarca.Visible = true;
            cboMarcas.SelectedIndex = 0;
        }

        private void rbtnEliminarMarca_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            cboMarcas.Visible = true;
            cargarMarcas();
            btnEliminarMarca.Visible = true;

        }

        public void ocultarTodo()
        {
            txtAgregarMarca.Visible = false;
            btnAgregarMarca.Visible = false;
            cboMarcas.Visible = false;
            txtModificarMarca.Visible = false;
            btnEliminarMarca.Visible = false;
            btnModificarMarca.Visible = false;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAgregarMarca.Text))
            {
                MarcaManager managerMarca = new MarcaManager();
                managerMarca.agregar(txtAgregarMarca.Text);
                MessageBox.Show("Marca agregada correctamente.");
                txtAgregarMarca.Clear();
                cargarMarcas();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para la marca.");
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtModificarMarca.Text))
            {
                MarcaManager managerMarca = new MarcaManager();
                listaMarcas[cboMarcas.SelectedIndex].Descripcion = txtModificarMarca.Text;
                managerMarca.modificar(listaMarcas[cboMarcas.SelectedIndex]);
                MessageBox.Show("Marca modificada correctamente.");
                txtModificarMarca.Clear();
                cargarMarcas();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre para la nueva marca.");
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaManager managerMarca = new MarcaManager();
            managerMarca.eliminar(Int32.Parse(cboMarcas.SelectedValue.ToString()));
            MessageBox.Show("Se ha eliminado la marca");
            cargarMarcas();
        }
    }
}
