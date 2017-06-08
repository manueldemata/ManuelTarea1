using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ManuelTarea1
{
    public partial class Form1 : Form
    {

        double A, B, C;
        string palabra;
        string p1, p2;
        double primero, segundo, tercero;

        private void button3_Click(object sender, EventArgs e)
        {
            p1 = textBox1.Text;
            p2 = txtSegundo.Text;

            for(int x = p1.Length -1;  x >= 0; x--)
            {
                p2 += p1[x];
            }
            

            MessageBox.Show("frase invertida" + p2 );

        }

        private void txtPrimero_Click(object sender, EventArgs e)
        {
            primero = int.Parse( textBox1.Text);
            segundo = int.Parse(txtSegundo.Text);
            tercero = int.Parse(txtTercero.Text);

            MessageBox.Show("El resultado es" + (tercero * segundo) / primero);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            palabra = textBox1.Text;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(textBox1.Text);
            B = Convert.ToInt32(txtSegundo.Text);
            MessageBox.Show("La hipotenusa es " + Math.Sqrt((A * A) + (B * B)));
        }
    }
}
