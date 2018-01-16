using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using Xamarin.Forms;
using System.Threading;

namespace IsThis.Droid
{

    [Activity(Label = "IsThis", Icon = "@drawable/TentIcon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity 
    {



        public static bool Volumeoff { get; set; }
        protected override void OnCreate(Bundle bundle)

        {
           
            
            //allowing the device to change the screen orientation based on the rotation
            MessagingCenter.Subscribe<GameplayPage>(this, "forceLandScapePortrait", sender =>
            { RequestedOrientation = ScreenOrientation.SensorLandscape;});

            //during page close setting back to portrait
            MessagingCenter.Subscribe<GameplayPage>(this, "freeorientation", sender =>
            {RequestedOrientation = ScreenOrientation.Unspecified;});



            MessagingCenter.Subscribe<GameplayPage>(this, "VolumeButtonOFF", sender =>
            {  Volumeoff = true; });

            MessagingCenter.Subscribe<GameplayPage>(this, "VolumeButtonON", sender =>
            { Volumeoff = false; });

            this.Window.AddFlags(WindowManagerFlags.Fullscreen);
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //string dbName = "travel_db.sqlite";
            //string folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            //string fullPath = Path.Combine(folderPath, dbName);

            LoadApplication(new App());

        }
        
        public override bool OnKeyUp(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.VolumeDown)
            {
                if (Volumeoff)
                {
                    MessagingCenter.Send<object>(this, "Down");
                    return true;
                }
                else
                {
                    return base.OnKeyUp(keyCode, e);
                }
            }

            if (keyCode == Keycode.VolumeUp)
            {
                if (Volumeoff)
                {                                                     
                    MessagingCenter.Send<object>(this, "Up");
                    return true;
                }
                else
                {
                    return base.OnKeyUp(keyCode, e);
                }
            }
            return base.OnKeyUp(keyCode, e);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.VolumeDown)
            {
                if (Volumeoff)
                {
                    return true;
                }
                return base.OnKeyDown(keyCode, e);
            }

            if (keyCode == Keycode.VolumeUp)
            {
                if(Volumeoff)
                {
                    return true;
                }
                return base.OnKeyDown(keyCode, e);
            }
            return base.OnKeyDown(keyCode, e);
        }
        


    }

}  















