using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace Negocio
{
    internal class CategoriaManager
    {
        public List<Categoria> listarCategorias()
        {

            List<Categoria> listaCategorias =  new List<Categoria>();

            AccesoADatos conexion = new AccesoADatos();

            try
            {
                conexion.setearConsulta("Select Id, Descripcion from Categorias");
                conexion.ejecturarQuery();
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

            return listaCategorias;
        }

    }
}
