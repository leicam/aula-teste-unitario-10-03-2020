using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Entidades
{
    public class Usuario
    {
        public string Nome { get; private set; }
        public string Senha { get; private set; }

        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public void AlterarSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("Senha inválida!");

            Senha = senha;
        }
    }
}
