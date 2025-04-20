using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace Negocio
{
    public class CategoriaManager
    {
        public List<Categoria> listar()
        {

            List<Categoria> listaCategorias =  new List<Categoria>();

            AccesoADatos conexion = new AccesoADatos();

            try
            {
                conexion.setearConsulta("Select Id, Descripcion from Categorias");
                conexion.ejecutarQuery();
                while (conexion.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)conexion.Lector["Id"];
                    try
                    {
                        aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    }
                    catch (Exception)
                    {
                        aux.Descripcion = "Error al leer la categoría";
                    }
                    /*
                    if ((string)conexion.Lector["Descripcion"] == null)
                    {
                        aux.Descripcion = "Error al leer la categoría"; 
                    }
                    else
                    {
                        aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    }
                    */
                    listaCategorias.Add(aux);
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
            return listaCategorias;
        }

        public void agregar(string nombreCategoria)
        {
            AccesoADatos conexion = new AccesoADatos();
            try
            {
                string query = "Insert Into Categorias (Descripcion) Values (@Descripcion)";
                conexion.setearConsulta(query);
                conexion.limpiarParametros();
                conexion.agregarParametros("@Descripcion", nombreCategoria);
                conexion.ejecutarNonQuery();
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

        public void modificar(Categoria categoriaModificada)
        {
            AccesoADatos conexion = new AccesoADatos();
            try
            {
                string query = "Update Categorias Set Descripcion = @Descripcion where Id = @Id";
                conexion.setearConsulta(query);
                conexion.agregarParametros("@Id", categoriaModificada.Id);
                conexion.agregarParametros("@Descripcion", categoriaModificada.Descripcion);
                conexion.ejecutarNonQuery();
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

        public void eliminar(int IdCategoria)
        {
            AccesoADatos conexion = new AccesoADatos();
            try
            {
                string query = "Update Articulos set IdCategoria = -1 where IdCategoria = @IdCategoria";
                conexion.setearConsulta(query);
                conexion.agregarParametros("@IdCategoria", IdCategoria);
                conexion.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
            }

            try
            {
                string query = "Delete from Categorias where Id = @Id";
                conexion.setearConsulta(query);
                conexion.agregarParametros("@Id", IdCategoria);
                conexion.ejecutarNonQuery();
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
