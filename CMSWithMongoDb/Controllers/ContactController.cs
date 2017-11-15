using BusinessLogicLayer.Contact;
using RepoPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace CMSWithMongoDb.Controllers
{
    [RoutePrefix("api/contact/activity")]
    public class ContactController : ApiController
    {
        private readonly ContactActivity activity = new ContactActivity();

        [Route("GetAll")]
        public async Task<IEnumerable<Contacts>> GetContacts()
        {
            return await activity.GetAllContacts();
        }

        [Route("Save")]
        [HttpPost]
        public async Task<IHttpActionResult> AddContact(Contacts contact)
        {
            ContactOperation operation = new ContactOperation();
            try
            {
                await operation.AddContact(contact);
                return Ok("Success");
            }
            catch
            {
                return BadRequest("Internal Server Problem");
            }
        }
    }
}
