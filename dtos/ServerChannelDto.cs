namespace ChatLPCommon.Dtos
{
    public class ServerChannelResponseDto
    {
        public Guid Id { get; }
        public string Name { get; }
        public ServerChannelMessageResponseDto[]? Messages { get; }

        public ServerChannelResponseDto(Guid id, string name, ServerChannelMessageResponseDto[]? messages)
        {
            Id = id;
            Name = name;
            Messages = messages;
        }
    }

    public class ServerChannelMessageResponseDto
    {
        public Guid Id { get; }
        public Guid AuthorId { get; }
        public string Content { get; }
        public AttachmentResponseDto[]? Attachments { get; }

        public ServerChannelMessageResponseDto(Guid id, Guid authorId, string content, AttachmentResponseDto[]? attachments)
        {
            Id = id;
            AuthorId = authorId;
            Content = content;
            Attachments = attachments;
        }
    }
}