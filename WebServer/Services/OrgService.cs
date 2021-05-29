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
        public async Task<JObject> GetActiveGroups()
        {
            try
            {
                dynamic result = new JObject();
                var activeGroups = await _groupRepository.GetAllActiveGroups();
                result.ActiveGroups = JToken.FromObject(activeGroups) as JObject;
                return result;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public async Task<JObject> GetAllGroups()
        {
            try
            {
                dynamic result = new JObject();
                //var allGroups = await _groupRepository.GetAllGroups();
                Task<List<Egroup>> groups = (Task<List<Egroup>>)await _groupRepository.GetAllGroups();
                result.AllGroups = JToken.FromObject() as JObject;
                return result;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
