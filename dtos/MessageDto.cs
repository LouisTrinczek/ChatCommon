namespace Chat.Common.Dtos
{
    public class MessageResponseDto
    {
        public Guid Id { get; }
        public Guid AuthorId { get; }
        public string Content { get; }
        public AttachmentResponseDto[]? Attachments { get; }

        public MessageResponseDto(Guid id, Guid authorId, string content, AttachmentResponseDto[]? attachments)
        {
            Id = id;
            AuthorId = authorId;
            Content = content;
            Attachments = attachments;
        }
    }

    public class MessageCreateDto
    {
        public string Content { get; }
        public Guid AuthorId { get; }

        public MessageCreateDto(string content, Guid authorId)
        {
            Content = content;
            AuthorId = authorId;
        }
    }

    public class MessageUpdateDto
    {
        
    }
}