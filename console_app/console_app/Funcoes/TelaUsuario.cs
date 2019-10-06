using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class TelaUsuario
    {
        public static void Chamar()
        {
            Console.WriteLine("========================= Cadastro de Usuario ========================\n");

            while (true)
            {
                string mensagem = "Digite uma das opções abaixo: " +
                    "\n         0 - Sair do Cadastro" +
                    "\n         1 - Para Cadastar usuarios" +
                    "\n         2 - Para Listar usuarios";

                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());

                if (valor == 0)
                {
                    break;
                }
                else if (valor == 1)
                {
                    var usuario = new Usuario();

                    Console.WriteLine("Digite o nome do Usuario");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do Usuario");
                    usuario.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Usuario");
                    usuario.CPF = Console.ReadLine();

                    usuario.Gravar();
                }
                else
                {
                    var usuarios = new Usuario().Ler();
                    foreach (Usuario c in usuarios)
                    {
                        Console.WriteLine("===============================");   
                        Console.WriteLine("Nome: " + c.Nome);
                        Console.WriteLine("Telefone: " + c.Telefone);
                        Console.WriteLine("CPF: " + c.CPF);
                        Console.WriteLine("===============================");
                    }
                }
            }
        }
    }
}
