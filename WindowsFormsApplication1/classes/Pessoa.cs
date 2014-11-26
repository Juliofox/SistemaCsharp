using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospedagem.classes
{
    public class Pessoa
    {
        public int codigo;
        public string nome;
        public string logradouro;
        public string numero;
        public string complemento;
        public string bairro;
        public string cep;
        public string telefone;
        public string celular;
        public string email;
        public DateTime data_nascimento;
        public DateTime data_cad;
        public DateTime data_alt;
        public Cidade umaCidade;

        public Pessoa()
        {
            codigo = 0;
            nome = null;
            logradouro = null;
            numero = null;
            complemento = null;
            bairro = null;
            cep = null;
            telefone = null;
            celular = null;
            email = null;
            umaCidade = new Cidade();
            
            //umaCidade.getumEstado.getumPais.GetCodigo = 1;
            //minhacidade.GetCidade = "Foz do Iguaçu";
            //minhacidade.getEstado = "Parana";
            //minhacidade.GetPais = "Brasil";
        }
        public int GetCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string GetNome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string GetLogradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        public string GetNumero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string GetComplemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string GetBairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string GetCep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string GetTelefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string GetCelular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string GetEmail
        {
            get { return email; }
            set { email = value; }
        }
        public DateTime GetData_nascimento
        {
            get { return data_nascimento; }
            set { data_nascimento = value; }
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
        public Cidade getumaCidade
        {
            get { return umaCidade; }
            set { umaCidade = value; }
        }
    }
}
