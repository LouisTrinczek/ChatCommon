using System.ComponentModel.DataAnnotations;
using Chat.Common.Types;

namespace Chat.Common.Dtos
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public OnlineStatus OnlineStatus { get; set; }
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Parameterless Constructor for Mapperly to work
        /// </summary>
        public UserResponseDto() { }

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
        [Required(ErrorMessage = "UsernameIsRequired")]
        [MaxLength(20, ErrorMessage = "UsernameIsTooLong")]
        public string Username { get; }

        [Required(ErrorMessage = "EmailIsRequired")]
        [EmailAddress(ErrorMessage = "EmailIsNotValid")]
        public string Email { get; }

        [Required(ErrorMessage = "PasswordIsRequired")]
        [MinLength(7, ErrorMessage = "PasswordIsTooShort")]
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
