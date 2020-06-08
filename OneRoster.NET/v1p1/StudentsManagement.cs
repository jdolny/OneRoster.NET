using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p1
{
    /// <summary>
    /// This enables the management of information about students (a student is a type of 'user').
    /// </summary>
    public class StudentsManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly RestRequest _request;

        public StudentsManagement(V1p1Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of students i.e. all students enrolled for the current school year. 
        /// Properties that are not supported: userProfiles, userIds, identifier, username is not valid for login. 
        /// Filtering by grades is not supported.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Users GetAllStudents(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Users>(_request, p);
        }
        public IRestResponse GetAllStudentsRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<Users> GetAllStudentsAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request, p);
        }

        /// <summary>
        /// To read, get, one student by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleUser GetStudent(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleUser>(_request, p);
        }
        public IRestResponse GetStudentRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<SingleUser> GetStudentAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleUser>(_request, p);
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year for a student. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Classes GetClassesForStudent(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Classes>(_request, p);
        }
        public IRestResponse GetClassesForStudentRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<Classes> GetClassesForStudentAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/students/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request, p);
        }


    }
}