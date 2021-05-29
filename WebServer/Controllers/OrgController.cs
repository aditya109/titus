using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using WebServer.ServiceContracts;

namespace WebServer.Controllers
{
    [Route("api/org")]
    [ApiController]
    public class OrgController : ControllerBase
    {
        private readonly IOrgService _orgService;

        public OrgController(IOrgService orgService)
        {
            _orgService = orgService;
        }

        [HttpGet("groups")]
        public async Task<JObject> GetAllGroups()
        {
            return await _orgService.GetAllGroups();
        }

        [HttpGet("group")]
        public string Get([FromQuery(Name = "id")] int id)
        {
            return "Need to get the group with ID=" + id;
        }
    }
}
