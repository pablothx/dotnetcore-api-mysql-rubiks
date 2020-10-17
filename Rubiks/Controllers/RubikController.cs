using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Rubiks.Data;
using Rubiks.Models;

namespace Rubiks.Controllers
{
    [Route("api/rubiks")]
    [ApiController]
    public class RubikController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<RubikCube>> Get()
        {
            var db = new RubikContext();
            IEnumerable<RubikCube> rubiks = db.RubikCube.ToList();
            return Ok(rubiks);
        }

        [HttpPost]
        public void Post(IEnumerable<RubikCube> rubikCube)
        {
            // using (var db = new RubikContext())
            // {
            // var rubikCubedes = JsonSerializer.Deserialize(rubikCube);
            // db.BulkInsert(rubikCubedes,
            //               options => options.IncludeGraph = true);
            
            // }
        }
    }
}