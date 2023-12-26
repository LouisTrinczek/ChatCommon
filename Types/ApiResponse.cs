namespace ChatLPCommon.Types;

public class ApiResponse<T> 
{
   public ResponseStatus Status { get; }
   public T? Data { get; } 
   public string Message { get; }

   public ApiResponse(ResponseStatus status, T? data, string message)
   {
      Status = status;
      Data = data;
      Message = message;
   }
}