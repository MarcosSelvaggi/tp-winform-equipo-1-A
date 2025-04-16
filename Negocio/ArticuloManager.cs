using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using static System.Net.Mime.MediaTypeNames;


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

            listaCategorias = categoriaManager.listar();
            listaMarcas = marcaManager.listar();
        }
        
        public List<Articulo> listarArticulos()
        {
            CategoriaManager categoriaManager = new CategoriaManager();
            MarcaManager marcaManager = new MarcaManager();

            listaCategorias = categoriaManager.listar();
            listaMarcas = marcaManager.listar();

            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoADatos conexion = new AccesoADatos();

            try
            {
                string query = "Select Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from Articulos";
                conexion.setearConsulta(query);
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    
                    aux.Id = (int)conexion.Lector["Id"];
                    aux.Codigo = (string)conexion.Lector["Codigo"];
                    aux.Nombre = (string)conexion.Lector["Nombre"];
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    /*aux.Categoria.Id = (int)conexion.Lector["IdCategoria"] - 1;                    
                    if (aux.Categoria.Id < listaCategorias.Count())
                    {
                        aux.Categoria.Descripcion = listaCategorias[aux.Categoria.Id].Descripcion;
                    }
                    else
                    {
                        aux.Categoria.Descripcion = "Error al cargar la categoría.";
                    }
                    aux.Marca.Id = (int)conexion.Lector["IdMarca"] - 1;
                    if (aux.Marca.Id < listaCategorias.Count())
                    {
                        aux.Marca.Descripcion = listaMarcas[aux.Marca.Id].Descripcion;
                     }
                    else
                    {
                        aux.Marca.Descripcion = "Error al cargar la Marca.";
                    }*/

                    
                    int idCategoria = (int)conexion.Lector["IdCategoria"];
                    aux.Categoria.Id = idCategoria;
                    bool encontroCategoria = false;

                    foreach (Categoria cat in listaCategorias)
                    {
                        if (cat.Id == idCategoria)
                        {
                            aux.Categoria.Descripcion = cat.Descripcion;
                            encontroCategoria = true;
                            break;
                        }
                    }

                    if (!encontroCategoria)
                        aux.Categoria.Descripcion = "Error al cargar la categoría.";

                    
                    int idMarca = (int)conexion.Lector["IdMarca"];
                    aux.Marca.Id = idMarca;
                    bool encontroMarca = false;

                    foreach (Marca m in listaMarcas)
                    {
                        if (m.Id == idMarca)
                        {
                            aux.Marca.Descripcion = m.Descripcion;
                            encontroMarca = true;
                            break;
                        }
                    }

                    if (!encontroMarca)
                        aux.Marca.Descripcion = "Error al cargar la Marca.";

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

        public void agregarArticuloEImagenes(Articulo articulo, List<string> imagenesUrls)
        {
            AccesoADatos accesoADatos = new AccesoADatos();
            try
            {
                string query = "Insert Into Articulos (Codigo, Nombre, Descripcion, Precio, IdMarca, IdCategoria) " +
                               "Values (@Codigo, @Nombre, @Descripcion, @Precio, @IdMarca, @IdCategoria); " +
                               "Select Scope_Identity();";

                accesoADatos.setearConsulta(query);
                accesoADatos.agregarParametros("@Codigo", articulo.Codigo);
                accesoADatos.agregarParametros("@Nombre", articulo.Nombre);
                accesoADatos.agregarParametros("@Descripcion", articulo.Descripcion);
                accesoADatos.agregarParametros("@Precio", articulo.Precio);
                accesoADatos.agregarParametros("@IdMarca", articulo.Marca.Id);
                accesoADatos.agregarParametros("@IdCategoria", articulo.Categoria.Id);

                
                object resultado = accesoADatos.EjecutarScalar();
                int articuloId = Convert.ToInt32(resultado); 

                
                foreach (var imagenUrl in imagenesUrls)
                {
                    accesoADatos.limpiarParametros();
                    query = "Insert Into Imagenes (IdArticulo, ImagenUrl) Values (@IdArticulo, @ImagenUrl)";
                    accesoADatos.setearConsulta(query);
                    accesoADatos.agregarParametros("@IdArticulo", articuloId);
                    accesoADatos.agregarParametros("@ImagenUrl", imagenUrl);
                    accesoADatos.ejecutarNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el artículo e imágenes", ex);
            }
            finally
            {
                accesoADatos.cerrarConexion();  
            }
        }
        public void ModificarArticuloEImagenes(Articulo articulo, List<string> imagenesNuevas) 
        {
            AccesoADatos conexion = new AccesoADatos();
            try
            {
                string query = "UPDATE Articulos SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, " +
                               "Precio = @Precio, IdMarca = @IdMarca, IdCategoria = @IdCategoria WHERE Id = @Id";

                conexion.setearConsulta(query);
                conexion.limpiarParametros();
                conexion.agregarParametros("@Codigo", articulo.Codigo);
                conexion.agregarParametros("@Nombre", articulo.Nombre);
                conexion.agregarParametros("@Descripcion", articulo.Descripcion);
                conexion.agregarParametros("@Precio", articulo.Precio);
                conexion.agregarParametros("@IdMarca", articulo.Marca.Id);
                conexion.agregarParametros("@IdCategoria", articulo.Categoria.Id);
                conexion.agregarParametros("@Id", articulo.Id);
                conexion.ejecutarNonQuery();

                query = "DELETE FROM Imagenes WHERE IdArticulo = @IdArticulo";
                conexion.setearConsulta(query);
                conexion.limpiarParametros();
                conexion.agregarParametros("@IdArticulo", articulo.Id);
                conexion.ejecutarNonQuery();

                foreach (string imagen in imagenesNuevas)
                {
                    query = "INSERT INTO Imagenes (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)";
                    conexion.setearConsulta(query);
                    conexion.limpiarParametros();
                    conexion.agregarParametros("@IdArticulo", articulo.Id);
                    conexion.agregarParametros("@ImagenUrl", imagen);
                    conexion.ejecutarNonQuery();
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
        }
    }
}
