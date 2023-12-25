namespace ChatLPCommon.Dtos
{
    public class ServerChannelDto
    {
        public Guid Id;
        public string Name;
        public ServerChannelMessageDto[] Messages;

        public ServerChannelDto(Guid id, string name, ServerChannelMessageDto[] messages)
        {
            Id = id;
            Name = name;
            Messages = messages;
        }
    }

    public class ServerChannelMessageDto
    {
        public Guid Id;
        public Guid AuthorId;
        public string Content;
        public AttachmentDto[]? Attachments;

        public ServerChannelMessageDto(Guid id, Guid authorId, string content, AttachmentDto[]? attachments)
        {
            Id = id;
            AuthorId = authorId;
            Content = content;
            Attachments = attachments;
        }
    }
}