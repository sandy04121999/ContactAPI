using ContactsManagementAPI.Models;
using ContactsManagementAPI.Models.DTO;
using ContactsManagementAPI.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContactsManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        public ContactController( IContactRepository contactRepository) { 
        
           this._contactRepository = contactRepository;
        }
        // GET: api/<ContactController>
        [HttpGet]
        public ActionResult<List<Contact>> GetAllContact()
        {
            try
            {
                return Ok(_contactRepository.GetAll());
            
            }
            catch (Exception ex)
            {
                return BadRequest("Issue to retrive contact details");
            }
        }
        [HttpPost]
        public IActionResult CreateContact([FromBody] ContactDTO contact)
        {
            try
            {
                 List<Contact> contacts = _contactRepository.GetAll();
                var isCreated = _contactRepository.CreateContact(contact);
                if (isCreated)
                {
                     Ok(CreatedAtAction(nameof(GetAllContact), contacts));
                }
                return Ok(isCreated);
            }
            catch(Exception ex)
            {
                return BadRequest("Contact detail is not save.");
            }
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, [FromBody] ContactDTO contact)
        {
            try
            {
                List<Contact> contacts = _contactRepository.GetAll();
                var isUpdate = _contactRepository.UpdateContact(contact, id);
                if (isUpdate)
                {
                     Ok(CreatedAtAction(nameof(GetAllContact), contacts));
                }
                return Ok(isUpdate);
            }
            catch(Exception ex)
            {
                return BadRequest("Contact detail is not update.");
            }
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
           try
            {
                List<Contact> contacts = _contactRepository.GetAll();
                var isDelete = _contactRepository.DeleteContact(id);
                if (isDelete)
                {
                    Ok(CreatedAtAction(nameof(GetAllContact), contacts));
                }
                return Ok(isDelete);

            }
            catch (Exception ex)
            {
                return BadRequest("Contact detail is not delete.");
            }
        }
    }
}
