using System;
using System.Collections.Generic;

namespace OneRoster.NET.SharedDtos
{
    /// <summary>
    /// A class is an instance of a course, onto which students and teachers are enrolled. A class is typically held within a term.
    /// </summary>
    public class Class
    {
        public string SourcedId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset DateLastModified { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Title { get; set; }

        public string ClassType { get; set; }

        public string ClassCode { get; set; }

        public string Location { get; set; }

        /// <summary>
        /// v1p1 only
        /// </summary>
        public List<string> Grades { get; set; }

        public List<string> Subjects { get; set; }

        public GuidRef Course { get; set; }

        public GuidRef School { get; set; }

        public List<GuidRef> Terms { get; set; }

        public List<string> SubjectCodes { get; set; }

        public List<string> Periods { get; set; }

    }

    public class Classes
    {
        public List<Class> classes { get; set; }
    }

    public class SingleClass
    {
        public Class Class { get; set; }
    }
}