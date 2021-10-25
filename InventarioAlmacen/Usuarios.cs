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
    public partial class Usuarios : Form
    {
        AlmacenEntities db = new AlmacenEntities();
        public Usuarios()
        {
            InitializeComponent();
            GetUsuarios();
            this.dgvRecords.Columns["contraseña"].Visible = false;
            this.dgvRecords.Columns["id"].Visible = false;
        }
        void GetUsuarios()
        {

            var usuarios = db.sp_get_usuario().ToList();
            dgvRecords.DataSource = usuarios.ToList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        void Guardar()
        {
            try
            {
                db.sp_insert_usuarios(txtNombre.Text, txtUsername.Text, txtPassword.Text, txtEmail.Text);
                db.SaveChanges();
                GetUsuarios();
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
                    db.sp_update_usuarios(Convert.ToInt32(lblId.Text), txtNombre.Text, txtUsername.Text, txtPassword.Text, txtEmail.Text);
                    db.SaveChanges();
                    GetUsuarios();
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
                    db.sp_delete_usuarios(Convert.ToInt32(lblId.Text));
                    db.SaveChanges();
                    GetUsuarios();
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

                lblId.Text = dgvRecords.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvRecords.CurrentRow.Cells[1].Value.ToString();
                txtUsername.Text = dgvRecords.CurrentRow.Cells[2].Value.ToString();
                txtPassword.Text = dgvRecords.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dgvRecords.CurrentRow.Cells[4].Value.ToString();
                
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }
        }
    }
}
