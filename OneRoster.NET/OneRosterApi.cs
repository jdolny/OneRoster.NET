using OneRoster.NET.v1p1;
using OneRoster.NET.v1p2;

namespace OneRoster.NET
{
    public class OneRosterApi
    {
        public V1p1Api V1p1(string baseUrl, string consumerKey, string consumerSecret)
        {
            return new V1p1Api(baseUrl,consumerKey,consumerSecret);
        }

        public V1p2Api V1p2(string tokenUrl, string baseUrl, string clientId, string clientSecret)
        {
            return new V1p2Api(tokenUrl, baseUrl, clientId, clientSecret);
        }
    }
}