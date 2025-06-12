namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void lbMostrarValor_Click(object sender, EventArgs e)
        {
     
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            //double valor = Convert.ToDouble(tb1.Text);
            //lbMostrarValor.Text = Convert.ToString(valor);

            FormModal fModal = new FormModal();
            if(fModal.ShowDialog()==DialogResult.OK)
            {
                lbMostrarValor.Text=fModal.tbValor.Text ;
            }
            else
            {
                lbMostrarValor.Text = $"Valor no enviado/ingresado";
            }
            

        }
    }
}
