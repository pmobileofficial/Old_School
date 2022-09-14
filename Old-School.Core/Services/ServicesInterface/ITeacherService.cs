//using Microsoft.AspNetCore.Identity;
//using Old_School.Data.Data.Models;
//using Old_School.Data.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Old_School.Core.Services.ServicesInterface.Utilities.Common;

//namespace Old_School.Core.Services.ServicesInterface
//{
//    public interface ITeacherService
//    {
//        public Task<ServiceReturnType<IdentityResult>> AddTeacher(Teacher teacher, string password);
//        public Task<Teacher> GetTeacherById(string id);
//        public Task<bool> AlreadyExist(string Email);
//        public IEnumerable<Teacher> GetAllTeachers();

//        public Task<bool> UpdateTeacher(string id, UpdateUserDto model);
//        public void DeleteTeacher(string id);
//        public Task<List<Teacher>> PaginatedResult(int size, int page);
//    }
//}
