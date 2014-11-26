using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Hospedagem.classes
{
    public class Hosts
    {
        int Codigo;
        String Dominio;
        Plano umPlano;
        Cliente umCliente;
        DateTime data_inicio;
        DateTime data_fim;
        String Situacao;

        public Hosts()
        {
            umPlano = new Plano();
            umCliente = new Cliente();
        }
        public int GetCodigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public String GetDominio
        {
            get { return Dominio; }
            set { Dominio = value; }
        }
        public Plano Getumplano
        {
            get { return umPlano; }
            set { umPlano = value; }
        }
        public Cliente Getumcliente
        {
            get { return umCliente; }
            set { umCliente = value; }
        }
        public DateTime GetDatainicio
        {
            get { return data_inicio; }
            set { data_inicio = value; }
        }
        public DateTime GetDatafim
        {
            get { return data_fim; }
            set { data_fim = value; }
        }
        public String GetSituacao
        {
            get { return Situacao; }
            set { Situacao = value; }
        }
    }
    
}
