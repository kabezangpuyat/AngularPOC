using AutoMapper;
using MNV.Domain.Entities;
using MNV.Domain.Models.Department;
using MNV.Domain.Models.Requests;
using MNV.Domain.Models.Responses.User;
using MNV.Domain.Models.User;
using System;
using System.Linq;

namespace MNV.Mappers
{
    /// <summary>
    /// Using Auto Mapper
    /// </summary>
    public class DepartmentMapper : Profile
    {
        public DepartmentMapper()
        {
            //create mapping
            CreateMap<DepartmentViewModel, Department>()
              .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
              .ForMember(dest => dest.Key, opt => opt.MapFrom(src => Guid.NewGuid()))
              .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active))
              .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => DateTimeOffset.Now));

            CreateMap<Department, DepartmentViewModel>()
               .ForMember(dest => dest.ID, opt => opt.MapFrom(src => src.ID))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Active, opt => opt.MapFrom(src => src.Active));

            CreateMap<CreateDepartmentRequest, Department>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Active, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(src => DateTimeOffset.Now));
        }
    }

    /// <summary>
    /// Manual Mapping
    /// </summary>
    public static class DepartmentMappings
    {
        public static DepartmentViewModel ToSingleDepartmentViewModel(this IQueryable<Domain.Entities.Department> val)
        {
            DepartmentViewModel model = new DepartmentViewModel();
            if (val.Count() == 0)
                model = null;
            else
                model = val.ToDepartmentViewModelQueryable().FirstOrDefault();

            return model;
        }

        public static IQueryable<DepartmentViewModel> ToDepartmentViewModelQueryable(this IQueryable<Domain.Entities.Department> val)
        {
            IQueryable<DepartmentViewModel> model = null;
            if (val.Count() == 0)
                model = null;
            else
            {
                model = val.Select(x => new DepartmentViewModel
                {
                    ID = x.ID,
                    Name = x.Name,
                    Active = x.Active
                });                
            }
            return model;
        }

        public static DepartmentViewModel ToSingleDepartmentViewModel(this Domain.Entities.Department val)
        {
            DepartmentViewModel model = new DepartmentViewModel();
            if (val == null)
                model = null;
            else
            {
                model =  new DepartmentViewModel
                {
                    ID = val.ID,
                    Name = val.Name,
                    Active = val.Active
                };
            }
            return model;
        }
    }
}
