using RestSharp;
using System.Net;


namespace OneRoster.NET.v1p2
{
    internal class Oauth2
    {
        private readonly RestClient _client;
        private readonly RestRequest _request;

        internal Oauth2(string tokenUrl)
        {
            _client = new RestClient(tokenUrl);
            _request = new RestRequest();
        }

        internal Token GetToken(string clientId, string clientSecret)
        {
            _request.Method = Method.POST;
            _request.AddParameter("grant_type", "client_credentials");
            _request.AddParameter("client_id", clientId);
            _request.AddParameter("client_secret", clientSecret);
            _request.AddParameter("scope", "http://purl.imsglobal.org/spec/or/v1p2/scope/roster.readonly http://purl.imsglobal.org/spec/or/v1p2/scope/roster-core.readonly http://purl.imsglobal.org/spec/or/v1p2/scope/roster-demographics.readonly");
            var response = _client.Execute<Token>(_request);

            if (response == null)
            {
                return new Token() { error = "Could Not Complete Token Request.The Response was empty." + _request.Resource };
            }

            var token = new Token();
            if (response.Data != null)
            {
                token = response.Data;
            }

            if (response.ErrorException != null)
            {
                return new Token() { error = "Error Obtaining Token", error_description = response.ErrorException.ToString() };
            }

            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    break;
                case HttpStatusCode.NotFound:
                case 0:
                    token.error = "Could Not Contact Token URL";
                    break;
                case HttpStatusCode.BadRequest:
                    token.error = "Bad Request";
                    token.error_description = response.Content;
                    break;
                default:
                    token.error_description = "Unknown Error Obtaining Token";
                    break;
            }

            return token;
        }
    }
}