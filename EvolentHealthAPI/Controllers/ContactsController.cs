using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EvolentHealthAPI.AutoMapper;
using EvolentHealthAPI.Models;
using EvolentHealthAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvolentHealthAPI.Controllers
{
    [Route("api/v1/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsRepository _contactsRepository;
        private readonly IMapper _mapper;
        public ContactsController(IContactsRepository contactsRepository,IMapper mapper)
        {
            _contactsRepository = contactsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var contactsList = await _contactsRepository.GetContacts();
                if (contactsList != null)
                {
                    return Ok(_mapper.Map<List<Contact>>(contactsList));
                }
                else return NoContent();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return NotFound("Something went wrong!");
            }
        }

        [HttpGet]
        [Route("Getcontactbyid/{id}")]
        public async Task<IActionResult> GetContactById(int id)
        {
            try
            {
                var contactsList = await _contactsRepository.GetContactsById(id);
                if (contactsList != null)
                {
                    return Ok(_mapper.Map<List<Contact>>(contactsList));
                }
                else return NoContent();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return NotFound("Something went wrong!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Contact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = _mapper.Map<Contact>(contact);
                    var success = await _contactsRepository.CreateContact(data);
                    return Ok(success);
                }
                else return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return NotFound("Something went wrong!");
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Contact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = _mapper.Map<Contact>(contact);
                    var success = await _contactsRepository.UpdateContactsById(data);
                    return Ok(success);
                }
                else return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return NotFound("Something went wrong!");
            }
        }
        [HttpPut]
        [Route("UpdateStatus/{id}/{status}")]
        public async Task<IActionResult> UpdateStatus(int id,string status)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var success = await _contactsRepository.UpdateStatus(id,status);
                    return Ok(success);
                }
                else return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return NotFound("Something went wrong!");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var contactsList =await _contactsRepository.RemoveContactsById(id);
                return Ok(contactsList);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return NotFound("Something went wrong!");
            }
        }
    }
}
