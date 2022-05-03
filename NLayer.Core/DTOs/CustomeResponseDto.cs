using System.Text.Json.Serialization;

namespace NLayer.Core.DTOs
{
    public class CustomeResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }


        public List<String> Errors { get; set; }

        public static CustomeResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomeResponseDto<T> { Data = data, StatusCode = statusCode };
        }
        public static CustomeResponseDto<T> Success(int statusCode)
        {
            return new CustomeResponseDto<T> { StatusCode = statusCode };
        }
        public static CustomeResponseDto<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomeResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }
        public static CustomeResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomeResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
