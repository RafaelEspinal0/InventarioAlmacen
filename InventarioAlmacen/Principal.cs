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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnFormAdmin_Click(object sender, EventArgs e)
        {
			Form formBG = new Form();
			using (Login login = new Login())
			{
				formBG.StartPosition = FormStartPosition.Manual;
				formBG.FormBorderStyle = FormBorderStyle.None;
				formBG.Opacity = .70d;
				formBG.BackColor = Color.Black;
				formBG.WindowState = FormWindowState.Maximized;
				formBG.TopMost = false;
				formBG.Location = this.Location;
				formBG.ShowInTaskbar = false;
				formBG.Show();

				login.Owner = formBG;
				login.ShowDialog();
				formBG.Dispose();
			}
		}
    }
}
