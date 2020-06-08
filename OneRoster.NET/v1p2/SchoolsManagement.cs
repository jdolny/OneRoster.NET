using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p2
{
    /// <summary>
    /// This enables the management of information about schools. A school is a type of 'org'.
    /// </summary>
    public class SchoolsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public SchoolsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of schools. Refers to campus schools by school GUID. status is always active.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Orgs GetAllSchools(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Orgs>(_request);
        }
        public IRestResponse GetAllSchoolsRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Orgs> GetAllSchoolsAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_request);
        }

        /// <summary>
        /// To read, get, one school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleOrg GetSchool(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleOrg>(_request);
        }
        public IRestResponse GetSchoolRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleOrg> GetSchoolAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleOrg>(_request);
        }

        /// <summary>
        /// To read, get, classes for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Classes GetClassesForSchool(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Classes>(_request);
        }
        public IRestResponse GetClassesForSchoolRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForSchoolAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }

        /// <summary>
        /// To read, get, enrollments for a class in a school by sourcedId
        /// </summary>
        /// <param name="schoolSourcedId"></param>
        /// <param name="classSourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Enrollments GetEnrollmentsForClassInSchool(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Enrollments>(_request);
        }
        public IRestResponse GetEnrollmentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Enrollments> GetEnrollmentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_request);
        }

        /// <summary>
        /// To read, get, students for a class in a school
        /// </summary>
        /// <param name="schoolSourcedId"></param>
        /// <param name="classSourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Users GetStudentsForClassInSchool(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Users>(_request);
        }
        public IRestResponse GetStudentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetStudentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, teachers for a class in a school
        /// </summary>
        /// <param name="schoolSourcedId"></param>
        /// <param name="classSourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Users GetTeachersForClassInSchool(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Users>(_request);
        }
        public IRestResponse GetTeachersForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetTeachersForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, courses for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Courses GetCoursesForSchool(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Courses>(_request);
        }
        public IRestResponse GetCoursesForSchoolRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Courses> GetCoursesForSchoolAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Courses>(_request);
        }

        /// <summary>
        /// To read, get, enrollments for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Enrollments GetEnrollmentsForSchool(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Enrollments>(_request);
        }
        public IRestResponse GetEnrollmentsForSchoolRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Enrollments> GetEnrollmentsForSchoolAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_request);
        }

        /// <summary>
        /// To read, get, students for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        //Todo: This is returning a list of user instead of the Users class, could be a bug in Campus implementation or error in spec
        public List<User> GetStudentsForSchool(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<List<User>>(_request);
        }
        public IRestResponse GetStudentsForSchoolRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<List<User>> GetStudentsForSchoolAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(_request);
        }


        /// <summary>
        /// To read, get, teachers for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        //Todo: This is returning a list of user instead of the Users class, could be a bug in Campus implementation or error in 1.2 spec
        public List<User> GetTeachersForSchool(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<List<User>>(_request);
        }
        public IRestResponse GetTeachersForSchoolRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<List<User>> GetTeachersForSchoolAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(_request);
        }


        /// <summary>
        /// To read, get, terms for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public AcademicSessions GetTermsForSchool(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<AcademicSessions>(_request);
        }
        public IRestResponse GetTermsForSchoolRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSessions> GetTermsForSchoolAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/schools/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }

    }
}