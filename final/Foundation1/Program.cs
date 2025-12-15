using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Real Life Trick Shots | Dude Perfect", "Dude Perfect", 303);
        Comment comment1 = new Comment("Palmerater", "These are the kind of things you do accidently when no one else is around and just wish you had a way to record everything you ever did.");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("PookieDookie44", "0:44 I love how Cory is just casually watering the plants while Ty starts the grill, but really he's there so that if the grass is on fire he can hose it off🤣");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("desertedstream", "succeeds at pen trick shot\ncan't rip paper\nSucceeds at 4 clothing trick shots\ncan't turn off light");
        video1.AddComment(comment3);
        Comment comment4 = new Comment("sumenabegum8663", "Anyone 2025?");
        video1.AddComment(comment4);
        videos.Add(video1);

        Video video2 = new Video("Michael Jackson - Thriller (Official 4K Video)", "Michael Jackson", 821);
        comment1 = new Comment("hudsonfilmss", "Michael Jackson has fans that aren’t even born yet.");
        video2.AddComment(comment1);
        comment2 = new Comment("Local-Art-Kid", "When we were kids: Scariest thing we ever saw\nNow: A masterpiece");
        video2.AddComment(comment2);
        comment3 = new Comment("kamiikamira", "this is THE halloween anthem");
        video2.AddComment(comment3);
        comment4 = new Comment("JakobHofer", "❤ Still listening 🎉 December 2025 🎉 Who else is here today? ❤");
        video2.AddComment(comment4);
        videos.Add(video2);

        Video video3 = new Video("Super Mario 64 HACKING! - PBG", "PeanutButterGamer", 669);
        comment1 = new Comment("brockbracken318", "HOW WAS THIS 11 YEARS AGO?!");
        video3.AddComment(comment1);
        comment2 = new Comment("kennymalice", "This is timeless thank you pbg I was laughing when I was 13 and still laughing now when I'm 20");
        video3.AddComment(comment2);
        comment3 = new Comment("swaggyshaggy6889", "“Mario is five balls with flashing trousers and he has no head.”\n\nI felt that");
        video3.AddComment(comment3);
        comment4 = new Comment("yonavlad3723", "This man singlehandedly made my childhood");
        video3.AddComment(comment4);
        videos.Add(video3);

        foreach(Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}