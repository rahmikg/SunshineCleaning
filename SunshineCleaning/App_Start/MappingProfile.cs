using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SunshineCleaning.Dtos;
using SunshineCleaning.Models;

namespace SunshineCleaning.App_Start
{
    public class MappingProfile: Profile

    {

        public MappingProfile()
        {
            Mapper.CreateMap<Client, ClientDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            // Dto to Domain
            Mapper.CreateMap<ClientDto, Client>()
                .ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}