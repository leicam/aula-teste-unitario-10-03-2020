using aula_testes_unitarios_10_03_2020.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_testes_unitarios_10_03_2020.Repositorio
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T>
    {
        protected List<T> Entidade = new List<T>();

        public void Add(T entidade) => Entidade.Add(entidade);
        public ICollection<T> GetAll() => Entidade;
        public void Remove(T entidade) => Entidade.Remove(entidade);

        public void Update(T entidade)
        {
            Remove(entidade);
            Add(entidade);
        }
    }
}
