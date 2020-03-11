using aula_testes_unitarios_10_03_2020.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_teste_unitario_10_03_2020.Teste.Entidades
{
    [TestClass]
    public class UsuarioTeste
    {
        private const string _owner = "Juliano";
        private const string _category = "Usuario";

        [TestMethod]
        [Owner(_owner)]
        [TestCategory(_category)]
        public void Usuario_Instancia_Sucesso()
        {
            var usuario = new Usuario("Teste", "Teste");

            Assert.IsNotNull(usuario);
        }
    }
}
