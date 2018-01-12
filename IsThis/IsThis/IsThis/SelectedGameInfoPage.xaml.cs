using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IsThis.Decks;

namespace IsThis
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectedGameInfoPage : ContentPage
	{
		public SelectedGameInfoPage ()
		{
			InitializeComponent ();
            Selecteddeckinfo();
            Title = Global.DeckName;
            playselecteddeckButton.Text = Global.Deckcounter.ToString();

            NavigationPage.SetHasNavigationBar(this, false);
            playselecteddeckButton.BackgroundColor = Color.FromHex(Global.ButtonBackColor);
           playselecteddeckButton.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            deckinfoLabel.TextColor = Color.FromHex(Global.ButtonBackColor);


        }




        public async void Selecteddeckinfo()
        {
            switch (Global.DeckNumber)
            {
                case 1:
                    GotDeck.SetDeckInfo();
                    deckinfoLabel.Text = Global.DeckInfo;
                    SelectedDeckPoster.Source = Global.DeckPoster;
                    break;
                case 4:
                    FriendsDeck.SetDeckInfo();
                    deckinfoLabel.Text = Global.DeckInfo;
                    SelectedDeckPoster.Source = Global.DeckPoster;
                    break;
                default:
                  await  Navigation.PushAsync(new GameSelectionPage());
                    break;
            }
        }

        private async void PlayselecteddeckButton_Clicked(object sender, EventArgs e)
        {
         await Navigation.PushAsync(new GameplayPage());
            
        }

        private async void SettingsButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new Settings());
        }
    }
}