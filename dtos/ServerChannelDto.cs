namespace ChatLPCommon.Dtos
{
    public class ServerChannelResponseDto
    {
        public Guid Id { get; }
        public string Name { get; }
        public MessageResponseDto[]? Messages { get; }

        public ServerChannelResponseDto(Guid id, string name, MessageResponseDto[]? messages)
        {
            Id = id;
            Name = name;
            Messages = messages;
        }
    }

    public class ServerChannelCreateDto
    {
        public string Name { get; }

        public ServerChannelCreateDto(string name)
        {
            Name = name;
        }
    }

    public class ServerChannelUpdateDto : ServerChannelCreateDto
    {
        public ServerChannelUpdateDto(string name) : base(name)
        {
        }
    }
}