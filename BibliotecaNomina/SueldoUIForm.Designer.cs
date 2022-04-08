
namespace BibliotecaNomina
{
    partial class SueldoUIForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtsalariobruto = new System.Windows.Forms.TextBox();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.txtsalarioneto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario Bruto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas Trabajadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario Neto";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(213, 21);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(223, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(213, 71);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(223, 22);
            this.txtapellido.TabIndex = 6;
            // 
            // txtsalariobruto
            // 
            this.txtsalariobruto.Location = new System.Drawing.Point(213, 123);
            this.txtsalariobruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtsalariobruto.Name = "txtsalariobruto";
            this.txtsalariobruto.Size = new System.Drawing.Size(223, 22);
            this.txtsalariobruto.TabIndex = 7;
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Location = new System.Drawing.Point(213, 174);
            this.txthorastrabajadas.Margin = new System.Windows.Forms.Padding(4);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(223, 22);
            this.txthorastrabajadas.TabIndex = 8;
            // 
            // txtsalarioneto
            // 
            this.txtsalarioneto.Location = new System.Drawing.Point(213, 226);
            this.txtsalarioneto.Margin = new System.Windows.Forms.Padding(4);
            this.txtsalarioneto.Name = "txtsalarioneto";
            this.txtsalarioneto.Size = new System.Drawing.Size(223, 22);
            this.txtsalarioneto.TabIndex = 9;
            this.txtsalarioneto.TextChanged += new System.EventHandler(this.txtsalarioneto_TextChanged);
            // 
            // SueldoUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 417);
            this.Controls.Add(this.txtsalarioneto);
            this.Controls.Add(this.txthorastrabajadas);
            this.Controls.Add(this.txtsalariobruto);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SueldoUIForm";
            this.Text = "SueldoUIForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtsalariobruto;
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.TextBox txtsalarioneto;
    }
}