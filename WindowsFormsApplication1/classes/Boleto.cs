using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Boleto
    {
        int Codigo;
        Empresa umaEmpresa;
        Cliente umcliente;
        Decimal Valor;
        DateTime Data_documento;
        DateTime Data_vencimento;
        int NossoNumero;
        int NumeroDocumento;
        String Situacao;
        String demonstrativo1, demonstrativo2;

        public Boleto()
        {
            umaEmpresa = new Empresa();
            umcliente = new Cliente();
        }
        public int GetCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public Empresa GetumEmpresa
        {
            get { return umaEmpresa; }
            set { umaEmpresa = value; }
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
        public DateTime GetDataDocumento
        {
            get { return Data_documento; }
            set { Data_documento = value; }
        }
        public DateTime GetDataVencimento
        {
            get { return Data_vencimento; }
            set { Data_vencimento = value; }
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
        public String GetDemonstrativo1
        {
            get { return demonstrativo1; }
            set { demonstrativo1 = value; }
        }
        public String GetDemonstrativo2
        {
            get { return demonstrativo2; }
            set { demonstrativo2 = value; }
        }
    }
}
