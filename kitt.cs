using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class kitt : Form
    {
        public kitt()
        {
            InitializeComponent();
        }

        private void BtnCalcu_Click(object sender, EventArgs e)
        {
            try { 
                int numero1, numero2, resultado;
                numero1 = int.Parse(TxtGato1.Text);
                numero2 = int.Parse(TxtGato2.Text);
                resultado = numero1 + numero2;
                TxtResultado.Text = resultado.ToString();
                MessageBox.Show("HAY " + resultado + " GATITOS");
            }
            catch (Exception)
            {
                MessageBox.Show("solo numeros");
            }

        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            try{
                int numero1, numero2, resta;
                numero1 = int.Parse(TxtGato1.Text);
                numero2 = int.Parse(TxtGato2.Text);
                resta = numero1 - numero2;
                string TxtResta = resta.ToString();
                MessageBox.Show("HAY " + resta + " GATITOS");
            }
            catch (Exception)
            {
                MessageBox.Show("solo numeros");
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            try{
                int numero1, numero2, multip;
                numero1 = int.Parse(TxtGato1.Text);
                numero2 = int.Parse(TxtGato2.Text);
                multip = numero1 * numero2;
                string TxtMultip = multip.ToString();
                MessageBox.Show("HAY " + multip + " GATITOS");
            }
            catch (Exception)
            {
                MessageBox.Show("solo numeros");
            }
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            try{
                int numero1, numero2, div;
                numero1 = int.Parse(TxtGato1.Text);
                numero2 = int.Parse(TxtGato2.Text);
                div = numero1 / numero2;
                string TxtDiv = div.ToString();
                MessageBox.Show("HAY " + div + " GATITOS");
            }
            catch (Exception)
            {
                MessageBox.Show("solo numeros");
            }
        }
    }
}
