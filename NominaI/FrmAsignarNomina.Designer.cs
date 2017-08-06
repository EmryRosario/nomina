namespace NominaI
{
    partial class FrmAsignarNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarNomina));
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.cbNominasNoAsignada = new System.Windows.Forms.ComboBox();
            this.nominasAsignadas = new System.Windows.Forms.ComboBox();
            this.btnDerecho = new System.Windows.Forms.Button();
            this.btnIzquierdo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(132, 31);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(436, 26);
            this.cbEmpleado.TabIndex = 1;
            // 
            // cbNominasNoAsignada
            // 
            this.cbNominasNoAsignada.AllowDrop = true;
            this.cbNominasNoAsignada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbNominasNoAsignada.Location = new System.Drawing.Point(15, 97);
            this.cbNominasNoAsignada.Name = "cbNominasNoAsignada";
            this.cbNominasNoAsignada.Size = new System.Drawing.Size(188, 293);
            this.cbNominasNoAsignada.Sorted = true;
            this.cbNominasNoAsignada.TabIndex = 2;
            this.cbNominasNoAsignada.SelectedIndexChanged += new System.EventHandler(this.cbNominasNoAsignada_SelectedIndexChanged);
            // 
            // nominasAsignadas
            // 
            this.nominasAsignadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.nominasAsignadas.FormattingEnabled = true;
            this.nominasAsignadas.Location = new System.Drawing.Point(380, 97);
            this.nominasAsignadas.Name = "nominasAsignadas";
            this.nominasAsignadas.Size = new System.Drawing.Size(188, 293);
            this.nominasAsignadas.TabIndex = 3;
            // 
            // btnDerecho
            // 
            this.btnDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecho.Location = new System.Drawing.Point(271, 169);
            this.btnDerecho.Name = "btnDerecho";
            this.btnDerecho.Size = new System.Drawing.Size(48, 46);
            this.btnDerecho.TabIndex = 4;
            this.btnDerecho.Text = "<";
            this.btnDerecho.UseVisualStyleBackColor = true;
            // 
            // btnIzquierdo
            // 
            this.btnIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierdo.Location = new System.Drawing.Point(271, 263);
            this.btnIzquierdo.Name = "btnIzquierdo";
            this.btnIzquierdo.Size = new System.Drawing.Size(48, 46);
            this.btnIzquierdo.TabIndex = 5;
            this.btnIzquierdo.Text = ">";
            this.btnIzquierdo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnGuardarEmpleado);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Location = new System.Drawing.Point(112, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 89);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(41, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 2;
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEmpleado.BackgroundImage")));
            this.btnGuardarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(235, 20);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(74, 49);
            this.btnGuardarEmpleado.TabIndex = 1;
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCancelar.Location = new System.Drawing.Point(52, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 49);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmAsignarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIzquierdo);
            this.Controls.Add(this.btnDerecho);
            this.Controls.Add(this.nominasAsignadas);
            this.Controls.Add(this.cbNominasNoAsignada);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "FrmAsignarNomina";
            this.Text = "FrmAsignarNomina";
            this.Load += new System.EventHandler(this.FrmAsignarNomina_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.ComboBox cbNominasNoAsignada;
        private System.Windows.Forms.ComboBox nominasAsignadas;
        private System.Windows.Forms.Button btnDerecho;
        private System.Windows.Forms.Button btnIzquierdo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.Button btnCancelar;
    }
}