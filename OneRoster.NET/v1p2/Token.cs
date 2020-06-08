using System;

namespace OneRoster.NET.v1p2
{
    public class Token
    {
        public Token()
        {
            CreatedAt = DateTime.Now;
        }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public string error { get; set; }
        public string expires_in { get; set; }
        public string token_type { get; set; }
        public string scope { get; set; }
        public DateTime CreatedAt {get;}

        public bool NotExpired()
        {
            long elapsedTicks = DateTime.Now.Ticks - CreatedAt.Ticks;
            var elapsedSpan = new TimeSpan(elapsedTicks);
            return elapsedSpan.Seconds < Convert.ToInt32(expires_in);
        }
    }
}