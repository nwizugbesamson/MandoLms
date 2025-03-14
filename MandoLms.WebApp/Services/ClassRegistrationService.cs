using System.Data;
using Microsoft.Data.SqlClient;
using MandoLms.WebApp.Models;
using Dapper;

namespace MandoLms.WebApp.Services
{
    public class ClassRegistrationService : IClassRegistrationService
    {
        private readonly IDbConnection _dbConnection;
        public ClassRegistrationService(IDbConnection connection)
        {
            _dbConnection = connection;
        }

        public IEnumerable<ClassRegistrationReport> GetRegistrationReport()
        {

            return _dbConnection
                .Query<ClassRegistrationReport>(
                    "ClassRegistrationReport",
                    commandType: CommandType.StoredProcedure
                    ).ToList();

        }
    }
}
