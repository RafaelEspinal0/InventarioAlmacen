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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnMant_Click(object sender, EventArgs e)
        {
            subMant.Visible = true;
        }
        void abrirForm(object form)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(f);
            this.panelContenedor.Tag = f;
            f.Show();
        }


        private void panelContenedor_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
        }

        private void btnMProd_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
            abrirForm(new Productos());
        }

        private void btnMUser_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
            abrirForm(new Usuarios());

        }

        private void btnMMar_Click(object sender, EventArgs e)
        {
            subMant.Visible = false;
            abrirForm(new Marcas());
        }
    }
}
