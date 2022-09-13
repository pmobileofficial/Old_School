using AutoMapper;
using Old_School.Data.Data.Models;
using Old_School.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<StudentToReturnDto, Student>();

            CreateMap<TeacherToReturnDto, Teacher>();
            
            CreateMap<SchoolToReturnDto, School>();

            CreateMap<UpdateUserDto, Student>();

            CreateMap<UpdateUserDto, Teacher>();

        }
    }
}
