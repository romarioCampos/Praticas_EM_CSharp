﻿using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;
        public const int CADASTRAR_USUARIOS = 5;
        public const int CADASTRAR_FORNECEDORES = 6;

        public static void Criar()
        {
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n Aplicação Console Final" +
                    "\n\n" +
                    "\n     Digite uma das opções abaixo: " +
                    "\n         0 - Sair do Programa" +
                    "\n         1 - Para Ler Arquivos" +
                    "\n         2 - Para executar a Tabuada" +
                    "\n         3 - Calcular a media de alunos" +
                    "\n         4 - Cadastar clientes" +
                    "\n         5 - Cadastar usuarios" +
                    "\n         6 - Cadastar fornecedores";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("================= Opção Ler Arquivos ============================");
                    Arquivo.Ler(1);
                    Console.WriteLine("=============================================================================");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("============= Opção Tabuada =========================");
                    Console.WriteLine("Digite o numero que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("\n==========================================================\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n==========================================================\n");

                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("\n==========================================================\n");
                }
                else if (valor == CADASTRAR_USUARIOS)
                {
                    TelaUsuario.Chamar();
                    Console.WriteLine("\n==========================================================\n");
                }
                else if (valor == CADASTRAR_FORNECEDORES)
                {
                    TelaFornecedor.Chamar();
                    Console.WriteLine("\n==========================================================\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida digite novamente");
                }
            }
        }
    }
}
