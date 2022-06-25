using System.Threading.Tasks;
using System.Web.Http;
using TheCodeCamp.Data;

namespace TheCodeCamp.Controllers
{
    public class CampsController : ApiController
    {

        private readonly ICampRepository _campRepository;
        public CampsController(ICampRepository campRepository)
        {
            _campRepository = campRepository;
        }
        public async Task<IHttpActionResult> Get()
        {
            var result = await _campRepository.GetAllCampsAsync();
            
            return Ok(result);
        }
    }
}

