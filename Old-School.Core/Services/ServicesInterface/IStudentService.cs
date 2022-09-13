using Microsoft.AspNetCore.Identity;
using Old_School.Data.Data.Models;
using Old_School.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Old_School.Core.Services.ServicesInterface.Utilities.Common;

namespace Old_School.Core.Services.ServicesInterface
{
    public interface IStudentService
    {
        public Task<ServiceReturnType<IdentityResult>> AddStudent(Student student, string password);
        public Task<Student> GetStudentById(string id);
        public Task<bool> AlreadyExist(string Email);
        public IEnumerable<Student> GetAllStudents();

        public Task<bool> UpdateStudent(string id, UpdateUserDto model);
        public void DeleteStudent(string id);
        public Task<List<Student>> PaginatedResult(int size, int page);
        // public Task<bool> GetUserName(string userName);


    }
}
