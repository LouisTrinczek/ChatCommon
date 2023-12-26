namespace Chat.Common.Types;

public class ApiResponse<T> 
{
   public ResponseStatus Status { get; }
   public T? Data { get; } 
   public string[] Messages { get; }

   public ApiResponse(ResponseStatus status, T? data, string[] messages)
   {
      Status = status;
      Data = data;
      Messages = messages;
   }
}