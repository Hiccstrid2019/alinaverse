using Entities.Models;

namespace Contracts;

public interface ITweetRepository
{
    int CreateTweet(Tweet tweet);
    Tweet GetTweetById(int id);
    IEnumerable<Tweet> GetUserTweets(int userId);
}