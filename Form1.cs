using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeMoussa = 31;
            int idadeRaquel = 42;
            int idadeHelena = 1;

            double mediaIdades;

            mediaIdades = (idadeHelena + idadeRaquel + idadeMoussa) / 3;

            MessageBox.Show($"A média de idade de Helena, Raquel e Moussa é {mediaIdades:f2}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show($"Pi quebrado = {piQuebrado}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 9;
            int c = 6;

            double delta, a1, a2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta) / (2 * a));
            a2 = (-b - Math.Sqrt(delta) / (2 * a));

            MessageBox.Show($"{a1} {a2}");
        }
    }
}
