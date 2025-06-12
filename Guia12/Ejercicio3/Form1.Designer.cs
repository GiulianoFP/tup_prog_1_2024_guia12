namespace Ejercicio3
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
            label1 = new Label();
            lb2 = new Label();
            lbCantidad = new Label();
            lsbListado = new ListBox();
            btnSolicitar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 109);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Listado";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Location = new Point(244, 109);
            lb2.Name = "lb2";
            lb2.Size = new Size(58, 15);
            lb2.TabIndex = 1;
            lb2.Text = "Cantidad:";
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.Location = new Point(337, 109);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(65, 15);
            lbCantidad.TabIndex = 2;
            lbCantidad.Text = "lbCantidad";
            // 
            // lsbListado
            // 
            lsbListado.FormattingEnabled = true;
            lsbListado.ItemHeight = 15;
            lsbListado.Location = new Point(34, 136);
            lsbListado.Name = "lsbListado";
            lsbListado.Size = new Size(405, 184);
            lsbListado.TabIndex = 3;
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(136, 25);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(204, 44);
            btnSolicitar.TabIndex = 4;
            btnSolicitar.Text = "Solicitar Valor";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 333);
            Controls.Add(btnSolicitar);
            Controls.Add(lsbListado);
            Controls.Add(lbCantidad);
            Controls.Add(lb2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb2;
        private Label lbCantidad;
        private ListBox lsbListado;
        private Button btnSolicitar;
    }
}
