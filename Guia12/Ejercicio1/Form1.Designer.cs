namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbMostrarValor = new Label();
            btnSolicitar = new Button();
            tb1 = new TextBox();
            lb1 = new Label();
            SuspendLayout();
            // 
            // lbMostrarValor
            // 
            lbMostrarValor.BackColor = SystemColors.ActiveCaption;
            lbMostrarValor.Location = new Point(190, 250);
            lbMostrarValor.Margin = new Padding(4, 0, 4, 0);
            lbMostrarValor.Name = "lbMostrarValor";
            lbMostrarValor.Size = new Size(279, 32);
            lbMostrarValor.TabIndex = 0;
            lbMostrarValor.Click += lbMostrarValor_Click;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(209, 117);
            btnSolicitar.Margin = new Padding(4);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(208, 32);
            btnSolicitar.TabIndex = 1;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // tb1
            // 
            tb1.Location = new Point(485, 117);
            tb1.Margin = new Padding(4);
            tb1.Name = "tb1";
            tb1.Size = new Size(127, 29);
            tb1.TabIndex = 3;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(103, 261);
            lb1.Margin = new Padding(4, 0, 4, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(79, 21);
            lb1.TabIndex = 4;
            lb1.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 336);
            Controls.Add(lb1);
            Controls.Add(tb1);
            Controls.Add(btnSolicitar);
            Controls.Add(lbMostrarValor);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejemplo Modal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMostrarValor;
        private Button btnSolicitar;
        private TextBox tb1;
        private Label lb1;
    }
}
