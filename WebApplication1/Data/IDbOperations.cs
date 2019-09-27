using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public interface IDbOperations
    {
        int Add<T>(T items);
        int AddOrUpdate<T>(T items);
    }
}
