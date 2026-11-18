using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] arg)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Learning C#";
        video1._author = "John";
        video1._length = 600;

        video1._comments.Add(new Comment { _name = "Maria", _text = "Great video!" });
        video1._comments.Add(new Comment { _name = "Sarah", _text = "Very helpful!" });
        video1._comments.Add(new Comment { _name = "Tom", _text = "Thanks" });

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "Painter Artist";
        video2._author = "Doris Aguilar";
        video2._length = 450;

        video2._comments.Add(new Comment { _name = "Anna", _text = "Inspired image!" });
        video2._comments.Add(new Comment { _name = "James", _text = "Very realistic!" });
        video2._comments.Add(new Comment { _name = "Lisa", _text = "Thanks for sharing your talent!" });

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "Travel Tips";
        video3._author = "David";
        video3._length = 720;

        video3._comments.Add(new Comment { _name = "Karen", _text = "Excellent!" });
        video3._comments.Add(new Comment { _name = "Paul", _text = "Helpful tips." });
        video3._comments.Add(new Comment { _name = "Emma", _text = "Great content!" });

        videos.Add(video3);


        // Create video2 with 3 comments
        // Create video3 with 3 comments

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }


    }
}
