namespace ChatLPCommon.Dtos
{
    public class UserDto
    {
        public Guid Id;
        public string Email;
        public string Status;

        public UserDto(Guid id, string email, string status)
        {
            Id = id;
            Email = email;
            Status = status;
        }
    }    
}
