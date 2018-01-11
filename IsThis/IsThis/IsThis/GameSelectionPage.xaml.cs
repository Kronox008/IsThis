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
            public int IsTimerOn { get; set; }
        }
        

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
                    Saved_Quantity = 20,
                    Saved_Time = 90,
                    IsTimerOn = 0,                                                        
                };
                await _connection.InsertOrReplaceAsync(DefaultNumbers);
                LoadNumbers = await _connection.GetAsync<Saved_Settings>(1);
            }
                Global.QuestionQuantity = LoadNumbers.Saved_Quantity;
                Global.CountDownTime = LoadNumbers.Saved_Time;
                Global.CountDownTimeIsOn = LoadNumbers.IsTimerOn;










            // var SavedinDB = new Saved_Settings()
            // { StaticId = 1,
            //      Saved_Quantity = 10,
            //      Saved_Time = 30,
            //      IsTimerOn = 1,                                                         /////Working
            //   };
            //await _connection.InsertOrReplaceAsync(SavedinDB);

            // var testiswork = new Saved_Settings();
            // testiswork = await _connection.GetAsync<Saved_Settings>(1);



            base.OnAppearing();
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