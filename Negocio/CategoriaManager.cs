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
                    aux.Descripcion = (string)conexion.Lector["Descripcion"];
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
                conexion.agregarParametros("@Descripcion", nombreCategoria);
                conexion.ejecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
