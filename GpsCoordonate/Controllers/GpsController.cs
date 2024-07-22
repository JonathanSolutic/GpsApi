using GpsCoordonate.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace GpsCoordonate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GpsController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] GpsCoordinate gpsCoordonate)
        {
            if (gpsCoordonate == null) return BadRequest();

            return Ok(gpsCoordonate);
        }
        
    }
}
