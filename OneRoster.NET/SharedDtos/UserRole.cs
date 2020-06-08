
using static OneRoster.NET.SharedDtos.SharedVocabulary;

namespace OneRoster.NET.SharedDtos
{
    public class UserRole
    {
        public RoleType Role { get; set; }

        public GuidRef Org { get; set; }

        public UserRoleRoleType RoleType { get; set; }
    }

   
}