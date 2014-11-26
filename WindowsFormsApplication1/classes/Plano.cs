using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Plano
    {
        int Codigo;
        String Nome;
        Decimal valor_mensal;
        Decimal valor_trimestral;
        Decimal valor_semestral;
        Decimal valor_anual;
        

        public Plano()
        {

        }
        public int GetCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public String GetNome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public Decimal GetValorMensal
        {
            get { return valor_mensal; }
            set { valor_mensal = value; }
        }
        public Decimal GetValorTrimestral
        {
            get { return valor_trimestral; }
            set { valor_trimestral = value; }
        }
        public Decimal GetValorSemestral
        {
            get { return valor_semestral; }
            set { valor_semestral = value; }
        }
        public Decimal GetValorAnual
        {
            get { return valor_anual; }
            set { valor_anual = value; }
        }

    }
}
