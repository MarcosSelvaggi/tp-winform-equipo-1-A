using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoADatos
    {
        private SqlConnection conexion;
        private SqlDataReader lector;
        public SqlCommand comando;

        public SqlDataReader Lector
        {
            get
            {
                return lector; 
            }
        }

        public void ConexionConLaDB()
        {
            conexion = new SqlConnection("server=localhost; database=CATALOGO_P3_DB; integrated security=true;");
            comando = new SqlCommand();
        }

        public void ejecturarQuery()
        {
            try
            {
                comando.Connection = conexion; 
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ejecutarNonQuery()
        {
            int filasAfectadas = 0;
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return filasAfectadas;
        }
        public void setearConsulta(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void agregarParametros(string key, object value)
        {
            comando.Parameters.AddWithValue(key, value);
        }

        public void cerrarConexion()
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }

    }
}
