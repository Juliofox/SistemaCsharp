using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Cidade 
    {
        public int codigo;
        public string cidade;
        public Estado umEstado;

        public Cidade()
        {
            codigo = 0;
            cidade = null;
            umEstado = new Estado();
        }
        
        public int GetCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string GetCidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public Estado getumEstado
        {
            get { return umEstado; }
            set { umEstado = value; }
        }
    }
}
