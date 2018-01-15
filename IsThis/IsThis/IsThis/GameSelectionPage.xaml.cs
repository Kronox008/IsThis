using SQLite;
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
        private SQLiteAsyncConnection _connection;

        public class Saved_Settings
        {
            [SQLite.PrimaryKey, SQLite.AutoIncrement]
            public int StaticId { get; set; }
            public int Saved_Quantity { get; set; }
            public int Saved_Time { get; set; }
            public int LanguageId { get; set; }

        }
        

        public GameSelectionPage()
        {
            InitializeComponent();
           
            NavigationPage.SetHasNavigationBar(this, false);

            SettingsButton.BackgroundColor =Color.FromHex(Global.ButtonBackColor);
            SettingsButton.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            InfoButton.BackgroundColor = Color.FromHex(Global.ButtonBackColor);
            InfoButton.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);


        }
        private void setLanguage()
        {
            Global.CheckLanguage();
            SettingsButton.Text = Global.SettingsButtonText;
            InfoButton.Text = Global.InfoButtonText;
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PopToRootAsync();
            return true;
        }
      


        protected override async void OnAppearing()
        {
           
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.CreateTableAsync<Saved_Settings>();

            var LoadNumbers = new Saved_Settings();

            try
            {
               LoadNumbers = await _connection.GetAsync<Saved_Settings>(1);
            }
            catch (Exception)
            {
                var DefaultNumbers = new Saved_Settings()
                {
                    StaticId = 1,
                    Saved_Quantity = 10,
                    Saved_Time = 90, 
                    LanguageId = 1,
                };
                await _connection.InsertOrReplaceAsync(DefaultNumbers);
               
            }
            LoadNumbers = await _connection.GetAsync<Saved_Settings>(1);

            Global.QuestionQuantity = LoadNumbers.Saved_Quantity;
            Global.CountDownTime = LoadNumbers.Saved_Time;
            Global.LanguageSelectedID = LoadNumbers.LanguageId;
            enableButtons();
            setLanguage();

            
            base.OnAppearing();
        }
        
        private async void myGOT_Clicked(object sender, EventArgs e)
        {
            myGOT.IsEnabled = false;
            Global.DeckNumber = 1;
            Global.DeckPoster = "GOT.jpg";
            await Navigation.PushAsync(new SelectedGameInfoPage());
        }

        private async void myLOTR_Clicked(object sender, EventArgs e)
        {
            myLOTR.IsEnabled = false;
            Global.DeckNumber = 2;
            Global.DeckPoster = "lord.jpg";
            await Navigation.PushAsync(new SelectedGameInfoPage());
        }

        private async void myHP_Clicked(object sender, EventArgs e)
        {
            myHP.IsEnabled = false;
            Global.DeckNumber = 3;
            Global.DeckPoster = "Harry.jpg";
            await Navigation.PushAsync(new SelectedGameInfoPage());
        }

        private async void myFriend_Clicked(object sender, EventArgs e)
        {
            myFriend.IsEnabled = false;
            Global.DeckNumber = 4;
            Global.DeckPoster = "friends.jpg";
            await Navigation.PushAsync(new SelectedGameInfoPage());
        }

        private void myAnimal_Clicked(object sender, EventArgs e)
        {
       //     DisplayAlert("Animals", "Animals clicked", "close alert");
        }

        private async void myAOM_Clicked(object sender, EventArgs e)
        {
            myAOM.IsEnabled = false;
            Global.DeckNumber = 6;
            Global.DeckPoster = "AOM.jpg";
            await Navigation.PushAsync(new SelectedGameInfoPage());
        }

        private void InfoButton_Clicked(object sender, EventArgs e)
        {
            InfoButton.IsEnabled = false;
            Navigation.PushModalAsync(new InfoPage());
        }

        private void SettingsButton_Clicked(object sender, EventArgs e)
        {
            SettingsButton.IsEnabled = false;
            Navigation.PushModalAsync(new Settings());
        }
        private void enableButtons()
        {
            SettingsButton.IsEnabled = true;
            InfoButton.IsEnabled = true;
            myFriend.IsEnabled = true;
            myHP.IsEnabled = true;
            myLOTR.IsEnabled = true;
            myGOT.IsEnabled = true;
            myAOM.IsEnabled = true;
            
        }
    }
}