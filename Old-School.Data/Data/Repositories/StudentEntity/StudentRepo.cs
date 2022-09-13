//using Microsoft.EntityFrameworkCore;
//using Old_School.Data.Data.Models;
//using Old_School.Data.Data.Repositories.StudentEntity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Old_School.Data.Data.Repositories
//{
//    public class StudentRepo : IStudentRepo
//    {
//        private readonly AppDbContext _context;

//        public StudentRepo(AppDbContext context)
//        {
//            _context = context;
//        }

//        public void DeleteStudent(string id)
//        {
//            _context.Remove(id);
//        }

//        public IEnumerable<Student> GetAllStudents()
//        {
//            return  _context.Students.ToList();
//        }

//        public Student GetStudentById(string id)
//        {
//            return _context.Students.FirstOrDefault(student => student.Id == id);
//        }

//        public void AddStudent(Student student)
//        {
//           _context.Students.Add(student);
//        }

//        public void SaveStudent()
//        {
//            _context.SaveChanges();
//        }

//        public Task<bool> UpdateStudent(string id)
//        {
//            _context.Entry(id).State = EntityState.Modified;
//            return Task.FromResult(true);
//        }
//    }
//}
