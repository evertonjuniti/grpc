using Microsoft.AspNetCore.Mvc;
using NetCoreHelperLib;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IIso8583Service iso8583Service;

        public MessageController(IIso8583Service iso8583Service)
        {
            this.iso8583Service = iso8583Service;
        }

        [HttpGet("{id}")]
        public List<PackedModel> Get(int id)
        {
            return iso8583Service.Transform(id.ToString());
        }
    }
}
