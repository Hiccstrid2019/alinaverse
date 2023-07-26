using System.Data;
using Contracts;
using Dapper;
using Entities.Models;
using Microsoft.Extensions.Configuration;

namespace Repository;

public class TweetRepository : RepositoryBase, ITweetRepository
{
    public TweetRepository(IConfiguration configuration) 
        : base(configuration) { }
    
    public int CreateTweet(Tweet tweet)
    {
        using (IDbConnection dbConnection = Connection)
        {
            dbConnection.Open();
            return dbConnection.ExecuteScalar<int>("INSERT INTO tweets (user_id, datetime, text, count_likes) " +
                                            "VALUES (@UserId, @DateTime, @Text, @CountLikes) RETURNING id", tweet);
        }
    }

    public Tweet GetTweetById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Tweet> GetUserTweets(int userId)
    {
        throw new NotImplementedException();
    }
}