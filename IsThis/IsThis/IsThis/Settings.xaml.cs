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
            public int IsTimerOn { get; set; }
        }

        public Settings()
        {
            InitializeComponent();
           
            Setup_setting_numbers();
            
        }


        private void Setup_setting_numbers()
        {
            
            if (Global.CountDownTimeIsOn == 1)
            {
                TimeSwitch.IsToggled = true;
            }
            else
            {
                TimeSwitch.IsToggled = false;
            }
            TimeStepper.Value = Global.CountDownTime;
            TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            TimeStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);

            Questiontepper.Value = Global.QuestionQuantity;
            QuestionStepperLabel.Text = String.Format("{0} klausimų", Global.QuestionQuantity);
            QuestionStepperLabel.TextColor = Color.FromHex(Global.ButtonBackColor);
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            if(Global.CountDownTimeIsOn == 1)
            {
                Global.CountDownTimeIsOn = 0;
                TimeStepper.IsEnabled = false;
                TimeStepperLabel.Text = "∞ sec";
            }
            else
            {
                Global.CountDownTimeIsOn = 1;
                TimeStepper.IsEnabled = true;
                TimeStepperLabel.Text = TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
        }

        private async void TimeStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.CountDownTime = Convert.ToInt32(TimeStepper.Value);
            TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);

            var TimeStepper_Change = new Saved_Settings()
            {
                StaticId = 1,
                Saved_Time = Global.CountDownTime,
                
            };
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(TimeStepper_Change);
        }

        private void Questiontepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.QuestionQuantity = Convert.ToInt32(Questiontepper.Value);
            QuestionStepperLabel.Text = String.Format("{0} klausimų", Global.QuestionQuantity);
        }
    }
       
}
