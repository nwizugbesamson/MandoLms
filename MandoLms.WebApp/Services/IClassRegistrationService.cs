using MandoLms.WebApp.Models;

namespace MandoLms.WebApp.Services
{
    public interface IClassRegistrationService
    {
        IEnumerable<ClassRegistrationReport> GetRegistrationReport(int? minRegistrations);
    }
}