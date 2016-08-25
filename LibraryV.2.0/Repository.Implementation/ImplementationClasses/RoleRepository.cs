﻿using Domain.Model.Models;
using NHibernate;
using System.Linq;
using Repository.Abstraction.Interfaces;
using System.Collections.Generic;

namespace Repository.Implementation.ImplementationClasses
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(ISessionProvider sessionProvider) : base(sessionProvider)
        {
        }
    }
}