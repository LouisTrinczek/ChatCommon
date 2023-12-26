namespace ChatLPCommon.Dtos
{
    public class UserResponseDto
    {
        public Guid Id { get; }
        public string Username { get; }
        public string Status { get; }

        public UserResponseDto(Guid id, string username, string status)
        {
            Id = id;
            Username = username;
            Status = status;
        }
    }    
}
