using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Cliente : Pessoa
    {
        public string rg;
        public string cpf;

        public Cliente()
        {
            rg = null;
            cpf = null;
        }
        public string GetRg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string GetCpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

    }
}
