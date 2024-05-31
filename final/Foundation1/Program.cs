using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 240),
            new Video("Video 3", "Author 3", 360)
        };

        videos[0].AddComment(new Comment("Commenter 1", "Great video!"));
        videos[0].AddComment(new Comment("Commenter 2", "Thanks for sharing!"));
        videos[0].AddComment(new Comment("Commenter 3", "I love it!"));

        videos[1].AddComment(new Comment("Commenter 4", "I like this video!"));
        videos[1].AddComment(new Comment("Commenter 5", "Very informative!"));
        videos[1].AddComment(new Comment("Commenter 6", "Thanks for sharing!"));

        videos[2].AddComment(new Comment("Commenter 7", "Nice job!"));
        videos[2].AddComment(new Comment("Commenter 8", "I learned a lot from this video."));
        videos[2].AddComment(new Comment("Commenter 9", "A must see videos and a lot to learn."));

        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}