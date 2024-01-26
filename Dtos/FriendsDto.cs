using System.ComponentModel.DataAnnotations;

namespace Chat.Common.Dtos
{
    public class FriendsRequestDto
    {
        [Required(ErrorMessage = "FriendIdIsRequired")]
        public string FriendId { get; }

        public FriendsRequestDto(string friendId)
        {
            FriendId = friendId;
        }
    }
}
