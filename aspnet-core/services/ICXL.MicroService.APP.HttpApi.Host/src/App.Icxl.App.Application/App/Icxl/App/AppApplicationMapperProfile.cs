using AutoMapper;

namespace App.Icxl.App;

public class AppApplicationMapperProfile : Profile
{
    public AppApplicationMapperProfile()
    {

        CreateMap<TestHome, TestHomeDto>();

        CreateMap<TestHome, TestHomeCreateOrEditDto>().ReverseMap();
    }
}
