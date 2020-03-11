using aula_testes_unitarios_10_03_2020.Entidades;
using aula_testes_unitarios_10_03_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    public class AlterarSenhaUsuarioServico : ISubitemMenu
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public AlterarSenhaUsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua senha: ");
            var senhaUsuario = Console.ReadLine();

            _usuarioRepositorio.AlterarSenha(new Usuario(nomeUsuario, senhaUsuario));
        }
    }
}
