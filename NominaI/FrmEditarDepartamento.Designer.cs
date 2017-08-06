namespace NominaI
{
    partial class FrmEditarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarDepartamento));
            this.btnCancelarDepartamento = new System.Windows.Forms.Button();
            this.btnEditarDepartamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblDepartamentoDescripcion = new System.Windows.Forms.Label();
            this.txtUbicacionDepartamento = new System.Windows.Forms.TextBox();
            this.txtDescripcionDepartamento = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNuevoDepartamento = new System.Windows.Forms.Label();
            this.txtCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // btnEditarDepartamento
            // 
            this.btnEditarDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarDepartamento.BackgroundImage")));
            this.btnEditarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarDepartamento.Location = new System.Drawing.Point(310, 11);
            this.btnEditarDepartamento.Name = "btnEditarDepartamento";
            this.btnEditarDepartamento.Size = new System.Drawing.Size(87, 67);
            this.btnEditarDepartamento.TabIndex = 1;
            this.btnEditarDepartamento.UseVisualStyleBackColor = true;
            this.btnEditarDepartamento.Click += new System.EventHandler(this.btnEditarDepartamento_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnEditarDepartamento);
            this.panel2.Controls.Add(this.btnCancelarDepartamento);
            this.panel2.Location = new System.Drawing.Point(30, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 89);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(1, 125);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(78, 16);
            this.lblUbicacion.TabIndex = 3;
            this.lblUbicacion.Text = "Ubicacion";
            this.lblUbicacion.UseWaitCursor = true;
            // 
            // lblDepartamentoDescripcion
            // 
            this.lblDepartamentoDescripcion.AutoSize = true;
            this.lblDepartamentoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamentoDescripcion.Location = new System.Drawing.Point(3, 72);
            this.lblDepartamentoDescripcion.Name = "lblDepartamentoDescripcion";
            this.lblDepartamentoDescripcion.Size = new System.Drawing.Size(193, 16);
            this.lblDepartamentoDescripcion.TabIndex = 0;
            this.lblDepartamentoDescripcion.Text = "Descripcion Departamento";
            this.lblDepartamentoDescripcion.UseWaitCursor = true;
            // 
            // txtUbicacionDepartamento
            // 
            this.txtUbicacionDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacionDepartamento.Location = new System.Drawing.Point(202, 119);
            this.txtUbicacionDepartamento.Name = "txtUbicacionDepartamento";
            this.txtUbicacionDepartamento.Size = new System.Drawing.Size(276, 26);
            this.txtUbicacionDepartamento.TabIndex = 4;
            this.txtUbicacionDepartamento.UseWaitCursor = true;
            // 
            // txtDescripcionDepartamento
            // 
            this.txtDescripcionDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDepartamento.Location = new System.Drawing.Point(202, 66);
            this.txtDescripcionDepartamento.Name = "txtDescripcionDepartamento";
            this.txtDescripcionDepartamento.Size = new System.Drawing.Size(276, 26);
            this.txtDescripcionDepartamento.TabIndex = 2;
            this.txtDescripcionDepartamento.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtCodigoDepartamento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDescripcionDepartamento);
            this.panel1.Controls.Add(this.txtUbicacionDepartamento);
            this.panel1.Controls.Add(this.lblDepartamentoDescripcion);
            this.panel1.Controls.Add(this.lblUbicacion);
            this.panel1.Location = new System.Drawing.Point(30, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 168);
            this.panel1.TabIndex = 8;
            this.panel1.UseWaitCursor = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNuevoDepartamento
            // 
            this.lblNuevoDepartamento.AutoSize = true;
            this.lblNuevoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoDepartamento.Location = new System.Drawing.Point(155, 22);
            this.lblNuevoDepartamento.Name = "lblNuevoDepartamento";
            this.lblNuevoDepartamento.Size = new System.Drawing.Size(228, 25);
            this.lblNuevoDepartamento.TabIndex = 7;
            this.lblNuevoDepartamento.Text = "Editar Departamento";
            this.lblNuevoDepartamento.Click += new System.EventHandler(this.lblNuevoDepartamento_Click);
            // 
            // txtCodigoDepartamento
            // 
            this.txtCodigoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDepartamento.Location = new System.Drawing.Point(202, 21);
            this.txtCodigoDepartamento.Name = "txtCodigoDepartamento";
            this.txtCodigoDepartamento.ReadOnly = true;
            this.txtCodigoDepartamento.Size = new System.Drawing.Size(276, 26);
            this.txtCodigoDepartamento.TabIndex = 6;
            this.txtCodigoDepartamento.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo Departamento";
            this.label2.UseWaitCursor = true;
            // 
            // FormEditarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 395);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoDepartamento);
            this.Name = "FormEditarDepartamento";
            this.Text = "FormEditarDepartamento";
            this.Load += new System.EventHandler(this.FormEditarDepartamento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarDepartamento;
        private System.Windows.Forms.Button btnEditarDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblDepartamentoDescripcion;
        private System.Windows.Forms.TextBox txtUbicacionDepartamento;
        private System.Windows.Forms.TextBox txtDescripcionDepartamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigoDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNuevoDepartamento;



    }
}