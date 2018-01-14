using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using IsThis.Decks;
using Plugin.SimpleAudioPlayer.Abstractions;
using System.Reflection;
using System.IO;

namespace IsThis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectedGameInfoPage : ContentPage
	{
        
        ISimpleAudioPlayer GOT_Theme_00;
        ISimpleAudioPlayer GOT_Theme_01;


        public SelectedGameInfoPage ()
		{
			InitializeComponent ();

            NavigationPage.SetHasNavigationBar(this, false);
            
            playselecteddeckButton.BackgroundColor = Color.FromHex(Global.ButtonBackColor);
            playselecteddeckButton.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            deckinfoLabel.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);

            ThemeSoundPlay();

        }


        //-------------------------------Theme sound start------------------------------------------------------------------------------------------

        public void ThemeSoundPlay()
        {

            switch (Global.DeckNumber)
            {

                case 1:
                    var stream0 = GetStreamFromGOT_Theme0File("got_s1e5_pays_his_debts.wav");
                    GOT_Theme_00 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
                    GOT_Theme_00.Load(stream0);

                    var stream1 = GetStreamFromGOT_Theme1File("got_s1e7_win_or_die.wav");
                    GOT_Theme_01 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    GOT_Theme_01.Load(stream1);

                    Stream GetStreamFromGOT_Theme0File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("IsThis.Sounds.GOT." + filename);

                        return stream;
                    }
                    Stream GetStreamFromGOT_Theme1File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("IsThis.Sounds.GOT." + filename);

                        return stream;
                    }



                    System.Random RandomNumber = new System.Random();  //Generating random number for selected deck (to choose specific 
                    int playthisNow = RandomNumber.Next(0, 2);         // 2-1 = total streams




                    switch (playthisNow)                              //Playing random theme sound form selected deck
                    {
                        case 0:
                            GOT_Theme_00.Volume = Global.ThemeSoundVolume;
                            GOT_Theme_00.Play();
                            break;
                        case 1:
                            GOT_Theme_01.Volume = Global.ThemeSoundVolume;
                            GOT_Theme_01.Play();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public void ThemeSoundsStop()
        {
            switch (Global.DeckNumber)
            {
                case 1:
                    if (GOT_Theme_00.IsPlaying)
                    {
                        GOT_Theme_00.Stop();
                    }
                    else if (GOT_Theme_01.IsPlaying)
                    {
                        GOT_Theme_01.Stop();
                    }
                    break;
                default:
                    break;
            }
            
        }
        //-------------------------------------Theme sounds end------------------------------------------------------------------------------------



        protected override void OnAppearing()
        {
            Global.CheckLanguage();
            Selecteddeckinfo();
            deckinfoLabel.Text = Global.DeckInfo;
            SelectedDeckPoster.Source = Global.DeckPoster;
            playselecteddeckButton.Text = Global.PlayButtonText;
            //SettingsButton.Text = Global.SettingsButtonText;


            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            ThemeSoundsStop();
            base.OnDisappearing();
        }




        public async void Selecteddeckinfo()
        {
            switch (Global.DeckNumber)
            {
                case 1:
                    //make_some_Theme_sounds.ThemeSoundPlay(Global.DeckNumber);
                   
                    GotDeck.SetDeckInfo();
                    break;
                case 2:
                   
                    LordDeck.SetDeckInfo();
                    break;
                case 3:
                   
                    HarryDeck.SetDeckInfo();
                    break;
                case 4:
                   
                    FriendsDeck.SetDeckInfo();
                    break;
                default:
                  await  Navigation.PushAsync(new GameSelectionPage());
                    break;
            }
        }

        private async void PlayselecteddeckButton_Clicked(object sender, EventArgs e)
        {
            playselecteddeckButton.IsEnabled = false;
            await Navigation.PushAsync(new GameplayPage());
            
        }

        //private async void SettingsButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Settings());
        //}
    }
}