using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaImposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculaSalario()
        {
            double salario = Convert.ToDouble(textBox1.Text);        
            double salarioFinal;
            //if(textBox1.Text = string.IsNullOrEmpty)
            //{
            //    MessageBox.Show("Por favor, informe um salário );
            //}
            if(salario <= 1045)
            {
                salarioFinal = salario - (salario * 7.5 / 100);
                MessageBox.Show("Salário deduzido é de: R$" + salarioFinal,"Dedução Salarial" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (salario >= 1045.01 &&  salario <= 2089.60 )
            {
                salarioFinal = salario - (salario * 9 / 100 - 15.67);
                MessageBox.Show("Salário deduzido é de: R$" + salarioFinal, "Dedução Salarial" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (salario >= 2089.60 && salario <= 3134.40 )
            {
                salarioFinal = salario - (salario * 12 / 100 - 78.36);
                MessageBox.Show("Salário deduzido é de: R$" + salarioFinal, "Dedução Salarial" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (salario >= 3134.41 && salario <= 6106.06)
            {
                salarioFinal = salario - (salario * 14 / 100 - 141.05);
                MessageBox.Show("Salário deduzido é de: R$" + salarioFinal, "Dedução Salarial" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (salario >= 6101.07)
            {
                salarioFinal = salario - 713.09;
                MessageBox.Show("Salário deduzido é de: R$" + salarioFinal, "Dedução Salarial" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calculaSalario();
            textBox1.Clear();
        }
    }
}
