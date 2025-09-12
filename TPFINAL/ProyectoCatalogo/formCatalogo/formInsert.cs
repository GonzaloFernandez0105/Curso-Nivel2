using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
namespace formCatalogo
{
    public partial class formInsert : Form
    {
        public formInsert()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo nuevo = new Articulo();
            try
            {
                 nuevo.Codigo = txtCodigo.Text;
                 nuevo.Nombre = txtNombre.Text;
                 nuevo.Descripcion = txtDescripcion.Text;
                 nuevo.Precio = decimal.Parse(txtPrecio.Text);

                negocio.AgregarArticulo(nuevo);
                MessageBox.Show("Se agrego correctamente");
                Close();

            }
            catch (Exception)
            {

                throw;
            }
            
            
        }
    }
}
