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
        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.TicketRequest model)
        {
            using (Models.FueraBugsDataContext db = new Models.FueraBugsDataContext())
            {
                Models.Ticket oTicket = new Models.Ticket();
                oTicket.Title = model.Title;
                oTicket.Description = model.Description;
                oTicket.Priority = model.Priority;
                oTicket.Status = model.Status;
                db.Ticket.Add(oTicket);
                db.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]

        public ActionResult Put([FromBody] Models.Request.TicketEditRequest model)
        {
            using (Models.FueraBugsDataContext db = new Models.FueraBugsDataContext())
            {
                Models.Ticket oTicket = db.Ticket.Find(model.Id);
                oTicket.Title = model.Title;
                oTicket.Description = model.Description;
                oTicket.Priority = model.Priority;
                oTicket.Status = model.Status;
                db.Entry(oTicket).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.TicketEditRequest model)
        {
            using (Models.FueraBugsDataContext db = new Models.FueraBugsDataContext())
            {
                Models.Ticket oTicket = db.Ticket.Find(model.Id);
                db.Ticket.Remove(oTicket);
                db.SaveChanges();
            }
            return Ok();
        }

    }
}
