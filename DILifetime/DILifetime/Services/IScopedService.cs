using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILifetime.Services
{
    public interface IScopedService
    {
        Guid GetID();
    }
}
