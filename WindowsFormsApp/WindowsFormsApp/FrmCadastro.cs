using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            try
            {
                int numero = int.Parse(txtNumero.Text);
                
                if(numero == 2)
                {
                    throw new ErroDeProposito("Erro de prposito");
                }
                else if(numero == 4)
                {
                    throw new Exception("Erro de prposito generico");
                }
                numero += 100;

                MessageBox.Show("Olá" + nome + ", o valor do numero mais 100 é de: " + numero);
            }
            catch (FormatException errFormat)
            {
                MessageBox.Show("Ola cliente, você por acaso não digitou letra no lugar de numero aqui? (" + errFormat.Message + ")");
                txtNome.Focus();
            }
            catch (ErroDeProposito errProposito)
            {
                MessageBox.Show("Erro de prososito - " + errProposito.StackTrace);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ola cliente, você por acaso não digitou letra no lugar de numero aqui? " + err.Message);
            }
            finally
            {
                MessageBox.Show("Todas as minhas exceções tratadas");
            }
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox3.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estou bucando no banco de dados com o termo: " + txtBuscaTool.Text);
        }
    }

    public class ErroDeProposito : Exception
    {
        public ErroDeProposito(string erro) : base(erro) { }
    }
}
