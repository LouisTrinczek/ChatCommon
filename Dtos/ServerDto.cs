using System.ComponentModel.DataAnnotations;

namespace Chat.Common.Dtos
{
    public class ServerResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public string IconUrl { get; set; }
        public UserResponseDto[] Members { get; set; }
        public ServerChannelResponseDto[] Channels { get; set; }

        public ServerResponseDto() { }

        public ServerResponseDto(
            Guid id,
            string name,
            Guid ownerId,
            string iconUrl,
            UserResponseDto[] members,
            ServerChannelResponseDto[] channels
        )
        {
            Id = id;
            Name = name;
            OwnerId = ownerId;
            IconUrl = iconUrl;
            Members = members;
            Channels = channels;
        }
    }

    public class ServerCreationDto
    {
        [Required(ErrorMessage = "ServerNameIsRequired")]
        public string Name { get; set; }

        public ServerCreationDto(string name)
        {
            Name = name;
        }
    }

    public class ServerUpdateDto : ServerCreationDto
    {
        public ServerUpdateDto(string name)
            : base(name) { }
    }
}
