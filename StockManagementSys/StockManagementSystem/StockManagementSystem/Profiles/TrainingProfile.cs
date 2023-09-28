using AutoMapper;
using StockManagementSystem.BusinessObjects;
using StockManagementSystem.Models.Domain;

namespace StockManagementSystem.Profiles
{
    public class TrainingProfile:Profile
    {
        public TrainingProfile()
        {
            CreateMap<Category,CategoryBO>().ReverseMap();
            CreateMap<Company, CompanyBO>().ReverseMap();
            CreateMap<Item, ItemBO>().ReverseMap();



        }
    }
}
