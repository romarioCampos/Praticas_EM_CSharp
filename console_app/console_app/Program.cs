using Classes;
using Componentes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Criar();
        }
    }

    #region Códigos de testes das aulas de Orientação a Obejto

    /*class Animal
    {
        public string teste;

        public virtual string teste2()
        {
            return "";
        }
    }

    class Macaco : Animal
    {
        public override string teste2()
        {
            return "ssss";
        }
    }

    partial class Animal
    {
        public string teste;
        partial void tt();
    }

    partial class Animal
    {
        public string teste2;
        partial void tt()
        {
            Console.WriteLine("teste");
        }
    }*/

    /*Email.Instancia.Corpo = "bla bla bla";
            Email.Instancia.Titulo = "Titulo do email";
            Email.Instancia.Origem = "danilo@beminfinito.com.br";
            Email.Instancia.Destino = "danilo@beminfinito.com.br";

            Email.Instancia.EnviarEmail();

            var a = new Animal();
            a.teste = "";

            var c = new Cachorro();
            c.Idade = 1;
            Console.WriteLine(c.Idade);

            c.Idade2 = 1;
            
            Console.WriteLine(c.Idade2);

            var cachorro = new Cachorro();
            cachorro.Latir();*/

    /*Console.WriteLine("============== Cadastro de Cliente ==============");
            Cliente c = new Cliente();
            c.Nome = "Cliente";
            c.Telefone = "156856";
            c.CPF = "16868552";
            c.Gravar();
            foreach (Cliente cl in new Cliente().Ler())
            {
                Console.WriteLine(cl.Nome);
                Console.WriteLine(cl.Telefone);
                Console.WriteLine(cl.CPF);
                Console.WriteLine("============================");
            }

            Console.WriteLine("============= Cadastro de usuario ===============");
            Usuario u = new Usuario();
            u.Nome = "Usuario";
            u.Telefone = "156856";
            u.CPF = "16868552";
            u.Gravar();
            foreach (Usuario us in new Usuario().Ler())
            {
                Console.WriteLine(us.Nome);
                Console.WriteLine(us.Telefone);
                Console.WriteLine(us.CPF);
                Console.WriteLine("============================");
            }

            /*Ferramentas f = new Ferramentas();
            bool d = f.ValidarCPF("sdasdsad");

            Cliente c = new Cliente();
            c.CalcularUmMaisDois4();
            Console.WriteLine("============ Cadastro de Usuario ================");*/
    #endregion
}
