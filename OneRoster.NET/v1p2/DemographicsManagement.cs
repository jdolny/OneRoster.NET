using OneRoster.NET.SharedDtos;
using RestSharp;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p2
{
    /// <summary>
    /// This enables the management of demographics information (each assigned to a specific user).
    /// </summary>
    public class DemographicsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public DemographicsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of demographic data. Demographics information is taken from the Common Educational Data Standards (CEDS) 
        /// from the US government. sourcedId refers to person GUID. publicSchoolResidenceStatus is not supported.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Demographicss GetAllDemographics(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/demographics/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<Demographicss>(_request);
        }
        public IRestResponse GetAllDemographicsRaw(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/demographics/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<Demographicss> GetAllDemographicsAsync(ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/demographics/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Demographicss>(_request);
        }

        /// <summary>
        /// To read, get, one demographic by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public SingleDemographic GetDemographics(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/demographics/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.Execute<SingleDemographic>(_request);
        }
        public IRestResponse GetDemographicsRaw(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/demographics/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleDemographic> GetDemographicsAsync(string sourcedId, ApiParameters p = null)
        {
            _request.Method = Method.GET;
            _request.Resource = $"/demographics/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleDemographic>(_request);
        }


    }
}