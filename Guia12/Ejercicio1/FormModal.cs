using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormModal : Form
    {
        public FormModal()
        {
            InitializeComponent();
        }

        public void tbValor_TextChanged(object sender, EventArgs e)
        {
            double valor=Convert.ToDouble(tbValor.Text);
        }
    }
}
