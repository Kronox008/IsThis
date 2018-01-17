using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;

namespace IsThis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        //public static string naujas = "https://drive.google.com/uc?id=1X6dLrZ1JnAm6N2_6mznQ-2ugMW4IFYO7";

        //CachedImage _image = new CachedImage()
        //{
        //    HorizontalOptions = LayoutOptions.StartAndExpand,
        //    VerticalOptions = LayoutOptions.StartAndExpand,
        //    Aspect = Aspect.Fill,
        //    CacheDuration = TimeSpan.FromDays(30),
        //    DownsampleToViewSize = true,
        //    RetryCount = 0,
        //    RetryDelay = 250,
        //    TransparencyEnabled = false,
        //    LoadingPlaceholder = "loading.png",
        //    ErrorPlaceholder = "error.png",
        //    Source = naujas,
        //};
        public TestPage()
        {
            InitializeComponent();
            //


            
            //stackas.Children.Add(_image);



        }
        //public void addimg() {

        //    var cachedImage = new CachedImage()
        //    {
        //        HorizontalOptions = LayoutOptions.StartAndExpand,
        //        VerticalOptions = LayoutOptions.StartAndExpand,
        //        Aspect = Aspect.Fill,
        //        CacheDuration = TimeSpan.FromDays(30),
        //        DownsampleToViewSize = true,
        //        RetryCount = 0,
        //        RetryDelay = 250,
        //        TransparencyEnabled = false,
        //        LoadingPlaceholder = "loading.png",
        //        ErrorPlaceholder = "error.png",
        //        Source = naujas,
        //    };
           
        //    // testnewimage.Source = "http://loremflickr.com/600/600/nature?filename=simple.jpg";

        //    stackas.Children.Add(cachedImage);
        //}

        private void Button_Clicked(object sender, EventArgs e)
        {
            ff_image.Source = "https://drive.google.com/uc?id=1QhECQUj8CC1gN-cElsi1Wrgvwj2NSryn";
        }
    }
}