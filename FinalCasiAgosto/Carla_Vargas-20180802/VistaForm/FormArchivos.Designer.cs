namespace VistaForm
{
    partial class FormArchivos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAlmacenarElectronico = new System.Windows.Forms.Button();
            this.btnAlmacenarFisico = new System.Windows.Forms.Button();
            this.btnLeerElectronico = new System.Windows.Forms.Button();
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeerFisico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlmacenarElectronico
            // 
            this.btnAlmacenarElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenarElectronico.ForeColor = System.Drawing.Color.Blue;
            this.btnAlmacenarElectronico.Location = new System.Drawing.Point(205, 290);
            this.btnAlmacenarElectronico.Name = "btnAlmacenarElectronico";
            this.btnAlmacenarElectronico.Size = new System.Drawing.Size(116, 42);
            this.btnAlmacenarElectronico.TabIndex = 0;
            this.btnAlmacenarElectronico.Text = "ALMACENAR ELECTRÓNICO";
            this.btnAlmacenarElectronico.UseVisualStyleBackColor = true;
            this.btnAlmacenarElectronico.Click += new System.EventHandler(this.btnAlmacenarElectronico_Click);
            // 
            // btnAlmacenarFisico
            // 
            this.btnAlmacenarFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenarFisico.ForeColor = System.Drawing.Color.Blue;
            this.btnAlmacenarFisico.Location = new System.Drawing.Point(61, 290);
            this.btnAlmacenarFisico.Name = "btnAlmacenarFisico";
            this.btnAlmacenarFisico.Size = new System.Drawing.Size(116, 42);
            this.btnAlmacenarFisico.TabIndex = 1;
            this.btnAlmacenarFisico.Text = "ALMACENAR FÍSICO";
            this.btnAlmacenarFisico.UseVisualStyleBackColor = true;
            this.btnAlmacenarFisico.Click += new System.EventHandler(this.btnAlmacenarFisico_Click);
            // 
            // btnLeerElectronico
            // 
            this.btnLeerElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerElectronico.ForeColor = System.Drawing.Color.Blue;
            this.btnLeerElectronico.Location = new System.Drawing.Point(351, 290);
            this.btnLeerElectronico.Name = "btnLeerElectronico";
            this.btnLeerElectronico.Size = new System.Drawing.Size(116, 42);
            this.btnLeerElectronico.TabIndex = 2;
            this.btnLeerElectronico.Text = "LEER ELECTRÓNICO";
            this.btnLeerElectronico.UseVisualStyleBackColor = true;
            this.btnLeerElectronico.Click += new System.EventHandler(this.btnLeerElectronico_Click);
            // 
            // rtbContenido
            // 
            this.rtbContenido.Location = new System.Drawing.Point(61, 74);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.Size = new System.Drawing.Size(551, 129);
            this.rtbContenido.TabIndex = 3;
            this.rtbContenido.Text = "";
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(161, 15);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreArchivo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre archivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contenido:";
            // 
            // btnLeerFisico
            // 
            this.btnLeerFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerFisico.ForeColor = System.Drawing.Color.Blue;
            this.btnLeerFisico.Location = new System.Drawing.Point(496, 290);
            this.btnLeerFisico.Name = "btnLeerFisico";
            this.btnLeerFisico.Size = new System.Drawing.Size(116, 42);
            this.btnLeerFisico.TabIndex = 7;
            this.btnLeerFisico.Text = "LEER FÍSICO";
            this.btnLeerFisico.UseVisualStyleBackColor = true;
            this.btnLeerFisico.Click += new System.EventHandler(this.btnLeerFisico_Click);
            // 
            // FormArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.btnLeerFisico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.rtbContenido);
            this.Controls.Add(this.btnLeerElectronico);
            this.Controls.Add(this.btnAlmacenarFisico);
            this.Controls.Add(this.btnAlmacenarElectronico);
            this.Name = "FormArchivos";
            this.Text = "Form Archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlmacenarElectronico;
        private System.Windows.Forms.Button btnAlmacenarFisico;
        private System.Windows.Forms.Button btnLeerElectronico;
        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeerFisico;
    }
}

