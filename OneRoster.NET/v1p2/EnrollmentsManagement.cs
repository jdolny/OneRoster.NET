using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p2
{
    /// <summary>
    /// This enables the management of the enrollments of users (teachers, students, etc.) on classes supplied by schools.
    /// </summary>
    public class EnrollmentsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public EnrollmentsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of enrollment data. An enrollment is the name given to an individual taking part in a class. 
        /// Users will be students learning or teachers teaching in a class. sourcedId refers to roster ID for students and history ID for 
        /// teachers. role only supports students and teachers.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Enrollments GetAllEnrollments(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/enrollments/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Enrollments>(_request);
        }
        public IRestResponse GetAllEnrollmentsRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/enrollments/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Enrollments> GetAllEnrollmentsAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/enrollments/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_request);
        }

        /// <summary>
        /// To read, get, one enrollment by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleEnrollment GetEnrollment(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/enrollments/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleEnrollment>(_request);
        }
        public IRestResponse GetEnrollmentRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/enrollments/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleEnrollment> GetEnrollmentAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/enrollments/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleEnrollment>(_request);
        }


    }
}