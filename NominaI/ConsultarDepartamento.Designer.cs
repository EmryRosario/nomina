namespace NominaI
{
    partial class ConsultarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarDepartamento));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarDepartamento = new System.Windows.Forms.Button();
            this.btnActualizarDepartamento = new System.Windows.Forms.Button();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(782, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAgregarDepartamento
            // 
            this.btnAgregarDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarDepartamento.BackgroundImage")));
            this.btnAgregarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarDepartamento.Location = new System.Drawing.Point(27, 46);
            this.btnAgregarDepartamento.Name = "btnAgregarDepartamento";
            this.btnAgregarDepartamento.Size = new System.Drawing.Size(69, 59);
            this.btnAgregarDepartamento.TabIndex = 1;
            this.btnAgregarDepartamento.UseVisualStyleBackColor = true;
            this.btnAgregarDepartamento.Click += new System.EventHandler(this.btnAgregarDepartamento_Click);
            // 
            // btnActualizarDepartamento
            // 
            this.btnActualizarDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarDepartamento.BackgroundImage")));
            this.btnActualizarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarDepartamento.Location = new System.Drawing.Point(136, 46);
            this.btnActualizarDepartamento.Name = "btnActualizarDepartamento";
            this.btnActualizarDepartamento.Size = new System.Drawing.Size(69, 59);
            this.btnActualizarDepartamento.TabIndex = 2;
            this.btnActualizarDepartamento.UseVisualStyleBackColor = true;
            this.btnActualizarDepartamento.Click += new System.EventHandler(this.btnActualizarDepartamento_Click);
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarDepartamento.BackgroundImage")));
            this.btnEliminarDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(246, 46);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(69, 59);
            this.btnEliminarDepartamento.TabIndex = 2;
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(338, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(417, 29);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(752, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 30);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConsultarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminarDepartamento);
            this.Controls.Add(this.btnActualizarDepartamento);
            this.Controls.Add(this.btnAgregarDepartamento);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ConsultarDepartamento";
            this.Text = "VerDepartamento";
            this.Activated += new System.EventHandler(this.ConsultarDepartamento_Activated);
            this.Load += new System.EventHandler(this.VerDepartamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarDepartamento;
        private System.Windows.Forms.Button btnActualizarDepartamento;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
    }
}