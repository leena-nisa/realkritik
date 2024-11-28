namespace MvcMovie.Models;
    /// <summary>
    /// Represents a view model for managing and displaying reviews on a page.
    /// </summary>
    /// <remarks>
    /// This model combines a list of existing reviews with a new review form,
    /// enabling users to view and submit reviews on the same page.
    /// </remarks>
public class ReviewIndex
{
    public int Id { get; set; }
    public List<Review> Reviews { get; set; }
    public Review NewReview { get; set; }
}