using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HUE01_ContactList.Controllers
{
    [Route("api/contact-list")]
    [ApiController]
    public class ContactListController : ControllerBase
    {
        List<IContactList> contacts = new List<IContactList>();

        // GET: api/ContactList
        [HttpGet]
        public IActionResult GetAllItems()
        {
            return Ok(contacts);
        }

        // GET: api/ContactList/5
        [HttpGet("{firstname}", Name = "Get")]
        //public IContactList GetContact(String firstname)
        //{
        //    for(int i=0; i<contacts.Count; i++)
        //    {
        //        if (contacts[i].Firstname.Equals(firstname))
        //        {
        //            return Ok(contacts[i]);
        //        }
        //    }
        //    return BadRequest("Invalid Name");
        //}

        // POST: api/ContactList
        [HttpPost]
        public IActionResult AddContact([FromBody] IContactList contact)
        {
            this.contacts.Add(contact);
            return CreatedAtRoute("GetSpecificItem", new { index = contacts.IndexOf(contact) }, contact);
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        [Route("{index}")]
        public IActionResult DeleteItem(int index)
        {
            if (index >= 0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
                return NoContent();
            }

            return BadRequest("Invalid index");
        }
    }
}
