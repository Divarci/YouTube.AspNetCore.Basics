using System.Text.Json.Serialization;

namespace ApiProject.Model
{
    public class CustomResponseModel<T>
    {
        public T? Data { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        [JsonIgnore]
        public bool IsSuccesfull { get; set; }
        public List<string>? Errors { get; set; }


        public static CustomResponseModel<T> Success(T data,int statusCode)
        {
            return new CustomResponseModel<T>()
            {
                Data = data,
                StatusCode = statusCode,
                IsSuccesfull = true

            };            
        }
        public static CustomResponseModel<T> Success(int statusCode)
        {
            return new CustomResponseModel<T>()
            {
                StatusCode = statusCode,
                IsSuccesfull = true

            };
        }
        public static CustomResponseModel<T> Fail(int statusCode, List<string> errors)
        {
            return new CustomResponseModel<T>()
            {
                StatusCode = statusCode,
                IsSuccesfull = true,
                Errors = errors

            };
        }
        public static CustomResponseModel<T> Fail(int statusCode, string error)
        {
            return new CustomResponseModel<T>()
            {
                StatusCode = statusCode,
                IsSuccesfull = true,
                Errors = new List<string> { error }

            };
        }
    }
}
