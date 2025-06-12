namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        { 
            int i = 0;

            Form2 fModal = new Form2();

            fModal.ShowDialog();

            lsbListado.Items.Add(fModal.tbValor.Text);

            fModal.tbValor.Clear();
            i++;

            while (i < 5 && fModal.ShowDialog()==DialogResult.OK)
            {
                lsbListado.Items.Add(fModal.tbValor.Text);
                fModal.tbValor.Clear();
                i++;

            }
        }
    }
}
