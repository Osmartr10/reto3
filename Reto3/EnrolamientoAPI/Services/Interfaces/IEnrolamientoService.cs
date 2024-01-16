using EnrolamientoAPI.Models;

namespace EnrolamientoAPI.Services.Interfaces
{
    public interface IEnrolamientoService
    {
        #region Metodos
        bool Create(Enrolamiento enrol);
        
        bool Delete(Guid id);
        #endregion
    }
}
