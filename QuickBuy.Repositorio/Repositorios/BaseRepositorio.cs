using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntiety> : IBaseRepositorio<TEntiety> where TEntiety : class
    {
        public BaseRepositorio()
        {

        }
        public void Adicionar(TEntiety entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntiety entity)
        {
            throw new NotImplementedException();
        }


        public TEntiety ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntiety> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntiety entity)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
