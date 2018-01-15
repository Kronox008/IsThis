﻿using System;
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

            Animation();
        }
        protected override bool OnBackButtonPressed()
        {
            //BackToRoot();
            GameOver();
            return true;
        }
       
        //private async void BackToRoot()
        //{
        //    await Navigation.PushAsync(new GameSelectionPage());
        //}



        private async void Animation()
        {
            CorrectButton.BackgroundColor = Color.FromHex(Global.CorrectColorHex);
            CorrectButton.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            CorrectButton.Text = Global.CorrectButtonText;
            SkipButton.BackgroundColor = Color.FromHex(Global.SkipColorHex);
            SkipButton.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            SkipButton.Text = Global.SkipButtonText;
            QuestionLabelBox.BackgroundColor = Color.FromHex(Global.QuestionBoxColor);
            QuestionLabel.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            CountingLabel.TextColor = Color.FromHex(Global.TimersColors);
            TimerLabel.TextColor = Color.FromHex(Global.TimersColors);
            


            Make_some_Tick_sounds.TickSoundStream();
            
            uint duration = 1000;

            QuestionImage.IsVisible = false;
            QuestionLabel.IsVisible = false;
            CorrectButton.IsVisible = false;
            SkipButton.IsVisible = false;
            QuestionLabelBox.IsVisible = false;

           
             CountingLabel.Text = "3";
            await CountingLabel.RotateTo(361, duration, Easing.SinInOut);

           
            CountingLabel.Text = "2";
            await CountingLabel.RotateTo(722, duration, Easing.SinInOut);

            
            CountingLabel.Text = "1";
            await CountingLabel.RotateTo(1083, duration, Easing.SinInOut);

            Make_some_Tick_sounds.TickSoundPlay();     /////////////////////// Sound







            //CountingLabel.Text = "3";
            //await Task.WhenAll(
            //CountingLabel.RotateTo(361, duration));

            //CountingLabel.Text = "2";
            //await Task.WhenAll(
            //CountingLabel.RotateTo(722, duration));


            //CountingLabel.Text = "1";
            //await Task.WhenAll(
            //CountingLabel.RotateTo(1083, duration));





            PlayTimeNow();
        }
        private void PlayTimeNow()
        {
            Make_some_Correct_sounds.CorrectSoundStream();
            Make_some_Skip_sounds.SkipSoundStream();
           
            QuestionImage.IsVisible = true;
            QuestionLabelBox.IsVisible = true;
            QuestionLabel.IsVisible = true;
            CountingLabel.IsVisible = false;
            QuestionImage.Opacity = 0;

            QuestionLabelBox.Opacity = 0;
            QuestionLabelBox.FadeTo(0.3, 1000);
            var animateExpand = new Animation(d => QuestionLabelBox.HeightRequest = d, 0, 50, Easing.CubicIn);
            animateExpand.Commit(QuestionLabelBox, "box", 16, 800);

            QuestionImage.FadeTo(0.3, 700);
          
            QuestionImage.Source = Global.ShuffledQuestion[i, 1];
            QuestionLabel.Text = Global.ShuffledQuestion[i, 0];

            
            CorrectButton.IsVisible = true;
            SkipButton.IsVisible = true;
            VolumeButtonsActive();
            Timer();

        }

        private async void GameOver()
        {
            Global.CountDownTimeIsRunning = false;
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
            {//correct
               Make_some_Correct_sounds.CorrectSoundPlay();
                Global.IsCorrect[i] = 1;
                Global.IsGuessed[i] = 1;
                Global.IsCorrectCount += 1;
                i++;
                if (i < Global.QuestionQuantity)
                {
                    CorrectButton.IsEnabled = false;
                    SkipButton.IsEnabled = false;
                    VolumeButtonsDisabled();
                    //extension color in
                    
                                QuestionLabelBox.ShiftColorTo
                                   (
                                   sourceColor: QuestionLabelBox.BackgroundColor,
                                   targetColor: Color.FromRgb(80, 200, 120),
                                   setter: color =>
                                   {
                                       QuestionLabelBox.BackgroundColor = color;

                                   },
                                   length: 500,
                                   easing: Easing.CubicOut);
                    //
                    await CorrectFlash.FadeTo(0.2, 500, Easing.CubicOut);
                    QuestionLabel.Text = Global.ShuffledQuestion[i, 0];
                    CorrectFlash.FadeTo(0, 500, Easing.CubicOut);
                    //extension color out

                    QuestionLabelBox.ShiftColorTo
                       (
                       sourceColor: QuestionLabelBox.BackgroundColor,
                       targetColor: Color.FromRgb(47, 79, 79),
                       setter: color =>
                       {
                           QuestionLabelBox.BackgroundColor = color;

                       },
                       length: 500,
                       easing: Easing.CubicOut);
                    //
                   
                    await QuestionImage.FadeTo(0, 500);

                    QuestionImage.Source = Global.ShuffledQuestion[i, 1];
                    
                    QuestionImage.FadeTo(0.5, 700);
                    CorrectButton.IsEnabled = true;
                    SkipButton.IsEnabled = true;
                    VolumeButtonsActive();

                }
                
                //if (i < 10)
                //{
                //    QuestionLabel.Text = Global.ShuffledQuestion[i, 0];
                //    CorrectButton.IsEnabled = false;
                //    SkipButton.IsEnabled = false;
                //    VolumeButtonsDisabled();
                //    await QuestionImage.FadeTo(0, 1000);
                //    QuestionImage.Source = Global.ShuffledQuestion[i, 1];
                //    QuestionImage.FadeTo(0.2, 1000);
                //    CorrectButton.IsEnabled = true;
                //    SkipButton.IsEnabled = true;
                //    VolumeButtonsActive();

                //}
                else
                {
                    GameOver();
                }
            }
            else
            {//Skipping
                Make_some_Skip_sounds.SkipSoundPlay();
                Global.IsCorrect[i] = 0;
                Global.IsGuessed[i] = 1;
                i++;
                if (i < Global.QuestionQuantity)
                {
                    CorrectButton.IsEnabled = false;
                    SkipButton.IsEnabled = false;
                    VolumeButtonsDisabled();
                    //extension color in

                    QuestionLabelBox.ShiftColorTo
                       (
                       sourceColor: QuestionLabelBox.BackgroundColor,
                       targetColor: Color.FromRgb(255, 0, 51),
                       setter: color =>
                       {
                           QuestionLabelBox.BackgroundColor = color;

                       },
                       length: 500,
                       easing: Easing.CubicOut);
                    //
                    await SkipFlash.FadeTo(0.2,500, Easing.CubicOut);
                    QuestionLabel.Text = Global.ShuffledQuestion[i, 0];
                    SkipFlash.FadeTo(0, 500, Easing.CubicOut);
                    //extension color out

                    QuestionLabelBox.ShiftColorTo
                       (
                       sourceColor: QuestionLabelBox.BackgroundColor,
                       targetColor: Color.FromRgb(47, 79, 79),
                       setter: color =>
                       {
                           QuestionLabelBox.BackgroundColor = color;

                       },
                       length: 500,
                       easing: Easing.CubicOut);
                    //


                    await QuestionImage.FadeTo(0, 500);
                    QuestionImage.Source = Global.ShuffledQuestion[i, 1];
                    QuestionImage.FadeTo(0.3, 700);
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
            Global.CountDownTimeIsRunning = true;
            if (Global.CountDownTime <= 180)
            { 
                TimerLabel.IsVisible = true;
                for (int _second = Global.CountDownTime; _second >= 0; _second--)
                 {
                    if (Global.CountDownTimeIsRunning)
                    {

                   
                        TimerLabel.Text = Convert.ToString(_second);
                        await Task.Delay(1000);

                         if(_second == 0)
                         {
                                GameOver();
                         }

                    }
                    else
                    {
                        break;
                    }
                   
                }
                 
            }

        }



    }
    }


//var animateExpand = new Animation(d => QuestionLabelBox.HeightRequest = d, 50, 80, Easing.SpringIn);              //working animation
//animateExpand.Commit(QuestionLabelBox, "BarGraph", 16, 3500);



                                                    //Working extension
//            QuestionImage.FadeTo(0.3, 700);
//            QuestionImage.Source = Global.ShuffledQuestion[i, 1];
//            QuestionLabel.Text = Global.ShuffledQuestion[i, 0];

//            QuestionLabel.ShiftColorTo
//               (
//               sourceColor: QuestionLabel.TextColor,
//               targetColor: Color.FromRgb(80, 200, 120),
//               setter: color =>
//               {
//                   QuestionLabel.TextColor = color;

//               },
//               length: 2750,
//               easing: Easing.CubicOut);