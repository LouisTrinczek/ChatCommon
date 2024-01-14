using System.ComponentModel.DataAnnotations;

namespace Chat.Common.Dtos
{
    public class ServerChannelResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<MessageResponseDto> Messages { get; set; }

        public ServerChannelResponseDto(
            Guid id,
            string name,
            ICollection<MessageResponseDto> messages
        )
        {
            Id = id;
            Name = name;
            Messages = messages;
        }
    }

    public class ServerChannelCreateDto
    {
        [Required(ErrorMessage = "ServerChannelNameIsRequired")]
        public string Name { get; set; }

        public ServerChannelCreateDto(string name)
        {
            Name = name;
        }
    }

    public class ServerChannelUpdateDto : ServerChannelCreateDto
    {
        public ServerChannelUpdateDto(string name)
            : base(name) { }
    }
}
