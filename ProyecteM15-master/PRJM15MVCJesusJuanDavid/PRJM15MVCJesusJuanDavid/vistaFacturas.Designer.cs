namespace PRJM15MVCJesusJuanDavid
{
    partial class vistaFacturas
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
            this.dataGridViewFacturasClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturasClient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFacturasClient
            // 
            this.dataGridViewFacturasClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturasClient.Location = new System.Drawing.Point(27, 96);
            this.dataGridViewFacturasClient.MultiSelect = false;
            this.dataGridViewFacturasClient.Name = "dataGridViewFacturasClient";
            this.dataGridViewFacturasClient.ReadOnly = true;
            this.dataGridViewFacturasClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFacturasClient.Size = new System.Drawing.Size(602, 220);
            this.dataGridViewFacturasClient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.505F);
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "insertname";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(609, 350);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // vistaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 426);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFacturasClient);
            this.Name = "vistaFacturas";
            this.Text = "vistaFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturasClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewFacturasClient;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonSalir;
    }
}