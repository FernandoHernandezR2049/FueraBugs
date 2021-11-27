using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FueraBugsDataManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using(Models.FueraBugsDataContext db = new Models.FueraBugsDataContext())
            {
                var lst = (from d in db.Ticket
                          select d).ToList();
                return Ok(lst);
            }
        }

    }
}
