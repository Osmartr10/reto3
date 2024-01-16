using EstudianteAPI.Enums;
using EstudianteAPI.Models;

namespace EstudianteAPI.Services.Implementations
{
    public class StudentService
    {
        #region Propiedades
        private readonly ILogger<Student> _logger;
        private readonly IColegioContext _dbContext;
        #endregion
        #region Constructores
        public StudentService(ILogger<Student> logger, IColegioContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        #endregion
        #region Metodos
        public bool Create(Student student)
        {
            bool result = false;

            try
            {
                student.Id = Guid.NewGuid();

                _dbContext.Students.Add(student);
                _dbContext.SaveChanges();

                result = true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creando data de estudiante {ex.Message.ToString()}");
            }

            return result;
        }
        public Student GetByDocumentNumber(int documentNumber)
        {
            Student result = null;

            try
            {
                result = _dbContext.Students.
                    Where(x => x.DocumentNumber == documentNumber)
                    .FirstOrDefault();

                if (result == null)
                {
                    _logger.LogError($"Error obteniendo data de estudiante {documentNumber}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error obteniendo data de estudiante {ex.Message.ToString()}");
            }

            return result;
        }
        public List<Student> List()
        {
            List<Student> result = null;

            try
            {
                result = _dbContext.Students.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error obteniendo data de estudiantes {ex.Message}");
            }

            return result;
        }
        public bool MassCreation(List<Student> students)
        {
            bool result = false;

            try
            {
                foreach (Student student in students)
                {
                    student.Id = Guid.NewGuid();

                    _dbContext.Students.Add(student);
                }

                _dbContext.SaveChanges();

                result = true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creando data de estudiantes {ex.Message.ToString()}");
            }

            return result;
        }
        public bool Update(Student student)
        {
            bool result = false;

            try
            {
                var entity = _dbContext.Students.
                    Where(x => x.Id == student.Id)
                    .FirstOrDefault();

                if (entity != null)
                {
                    entity.DocumentType = student.DocumentType;
                    entity.DocumentNumber = student.DocumentNumber;
                    entity.Name = student.Name;
                    entity.Email = student.Email;

                    _dbContext.SaveChanges();
                }
                else
                {
                    _logger.LogError($"No sé encontró el estudiante {student.Id}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error actualizando data de estudiante {ex.Message.ToString()}");
            }

            return result;
        }
        #endregion
    }
}