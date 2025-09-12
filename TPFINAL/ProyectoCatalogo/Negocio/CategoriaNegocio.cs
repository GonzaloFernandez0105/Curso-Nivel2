using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Net;

namespace Negocio
{
    public class CategoriaNegocio
    {
      public  List<Categoria> listarCategoria()
        {
            List <Categoria> lista = new List <Categoria> ();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetearConsulta("select Id, Descripcion from CATEGORIAS");
                Datos.EjecutarLectura();

                while(Datos.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.Id = (int)Datos.Lector["Id"];
                    aux.Descripcion = (string)Datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Datos.CerrarConexion();
            }
           
        }
        

        
    }
}
