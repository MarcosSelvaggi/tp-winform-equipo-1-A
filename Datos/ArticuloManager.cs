using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio;


namespace Dominio
{
    public class ArticuloManager
    {
        private List<Categoria> listaCategorias;
        private List<Marca> listaMarcas;

    public void ArticulosManager()
        {
            CategoriaManager categoriaManager = new CategoriaManager();
            MarcaManager marcaManager = new MarcaManager();

            listaCategorias = categoriaManager.listarCategorias();
            listaMarcas = marcaManager.listarMarcas();
        }
        public List<Articulo> listarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoADatos conexion = new AccesoADatos();

            try
            {
                string query = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio from Articulos";
                conexion.setearConsulta(query);
                conexion.ejecturarQuery();

                Articulo aux = new Articulo();

                while (conexion.Lector.Read())
                {
                    aux.Id = (int)conexion.Lector["Id"];
                    aux.Codigo = (string)conexion.Lector["Codigo"];
                    aux.Nombre = (string)conexion.Lector["Nombre"];
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    aux.IdCategoria = (int)conexion.Lector["IdCategoria"] - 1;
                    aux.IdMarca = (int)conexion.Lector["IdMarca"] - 1;
                    aux.Precio = Decimal.Parse(conexion.Lector["Precio"].ToString());

                    listaArticulos.Add(aux);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return listaArticulos;
        }
    }
}
