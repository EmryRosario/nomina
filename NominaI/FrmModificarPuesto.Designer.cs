namespace NominaI
{
    partial class FrmModificarPuesto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarPuesto));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarPuesto = new System.Windows.Forms.Button();
            this.btnCancelarPuesto = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtSalarioMaximo = new System.Windows.Forms.TextBox();
            this.lblSalarioMaximo = new System.Windows.Forms.Label();
            this.txtSalarioMinimo = new System.Windows.Forms.TextBox();
            this.lblSalarioMinimo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCabecera = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.nominaDBDataSet = new NominaI.nominaDBDataSet();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new NominaI.nominaDBDataSetTableAdapters.DepartamentosTableAdapter();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnModificarPuesto);
            this.panel2.Controls.Add(this.btnCancelarPuesto);
            this.panel2.Location = new System.Drawing.Point(12, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 89);
            this.panel2.TabIndex = 10;
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
            // btnModificarPuesto
            // 
            this.btnModificarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarPuesto.BackgroundImage")));
            this.btnModificarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarPuesto.Location = new System.Drawing.Point(235, 20);
            this.btnModificarPuesto.Name = "btnModificarPuesto";
            this.btnModificarPuesto.Size = new System.Drawing.Size(74, 49);
            this.btnModificarPuesto.TabIndex = 1;
            this.btnModificarPuesto.UseVisualStyleBackColor = true;
            this.btnModificarPuesto.Click += new System.EventHandler(this.btnModificarPuesto_Click);
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
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(13, 303);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(114, 18);
            this.lblDepartamento.TabIndex = 16;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtSalarioMaximo
            // 
            this.txtSalarioMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMaximo.Location = new System.Drawing.Point(140, 240);
            this.txtSalarioMaximo.Name = "txtSalarioMaximo";
            this.txtSalarioMaximo.Size = new System.Drawing.Size(245, 26);
            this.txtSalarioMaximo.TabIndex = 15;
            // 
            // lblSalarioMaximo
            // 
            this.lblSalarioMaximo.AutoSize = true;
            this.lblSalarioMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMaximo.Location = new System.Drawing.Point(9, 240);
            this.lblSalarioMaximo.Name = "lblSalarioMaximo";
            this.lblSalarioMaximo.Size = new System.Drawing.Size(125, 18);
            this.lblSalarioMaximo.TabIndex = 14;
            this.lblSalarioMaximo.Text = "Salario Maximo";
            // 
            // txtSalarioMinimo
            // 
            this.txtSalarioMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioMinimo.Location = new System.Drawing.Point(140, 177);
            this.txtSalarioMinimo.Name = "txtSalarioMinimo";
            this.txtSalarioMinimo.Size = new System.Drawing.Size(245, 26);
            this.txtSalarioMinimo.TabIndex = 13;
            // 
            // lblSalarioMinimo
            // 
            this.lblSalarioMinimo.AutoSize = true;
            this.lblSalarioMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioMinimo.Location = new System.Drawing.Point(13, 181);
            this.lblSalarioMinimo.Name = "lblSalarioMinimo";
            this.lblSalarioMinimo.Size = new System.Drawing.Size(121, 18);
            this.lblSalarioMinimo.TabIndex = 12;
            this.lblSalarioMinimo.Text = "Salario Minimo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(140, 113);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 26);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(13, 113);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 18);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCabecera
            // 
            this.lblCabecera.AutoSize = true;
            this.lblCabecera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabecera.Location = new System.Drawing.Point(93, 9);
            this.lblCabecera.Name = "lblCabecera";
            this.lblCabecera.Size = new System.Drawing.Size(189, 25);
            this.lblCabecera.TabIndex = 9;
            this.lblCabecera.Text = "Modificar Puesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(140, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(245, 26);
            this.txtCodigo.TabIndex = 19;
            // 
            // nominaDBDataSet
            // 
            this.nominaDBDataSet.DataSetName = "nominaDBDataSet";
            this.nominaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.nominaDBDataSet;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DataSource = this.departamentosBindingSource;
            this.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(140, 299);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(245, 26);
            this.cbDepartamento.TabIndex = 20;
            // 
            // FrmModificarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 446);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblCabecera);
            this.Controls.Add(this.txtSalarioMaximo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblSalarioMaximo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtSalarioMinimo);
            this.Controls.Add(this.lblSalarioMinimo);
            this.Name = "FrmModificarPuesto";
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.FrmModificarPuesto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nominaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarPuesto;
        private System.Windows.Forms.Button btnCancelarPuesto;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtSalarioMaximo;
        private System.Windows.Forms.Label lblSalarioMaximo;
        private System.Windows.Forms.TextBox txtSalarioMinimo;
        private System.Windows.Forms.Label lblSalarioMinimo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCabecera;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private nominaDBDataSet nominaDBDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private nominaDBDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.ComboBox cbDepartamento;
    }
}