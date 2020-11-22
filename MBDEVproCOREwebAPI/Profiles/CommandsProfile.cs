using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MBDEVproCOREwebAPI.Dtos;
using MBDEVproCOREwebAPI.Models;

namespace MBDEVproCOREwebAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}
