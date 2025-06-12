namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Form2 fModal = new Form2();
            fModal.lbMostrarValor.Text=tbValor.Text;
            fModal.ShowDialog();
        }
    }
}
