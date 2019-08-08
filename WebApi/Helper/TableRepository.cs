using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Helper
{
    public class TableRepository : ITableRepository
    {
        private IDbConnection _connection;

        public TableRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<string> GetNames()
        {
            IEnumerable<string> names = Enumerable.Empty<string>();
            return _connection.Query<string>("SELECT name FROM sys.Tables");
        }
    }
}
