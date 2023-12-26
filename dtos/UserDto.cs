using System.ComponentModel.DataAnnotations;

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

        public UserLoginDto(string username, string email, string password) : base(username, email, password)
        {
            Username = username;
            Email = email;
        }
    }

    public class UserUpdateDto : UserRegistrationDto
    {
        public new string? Username { get; }
        public new string? Email { get; }
        public new string? Password { get; }
        
        public UserUpdateDto(string username, string email, string password) : base(username, email, password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}