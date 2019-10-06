using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturasDeControle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Código do saque
            {
                double saldo = 100.0;
                double valorSaque = 100.0;
                if (saldo >= valorSaque)
                {
                    saldo = saldo - valorSaque;
                    MessageBox.Show("Saque realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Saldo Insuficiente");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                //Código do saque
                {
                    double saldo = 100.0;
                    double valorSaque = 100.0;
                    if (saldo >= valorSaque)
                    {
                        saldo = saldo - valorSaque;
                        MessageBox.Show("Saque realizado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Saldo Insuficiente");
                    }
                }
            }
        }
    }
}
