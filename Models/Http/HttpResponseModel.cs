namespace netcore_school.Models.Http
{
    public class HttpResponseModel
    {
        public string Message { get; set; }
        public object Status { get; set; }
        public object Data { get; set; }
        public object Errors { get; set; }
        public string Mode { get; set; }
    }
}
