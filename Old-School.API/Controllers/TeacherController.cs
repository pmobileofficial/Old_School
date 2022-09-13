//using AutoMapper;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Old_School.Core.Services;
//using Old_School.Core.Services.ServicesInterface;
//using Old_School.Data.Data.Models;
//using Old_School.Data.DTOs;

//namespace Old_School.API.Controllers
//{
//    [ApiController]
//    public class TeacherController : ControllerBase
//    {
//        private readonly ITeacherService _tchService;
//        private readonly IMapper _mapper;

//        public TeacherController(ITeacherService teacherService, IMapper mapper )
//        {
//            _tchService = teacherService;
//            _mapper = mapper;
//        }
//        [HttpPost("add-teacher")]
//        public async Task<IActionResult> Post( TeacherToAddDto model)
//        {
//            if (!ModelState.IsValid)
//            {
//                ModelState.AddModelError("", "Invalid Model");
//                return BadRequest(ModelState);
//            }

//            if(await _tchService.AlreadyExist(model.Email))
//            {
//                ModelState.AddModelError("", "Teacher already exist");
//                return BadRequest(ModelState);
//            }

//            var teacher = _mapper.Map<Teacher>(model);
//            var result = await _tchService.AddTeacher(teacher, model.Password);
//            if (result.Status == false)
//            {
//                foreach (var error in result.Error.Errors)
//                {
//                    ModelState.AddModelError(error.Code, error.Description);
//                }
//                return BadRequest(model);
//            }
//            return Ok(result);


//        }



//        [HttpGet("get-single-teacher")]
//        public async Task<IActionResult> GetTeacher(string id)
//        {
//            var result = await _tchService.GetTeacherById(id);
//            if (result == null)
//                return NotFound($"Student with ID:{id} was not found ");
//            //map student to return
//            var teacherToReturn = _mapper.Map<TeacherToReturnDto>(result);
//            return Ok(teacherToReturn);
//        }

//        [HttpGet("get-all-teacher")]
//        public async Task<IActionResult> GetAllTeacher()
//        {
//            var result = _tchService.GetAllTeachers();
//            return Ok(result);
//        }

//        [HttpPut("update-teacher")]
//        public async Task<IActionResult> UpdateTeacher(string id, UpdateUserDto model)
//        {
//            await _tchService.UpdateTeacher(id, model);
//            if (!ModelState.IsValid)
//            {
//                ModelState.AddModelError("", "invalid model");
//                return BadRequest(model);
//            }

//            return Ok(model);
//        }

//        [HttpDelete("delete-single-teaceher")]

//        public void DeleteTeacher(string id)
//        {
//            _tchService.DeleteTeacher(id);

//        }


       
       
//       // [HttpDelete("Delete Multiple Teachers")]
//    }
//}
