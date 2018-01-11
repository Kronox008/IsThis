using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IsThis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameSelectionPage : ContentPage
    {
        public GameSelectionPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
           
            
            //   NavigationPage.SetHasBackButton(this, false);
            //((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Black;
            //  ((NavigationPage)Application.Current.MainPage).BarTextColor =       Color.Gold;
            /*myGOT.GestureRecognizers.Add(new TapGestureRecognizer //myGOT - picture x:name
            {
                Command = new Command(() => DisplayAlert("GOT", "GOT clicked", "close alert"))
            });
            */
        }

        private async void myFriend_Clicked(object sender, EventArgs e)
        {
            Global.DeckNumber = 4;
            Global.DeckPoster = "friends.jpg";
          await  Navigation.PushAsync(new SelectedGameInfoPage());
        }

        private void myGOT_Clicked(object sender, EventArgs e)
        {
            Global.DeckNumber = 1;
            Global.DeckPoster = "GOT.jpg";
            Navigation.PushAsync(new SelectedGameInfoPage());
        }

        private void myLOTR_Clicked(object sender, EventArgs e)
        {
           
        }

        private void myHP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Settings());
        }

        private void myAnimal_Clicked(object sender, EventArgs e)
        {
       //     DisplayAlert("Animals", "Animals clicked", "close alert");
        }

        private void myAOM_Clicked(object sender, EventArgs e)
        {
       //     DisplayAlert("Age of Mythology", "AOM clicked", "close alert");
        }
    }
}