using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    /// <summary>
    /// Not very sure about the implementation. ///////////////////////////////////////////////////////////////////////////////
    /// </summary>
    //Abstract class
    abstract class VideoPlayer
    {
        //Default Steps

        public abstract void LoadFile();

        public abstract void StartPlay();

        //Steps whtat will be overridden by SubClass
        public abstract void DecodeVideoFormat();

        
    }

    class MP4Video : VideoPlayer
    {
        public override void LoadFile()
        {
            Console.WriteLine("Video file loaded with MP4.");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Video File Started Playing with MP4");
        }

        public override void DecodeVideoFormat()
        {
            Console.WriteLine("Video file is processed with MP4 Decoder");
        }
    }

    class MkvVideo : VideoPlayer
    {
        public override void LoadFile()
        {
            Console.WriteLine("Video file loaded with Mkv.");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Video File Started Playing with Mkv");
        }

        public override void DecodeVideoFormat()
        {
            Console.WriteLine("Video file is processed with Mkv Decoder");
        }
    }
    class StrategyPatternExample
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Video Player - MP4 Video");

        //    VideoPlayer fileExporter = new MP4Video();
        //    fileExporter.LoadFile();
        //    fileExporter.StartPlay();
        //    fileExporter.DecodeVideoFormat();

        //    Console.WriteLine("\nVideo Player - Mkv video");
        //    fileExporter = new MkvVideo();
        //    fileExporter.LoadFile();
        //    fileExporter.StartPlay();
        //    fileExporter.DecodeVideoFormat();

        //    Console.Read();
        //}
    }
}
