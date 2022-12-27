using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;

namespace Villa_API.Model
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }

        public bool IsSuccess {  get; set; }
        
        public List<string>? ErrorMessages { get; set; }

        public object? Result { get; set; }
    }
}
