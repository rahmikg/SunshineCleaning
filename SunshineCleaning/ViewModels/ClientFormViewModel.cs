using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SunshineCleaning.Models;
using System.ComponentModel.DataAnnotations;

namespace SunshineCleaning.ViewModels
{
    public class ClientFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Client Client { get; set; }

        //public int? Id { get; set; }

        //[Required]
        //[StringLength(255)]
        //[Display(Name = "First & Last Name")]
        //public string Name { get; set; }

        //public bool IsSubscribedToNewsLetter { get; set; }

        //[Display(Name = "Address/City/State/Zip")]
        //public string Address { get; set; }

        //[Required]
        //[Display(Name = "Phone Number")]
        //public double PhoneNumber { get; set; }

        //[Display(Name = " Email Address")]
        //public string Email { get; set; }

        //public MembershipType MembershipType { get; set; }

        //[Display(Name = "Membership Type")]
        //public byte? MembershipTypeId { get; set; }
    }
}