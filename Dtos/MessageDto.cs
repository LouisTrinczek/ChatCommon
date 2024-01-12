using System.ComponentModel.DataAnnotations;

namespace Chat.Common.Dtos
{
    public class MessageResponseDto
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public string Content { get; set; }
        public AttachmentResponseDto[]? Attachments { get; set; }

        public MessageResponseDto() { }

        public MessageResponseDto(
            Guid id,
            Guid authorId,
            string content,
            AttachmentResponseDto[]? attachments
        )
        {
            Id = id;
            AuthorId = authorId;
            Content = content;
            Attachments = attachments;
        }
    }

    public class MessageCreateDto
    {
        [Required(ErrorMessage = "MessageContentIsRequired")]
        public string Content { get; set; }

        [Required(ErrorMessage = "AuthorIdIsRequired")]
        public Guid AuthorId { get; set; }

        public MessageCreateDto() { }

        public MessageCreateDto(string content, Guid authorId)
        {
            Content = content;
            AuthorId = authorId;
        }
    }

    public class MessageUpdateDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "MessageContentIsRequired")]
        public string Content { get; set; }

        public MessageUpdateDto() { }

        public MessageUpdateDto(Guid id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}
