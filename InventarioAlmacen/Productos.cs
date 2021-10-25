using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioAlmacen
{
    public partial class Productos : Form
    {
        AlmacenEntities db = new AlmacenEntities();
        public Productos()
        {
            InitializeComponent();
            getCombos();
            GetProductos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void GetProductos()
        {
            
                var productos = db.sp_get_productos().ToList();
                dgvRecords.DataSource = productos.ToList();
        }

        void getCombos()
        {
            var categoria = db.categoria.ToList();
            cbCategoria.ValueMember = "id";
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.DataSource = categoria;

            var marca = db.marca.ToList();
            cbMarca.ValueMember = "id";
            cbMarca.DisplayMember = "nombre";
            cbMarca.DataSource = marca;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        void Guardar()
        {
            try
            {
                db.sp_insert_productos(txtNombre.Text, txtModel.Text, txtPrecio.Text, Convert.ToInt32(cbCategoria.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue));
                db.SaveChanges();
                GetProductos();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al guardar");
                Console.WriteLine(e.Message);
            }

        }

        
    }
}
