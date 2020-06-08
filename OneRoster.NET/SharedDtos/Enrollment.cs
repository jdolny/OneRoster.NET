using System;
using System.Collections.Generic;

namespace OneRoster.NET.SharedDtos
{


    /// <summary>
    /// An enrollment is the name given to an individual taking part in a course or class. In the vast majority of cases, 
    /// users will be students learning in a class, or teachers teaching the class. Other roles are also possible.
    /// </summary>
    public class Enrollment
    {
        public string SourcedId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset DateLastModified { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Role { get; set; }

        public bool Primary { get; set; }

        public DateTimeOffset BeginDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public GuidRef User { get; set; }

        public GuidRef Class { get; set; }

        public GuidRef School { get; set; }

    }

    public class Enrollments
    {
        public List<Enrollment> enrollments { get; set; }

    }

    public class SingleEnrollment
    {
        public Enrollment enrollment { get; set; }
    }
}