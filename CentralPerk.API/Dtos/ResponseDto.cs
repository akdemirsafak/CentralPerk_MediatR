using System.Text.Json.Serialization;

namespace CentralPerk.API.Dtos;

public class ResponseDto<T>
{
    public T Data { get; set; }
    public List<string> Errors { get; set; }

    [JsonIgnore] public int StatusCode { get; set; }

    //Static Factory Method
    public static ResponseDto<T> Success(T Data, int statusCode = 0)
    {
        return new ResponseDto<T> { Data = Data, StatusCode = statusCode };
    }

    public static ResponseDto<T> Success(int statusCode = 0)
    {
        return new ResponseDto<T> { Data = default, StatusCode = statusCode };
    }

    public static ResponseDto<T> Fail(List<string> errors, int statusCode = 0)
    {
        return new ResponseDto<T> { Data = default, Errors = errors, StatusCode = statusCode };
    }

    public static ResponseDto<T> Fail(string error, int statusCode = 0)
    {
        return new ResponseDto<T> { Data = default, Errors = new List<string> { error }, StatusCode = statusCode };
    }
}