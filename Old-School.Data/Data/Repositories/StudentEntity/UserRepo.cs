using Microsoft.EntityFrameworkCore;
using Old_School.Data.Data.Models;
using Old_School.Data.Data.Repositories.StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_School.Data.Data.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _ctx;

        public UserRepo(AppDbContext context)
        {
            _ctx = context;
        }
        public async Task<bool> AddStudent(Student entity)
        {
            await _ctx.AddAsync(entity);
            return await this.SaveStudent();
        }

        public async Task<bool> DeleteStudent(Student entity)
        {
           _ctx.Remove(entity);
            return await this.SaveStudent();
        }

        public IQueryable<Student> GetAllStudents()
        {
            return _ctx.Students.AsQueryable();
        }

        public async Task<Student> GetStudentById(string id)
        {
            return await _ctx.Students.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> SaveStudent()
        {
           return await _ctx.SaveChangesAsync() >0;
        }

        public async Task<bool> UpdateStudent(Student entity)
        {
            _ctx.Students.Update(entity);
            return await SaveStudent();
        }
    }
}
