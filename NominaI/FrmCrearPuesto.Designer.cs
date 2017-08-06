namespace NominaI
{
    partial class FrmCrearPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearPuesto));
            this.lblCabecera = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.txtSalarioMaximo = new System.Windows.Forms.TextBox();
            this.lblSalarioMaximo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearPuesto = new System.Windows.Forms.Button();
            this.btnCancelarPuesto = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera.Location = new System.Drawing.Point(133, 19);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(150, 25);
            this.lblCabecera.TabIndex = 0;
            this.lblCabecera.Text = "Crear Puesto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(21, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 18);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(148, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 26);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMinimo.Location = new System.Drawing.Point(148, 145);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(245, 26);
            this.txtSalarioMinimo.TabIndex = 4;
            this.txtSalarioMinimo.TextChanged += new System.EventHandler(this.txtSalarioMinimo_TextChanged);
            this.txtSalarioMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMinimo_KeyPress);
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMinimo.Location = new System.Drawing.Point(21, 149);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(121, 18);
            this.lblSalarioMinimo.TabIndex = 3;
            this.lblSalarioMinimo.Text = "Salario Minimo";
            // 
            // txtSalarioMaximo
            // 
            this.txtSalarioMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMaximo.Location = new System.Drawing.Point(148, 208);
            this.txtSalarioMaximo.Name = "txtSalarioMaximo";
            this.txtSalarioMaximo.Size = new System.Drawing.Size(245, 26);
            this.txtSalarioMaximo.TabIndex = 6;
            this.txtSalarioMaximo.TextChanged += new System.EventHandler(this.txtSalarioMaximo_TextChanged);
            this.txtSalarioMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMaximo_KeyPress);
            // 
            // lblSalarioMaximo
            // 
            this.lblSalarioMaximo.AutoSize = true;
            this.lblSalarioMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMaximo.Location = new System.Drawing.Point(17, 208);
            this.lblSalarioMaximo.Name = "lblSalarioMaximo";
            this.lblSalarioMaximo.Size = new System.Drawing.Size(125, 18);
            this.lblSalarioMaximo.TabIndex = 5;
            this.lblSalarioMaximo.Text = "Salario Maximo";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(21, 271);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(114, 18);
            this.lblDepartamento.TabIndex = 7;
            this.lblDepartamento.Text = "Departamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(148, 267);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(245, 26);
            this.cbDepartamento.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCrearPuesto);
            this.panel2.Controls.Add(this.btnCancelarPuesto);
            this.panel2.Location = new System.Drawing.Point(20, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 89);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // btnCrearPuesto
            // 
            this.btnCrearPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearPuesto.BackgroundImage")));
            this.btnCrearPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearPuesto.Location = new System.Drawing.Point(235, 20);
            this.btnCrearPuesto.Name = "btnCrearPuesto";
            this.btnCrearPuesto.Size = new System.Drawing.Size(74, 49);
            this.btnCrearPuesto.TabIndex = 1;
            this.btnCrearPuesto.UseVisualStyleBackColor = true;
            this.btnCrearPuesto.Click += new System.EventHandler(this.btnCrearPuesto_Click);
            // 
            // btnCancelarPuesto
            // 
            this.btnCancelarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarPuesto.BackgroundImage")));
            this.btnCancelarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarPuesto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCancelarPuesto.Location = new System.Drawing.Point(52, 20);
            this.btnCancelarPuesto.Name = "btnCancelarPuesto";
            this.btnCancelarPuesto.Size = new System.Drawing.Size(70, 49);
            this.btnCancelarPuesto.TabIndex = 0;
            this.btnCancelarPuesto.UseVisualStyleBackColor = true;
            this.btnCancelarPuesto.Click += new System.EventHandler(this.btnCancelarPuesto_Click);
            // 
            // FrmCrearPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.txtSalarioMaximo);
            this.Controls.Add(this.lblSalarioMaximo);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.lblSalarioMinimo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCabecera);
            this.Name = "FrmCrearPuesto";
            this.Text = "FrmCrearPuesto";
            this.Load += new System.EventHandler(this.FrmCrearPuesto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.TextBox txtSalarioMaximo;
        private System.Windows.Forms.Label lblSalarioMaximo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearPuesto;
        private System.Windows.Forms.Button btnCancelarPuesto;
    }
}