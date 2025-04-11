using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Dominio; 

namespace Dominio
{
    internal class CategoriaManager
    {
        public List<Categoria> listarCategorias()
        {

            List<Categoria> listaCategorias =  new List<Categoria>();

            AccesoADatos conexion = new Datos.AccesoADatos();

            try
            {
                conexion.setearConsulta("Select Id, Descripcion from Categorias");
                conexion.ejecturarQuery();
                Categoria aux = new Categoria(); 
                while (conexion.Lector.Read())
                {
                    aux.Id = (int)conexion.Lector["Id"];
                    aux.Descripcion = (string)conexion.Lector["Description"];
                }
                listaCategorias.Add(aux);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaCategorias;
        }

    }
}
