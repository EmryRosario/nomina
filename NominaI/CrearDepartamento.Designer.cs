namespace NominaI
{
    partial class CrearDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearDepartamento));
            this.lblDepartamentoDescripcion = new System.Windows.Forms.Label();
            this.lblNuevoDepartamento = new System.Windows.Forms.Label();
            this.txtDescripcionDepartamento = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacionDepartamento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearDepartamento = new System.Windows.Forms.Button();
            this.btnCancelarDepartamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDepartamentoDescripcion
            // 
            this.lblDepartamentoDescripcion.AutoSize = true;
            this.lblDepartamentoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoDescripcion.Location = new System.Drawing.Point(5, 32);
            this.lblDepartamentoDescripcion.Name = "lblDepartamentoDescripcion";
            this.lblDepartamentoDescripcion.Size = new System.Drawing.Size(193, 16);
            this.lblDepartamentoDescripcion.TabIndex = 0;
            this.lblDepartamentoDescripcion.Text = "Descripcion Departamento";
            this.lblDepartamentoDescripcion.Click += new System.EventHandler(this.lblDepartamentoDescripcion_Click);
            // 
            // lblNuevoDepartamento
            // 
            this.lblNuevoDepartamento.AutoSize = true;
            this.lblNuevoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoDepartamento.Location = new System.Drawing.Point(142, 24);
            this.lblNuevoDepartamento.Name = "lblNuevoDepartamento";
            this.lblNuevoDepartamento.Size = new System.Drawing.Size(233, 25);
            this.lblNuevoDepartamento.TabIndex = 1;
            this.lblNuevoDepartamento.Text = "Nuevo Departamento";
            // 
            // txtDescripcionDepartamento
            // 
            this.txtDescripcionDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDepartamento.Location = new System.Drawing.Point(204, 26);
            this.txtDescripcionDepartamento.Name = "txtDescripcionDepartamento";
            this.txtDescripcionDepartamento.Size = new System.Drawing.Size(276, 26);
            this.txtDescripcionDepartamento.TabIndex = 2;
            this.txtDescripcionDepartamento.TextChanged += new System.EventHandler(this.txtDescripcionDepartamento_TextChanged);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(3, 85);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(78, 16);
            this.lblUbicacion.TabIndex = 3;
            this.lblUbicacion.Text = "Ubicacion";
            this.lblUbicacion.Click += new System.EventHandler(this.lblUbicacion_Click);
            // 
            // txtUbicacionDepartamento
            // 
            this.txtUbicacionDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionDepartamento.Location = new System.Drawing.Point(204, 79);
            this.txtUbicacionDepartamento.Name = "txtUbicacionDepartamento";
            this.txtUbicacionDepartamento.Size = new System.Drawing.Size(276, 26);
            this.txtUbicacionDepartamento.TabIndex = 4;
            this.txtUbicacionDepartamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtDescripcionDepartamento);
            this.panel1.Controls.Add(this.txtUbicacionDepartamento);
            this.panel1.Controls.Add(this.lblDepartamentoDescripcion);
            this.panel1.Controls.Add(this.lblUbicacion);
            this.panel1.Location = new System.Drawing.Point(17, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 131);
            this.panel1.TabIndex = 5;
            this.panel1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCrearDepartamento);
            this.panel2.Controls.Add(this.btnCancelarDepartamento);
            this.panel2.Location = new System.Drawing.Point(17, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 89);
            this.panel2.TabIndex = 6;
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
            // btnCrearDepartamento
            // 
            this.btnCrearDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrearDepartamento.BackgroundImage")));
            this.btnCrearDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearDepartamento.Location = new System.Drawing.Point(310, 11);
            this.btnCrearDepartamento.Name = "btnCrearDepartamento";
            this.btnCrearDepartamento.Size = new System.Drawing.Size(87, 67);
            this.btnCrearDepartamento.TabIndex = 1;
            this.btnCrearDepartamento.UseVisualStyleBackColor = true;
            this.btnCrearDepartamento.Click += new System.EventHandler(this.btnCrearDepartamento_Click);
            // 
            // btnCancelarDepartamento
            // 
            this.btnCancelarDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarDepartamento.BackgroundImage")));
            this.btnCancelarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarDepartamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCancelarDepartamento.Location = new System.Drawing.Point(72, 11);
            this.btnCancelarDepartamento.Name = "btnCancelarDepartamento";
            this.btnCancelarDepartamento.Size = new System.Drawing.Size(86, 67);
            this.btnCancelarDepartamento.TabIndex = 0;
            this.btnCancelarDepartamento.UseVisualStyleBackColor = true;
            this.btnCancelarDepartamento.Click += new System.EventHandler(this.btnCancelarDepartamento_Click);
            // 
            // CrearDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 324);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoDepartamento);
            this.Name = "CrearDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Departamento";
            this.Load += new System.EventHandler(this.CrearDepartamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepartamentoDescripcion;
        private System.Windows.Forms.Label lblNuevoDepartamento;
        private System.Windows.Forms.TextBox txtDescripcionDepartamento;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtUbicacionDepartamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCrearDepartamento;
        private System.Windows.Forms.Button btnCancelarDepartamento;
        private System.Windows.Forms.Label label1;
    }
}