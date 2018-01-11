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
    [Activity(Label = "IsThis", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)

        {

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
                Toast.MakeText(this, "Volume Down pressed", ToastLength.Long).Show();
                MessagingCenter.Send<object>(this, "Down");
                
                return true;
            }

            if (keyCode == Keycode.VolumeUp)
            {
               // Toast.MakeText(this, "Volume up pressed", ToastLength.Long).Show();
                MessagingCenter.Send<object>(this, "Up");

                
                return true;
            }
            return base.OnKeyUp(keyCode, e);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.VolumeDown)
            {
                
                return true;
            }

            if (keyCode == Keycode.VolumeUp)
            {
                
                return true;
            }
            return base.OnKeyDown(keyCode, e);
        }
        


    }

}  















