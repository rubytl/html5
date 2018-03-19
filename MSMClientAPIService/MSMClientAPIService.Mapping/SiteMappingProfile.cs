using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MSMClientAPIService.Data.Models;
using MSMClientAPIService.Mapping.Models;

namespace MSMClientAPIService.Mapping
{
    public class SiteMappingProfile : Profile
    {
        public SiteMappingProfile()
        {
            this.CreateMap<Site, SiteModel>()
                .ForMember(s => s.Id, m => m.MapFrom(site => site.Id))
                .ReverseMap()
                .ForMember(s => s.ParentId, m => m.MapFrom(site => site.ParentId))
                .ReverseMap()
                .ForMember(s => s.Description, m => m.MapFrom(site => site.Description))
                .ReverseMap()
                .ForMember(s => s.IsToplevel, m => m.MapFrom(site => site.IsToplevel))
                .ReverseMap();
        }
    }
}
