using EnrolamientoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EnrolamientoAPI
{
    public interface IEnrolamientoContext
    {
        DbSet<Enrolamiento> enrols { get; set; }
        void SaveChanges();
    }
}
