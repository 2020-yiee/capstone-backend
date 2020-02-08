using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cothrive_backend.api.example.Application.User.Queries.GetUsersList
{
    public class UsersListVm
    {
        public IList<UserLookupDto> Users { get; set; }
    }
}
