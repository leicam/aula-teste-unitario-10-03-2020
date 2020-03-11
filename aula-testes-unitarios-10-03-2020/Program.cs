using aula_testes_unitarios_10_03_2020.Entidades;
using aula_testes_unitarios_10_03_2020.Interfaces;
using aula_testes_unitarios_10_03_2020.Repositorio;
using aula_testes_unitarios_10_03_2020.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020
{
    class Program
    {
        private static readonly UsuarioRepositorio _usuarioRepositorio = new UsuarioRepositorio();
        private static IList<ItemMenu> _itensMenu;

        static void Main(string[] args)
        {
            _itensMenu = GetMenuItems();

            while (true)
            {
                ImprimirMenuItems(_itensMenu);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out int valorOpcao);

                if (valorOpcao == 0)
                    break;

                if (valorOpcao > _itensMenu.Count)
                    break;

                Executar(valorOpcao);
            }
        }

        private static IList<ItemMenu> GetMenuItems()
            => new List<ItemMenu>
            {
                new ItemMenu("Login"),
                new ItemMenu("Cadastro de Usuario"),
                new ItemMenu("Alterar Senha"),
            };

        private static void Executar(int valorOpcao)
        {
            ISubitemMenu subitemSelecionado;
            ItemMenu itemMenu = _itensMenu[valorOpcao - 1];
            subitemSelecionado = GetInstance(itemMenu);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {itemMenu.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            subitemSelecionado.Executar();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
            Console.ReadKey();
        }

        private static ISubitemMenu GetInstance(ItemMenu item)
        {
            if (item.Titulo.Equals("Login"))
                return new LoginService(_usuarioRepositorio);
            if (item.Titulo.Equals("Cadastro de Usuario"))
                return new CadastroUsuarioServico(_usuarioRepositorio);
            if (item.Titulo.Equals("Alterar Senha"))
                return new AlterarSenhaUsuarioServico(_usuarioRepositorio);

            return null;
        }

        private static void ImprimirMenuItems(IList<ItemMenu> itensMenu)
        {
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");
            foreach (var item in itensMenu)
                Console.WriteLine((i++).ToString() + " - " + item.Titulo);
        }
    }
}
