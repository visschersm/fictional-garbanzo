using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Garbanzo.DataLayer.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task<TView> Create<TView>();
        Task<TView> Create<TView>(Expression<Func<TEntity, TView>> select);

        Task<TView> Read<TView>();
        Task<TView> Read<TView>(Expression<Func<TEntity, TView>> select);
    }

    public static class Extensions
    {
        public static Task<TView> Select<TEntity, TView>(this IRepository<TEntity> source, Expression<Func<TEntity, TView>> select)
        {
            throw new NotImplementedException();
        }
    }
}