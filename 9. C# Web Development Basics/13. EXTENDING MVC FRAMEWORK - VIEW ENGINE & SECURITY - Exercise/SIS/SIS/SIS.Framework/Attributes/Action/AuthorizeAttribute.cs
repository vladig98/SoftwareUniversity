using SIS.Framework.Security;
using System;
using System.Linq;

namespace SIS.Framework.Attributes.Action
{
    public class AuthorizeAttribute : Attribute
    {
        private readonly string role;

        public AuthorizeAttribute()
        {

        }

        public AuthorizeAttribute(string role)
        {
            this.role = role;
        }

        private bool IsIdentityPresent(IIdentity identity)
        {
            return identity != null;
        }

        private bool IsIdentityInRole(IIdentity identity)
        {
            return IsIdentityPresent(identity) ? identity.Roles.Any(x => x == role) : false;
        }

        public bool IsAuthorized(IIdentity user)
        {
            if (string.IsNullOrEmpty(role))
            {
                return IsIdentityPresent(user);
            }
            else
            {
                return IsIdentityInRole(user);
            }
        }
    }
}
