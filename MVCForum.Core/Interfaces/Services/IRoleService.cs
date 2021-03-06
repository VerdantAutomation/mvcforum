﻿using System;
using System.Collections.Generic;
using MVCForum.Domain.DomainModel;

namespace MVCForum.Domain.Interfaces.Services
{
    public partial interface IRoleService
    {
        IList<MembershipRole> AllRoles();
        void Save(MembershipRole user);
        void Delete(MembershipRole role);
        MembershipRole GetRole(string rolename, bool removeTracking = false);
        MembershipRole GetRole(Guid id);
        IList<MembershipUser> GetUsersForRole(string roleName);
        void CreateRole(MembershipRole role);
        PermissionSet GetPermissions(Category category, MembershipRole role);
    }
}
