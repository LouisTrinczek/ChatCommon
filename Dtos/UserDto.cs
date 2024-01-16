using Chat.Common.Types;

namespace Chat.Common.Dtos
{
    public class UserResponseDto
    {
        public Guid Id { get; }
        public string Username { get; }
        public OnlineStatus OnlineStatus { get; }
        public string AvatarUrl { get; }

        public UserResponseDto(
            Guid id,
            string username,
            OnlineStatus onlineStatus,
            string avatarUrl
        )
        {
            Id = id;
            Username = username;
            OnlineStatus = onlineStatus;
            AvatarUrl = avatarUrl;
        }
    }

    public class UserRegistrationDto
    {
        public string Username { get; }
        public string Email { get; }
        public string Password { get; }

        public UserRegistrationDto(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }

    public class UserLoginDto : UserRegistrationDto
    {
        public new string? Username { get; }
        public new string? Email { get; }

        public UserLoginDto(string username, string email, string password)
            : base(username, email, password)
        {
            Username = username;
            Email = email;
        }
    }

    public class UserUpdateDto : UserRegistrationDto
    {
        public UserUpdateDto(string username, string email, string password)
            : base(username, email, password) { }
    }
}
