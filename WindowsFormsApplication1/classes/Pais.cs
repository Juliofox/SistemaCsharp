using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Pais
    {
        public int Codigo;
        public string pais;
        public DateTime data_cad;
        public DateTime data_alt;

        public Pais()
        {
            Codigo = 0;
            pais = null;
        }
        public int GetCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string GetPais
        {
            get { return pais; }
            set { pais = value; }
        }
        public DateTime GetData_cad
        {
            get { return data_cad; }
            set { data_cad = value; }
        }
        public DateTime GetData_alt
        {
            get { return data_alt; }
            set { data_alt = value; }
        }
    }
}
