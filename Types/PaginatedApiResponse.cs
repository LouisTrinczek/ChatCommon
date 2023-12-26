namespace ChatLPCommon.Types;

public class PaginatedApiResponse<T>
{
    public ResponseStatus Status { get; }
    public int TotalPages { get; }
    public int CurrentPage { get; }
    public int TotalRecords { get; }
    public int SkippedRecords { get; }
    public int RecordsToSend { get; }
    public bool HasNext { get; }
    public T? Data { get; }
    public string[] Messages { get; }

    public PaginatedApiResponse(ResponseStatus status, int totalPages, int currentPage, int totalRecords,
        int recordsToSend, int skippedRecords, bool hasNext, T data, string[] messages)
    {
        Status = status;
        TotalPages = totalPages;
        CurrentPage = currentPage;
        TotalRecords = totalRecords;
        RecordsToSend = recordsToSend;
        SkippedRecords = skippedRecords;
        HasNext = hasNext;
        Data = data;
        Messages = messages;
    }
}