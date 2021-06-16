using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EquipoAPI.Data.Entities;
using EquipoAPI.Models;

namespace EquipoAPI.Data
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            this.CreateMap<EquipoEntity, EquipoModel>()
                .ReverseMap();
        }
    }
}
