using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SunshineCleaning.Models;
using SunshineCleaning.ViewModels;

namespace SunshineCleaning.Controllers
{
    public class ClientsController : Controller
    {
        private ApplicationDbContext _context;

        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET CLIENTS
        [Authorize(Roles = RoleName.CanManageClients)]
        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageClients))
                return View("Index");
           // var clients = _context.Clients.Include(c => c.MembershipType).ToList();
           //return View(clients);
            return View();
        }

         [Authorize(Roles = RoleName.CanManageClients)]
        //GET INPUT NEW CLIENTS
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new ClientFormViewModel
            {
                Client = new Client(),
                MembershipTypes = membershipTypes
            };
            return View("ClientForm", viewModel);
        }

        //SAVING CLIENTS TO DATABASE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageClients)]
        public ActionResult Save(Client client)
        {
       
            if (!ModelState.IsValid)
            {
                var viewModel = new ClientFormViewModel
                {
                    Client  = client,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("ClientForm", viewModel);
            }

            if(client.Id == 0)
            {
                _context.Clients.Add(client);
            }
            else
            {
                var clientInDb = _context.Clients.Single(c => c.Id == client.Id);
                clientInDb.Name = client.Name;
                clientInDb.SquareFeet = client.SquareFeet;
                clientInDb.Address = client.Address;
                clientInDb.PhoneNumber = client.PhoneNumber;
                clientInDb.Email = client.Email;
                clientInDb.MembershipTypeId = client.MembershipTypeId;
                clientInDb.IsSubscribedToNewsLetter = client.IsSubscribedToNewsLetter;
            
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Clients");
        }

        //GET CLIENT DETAILS
        public ActionResult Details(int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (client == null)
                return HttpNotFound();

            return View(client);
        }

        //EDIT CLIENT 
        [Authorize(Roles = RoleName.CanManageClients)]
        public ActionResult Edit (int id)
        {
            var client = _context.Clients.SingleOrDefault(c => c.Id == id);

            if (client == null)
                return HttpNotFound();

            var viewModel = new ClientFormViewModel
            {
                Client = client,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("ClientForm", viewModel);
        }

       
    }
}