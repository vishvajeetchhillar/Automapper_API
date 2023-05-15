using AM.API.DataTranferObjects;
using AM.API.Entities;
using AM.API.HelperFunctions;
using AutoMapper;

namespace AM.API.AMProfile
{
    public class UserProfiles:Profile
    {
        public UserProfiles()
        {
            CreateMap<User, UserReadDto>()
                .ForMember(
                dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));

            CreateMap<UserCreateDto, User>();
            
        }

    }
}
