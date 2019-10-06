using Microsoft.AspNetCore.Http;

namespace Dating.API.Helpers
{
    public static class Extensions
    {
        //override the http response
        public static void AddApplicationError(this HttpResponse response, string message){
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            // response.Headers.Add("Access-control-Allow-Origin", "*");
        }
    }
}