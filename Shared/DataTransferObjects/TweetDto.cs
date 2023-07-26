namespace Shared.DataTransferObjects;

public record TweetDto(int Id, DateTime DateTime, string Text, int CountLikes);