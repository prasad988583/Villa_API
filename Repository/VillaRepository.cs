using System.Linq.Expressions;
using Villa_API.Model;
using Villa_API.Repositry.IREpositry;

namespace Villa_API.Repository
{
    public class VillaRepository : IVillaRepository
    {
        public Task Create(Villa entity)
        {
            throw new NotImplementedException();
        }

        public Task<Villa> Get(Expression<Func<Villa>> filter = null, bool tracked = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<Villa>> GetAll(Expression<Func<Villa>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Villa entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
