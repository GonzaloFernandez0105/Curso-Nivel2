using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace formCatalogo
{
    internal class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;

                conexion.ConnectionString = "server=GonzaPc\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Codigo, Nombre, Descripcion, Precio, ImagenUrl from ARTICULOS";
                comando.Connection = conexion;
                conexion.Open();
              
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Codigo = (string)lector["Codigo"];
                    articulo.Nombre = (string)lector["Nombre"];
                    articulo.Descripcion = (string)lector["Descripcion"];
                    articulo.Precio = (decimal)lector["Precio"];
                    articulo.ImagenUrl = (string)lector["ImagenUrl"];
                    listaArticulos.Add(articulo);
                }
                conexion.Close();
              


            }
            catch (Exception ex)
            {

                throw ex;
            }


    return listaArticulos;

          
        }

    }

}
