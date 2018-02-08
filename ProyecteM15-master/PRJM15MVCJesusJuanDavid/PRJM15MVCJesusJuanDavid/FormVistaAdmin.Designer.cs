namespace PRJM15MVCJesusJuanDavid
{
    partial class FormVistaAdmin
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.labelClientes = new System.Windows.Forms.Label();
            this.labelPedidos = new System.Windows.Forms.Label();
            this.labelTitol = new System.Windows.Forms.Label();
            this.comboBoxRepartidores = new System.Windows.Forms.ComboBox();
            this.labelRepartidores = new System.Windows.Forms.Label();
            this.textBoxdescrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewClientes.MultiSelect = false;
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(165, 194);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // dataGridViewPedidos
            // 
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(202, 64);
            this.dataGridViewPedidos.MultiSelect = false;
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";
            this.dataGridViewPedidos.ReadOnly = true;
            this.dataGridViewPedidos.Size = new System.Drawing.Size(165, 194);
            this.dataGridViewPedidos.TabIndex = 1;
            // 
            // labelClientes
            // 
            this.labelClientes.AutoSize = true;
            this.labelClientes.Location = new System.Drawing.Point(9, 48);
            this.labelClientes.Name = "labelClientes";
            this.labelClientes.Size = new System.Drawing.Size(71, 13);
            this.labelClientes.TabIndex = 2;
            this.labelClientes.Text = "Taula Clients:";
            // 
            // labelPedidos
            // 
            this.labelPedidos.AutoSize = true;
            this.labelPedidos.Location = new System.Drawing.Point(199, 48);
            this.labelPedidos.Name = "labelPedidos";
            this.labelPedidos.Size = new System.Drawing.Size(78, 13);
            this.labelPedidos.TabIndex = 3;
            this.labelPedidos.Text = "Taula Pedidos:";
            // 
            // labelTitol
            // 
            this.labelTitol.AutoSize = true;
            this.labelTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitol.Location = new System.Drawing.Point(12, 9);
            this.labelTitol.Name = "labelTitol";
            this.labelTitol.Size = new System.Drawing.Size(176, 16);
            this.labelTitol.TabIndex = 4;
            this.labelTitol.Text = "Benvingut Administrador";
            // 
            // comboBoxRepartidores
            // 
            this.comboBoxRepartidores.FormattingEnabled = true;
            this.comboBoxRepartidores.Location = new System.Drawing.Point(425, 64);
            this.comboBoxRepartidores.Name = "comboBoxRepartidores";
            this.comboBoxRepartidores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRepartidores.TabIndex = 5;
            // 
            // labelRepartidores
            // 
            this.labelRepartidores.AutoSize = true;
            this.labelRepartidores.Location = new System.Drawing.Point(422, 48);
            this.labelRepartidores.Name = "labelRepartidores";
            this.labelRepartidores.Size = new System.Drawing.Size(70, 13);
            this.labelRepartidores.TabIndex = 6;
            this.labelRepartidores.Text = "Repartidores:";
            // 
            // textBoxdescrip
            // 
            this.textBoxdescrip.Location = new System.Drawing.Point(425, 173);
            this.textBoxdescrip.Name = "textBoxdescrip";
            this.textBoxdescrip.Size = new System.Drawing.Size(121, 20);
            this.textBoxdescrip.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descripcion:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Blue;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuardar.Location = new System.Drawing.Point(437, 235);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(88, 34);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // FormVistaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(579, 281);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxdescrip);
            this.Controls.Add(this.labelRepartidores);
            this.Controls.Add(this.comboBoxRepartidores);
            this.Controls.Add(this.labelTitol);
            this.Controls.Add(this.labelPedidos);
            this.Controls.Add(this.labelClientes);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FormVistaAdmin";
            this.Text = "FormVistaAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClientes;
        private System.Windows.Forms.Label labelPedidos;
        private System.Windows.Forms.Label labelTitol;
        private System.Windows.Forms.Label labelRepartidores;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewClientes;
        public System.Windows.Forms.DataGridView dataGridViewPedidos;
        public System.Windows.Forms.ComboBox comboBoxRepartidores;
        public System.Windows.Forms.TextBox textBoxdescrip;
        public System.Windows.Forms.Button buttonGuardar;
    }
}