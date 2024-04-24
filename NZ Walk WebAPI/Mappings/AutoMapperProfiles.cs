using AutoMapper;
using NZ_Walk_WebAPI.Models.Domain_Models;
using NZ_Walk_WebAPI.Models.DTO;

namespace NZ_Walk_WebAPI.Mappings
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region,RegionDTO>().ReverseMap();
            CreateMap<Region,AddRegionRequestDTO>().ReverseMap();
            CreateMap<Region,UpdateRegionRequestDTO>().ReverseMap();
            CreateMap<AddWalkRequestDTO, Walk>().ReverseMap();
            CreateMap<Walk,WalkDTO>().ReverseMap();
            CreateMap<Walk,UpdateWalkRequestDTO>().ReverseMap();
            CreateMap<DifficultyDTO,Difficulty>().ReverseMap();
        }
    }
}
