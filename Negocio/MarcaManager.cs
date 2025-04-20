using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaManager
    {
        private AccesoADatos conexion = new AccesoADatos();
        public List<Marca> listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            //AccesoADatos conexion = new AccesoADatos();
            try
            {
                conexion.setearConsulta("Select Id, Descripcion from Marcas");
                conexion.ejecutarQuery();
                while (conexion.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)conexion.Lector["Id"];
                    try
                    {
                        aux.Descripcion = (string)conexion.Lector["Descripcion"];
                    }
                    catch (Exception)
                    {
                        aux.Descripcion = "Error al leer la marca";
                    }
                    //aux.Descripcion = (string)conexion.Lector["Descripcion"];

                    listaMarcas.Add(aux);
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

            return listaMarcas;
        }
        public void agregar(string nombreMarca)
        {
            try
            {
                string query = "Insert Into Marcas (Descripcion) Values (@Descripcion)";
                conexion.setearConsulta(query);
                conexion.limpiarParametros();
                conexion.agregarParametros("@Descripcion", nombreMarca);
                conexion.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void modificar(Marca marcaModificada)
        {
            AccesoADatos conexion = new AccesoADatos();
            try
            {
                string query = "Update Marcas Set Descripcion = @Descripcion where Id = @Id";
                conexion.setearConsulta(query);
                conexion.agregarParametros("@Id", marcaModificada.Id);
                conexion.agregarParametros("@Descripcion", marcaModificada.Descripcion);
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

        public void eliminar(int IdMarca)
        {
            AccesoADatos conexion = new AccesoADatos();
            try
            {
                string query = "Update Articulos set IdMarca = -1 where IdMarca = @IdMarca";
                conexion.setearConsulta(query);
                conexion.agregarParametros("@IdMarca", IdMarca);
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
                string query = "Delete from Marcas where Id = @Id";
                conexion.setearConsulta(query);
                conexion.agregarParametros("@Id", IdMarca);
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
