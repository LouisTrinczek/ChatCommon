namespace ChatLPCommon.Dtos
{
    public class AttachmentResponseDto
    {
        public Guid Id { get; }
        public string FileName { get; }
        public string Url { get; }

        public AttachmentResponseDto(Guid id, string fileName, string url)
        {
            Id = id;
            FileName = fileName;
            Url = url;
        }
    }
}
