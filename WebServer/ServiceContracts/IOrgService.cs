using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer.ServiceContracts
{
    public interface IOrgService
    {
        Task<JObject> GetActiveGroups();

        Task<JObject> GetAllGroups();
    }
}
