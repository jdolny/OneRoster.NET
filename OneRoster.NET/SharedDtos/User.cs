using System;
using System.Collections.Generic;
using static OneRoster.NET.SharedDtos.SharedVocabulary;

namespace OneRoster.NET.SharedDtos
{
    /// <summary>
    /// Users, Teachers and Students are human beings that are teaching or studying in a class respectively. LIS represents these with Person. 
    /// For the case of binding, it is proposed that a single User class is used to represent both teachers and students, and that a role 
    /// element be used to distinguish a user's natural role. In the rest binding to follow, it is possible to select teachers and students 
    /// within a school, course or class. In LIS, users have an "institution role" set within the person record to identify their (primary) 
    /// role.  Note that this requirement is expanded to introduce other types of human: parents, guardians, relatives and aides.  
    /// Humans may have relationships with other humans.For example, a student may have parents.The "agents" attribute allows for relationships between humans to be expressed. Note that these are typically from the point of view of the student - so a student will link to its parents (via the agent attribute). The reverse view MUST also be modeled, so for example, a user of role "parent" MUST have agents that are of type "student".
    /// Note: Teachers MUST NOT be set as agents of students -the teaching relationship is covered via enrollments
    /// </summary>
    public class User
    {
        public string SourcedId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset DateLastModified { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string UserMasterIdentifier { get; set; }

        public string Identifier { get; set; }

        public string Username { get; set; }

        public bool EnabledUser { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string MiddleName { get; set; }

        public string PreferredFirstName { get; set; }

        public string PreferredLastName { get; set; }

        public string PreferredMiddleName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Sms { get; set; }

        public List<UserId> UserIds { get; set; }

        /// <summary>
        /// v1p1 only
        /// </summary>
        public RoleType? Role { get; set; }

        /// <summary>
        /// v1p2 only
        /// </summary>
        public List<UserRole> Roles { get; set; }

        public List<GuidRef> Agents { get; set; }

        public List<string> Grades { get; set; }

        /// <summary>
        /// v1p2 only
        /// </summary>
        public UserRole RoleTypesForGreatestPrimaryEnrollment { get; set; }

        /// <summary>
        /// v1p1 only
        /// </summary>
        public string Password { get; set; }
    }

    public class Users
    {
        public List<User> users { get; set; }
    }

    public class SingleUser
    {
        public User user { get; set; }
    }
}