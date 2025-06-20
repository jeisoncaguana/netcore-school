using netcore_school.Models.Http;

namespace netcore_school.Helpers
{
    public class HttpResponseHelper
    {
        private static string _mode;

        public static void Configure(IConfiguration configuration)
        {
            _mode = configuration.GetSection("AppSettings:Mode").Value ?? "developer";
        }

        public static HttpResponseModel Success(string message = "", object status = null, object data = null)
        {
            return new HttpResponseModel

            {
                Message = message,
                Status = status,
                Data = data,
                Errors = null,
                Mode = _mode
            };
        }

        public static HttpResponseModel Error(string message = "", object status = null, object errors = null)
        {
            return new HttpResponseModel
            {
                Message = message,
                Status = status,
                Data = null,
                Errors = errors,
                Mode = _mode
            };
        }
    }
}
