using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ONEbook.NG2.API.Log
{
    /// <summary>
    /// For writing logs request and response into database.
    /// </summary>
    internal class Writer : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // log request body
            string requestBody = await request.Content.ReadAsStringAsync();
            Trace.WriteLine(requestBody);

            // let other handlers process the request
            var result = await base.SendAsync(request, cancellationToken);

            if (result.Content != null)
            {
                // once response body is ready, log it
                var responseBody = await result.Content.ReadAsStringAsync();
                Trace.WriteLine(responseBody);
            }

            return result;
        }
    }
}
