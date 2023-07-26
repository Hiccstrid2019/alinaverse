using Shared.DapperCustomAttributes;

namespace Entities.Models;

public class Tweet
{
    public int Id { get; set; }
    [Column(Name = "user_id")]
    public int UserId { get; set; }
    [Column(Name = "datetime")]
    public DateTime DateTime { get; set; }
    public string Text { get; set; }
    [Column(Name = "count_likes")]
    public int CountLikes { get; set; }
}