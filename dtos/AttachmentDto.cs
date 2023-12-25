namespace ChatLPCommon.Dtos
{
    public class AttachmentDto
    {
        public Guid Id;
        public string FileName;
        public string Url;

        public AttachmentDto(Guid id, string fileName, string url)
        {
            Id = id;
            FileName = fileName;
            Url = url;
        }
    }
}