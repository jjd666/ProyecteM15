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
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.labelTitol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.Blue;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClient.Location = new System.Drawing.Point(12, 55);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(88, 34);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Blue;
            this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdmin.Location = new System.Drawing.Point(160, 55);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(88, 34);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            // 
            // labelTitol
            // 
            this.labelTitol.AutoSize = true;
            this.labelTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitol.Location = new System.Drawing.Point(95, 22);
            this.labelTitol.Name = "labelTitol";
            this.labelTitol.Size = new System.Drawing.Size(76, 16);
            this.labelTitol.TabIndex = 2;
            this.labelTitol.Text = "Benvingut";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(262, 121);
            this.Controls.Add(this.labelTitol);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonClient);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Label labelTitol;
    }
}