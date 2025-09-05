using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConectandoDB
{
    internal class ListaDeProductos
    {

        public List<Producto> Listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            List<Producto> productos = new List<Producto>();
            try
            {
                conexion.ConnectionString = "server=GONZAPC\\SQLEXPRESS; database=PuntoDeVenta; integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre, CodigoSKU, PrecioUnitario, StockDisponible from Producto;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Producto producto = new Producto();
                    producto.Nombre = (string)lector["Nombre"];
                    producto.CodigoSKU = Convert.ToInt64(lector["CodigoSKU"]);
                    producto.PrecioUnitario = Convert.ToInt32(lector["PrecioUnitario"]);
                    producto.StockDisponible = Convert.ToInt32(lector["StockDisponible"]);

                    productos.Add(producto);
                }

                conexion.Close();
                return productos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}
