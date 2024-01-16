using EstudianteAPI.Models;
using System.Security.Cryptography.Xml;

namespace EnrolamientoAPI.Models
{
    public class Enrolamiento
    {
        public Guid Id { get; set; }
        public int AsignaturaId { get; set; }
        public Asignatura Asignaturas { get; set; }
        public int EstudianteId { get; set; }
        public Student Estudiante { get; set; }
        public DateTime FechaEnrolamiento { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Estado { get; set; }
    }
}
