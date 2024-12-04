namespace MvcMovie.Models;
    /// <summary>
    /// Represents the error details for the application.
    /// </summary>
    /// <remarks>
    /// This model is used to display error details to the user, including a unique RequestId for tracking and debugging purposes.
    /// Built-in from Asp.net and is for developers, if error page will become a error log for debugging, very useful
    /// </remarks>
public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
