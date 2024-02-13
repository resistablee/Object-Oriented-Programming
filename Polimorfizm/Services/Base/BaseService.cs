using Polimorfizm.Models.Base;

namespace Polimorfizm.Services.Base
{
    public class BaseService<TEntity> where TEntity : BaseEntity
    {
        public void Add(TEntity entity)
        {
            // Add operation
        }

        public void Update(TEntity entity)
        {
            // Update operation
        }
    }
}
