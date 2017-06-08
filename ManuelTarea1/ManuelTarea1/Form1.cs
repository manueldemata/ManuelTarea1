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
