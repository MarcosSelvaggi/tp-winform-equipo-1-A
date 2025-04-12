using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class ArticuloManager
    {
        private List<Categoria> listaCategorias;
        private List<Marca> listaMarcas;

    public ArticuloManager()
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
                string query = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from Articulos";
                conexion.setearConsulta(query);
                conexion.ejecturarQuery();

                while (conexion.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    
                    aux.Id = (int)conexion.Lector["Id"];
                    aux.Codigo = (string)conexion.Lector["Codigo"];
                    aux.Nombre = (string)conexion.Lector["Nombre"];
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    aux.Categoria.Id = (int)conexion.Lector["IdCategoria"] - 1;
                    if (aux.Categoria.Id < listaCategorias.Count())
                    {
                        aux.Categoria.Descripcion = listaCategorias[aux.Categoria.Id].Descripcion;
                    }
                    else
                    {
                        aux.Categoria.Descripcion = "Error al cargar la categoría";
                    }
                    aux.Marca.Id = (int)conexion.Lector["IdMarca"] - 1;
                    if (aux.Marca.Id < listaCategorias.Count())
                    {
                        aux.Marca.Descripcion = listaCategorias[aux.Marca.Id].Descripcion;
                    }
                    else
                    {
                        aux.Marca.Descripcion = "Error al cargar la Marca";
                    }
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
