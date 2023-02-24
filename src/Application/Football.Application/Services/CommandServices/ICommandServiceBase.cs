using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Services
{
    public interface ICommandServiceBase<T>
    {   
        Task Insert(T entity);

        Task InsertRange(IEnumerable<T> entities);

        Task Update(T entity);

        Task Delete(T entity);

        Task Delete(object id);

        Task DeleteRange(IEnumerable<T> entities);
    }
}
