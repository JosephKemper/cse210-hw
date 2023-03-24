using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program 1: Abstraction with YouTube Videos");
        Video runVideo = new Video();
        runVideo.LoadFile();
        runVideo.DisplayVideoData();
    }
}