using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Empresa : Pessoa
    {
        public string ie;
        public string cnpj;

        public Empresa()
        {
            ie = null;
            cnpj = null;
        }
        public string GetIe
        {
            get { return ie; }
            set { ie = value; }
        }
        public string GetCnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
    }
}
