using System;

public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count();
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}");
        Console.WriteLine($"{_duration} seconds");
        Console.WriteLine();
        Console.WriteLine($"{GetCommentCount()} comments:");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine();
    }
}