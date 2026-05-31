using System.Collections.Generic;

public class Video : Content
{
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
        : base(title, author)
    {
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {GetNumberOfComments()}");
    }
}