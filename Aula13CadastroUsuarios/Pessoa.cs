using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13CadastroUsuarios
{
    internal class Pessoa
    {
        //ATRIBUTOS
        public string nome;
        public int idade;
        public string endereco;
        public string cidade;

        //MÉTODOS
        public Pessoa(string nome, int idade, string endereco, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.cidade = cidade;

        }

    }
}
