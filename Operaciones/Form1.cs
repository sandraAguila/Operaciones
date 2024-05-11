using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDivisible3_Click(object sender, EventArgs e)
        {
            double valor = 0;
            String  result ;

            valor = Convert.ToDouble(txtValor.Text );

            if(valor % 3 ==0)
            {
                result = "El valor es divisible entre 3";
                txtResultado.Text = result;
            }
            else
            {
                result = "El valor no es divisible entre 3";
                txtResultado.Text = result;

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
