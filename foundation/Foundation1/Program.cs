using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("Blindfolded golfing", "Henry Davis", 600);
        video1.AddComment(new Comment("GamerDude", "FAKE"));
        video1.AddComment(new Comment("Tiger Woods", "Please teach me."));
        video1.AddComment(new Comment("Sportfan647", "This is the only way golf can be cool."));

        Video video2 = new Video("My first Vision", "Joseph Smith", 750);
        video2.AddComment(new Comment("Porter Rockwell", "Where can I learn more??"));
        video2.AddComment(new Comment("Gov. Boggs, official", "Get out of my state."));
        video2.AddComment(new Comment("Moroni", "Don't listen to the haters!!"));

        List<Video> videos = new List<Video> { video1, video2 };

        
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}


class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();  
    }

    
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

   
    public int GetCommentCount()
    {
        return Comments.Count;
    }

   
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        
        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Text}");
        }
        Console.WriteLine();
    }
}