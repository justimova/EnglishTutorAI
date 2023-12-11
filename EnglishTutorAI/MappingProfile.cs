using AutoMapper;
using EnglishTutorAI.DataTransferObjects;
using EnglishTutorAI.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EnglishTutorAI
{
	internal class MappingProfile : Profile
	{
		public MappingProfile() {
			CreateMap<UserForRegistrationDto, User>()
				.ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
		}
	}
}
