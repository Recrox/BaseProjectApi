﻿using RamDam.BackEnd.Core.Models.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamDam.BackEnd.Core.Repositories
{
    public interface IRoleUserRepository : IRepository<RoleUser, Models.Api.RoleUser, Guid>
    {
    }
}
