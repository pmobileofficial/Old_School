//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using Old_School.Core.Services.ServicesInterface;
//using Old_School.Core.Services.ServicesInterface.Utilities;
//using Old_School.Data.Data;
//using Old_School.Data.Data.Repositories.SchoolEntity;
//using Old_School.Data.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Old_School.Core.Services.ServicesInterface.Utilities.Common;

//namespace Old_School.Core.Services
//{
//    public class SchoolService : ISchoolService
//    {
//        private readonly ISchoolRepo _schRepo;
//        private readonly IMapper _mapper;
//        private readonly UserManager<School> _usrMgr;

//        public SchoolService(ISchoolRepo schoolRepo, IMapper imapper )
//        {
//            _schRepo = schoolRepo;
//            _mapper = imapper;
           
//        }
//        public IQueryable<School> Schools { get; private set; }

//        public async Task<ServiceReturnType<IdentityResult>> AddSchool(School school, string password)
//        {
//            //validate the entity is not nul before passing to the controller
//            if (school == null)
//                return new ServiceReturnType<IdentityResult>
//                {
//                    Status = false,
//                    Message = "Object must not be null",
//                    Data = null,
//                    Error = null
//                };
//            var result = await _schRepo.AddSchool( school);
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
//                Data = result,
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



//        public IEnumerable<School> GetAllSchool()
//        {
//            return _usrMgr.Users;
//        }

//        public Task<School> GetSchoolById(string id)
//        {
//            return _usrMgr.FindByIdAsync(id);
//        }

//        public async Task<bool> UpdateSchool(string id, UpdateSchoolDto model)
//        {
//            var std = _usrMgr.FindByIdAsync(id);
//            _mapper.Map(model, std);
//            _schRepo.SaveSchool();
//            return await _schRepo.UpdateSchool(id);

//        }

//        public void DeleteSchool(string id)
//        {
//            var student = _usrMgr.FindByIdAsync(id);
//            _schRepo.DeleteSchool(id);
            
//        }

//        public Task<List<School>> PaginatedResult(int size, int page)
//        {
//            return Task.Run(() => this.Schools.Skip(page - 1 * size).Take(size).ToList());
//        }
//    }
//}
