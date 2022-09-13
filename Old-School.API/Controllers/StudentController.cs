//using AutoMapper;
//using Microsoft.AspNetCore.Mvc;
//using Old_School.Core.Services.ServicesInterface;
//using Old_School.Data.Data.Models;
//using Old_School.Data.DTOs;

//namespace Old_School.API.Controllers
//{
//    [ApiController]
//    public class StudentController : ControllerBase
//    {
//        private readonly IStudentService _stdService;
//        private readonly IMapper _mapper;

//        public StudentController(IStudentService studentService, IMapper imapper)
//        {
//            _stdService = studentService;
//            _mapper = imapper;
//        }

//        [HttpPost("add")]
//        public async Task<IActionResult> AddStudent(StudentToAddDto model)
//        {
//            check if model state is valid
//            if (!ModelState.IsValid)
//            {
//                ModelState.AddModelError("", "Invalid Model");
//                return BadRequest(ModelState);
//            }
//            check if student already exist
//            if (await _stdService.AlreadyExist(model.Email))
//            {
//                ModelState.AddModelError("", "Email Already Exist");
//                return BadRequest(ModelState);
//            }
//            check if userName already exist
//            if (await _stdService.AlreadyExist(model.UserName))
//            {
//                ModelState.AddModelError("", "UserName already exist");
//            }


//            map student dto to student model before adding student
//           var student = _mapper.Map<Student>(model);

//            status report to show if successful or failed to add student with error message
//            var result = await _stdService.AddStudent(student, model.Password);
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

//        [HttpGet("get-student-by-id")]
//        public async Task<IActionResult> GetStudent(string id)
//        {
//            var result = await _stdService.GetStudentById(id);
//            if (result == null)
//                return NotFound($"Student with ID:{id} was not found ");
//            //map student to return
//            var studentToReturn = _mapper.Map<StudentToReturnDto>(result);
//            return Ok(studentToReturn);
//        }

//        [HttpGet("get-all-students")]
//        public async Task<IActionResult> GetAllStudents()
//        {
//            var result = _stdService.GetAllStudents();
//            return Ok(result);
//        }

//        [HttpPut("modify-student")]
//        public async Task<IActionResult> UpdateStudent(string id, UpdateUserDto model)
//        {
//            await _stdService.UpdateStudent(id, model);
//            if (!ModelState.IsValid)
//            {
//                ModelState.AddModelError("", "invalid model");
//                return BadRequest(model);
//            }

//            return Ok(model);
//        }

//        [HttpDelete("delete-student")]

//        public void DeleteStudent(string id)
//        {
//            _stdService.DeleteStudent(id);

//        }


//    }
//}
