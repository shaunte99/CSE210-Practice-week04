// The Video class is responsible for managing video details and comments
public class Video
{
    // Properties to store video details
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }

    // A private list to store comments for encapsulation
    private List<Comment> Comments = new List<Comment>();

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Method to display the details of the video
    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}

// The Comment class is responsible for managing individual comments
public class Comment
{
    // Properties to store the commenter's name and the text of the comment
    public string Name { get; set; }
    public string Text { get; set; }

    // Method to display the comment details
    public void DisplayComment()
    {
        Console.WriteLine($"{Name}: {Text}");
    }
}
