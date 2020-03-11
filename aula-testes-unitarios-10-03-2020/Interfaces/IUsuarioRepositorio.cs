using aula_testes_unitarios_10_03_2020.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Interfaces
{
    public interface IUsuarioRepositorio
    {
        void Login(Usuario usuario);
        void Cadastrar(Usuario usuario);
        void AlterarSenha(Usuario usuario);
    }
}
