using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Helper
{
    public interface ITableRepository
    {
        IEnumerable<string> GetNames();
    }
}
