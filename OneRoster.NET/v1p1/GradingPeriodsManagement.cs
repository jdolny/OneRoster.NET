using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p1
{
    /// <summary>
    /// This enables the management of grading periods i.e. specific academic sessions.
    /// </summary>
    public class GradingPeriodsManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly RestRequest _request;

        public GradingPeriodsManagement(V1p1Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of grading periods i.e. all grading periods for the current school year. 
        /// Refers to campus terms and schedule sets by term GUID and structure GUID.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public AcademicSessions GetAllGradingPeriods(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/gradingPeriods/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<AcademicSessions>(_request, p);
        }
        public IRestResponse GetAllGradingPeriodsRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/gradingPeriods/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<AcademicSessions> GetAllGradingPeriodsAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/gradingPeriods/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request, p);
        }

        /// <summary>
        /// To read, get, one grading period by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleAcademicSession GetGradingPeriod(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/gradingPeriods/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleAcademicSession>(_request, p);
        }
        public IRestResponse GetGradingPeriodRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/gradingPeriods/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request, p);
        }
        public async Task<SingleAcademicSession> GetGradingPeriodAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/gradingPeriods/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleAcademicSession>(_request, p);
        }


    }
}