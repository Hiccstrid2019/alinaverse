namespace Shared.DataTransferObjects;

public record TweetForCreationDto(int UserId, DateTime DateTime, string Text);