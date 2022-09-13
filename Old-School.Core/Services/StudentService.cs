//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using Old_School.Core.Services.ServicesInterface;
//using Old_School.Core.Services.ServicesInterface.Utilities;
//using Old_School.Data.Data.Models;
//using Old_School.Data.Data.Repositories.StudentEntity;
//using Old_School.Data.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Old_School.Core.Services.ServicesInterface.Utilities.Common;

//namespace Old_School.Core.Services
//{
//    public class StudentService : IStudentService
//    {
        
//        private readonly IStudentRepo _stdRepo;

//        private readonly IMapper _mapper;
//        private readonly UserManager<Student> _usrMgr;

//        public StudentService(UserManager<Student> userManager, IStudentRepo studentRepo, IMapper mapper)
//        {
//            _stdRepo = studentRepo;
//            _mapper = mapper;
//            _usrMgr = userManager;
//        }

       
//        public IQueryable<Student> Student { get; private set; }

//        public async Task<ServiceReturnType<IdentityResult>> AddStudent(Student student, string password)
//        {
//            //validate the entity is not nul before passing to the controller
//            if (student == null)
//                return new ServiceReturnType<IdentityResult>
//                {
//                    Status = false,
//                    Message = "Object must not be null",
//                    Data = null,
//                    Error = null
//                };
//            var result = await _usrMgr.CreateAsync( student,  password );
//            if (!result.Succeeded)
//            {
//                return new ServiceReturnType<IdentityResult>
//                {
//                    Status = false,
//                    Message = "Failed to create Student",
//                    Data = null,
//                    Error = result
//                };
//            }

//            return new ServiceReturnType<IdentityResult> 
//            { 
//                Status = true,
//                Message = "Student added successfully",
//                Data= result,
//                Error = null
                
//            };
//        }

//        public async Task<bool> AlreadyExist(string Email)
//        {
//            var result = await _usrMgr.FindByEmailAsync(Email);
//            if (result != null)
//                return true;
//            return false;
//        }

        

//        public IEnumerable<Student> GetAllStudents()
//        {
//            return _usrMgr.Users;
//        }

//        public Task<Student> GetStudentById(string id)
//        {
//            return _usrMgr.FindByIdAsync(id);
//        }

//        public async Task<bool> UpdateStudent(string id, UpdateUserDto model )
//        {
//            var std = _usrMgr.FindByIdAsync(id);
//            _mapper.Map(model, std); 
//            _stdRepo.SaveStudent();
//         return await  _stdRepo.UpdateStudent(id);
                                 
//        }

//        public void DeleteStudent(string id)
//        {
//            var student = _usrMgr.FindByIdAsync(id);
//            _stdRepo.DeleteStudent(id);
//        }

//        public Task<List<Student>> PaginatedResult(int size, int page)
//        {
//            return Task.Run(() => this.Student.Skip(page - 1 * size).Take(size).ToList());
//        }

//    }


//}
