using SQLite;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace IsThis
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public class Saved_Settings
        {
            [SQLite.PrimaryKey, SQLite.AutoIncrement]
            public int StaticId { get; set; }
            public int Saved_Quantity { get; set; }
            public int Saved_Time { get; set; }
        }

        public Settings()
        {
            InitializeComponent();
           

        }





        protected override void OnAppearing()
        {
            TimeStepper.Value = Global.CountDownTime;
            TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            TimeStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);

            Questiontepper.Value = Global.QuestionQuantity;
            QuestionStepperLabel.Text = String.Format("{0} klausimų", Global.QuestionQuantity);
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
            var Save_TO_DB = new Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = Global.QuestionQuantity,
                Saved_Time = Global.CountDownTime,
                

            };
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(Save_TO_DB);
            
        }
        //Question stepper--------------------------------------------------------------------------
        private async void Questiontepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.QuestionQuantity = Convert.ToInt32(Questiontepper.Value);
            QuestionStepperLabel.Text = String.Format("{0} klausimų", Global.QuestionQuantity);
       ///////////////////////////////////////////////////////////////////////////////////////////////Saving to DB
            var Save_TO_DB = new Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = Global.QuestionQuantity,
                Saved_Time = Global.CountDownTime,
                

            };
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(Save_TO_DB);
        }
    }
       
}
