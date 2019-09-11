using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    ////Abstract class
    //abstract class VideoPlayer
    //{
    //    //Default Steps

    //    public void LoadFile()
    //    {
    //        Console.WriteLine("Video file loaded.");
    //    }

    //    public void StartPlay()
    //    {
    //        Console.WriteLine("Video File Started Playing");
    //    }

    //    //Steps whtat will be overridden by SubClass
    //    public abstract void DecodeVideoFormat();

    //    public void PlayVideo()
    //    {
    //        this.LoadFile();
    //        this.DecodeVideoFormat();
    //        this.StartPlay();
    //    }
    //}

    //class MP4Video : VideoPlayer
    //{
    //    public override void DecodeVideoFormat()
    //    {
    //        Console.WriteLine("Video file is processed with MP4 Decoder");
    //    }
    //}

    //class MkvVideo : VideoPlayer
    //{
    //    public override void DecodeVideoFormat()
    //    {
    //        Console.WriteLine("Video file is processed with Mkv Decoder");
    //    }
    //}

    class TemplatePatternExample
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Video Player - MP4 Video");

        //    VideoPlayer fileExporter = new MP4Video();
        //    fileExporter.PlayVideo();

        //    Console.WriteLine("\nVideo Player - Mkv video");
        //    fileExporter = new MkvVideo();
        //    fileExporter.PlayVideo();

        //    Console.Read();
        //}
    }
}
