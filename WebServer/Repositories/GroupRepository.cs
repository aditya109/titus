using System.Linq;
using System.Threading.Tasks;
using WebServer.Context;
using WebServer.Models;
using WebServer.RepositoryContracts;

namespace WebServer.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        private readonly CoreDbContext _context;

        public GroupRepository(CoreDbContext context)
        {
            _context = context;
        }

        public IQueryable<Egroup> GetAllGroups
        {
            get
            {
                var query = _context.Set<Egroup>().Where(g => g.IsActive != 0).AsQueryable();
                return query;
            }
        }

        public IQueryable<Egroup> GetAllActiveGroups => throw new System.NotImplementedException();
    }
}
