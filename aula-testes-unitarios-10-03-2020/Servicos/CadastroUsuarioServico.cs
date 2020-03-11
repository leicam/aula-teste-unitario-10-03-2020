using aula_testes_unitarios_10_03_2020.Entidades;
using aula_testes_unitarios_10_03_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Servicos
{
    public class CadastroUsuarioServico : ISubitemMenu
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public CadastroUsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Executar()
        {
            Console.WriteLine("Informe seu usuário: ");
            var nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua senha: ");
            var senhaUsuario = Console.ReadLine();

            _usuarioRepositorio.Cadastrar(new Usuario(nomeUsuario, senhaUsuario));
        }
    }
}
