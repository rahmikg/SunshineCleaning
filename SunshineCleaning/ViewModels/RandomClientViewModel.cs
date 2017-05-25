using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SunshineCleaning.Models;

namespace SunshineCleaning.ViewModels
{
    public class RandomClientViewModel
    {
        public Client Client { get; set; }
        public List<Client> Clients { get; set; }
    }
}