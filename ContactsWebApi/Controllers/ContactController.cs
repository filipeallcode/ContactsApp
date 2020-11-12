using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContactsWebApi.Data;
using ContactsWebApi.Models;

namespace ContactsWebApi.Controllers
{
    [ApiController]
    [Route("v1/contacts")]
    public class ContactController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Contact>>> Get ([FromServices] DataContext context)
        {
            var contacts = await context.Contacts.ToListAsync();
            return contacts;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Contact>> Post ([FromServices] DataContext context, [FromBody] Contact model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else {
                context.Contacts.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
        }
    }
}