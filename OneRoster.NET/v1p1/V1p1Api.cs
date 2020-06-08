using RestSharp;
using System;
using System.Threading.Tasks;

namespace OneRoster.NET.v1p1
{
    public class V1p1Api : IDisposable
    {
        private bool disposed;
        private RestClient _restClient;
        private string _consumerKey;
        private string _consumerSecret;

        public V1p1Api(string baseUrl, string consumerKey, string consumerSecret)
        {
            _restClient = new RestClient(baseUrl != null ? baseUrl.TrimEnd('/') : baseUrl);
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
        }

        /// <summary>
        /// This enables the management of academic sessions i.e. periods of academic activity.
        /// </summary>
        public AcademicSessionsManagement AcademicSessionsManagement => new AcademicSessionsManagement(this);

        /// <summary>
        /// This enables the management of Classes i.e. scheduled learning of courses.
        /// </summary>
        public ClassesManagement ClassesManagement => new ClassesManagement(this);

        /// <summary>
        /// This enables the management of Courses i.e. programme of study.
        /// </summary>
        public CoursesManagement CoursesManagement => new CoursesManagement(this);

        /// <summary>
        /// This enables the management of demographics information (each assigned to a specific user).
        /// </summary>
        public DemographicsManagement DemographicsManagement => new DemographicsManagement(this);

        /// <summary>
        /// This enables the management of the enrollments of users (teachers, students, etc.) on classes supplied by schools.
        /// </summary>
        public EnrollmentsManagement EnrollmentsManagement => new EnrollmentsManagement(this);

        /// <summary>
        /// This enables the management of grading periods i.e. specific academic sessions.
        /// </summary>
        public GradingPeriodsManagement GradingPeriodsManagement => new GradingPeriodsManagement(this);

        /// <summary>
        /// This enables the management of Orgs i.e. an organization involved in the learning in some form or other.
        /// </summary>
        public OrgsManagement OrgsManagement => new OrgsManagement(this);

        /// <summary>
        /// This enables the management of information about schools. A school is a type of 'org'.
        /// </summary>
        public SchoolsManagement SchoolsManagement => new SchoolsManagement(this);

        /// <summary>
        /// This enables the management of information about students (a student is a type of 'user').
        /// </summary>
        public StudentsManagement StudentsManagement => new StudentsManagement(this);

        /// <summary>
        /// This enables the management of information about teachers (a teacher is a type of 'user').
        /// </summary>
        public TeachersManagement TeachersManagement => new TeachersManagement(this);

        /// <summary>
        /// This enables the management of information about terms (a term is a type of 'academicSession').
        /// </summary>
        public TermsManagement TermsManagement => new TermsManagement(this);

        /// <summary>
        /// This enables the management of information about users (including students and teachers).
        /// </summary>
        public UsersManagement UsersManagement => new UsersManagement(this);

        internal T Execute<T>(RestRequest request, ApiParameters p) where T : new()
        {
            request.AddHeader("Authorization", new Oauth1(_consumerKey,_consumerSecret).GenerateAuthHeader(_restClient.BaseUrl + request.Resource,p));
            var response = _restClient.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var exception = new Exception(message, response.ErrorException);
                throw exception;
            }
            return response.Data;
        }

        internal async Task<T> ExecuteAsync<T>(RestRequest request, ApiParameters p) where T : new()
        {
            request.AddHeader("Authorization", new Oauth1(_consumerKey, _consumerSecret).GenerateAuthHeader(_restClient.BaseUrl + request.Resource, p));
            var response = await _restClient.ExecuteAsync<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var exception = new Exception(message, response.ErrorException);
                throw exception;
            }
            return response.Data;
        }

        internal IRestResponse GetResponse(RestRequest request, ApiParameters p)
        {
            request.AddHeader("Authorization", new Oauth1(_consumerKey, _consumerSecret).GenerateAuthHeader(_restClient.BaseUrl + request.Resource, p));
            var response = _restClient.Execute(request);
            return response;
        }


        internal RestRequest AddRequestParameters(RestRequest r, ApiParameters p)
        {
            if (p == null) return r;

            if (p.Filter != null)
            {
                r.AddParameter("filter", p.Filter);
            }
            if (p.Sort != null)
            {
                r.AddParameter("sort", p.Sort);
            }
            if (p.OrderBy != null)
            {
                r.AddParameter("orderBy", p.OrderBy);
            }
            if (p.Limit != null)
            {
                r.AddParameter("limit", p.Limit);
            }
            if (p.Offset != null)
            {
                r.AddParameter("offset", p.Offset);
            }
            if (p.Fields != null)
            {
                r.AddParameter("fields", p.Fields);
            }
            if (p.ExtBasic != null)
            {
                r.AddParameter("ext_basic", p.ExtBasic);
            }

            return r;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _restClient = null;
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}