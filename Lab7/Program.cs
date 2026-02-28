using System;
using static System.Console;
using System.Collections.Generic;

namespace MediaPlayerSystem
{
    public interface AudioPlayer
    {
        void PlayAudio();
    }


    public interface VideoPlayer
    {
        void PlayVideo();
    }


    public class SmartMediaPlayer : AudioPlayer, VideoPlayer
    {

        public void PlayAudio()
        {
            WriteLine($" Now Playing Audio ");
        }


        public void PlayVideo()
        {
            WriteLine($" Now Playing video");
        }


        public void PlayAudioVideo()
        {
            PlayAudio();
            PlayVideo();
        }

    }


        public class AudioOnlyPlayer : AudioPlayer
        {
            public void PlayAudio()
            {
                WriteLine($" Playing Audio Only");
            }
        }

    

    class program
    {
        static void Main()
        {
            WriteLine("=====Media Player=====\n");

            List <AudioPlayer> audioplayers= new List<AudioPlayer>
            { 
                new SmartMediaPlayer() ,
                new AudioOnlyPlayer() ,
                new SmartMediaPlayer() 
            };

            WriteLine("AudioPlayer Players List: ");
            foreach (var player in audioplayers)
            {
                player.PlayAudio();
            }

            //*****************************************************************************
            WriteLine("\n******************\n");


            List <VideoPlayer> videoplayers= new List<VideoPlayer> 
            {
            new SmartMediaPlayer() ,
            new SmartMediaPlayer()
            };

            WriteLine("VideoPlayer Players List: ");
            foreach (var player in videoplayers)
            {
                player.PlayVideo();
            }

            ReadKey();
        }
    }
}