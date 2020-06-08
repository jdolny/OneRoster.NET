using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p1
{
    /// <summary>
    /// This enables the management of Courses i.e. programme of study.
    /// </summary>
    public class CoursesManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly RestRequest _request;

        public CoursesManagement(V1p1Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of courses i.e. all courses for the current school year. Refers to campus courses. 
        /// Properties that are not supported: schoolYear, grades, resources. status is always active
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Courses GetAllCourses(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Courses>(_request, p);
        }
        public IRestResponse GetAllCoursesRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<Courses> GetAllCoursesAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Courses>(_request, p);
        }

        /// <summary>
        /// To read, get, one course by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleCourse GetCourse(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleCourse>(_request, p);
        }
        public IRestResponse GetCourseRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<SingleCourse> GetCourseAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleCourse>(_request, p);
        }

        /// <summary>
        /// To read, get, classes for a course by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Classes GetClassesForCourse(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Classes>(_request, p);
        }
        public IRestResponse GetClassesForCourseRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<Classes> GetClassesForCourseAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/courses/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request, p);
        }


    }
}