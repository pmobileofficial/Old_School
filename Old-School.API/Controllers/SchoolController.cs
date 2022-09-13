//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using Old_School.Core.Services;
//using Old_School.Core.Services.ServicesInterface;
//using Old_School.Data.Data;
//using Old_School.Data.DTOs;

//namespace Old_School.API.Controllers
//{
//    [ApiController]
//    public class SchoolController : ControllerBase
//    {
//        private readonly ISchoolService _schService;
//        private readonly IMapper _mapper;

//        public SchoolController(ISchoolService schoolService, IMapper imapper)
//        {
//            _schService = schoolService;
//            _mapper = imapper;
//        }

//        [HttpPost("add-school")]
//        public async Task<IActionResult> Post(SchoolToAddDto model)
//        {
//            if (!ModelState.IsValid)
//            {
//                ModelState.AddModelError("", "Invalid model");
//                return BadRequest(ModelState);
//            }

//            if(model == null)
//            {
//                ModelState.AddModelError("", "model cannot be empty");
//                return BadRequest(ModelState);
//            }

//            var school = _mapper.Map<School>(model);
//            var result = await _schService.AddSchool(school, model.SchoolName);

//            if(result.Status == false)
//            {
//                foreach(var error in result.Error.Errors)
//                {
//                    ModelState.AddModelError(error.Code, error.Description);
//                }
//                return BadRequest(model);
//            }
//            return Ok(result);
           
//        }

//        [HttpGet("get-single-school-by-id")]
//        public async Task<IActionResult> Get(string id)
//        {
//            var result = _schService.GetSchoolById(id);
//            if(result == null)
//            {
//                return NotFound($"School with ID:{id} was not found ");
//            }
//            var schoolToReturn = _mapper.Map<SchoolToReturnDto>(result);
//            return Ok(schoolToReturn);
//        }

//        [HttpGet("get-all-schools")]
//        public async Task<IActionResult> GetAllScools()
//        {
//            var result = _schService.GetAllSchool();
//            return Ok(result);
//        }

//        [HttpPut("modify-school")]
//        public async Task<IActionResult> Put(string id, UpdateSchoolDto model)
//        {
//            await _schService.UpdateSchool(id, model);
//            if (!ModelState.IsValid)
//            {
//                ModelState.AddModelError("", "Invalid model");
//                return BadRequest(model);
//            }
//            return Ok(model);
//        }

//        [HttpDelete("delete-single-school")]
//        public void DeleteSchool(string id)
//        {
//             _schService.DeleteSchool(id);
//        }
//    }
//}
