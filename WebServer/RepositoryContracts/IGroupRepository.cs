using System.Linq;
using WebServer.Models;

namespace WebServer.RepositoryContracts
{
    public interface IGroupRepository
    {
        IQueryable<Egroup> GetAllGroups { get; }

        IQueryable<Egroup> GetAllActiveGroups { get; }
    }
}
