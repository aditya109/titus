using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Context;
using WebServer.Models;
using WebServer.RepositoryContracts;

namespace WebServer.Repositories
{
    public class GroupRepository: IGroupRepository
    {
        private readonly CoreDbContext _context;

        public GroupRepository(CoreDbContext context)
        {
            _context = context;
        }

        public IQueryable<Egroup> GetAllGroups()
        {
            return _context.Set<Egroup>().AsQueryable();
        }

        public IQueryable<Egroup> GetAllActiveGroups()
        {
            return _context.Set<Egroup>().Where(group => group.IsActive == 1).AsQueryable();
        }
    }
}
