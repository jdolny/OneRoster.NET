using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p2
{
    /// <summary>
    /// This enables the management of Classes i.e. scheduled learning of courses.
    /// </summary>
    public class ClassesManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public ClassesManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Classes GetAllClasses(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Classes>(_request);
        }
        public IRestResponse GetAllClassesRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetAllClassesAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }

        /// <summary>
        /// To read, get, one class by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleClass GetClass(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleClass>(_request);
        }
        public IRestResponse GetClassRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleClass> GetClassAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleClass>(_request);
        }

        /// <summary>
        /// To read, get, a collection of students i.e. all students for the current school year for a class.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Users GetStudentsForClass(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Users>(_request);
        }
        public IRestResponse GetStudentsForClassRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetStudentsForClassAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, a collection of teachers i.e. all teachers for the current school year for a class.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public Users GetTeachersForClass(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Users>(_request);
        }
        public IRestResponse GetTeachersForClassRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetTeachersForClassAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/classes/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }


    }
}