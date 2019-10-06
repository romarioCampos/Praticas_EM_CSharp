using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componentes
{
    public class Ferramentas
    {
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este metodo so pode ser acessado dentro deste assembly componentes";
        }

        public string MetodoParaTodoQueUtilizarOAssembly()
        {
            return "Este metodo e para todos";
        }

        public bool ValidarCPF(string cpf)
        {
            return true;
        }
    }
}
