namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        



        private void btnSolicitar_Click_1(object sender, EventArgs e)
        {

            int[] listado = new int[10];
            int i = 0;
            int num;

            Form2 fModal = new Form2();

            fModal.ShowDialog();


            listado[i] = Convert.ToInt32(fModal.tbValor.Text);
            fModal.tbValor.Clear();
            i++;

            while (i < 5 && fModal.ShowDialog() == DialogResult.OK)
            {
                i++;
                listado[i] = Convert.ToInt32(fModal.tbValor.Text);
                fModal.tbValor.Clear();
            }
            if (i == 5)
            {
                for (int n = 0; n < i; n++)
                {
                    lsbListado.Items.Add(listado[n]);
                }
            }
        }
    }
}
