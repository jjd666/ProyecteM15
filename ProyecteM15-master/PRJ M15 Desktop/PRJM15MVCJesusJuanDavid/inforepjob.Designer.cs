namespace PRJM15MVCJesusJuanDavid
{
    partial class inforepjob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inforepjob));
            this.dataGridViewrepjob = new System.Windows.Forms.DataGridView();
            this.comboBoxrep = new System.Windows.Forms.ComboBox();
            this.checkBoxpendiente = new System.Windows.Forms.CheckBox();
            this.checkBoxterminiado = new System.Windows.Forms.CheckBox();
            this.buttoncercar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrepjob)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewrepjob
            // 
            this.dataGridViewrepjob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewrepjob.Location = new System.Drawing.Point(12, 120);
            this.dataGridViewrepjob.Name = "dataGridViewrepjob";
            this.dataGridViewrepjob.Size = new System.Drawing.Size(704, 244);
            this.dataGridViewrepjob.TabIndex = 0;
            // 
            // comboBoxrep
            // 
            this.comboBoxrep.FormattingEnabled = true;
            this.comboBoxrep.Location = new System.Drawing.Point(255, 32);
            this.comboBoxrep.Name = "comboBoxrep";
            this.comboBoxrep.Size = new System.Drawing.Size(121, 21);
            this.comboBoxrep.TabIndex = 1;
            // 
            // checkBoxpendiente
            // 
            this.checkBoxpendiente.AutoSize = true;
            this.checkBoxpendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxpendiente.Location = new System.Drawing.Point(444, 80);
            this.checkBoxpendiente.Name = "checkBoxpendiente";
            this.checkBoxpendiente.Size = new System.Drawing.Size(142, 20);
            this.checkBoxpendiente.TabIndex = 2;
            this.checkBoxpendiente.Text = "Mostrar pendientes";
            this.checkBoxpendiente.UseVisualStyleBackColor = true;
            // 
            // checkBoxterminiado
            // 
            this.checkBoxterminiado.AutoSize = true;
            this.checkBoxterminiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxterminiado.Location = new System.Drawing.Point(444, 32);
            this.checkBoxterminiado.Name = "checkBoxterminiado";
            this.checkBoxterminiado.Size = new System.Drawing.Size(128, 20);
            this.checkBoxterminiado.TabIndex = 3;
            this.checkBoxterminiado.Text = "Mostrar entregas";
            this.checkBoxterminiado.UseVisualStyleBackColor = true;
            // 
            // buttoncercar
            // 
            this.buttoncercar.BackColor = System.Drawing.Color.Blue;
            this.buttoncercar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncercar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttoncercar.Location = new System.Drawing.Point(622, 45);
            this.buttoncercar.Name = "buttoncercar";
            this.buttoncercar.Size = new System.Drawing.Size(83, 37);
            this.buttoncercar.TabIndex = 4;
            this.buttoncercar.Text = "Cercar";
            this.buttoncercar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Información Repartidores";
            // 
            // inforepjob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttoncercar);
            this.Controls.Add(this.checkBoxterminiado);
            this.Controls.Add(this.checkBoxpendiente);
            this.Controls.Add(this.comboBoxrep);
            this.Controls.Add(this.dataGridViewrepjob);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inforepjob";
            this.Text = "inforepjob";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrepjob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewrepjob;
        public System.Windows.Forms.ComboBox comboBoxrep;
        public System.Windows.Forms.CheckBox checkBoxpendiente;
        public System.Windows.Forms.CheckBox checkBoxterminiado;
        public System.Windows.Forms.Button buttoncercar;
        private System.Windows.Forms.Label label1;
    }
}