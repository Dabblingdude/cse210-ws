using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video0 = new Video("Pro Player Tries Impossible Challenge", "RacerMan", 956);
        video0.AddComment("gamer77", "You suck, I could do that faster!");        
        video0.AddComment("Bob Hope", "You're so cool");
        video0.AddComment("turtlelover5719", "I like turtles");
        videos.Add(video0);

        Video video1 = new Video("The Piano Guys Behind ThePianoGuys - Studio C", "Studio C", 281);
        video1.AddComment("gamer77", "I can play the piano and cello at the same time");        
        video1.AddComment("Bob Hope", "Love this!");
        video1.AddComment("turtlelover5719", "I really like turtles");
        videos.Add(video1);

        Video video2 = new Video("Everything We Know So Far About Dark Matter", "PBS", 10820);
        video2.AddComment("gamer77", "Why haven't you solved this yet?");        
        video2.AddComment("Bob Hope", "Y'all are so smart");
        video2.AddComment("turtlelover5719", "I love turtles");
        videos.Add(video2);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}