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
    public partial class gato : Form
    {
        public gato()
        {
            InitializeComponent();
        }

        private void BtnHola_Click(object sender, EventArgs e)
        {
            string nombregato;
            string apellidogato;
            int numerogatos;
            nombregato = TxtGato.Text;
            apellidogato = TxtApellido.Text;
            numerogatos = int.Parse(TxtNumero.Text);
            MessageBox.Show("hellow " + nombregato + " "+ apellidogato +  " cat" + " usted tiene " + numerogatos + " de gatitos");
        }
    }
}
