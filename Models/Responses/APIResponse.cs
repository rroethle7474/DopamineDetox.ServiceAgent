namespace DopamineDetox.ServiceAgent.Models.Responses
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
        public Exception? Exception { get; set; }

        public static ApiResponse<T> SuccessResult(T data)
        {
            return new ApiResponse<T> { Success = true, Data = data };
        }

        public static ApiResponse<T> FailureResult(string message, Exception? exception = null)
        {
            return new ApiResponse<T> { Success = false, Message = message, Exception = exception };
        }
    }
}
