
namespace InventarioAlmacen
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMant = new System.Windows.Forms.Button();
            this.subMant = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnMMar = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnMUser = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subMant.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido";
            // 
            // btnMant
            // 
            this.btnMant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.btnMant.FlatAppearance.BorderSize = 0;
            this.btnMant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMant.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMant.Location = new System.Drawing.Point(509, 63);
            this.btnMant.Name = "btnMant";
            this.btnMant.Size = new System.Drawing.Size(158, 33);
            this.btnMant.TabIndex = 2;
            this.btnMant.Text = "Mantenimientos";
            this.btnMant.UseVisualStyleBackColor = false;
            this.btnMant.Click += new System.EventHandler(this.btnMant_Click);
            // 
            // subMant
            // 
            this.subMant.Controls.Add(this.panel8);
            this.subMant.Controls.Add(this.btnMMar);
            this.subMant.Controls.Add(this.panel7);
            this.subMant.Controls.Add(this.panel6);
            this.subMant.Controls.Add(this.btnMProd);
            this.subMant.Controls.Add(this.btnMUser);
            this.subMant.Location = new System.Drawing.Point(509, 92);
            this.subMant.Name = "subMant";
            this.subMant.Size = new System.Drawing.Size(158, 94);
            this.subMant.TabIndex = 4;
            this.subMant.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.panel8.Location = new System.Drawing.Point(3, 61);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 27);
            this.panel8.TabIndex = 9;
            // 
            // btnMMar
            // 
            this.btnMMar.BackColor = System.Drawing.Color.White;
            this.btnMMar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMMar.FlatAppearance.BorderSize = 0;
            this.btnMMar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.btnMMar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMar.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMar.ForeColor = System.Drawing.Color.Black;
            this.btnMMar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMMar.Location = new System.Drawing.Point(11, 61);
            this.btnMMar.Name = "btnMMar";
            this.btnMMar.Size = new System.Drawing.Size(144, 27);
            this.btnMMar.TabIndex = 8;
            this.btnMMar.Text = "Mantenimiento marcas";
            this.btnMMar.UseVisualStyleBackColor = false;
            this.btnMMar.Click += new System.EventHandler(this.btnMMar_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.panel7.Location = new System.Drawing.Point(3, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 27);
            this.panel7.TabIndex = 7;
            // 
            // btnMUser
            // 
            this.btnMUser.BackColor = System.Drawing.Color.White;
            this.btnMUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMUser.FlatAppearance.BorderSize = 0;
            this.btnMUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.btnMUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMUser.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUser.ForeColor = System.Drawing.Color.Black;
            this.btnMUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMUser.Location = new System.Drawing.Point(11, 32);
            this.btnMUser.Name = "btnMUser";
            this.btnMUser.Size = new System.Drawing.Size(144, 27);
            this.btnMUser.TabIndex = 6;
            this.btnMUser.Text = "Mantenimiento usuarios";
            this.btnMUser.UseVisualStyleBackColor = false;
            this.btnMUser.Click += new System.EventHandler(this.btnMUser_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(0, 99);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 406);
            this.panelContenedor.TabIndex = 5;
            this.panelContenedor.Click += new System.EventHandler(this.panelContenedor_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 27);
            this.panel6.TabIndex = 5;
            // 
            // btnMProd
            // 
            this.btnMProd.BackColor = System.Drawing.Color.White;
            this.btnMProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMProd.FlatAppearance.BorderSize = 0;
            this.btnMProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(203)))), ((int)(((byte)(113)))));
            this.btnMProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMProd.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMProd.ForeColor = System.Drawing.Color.Black;
            this.btnMProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMProd.Location = new System.Drawing.Point(11, 3);
            this.btnMProd.Name = "btnMProd";
            this.btnMProd.Size = new System.Drawing.Size(144, 27);
            this.btnMProd.TabIndex = 4;
            this.btnMProd.Text = "Mantenimiento productos";
            this.btnMProd.UseVisualStyleBackColor = false;
            this.btnMProd.Click += new System.EventHandler(this.btnMProd_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.subMant);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.btnMant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Click += new System.EventHandler(this.btnMant_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subMant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMant;
        private System.Windows.Forms.Panel subMant;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnMMar;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnMUser;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnMProd;
    }
}