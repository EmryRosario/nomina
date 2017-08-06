namespace NominaI
{
    partial class FrmEliminarNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarNomina));
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificarNomina = new System.Windows.Forms.Button();
            this.btnCancelarNomina = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(133, 122);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(367, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿Seguro que desea eliminar esta nomina?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnModificarNomina);
            this.panel2.Controls.Add(this.btnCancelarNomina);
            this.panel2.Location = new System.Drawing.Point(12, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 89);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(41, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // btnModificarNomina
            // 
            this.btnModificarNomina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarNomina.BackgroundImage")));
            this.btnModificarNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarNomina.Location = new System.Drawing.Point(310, 11);
            this.btnModificarNomina.Name = "btnModificarNomina";
            this.btnModificarNomina.Size = new System.Drawing.Size(87, 67);
            this.btnModificarNomina.TabIndex = 1;
            this.btnModificarNomina.UseVisualStyleBackColor = true;
            this.btnModificarNomina.Click += new System.EventHandler(this.btnModificarNomina_Click);
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
            // FrmEliminarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 297);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmEliminarNomina";
            this.Text = "FrmEliminarNomina";
            this.Load += new System.EventHandler(this.FrmEliminarNomina_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarNomina;
        private System.Windows.Forms.Button btnCancelarNomina;
    }
}