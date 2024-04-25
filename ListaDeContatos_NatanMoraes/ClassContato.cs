using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatos_NatanMoraes
{
    internal class ClassContato
    {
        //Declaração das variáveis.
        private string nome;
        private string sobrenome;
        private string telefone;

        //Propriedades. (São os métodos "get" ou "set")
        //get = leitura.
        //set = definição
        //É possivel ser somente leitura, ou somente definição.
        public string Nome
        {   get    
            { 
                return nome; 
            }
            set
            {
                nome = value;
            }
        }
        public string Sobrenome
        {   get 
            { 
                return sobrenome; 
            }
            set 
            {
                sobrenome = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "(00) 00000-0000";
                }
            }
        }
            
            //Construtor da Classe
            public ClassContato() 
            {
                Nome = "Claúde";
                Sobrenome = "Sim";
                Telefone = "(11)99999-9999";
            }

             //Sobrecarga do método construtor da classe "ClassContato"
            public ClassContato(string nome, string sobrenome, string telefone)
            {
            Nome = nome;
            Sobrenome = sobrenome; 
            Telefone = telefone;
            }

        //Polimorfismo
        //Todas as classes são filhas de object (Herança)
        //"override" sobrescreve o método da classe pai (Polimorfismo)
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0} {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}",
                Telefone.Substring(0,2),
                Telefone.Substring(2,5),
                Telefone.Substring(7,4));

            return saida;
        }
    }
}
