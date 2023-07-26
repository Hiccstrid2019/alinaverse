using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface ITweetService
{
    TweetDto AddTweet(TweetForCreationDto tweetForCreationDto);
}