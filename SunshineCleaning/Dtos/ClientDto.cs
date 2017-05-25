using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SunshineCleaning.Models;

namespace SunshineCleaning.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public double SquareFeet { get; set; }
        
        public string Address { get; set; }

        [Required]
        
        public double PhoneNumber { get; set; }

        
        public string Email { get; set; }

        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    
   }
}