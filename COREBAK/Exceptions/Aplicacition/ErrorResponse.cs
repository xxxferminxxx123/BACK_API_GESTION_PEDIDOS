namespace COREBAK.Exceptions.Aplicacition
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
        public DateTime Timestamp { get; set; }
        public string Path { get; set; }

        public ErrorResponse(int statusCode, string message, string details = null, string path = null)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
            Timestamp = DateTime.UtcNow;
            Path = path;
        }
    }
}