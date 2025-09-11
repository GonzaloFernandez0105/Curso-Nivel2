using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formCatalogo
{
    public partial class Form1 : Form
    {  private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private List<Articulo> ArtList;

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            ArtList = negocio.Listar();
            dgvArticulos.DataSource = ArtList;
            CargarImagen(ArtList[0].ImagenUrl);
          
            
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
           
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
         
            
        }
        private void CargarImagen(string Imagen)
        {
            try
            {  
              pbArticulo.Load(Imagen);

            }
            catch (Exception)
            {
                pbArticulo.Load("https://thumbs.dreamstime.com/b/default-image-icon-vector-missing-picture-page-website-design-mobile-app-no-photo-available-236105299.jpg");
            }
            
        }
    }
}
