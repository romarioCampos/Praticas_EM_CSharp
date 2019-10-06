﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FrmTree : Form
    {
        public FrmTree()
        {
            InitializeComponent();
        }

        private void FrmTree_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("C#;APSP.NET;DOTNET");
            var node = treeView1.Nodes[0];
            loadDiretorios(@"C:\Users\Romário Campos\Documents\Projetos\C#;APSP.NET;DOTNET\", ref node);
        }

        private void loadDiretorios(string diretorio, ref TreeNode node)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            foreach(string arquivo in arquivos)
            {
                node.Nodes.Add(Path.GetFileName(arquivo));
            }

            string[] subdiretorios = Directory.GetDirectories(diretorio);
            foreach(string subdiretorio in subdiretorios)
            {
                TreeNode n = new TreeNode(Path.GetFileName(subdiretorio));
                loadDiretorios(subdiretorio, ref n);
                node.Nodes.Add(n);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lerChecados(treeView1.Nodes[0]));
        }

        private string lerChecados(TreeNode node, string checkeds = "")
        {
            foreach(TreeNode n in node.Nodes)
            {
                if (n.Checked)
                {
                    checkeds += n.Text + ", ";
                }
                checkeds = lerChecados(n, checkeds);
            }
            return checkeds;
        }
    }
}
