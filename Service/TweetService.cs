using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

public class TweetService : ITweetService
{
    private readonly ITweetRepository _tweetRepository;

    public TweetService(ITweetRepository tweetRepository)
    {
        _tweetRepository = tweetRepository;
    }

    public TweetDto AddTweet(TweetForCreationDto tweetForCreationDto)
    {
        var newTweet = new Tweet()
        {
            UserId = tweetForCreationDto.UserId,
            DateTime = tweetForCreationDto.DateTime,
            Text = tweetForCreationDto.Text,
            CountLikes = 0
        };
        var newTweetId = _tweetRepository.CreateTweet(newTweet);
        return new TweetDto(newTweetId, newTweet.DateTime, newTweet.Text, newTweet.CountLikes);
    }
}