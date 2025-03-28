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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int[] vetorA = new int[15];
            int i;
            Random random = new Random();
            for (i = 0; i < 15; i++)
            {
                vetorA[i] = random.Next(0,100);
                if (vetorA[i] % 2 == 0)
                {
                    rtxt.Text += vetorA[i].ToString() + Environment.NewLine;
                }
            }
        }
    }
}
