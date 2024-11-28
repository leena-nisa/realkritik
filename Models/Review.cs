namespace MvcMovie.Models;
    /// <summary>
    /// Represents a user-submitted review for an item, such as a movie.
    /// </summary>
    /// <remarks>
    /// This model stores the review details, including the score, description, 
    /// status, and optional image data.
    /// </remarks>
public class Review
{
    public int Id { get; set; }
    public int Score { get; set; }
    public string? ReviewDescription { get; set; }
    public string? status { get; set; } 
    public byte[]? ImageData { get; set; }
    public string? Title { get; set; }
  
}