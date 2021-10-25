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
            this.dgvRecords.Columns["id"].Visible = false;
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
        void Editar()
        {
            if (lblId.Text != "")
            {
                try
                {
                    db.sp_update_productos(Convert.ToInt32(lblId.Text),txtNombre.Text, txtModel.Text, txtPrecio.Text, Convert.ToInt32(cbCategoria.SelectedValue), Convert.ToInt32(cbMarca.SelectedValue));
                    db.SaveChanges();
                    GetProductos();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al actualizar");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un dato de la tabla");
            }
           

        }
        void Eliminar()
        {
            if (lblId.Text != "")
            {
                try
                {
                    db.sp_delete_productos(Convert.ToInt32(lblId.Text));
                    db.SaveChanges();
                    GetProductos();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al eliminar");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un dato de la tabla");
            }


        }


        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = "";
                
                lblId.Text = dgvRecords.CurrentRow.Cells[5].Value.ToString();
                txtNombre.Text = dgvRecords.CurrentRow.Cells[0].Value.ToString();
                txtModel.Text = dgvRecords.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dgvRecords.CurrentRow.Cells[2].Value.ToString();
                cbCategoria.Text = dgvRecords.CurrentRow.Cells[4].Value.ToString();
                cbMarca.Text = dgvRecords.CurrentRow.Cells[3].Value.ToString();
            }
            catch(Exception r)
            {
                Console.WriteLine(r.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
