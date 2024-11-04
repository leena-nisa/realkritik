namespace MvcMovie.Models;
public class Review
{
    public int Id { get; set; }
    public int Score { get; set; }
    public string? ReviewDescription { get; set; }
    public string? status { get; set; } 
    public byte[]? ImageData { get; set; }
    public string? Title { get; set; }
  
}