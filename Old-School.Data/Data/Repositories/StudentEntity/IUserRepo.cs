using Old_School.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.Data.Repositories.StudentEntity
{
    public interface IUserRepo
    {
        public IQueryable<Student> GetAllStudents();
        public Task<Student> GetStudentById(string id);
        public Task<bool> AddStudent(Student entity);
        public Task<bool> UpdateStudent(Student entity);
        public Task <bool> DeleteStudent(Student entity);
        public Task <bool> SaveStudent();
    }
}
