﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using SincolPDV.Repositorio.Compartilhado;

namespace SincolPDV.Repositorio.Implementacao.Base
{
    public abstract class Repositorio<TEntity> : IDisposable,
       IRepository<TEntity> where TEntity : class
    {
        Contexto contexto = new Contexto();

        public IQueryable<TEntity> ListarTodos()
        {
            return contexto.Set<TEntity>();
        }

        public IQueryable<TEntity> Listar(Func<TEntity, bool> predicate)
        {
            return ListarTodos().Where(predicate).AsQueryable();
        }

        public TEntity Buscar(params object[] key)
        {
            return contexto.Set<TEntity>().Find(key);
        }

        public void Atualizar(TEntity obj)
        {
            contexto.Entry(obj).State = EntityState.Modified;
        }

        public void SalvarTodos()
        {
            contexto.SaveChanges();
        }

        public void Adicionar(TEntity obj)
        {
            contexto.Set<TEntity>().Add(obj);
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            contexto.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => contexto.Set<TEntity>().Remove(del));
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
