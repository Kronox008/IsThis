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
        ISimpleAudioPlayer ScoreSoundPlayer;
        ISimpleAudioPlayer SettingsSoundPlayer;
        private static double MasterVolume = Global.SoundVolume;
        public void CorrectSoundStream()
        {
            var stream = GetStreamFromCorrectFile("conjure_item.mp3");
            CorrectSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            CorrectSoundPlayer.Load(stream);
            

        }
       public void CorrectSoundPlay()
        {
            CorrectSoundPlayer.Volume = MasterVolume;
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
            var stream = GetStreamFromSkipFile("conjure_food.mp3");
            SkipSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            SkipSoundPlayer.Load(stream);


        }
        public void SkipSoundPlay()
        {
            SkipSoundPlayer.Volume = MasterVolume;
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
            var stream = GetStreamFromTickFile("dot.mp3");
            TickSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            TickSoundPlayer.Load(stream);


        }
        public void TickSoundPlay()
        {
            TickSoundPlayer.Volume = MasterVolume;
            TickSoundPlayer.Play();
            
        }



        Stream GetStreamFromTickFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("IsThis.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------
      
        public void ScoreSoundStream()
        {
            var stream = GetStreamFromScoreFile("lvlUP.mp3");
            ScoreSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            ScoreSoundPlayer.Load(stream);


        }
        public void ScoreSoundPlay()
        {
            ScoreSoundPlayer.Volume = MasterVolume;
            ScoreSoundPlayer.Play();

        }



        Stream GetStreamFromScoreFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("IsThis.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public void SettingsSoundStream()
        {
            var stream = GetStreamFromSettingsFile("chestOPEN.mp3");
            SettingsSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            SettingsSoundPlayer.Load(stream);


        }
        public void SettingsSoundPlay()
        {
            SettingsSoundPlayer.Volume = MasterVolume;
            SettingsSoundPlayer.Play();

        }



        Stream GetStreamFromSettingsFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("IsThis.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------



    }
}
