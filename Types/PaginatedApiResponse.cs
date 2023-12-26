namespace ChatLPCommon.Types;

public class PaginatedApiResponse<T>
{
    public ResponseStatus Status { get; }
    public int Page { get; }
    public int Limit { get; }
    public T? Payload { get; }
    
    public PaginatedApiResponse(ResponseStatus status, int page, int limit, T? payload)
    {
        Status = status;
        Page = page;
        Limit = limit;
        Payload = payload;
    }

}