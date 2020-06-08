using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p2
{
    /// <summary>
    /// This enables the management of academic sessions i.e. periods of academic activity.
    /// </summary>
    public class AcademicSessionsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public AcademicSessionsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of academic sessions i.e. all academic sessions for the current school year. Refers to campus terms.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public AcademicSessions GetAllAcademicSessions(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/academicSessions/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<AcademicSessions>(_request);
        }
        public IRestResponse GetAllAcademicSessionsRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/academicSessions/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSessions> GetAllAcademicSessionsAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/academicSessions/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }

        /// <summary>
        /// To read, get, one academicSession by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleAcademicSession GetAcademicSession(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/academicSessions/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleAcademicSession>(_request);
        }
        public IRestResponse GetAcademicSessionRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/academicSessions/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleAcademicSession> GetAcademicSessionAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/academicSessions/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleAcademicSession>(_request);
        }



    }
}