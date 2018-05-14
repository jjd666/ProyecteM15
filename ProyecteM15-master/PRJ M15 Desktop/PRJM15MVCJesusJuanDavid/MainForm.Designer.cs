namespace PRJM15MVCJesusJuanDavid
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirRepartidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoAvanzadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inforepartidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(571, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // asToolStripMenuItem
            // 
            this.asToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.añadirRepartidorToolStripMenuItem,
            this.añadirPedidoToolStripMenuItem,
            this.modoAvanzadorToolStripMenuItem,
            this.inforepartidorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.asToolStripMenuItem.Name = "asToolStripMenuItem";
            this.asToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.asToolStripMenuItem.Text = "Menu";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            // 
            // añadirRepartidorToolStripMenuItem
            // 
            this.añadirRepartidorToolStripMenuItem.Name = "añadirRepartidorToolStripMenuItem";
            this.añadirRepartidorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.añadirRepartidorToolStripMenuItem.Text = "Añadir Repartidor";
            // 
            // añadirPedidoToolStripMenuItem
            // 
            this.añadirPedidoToolStripMenuItem.Name = "añadirPedidoToolStripMenuItem";
            this.añadirPedidoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.añadirPedidoToolStripMenuItem.Text = "Añadir Pedido";
            // 
            // modoAvanzadorToolStripMenuItem
            // 
            this.modoAvanzadorToolStripMenuItem.Name = "modoAvanzadorToolStripMenuItem";
            this.modoAvanzadorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modoAvanzadorToolStripMenuItem.Text = "Modo avanzado";
            // 
            // inforepartidorToolStripMenuItem
            // 
            this.inforepartidorToolStripMenuItem.Name = "inforepartidorToolStripMenuItem";
            this.inforepartidorToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.inforepartidorToolStripMenuItem.Text = "Info repartidor";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRJM15MVCJesusJuanDavid.Properties.Resources.Logoidea;
            this.pictureBox1.Location = new System.Drawing.Point(116, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(571, 232);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "J.J.D SOLUCIONS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem asToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem añadirRepartidorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem añadirPedidoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modoAvanzadorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolStripMenuItem inforepartidorToolStripMenuItem;
    }
}