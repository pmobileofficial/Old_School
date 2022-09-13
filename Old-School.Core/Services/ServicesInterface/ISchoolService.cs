using Microsoft.AspNetCore.Identity;
using Old_School.Data.Data;
using Old_School.Data.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Old_School.Core.Services.ServicesInterface.Utilities.Common;

namespace Old_School.Core.Services.ServicesInterface
{
    public interface ISchoolService
    {
        public Task<ServiceReturnType<IdentityResult>> AddSchool(School school, string password);
        public Task<School> GetSchoolById(string id);
        public Task<bool> AlreadyExist(string Email);
        public IEnumerable<School> GetAllSchool();

        public Task<bool> UpdateSchool(string id, UpdateSchoolDto model);
        public void DeleteSchool(string id);
        public Task<List<School>> PaginatedResult(int size, int page);
    }
}
