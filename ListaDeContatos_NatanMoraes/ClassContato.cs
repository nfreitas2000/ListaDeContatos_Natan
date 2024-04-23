using System;
using System.Collections.Generic;
using System.Linq;
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
            public ClassContato(string nome, string sobrenome, string telefone)
            {

            }
    }
}
