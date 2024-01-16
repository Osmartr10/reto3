using EstudianteAPI.Models;
using EstudianteAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EstudianteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Propiedades
        private readonly IStudentService _student;
        #endregion
        #region Constructores
        public StudentController(IStudentService student)
        {
            _student = student;
        }
        #endregion
        #region Metodos
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(Student student)
        {
            return Ok(_student.Create(student));
        }

        [HttpPost]
        [Route("MassCreation")]
        public IActionResult MassCreation(List<Student> students)
        {
            return Ok(_student.MassCreation(students));
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            return Ok(_student.Update(student));
        }
        #endregion
    }
}