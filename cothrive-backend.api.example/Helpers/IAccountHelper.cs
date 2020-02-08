using cothrive_backend.api.example.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cothrive_backend.api.example.Helpers
{
    public interface IAccountHelper
    {
        object GenerateJwtToken(string email, Users user, string Role);
    }
}
