using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntiety> : IBaseRepositorio<TEntiety> where TEntiety : class
    {
        protected readonly QuickBuyContexto QuickBuyContexto;

        //ctor Code Snippet
        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            QuickBuyContexto = quickBuyContexto;
        }
        public void Adicionar(TEntiety entity)
        {
            QuickBuyContexto.Set<TEntiety>().Add(entity);
            QuickBuyContexto.SaveChanges();
        }
        public void Atualizar(TEntiety entity)
        {
            QuickBuyContexto.Set<TEntiety>().Update(entity);
            QuickBuyContexto.SaveChanges();
        }
        public TEntiety ObterPorId(int id)
        {
            return QuickBuyContexto.Set<TEntiety>().Find(id);
        }
        public IEnumerable<TEntiety> ObterTodos()
        {
            return QuickBuyContexto.Set<TEntiety>().ToList();
        }
        public void Remover(TEntiety entity)
        {
            QuickBuyContexto.Set<TEntiety>().Remove(entity);
            QuickBuyContexto.SaveChanges();
        }
        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }
    }
}
