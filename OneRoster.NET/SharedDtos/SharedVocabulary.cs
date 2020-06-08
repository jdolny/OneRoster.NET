
namespace OneRoster.NET.SharedDtos
{
    public class SharedVocabulary
    {
        public enum AcademicSessionType
        {
            GRADING_PERIOD = 0,

            SEMESTER = 1,

            SCHOOL_YEAR = 2,

            TERM = 3,

        }

        public enum RoleType
        {

            ADMINISTRATOR = 0,


            AIDE = 1,


            GUARDIAN = 2,


            PARENT = 3,


            PROCTOR = 4,


            RELATIVE = 5,


            STUDENT = 6,


            TEACHER = 7,

        }

        public enum UserRoleRoleType
        {

            PRIMARY = 0,


            SECONDARY = 1,

        }
    }
}