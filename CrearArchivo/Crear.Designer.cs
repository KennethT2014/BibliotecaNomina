
namespace CrearArchivo
{
    partial class Crear
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
            this.BtnGuardarComo = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.bntSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGuardarComo
            // 
            this.BtnGuardarComo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarComo.Location = new System.Drawing.Point(20, 388);
            this.BtnGuardarComo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGuardarComo.Name = "BtnGuardarComo";
            this.BtnGuardarComo.Size = new System.Drawing.Size(140, 41);
            this.BtnGuardarComo.TabIndex = 11;
            this.BtnGuardarComo.Text = "guardar como...";
            this.BtnGuardarComo.UseVisualStyleBackColor = true;
            this.BtnGuardarComo.Click += new System.EventHandler(this.BtnGuardarComo_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Location = new System.Drawing.Point(204, 388);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(154, 38);
            this.btnEntrar.TabIndex = 12;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // bntSalir
            // 
            this.bntSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSalir.Location = new System.Drawing.Point(404, 388);
            this.bntSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(140, 37);
            this.bntSalir.TabIndex = 13;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = true;
            this.bntSalir.Click += new System.EventHandler(this.bntSalir_Click);
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 482);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.BtnGuardarComo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Crear";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.BtnGuardarComo, 0);
            this.Controls.SetChildIndex(this.btnEntrar, 0);
            this.Controls.SetChildIndex(this.bntSalir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardarComo;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button bntSalir;
    }
}

