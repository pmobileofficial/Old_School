//using Microsoft.EntityFrameworkCore;
//using Old_School.Data.Data.Repositories.SchoolEntity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Old_School.Data.Data.Repositories
//{
//    public class SchoolRepo : ISchoolRepo
//    {
//        private readonly AppDbContext _context;

//        public SchoolRepo(AppDbContext context)
//        {
//            _context = context;
//        }

//        public void DeleteSchool(string id)
//        {
//            _context.Remove(id);
           
//        }

//        public IEnumerable<School> GetAllSchools()
//        {
//            return _context.Schools.ToList();
//        }

//        public School GetSchoolById(string id)
//        {
//            return _context.Schools.FirstOrDefault(school => school.Id == id);
//        }

//        public async Task <School>AddSchool(School school)
//        {
//            _context.Schools.Add(school);
//            return school;
//        }

//        public void SaveSchool()
//        {
//            _context.SaveChanges();
//        }

//        public Task <bool> UpdateSchool(string id)
//        {
//            _context.Entry(id).State = EntityState.Modified;
//            return Task.FromResult(true);
//        }
//    }
//}
