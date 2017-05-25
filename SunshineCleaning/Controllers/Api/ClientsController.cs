using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SunshineCleaning.Models;
using SunshineCleaning.Dtos;
using AutoMapper;

namespace SunshineCleaning.Controllers.Api
{
    public class ClientsController : ApiController

    {
        private ApplicationDbContext _context;

        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/CLIENTS         //public IEnumerable<ClientDto> GetClients()
        public IHttpActionResult GetClients()
        {
            var clientDtos = _context.Clients
                .Include(c => c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Client, ClientDto>);

            return Ok(clientDtos);
            //return _context.Clients.ToList().Select(Mapper.Map<Client, ClientDto>);
        }

        //GET /API/CLIENTS/1    
        public IHttpActionResult GetClient(int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (client == null)
               return NotFound();

            return Ok(Mapper.Map<Client, ClientDto>(client));
        }

        // POST /API/CLIENTS
        [HttpPost]
        public IHttpActionResult CreateClient(ClientDto clientDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var client = Mapper.Map<ClientDto, Client>(clientDto);
            _context.Clients.Add(client);
            _context.SaveChanges();

            clientDto.Id = client.Id;

            return Created(new Uri(Request.RequestUri + "/" + client.Id), clientDto);
        }

        //PUT /API/CLIENTS/1
        [HttpPut]
        public void UpdateClient(int id, ClientDto clientDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var clientInDb = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (clientInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<ClientDto, Client>(clientDto, clientInDb);
            //clientInDb.Name = clientDto.Name;
            //clientInDb.Address = clientDto.Address;
            //clientInDb.PhoneNumber = clientDto.PhoneNumber;
            //clientInDb.Email = clientDto.Email;
            //clientInDb.MembershipTypeId = clientDto.MembershipTypeId;
            //clientInDb.IsSubscribedToNewsLetter = clientDto.IsSubscribedToNewsLetter;

            _context.SaveChanges();
        }

        //DELET /API/CLIENTS/1
        [HttpDelete]
        public void DeleteClient(int id)
        {

            var clientInDb = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (clientInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Clients.Remove(clientInDb);
            _context.SaveChanges();

        }



    }
}
