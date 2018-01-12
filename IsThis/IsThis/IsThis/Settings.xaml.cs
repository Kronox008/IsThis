﻿using SQLite;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace IsThis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        //public class Saved_Settings
        //{
        //    [SQLite.PrimaryKey, SQLite.AutoIncrement]
        //    public int StaticId { get; set; }
        //    public int Saved_Quantity { get; set; }
        //    public int Saved_Time { get; set; }
        //}


        public Settings()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }





        protected override void OnAppearing()
        {

            TimeStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);
            TimeStepper.Value = Global.CountDownTime;

            if (Global.CountDownTime <= 180)
            {
                TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
            else
            {
                TimeStepperLabel.Text = "∞ sec";
            }
         
            

            Questiontepper.Value = Global.QuestionQuantity;
            QuestionStepperLabel.Text = String.Format("{0} {1}", Global.QuestionQuantity, Global.QuestionslabelText);
            QuestionStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);


            //if (Global.CountDownTimeIsOn == 1)
            //{
            //    TimeSwitch.IsToggled = true;
            //    TimeStepper.IsEnabled = true;
            //}
            //else
            //{
            //    TimeSwitch.IsToggled = false;
            //    TimeStepper.IsEnabled = false;
            //    TimeStepperLabel.Text = "∞ sec";
            //}


            base.OnAppearing();
        }

        


        //Time Switch---------------------------------------------------------------------------
        //private async void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        //{
        //    if(Global.CountDownTimeIsOn == 1)
        //    {
        //        Global.CountDownTimeIsOn = 0;
        //        TimeStepper.IsEnabled = false;
                
        //        TimeStepperLabel.Text = "∞ sec";
        //    }
        //    else
        //    {
        //        Global.CountDownTimeIsOn = 1;
               
        //        TimeStepper.IsEnabled = true;
        //        TimeStepperLabel.Text = TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
        //    }
            ///////////////////////////////////////////////////////////////////////////////////////////////Saving to DB
        //    var Save_TO_DB = new Saved_Settings()
        //    {
        //        StaticId = 1,
        //        Saved_Quantity = Global.QuestionQuantity,
        //        Saved_Time = Global.CountDownTime,
        //        IsTimerOn = Global.CountDownTimeIsOn,



        //    };
        //    _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        //    await _connection.UpdateAsync(Save_TO_DB);
        //}




        //Time stepper---------------------------------------------------------------------------
        private async void TimeStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.CountDownTime = Convert.ToInt32(TimeStepper.Value);
            if (Global.CountDownTime <= 180)
            { 
            TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
            else
            {
                TimeStepperLabel.Text = "∞ sec";
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////Saving to DB
            var Save_TO_DB = new GameSelectionPage.Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = Global.QuestionQuantity,
                Saved_Time = Global.CountDownTime,
                LanguageId = Global.LanguageSelectedID,
                

            };

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(Save_TO_DB);
            
        }
        //Question stepper--------------------------------------------------------------------------
        private async void Questiontepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.QuestionQuantity = Convert.ToInt32(Questiontepper.Value);
            QuestionStepperLabel.Text = String.Format("{0} {1}", Global.QuestionQuantity, Global.QuestionslabelText);

            ///////////////////////////////////////////////////////////////////////////////////////////////Saving to DB
            var Save_TO_DB = new GameSelectionPage.Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = Global.QuestionQuantity,
                Saved_Time = Global.CountDownTime,
                LanguageId = Global.LanguageSelectedID,

            };
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(Save_TO_DB);
        }
    }
       
}
