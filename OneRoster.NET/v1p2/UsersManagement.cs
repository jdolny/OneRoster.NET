using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p2
{
    /// <summary>
    /// This enables the management of information about users (including students and teachers).
    /// </summary>
    public class UsersManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public UsersManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of users i.e. all user for the current school year. 
        /// Properties that are not supported: userProfiles, userIds, identifier, username is not valid for login. 
        /// Filtering by grades of students is not supported.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Users GetAllUsers(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Users>(_request);
        }
        public IRestResponse GetAllUsersRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetAllUsersAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, one user by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleUser GetUser(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleUser>(_request);
        }
        public IRestResponse GetUserRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleUser> GetUserAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleUser>(_request);
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year for a student or teacher. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Classes GetClassesForUser(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Classes>(_request);
        }
        public IRestResponse GetClassesForUserRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForUserAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/users/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }


    }
}