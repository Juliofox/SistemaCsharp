using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Estado 
    {
        public int Codigo;
        public string estado;
        public Pais umPais;


        public Estado()
        {
            Codigo = 0;
            estado = null;
            umPais = new Pais();
        }

        public int GetCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string getEstado
        {
            get { return estado; }
            set { estado = value; }
        }
        public Pais getumPais
        {
            get { return umPais; }
            set { umPais = value; }
        }

    }
}
