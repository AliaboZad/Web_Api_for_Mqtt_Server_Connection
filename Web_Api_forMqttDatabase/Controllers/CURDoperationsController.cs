using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Api_forMqttDatabase.Models;

namespace Web_Api_forMqttDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CURDoperationsController : ControllerBase
    {
        private readonly MqttDatabase_for_testModelContext _db;
        public CURDoperationsController(MqttDatabase_for_testModelContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var g = _db.Tes.ToList();
            await _db.SaveChangesAsync();
            return Ok(g);
        }
    }
}
