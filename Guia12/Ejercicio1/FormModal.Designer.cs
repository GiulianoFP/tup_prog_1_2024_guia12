namespace Ejercicio1
{
    partial class FormModal
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
            lb1 = new Label();
            tbValor = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(224, 162);
            lb1.Name = "lb1";
            lb1.Size = new Size(33, 15);
            lb1.TabIndex = 0;
            lb1.Text = "Valor";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(358, 159);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 1;
            tbValor.TextChanged += tbValor_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(279, 297);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(465, 297);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // FormModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(tbValor);
            Controls.Add(lb1);
            Name = "FormModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Button btnCancelar;
        private Button btnAceptar;
        public TextBox tbValor;
    }
}