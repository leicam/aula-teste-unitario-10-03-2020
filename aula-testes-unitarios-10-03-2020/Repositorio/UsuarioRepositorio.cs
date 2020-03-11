using aula_testes_unitarios_10_03_2020.Entidades;
using aula_testes_unitarios_10_03_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Repositorio
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio()
        {
            Entidade.Add(new Usuario("admin", "admin"));
        }

        public void AlterarSenha(Usuario usuario)
        {
            var retorno = GetAll()
                .FirstOrDefault(x
                => x.Nome.Equals(usuario.Nome)
                && x.Senha.Equals(usuario.Senha));

            if (retorno == null)
            {
                Console.WriteLine("Usuario ou Senha inválidos!");
                return;
            }

            Console.WriteLine("Informe uma nova senha: ");
            var novaSenha = Console.ReadLine();

            Console.WriteLine("Confirme sua senha: ");
            var confirmacaoSenha = Console.ReadLine();

            if(!novaSenha.Equals(confirmacaoSenha))
            {
                Console.WriteLine("Senha e Confirmação diferentes.! Verifique.");
                return;
            }

            try
            {
                retorno.AlterarSenha(novaSenha);
                Update(retorno);
                Console.WriteLine("Senha alterada com sucesso.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            var retorno = GetAll()
                .FirstOrDefault(x
                => x.Nome.Equals(usuario.Nome));

            if (retorno != null)
            {
                Console.WriteLine("Nome de usuário já cadastrado!");
                return;
            }

            Add(usuario);
            Console.WriteLine($"Usuário {usuario.Nome} cadastrado com sucesso!");
        }

        public void Login(Usuario usuario)
        {
            var retorno = GetAll()
                .FirstOrDefault(x 
                => x.Nome.Equals(usuario.Nome) 
                && x.Senha.Equals(usuario.Senha));

            if (retorno != null)
                Console.WriteLine($"Bem vindo {usuario.Nome}");
            else
                Console.WriteLine("Usuário ou senha inválidos! Verifique.");
        }
    }
}