//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using Old_School.Core.Services.ServicesInterface;
//using Old_School.Core.Services.ServicesInterface.Utilities;
//using Old_School.Data.Data.Models;
//using Old_School.Data.Data.Repositories.TeacherEntity;
//using Old_School.Data.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Old_School.Core.Services.ServicesInterface.Utilities.Common;

//namespace Old_School.Core.Services
//{
//    public class TeacherService : Common, ITeacherService
//    {
//        private readonly UserManager<Teacher> _usrMgr;
//        private readonly ITeacherRepo _tchRepo;
//        private readonly IMapper _mapper;

//        public TeacherService(UserManager <Teacher> userManager, ITeacherRepo teacherRepo, IMapper imapper)
//        {
//            _usrMgr = userManager;
//            _tchRepo = teacherRepo;
//            _mapper = imapper;
//        }
//        public object Teacher { get; private set; }
//        public async Task<ServiceReturnType<IdentityResult>> AddTeacher(Teacher teacher, string password)
//        {
//            //validate if entity is not a null object before passing to the controller
//            if (teacher == null)
//                return new ServiceReturnType<IdentityResult>
//                {
//                    Status = false,
//                    Message = "Object must not be null",
//                    Data = null,
//                    Error = null,
//                };
//            var result = await _usrMgr.CreateAsync(teacher, password);
//            if (!result.Succeeded)
//            {
//                return new ServiceReturnType<IdentityResult>
//                {
//                    Status = false,
//                    Message = "Failed to create Teacher",
//                    Data = null,
//                    Error = result

//                };
//            }

//            return new ServiceReturnType<IdentityResult>
//            {
//                Status = true,
//                Message = "Teacher added successfully",
//                Data = result,
//                Error = null
//            };
//        }

//        public async Task<bool> AlreadyExist(string Email)
//        {
//           var result = await _usrMgr.FindByEmailAsync(Email);
//            if (result != null)
//                return true;
//            return false;
//        }
//        public IQueryable<Teacher> Teachers { get; private set; }
//        public IEnumerable<Teacher> GetAllTeachers()
//        {
//            return _tchRepo.GetAllTeachers();
//        }

//        public async Task<Teacher> GetTeacherById(string id)
//        {
//           return await _usrMgr.FindByIdAsync(id);
//        }
        
//        public async Task<bool> UpdateTeacher(string id, UpdateUserDto model)
//        {
//            var teacher = _tchRepo.GetTeacherById(id);
//           _mapper.Map(model, teacher);
//            _tchRepo.SaveTeacher();
//          return await _tchRepo.UpdateTeacher(id);
//        }

//        public void DeleteTeacher(string id)
//        {
//            var teacher = _usrMgr.FindByIdAsync(id);
//            _tchRepo.DeleteTeacher(id);
//        }

//        public Task<List<Teacher>> PaginatedResult(int size, int page)
//        {
//            return Task.Run(() => this.Teachers.Skip(page - 1 * size).Take(size).ToList());
//        }
//    }

//}
