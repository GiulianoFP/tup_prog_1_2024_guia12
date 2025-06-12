namespace Ejercicio3
{
    partial class Form2
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(69, 126);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 32);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(217, 126);
            btnAceptar.Margin = new Padding(4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 32);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 2;
            label1.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(185, 70);
            tbValor.Margin = new Padding(4);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(127, 29);
            tbValor.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 207);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        public Button btnCancelar;
        public Button btnAceptar;
        public TextBox tbValor;
    }
}