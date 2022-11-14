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

        private void button4_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;

            if(saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show($"Saque realizado com sucesso. Seu saldo é: {saldo}");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;

            if(saldo >= valorSaque )
            {
                saldo -= valorSaque;
                MessageBox.Show($"Saque realizado com sucesso.");
            }
            else
            {
                MessageBox.Show("Saldo insuficente.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = false;

            if (idade >= 16 && brasileira == true)
                MessageBox.Show("Você está apta a votar");
            else
                MessageBox.Show("Calma! A sua hora vai chegar.");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = 5040.0;
            double imposto;

            if(valorNotaFiscal <= 999)
            {
                imposto = 1.02;
                valorNotaFiscal *= imposto;
                MessageBox.Show($"Imposto a pagar de: {valorNotaFiscal}");
            }
            else if(valorNotaFiscal >= 1000 && valorNotaFiscal <= 2999)
            {
                imposto = 1.025;
                valorNotaFiscal *= imposto;
                MessageBox.Show($"Imposto a pagar de: {valorNotaFiscal}");
            }
            else if(valorNotaFiscal >= 3000 && valorNotaFiscal <= 6999)
            {
                imposto = 1.028;
                valorNotaFiscal *= imposto;
                MessageBox.Show($"Imposto a pagar de: {valorNotaFiscal}");
            }
            else
            {
                imposto = 1.03;
                valorNotaFiscal *= imposto;
                MessageBox.Show($"Imposto a pagar de: {valorNotaFiscal}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem = (valor > 35) ? "Maior que 35" : "Menor que 35";

            MessageBox.Show(mensagem);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int total = 2;
            for(int i = 0; i < 5; i++)
            {
                total *= 2;
            }
            MessageBox.Show($"O total é: {total}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int total = 1;
            for(int i = 0; i < 1000; i++)
            {
                total += i;
            }
            MessageBox.Show($"O total é: {total}");
        }

        private void button11_Click(object sender, EventArgs e)
        {
           for(int i =3; i <=100; i +=3)
            {  
                    MessageBox.Show("Número múltiplo de 3: " + i);
            }
            /*
             
            int count = 1;
            while (count <= 100)
            {
                if (count % 3 == 0)
                {
                    MessageBox.Show($" Esse número é múltiplo de 3: {count}");
                }
                count++;
            }
             
             */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int numeroInicial = 1;
            int numeroFinal = 100;
            var soma = 0;

            for(int numeroAtual = numeroInicial;numeroAtual <= numeroFinal;numeroAtual++)
            {
                var ehMultiploDeTres = numeroAtual % 3 == 0;
                if (ehMultiploDeTres)
                    continue;

                soma += numeroAtual;
            }
            MessageBox.Show($"O resultado é {soma}");
            

        }
    }
}
