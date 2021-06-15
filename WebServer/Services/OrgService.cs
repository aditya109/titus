using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebServer.Models;
using WebServer.RepositoryContracts;
using WebServer.ServiceContracts;

namespace WebServer.Services
{
    public class OrgService : IOrgService
    {
        private readonly IGroupRepository _groupRepository;

        public OrgService(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public Task<JObject> GetActiveGroups()
        {
            throw new System.NotImplementedException();
        }

        public async Task<JObject> GetAllGroups()
        {
            try
            {
                dynamic result = new JObject();
                var getAllGroupsQuery = await _groupRepository.GetAllGroups;

                result.AllGroups = JToken.FromObject(getAllGroupsQuery) as JObject;
                return result;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
