using System;
using System.Collections.Generic;

namespace OneRoster.NET.SharedDtos
{
    /// <summary>
    /// A Course is a course of study that, typically, has a shared curriculum although it may be taught to different students by different 
    /// teachers. It is likely that several classes of a single course may be taught in a term. For example, a school runs Grade 9 English 
    /// in the spring term. There are four classes, each with a different 30 students, taught by 4 different teachers. However the curriculum 
    /// for each of those four classes is the same - the course curriculum.
    /// </summary>
    public class Course
    {
        public string SourcedId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset DateLastModified { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Title { get; set; }

        public string CourseCode { get; set; }

        /// <summary>
        /// v1p1 only
        /// </summary>
        public List<string> Grades { get; set; }

        public List<string> Subjects { get; set; }

        public List<string> SubjectCodes { get; set; }

        public GuidRef Org { get; set; }

    }

    public class Courses
    {
        public List<Course> courses { get; set; }
    }

    public class SingleCourse
    {
        public Course course { get; set; }
    }
}