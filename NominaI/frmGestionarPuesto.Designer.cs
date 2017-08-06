namespace NominaI
{
    partial class FrmGestionarPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarPuesto));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminarPuesto = new System.Windows.Forms.Button();
            this.btnActualizarPuesto = new System.Windows.Forms.Button();
            this.btnAgregarPuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(759, 260);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(737, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(323, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(417, 20);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEliminarPuesto
            // 
            this.btnEliminarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPuesto.BackgroundImage")));
            this.btnEliminarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarPuesto.Location = new System.Drawing.Point(236, 56);
            this.btnEliminarPuesto.Name = "btnEliminarPuesto";
            this.btnEliminarPuesto.Size = new System.Drawing.Size(69, 59);
            this.btnEliminarPuesto.TabIndex = 6;
            this.btnEliminarPuesto.UseVisualStyleBackColor = true;
            this.btnEliminarPuesto.Click += new System.EventHandler(this.btnEliminarPuesto_Click);
            // 
            // btnActualizarPuesto
            // 
            this.btnActualizarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarPuesto.BackgroundImage")));
            this.btnActualizarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarPuesto.Location = new System.Drawing.Point(131, 56);
            this.btnActualizarPuesto.Name = "btnActualizarPuesto";
            this.btnActualizarPuesto.Size = new System.Drawing.Size(69, 59);
            this.btnActualizarPuesto.TabIndex = 7;
            this.btnActualizarPuesto.UseVisualStyleBackColor = true;
            this.btnActualizarPuesto.Click += new System.EventHandler(this.btnActualizarPuesto_Click);
            // 
            // btnAgregarPuesto
            // 
            this.btnAgregarPuesto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarPuesto.BackgroundImage")));
            this.btnAgregarPuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarPuesto.Location = new System.Drawing.Point(21, 56);
            this.btnAgregarPuesto.Name = "btnAgregarPuesto";
            this.btnAgregarPuesto.Size = new System.Drawing.Size(69, 59);
            this.btnAgregarPuesto.TabIndex = 5;
            this.btnAgregarPuesto.UseVisualStyleBackColor = true;
            this.btnAgregarPuesto.Click += new System.EventHandler(this.btnAgregarPuesto_Click);
            // 
            // FrmGestionarPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminarPuesto);
            this.Controls.Add(this.btnActualizarPuesto);
            this.Controls.Add(this.btnAgregarPuesto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmGestionarPuesto";
            this.Text = "Gestionar Puestos";
            this.Activated += new System.EventHandler(this.FrmGestionarPuesto_Activated);
            this.Load += new System.EventHandler(this.FrmGestionarPuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminarPuesto;
        private System.Windows.Forms.Button btnActualizarPuesto;
        private System.Windows.Forms.Button btnAgregarPuesto;
    }
}