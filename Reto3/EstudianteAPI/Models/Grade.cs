namespace EstudianteAPI.Models
{
    public class Grade
    {
        #region Propiedades
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public virtual Student Student { get; set; }
        #endregion
    }
}