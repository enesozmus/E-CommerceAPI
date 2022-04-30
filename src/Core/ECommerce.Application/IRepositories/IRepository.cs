using ECommerce.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Application.IRepositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
