using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ProS.GestaoServico.Repositorio
{
    public class RepositorioBase<T> : IDisposable
        where T : class
    {
        private bool disposed = false;
        private ProSDbContext contexto;

        public RepositorioBase()
        {
            contexto = new ProSDbContext();
        }

        protected IQueryable<T> Entidade
            => contexto.Set<T>();

        public T inserir(T entidade)
        {
            contexto.Set<T>().Add(entidade);
            contexto.SaveChanges();
            return entidade;
        }

        public IQueryable<T> Select(params string[] includes)
        {
            var query = contexto.Set<T>().AsQueryable();

            if (includes.Any())
            {
                query = includes.Aggregate(query, (current, include) => current.Include(include));
            }

            return query;
        }

        public IQueryable<T> Select(Expression<Func<T, bool>> expression, params string[] includes)
        {
            var query = contexto.Set<T>().AsQueryable();

            if (includes.Any())
            {
                if (expression != null)
                {
                    query = includes.Aggregate(query.Where(expression), (current, include) => current.Include(include));
                }
                else
                {
                    query = includes.Aggregate(query, (current, include) => current.Include(include));
                }
            }
            else
            {
                if (expression != null)
                {
                    query = query.Where(expression);
                }
            }
            return query;
        }

        public T Select(int id)
        {
            return contexto.Set<T>().Find(id);
        }

        //public void Atualizar(int id, object entidade)
        //{
        //    var entidadeAtual = this.Obter(id);

        //    contexto.Set<T>().Attach(entidadeAtual);
        //    contexto.Entry(entidadeAtual).CurrentValues.SetValues(entidade);

        //    contexto.SaveChanges();
        //}

        //public void Excluir(int _id)
        //{
        //    var entidade = new
        //    {
        //        Excluido = true
        //    };

        //    this.Atualizar(_id, entidade);
        //}

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (contexto != null) contexto.Dispose();
                }
                contexto = null;
                disposed = true;
            }
        }
    }
}
