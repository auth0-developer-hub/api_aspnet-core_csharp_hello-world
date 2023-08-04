using Microsoft.AspNetCore.Authorization;

namespace App.Requirement;

class RbacRequirement : IAuthorizationRequirement
{
    public string Permission { get; }

    public RbacRequirement(string permission)
    {
        Permission = permission ?? throw new ArgumentNullException(nameof(permission));
    }
}
