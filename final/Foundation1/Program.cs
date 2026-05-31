using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Tie a Tie", "Dapper Channel", 600);

        video1.AddComment(new Comment("Bruce2", "Great video!"));
        video1.AddComment(new Comment("CatWarple203", "What if I have a bow tie?"));
        video1.AddComment(new Comment("CharlesThompson", "My wife does mine"));

        Video video2 = new Video("How to get free money (not a scam!!!!)", "FreeRobux2040", 800);

        video2.AddComment(new Comment("Dave2", "Is this legit?"));
        video2.AddComment(new Comment("CarLover", "OMG!!!! I got free money!"));
        video2.AddComment(new Comment("Frank", "Highly recommend."));

        Video video3 = new Video("Crayon Review", "Color Academy", 500);

        video3.AddComment(new Comment("ArtGirl", "The blue crayon is my fav"));
        video3.AddComment(new Comment("Heidi", "Try mixing blue and green."));
        video3.AddComment(new Comment("AnnaBanana", "Helped me get started."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayInfo();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}