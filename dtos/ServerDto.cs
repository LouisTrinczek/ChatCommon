namespace ChatLPCommon.Dtos
{
    public class ServerResponseDto
    {
        public Guid Id { get; }
        public string Name { get; }
        public Guid OwnerId { get; }
        public UserResponseDto[] Members { get; }
        public ServerChannelResponseDto[] Channels { get; }

        public ServerResponseDto(
            Guid id, 
            string name, 
            Guid ownerId, 
            UserResponseDto[] members,
            ServerChannelResponseDto[] channels)
        {
            Id = id;
            Name = name;
            OwnerId = ownerId;
            Members = members;
            Channels = channels;
        }
    }
}