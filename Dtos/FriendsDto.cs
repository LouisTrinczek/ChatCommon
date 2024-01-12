namespace Chat.Common.Dtos
{
    public class FriendsResponseDto
    {
        public UserResponseDto Friend { get; }

        public FriendsResponseDto(UserResponseDto friend)
        {
            Friend = friend;
        }
    }

    public class FriendsRequestDto
    {
        public Guid FriendId { get; }

        public FriendsRequestDto(Guid friendId)
        {
            FriendId = friendId;
        }
    }
}
