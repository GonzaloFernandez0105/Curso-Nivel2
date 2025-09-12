using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
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
                comando.CommandText = "SELECT    A.Codigo,A.Nombre, A.Descripcion, A.Precio, A.ImagenUrl, C.Descripcion AS Categoria, M.Descripcion AS Marca FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN MARCAS M ON A.IdMarca = M.Id;";
                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Codigo = (string)lector["Codigo"];
                    articulo.Nombre = (string)lector["Nombre"];
                    articulo.Marca = (string)lector["Marca"];
                    articulo.Descripcion = (string)lector["Descripcion"];
                    articulo.Precio = (decimal)lector["Precio"];
                    articulo.Tipo = new Categoria();
                    articulo.Tipo.Descripcion = (string)lector["Categoria"];
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

        public void AgregarArticulo(Articulo nuevo)
        {
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.SetearConsulta($"INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, Precio) VALUES ('{nuevo.Codigo}', '{nuevo.Nombre}','{nuevo.Descripcion}',{nuevo.Precio})");
                dato.EjecutarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { dato.CerrarConexion(); }
        }

       

        /*public void ModificarArticulo(Articulo modificar)
        {

        }*/

    }


}

