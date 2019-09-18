using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILifetime.Services
{
    public class SomeService : ITransientService, IScopedService, ISingletonService
    {
        Guid _id;

        public SomeService()
        {
            _id = Guid.NewGuid();
        }
        public Guid GetID()
        {
            return _id;
        }
    }
}
