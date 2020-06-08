using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p1
{
    /// <summary>
    /// This enables the management of information about teachers (a teacher is a type of 'user').
    /// </summary>
    public class TeachersManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly RestRequest _request;

        public TeachersManagement(V1p1Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of teachers i.e. all teachers registered to teach for the current school year. 
        /// Properties that are not supported: userProfiles, userIds, identifier, grades, username is not valid for login.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Users GetAllTeachers(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Users>(_request, p);
        }
        public IRestResponse GetAllTeachersRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<Users> GetAllTeachersAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request, p);
        }

        /// <summary>
        /// To read, get, one teacher by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleUser GetTeacher(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleUser>(_request, p);
        }
        public IRestResponse GetTeacherRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<SingleUser> GetTeacherAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleUser>(_request, p);
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year for a teacher. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Classes GetClassesForTeacher(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Classes>(_request, p);
        }
        public IRestResponse GetClassesForTeacherRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<Classes> GetClassesForTeacherAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/teachers/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request, p);
        }

    }
}