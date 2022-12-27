using System.Linq.Expressions;
using Villa_API.Model;

namespace Villa_API.Repositry.IREpositry
{
    public interface IVillaRepository
    {
        Task<List<Villa>> GetAll(Expression<Func<Villa>>filter =null);
        Task<Villa> Get(Expression<Func<Villa>> filter = null, bool tracked=true);
        Task Create(Villa entity);
        Task Remove(Villa entity);
        Task Save();
    }
}
