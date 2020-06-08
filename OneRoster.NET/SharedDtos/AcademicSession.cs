using System;
using System.Collections.Generic;
using static OneRoster.NET.SharedDtos.SharedVocabulary;

namespace OneRoster.NET.SharedDtos
{
    /// <summary>
    /// AcademicSession represent durations of time. Typically they are used to describe terms, grading periods, and other durations e.g. 
    /// school years. Term is used to describe a period of time during which learning will take place. Other words for term could be in common 
    /// use around the world e.g. Semester. The important thing is that Term is a unit of time, often many weeks long, into which classes are 
    /// scheduled. Grading Period is used to represent another unit of time, that within which line items are assessed. A term may have many 
    /// grading periods, a grading period belongs to a single term. A class may be assessed over several grade periods (represented by a line 
    /// item being connected to a grading period). The parent / child attributes of academic sessions allow terms to be connected to their 
    /// grading periods and vice-versa.
    /// </summary>
    public class AcademicSession
    {
        public string SourcedId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset DateLastModified { get; set; }

        public Dictionary<string, string> Metadata { get; set; }

        public string Title { get; set; }

        public string SchoolYear { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public List<GuidRef> Children { get; set; }

        public GuidRef Parent { get; set; }

        public AcademicSessionType? Type { get; set; }

    }

    public class AcademicSessions
    {
        public List<AcademicSession> academicSessions { get; set; }
    }

    public class SingleAcademicSession
    {
        public AcademicSession academicSession { get; set; }
    }

   
}