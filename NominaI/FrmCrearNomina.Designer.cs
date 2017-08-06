namespace NominaI
{
    partial class FrmCrearNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearNomina));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCrearNomina = new System.Windows.Forms.Button();
            this.btnCancelarNomina = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Nomina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 129);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(367, 26);
            this.txtDescripcion.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCrearNomina);
            this.panel2.Controls.Add(this.btnCancelarNomina);
            this.panel2.Location = new System.Drawing.Point(12, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 89);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // btnCrearNomina
            // 
            this.btnCrearNomina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearNomina.BackgroundImage")));
            this.btnCrearNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearNomina.Location = new System.Drawing.Point(310, 11);
            this.btnCrearNomina.Name = "btnCrearNomina";
            this.btnCrearNomina.Size = new System.Drawing.Size(87, 67);
            this.btnCrearNomina.TabIndex = 1;
            this.btnCrearNomina.UseVisualStyleBackColor = true;
            this.btnCrearNomina.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // btnCancelarNomina
            // 
            this.btnCancelarNomina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarNomina.BackgroundImage")));
            this.btnCancelarNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarNomina.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCancelarNomina.Location = new System.Drawing.Point(72, 11);
            this.btnCancelarNomina.Name = "btnCancelarNomina";
            this.btnCancelarNomina.Size = new System.Drawing.Size(86, 67);
            this.btnCancelarNomina.TabIndex = 0;
            this.btnCancelarNomina.UseVisualStyleBackColor = true;
            this.btnCancelarNomina.Click += new System.EventHandler(this.btnCancelarNomina_Click);
            // 
            // FrmCrearNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 297);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmCrearNomina";
            this.Text = "FrmCrearNomina";
            this.Load += new System.EventHandler(this.FrmCrearNomina_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearNomina;
        private System.Windows.Forms.Button btnCancelarNomina;
    }
}