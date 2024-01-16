using EstudianteAPI.Enums;

namespace EstudianteAPI.Models
{
    public class Student
    {
        #region Propiedades
        public Guid Id { get; set; }
        public DocumentTypeEnum DocumentType { get; set; }
        public int DocumentNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Guid GradeId { get; set; }
        public virtual Grade Grade { get; set; }
        #endregion
    }
}