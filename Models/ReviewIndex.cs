namespace MvcMovie.Models;
public class ReviewIndex
{
    public int Id { get; set; }
    public List<Review> Reviews { get; set; }
    public Review NewReview { get; set; }
}