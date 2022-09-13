//using Microsoft.EntityFrameworkCore;
//using Old_School.Data.Data.Models;
//using Old_School.Data.Data.Repositories.TeacherEntity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Old_School.Data.Data.Repositories
//{
//    public class TeacherRepo : ITeacherRepo
//    {
//        private readonly AppDbContext _context;

//        public TeacherRepo(AppDbContext context)
//        {
//            _context = context;
//        }

//        public void DeleteTeacher(string id)
//        {
//            _context.Remove(id);   
//        }

//        public IEnumerable<Teacher> GetAllTeachers()
//        {
//            return _context.Teachers.ToList();  
//        }

//        public Teacher GetTeacherById(string id)
//        {
//            return _context.Teachers.FirstOrDefault(teacher => teacher.Id == id);
//        }

//        public void AddTeacher(Teacher teacher)
//        {
//            _context.Add(teacher);
//        }

//        public void SaveTeacher()
//        {
//            _context.SaveChanges();
//        }

//        public Task<bool> UpdateTeacher(string id)
//        {
//           _context.Entry(id).State = EntityState.Modified;
//            return Task.FromResult(true);
//        }
//    }
//}
