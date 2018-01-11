using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Plugin.SimpleAudioPlayer.Abstractions;

namespace IsThis
{
    public  class Sound
    {
        ISimpleAudioPlayer CorrectSoundPlayer;
        ISimpleAudioPlayer SkipSoundPlayer;
        ISimpleAudioPlayer TickSoundPlayer;
        public void CorrectSoundStream()
        {
            var stream = GetStreamFromCorrectFile("Correct.mp3");
            CorrectSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            CorrectSoundPlayer.Load(stream);
            

        }
       public void CorrectSoundPlay()
        {
            CorrectSoundPlayer.Play();
        }
        
        
        Stream GetStreamFromCorrectFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("IsThis.Sounds." + filename);

            return stream;
        }
//-------------------------------------------------------------------------------------------------------------------------

        public void SkipSoundStream()
        {
            var stream = GetStreamFromSkipFile("Skip.mp3");
            SkipSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            SkipSoundPlayer.Load(stream);


        }
        public void SkipSoundPlay()
        {
            SkipSoundPlayer.Play();
        }


        Stream GetStreamFromSkipFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("IsThis.Sounds." + filename);

            return stream;
        }
//-------------------------------------------------------------------------------------------------------------------------
        public void TickSoundStream()
        {
            var stream = GetStreamFromTickFile("Button.mp3");
            TickSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            TickSoundPlayer.Load(stream);


        }
        public void TickSoundPlay()
        {
            TickSoundPlayer.Play();
        }


        Stream GetStreamFromTickFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("IsThis.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------



    }
}
