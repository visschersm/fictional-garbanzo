using System;
using Garbanzo.Domain.Entities;
using Garbanzo.DataLayer.Interfaces;
using System.Threading.Tasks;

namespace Garbanzo.DataLayer.DataApi
{
    public class BlogRepository : IRepository<Blog>
    {
        public Task<TView> Create<TView>()
        {
            throw new NotImplementedException();
        }

        public Task<TView> Create<TView>(System.Linq.Expressions.Expression<Func<Blog, TView>> select)
        {
            throw new NotImplementedException();
        }

        public Task<TView> Read<TView>()
        {
            throw new NotImplementedException();
        }

        public Task<TView> Read<TView>(System.Linq.Expressions.Expression<Func<Blog, TView>> select)
        {
            throw new NotImplementedException();
        }
    }
}
