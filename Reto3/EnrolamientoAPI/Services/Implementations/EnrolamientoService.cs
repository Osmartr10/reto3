using EnrolamientoAPI.Models;

namespace EnrolamientoAPI.Services.Implementations
{
    public class EnrolamientoService
    {
        private readonly ILogger<EnrolamientoService> _logger;
        private readonly IEnrolamientoContext _context;
        public EnrolamientoService(ILogger<EnrolamientoService> logger, IEnrolamientoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public bool Create(Enrolamiento enrol)
        {
            bool result = false;

            try
            {
                enrol.Id = Guid.NewGuid();

                _context.enrols.Add(enrol);
                _context.SaveChanges();

                result = true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error creando data de enrolamiento {ex.Message.ToString()}");
            }

            return result;
        }
        public bool Delete(Guid id)
        {
            bool result = false;

            try
            { 
                Enrolamiento enrolDelete = _context.enrols.FirstOrDefault(en => en.Id == id);

                _context.enrols.Remove(enrolDelete);
                _context.SaveChanges();

                result = true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error eliminando data de enrolamiento {ex.Message.ToString()}");
            }

            return result;
        }
    }
}
