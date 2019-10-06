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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá danilo este é o seu primeiro programa - " + ((Estado)cboEstados.SelectedItem).Id;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirCadastro_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void abrirLerArquivo_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Abrir Ler Arquivo", abrirLerArquivo_Click));
            contextMenu.MenuItems.Add(new MenuItem("Abrir Cadastro", abrirCadastro_Click));
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            notifyIcon1.ContextMenu = contextMenu;

            atualizaHora(); 

            /***************************************************/
            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "[Selecione]";

            /*
             cboEstados.Items.Clear();
             foreach(Estado estado in Estado.Lista())
             {
                cboEstados.Items.Add(estado);
             }*/

            /***************************************************/

            //Maneira simples de utilizar
            //dataGridView.DataSource = Estados.Lista();

            //Maneira complexa de utilizar
            /*
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nome";

            var rows = new List<string[]>();
            foreach(Estado estado in Estado.Lista())
            {
                string[] row1 = new string[] { estado.Id.ToString(), estado.Nome };
                rows.Add(row1);
            }

            foreach(string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }
            */

            //Maneira intermediaria de utilizar
            //utilizando Link
            var data = from estado in Estado.Lista()
                           //where estado.Id == 1 || estado.Id == 2
                           //orderby estado.Nome
                           select new
                           {
                               Id = estado.Id,
                               Nome = estado.Nome
                            };
            dataGridView.DataSource = data.ToList();
        }

        private void atualizaHora()
        {
            lblHoraAtual.Text = "Dia e Hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTexto = new FrmTexto();
            frmTexto.MdiParent = MDISingleton.InstanciaMDI();
            frmTexto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cliquei no ícone");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Dois cliques no ícone");
        }

        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10, "Notificação", "Valide os campo\nNome, Telefone", ToolTipIcon.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MDIParentPrincipal().Show();
        }
    }
}
