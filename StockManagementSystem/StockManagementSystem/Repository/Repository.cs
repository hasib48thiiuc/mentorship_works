using Microsoft.EntityFrameworkCore;
using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ApplicationDbContext _ctx;

        protected DbSet<TEntity> _dbset;


        public Repository(ApplicationDbContext ctx)
        {
            _ctx = ctx;

            _dbset = _ctx.Set<TEntity>();

        }

        public void Add(TEntity item)
        {
            _dbset.Add(item);
        }

        public IEnumerable<TEntity> GetAll()
        {
            IEnumerable<TEntity> items = _dbset.ToList();

            return items;


        }
        public TEntity GetById(int id)
        {
            var item = _dbset.Find(id);
            return item;

        }




        public void Update(TEntity item)
        {
            _dbset.Update(item);

        }

        public void Delete(int id)
        {
            if (_dbset.Find(id) != null)
            {
                _dbset.Remove(_dbset.Find(id));
            }
        }
    }
}
