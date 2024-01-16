using EstudianteAPI.Models;

namespace EstudianteAPI.Services.Interfaces
{
    public interface IStudentService
    {
        #region Metodos
        bool Create(Student student);
        List<Student> List();
        bool MassCreation(List<Student> students);
        bool Update(Student student);
        #endregion
    }
}