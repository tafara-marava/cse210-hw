using System;
using System.Collections.Generic;



class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        comments.Add(comment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }

    public List<Comment> Comments
    {
        get { return comments; }
    }
}

