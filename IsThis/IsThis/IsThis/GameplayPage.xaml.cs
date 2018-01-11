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
    public partial class GameplayPage : ContentPage
    {
        Sound Make_some_Correct_sounds = new Sound();
        Sound Make_some_Skip_sounds = new Sound();
        Sound Make_some_Tick_sounds = new Sound();

        int i = 0;
        public GameplayPage()
        {
            InitializeComponent();
            
           NavigationPage.SetHasNavigationBar(this, false);
            CorrectButton.BackgroundColor = Color.FromHex(Global.CorrectColorHex);
            CorrectButton.TextColor = Color.FromHex(Global.ButtonTextColor);
            SkipButton.BackgroundColor = Color.FromHex(Global.SkipColorHex);
            SkipButton.TextColor = Color.FromHex(Global.ButtonTextColor);
            CountingLabel.TextColor = Color.FromHex(Global.ButtonBackColor);
            QuestionLabel.TextColor = Color.FromHex(Global.ButtonBackColor);
            TimerLabel.TextColor = Color.FromHex(Global.ButtonBackColor);
            Animation();
        }
        protected override bool OnBackButtonPressed()
        {
            BackToRoot();
            return true;
        }
        private async void BackToRoot()
        {
            await Navigation.PushAsync(new GameSelectionPage());
        }



        private async void Animation()
        {
            Make_some_Tick_sounds.TickSoundStream();
            uint duration = 1 * 1000;
            QuestionImage.IsVisible = false;
            QuestionLabel.IsVisible = false;
            CorrectButton.IsVisible = false;
            SkipButton.IsVisible = false;
            CountingLabel.Text = "3";
            
            await Task.WhenAll(
            CountingLabel.RotateTo(361, duration));
           
            CountingLabel.Text = "2";
            await Task.WhenAll(
            CountingLabel.RotateTo(722, duration));


            CountingLabel.Text = "1";
            await Task.WhenAll(
            CountingLabel.RotateTo(1083, duration));
            Make_some_Tick_sounds.TickSoundPlay();

            PlayTimeNow();
        }
        private void PlayTimeNow()
        {
            Global.IsCorrectCount = 0;
            Make_some_Correct_sounds.CorrectSoundStream();
            Make_some_Skip_sounds.SkipSoundStream();
            QuestionImage.IsVisible = true;                      
            QuestionLabel.IsVisible = true;
            CountingLabel.IsVisible = false;
            QuestionImage.Opacity = 0;
            QuestionImage.FadeTo(0.2, 1000);
            QuestionImage.Source = Global.ShuffledQuestion[i, 1];
            QuestionLabel.Text = Global.ShuffledQuestion[i, 0];
            CorrectButton.IsVisible = true;
            SkipButton.IsVisible = true;
            VolumeButtonsActive();
            Timer();

        }

        private async void GameOver()
        {
            CorrectButton.IsVisible = false;
            SkipButton.IsVisible = false;
            VolumeButtonsDisabled();
            await Navigation.PushAsync(new AfterGamePage());
        }
        private void Correct_Button_Clicked(object sender, EventArgs e)
        {
            On_CorrectandSkip_button_clicked(true);
        }
        private void Skip_Button_Clicked(object sender, EventArgs e)
        {
            On_CorrectandSkip_button_clicked(false);
        }
        private async void On_CorrectandSkip_button_clicked (bool CorS)
        {
            if(CorS)
            {
                Make_some_Correct_sounds.CorrectSoundPlay();
                Global.IsCorrect[i] = 1;
                Global.IsGuessed[i] = 1;
                Global.IsCorrectCount += 1;
                i++;
                if (i < 10)
                {
                    QuestionLabel.Text = Global.ShuffledQuestion[i, 0];
                    CorrectButton.IsEnabled = false;
                    SkipButton.IsEnabled = false;
                    VolumeButtonsDisabled();
                    await QuestionImage.FadeTo(0, 1000);
                    QuestionImage.Source = Global.ShuffledQuestion[i, 1];
                    QuestionImage.FadeTo(0.2, 1000);
                    CorrectButton.IsEnabled = true;
                    SkipButton.IsEnabled = true;
                    VolumeButtonsActive();

                }
                else
                {
                    GameOver();
                }
            }
            else
            {
                Make_some_Skip_sounds.SkipSoundPlay();
                Global.IsCorrect[i] = 0;
                Global.IsGuessed[i] = 1;
                i++;
                if (i < 10)
                {

                    QuestionLabel.Text = Global.ShuffledQuestion[i, 0];
                    CorrectButton.IsEnabled = false;
                    SkipButton.IsEnabled = false;
                    VolumeButtonsDisabled();
                    await QuestionImage.FadeTo(0, 1000);
                    QuestionImage.Source = Global.ShuffledQuestion[i, 1];
                    QuestionImage.FadeTo(0.2, 1000);
                    CorrectButton.IsEnabled = true;
                    SkipButton.IsEnabled = true;
                    VolumeButtonsActive();
                }
                else
                {
                    GameOver();
                }
            }
        }
        
        private void VolumeButtonsActive()
        {

            MessagingCenter.Subscribe<object>(this, "Up", (sender) =>
               {
                   On_CorrectandSkip_button_clicked(true);
               });
            MessagingCenter.Subscribe<object>(this, "Down",  (sender) =>
            {
                On_CorrectandSkip_button_clicked(false);
            });
           
        }
        private void VolumeButtonsDisabled()
        {
            MessagingCenter.Unsubscribe<object>(this, "Up");
            MessagingCenter.Unsubscribe<object>(this, "Down");
        }
        private async void Timer ()
        {

            if (Global.CountDownTime <= 180)
            { 
                TimerLabel.IsVisible = true;
            for (int _second = Global.CountDownTime; _second >= 0; _second--)
            {
                TimerLabel.Text = Convert.ToString(_second);
                await Task.Delay(1000);
            }
            GameOver();
            }

        }



    }
    }
