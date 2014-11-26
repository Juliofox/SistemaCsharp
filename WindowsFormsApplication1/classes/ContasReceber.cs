using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class ContasReceber
    {
        int Codigo;
        Cliente umcliente;
        Decimal Valor;
        DateTime Data_documento;
        DateTime Data_vencimento;
        int NossoNumero;
        int NumeroDocumento;
        String Situacao, Servico;

        public ContasReceber()
        {
            umcliente = new Cliente();
        }
        public int GetCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public Cliente GetumCliente
        {
            get { return umcliente; }
            set { umcliente = value; }
        }
        public Decimal GetValor
        {
            get { return Valor; }
            set { Valor = value; }
        }
        public DateTime GetData_vencimento
        {
            get { return Data_vencimento; }
            set { Data_vencimento = value; }
        }
        public DateTime GetData_documento
        {
            get { return Data_documento; }
            set { Data_documento = value; }
        }
        public int GetNossoNumero
        {
            get { return NossoNumero; }
            set { NossoNumero = value; }
        }
        public int GetNumeroDocumento
        {
            get { return NumeroDocumento; }
            set { NumeroDocumento = value; }
        }
        public String GetSituacao
        {
            get { return Situacao; }
            set { Situacao = value; }
        }
        public String GetServico
        {
            get { return Servico; }
            set { Servico = value; }
        }
    }
}
