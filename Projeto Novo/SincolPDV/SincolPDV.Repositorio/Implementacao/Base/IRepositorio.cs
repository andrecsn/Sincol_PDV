using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SincolPDV.Repositorio.Implementacao.Base
{
    interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> ListarTodos();
        IQueryable<TEntity> Listar(Func<TEntity, bool> predicate);
        TEntity Buscar(params object[] key);
        void Atualizar(TEntity obj);
        void SalvarTodos();
        void Adicionar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);
    }
}
