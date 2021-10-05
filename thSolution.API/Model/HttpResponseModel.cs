using Newtonsoft.Json;

namespace thSolution.API.Model
{
    public class HttpResponseModel
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public HttpResponseModel(int code, object data, string message)
        {
            Code = code;
            Data = data;
            Message = message;
        }
    }
}
