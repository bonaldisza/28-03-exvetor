using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exvetores
{
    public partial class Form2 : Form
    {
        int i, soma = 0, nota, media;
        int[] vetorNotas = new int[30];

        private void rctxnotas_TextChanged(object sender, EventArgs e)
        {

        }


        public Form2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 30; i++)
            {
                nota = Convert.ToInt32(txtnota.Text);
                soma = soma + vetorNotas[i];
                media = soma / 30;
                txtmedia.Text = media.ToString();
            }
        }
    }
}
