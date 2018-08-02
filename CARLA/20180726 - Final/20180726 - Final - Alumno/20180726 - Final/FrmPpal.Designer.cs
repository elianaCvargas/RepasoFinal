namespace _20180726___Final
{
    partial class FrmPpal
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
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.nudAncho = new System.Windows.Forms.NumericUpDown();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lblAlto = new System.Windows.Forms.Label();
            this.nudAlto = new System.Windows.Forms.NumericUpDown();
            this.lblProfundidad = new System.Windows.Forms.Label();
            this.nudProfundidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnProbar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfundidad)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.Location = new System.Drawing.Point(236, 11);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(355, 402);
            this.rtbMensaje.TabIndex = 0;
            this.rtbMensaje.Text = "";
            // 
            // nudAncho
            // 
            this.nudAncho.Location = new System.Drawing.Point(110, 11);
            this.nudAncho.Name = "nudAncho";
            this.nudAncho.Size = new System.Drawing.Size(120, 20);
            this.nudAncho.TabIndex = 1;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(12, 13);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(38, 13);
            this.lblAncho.TabIndex = 2;
            this.lblAncho.Text = "Ancho";
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Location = new System.Drawing.Point(12, 39);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(25, 13);
            this.lblAlto.TabIndex = 4;
            this.lblAlto.Text = "Alto";
            // 
            // nudAlto
            // 
            this.nudAlto.Location = new System.Drawing.Point(110, 37);
            this.nudAlto.Name = "nudAlto";
            this.nudAlto.Size = new System.Drawing.Size(120, 20);
            this.nudAlto.TabIndex = 3;
            // 
            // lblProfundidad
            // 
            this.lblProfundidad.AutoSize = true;
            this.lblProfundidad.Location = new System.Drawing.Point(12, 65);
            this.lblProfundidad.Name = "lblProfundidad";
            this.lblProfundidad.Size = new System.Drawing.Size(64, 13);
            this.lblProfundidad.TabIndex = 6;
            this.lblProfundidad.Text = "Profundidad";
            // 
            // nudProfundidad
            // 
            this.nudProfundidad.Location = new System.Drawing.Point(110, 63);
            this.nudProfundidad.Name = "nudProfundidad";
            this.nudProfundidad.Size = new System.Drawing.Size(120, 20);
            this.nudProfundidad.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(124, 376);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 37);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(12, 376);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(106, 37);
            this.btnProbar.TabIndex = 8;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 426);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblProfundidad);
            this.Controls.Add(this.nudProfundidad);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.nudAlto);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.nudAncho);
            this.Controls.Add(this.rtbMensaje);
            this.Name = "FrmPpal";
            this.Text = "Final 26 - 06 - 2018";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfundidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMensaje;
        private System.Windows.Forms.NumericUpDown nudAncho;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.NumericUpDown nudAlto;
        private System.Windows.Forms.Label lblProfundidad;
        private System.Windows.Forms.NumericUpDown nudProfundidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnProbar;
    }
}

