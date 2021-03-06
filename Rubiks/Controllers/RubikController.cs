using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            using (var db = new RubikContext())
            {
                IEnumerable<RubikCube> rubiks = db.RubikCube.ToList();
                return Ok(rubiks);
            };
        }

        [HttpGet("{id}")]
        public ActionResult<RubikCube> GetById(int id)
        {
           using (var db = new RubikContext())
            {
                var rubik = db.RubikCube.First(c => c.RubikId == id);

                return Ok(rubik);
            };
           


        }

        [HttpPost]
        public ActionResult<IEnumerable<RubikCube>> Post(RubikCube rubikCube)
        {
            using (var db = new RubikContext())
            {
                List<RubikCube> rubikList= new List<RubikCube>();
                rubikList.Add(rubikCube);
                db.BulkInsert(rubikList);
            }
           
            return Ok(rubikCube);
        }
    }
}